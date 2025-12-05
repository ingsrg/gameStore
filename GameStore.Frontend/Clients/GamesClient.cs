using System;
using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class GamesClient
{
private readonly List<GameSummary> games = [
        new(){
            Id = 1,
            Name = "Street Fighter",
            Genre = "fighting",
            Price = 19.00M,
            ReleaseDate = new DateOnly(1992, 7, 15)
        },
        new(){
            Id = 2,
            Name = "Final Fantasy XV",
            Genre = "roleplaying",
            Price = 59.00M,
            ReleaseDate = new DateOnly(2010, 9, 30)
        },
        new(){
            Id = 3,
            Name = "Fifa 23",
            Genre = "Sports",
            Price = 69.00M,
            ReleaseDate = new DateOnly(2022, 9, 27)
        }
    ];

    public GameSummary[] GetGames() => [.. games];
}
