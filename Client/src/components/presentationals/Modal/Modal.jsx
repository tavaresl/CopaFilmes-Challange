import React from 'react';
import PropTypes from 'prop-types';

import './Modal.css';

const Modal = ({ title, children, onClose }) => (
  <div className="modal">
    <div className="modal__header">
      <h3 className="modal__title">{title}</h3>
    </div>
    <div className="modal__body">
      {children}
    </div>
    <button type="button" className="modal__close_button" onClick={onClose}>x</button>
  </div>
);

Modal.propTypes = {
  title: PropTypes.string.isRequired,
  children: PropTypes.arrayOf(PropTypes.element).isRequired,
  onClose: PropTypes.func.isRequired,
};

export default Modal;
