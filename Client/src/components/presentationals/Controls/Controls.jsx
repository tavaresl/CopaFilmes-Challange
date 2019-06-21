import React from 'react';
import PropTypes from 'prop-types';

import './Controls.css';

const Controls = ({ counter, active, onClick }) => (
  <aside className="controls">
    <div className="controls__indicator">
      <p className="controls__indicator_text">Selecionados</p>
      <p className="controls__indicator_text">
        <span className="controls__indicator_text--highlighted">{counter}</span>
        <span> de 8 filmes</span>
      </p>
    </div>
    <div className="controls__actions">
      <button type="button" className={!active ? 'controls__button controls__button--disabled' : 'controls__button'} onClick={onClick}>Gerar meu campeonato</button>
    </div>
  </aside>
);

Controls.propTypes = {
  counter: PropTypes.number.isRequired,
  active: PropTypes.bool.isRequired,
  onClick: PropTypes.func.isRequired,
};

export default Controls;
