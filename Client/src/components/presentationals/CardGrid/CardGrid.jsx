import React from 'react';
import PropTypes from 'prop-types';
import './CardGrid.css';

const CardGrid = ({ children }) => (
  <div className="card_grid">
    { children }
  </div>
);

CardGrid.propTypes = {
  children: PropTypes.arrayOf(PropTypes.element).isRequired,
};

export default CardGrid;
