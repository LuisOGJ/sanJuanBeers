using sanJuanBeers.Models;

namespace sanJuanBeers.Repository
{
    public class BeerRepository : IRepository<Beer>
    {
        private StoreContext _Context;

        public BeerRepository(StoreContext context) {
            _Context = context;
        }

        public async Task Add(Beer beer) => await _Context.Beers.AddAsync(beer);

        public void Delete(Beer entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Beer>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Beer> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Beer entity)
        {
            throw new NotImplementedException();
        }
    }
}
