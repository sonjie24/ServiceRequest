using System;
namespace AccountManagement.MicroService.Controllers.validation
{
    public interface Ivalidate<T>
    {
        bool validate(T param); 
    }
}
