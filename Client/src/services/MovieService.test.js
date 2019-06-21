import MovieService from './MovieService';

test('it should resolve a list of movies', async () => {
  const movies = [
    {
      id: 'i01',
      title: 't01',
      releaseYear: 2012,
      rating: 4.0,
    },
  ];
  const httpMock = {
    get: jest.fn().mockResolvedValue({ status: 200, data: movies }),
  };
  const movieService = new MovieService(httpMock);

  expect(await movieService.getAll()).toEqual(movies);
});
