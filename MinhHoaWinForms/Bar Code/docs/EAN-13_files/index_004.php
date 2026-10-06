/* generated javascript */
var skin = 'monobook';
var stylepath = '/skins-1.5';

/* MediaWiki:Common.js */
//<source lang="javascript">
/* Kết các đoạn mã lưu bên ngoài */

if (wgAction == "edit" || wgAction == "submit") //mã chỉ dành riêng cho trang sửa đổi
{
    importScript("MediaWiki:Common.js/edit.js")
}

// nhúng bộ gõ AVIM vào toàn bộ các skin của Wikipedia tiếng Việt
importScript("MediaWiki:ImportAVIM.js");

/* Mẹo vặt và phím tiện */

ta = new Object();
ta['ca-nstab-ch.E1.BB.A7_.C4.91.E1.BB.81'] = new Array('c', 'Xem trang chủ đề');
ta['ca-unprotect'] = new Array('=','Mở khóa trang này');
ta['ca-nomove'] = new Array('','Bạn không thể di chuyển trang này');
ta['t-print'] = new Array('','Bản đơn giản để cho dễ in ra');
ta['t-permalink'] = new Array('','Địa chỉ thường trực của phiên bản này');
ta['t-cite'] = new Array('','Chi tiết thư mục của trang này');

/* Kiểm tra một thành phần HTML đã có "class" nào đó chưa **************************************
  */
 
var hasClass = (function () {
     var reCache = {};
     return function (element, className) {
         return (reCache[className] ? reCache[className] : (reCache[className] = new RegExp("(?:\\s|^)" + className + "(?:\\s|$)"))).test(element.className);
     };
})();

/** Sửa lỗi Internet Explorer **************************************************
  *
  *  Description: Fixes IE horizontal scrollbar bug
  *  Maintainers: [[User:Tom-]]?
  */
 
if (navigator.appName == "Microsoft Internet Explorer" && document.compatMode == "CSS1Compat")
{
   var oldWidth;
   var docEl = document.documentElement;
 
   function fixIEScroll()
   {
     if (!oldWidth || docEl.clientWidth > oldWidth)
       doFixIEScroll();
     else
       setTimeout(doFixIEScroll, 1);
   
     oldWidth = docEl.clientWidth;
   }
 
   function doFixIEScroll() {
     docEl.style.overflowX = (docEl.scrollWidth - docEl.clientWidth < 4) ? "hidden" : "";
   }
 
   document.attachEvent("onreadystatechange", fixIEScroll);
   attachEvent("onresize", fixIEScroll);
}

/** Liên kết interwiki đến các bài chọn lọc ***************************************
  *
  *  Chức năng: Chuyển dấu chấm trước các liên kết liên wiki của các bài chọn lọc 
  *             thành dấu sao
  *  Người bảo trì: [[:en:User:R. Koot]]
  */
 
function LinkFA() 
{
     if ( document.getElementById( "p-lang" ) ) {
         var InterwikiLinks = document.getElementById( "p-lang" ).getElementsByTagName( "li" );
 
         for ( var i = 0; i < InterwikiLinks.length; i++ ) {
             if ( document.getElementById( InterwikiLinks[i].className + "-fa" ) ) {
                 InterwikiLinks[i].className += " FA"
                 InterwikiLinks[i].title = "Liên kết này dẫn đến bài chọn lọc.";
             }
         }
     }
}
 
addOnloadHook( LinkFA );

function LinkGA() 
{
     if ( document.getElementById( "p-lang" ) ) {
         var InterwikiLinks = document.getElementById( "p-lang" ).getElementsByTagName( "li" );
 
         for ( var i = 0; i < InterwikiLinks.length; i++ ) {
             if ( document.getElementById( InterwikiLinks[i].className + "-ga" ) ) {
                 InterwikiLinks[i].className += " GA"
                 InterwikiLinks[i].title = "Liên kết này dẫn đến bài chất lượng tốt.";
             }
         }
     }
}
addOnloadHook( LinkGA );

/*
Tạo biểu tượng trên cùng góc phải
---------------
 
Tìm các hình thuộc class="right-uppermost image" rồi xếp chúng trên thanh tiêu đề
của trang, sau khi tính toán sắp xếp vị trí đối với các hình có sẵn.
*/
 
function rightUppermostImage() {
  var h1 = document.getElementsByTagName("h1")[0];
  var icons = document.getElementsByTagName("div");
  var icons2 = new Array();
  var j = 0;
  for (var i = 0; i < icons.length; ++i) {
    if (icons[i].className == "right-uppermost image") {
      icons2[j++] = icons[i];
    }
  }
  for (; j > 0; --j) {
    icons2[j-1].style.display = "block"; /* hủy "display:none" mặc định*/
    icons2[j-1].style.borderWidth = "1px";
    icons2[j-1].style.borderStyle = "solid";
    icons2[j-1].style.borderColor = "white";
    h1.insertBefore(icons2[j-1], h1.firstChild); /* dịch chuyển */
  }
}
addOnloadHook(rightUppermostImage);

/** Bảng ẩn/hiện *********************************************************
  *
  *  Chức năng: Cho phép tiêu bản có thể ẩn đi lại, chỉ hiện tiêu đề. Xem
  *               [[Wikipedia:NavFrame]].
  *  Người bảo trì: [[:en:User:R. Koot]]
  */
 
var autoCollapse = 2;
var collapseCaption = "ẩn";
var expandCaption = "hiện";
 
function collapseTable( tableIndex )
{
     var Button = document.getElementById( "collapseButton" + tableIndex );
     var Table = document.getElementById( "collapsibleTable" + tableIndex );
 
     if ( !Table || !Button ) {
         return false;
     }
 
     var Rows = Table.getElementsByTagName( "tr" ); 
 
     if ( Button.firstChild.data == collapseCaption ) {
         for ( var i = 1; i < Rows.length; i++ ) {
             Rows[i].style.display = "none";
         }
         Button.firstChild.data = expandCaption;
     } else {
         for ( var i = 1; i < Rows.length; i++ ) {
             Rows[i].style.display = Rows[0].style.display;
         }
         Button.firstChild.data = collapseCaption;
     }
}
 
function createCollapseButtons()
{
     var tableIndex = 0;
     var NavigationBoxes = new Object();
     var Tables = document.getElementsByTagName( "table" );
 
     for ( var i = 0; i < Tables.length; i++ ) {
         if ( hasClass( Tables[i], "collapsible" ) ) {
             NavigationBoxes[ tableIndex ] = Tables[i];
             Tables[i].setAttribute( "id", "collapsibleTable" + tableIndex );
 
             var Button     = document.createElement( "span" );
             var ButtonLink = document.createElement( "a" );
             var ButtonText = document.createTextNode( collapseCaption );
 
             Button.style.styleFloat = "right";
             Button.style.cssFloat = "right";
             Button.style.fontWeight = "normal";
             Button.style.textAlign = "right";
             Button.style.width = "6em";
 
             ButtonLink.setAttribute( "id", "collapseButton" + tableIndex );
             ButtonLink.setAttribute( "href", "javascript:collapseTable(" + tableIndex + ");" );
             ButtonLink.appendChild( ButtonText );
 
             Button.appendChild( document.createTextNode( "[" ) );
             Button.appendChild( ButtonLink );
             Button.appendChild( document.createTextNode( "]" ) );
 
             var Header = Tables[i].getElementsByTagName( "tr" )[0].getElementsByTagName( "th" )[0];
             /* only add button and increment count if there is a header row to work with */
             if (Header) {
                 Header.insertBefore( Button, Header.childNodes[0] );
                 tableIndex++;
             }
         }
     }
 
     for ( var i = 0;  i < tableIndex; i++ ) {
         if ( hasClass( NavigationBoxes[i], "collapsed" ) || ( tableIndex >= autoCollapse && hasClass( NavigationBoxes[i], "autocollapse" ) ) ) {
             collapseTable( i );
         }
     }
}
 
addOnloadHook( createCollapseButtons );

  /** Dynamic Navigation Bars (thử nghiệm) *************************************
  *
  *  Chức năng: See [[Wikipedia:NavFrame]].
  *  Người bảo trì: 
  */
 
  // set up the words in your language
  var NavigationBarHide = '[' + collapseCaption + ']';
  var NavigationBarShow = '[' + expandCaption + ']';
 

  // shows and hides content and picture (if available) of navigation bars
  // Parameters:
  //     indexNavigationBar: the index of navigation bar to be toggled
  function toggleNavigationBar(indexNavigationBar)
  {
     var NavToggle = document.getElementById("NavToggle" + indexNavigationBar);
     var NavFrame = document.getElementById("NavFrame" + indexNavigationBar);
 
     if (!NavFrame || !NavToggle) {
         return false;
     }
 
     // if shown now
     if (NavToggle.firstChild.data == NavigationBarHide) {
         for (
                 var NavChild = NavFrame.firstChild;
                 NavChild != null;
                 NavChild = NavChild.nextSibling
             ) {
             if ( hasClass( NavChild, 'NavPic' ) ) {
                 NavChild.style.display = 'none';
             }
             if ( hasClass( NavChild, 'NavContent') ) {
                 NavChild.style.display = 'none';
             }
         }
     NavToggle.firstChild.data = NavigationBarShow;
 
     // if hidden now
     } else if (NavToggle.firstChild.data == NavigationBarShow) {
         for (
                 var NavChild = NavFrame.firstChild;
                 NavChild != null;
                 NavChild = NavChild.nextSibling
             ) {
             if (hasClass(NavChild, 'NavPic')) {
                 NavChild.style.display = 'block';
             }
             if (hasClass(NavChild, 'NavContent')) {
                 NavChild.style.display = 'block';
             }
         }
     NavToggle.firstChild.data = NavigationBarHide;
     }
  }
 
  // adds show/hide-button to navigation bars
  function createNavigationBarToggleButton()
  {
     var indexNavigationBar = 0;
     // iterate over all < div >-elements 
     var divs = document.getElementsByTagName("div");
     for(
             var i=0; 
             NavFrame = divs[i]; 
             i++
         ) {
         // if found a navigation bar
         if (hasClass(NavFrame, "NavFrame")) {
 
             indexNavigationBar++;
             var NavToggle = document.createElement("a");
             NavToggle.className = 'NavToggle';
             NavToggle.setAttribute('id', 'NavToggle' + indexNavigationBar);
             NavToggle.setAttribute('href', 'javascript:toggleNavigationBar(' + indexNavigationBar + ');');
 
             var NavToggleText = document.createTextNode(NavigationBarHide);
             for (
                  var NavChild = NavFrame.firstChild;
                  NavChild != null;
                  NavChild = NavChild.nextSibling
                 ) {
                 if ( hasClass( NavChild, 'NavPic' ) || hasClass( NavChild, 'NavContent' ) ) {
                     if (NavChild.style.display == 'none') {
                         NavToggleText = document.createTextNode(NavigationBarShow);
                         break;
                     }
                 }
             }
             NavToggle.appendChild(NavToggleText);
             // Find the NavHead and attach the toggle link (Must be this complicated because Moz's firstChild handling is borked)
             for(
               var j=0; 
               j < NavFrame.childNodes.length; 
               j++
             ) {
               if (hasClass(NavFrame.childNodes[j], "NavHead")) {
                 NavFrame.childNodes[j].appendChild(NavToggle);
               }
             }
             NavFrame.setAttribute('id', 'NavFrame' + indexNavigationBar);
         }
     }
 
  }
 
  addOnloadHook( createNavigationBarToggleButton );

/** Viết lại tựa bài và bỏ dòng "Hạn chế kỹ thuật" khi hiển thị một số tựa bài ***************************************
 
Hàm dước tiêu bản {{tựa sai}} sử dụng
 
Hàm này tìm 
<div id="RealTitleBanner">
  <span id="RealTitle">titre</span>
</div>
 
Nếu có thành phần id="DisableRealTitle" thì tắt hàm
*/
function rewritePageH1() {
  var realTitleBanner = document.getElementById('RealTitleBanner');
  if (realTitleBanner) {
    if (!document.getElementById('DisableRealTitle')) {
      var realTitle = document.getElementById('RealTitle');
      var h1 = document.getElementsByTagName('h1')[0];
      if (realTitle && h1) {
        var titleText = realTitle.innerHTML;
        if (titleText == '') h1.style.display = 'none';
        else h1.innerHTML = titleText;
        realTitleBanner.style.display = 'none';
      }
    }
  }
}
addOnloadHook(rewritePageH1);

/* Configuration for [[:en:User:Pilaf/Live Preview|Live Preview]] */

var wpLanguageCode = 'vi';
var wpImageBasePath = 'http://upload.wikimedia.org/wikipedia/'+wpLanguageCode+'/';
var wpUserNamespace = 'Thành viên';
var wpImageNamespace = 'Hình';
var wpCategoryNamespace = 'Thể loại';

/*
*****Làm cho tab của Trang Chính không đề "bài viết"***********
* Chuyển từ MediaWiki:monobook.js sang đây để áp dụng cho mọi skin khác
* User:Vinhtantran, 2008/01/20
****************************************************************/
function mainpg() {
	if (wgTitle == "Trang Chính") {
		document.getElementById('ca-nstab-main').firstChild.innerHTML = 'Trang Chính';
	}
}
addOnloadHook(mainpg);

//Cố định liên kết "Tải tập tin lên"
//Đây là một cách né có thể xóa khi lỗi 10843 được sửa
addOnloadHook(function()
{
if (document.getElementById("t-upload"))
{
document.getElementById("t-upload").getElementsByTagName("a")[0].href = wgArticlePath.replace("$1", "Wikipedia:Tải tập tin lên")
}
})

/** WikiMiniAtlas *******************************************************
  *
  *  Mô tả: WikiMiniAtlas là bản đồ thế giới xuất hiện khi nhấn và kéo hình trái đất.
  *               Mã này sẽ khiến tất cả các liên kết tọa độ hiển thị nút bật ra WikiMiniAtlas.
  *               Bản thân đoạn mã nằm ở meta để dùng cho nhiều dự án.
  *               Xem [[Meta:WikiMiniAtlas]] để có thêm thông tin. 
  *  Người bảo trì: [[:en:User:Dschwen]]
  */

if (wgServer == "https://secure.wikimedia.org") {
  var metaBase = "https://secure.wikimedia.org/wikipedia/meta";
} else {
  var metaBase = "http://meta.wikimedia.org";
}
importScriptURI(metaBase+"/w/index.php?title=MediaWiki:Wikiminiatlas.js&action=raw&ctype=text/javascript&smaxage=21600&maxage=86400")

var wma_settings =
{
buttonImage: 'http://upload.wikimedia.org/wikipedia/commons/thumb/f/f3/Gnome-globe.svg/18px-Gnome-globe.svg.png'
}

/** Thêm chức năng tìm kiếm bên ngoài cho Đặc_biệt:Tìm_kiếm **************************************
* Mô tả: Sửa Đặc_biệt:Tìm_kiếm để thêm một số bộ máy tìm kiếm từ bên ngoài vào
* dưới dạng hộp thả xuống
* Tác giả : Jakob Voss, Guillaume, nhập từ Wiki tiếng Đức, Vinhtantran nhập từ Wiki tiếng Pháp
*/
 
function externalSearchEngines() {
    if (typeof SpecialSearchEnhanced2Disabled != 'undefined') return;
    if (wgPageName != "Đặc_biệt:Tìm_kiếm") return;
 
    var mainNode;
    if (document.forms["search"]) { 
        mainNode = document.forms["search"];
    } else {
        mainNode = document.getElementById("powersearch");
        if (!mainNode) return;
        var mainNode = mainNode.lastChild;
        if (!mainNode) return;
 
        while(mainNode.nodeType == 3) {
            mainNode = mainNode.previousSibling;
        }
    }
 
    var firstEngine = "mediawiki";
 
    var choices = document.createElement("div");
    choices.setAttribute("id","searchengineChoices");
    choices.style.textAlign = "center";
 
    var lsearchbox = document.getElementById("powerSearchText");
    var initValue = lsearchbox.value;
 
    var space = "";
 
    for (var id in searchEngines) {
        var engine = searchEngines[id];
        if(engine.ShortName)
        {
            if (space) choices.appendChild(space);
            space = document.createTextNode(" ");
 
            var attr = { 
                    type: "radio", 
                    name: "searchengineselect",
                    value: id,
                    onFocus: "changeSearchEngine(this.value)",
                    id: "searchengineRadio-"+id
                   };
 
            var html = "<input";
            for (var a in attr) html += " " + a + "='" + attr[a] + "'";
            html += " />";
            var span = document.createElement("span");
            span.innerHTML = html;
 
            choices.appendChild( span );
            var label = document.createElement("label");
            label.htmlFor = "searchengineRadio-"+id;
 
            label.appendChild( document.createTextNode( engine.ShortName ) );
            choices.appendChild( label );
        }
    }
    mainNode.appendChild(choices);
 
    var input = document.createElement("input");
    input.id = "searchengineextraparam";
    input.type = "hidden";
 
    mainNode.appendChild(input);
 
    changeSearchEngine(firstEngine, initValue);
}
 
function changeSearchEngine(selectedId, searchTerms) {
 
    var currentId = document.getElementById("searchengineChoices").currentChoice;
    if (selectedId == currentId) return;
 
    document.getElementById("searchengineChoices").currentChoice = selectedId;
    var radio = document.getElementById('searchengineRadio-'  + selectedId);
    radio.checked = "checked";
 
    var engine = searchEngines[selectedId];
    var p = engine.Template.indexOf('?');
    var params = engine.Template.substr(p+1);
 
    var form;
    if (document.forms["search"]) {
        form = document.forms["search"];
    } else {
        form = document.getElementById("powersearch");
    }
    form.setAttribute("action", engine.Template.substr(0,p));
 
    var l = ("" + params).split("&");
    for (var i in l) {
        var p = l[i].split("=");
        var pValue = p[1];
 
        if (pValue == "{language}") {
        } else if (pValue == "{searchTerms}") {
            var input;
            if (document.forms["search"]) {
                input = document.getElementById("searchText");
            } else {
                input = document.getElementById("powerSearchText");
            } 
 
            input.name = p[0];
        } else {
            var input = document.getElementById("searchengineextraparam");
 
            input.name = p[0];
            input.value = pValue;
        }
    }
}
if (wgPageName == "Đặc_biệt:Tìm_kiếm") {
    var searchEngines = {
                mediawiki: {
                    ShortName: "Tìm thông thường",
                    Template: "/w/index.php?search={searchTerms}"
                },
                google: {
                    ShortName: "Google",
                    Template: "http://www.google.com.vn/search?as_sitesearch=vi.wikipedia.org&hl={language}&q={searchTerms}"
                },
                wikiwix: {
                    ShortName: "Wikiwix",
                    Template: "http://vi.wikiwix.com/index.php?action={searchTerms}&lang={language}"
                },
 
                wlive: {
                    ShortName: "Windows Live",
                    Template: "http://search.live.com/results.aspx?q={searchTerms}&q1=site:http://vi.wikipedia.org"
                },
                yahoo: {
                    ShortName: "Yahoo!",
                    Template: "http://vn.search.yahoo.com/search?p={searchTerms}&vs=vi.wikipedia.org"
                }
            };
    addOnloadHook(externalSearchEngines);
} // Kết thúc mã
//</source>

/* MediaWiki:Monobook.js */
/* Đây là script được áp dụng khắp website với ngoại hình Monobook. Để áp dụng mã nguồn trong các ngoại hình khác, hãy đưa mã nguồn vào [[MediaWiki:Common.js]] thay vì vào đây.
*/