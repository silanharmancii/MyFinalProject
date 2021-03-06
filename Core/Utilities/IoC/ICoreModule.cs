using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.IoC
{
    // Core gördüğünüz zaman bu bizim Framework, tüm projelerimizde kullanacağımız
    // kodları içeren yapıdır.
    public interface ICoreModule
    {
        void Load(IServiceCollection serviceCollection);
    }
}
