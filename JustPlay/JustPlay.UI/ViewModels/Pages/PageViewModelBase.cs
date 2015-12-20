namespace JustPlay.UI.ViewModels.Pages
{
	using Contracts;

	public abstract class PageViewModelBase : ViewModelBase, IPageViewModel
	{
		protected readonly string title;

		protected PageViewModelBase(string title, IContentViewModel content)
		{
			this.title = title;
			this.ContentViewModel = content;
		}

		public IContentViewModel ContentViewModel { get; set; }

		public string Title
		{
			get
			{
				return this.title;
			}
		}
	}
}
