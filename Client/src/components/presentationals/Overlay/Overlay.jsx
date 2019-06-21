import React from 'react';
import PropTypes from 'prop-types';

import './Overlay.css';

const Overlay = ({ children }) => (
  <div className="overlay">
    {children}
  </div>
);

Overlay.propTypes = {
  children: PropTypes.arrayOf(PropTypes.element).isRequired,
};

export default Overlay;
