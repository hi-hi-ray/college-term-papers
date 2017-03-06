RDApp.controller('appController' , function($scope,$http)

{
	$scope.page= "home";
	$scope.mostraMab= false;
	$scope.mudaPage = function(page)
	{
		if (page=="Mab")
		{
			$scope.mostraMab = true;
			$scope.$apply();
			$scope.initialize($scope.page);
		}
		else
		{
			$scope.mostraMab = false;
		}

		$scope.page = page;
	}

	//Banco de Dados, Captura do dados no JSON
	function carregaBD(url,lista){
		$http.get(url).then(function(response)
		{
			if (lista=="banheiro")
			{
				$scope.banheiros = response.data; 
			}
			else if (lista=="delegacia")
			{
				$scope.delegacias = response.data;
			}
			else if (lista=="evento")
			{
				$scope.eventos = response.data;
			}
			else if (lista=="hospital")
			{
				$scope.hospitals = response.data;
			}
			else if (lista=="come")
			{
				$scope.comes = response.data;
			}
			else if (lista=="dormi")
			{
				$scope.dormis = response.data;
			}
			else if (lista=="turist")
			{
				$scope.turists = response.data;
			}
			else if (lista=="praia")
			{
				$scope.praias = response.data;
			}
		});
	}
	carregaBD("http://demo8201453.mockable.io/banheiro","banheiro");
	carregaBD("http://demo8201453.mockable.io/delegacia","delegacia");
	carregaBD("http://demo8201453.mockable.io/eventos","evento");
	carregaBD("http://demo8201453.mockable.io/hospital","hospital");
	carregaBD("http://demo1950695.mockable.io/OndeComer","come"); //Créditos ao Aluno Paulo Leonnardo
	carregaBD("http://demo1950695.mockable.io/OndeDormir","dormi"); //Créditos ao Aluno Paulo Leonnardo
	carregaBD("http://demo8201453.mockable.io/pontos_turisticos","turist");
	carregaBD("http://demo1950695.mockable.io/Praias","praia"); //Créditos ao Aluno Paulo Leonnardo

	//mapa
	$scope.initialize = function(page) 
	{
		//for para pegar os markers dos locais, de cada página. 

		var markers = []; 
		if (page=="banheiro"){
			var n = $scope.banheiros.length;
			for(var i =0 ; i < n;i++)
			{
				var forlatlng = new google.maps.LatLng($scope.banheiros[i].latitude,$scope.banheiros[i].longitude);
				var marker = forlatlng;
				markers.push(marker);	
			}
		}
		else if (page=="delegacia")
		{
			var n = $scope.delegacias.length;
			for(var i =0 ; i < n;i++)
			{
				var forlatlng = new google.maps.LatLng($scope.delegacias[i].latitude,$scope.delegacias[i].longitude);
				var marker = forlatlng;
				markers.push(marker);	
			}
		}
		else if (page=="evento")
		{
			var n = $scope.eventos.length;
			for(var i =0 ; i < n;i++)
			{
				var forlatlng = new google.maps.LatLng($scope.eventos[i].latitude,$scope.eventos[i].longitude);
				var marker = forlatlng;
				markers.push(marker);	
			}
		}
		else if (page=="hospitais")
		{
			var n = $scope.hospitals.length;
			for(var i =0 ; i < n;i++)
			{
				var forlatlng = new google.maps.LatLng($scope.hospitals[i].latitude,$scope.hospitals[i].longitude);
				var marker = forlatlng;
				markers.push(marker);	
			}
		}
		else if (page=="comida")
		{
			var n = $scope.comes.length;
			for(var i =0 ; i < n;i++)
			{
				var forlatlng = new google.maps.LatLng($scope.comes[i].latitude,$scope.comes[i].longitude);
				var marker = forlatlng;
				markers.push(marker);	
			}
		}
		else if (page=="dormir")
		{
			var n = $scope.dormis.length;
			for(var i =0 ; i < n;i++)
			{
				var forlatlng = new google.maps.LatLng($scope.banheiros[i].latitude,$scope.banheiros[i].longitude);
				var marker = forlatlng;
				markers.push(marker);	
			}
		}
		else if (page=="pontosturi")
		{
			var n = $scope.turists.length;
			for(var i =0 ; i < n;i++)
			{
				var forlatlng = new google.maps.LatLng($scope.turists[i].latitude,$scope.turists[i].longitude);
				var marker = forlatlng;
				markers.push(marker);	
			}
		}
		else if (page=="praia")
		{
			var n = $scope.praias.length;
			for(var i =0 ; i < n;i++)
			{
				var forlatlng = new google.maps.LatLng($scope.praias[i].latitude,$scope.praias[i].longitude);
				var marker = forlatlng;
				markers.push(marker);	
			}
		}
		var mapCanvas = document.getElementById("map");
		var latlng = new google.maps.LatLng(-22.9082998,-43.1970773);
		var mapOptions = {
			center: latlng,
			zoom: 10,
			mapTypeId: google.maps.MapTypeId.ROADMAP
		}

		var map = new google.maps.Map(mapCanvas, mapOptions)
		var totalMarkers = markers.length;
		var marker;
		for (var i = 0; i < totalMarkers; i++){
			marker= new google.maps.Marker({
				position:markers[i], 
				map: map
			});
		}
	}
});
