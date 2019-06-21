import React from 'react';
import axios from 'axios';

import Movies from './components/containers/Movies/Movies';
import MovieService from './services/MovieService';
import ChampionshipService from './services/ChampionshipService';

const baseURL = 'https://localhost:8081/api';

function App() {
  return (
    <Movies
      movieService={new MovieService(axios.create({ baseURL }))}
      championshipService={new ChampionshipService(axios.create({ baseURL }))}
    />
  );
}

export default App;
