% genealogia.pl
% Pequena genealogia com fatos e regras para parentesco

% fatos: pai(X, Y) significa X é pai de Y
pai(joao, maria).
pai(joao, pedro).
pai(carlos, joao).
pai(carlos, ana).
pai(fernando, carlos).

% fatos: mae(X, Y) significa X é mãe de Y
mae(maria_ana, maria).
mae(maria_ana, pedro).
mae(ana_luiza, joao).
mae(ana_luiza, ana).
mae(sofia, carlos).

% regras

% pai_de(X, Y) verdadeiro se X é pai de Y
pai_de(X, Y) :- pai(X, Y).

% mae_de(X, Y) verdadeiro se X é mãe de Y
mae_de(X, Y) :- mae(X, Y).

% avo_de(X, Y) verdadeiro se X é pai ou mãe do pai ou mãe de Y
avo_de(X, Y) :- pai_de(X, Z), pai_de(Z, Y).
avo_de(X, Y) :- pai_de(X, Z), mae_de(Z, Y).
avo_de(X, Y) :- mae_de(X, Z), pai_de(Z, Y).
avo_de(X, Y) :- mae_de(X, Z), mae_de(Z, Y).

% irmao_de(X, Y) verdadeiro se X e Y compartilham pelo menos um pai ou mãe e são distintos
irmao_de(X, Y) :- pai_de(P, X), pai_de(P, Y), X \= Y.
irmao_de(X, Y) :- mae_de(M, X), mae_de(M, Y), X \= Y.
