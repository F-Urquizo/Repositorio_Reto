import express from "express";

import mysql from "mysql2/promise";

const app = express();

const port = 3000;

app.use(express.json())

app.listen(port, () => {
    console.log(`Listening on port ${port}`);
})

async function connectToDB() {
        return await mysql.createConnection({ 
        host: 'localhost',
        user: 'root',
        password: 'password',
        database: 'mydatabase'
    })
}

// Solicitud para obtener progreso en el juego

app.get("/api/reto/progress", async(request, response) => {

    let connection = null;

    try {
        connection = await connectToDB();
        const[results, fields] = await connection.execute("SELECT * FROM level ORDER BY level_id DESC LIMIT 1"); 

        console.log(results);
        response.status(200).json(results[0]);
    }
    catch (error) {
        response.status(500);
        response.json(error);
        console.log(error);   
    }
    finally {
        if (connection !== null)
        {
            connection.end();
            console.log("Connection closed successfully!")
        }
    }

});



// Solicitud para obtener información de una carta

app.get("/api/reto/card/:id", async (request, response) => {
    let connection = null;
  
    try {
    
      connection = await connectToDB();
  
      const [results, fields] = await connection.execute("SELECT * FROM cards WHERE card_id = req.params.id");
  
      console.log(results);
      response.status(200).json(results);
    }
    catch (error) {
      response.status(500);
      response.json(error);
      console.log(error);
    }
    finally {
      if (connection !== null) {
        connection.end();
        console.log("Connection closed succesfully!");
      }
    }
  });

// Solicitud para obtener información de mazo

app.get("/api/reto/deck/:deck_id", async (request, response) => {
  let connection = null;

  try {
  
    connection = await connectToDB();

    const [results, fields] = await connection.execute("SELECT * FROM Inventory AS i JOIN Cards AS c ON i.fk_inventory_card = c.Card_id WHERE i.fk_inventory_deck = ?", [req.params.deck_id]);

    console.log(results);
    response.status(200).json(results);
  }
  catch (error) {
    response.status(500);
    response.json(error);
    console.log(error);
  }
  finally {
    if (connection !== null) {
      connection.end();
      console.log("Connection closed succesfully!");
    }
  }
});

// Solicitud para actualizar información de nivel jugado

app.post("/api/reto/level/:id_player/:id_npc/:id_winner/:date_played", async (request, response) => {
  let connection = null;

  try {
      connection = await connectToDB();
      [results, fields] = await connection.execute("INSERT INTO level (columna_id_player, columna_id_npc, columna_id_winner, columna_date_played) VALUES (?, ?, ?, ?)", [request.params.id_player, request.params.id_npc, request.params.id_winner, request.params.date_played]);

      console.log(results);
      response.status(200).json({ message: "Level registered correctly", results: results });
  }
  catch (error) {
      console.log(error);
      response.status(500).json({ message: "Error in level registration", error: error.message });
  }
  finally {
      if (connection !== null) {
          connection.end();
          console.log("Connection closed successfully!");
      }
  }
});



// Solicitud para actualizar información de turnos dentro del nivel

app.post("/api/reto/turn/:level_id/:player_id/:hand_id/:fight_id/:duration/:turn_status/:date_time", async (request, response) => {
  let connection = null;

  try {
      connection = await connectToDB();
      [results, fields] = connection.execute("INSERT INTO level (fk_turn_level, fk_turn_player, fk_turn_hand, fk_turn_fight, duration, turn_status, date_time) VALUES(?, ?, ?, ?, ?, ?, ?)", [req.params.id_player, req.params.id_npc, req.params.id_winner, req.params.date_played]);

      console.log(results);
      response.status(200).json({ message: "Turn registered correctly", results: results });
  }
  catch (error) {
      console.log(error);
      response.status(500).json({ message: "Error in turn registration", error: error.message });
  }
  finally {
      if (connection !== null) {
          connection.end();
          console.log("Connection closed successfully!");
      }
  }
});


// Solicitud para actualizar inventario con una recompenza de nivel

// Solicitud para actualizar el mazo (borrar y añadir o actualizar nada más??)

// Solicitud para crear un mazo

// Solicitud para actualizar pila de descarte dentro del juego ???

// 