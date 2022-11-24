# Deck

Librería necesaria para utilizar la baraja de cartas en los juegos 1-4

Para compilarla con mono: 

- mcs -target:library libreria.cs

Para utilizarla en los juegos, usar los comandos siguientes (ej: juego nº1):

- mcs -r:libreria.dll app1.cs
- mono app1.exe
