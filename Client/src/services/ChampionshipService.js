export default class ChampionshipService {
  constructor(httpClient) {
    this.http = httpClient;
  }

  async createWithMovies(movies) {
    try {
      const moviesIds = movies.map(movie => movie.id);
      const response = await this.http.post('/championships', [...moviesIds]);

      return response.data;
    } catch (err) {
      return null;
    }
  }
}
