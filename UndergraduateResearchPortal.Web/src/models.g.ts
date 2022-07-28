import * as metadata from './metadata.g'
import { Model, DataSource, convertToModel, mapToModel } from 'coalesce-vue/lib/model'

export interface Application extends Model<typeof metadata.Application> {
  applicationId: string | null
  user: User | null
  preferredName: string | null
  description: string | null
  referenceName: string | null
  referenceEmail: string | null
  approvedForInterview: boolean | null
  hired: boolean | null
  notHired: boolean | null
}
export class Application {
  
  /** Mutates the input object and its descendents into a valid Application implementation. */
  static convert(data?: Partial<Application>): Application {
    return convertToModel(data || {}, metadata.Application) 
  }
  
  /** Maps the input object and its descendents to a new, valid Application implementation. */
  static map(data?: Partial<Application>): Application {
    return mapToModel(data || {}, metadata.Application) 
  }
  
  /** Instantiate a new Application, optionally basing it on the given data. */
  constructor(data?: Partial<Application> | {[k: string]: any}) {
      Object.assign(this, Application.map(data || {}));
  }
}


export interface Field extends Model<typeof metadata.Field> {
  fieldId: string | null
  name: string | null
}
export class Field {
  
  /** Mutates the input object and its descendents into a valid Field implementation. */
  static convert(data?: Partial<Field>): Field {
    return convertToModel(data || {}, metadata.Field) 
  }
  
  /** Maps the input object and its descendents to a new, valid Field implementation. */
  static map(data?: Partial<Field>): Field {
    return mapToModel(data || {}, metadata.Field) 
  }
  
  /** Instantiate a new Field, optionally basing it on the given data. */
  constructor(data?: Partial<Field> | {[k: string]: any}) {
      Object.assign(this, Field.map(data || {}));
  }
}


export interface Language extends Model<typeof metadata.Language> {
  languageId: string | null
  name: string | null
}
export class Language {
  
  /** Mutates the input object and its descendents into a valid Language implementation. */
  static convert(data?: Partial<Language>): Language {
    return convertToModel(data || {}, metadata.Language) 
  }
  
  /** Maps the input object and its descendents to a new, valid Language implementation. */
  static map(data?: Partial<Language>): Language {
    return mapToModel(data || {}, metadata.Language) 
  }
  
  /** Instantiate a new Language, optionally basing it on the given data. */
  constructor(data?: Partial<Language> | {[k: string]: any}) {
      Object.assign(this, Language.map(data || {}));
  }
}


export interface Post extends Model<typeof metadata.Post> {
  postID: number | null
  title: string | null
  description: string | null
  startDate: Date | null
  endDate: Date | null
  timeCommitment: number | null
  qualifications: string | null
  user: User | null
  creationDate: Date | null
}
export class Post {
  
  /** Mutates the input object and its descendents into a valid Post implementation. */
  static convert(data?: Partial<Post>): Post {
    return convertToModel(data || {}, metadata.Post) 
  }
  
  /** Maps the input object and its descendents to a new, valid Post implementation. */
  static map(data?: Partial<Post>): Post {
    return mapToModel(data || {}, metadata.Post) 
  }
  
  /** Instantiate a new Post, optionally basing it on the given data. */
  constructor(data?: Partial<Post> | {[k: string]: any}) {
      Object.assign(this, Post.map(data || {}));
  }
}


export interface User extends Model<typeof metadata.User> {
  firstName: string | null
  lastName: string | null
  wsuId: number | null
  major: string | null
  graduationDate: string | null
  gpa: number | null
  experience: string | null
  electiveCourses: string | null
  name: string | null
  id: string | null
  userName: string | null
  normalizedUserName: string | null
  email: string | null
  normalizedEmail: string | null
  emailConfirmed: boolean | null
  passwordHash: string | null
  securityStamp: string | null
  concurrencyStamp: string | null
  phoneNumber: string | null
  phoneNumberConfirmed: boolean | null
  twoFactorEnabled: boolean | null
  lockoutEnd: Date | null
  lockoutEnabled: boolean | null
  accessFailedCount: number | null
}
export class User {
  
  /** Mutates the input object and its descendents into a valid User implementation. */
  static convert(data?: Partial<User>): User {
    return convertToModel(data || {}, metadata.User) 
  }
  
  /** Maps the input object and its descendents to a new, valid User implementation. */
  static map(data?: Partial<User>): User {
    return mapToModel(data || {}, metadata.User) 
  }
  
  /** Instantiate a new User, optionally basing it on the given data. */
  constructor(data?: Partial<User> | {[k: string]: any}) {
      Object.assign(this, User.map(data || {}));
  }
}


