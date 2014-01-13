using NutsAndBoltsIOC.Models;

namespace NutsAndBoltsIOC.Repository
{
    /* IRepository will be injected for each POCO
     * ]
     * Responsiblity: to be a service exposed directly to the application. Handles detailed operations before passing CRUD commands back to the repository > context.
     * This is where very specific methods that return filtered data would go.
     * 
     */

    public class ApplicationService : IApplicationService
    {
        private readonly IRepository<Foo> _fooRepository;
        private readonly IRepository<Bar> _barRepository;
        private readonly IRepository<Baz> _bazRepository;

        public ApplicationService(IRepository<Foo> fooRepository, IRepository<Bar> barRepository, IRepository<Baz> bazRepository)
        {
            _fooRepository = fooRepository;
            _barRepository = barRepository;
            _bazRepository = bazRepository;
        }

        public string DisplayFoo()
        {
            return _fooRepository.GetSomething();
        }

        public string DisplayBar()
        {
            return _barRepository.GetSomething();
        }

        public string DisplayBaz()
        {
            return _bazRepository.GetSomething();
        }
    }
}