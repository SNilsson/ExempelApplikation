using System.Collections.Generic;
using Umea.se.ExempelApplikation.DataObjectLibrary;

namespace Umea.se.ExempelApplikation.ExtDataAccessLayer.Contracts
{
    public interface IExtpersonRepository
    {
        PersonInformation GetKompletterandePersonInfo(Person personList);
    }
}
