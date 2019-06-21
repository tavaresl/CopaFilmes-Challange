import ChampionshipService from './ChampionshipService';

test('it should resolve a created championship', async () => {
  const movies = [{
    id: 'i01',
    title: 't01',
    releaseYear: 2012,
    rating: 8.0,
  }, {
    id: 'i02',
    title: 't02',
    releaseYear: 2012,
    rating: 5.0,
  }];
  const championship = {
    champion: {
      id: 'i01',
      title: 't01',
      releaseYear: 2012,
      rating: 8.0,
    },
    runnerUp: {
      id: 'i02',
      title: 't02',
      releaseYear: 2012,
      rating: 5.0,
    },
  };
  const httpMock = {
    post: jest.fn().mockResolvedValue({ data: championship }),
  };
  const championshipService = new ChampionshipService(httpMock);

  expect(await championshipService.createWithMovies(movies)).toEqual(championship);
});
