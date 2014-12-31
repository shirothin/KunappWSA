# KunappWSA

KunappWSAは、kunkokuショップメンバーズの公式アプリ
kunappのWindowsRt(ストア)版です。

Android版 : [https://play.google.com/store/apps/details?id=com.kunkoku.kunClock&hl=ja](https://play.google.com/store/apps/details?id=com.kunkoku.kunClock&hl=ja)

# インストール
Windows 向けアプリ : [http://windows.microsoft.com/ja-jp/windows/search#q=KunappWSA](
http://windows.microsoft.com/ja-jp/windows/search#q=KunappWSA)

# 概要

* Home
	* Tweetをナビゲートするキャラクタを選択します。(開発中:Ver1.00現在)
* Feed
	* Tweetをナビゲートするキャラクタを選択します。
* Tweet
	* Tweetをナビゲートするキャラクタを選択します。
* 画像サンプル（2014/12/28現在のものです）
		* ![キャプチャ画像](https://raw.github.com/shirothin/KunappWSA/master/description/KunappWSA_SS0.png)
		* ![キャプチャ画像](https://raw.github.com/shirothin/KunappWSA/master/description/KunappWSA_SS1.png)
		* ![キャプチャ画像](https://raw.github.com/shirothin/KunappWSA/master/description/KunappWSA_SS2.png)

# ビルド

* Const.csクラスの追加

	プロジェクト\C#\Shared\Commonディレクトリ内にあるConst.csをプロジェクトに追加します。
* 参照設定の追加

	パッケジマネージャーコンソールを開き、次のライブラリをNuGetで追加します。

	* CharmFlyout
	* CoreTweet

