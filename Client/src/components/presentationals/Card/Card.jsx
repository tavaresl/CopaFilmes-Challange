import React from 'react';
import PropTypes from 'prop-types';

import './Card.css';

const Card = ({ title, text, selected, disabled, onClick }) => {
  const classes = ['card'];

  if (selected) {
    classes.push('card--selected');
  } else if (disabled) {
    classes.push('card--disabled');
  }

  return (
    <div
      role="button"
      tabIndex={0}
      className={classes.join(' ')}
      onKeyPress={() => {}}
      onClick={onClick}
    >
      <h3 className="card__title">{title}</h3>
      <p className="card__text">{text}</p>
    </div>
  );
};

Card.propTypes = {
  title: PropTypes.string.isRequired,
  text: PropTypes.string.isRequired,
  selected: PropTypes.bool,
  disabled: PropTypes.bool,
  onClick: PropTypes.func,
};

Card.defaultProps = {
  selected: false,
  disabled: false,
  onClick: () => null,
};

export default Card;
