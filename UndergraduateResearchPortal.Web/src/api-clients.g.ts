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


export class LoginServiceApiClient extends ServiceApiClient<typeof $metadata.LoginService> {
  constructor() { super($metadata.LoginService) }
  public login(email: string | null, password: string | null, $config?: AxiosRequestConfig): AxiosPromise<ItemResult<void>> {
    const $method = this.$metadata.methods.login
    const $params =  {
      email,
      password,
    }
    return this.$invoke($method, $params, $config)
  }
  
  public getToken(email: string | null, password: string | null, $config?: AxiosRequestConfig): AxiosPromise<ItemResult<unknown>> {
    const $method = this.$metadata.methods.getToken
    const $params =  {
      email,
      password,
    }
    return this.$invoke($method, $params, $config)
  }
  
  public logout($config?: AxiosRequestConfig): AxiosPromise<ItemResult<void>> {
    const $method = this.$metadata.methods.logout
    const $params =  {
    }
    return this.$invoke($method, $params, $config)
  }
  
  public createAccount(firstName: string | null, lastName: string | null, email: string | null, password: string | null, $config?: AxiosRequestConfig): AxiosPromise<ItemResult<void>> {
    const $method = this.$metadata.methods.createAccount
    const $params =  {
      firstName,
      lastName,
      email,
      password,
    }
    return this.$invoke($method, $params, $config)
  }
  
  public changePassword(currentPassword: string | null, newPassword: string | null, $config?: AxiosRequestConfig): AxiosPromise<ItemResult<void>> {
    const $method = this.$metadata.methods.changePassword
    const $params =  {
      currentPassword,
      newPassword,
    }
    return this.$invoke($method, $params, $config)
  }
  
  public isLoggedIn($config?: AxiosRequestConfig): AxiosPromise<ItemResult<void>> {
    const $method = this.$metadata.methods.isLoggedIn
    const $params =  {
    }
    return this.$invoke($method, $params, $config)
  }
  
}


