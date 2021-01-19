define('CITACH_Client_About', function()
{
	return class extends Component
	{
		constructor()
		{
			console.log('Succesfully Loaded : CITACH_Client_About Class')

			super()
		}

		componentDidMount()
		{
			console.log('Succesfully Executed componentDidMount() : CITACH_Client_About Class')
		}

		render()
		{
			return	<div>
						<section className = 'title'>
							<div className = 'container'>
								<div className = 'row-fluid'>
									<div className = 'span6'>
										<h1>About Us</h1>
									</div>
									<div className = 'span6'>
										<ul className = 'breadcrumb pull-right'>
											<li><Link to = '/Home'>Home</Link><span className = 'divider'>/</span></li>
											<li className = 'active'>About Us</li>
										</ul>
									</div>
								</div>
							</div>
						</section>

						<section id = 'about-us' className = 'container main'>
							<div className = 'row-fluid'>

								<div className = 'span6'>
									<h1>HISTORY </h1>
									<p>In Acts 13:47, the Lord commands us, “ I have made you light for the Gentiles that you may bring salvation to the ends of the earth.” This command of winning multitude of souls for Christ marks the vision and mission of Christ is the Answer Church (CITA). This is what CITA has been carrying out since it was founded and built.
									</p>
									
									<p>After several meaningful years of spreading God’s love and salvation to the people of Malabon and even to other places, a man of God was placed to CITA to lead God’s servants and was used as instrument for the intensified realization of spreading God’s word through church planting.
									</p>

									<p>On January 31, 2006, Reverend Tomas P. Dulatas was installed as Senior Pastor of CITA by Rev. Gerry Cruz, STDC District Superintendent. This momentous event was witnessed by Rev. Anacleto Lobarbio, former STDC Superintendent and Ptra. Liza Dulatas, the lovely wife of Rev. Dulatas.  From its previous organization, CITA was reorganized by Rev. Tomas P. Dulatas on February 1, 2008 for better service and ministry expansion, all for God’s glory. The church which has been existing for a decade has grown and been blessed graciously by the Lord.
									</p>

									<p>During those formative years, growth was slow but Rev. Tomas P. Dulatas and the team carried on in the Name of the Lord. The Lord directed the church to extend its arms and reach more souls outside the church through Church Planting Program. On February 1, 2009 , the first daughter church was conceived and given birth as Christ is the Answer, Perez located in C. Perez St. Tonsuya, Malabon City. The newly born church was headed by Ptr. Benjo Gaddi, now a Reverend, and his wife Ptra. Christina Gaddi with their committed team and deacons. Since that humble beginning, the church has been blessed to have several God-driven ministers to serve the Lord.
									</p>

									<p><img src = 'Data/About/Image/Image_1.jpg' height = '250px' width = '250px' style={{'float' : 'right'}}/>
									</p>

									<p>Christ is the Answer Church never stopped to envision souls coming to God and be saved. So, its advocacy to spread the Gospel of the Lord was pursued continuously. The second daughter church was given birth again. With lots of prayers, Christ is the Answer Church-Gulayan was founded headed by Ptra. Melecia David with her Associate Pastor, Bro. Rommel Bravo and their team. As years passed, more blessings were poured out abundantly upon CITA when more churches were planted in the succeeding years.  This was a fantastic move by faith. The church was making gigantic strides until one church after another was planted. Another was born on February 1, 2010 located in Canumay East, Valenzuela City which was initially led by Ptr. Allan Antoni, and then by Ptr. Romy Sabang with his diligent wife Sis. Emma Sabang, and Associate Ptr. Noel Gonzales in 2011 onwards. Truly fired by God’s heartbeat for souls, another CITA church was planted in Dagat-dagatan, Malabon headed by the couple Pastors Henry and Fatima Sanchez.  In April 25, 2011, Ptr. Allan Antoni and his wife, Ptra. Anita Antoni had to move to Pampanga to heed to another call God has set for them- to head the church planting at San Pedro, San Simon, Pampanga.  The unstoppable move of the Holy Spirit in CITA for the realization of the Great Commission gave birth to another church on September 2, 2012 at Sitio 6 Catmon, Malabon led by Pastors Mike and Theresa Entera, and another church through Ptr. Lito Sanchez on May 5, 2013 at Dulong Hernandez, Tonsuya, Malabon, now headed by Ptr. Allan Navaroza and his team.
									</p>

									<p>With great conviction, Rev. Tomas Dulatas and the congregation reflected on the following verse of the song, “through many dangers toils and snares I have already come. Faith has brought one safe thus far, and faith shall lead me on” and the verse Revelation 3:8, “I know thy works , Behold I (GOD) have set before thee an open door and no man can shut it.”
									</p>

									<p>We prayed and prayed and prayed that God would continue to sustain us through difficult times as He had done in the past. Christ is the Answer Church sailed through turbulent waters but we kept “…looking to the hills, knowing that our help was from the Lord.” God led us by the hand every step of the way for thirty-seven (37) years.
									</p>

									<p>Christ is the Answer Church continues in its efforts to be “The Church with a Mission” and to grow for the cause of Christ. God has blessed us with numerous souls who have been won for Christ and baptized since 2007 . Many persons have also united in membership by Christian experience and reinstatement. New and reorganized groups have become part of church ministries. The Church’s Christian Worship Service is on Sundays 8:30 to 10:30 in the morning and bible classes right after it. Our church Kid’s ministry staff hold teachers’ meeting, feeding program, and outreaches. More than a dozen preachers have been given minister licenses. Men have also been added to the Board of Deacons. Women, now called Deaconess, have a new focus. Additional workers have been added to the ministries. Our team continues their outreach program and church planting. School of Ministry was founded as sharpening and education program for all the ministers and deacons as well to mentees to be future leaders of the church. Several major physical improvements have been made to the church in terms of facility and building.
									</p>

									<p>This year, CITA is moved by God to steering its wheel to intensified “INTENTIONAL DISCIPLESHIP” which is also this year’s anniversary theme, an attestation of its sincerity and passion to obey God’s mandate to “go and make disciples.” CITA’s business is to mentor, share God’s word, and disciple in leading people to CHRISTLIKENESS.
									</p>

									<p>Under the divine leadership of God through our senior pastor, Rev. Tomas Dulatas, with his heart of a shepherd, CITA continues to be an instrument in the hand of God. “ON CHRIST THE SOLID ROCK WE STAND.”
									</p>
								</div>

								<h1 style = {{ 'textAlign' : 'Center' }}>MISSION AND VISION</h1>
								
								<div>
									<br/>
									<img src = 'Data/About/Image/Image_2.jpg' height = '600px' width = '600px'/>
									<hr/>

									<div className = 'span6'>
										<h3>16 Fundamental Truths</h3>
										<div className = 'accordion' id = 'accordion2'>

											<div className = 'accordion-group'>
												<div className = 'accordion-heading'>
													<a className = 'accordion-toggle collapsed' data-toggle = 'collapse' data-parent = '#accordion2' href = '#collapse_1' style = {{ 'color' : '#0eb8ce' }}>
														1. THE SCRIPTURES INSPIRED
													</a>
												</div>
												<div id = 'collapse_1' className = 'accordion-body collapse'>
													<div className = 'accordion-inner'>
														<div>The Scriptures, both the Old and New Testaments, are verbally inspired of God and are the revelation of God to man, the infallible, authoritative rule of faith and conduct.
															<li>2 Timothy 3:15-17<a>&nbsp;[KJV/NIV]</a></li>
															<li>1 Thessalonians 2:13<a>&nbsp;[KJV/NIV]</a></li>
															<li>2 Peter 1:21<a>&nbsp;[KJV/NIV]</a></li>
														</div>
													</div>
												</div>
											</div>

											<div className = 'accordion-group'>
												<div className = 'accordion-heading'>
													<a className = 'accordion-toggle collapsed' data-toggle = 'collapse' data-parent = '#accordion2' href = '#collapse_2' style = {{ 'color' : '#0eb8ce' }}>
														2. THE ONE TRUE GOD
													</a>
												</div>
												<div id = 'collapse_2' className = 'accordion-body collapse'>
													<div className = 'accordion-inner'>
													<div>The one true God has revealed Himself as the eternally self-existent 'I AM,' the Creator of heaven and earth and the Redeemer of mankind. He has further revealed Himself as embodying the principles of relationship and association as Father, Son and Holy Spirit.
														<li>Deuteronomy 6:4<a>&nbsp;[KJV/NIV]</a></li>
														<li>Isaiah 43:10,11<a>&nbsp;[KJV/NIV]</a></li>
														<li>Matthew 28:19<a>&nbsp;[KJV/NIV]</a></li>
														<li>Luke 3:22<a>&nbsp;[KJV/NIV]</a></li>
													</div>
													</div>
												</div>
											</div>

											<div className = 'accordion-group'>
												<div className = 'accordion-heading'>
													<a className = 'accordion-toggle collapsed' data-toggle = 'collapse' data-parent = '#accordion2' href = '#collapse_3' style = {{ 'color' : '#0eb8ce' }}>
														3. THE DEITY OF THE LORD JESUS CHRIST
													</a>
												</div>
												<div id = 'collapse_3' className = 'accordion-body collapse'>
													<div className = 'accordion-inner'>
														<div>The Lord Jesus Christ is the eternal Son of God. The Scriptures declare: 
															<br/>His virgin birth,
															<li>Matthew 1:23<a>&nbsp;[KJV/NIV]</a></li> 
															<li>Luke 1:31<a>&nbsp;[KJV/NIV]</a></li> 
															<li>Luke 1:35<a>&nbsp;[KJV/NIV]</a></li>
														</div>
													</div>
												</div>
											</div>

											<div className = 'accordion-group'>
												<div className = 'accordion-heading'>
													<a className = 'accordion-toggle collapsed' data-toggle = 'collapse' data-parent = '#accordion2' href = '#collapse_4' style = {{ 'color' : '#0eb8ce' }}>
														4. THE FALL OF MAN
													</a>
												</div>
												<div id = 'collapse_4' className = 'accordion-body collapse'>
													<div className = 'accordion-inner'>
														<div>Man was created good and upright; for God said, 'Let us make man in our own image, after our likeness.' However, man by voluntary transgression fell and thereby incurred not only physical death but also spiritual death, which is separation from God.
															<li>Genesis 1:26,27<a>&nbsp;[KJV/NIV]</a></li>
															<li>Genesis 2:17<a>&nbsp;[KJV/NIV]</a></li>
															<li>Genesis 3:6<a>&nbsp;[KJV/NIV]</a></li>
															<li>Romans 5:12-19<a>&nbsp;[KJV/NIV]</a></li>
														</div>
													</div>
												</div>
											</div>

											<div className = 'accordion-group'>
												<div className = 'accordion-heading'>
													<a className = 'accordion-toggle collapsed' data-toggle = 'collapse' data-parent = '#accordion2' href = '#collapse_5' style = {{ 'color' : '#0eb8ce' }}>
														5. THE SALVATION OF MAN
													</a>
												</div>
												<div id = 'collapse_5' className = 'accordion-body collapse'>
													<div className = 'accordion-inner'>
														<div>Man's only hope of redemption is through the shed blood of Jesus Christ the Son of God</div>
													</div>
												</div>
											</div>

											<div className = 'accordion-group'>
												<div className = 'accordion-heading'>
													<a className = 'accordion-toggle collapsed' data-toggle = 'collapse' data-parent = '#accordion2' href = '#collapse_6' style = {{ 'color' : '#0eb8ce' }}>
														6. THE ORDINANCES OF THE CHURCH
													</a>
												</div>
												<div id = 'collapse_6' className = 'accordion-body collapse'>
													<div className = 'accordion-inner'>
														<div>The ordinance of baptism by immersion is commanded by the Scriptures. All who repent and believe on Christ as Saviour and Lord are to be baptized. Thus they declare to the world that they have died with Christ and that they also have been raised with Him to walk in newness of life.
															<li>Matthew 28:19<a>&nbsp;[KJV/NIV]</a></li>
															<li>Mark 16:16<a>&nbsp;[KJV/NIV]</a></li>
															<li>Acts 10:47-48<a>&nbsp;[KJV/NIV]</a></li>
															<li>Romans 6:4<a>&nbsp;[KJV/NIV]</a></li>
														</div>
													</div>
												</div>
											</div>

											<div className = 'accordion-group'>
												<div className = 'accordion-heading'>
													<a className = 'accordion-toggle collapsed' data-toggle = 'collapse' data-parent = '#accordion2' href = '#collapse_7' style = {{ 'color' : '#0eb8ce' }}>
														7. THE BAPTISM IN THE HOLY SPIRIT
													</a>
												</div>
												<div id = 'collapse_7' className = 'accordion-body collapse'>
													<div className = 'accordion-inner'>
														<div>All believers are entitled to and should ardently expect and earnestly seek the promise of the Father, the baptism in the Holy Spirit and fire, according to the command of our Lord Jesus Christ. This was the normal experience of all in the early Christian Church. With it comes the enduement of power for life and service, the bestowment of the gifts and their uses in the work of the ministry.

															<li>Luke 24:49<a>&nbsp;[KJV/NIV]</a></li>
															<li>Acts 1:4<a>&nbsp;[KJV/NIV]</a></li>
															<li>Acts 1:8<a>&nbsp;[KJV/NIV]</a></li>
															<li>1 Corinthians 12:1-31<a>&nbsp;[KJV/NIV]</a></li>

															<ul><b>This experience is distinct from and subsequent to the experience of the new birth.</b>
															<li>Acts 8:12-17<a>&nbsp;[KJV/NIV]</a></li>
															<li>Acts 10:44-46<a>&nbsp;[KJV/NIV]</a></li>
															<li>Acts 11:14-16<a>&nbsp;[KJV/NIV]</a></li>
															<li>Acts 15:7-9<a>&nbsp;[KJV/NIV]</a></li>
															</ul>
															With the baptism in the Holy Spirit come such experiences as:

															an overflowing fullness of the Spirit, John 7:37-39<a>&nbsp;[KJV/NIV]</a>, Acts 4:8<a>&nbsp;[KJV/NIV]</a>
															a deepened reverence for God, Acts 2:43<a>&nbsp;[KJV/NIV]</a>, Hebrews 12:28 <a>&nbsp;[KJV/NIV]</a>
															an intensified consecration to God and dedication to His work, Acts 2:42<a>&nbsp;[KJV/NIV]</a>
															and a more active love for Christ, for His Word and for the lost, Mark 16:20<a>&nbsp;[KJV/NIV]</a>
														</div>
													</div>
												</div>
											</div>

											<div className = 'accordion-group'>
												<div className = 'accordion-heading'>
													<a className = 'accordion-toggle collapsed' data-toggle = 'collapse' data-parent = '#accordion2' href = '#collapse_8' style = {{ 'color' : '#0eb8ce' }}>
														8. THE INITIAL PHYSICAL EVIDENCE OF THE BAPTISM IN THE HOLY SPIRIT	
													</a>
												</div>
												<div id = 'collapse_8' className = 'accordion-body collapse'>
													<div className = 'accordion-inner'>
														<div>The baptism of believers in the Holy Spirit is witnessed by the initial physical sign of speaking with other tongues as the Spirit of God gives them utterance.
															<li>Acts 2:4<a>&nbsp;[KJV/NIV]</a></li>
															The speaking in tongues in this instance is the same in essence as the gift of tongues, but is different in purpose and use.
															<li>1 Corinthians 12:4-10<a>&nbsp;[KJV/NIV]</a></li>
															<li>1 Corinthians 12:28<a>&nbsp;[KJV/NIV]</a></li>
														</div>
													</div>
												</div>
											</div>

											<div className = 'accordion-group'>
												<div className = 'accordion-heading'>
													<a className = 'accordion-toggle collapsed' data-toggle = 'collapse' data-parent = '#accordion2' href = '#collapse_9' style = {{ 'color' : '#0eb8ce' }}>
														9. SANCTIFICATION
													</a>
												</div>
												<div id = 'collapse_9' className = 'accordion-body collapse'>
													<div className = 'accordion-inner'>
														<div>Sanctification is an act of separation from that which is evil, and of dedication unto God.
															<li>Romans 12:1-2<a>&nbsp;[KJV/NIV]</a></li>
															<li>1 Thessalonians 5:23<a>&nbsp;[KJV/NIV]</a></li>
															<li>Hebrews 13:12<a>&nbsp;[KJV/NIV]</a></li>
															The Scriptures teach a life of 'holiness without which no man shall see the Lord.'
															<li>Hebrews 12:14<a>&nbsp;[KJV/NIV]</a></li>
															By the power of the Holy Spirit we are able to obey the command: 'Be ye holy, for I am holy.'
															<li>1 Peter 1:15,16<a>&nbsp;[KJV/NIV]</a></li>
															Sanctification is realized in the believer by recognizing his identification with Christ in His death and resurrection, and by the faith reckoning daily upon the fact of that union, and by offering every faculty continually to the dominion of the Holy Spirit.
															<li>Romans 6:1-11<a>&nbsp;[KJV/NIV]</a></li>
															<li>Romans 6:13<a>&nbsp;[KJV/NIV]</a></li>
															<li>Romans 8:1,2<a>&nbsp;[KJV/NIV]</a></li>
															<li>Romans 8:13<a>&nbsp;[KJV/NIV]</a></li>
															<li>Galatians 2:20<a>&nbsp;[KJV/NIV]</a></li>
															<li>Philippians 2:12-13<a>&nbsp;[KJV/NIV]</a></li>
															<li>1 Peter 1:5<a>&nbsp;[KJV/NIV]</a></li>
														</div>
													</div>
												</div>
											</div>


											<div className = 'accordion-group'>
												<div className = 'accordion-heading'>
													<a className = 'accordion-toggle collapsed' data-toggle = 'collapse' data-parent = '#accordion2' href = '#collapse_10' style = {{ 'color' : '#0eb8ce' }}>
														10. THE CHURCH AND ITS MISSION
													</a>
												</div>
												<div id = 'collapse_10' className = 'accordion-body collapse'>
													<div className = 'accordion-inner'>
														<div>The Church is the Body of Christ, the habitation of God through the Spirit, with divine appointments for the fulfillment of her great commission. Each believer, born of the Spirit, is an integral part of the General Assembly and Church of the Firstborn, which are written in heaven.
															<li>Ephesians 1:22-23<a>&nbsp;[KJV/NIV]</a></li>
															<li>Ephesians 2:22<a>&nbsp;[KJV/NIV]</a></li>
															<li>Hebrews 12:23<a>&nbsp;[KJV/NIV]</a></li>
														</div>
													</div>
												</div>
											</div>

											<div className = 'accordion-group'>
												<div className = 'accordion-heading'>
													<a className = 'accordion-toggle collapsed' data-toggle = 'collapse' data-parent = '#accordion2' href = '#collapse_11' style = {{ 'color' : '#0eb8ce' }}>
														11. THE MINISTRY
													</a>
												</div>
												<div id = 'collapse_11' className = 'accordion-body collapse'>
													<div className = 'accordion-inner'>

														<div>A divinely called and scripturally ordained ministry has been provided by our Lord for the fourfold purpose of leading the Church in:
															Evangelization of the world.
															<li>Mark 16:15-20<a>&nbsp;[KJV/NIV]</a></li>
															Worship of God.
															<li>John 4:23-24<a>&nbsp;[KJV/NIV]</a></li>
															Building a body of saints being perfected in the image of His Son.
															<li>Ephesians 4:11-16<a>&nbsp;[KJV/NIV]</a></li>
														</div>

													</div>
												</div>
											</div>

											<div className = 'accordion-group'>
												<div className = 'accordion-heading'>
													<a className = 'accordion-toggle collapsed' data-toggle = 'collapse' data-parent = '#accordion2' href = '#collapse_12' style = {{ 'color' : '#0eb8ce' }}>
														12. DIVINE HEALING
													</a>
												</div>
												<div id = 'collapse_12' className = 'accordion-body collapse'>
													<div className = 'accordion-inner'>

														<div>Divine healing is an integral part of the gospel. Deliverance from sickness is provided for in the atonement, and is the privilege of all believers.
															<li>Isaiah 53:4-5<a>&nbsp;[KJV/NIV]</a></li>
															<li>Matthew 8:16-17<a>&nbsp;[KJV/NIV]</a></li>
															<li>James 5:14-16<a>&nbsp;[KJV/NIV]</a></li>
														</div>
													</div>
												</div>
											</div>

											<div className = 'accordion-group'>
												<div className = 'accordion-heading'>
													<a className = 'accordion-toggle collapsed' data-toggle = 'collapse' data-parent = '#accordion2' href = '#collapse_13' style = {{ 'color' : '#0eb8ce' }}>
														13. THE BLESSED HOPE
													</a>
												</div>
												<div id = 'collapse_13' className = 'accordion-body collapse'>
													<div className = 'accordion-inner'>
														<div>The resurrection of those who have fallen asleep in Christ and their translation together with those who are alive and remain unto the coming of the Lord is the imminent and blessed hope of the church.
															<li>1 Thessalonians 4:16,17<a>&nbsp;[KJV/NIV]</a></li>
															<li>Romans 8:23<a>&nbsp;[KJV/NIV]</a></li>
															<li>Titus 2:13<a>&nbsp;[KJV/NIV]</a></li>
															<li>1 Corinthians 15:51-52<a>&nbsp;[KJV/NIV]</a></li>
														</div>
													</div>
												</div>
											</div>

											<div className = 'accordion-group'>
												<div className = 'accordion-heading'>
													<a className = 'accordion-toggle collapsed' data-toggle = 'collapse' data-parent = '#accordion2' href = '#collapse_14' style = {{ 'color' : '#0eb8ce' }}>
														14. THE MILLENNIAL REIGN OF CHRIST
													</a>
												</div>
												<div id = 'collapse_14' className = 'accordion-body collapse'>
													<div className = 'accordion-inner'>
														<div>The second coming of Christ includes the rapture of the saints, which is our blessed hope, followed by the visible return of Christ with His saints to reign on earth for one thousand years.
															<li>Zechariah 14:5<a>&nbsp;[KJV/NIV]</a></li>
															<li>Matthew 24:27<a>&nbsp;[KJV/NIV]</a></li>
															<li>Matthew 24:30<a>&nbsp;[KJV/NIV]</a></li>
															<li>Revelation 1:7<a>&nbsp;[KJV/NIV]</a></li>
															<li>Revelation 19:11-14<a>&nbsp;[KJV/NIV]</a></li>
															<li>Revelation 20:1-6<a>&nbsp;[KJV/NIV]</a></li>
															This millennial reign will bring the salvation of national Israel,
															<li>Ezekiel 37:21-22<a>&nbsp;[KJV/NIV]</a></li>
															<li>Zephaniah 3:19-20<a>&nbsp;[KJV/NIV]</a></li>
															<li>Romans 11:26-27<a>&nbsp;[KJV/NIV]</a></li>
															and the establishment of universal peace.
															<li>Isaiah 11:6-9<a>&nbsp;[KJV/NIV]</a></li>
															<li>Psalms 72:3-8<a>&nbsp;[KJV/NIV]</a></li>
															<li>Micah 4:3-4<a>&nbsp;[KJV/NIV]</a></li>
														</div>
													</div>
												</div>
											</div>

											<div className = 'accordion-group'>
												<div className = 'accordion-heading'>
													<a className = 'accordion-toggle collapsed' data-toggle = 'collapse' data-parent = '#accordion2' href = '#collapse_15' style = {{ 'color' : '#0eb8ce' }}>
														15. THE FINAL JUDGMENT
													</a>
												</div>
												<div id = 'collapse_15' className = 'accordion-body collapse'>
													<div className = 'accordion-inner'>
														<div>There will be a final judgment in which the wicked dead will be raised and judged according to their works. Whosoever is not found written in the Book of Life, together with the devil and his angels, the beast and the false prophet, will be consigned to the everlasting punishment in the lake which burneth with fire and brimstone, which is the second death.
															<li>Matthew 25:46<a>&nbsp;[KJV/NIV]</a></li>
															<li>Mark 9:43-48<a>&nbsp;[KJV/NIV]</a></li>
															<li>Revelation 19:20<a>&nbsp;[KJV/NIV]</a></li>
															<li>Revelation 20:11-15<a>&nbsp;[KJV/NIV]</a></li>
															<li>Revelation 21:8<a>&nbsp;[KJV/NIV]</a></li>
														</div>
													</div>
												</div>
											</div>

											<div className = 'accordion-group'>
												<div className = 'accordion-heading'>
													<a className = 'accordion-toggle collapsed' data-toggle = 'collapse' data-parent = '#accordion2' href = '#collapse_16' style = {{ 'color' : '#0eb8ce' }}>
														16. THE NEW HEAVENS AND THE NEW EARTH
													</a>
												</div>
												<div id = 'collapse_16' className = 'accordion-body collapse'>
													<div className = 'accordion-inner'>													
														<div>'We, according to His promise, look for new heavens and a new earth wherein dwelleth righteousness.'
															<li>2 Peter 3:13<a>&nbsp;[KJV/NIV]</a></li>
															<li>Revelation 21<a>&nbsp;[KJV/NIV]</a></li>
															<li>Revelation 22<a>&nbsp;[KJV/NIV]</a></li>
														</div>
													</div>
												</div>
											</div>

											<br/>
											<button className='btn'>
												<i className='fa fa-download'></i>
												<a className='btna' href='Data\About\Document\16-FUNDAMENTALS.docx' download>
													Download Soft Copy of 16 Fundamental Truths (English)&nbsp;
												</a>
											</button>

											<hr/>
											<button className='btn'>
												<i className='fa fa-download'></i>
												<a className='btna' href='Data\About\Document\The-16-Fundamental-Truth-Tagalog-Teacher.pdf' download>
													Download Soft Copy of 16 Fundamental Truths (Tagalog)
												</a>
											</button>

										</div>
									</div>
								</div>

							</div>
						</section>
					</div>
		}
	}

})