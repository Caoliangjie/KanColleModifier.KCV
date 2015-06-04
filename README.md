KanColleModifier.KCV
====================
KanColleViewer舰娘魔改插件

**插件已不再开发新功能，建议使用[KanColleCacher](https://github.com/Gizeta/KanColleCacher)替代**

使用方法
-------
* 将KanColleModifier.KCV.dll放入KanColleViewer的Plugin目录中。
* 在KanColleViewer目录中创建 “魔改.txt” 文件，并将魔改文件路径写入文件中。每个路径占用一行。
* 开启或关闭魔改功能时，需要清除对应文件的缓存。
* 使用井号(#)可以注释该行后面的所有文字。如当前一行中井号前存在路径需增加一个空格。
* 注释示例：
```
  #注释一行
  X:\sample.hack.swf #注释 
```

注：文件名格式与岛风Go魔改一致。支持 “.hack.swf” 、 “.config.ini” 与 “kcs_flash.hack.js” 。

使用库
-----
* [KanColleViewer](http://grabacr.net/kancolleviewer) - KanColleViewer使用MIT协议发布，协议文件见 MIT-LICENSE.txt 。
* [FiddlerCore](http://www.telerik.com/fiddler/fiddlercore)

协议
---
使用[DBAD协议(DON'T BE A DICK PUBLIC LICENSE)](http://www.dbad-license.org/)发布。
