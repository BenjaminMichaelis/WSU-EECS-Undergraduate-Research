import * as $metadata from './metadata.g'
import * as $models from './models.g'
import * as $apiClients from './api-clients.g'
import { ViewModel, ListViewModel, ServiceViewModel, DeepPartial, defineProps } from 'coalesce-vue/lib/viewmodel'

export interface ApplicationViewModel extends $models.Application {
  applicationId: string | null;
  user: UserViewModel | null;
  preferredName: string | null;
  description: string | null;
  referenceName: string | null;
  referenceEmail: string | null;
  approvedForInterview: boolean | null;
  hired: boolean | null;
  notHired: boolean | null;
}
export class ApplicationViewModel extends ViewModel<$models.Application, $apiClients.ApplicationApiClient, string> implements $models.Application  {
  
  constructor(initialData?: DeepPartial<$models.Application> | null) {
    super($metadata.Application, new $apiClients.ApplicationApiClient(), initialData)
  }
}
defineProps(ApplicationViewModel, $metadata.Application)

export class ApplicationListViewModel extends ListViewModel<$models.Application, $apiClients.ApplicationApiClient, ApplicationViewModel> {
  
  constructor() {
    super($metadata.Application, new $apiClients.ApplicationApiClient())
  }
}


export interface FieldViewModel extends $models.Field {
  fieldId: string | null;
  name: string | null;
}
export class FieldViewModel extends ViewModel<$models.Field, $apiClients.FieldApiClient, string> implements $models.Field  {
  
  constructor(initialData?: DeepPartial<$models.Field> | null) {
    super($metadata.Field, new $apiClients.FieldApiClient(), initialData)
  }
}
defineProps(FieldViewModel, $metadata.Field)

export class FieldListViewModel extends ListViewModel<$models.Field, $apiClients.FieldApiClient, FieldViewModel> {
  
  constructor() {
    super($metadata.Field, new $apiClients.FieldApiClient())
  }
}


export interface LanguageViewModel extends $models.Language {
  languageId: string | null;
  name: string | null;
}
export class LanguageViewModel extends ViewModel<$models.Language, $apiClients.LanguageApiClient, string> implements $models.Language  {
  
  constructor(initialData?: DeepPartial<$models.Language> | null) {
    super($metadata.Language, new $apiClients.LanguageApiClient(), initialData)
  }
}
defineProps(LanguageViewModel, $metadata.Language)

export class LanguageListViewModel extends ListViewModel<$models.Language, $apiClients.LanguageApiClient, LanguageViewModel> {
  
  constructor() {
    super($metadata.Language, new $apiClients.LanguageApiClient())
  }
}


export interface PostViewModel extends $models.Post {
  postID: number | null;
  title: string | null;
  description: string | null;
  startDate: Date | null;
  endDate: Date | null;
  timeCommitment: number | null;
  qualifications: string | null;
  user: UserViewModel | null;
  creationDate: Date | null;
}
export class PostViewModel extends ViewModel<$models.Post, $apiClients.PostApiClient, number> implements $models.Post  {
  
  constructor(initialData?: DeepPartial<$models.Post> | null) {
    super($metadata.Post, new $apiClients.PostApiClient(), initialData)
  }
}
defineProps(PostViewModel, $metadata.Post)

export class PostListViewModel extends ListViewModel<$models.Post, $apiClients.PostApiClient, PostViewModel> {
  
  constructor() {
    super($metadata.Post, new $apiClients.PostApiClient())
  }
}


export interface UserViewModel extends $models.User {
  firstName: string | null;
  lastName: string | null;
  wsuId: number | null;
  major: string | null;
  graduationDate: string | null;
  gpa: number | null;
  experience: string | null;
  electiveCourses: string | null;
  name: string | null;
  id: string | null;
  userName: string | null;
  normalizedUserName: string | null;
  email: string | null;
  normalizedEmail: string | null;
  emailConfirmed: boolean | null;
  passwordHash: string | null;
  securityStamp: string | null;
  concurrencyStamp: string | null;
  phoneNumber: string | null;
  phoneNumberConfirmed: boolean | null;
  twoFactorEnabled: boolean | null;
  lockoutEnd: Date | null;
  lockoutEnabled: boolean | null;
  accessFailedCount: number | null;
}
export class UserViewModel extends ViewModel<$models.User, $apiClients.UserApiClient, string> implements $models.User  {
  
  constructor(initialData?: DeepPartial<$models.User> | null) {
    super($metadata.User, new $apiClients.UserApiClient(), initialData)
  }
}
defineProps(UserViewModel, $metadata.User)

export class UserListViewModel extends ListViewModel<$models.User, $apiClients.UserApiClient, UserViewModel> {
  
  constructor() {
    super($metadata.User, new $apiClients.UserApiClient())
  }
}


const viewModelTypeLookup = ViewModel.typeLookup = {
  Application: ApplicationViewModel,
  Field: FieldViewModel,
  Language: LanguageViewModel,
  Post: PostViewModel,
  User: UserViewModel,
}
const listViewModelTypeLookup = ListViewModel.typeLookup = {
  Application: ApplicationListViewModel,
  Field: FieldListViewModel,
  Language: LanguageListViewModel,
  Post: PostListViewModel,
  User: UserListViewModel,
}
const serviceViewModelTypeLookup = ServiceViewModel.typeLookup = {
}

