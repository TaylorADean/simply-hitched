var imgArray = new Array();
var initialized = false;

imgArray[0] = new Image();
imgArray[0].src = '\\StyleQuizSampleImages\\wedding-1.jpg';

imgArray[1] = new Image();
imgArray[1].src = '\\StyleQuizSampleImages\\wedding-2.jpg';

imgArray[2] = new Image();
imgArray[2].src = '\\StyleQuizSampleImages\\wedding-3.jpg';

imgArray[3] = new Image();
imgArray[3].src = '\\StyleQuizSampleImages\\wedding-4.jpg';

imgArray[4] = new Image();
imgArray[4].src = '\\StyleQuizSampleImages\\wedding-5.jpg';

imgArray[5] = new Image();
imgArray[5].src = '\\StyleQuizSampleImages\\wedding-6.jpg';
/* ... more images ... */

function BlankImages() {
	hideImage('wedding1');
	hideImage('wedding2');
	hideImage('wedding3');
}

function ChangeImage() {

	// if (initialized == false) {
		// InitializeImages();
		// initialized = true;
	// }

	//logMessage("Starting change image");

	for (var i = 0; i < imgArray.length; i++)
	{
		//logMessage("Comparing " + String(imgArray[i].src))
		if(imgArray[i].src == document.getElementById('wedding').src)
		{
			document.getElementById('wedding').src = imgArray[((i+1) % imgArray.length)].src;
			//logMessage("found match" + String(i));
			break;
		}
	}
}

function logMessage(text) {
	document.getElementById("log").innerHTML = text;
}

function InitializeImages() {
	
	logMessage("Initializing");
	
	var foundImage = true;
	var index = 1;
	
	while (foundImage) {
		//Create url:
		var url = '\\StyleQuizSampleImages\\wedding-' + String(index) + '.jpg';
		if (ImageExists(url)) {
			image = new Image();
			image.src = url;
			imgArray.push(image);
			index++;
			
			logMessage("Adding image " + String(index)); 
		} else {
			foundImage = false;
		}
	}
}

function ImageExists(url) {
	
	logMessage("Checking image: " + url);
	
	var img = new Image();
	img.src = url;
	return img.height != 0;
}















// DEPRECATED

function weddingFunc1() {
	showImage('wedding1');
	hideImage('wedding2');
	hideImage('wedding3');
}

function weddingFunc2() {
	showImage('wedding2');
	hideImage('wedding1');
	hideImage('wedding3');
}

function weddingFunc3() {
	showImage('wedding3');
	hideImage('wedding1');
	hideImage('wedding2');
}

function showImage(imageId) {
	document.getElementById(imageId).style.display = 'block';
}

function hideImage(imageId) {
	document.getElementById(imageId).style.display = 'none';
}

function CycleImages() {
	if (document.getElementById("wedding1").style.display == 'block') {
		weddingFunc2();
	} else if (document.getElementById("wedding2").style.display == 'block') {
		weddingFunc3();
	} else {
		weddingFunc1();
	}
	
	TestWedding1();
}

function TestWedding1() {
	document.getElementById("log").innerHTML = "Changed logs";

	document.getElementById("log").innerHTML = String(2);
	
	var x = document.getElementById("wedding1").getAttribute("id");
	document.getElementById("log").innerHTML = String(x);
	
	if(document.getElementById("wedding1").style.display == 'block') {
		document.getElementById("log").innerHTML = 'blocking';
	} else {
		document.getElementById("log").innerHTML = 'none';
	}
}