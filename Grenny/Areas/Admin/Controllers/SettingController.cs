using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Ocsp;
using ServiceLayer.Services.Implementations;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.DiscountVM;
using ServiceLayer.ViewModels.AdminVM.SettingVM;
using System.Collections.Generic;
using System.Threading.Tasks;

[Area("Admin")]
public class SettingController : Controller
{
    private readonly ISettingService _settingService;

    public SettingController(ISettingService settingService)
    {
        _settingService = settingService;
    }

    public async Task<IActionResult> Index()
    {
        var settings = await _settingService.GetAllSettingsWithIdAsync();

        List<SettingVM> settingVM = new();

        foreach (var setting in settings.OrderByDescending(m => m.Id))
        {
            settingVM.Add(new SettingVM
            {
                Id = setting.Id,
                Key = setting.Key,
                Value = setting.Value
            });
        }
        return View(settingVM);
    }
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Add(SettingAddVM request)
    {
        if (!ModelState.IsValid)
        {
            return View(request);
        }

        await _settingService.AddAsync(request);

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Edit(int? id)
    {
        if (id is null) BadRequest();

        Setting setting = await _settingService.GetByIdAsync((int)id);

        if (setting == null) return NotFound();

        SettingEditVM model = new()
        {
            Key = setting.Key,
            Value = setting.Value
        };

        return View(model);
    }
    [HttpPost]
    public async Task<IActionResult> Edit(SettingEditVM request, int? id)
    {
        if (id is null)
            return BadRequest();

        var setting = await _settingService.GetByIdAsync((int)id);

        if (setting == null)
            return NotFound();

        if (!ModelState.IsValid)
        {
            return View(request);
        }

        await _settingService.EditAsync((int)id, request);

        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null) return BadRequest();

        await _settingService.DeleteAsync((int)id);
        return Ok();
    }
}
