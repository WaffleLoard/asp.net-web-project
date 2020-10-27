let board = 
	[
		[0, 1, 2],
		[3, 0, 1],
		[1, 2, 3],
	];

function createBoardDOM( data ){
	let boardDiv = document.getElementById("board");
	for(let i=0; i<data.length; i++){
		let currentRow = createRow( "r" + i );
		for(let j=0; j<data[i].length; j++){
			let currentCell = createCell(i, j, board[i][j]);
			currentRow.appendChild(currentCell);
		}
		boardDiv.appendChild(currentRow);
	}
}

function clear( id ){
	document.getElementById( id ).innerHTML = "";
}

function createRow( name ){
	let row = document.createElement("div");
	row.classList.add("row");
	row.setAttribute("id", name);
	row.setAttribute("value", name);
	return row;
}

function log( e ){
	console.log(e.value);
}

function clickRequest(board, x, y){
	//ajax here
	//clear board, recreate board on response success
}

function createCell( row, column, data ){
	let cell = document.createElement("div");
	cell.classList.add("c"+column);
	cell.classList.add("cell");
	let btn = createButton(row, column, data);
	/***change to click request as function when finished***/
	cell.appendChild(createButton(row, column, data, log));
	return cell; 
}


function createButton(row, column, data, click){
	let btn = document.createElement("BUTTON");

	btn.innerHTML = data;
	btn.setAttribute("value", row+ "-"+column);
	btn.innerHTML = data;
	
	btn.addEventListener("click", function(){click( this )})
	
	return btn;
}

createBoardDOM(board);
