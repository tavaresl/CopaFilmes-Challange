import React from 'react';
import './Header.css';

export default () => (
  <header className="header">
    <h1 className="header__title">Campeonato de filmes</h1>
    <p className="header__phase">Fase de seleção</p>
    <hr className="header__divider" />
    <p className="header__instructions">Selecione 8 filmes que você deseja que entrem na competição e depois pressione o botão &quot;Gerar meu campeonato&quot; para prosseguir.</p>
  </header>
);
