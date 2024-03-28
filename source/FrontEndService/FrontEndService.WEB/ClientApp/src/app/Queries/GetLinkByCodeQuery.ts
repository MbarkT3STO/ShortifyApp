export class GetLinkByCodeQuery {
  public constructor(public code: string) {}
}


export class GetLinkByCodeQueryResult {
  public id                   : number
  public originalUrl          : string
  public shortUrl             : string
  public creationDateAndTime  : Date
  public expirationDateAndTime: Date
  public isActive             : boolean

  public constructor(id: number, originalUrl: string, shortUrl: string, creationDateAndTime: Date, expirationDateAndTime: Date, isActive: boolean) {
    this.id                    = id
    this.originalUrl           = originalUrl
    this.shortUrl              = shortUrl
    this.creationDateAndTime   = creationDateAndTime
    this.expirationDateAndTime = expirationDateAndTime
    this.isActive              = isActive
  }
}
