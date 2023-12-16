using System;
using System.Threading.Channels;
using SoftArch_NimphiusFinalProject.Services;

namespace SoftArch_NimphiusFinalProject
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MainService _mainService = new MainService();
            _mainService.Invoke();
        }
    }
}