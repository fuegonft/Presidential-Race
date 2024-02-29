var IframePlugin = {
      jsOpenClick: function() {
      	var ovelay = document.getElementById('overlayad');
        if(ovelay) ovelay.style.display = 'block';
        var closeBut = document.getElementById('buttonClose');
        if(closeBut) closeBut.style.display = 'block';
        var countTextContain = document.getElementById('countTextContain');
        if(countTextContain) countTextContain.style.display = 'none'; 
      },

      jsOpenRewardClick: function() {
        var ovelay = document.getElementById('overlayad');
        if(ovelay) ovelay.style.display = 'block';
        var closeBut = document.getElementById('buttonClose');
        if(closeBut) closeBut.style.display = 'none';
        var countTextContain = document.getElementById('countTextContain');
        if(countTextContain) countTextContain.style.display = 'block';
      },

      jsCloseClick: function() {
      	var ovelay = document.getElementById('overlayad');
        if(ovelay) ovelay.style.display = 'none';    
        var countTextContain = document.getElementById('countTextContain');
        if(countTextContain) countTextContain.style.display = 'none';  
      },

      jsRefreshClick: function(){
      	document.getElementById('ifads').contentWindow.location.reload();
      },

      jsCountDown: function(i){
        var countText = document.getElementById('countText');
        if(countText) countText.innerHTML = i;
      }
    };
    mergeInto(LibraryManager.library, IframePlugin);