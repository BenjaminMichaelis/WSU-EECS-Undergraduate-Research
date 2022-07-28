import * as $metadata from './metadata.g'
import * as $models from './models.g'
import { AxiosClient, ModelApiClient, ServiceApiClient, ItemResult, ListResult } from 'coalesce-vue/lib/api-client'
import { AxiosPromise, AxiosResponse, AxiosRequestConfig } from 'axios'

export class ApplicationApiClient extends ModelApiClient<$models.Application> {
  constructor() { super($metadata.Application) }
}


export class FieldApiClient extends ModelApiClient<$models.Field> {
  constructor() { super($metadata.Field) }
}


export class LanguageApiClient extends ModelApiClient<$models.Language> {
  constructor() { super($metadata.Language) }
}


export class PostApiClient extends ModelApiClient<$models.Post> {
  constructor() { super($metadata.Post) }
}


export class UserApiClient extends ModelApiClient<$models.User> {
  constructor() { super($metadata.User) }
}


