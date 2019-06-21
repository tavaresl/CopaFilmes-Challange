export default class MovieService {
  constructor(httpClient) {
    this.http = httpClient;
  }

  async getAll() {
    try {
      const response = await this.http.get('/movies');

      return response.data;
    } catch (err) {
      return [];
    }
  }
}
