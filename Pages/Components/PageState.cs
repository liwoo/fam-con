using FamiCon.Application.Models;

namespace FamiCon.Pages.Components;

public class PageState
{
	public User User { get; set; } = new();
	public string AppName { get; set; }
}