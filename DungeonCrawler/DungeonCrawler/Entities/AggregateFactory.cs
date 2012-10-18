﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using DungeonCrawler.Components;

namespace DungeonCrawler.Entities
{
    /// <summary>
    /// A class for quickly creating entities from pre-defined collections
    /// of components
    /// </summary>
    public class AggregateFactory
    {
        /// <summary>
        /// The game this AggregateFactory belongs to
        /// </summary>
        DungeonCrawlerGame game;

        /// <summary>
        /// Creates a new AggregateFactory instance
        /// </summary>
        /// <param name="game"></param>
        public AggregateFactory(DungeonCrawlerGame game)
        {
            this.game = game;
        }

        /// <summary>
        /// Creates Entities from aggregates (collections of components)
        /// </summary>
        /// <param name="aggregate">The specific aggreage to create</param>
        public void CreateFromAggregate(Aggregate aggregate, PlayerIndex playerIndex)
        { 
            uint entityID;
            Texture2D spriteSheet;
            Position position;
            Movement movement;
            MovementSprite movementSprite;
            Local local;
            Player player;
            HUDAggregateFactory hudagg = new HUDAggregateFactory(game);

            switch (aggregate)
            {
                case Aggregate.FairyPlayer:
                    entityID = Entity.NextEntity();
                    spriteSheet = game.Content.Load<Texture2D>("Spritesheets/wind_fae");
                    spriteSheet.Name = "Spritesheets/wind_fae";
                    
                    position = new Position()
                    {
                        EntityID = entityID,
                        Center = new Vector2(400, 50),
                        Radius = 32f,
                    };
                    game.PositionComponent[entityID] = position;
                    
                    movement = new Movement() {
                        EntityID = entityID,
                        Direction = new Vector2(0, 1),
                        Speed = 200f,
                    };
                    game.MovementComponent[entityID] = movement;
                    
                    movementSprite = new MovementSprite() {
                        EntityID = entityID,
                        Facing = Facing.South,
                        SpriteSheet = spriteSheet,
                        SpriteBounds = new Rectangle(0, 0, 64, 64),
                        Timer = 0f,
                    };
                    game.MovementSpriteComponent[entityID] = movementSprite;
                    
                    local = new Local(){
                        EntityID = entityID,
                    };
                    game.LocalComponent[entityID] = local;

                    player = new Player()
                    {
                        EntityID = entityID,
                        PlayerIndex = playerIndex,
                    };
                    game.PlayerComponent[entityID] = player;

                    hudagg.CreateHUD(player);

                    break;

                case Aggregate.CultistPlayer:
                    entityID = Entity.NextEntity();
                    spriteSheet = game.Content.Load<Texture2D>("Spritesheets/Cultist");
                    spriteSheet.Name = "Spritesheets/Cultist";
                    
                    position = new Position()
                    {
                        EntityID = entityID,
                        Center = new Vector2(400, 50),
                        Radius = 32f,
                    };
                    game.PositionComponent[entityID] = position;
                    
                    movement = new Movement() {
                        EntityID = entityID,
                        Direction = new Vector2(0, 1),
                        Speed = 200f,
                    };
                    game.MovementComponent[entityID] = movement;
                    
                    movementSprite = new MovementSprite() {
                        EntityID = entityID,
                        Facing = Facing.South,
                        SpriteSheet = spriteSheet,
                        SpriteBounds = new Rectangle(0, 0, 64, 64),
                        Timer = 0f,
                    };
                    game.MovementSpriteComponent[entityID] = movementSprite;
                    
                    local = new Local(){
                        EntityID = entityID,
                    };
                    game.LocalComponent[entityID] = local;

                    player = new Player()
                    {
                        EntityID = entityID,
                        PlayerIndex = PlayerIndex.One,
                    };
                    game.PlayerComponent[entityID] = player;

                    hudagg.CreateHUD(player);

                    break;

                case Aggregate.CyborgPlayer:
                    entityID = Entity.NextEntity();
                    spriteSheet = game.Content.Load<Texture2D>("Spritesheets/cyborg");
                    spriteSheet.Name = "Spritesheets/cyborg";
                    
                    position = new Position()
                    {
                        EntityID = entityID,
                        Center = new Vector2(400, 50),
                        Radius = 32f,
                    };
                    game.PositionComponent[entityID] = position;
                    
                    movement = new Movement() {
                        EntityID = entityID,
                        Direction = new Vector2(0, 1),
                        Speed = 200f,
                    };
                    game.MovementComponent[entityID] = movement;
                    
                    movementSprite = new MovementSprite() {
                        EntityID = entityID,
                        Facing = Facing.South,
                        SpriteSheet = spriteSheet,
                        SpriteBounds = new Rectangle(0, 0, 64, 64),
                        Timer = 0f,
                    };
                    game.MovementSpriteComponent[entityID] = movementSprite;
                    
                    local = new Local(){
                        EntityID = entityID,
                    };
                    game.LocalComponent[entityID] = local;

                    player = new Player()
                    {
                        EntityID = entityID,
                        PlayerIndex = PlayerIndex.One,
                    };
                    game.PlayerComponent[entityID] = player;
                    //create HUD
                    hudagg.CreateHUD(player);
                    break;

                case Aggregate.EarthianPlayer:

                     entityID = Entity.NextEntity();
                    spriteSheet = game.Content.Load<Texture2D>("Spritesheets/Earthian2x");
                    spriteSheet.Name = "Spritesheets/Earthian2x";
                    
                    position = new Position()
                    {
                        EntityID = entityID,
                        Center = new Vector2(400, 50),
                        Radius = 32f,
                    };
                    game.PositionComponent[entityID] = position;
                    
                    movement = new Movement() {
                        EntityID = entityID,
                        Direction = new Vector2(0, 1),
                        Speed = 200f,
                    };
                    game.MovementComponent[entityID] = movement;
                    
                    movementSprite = new MovementSprite() {
                        EntityID = entityID,
                        Facing = Facing.South,
                        SpriteSheet = spriteSheet,
                        SpriteBounds = new Rectangle(0, 0, 64, 64),
                        Timer = 0f,
                    };
                    game.MovementSpriteComponent[entityID] = movementSprite;
                    
                    local = new Local(){
                        EntityID = entityID,
                    };
                    game.LocalComponent[entityID] = local;

                    player = new Player()
                    {
                        EntityID = entityID,
                        PlayerIndex = playerIndex,
                    };
                    game.PlayerComponent[entityID] = player;
                    
                    hudagg.CreateHUD(player);
                    break;

                case Aggregate.GargranianPlayer:
                    entityID = Entity.NextEntity();
                    spriteSheet = game.Content.Load<Texture2D>("Spritesheets/gargranian");
                    spriteSheet.Name = "Spritesheets/gargranian";
                    
                    position = new Position()
                    {
                        EntityID = entityID,
                        Center = new Vector2(400, 50),
                        Radius = 32f,
                    };
                    game.PositionComponent[entityID] = position;
                    
                    movement = new Movement() {
                        EntityID = entityID,
                        Direction = new Vector2(0, 1),
                        Speed = 200f,
                    };
                    game.MovementComponent[entityID] = movement;
                    
                    movementSprite = new MovementSprite() {
                        EntityID = entityID,
                        Facing = Facing.South,
                        SpriteSheet = spriteSheet,
                        SpriteBounds = new Rectangle(0, 0, 64, 64),
                        Timer = 0f,
                    };
                    game.MovementSpriteComponent[entityID] = movementSprite;
                    
                    local = new Local(){
                        EntityID = entityID,
                    };
                    game.LocalComponent[entityID] = local;

                    player = new Player()
                    {
                        EntityID = entityID,
                        PlayerIndex = playerIndex,
                    };
                    game.PlayerComponent[entityID] = player;

                    hudagg.CreateHUD(player);
                    
                    break;

                case Aggregate.SpacePiratePlayer:
                                        entityID = Entity.NextEntity();
                    spriteSheet = game.Content.Load<Texture2D>("Spritesheets/SpacePBig");
                    spriteSheet.Name = "Spritesheets/SpacePBig";
                    
                    position = new Position()
                    {
                        EntityID = entityID,
                        Center = new Vector2(400, 50),
                        Radius = 32f,
                    };
                    game.PositionComponent[entityID] = position;
                    
                    movement = new Movement() {
                        EntityID = entityID,
                        Direction = new Vector2(0, 1),
                        Speed = 200f,
                    };
                    game.MovementComponent[entityID] = movement;
                    
                    movementSprite = new MovementSprite() {
                        EntityID = entityID,
                        Facing = Facing.South,
                        SpriteSheet = spriteSheet,
                        SpriteBounds = new Rectangle(0, 0, 64, 64),
                        Timer = 0f,
                    };
                    game.MovementSpriteComponent[entityID] = movementSprite;
                    
                    local = new Local(){
                        EntityID = entityID,
                    };
                    game.LocalComponent[entityID] = local;

                    player = new Player()
                    {
                        EntityID = entityID,
                        PlayerIndex = PlayerIndex.One,
                    };
                    game.PlayerComponent[entityID] = player;
                    //Create HUD
                    hudagg.CreateHUD(player);
                    
                    break;

                case Aggregate.ZombiePlayer:
                    entityID = Entity.NextEntity();
                    spriteSheet = game.Content.Load<Texture2D>("Spritesheets/MzombieBx2");
                    spriteSheet.Name = "Spritesheets/MzombieBx2";
                    
                    position = new Position()
                    {
                        EntityID = entityID,
                        Center = new Vector2(400, 50),
                        Radius = 32f,
                    };
                    game.PositionComponent[entityID] = position;
                    
                    movement = new Movement() {
                        EntityID = entityID,
                        Direction = new Vector2(0, 1),
                        Speed = 200f,
                    };
                    game.MovementComponent[entityID] = movement;
                    
                    movementSprite = new MovementSprite() {
                        EntityID = entityID,
                        Facing = Facing.South,
                        SpriteSheet = spriteSheet,
                        SpriteBounds = new Rectangle(0, 0, 64, 64),
                        Timer = 0f,
                    };
                    game.MovementSpriteComponent[entityID] = movementSprite;
                    
                    local = new Local(){
                        EntityID = entityID,
                    };
                    game.LocalComponent[entityID] = local;

                    player = new Player()
                    {
                        EntityID = entityID,
                        PlayerIndex = PlayerIndex.One,
                    };
                    game.PlayerComponent[entityID] = player;
                    //Create HUD
                    hudagg.CreateHUD(player);
                    break;
            }
        }
    }
}
