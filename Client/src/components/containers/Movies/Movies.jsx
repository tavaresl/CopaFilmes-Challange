import React from 'react';
import PropTypes from 'prop-types';

import './Movies.css';

import MovieService from '../../../services/MovieService';
import ChampionshipService from '../../../services/ChampionshipService';

import Header from '../../presentationals/Header/Header';
import Controls from '../../presentationals/Controls/Controls';
import CardGrid from '../../presentationals/CardGrid/CardGrid';
import Card from '../../presentationals/Card/Card';
import Overlay from '../../presentationals/Overlay/Overlay';
import Modal from '../../presentationals/Modal/Modal';

export default class Movies extends React.Component {
  constructor(props) {
    super(props);

    this.movieService = props.movieService;
    this.championshipService = props.championshipService;
    this.state = {
      selectedMovies: [],
      championship: null,
      movies: [],
    };
  }

  async componentDidMount() {
    const movies = await this.movieService.getAll();
    this.setState({ movies });
  }

  async createChampionship() {
    const { selectedMovies } = this.state;
    const championship = await this.championshipService.createWithMovies(selectedMovies);

    this.setState({ championship });
  }

  toggleMovieSelection(movie) {
    const { selectedMovies } = this.state;

    if (selectedMovies.includes(movie)) {
      this.setState({ selectedMovies: selectedMovies.filter(selected => selected !== movie) });
      return;
    }

    this.setState({ selectedMovies: [...selectedMovies, movie] });
  }

  render() {
    const { movies, selectedMovies, championship } = this.state;
    return (
      <React.Fragment>
        <div className="view_container">
          <Header />

          <Controls
            counter={selectedMovies.length}
            active={selectedMovies.length === 8}
            onClick={() => this.createChampionship()}
          />

          <CardGrid>
            {
              movies.map(movie => (
                <Card
                  key={movie.id}
                  title={movie.title}
                  text={movie.releaseYear}
                  selected={selectedMovies.includes(movie)}
                  disabled={selectedMovies.length === 8}
                  onClick={() => this.toggleMovieSelection(movie)}
                />
              ))
            }
          </CardGrid>
        </div>

        {
          !championship ? null : (
            <Overlay>
              <Modal title="Resultado final" onClose={() => this.setState({ championship: null })}>
                <Card title="Campeão" text={championship.champion.title} />
                <Card title="Vice campeão" text={championship.runnerUp.title} />
              </Modal>
            </Overlay>
          )
        }
      </React.Fragment>
    );
  }
}

Movies.propTypes = {
  movieService: PropTypes.instanceOf(MovieService).isRequired,
  championshipService: PropTypes.instanceOf(ChampionshipService).isRequired,
};
