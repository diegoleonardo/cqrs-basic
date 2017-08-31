using simple.cqrs.applicationService.DataTransferObjects;

namespace simple.cqrs.applicationService.Services
{
    public interface IPersonAplicationService
    {
        void Insert(PersonDTO person);
        void Edit(PersonDTO person);
    }
}
