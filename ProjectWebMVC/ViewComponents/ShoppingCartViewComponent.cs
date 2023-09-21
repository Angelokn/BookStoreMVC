using Microsoft.AspNetCore.Mvc;
using ProjectWeb.Repository.IRepository;
using System.Security.Claims;
using WebMVC.Utility;

namespace ProjectWeb.ViewComponents
{
    public class ShoppingCartViewComponent : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;
        public ShoppingCartViewComponent(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
