import {
  Domain, getEnumMeta, solidify, ModelType, ObjectType,
  PrimitiveProperty, ForeignKeyProperty, PrimaryKeyProperty,
  ModelCollectionNavigationProperty, ModelReferenceNavigationProperty
} from 'coalesce-vue/lib/metadata'


const domain: Domain = { enums: {}, types: {}, services: {} }
export const Application = domain.types.Application = {
  name: "Application",
  displayName: "Application",
  get displayProp() { return this.props.applicationId }, 
  type: "model",
  controllerRoute: "Application",
  get keyProp() { return this.props.applicationId }, 
  behaviorFlags: 7,
  props: {
    applicationId: {
      name: "applicationId",
      displayName: "Application Id",
      type: "string",
      role: "primaryKey",
      hidden: 3,
    },
    user: {
      name: "user",
      displayName: "User",
      type: "model",
      get typeDef() { return (domain.types.User as ModelType) },
      role: "value",
      dontSerialize: true,
    },
    preferredName: {
      name: "preferredName",
      displayName: "Preferred Name",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Preferred Name is required.",
        minLength: val => !val || val.length >= 1 || "Preferred Name must be at least 1 characters.",
        maxLength: val => !val || val.length <= 100 || "Preferred Name may not be more than 100 characters.",
      }
    },
    description: {
      name: "description",
      displayName: "Description",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Description is required.",
        minLength: val => !val || val.length >= 1 || "Description must be at least 1 characters.",
        maxLength: val => !val || val.length <= 1500 || "Description may not be more than 1500 characters.",
      }
    },
    referenceName: {
      name: "referenceName",
      displayName: "Reference Name",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Reference Name is required.",
        minLength: val => !val || val.length >= 1 || "Reference Name must be at least 1 characters.",
        maxLength: val => !val || val.length <= 50 || "Reference Name may not be more than 50 characters.",
      }
    },
    referenceEmail: {
      name: "referenceEmail",
      displayName: "Reference Email",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Reference Email is required.",
        minLength: val => !val || val.length >= 1 || "Reference Email must be at least 1 characters.",
        maxLength: val => !val || val.length <= 50 || "Reference Email may not be more than 50 characters.",
      }
    },
    approvedForInterview: {
      name: "approvedForInterview",
      displayName: "Approved For Interview",
      type: "boolean",
      role: "value",
    },
    hired: {
      name: "hired",
      displayName: "Hired",
      type: "boolean",
      role: "value",
    },
    notHired: {
      name: "notHired",
      displayName: "Not Hired",
      type: "boolean",
      role: "value",
    },
  },
  methods: {
  },
  dataSources: {
  },
}
export const Field = domain.types.Field = {
  name: "Field",
  displayName: "Field",
  get displayProp() { return this.props.name }, 
  type: "model",
  controllerRoute: "Field",
  get keyProp() { return this.props.fieldId }, 
  behaviorFlags: 7,
  props: {
    fieldId: {
      name: "fieldId",
      displayName: "Field Id",
      type: "string",
      role: "primaryKey",
      hidden: 3,
    },
    name: {
      name: "name",
      displayName: "Name",
      type: "string",
      role: "value",
      rules: {
        minLength: val => !val || val.length >= 1 || "Name must be at least 1 characters.",
        maxLength: val => !val || val.length <= 50 || "Name may not be more than 50 characters.",
      }
    },
  },
  methods: {
  },
  dataSources: {
  },
}
export const Language = domain.types.Language = {
  name: "Language",
  displayName: "Language",
  get displayProp() { return this.props.name }, 
  type: "model",
  controllerRoute: "Language",
  get keyProp() { return this.props.languageId }, 
  behaviorFlags: 7,
  props: {
    languageId: {
      name: "languageId",
      displayName: "Language Id",
      type: "string",
      role: "primaryKey",
      hidden: 3,
    },
    name: {
      name: "name",
      displayName: "Name",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Name is required.",
        minLength: val => !val || val.length >= 1 || "Name must be at least 1 characters.",
        maxLength: val => !val || val.length <= 20 || "Name may not be more than 20 characters.",
      }
    },
  },
  methods: {
  },
  dataSources: {
  },
}
export const Post = domain.types.Post = {
  name: "Post",
  displayName: "Post",
  get displayProp() { return this.props.postID }, 
  type: "model",
  controllerRoute: "Post",
  get keyProp() { return this.props.postID }, 
  behaviorFlags: 7,
  props: {
    postID: {
      name: "postID",
      displayName: "Post I D",
      type: "number",
      role: "primaryKey",
      hidden: 3,
    },
    title: {
      name: "title",
      displayName: "Title",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Title is required.",
        minLength: val => !val || val.length >= 1 || "Title must be at least 1 characters.",
        maxLength: val => !val || val.length <= 150 || "Title may not be more than 150 characters.",
      }
    },
    description: {
      name: "description",
      displayName: "Description",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Description is required.",
        minLength: val => !val || val.length >= 1 || "Description must be at least 1 characters.",
        maxLength: val => !val || val.length <= 1500 || "Description may not be more than 1500 characters.",
      }
    },
    startDate: {
      name: "startDate",
      displayName: "Start Date",
      type: "date",
      dateKind: "datetime",
      noOffset: true,
      role: "value",
      rules: {
        required: val => val != null || "Start Date is required.",
      }
    },
    endDate: {
      name: "endDate",
      displayName: "End Date",
      type: "date",
      dateKind: "datetime",
      noOffset: true,
      role: "value",
      rules: {
        required: val => val != null || "End Date is required.",
      }
    },
    timeCommitment: {
      name: "timeCommitment",
      displayName: "Time Commitment",
      type: "number",
      role: "value",
      rules: {
        required: val => val != null || "Time Commitment is required.",
      }
    },
    qualifications: {
      name: "qualifications",
      displayName: "Qualifications",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Qualifications is required.",
        minLength: val => !val || val.length >= 1 || "Qualifications must be at least 1 characters.",
        maxLength: val => !val || val.length <= 1500 || "Qualifications may not be more than 1500 characters.",
      }
    },
    user: {
      name: "user",
      displayName: "User",
      type: "model",
      get typeDef() { return (domain.types.User as ModelType) },
      role: "value",
      dontSerialize: true,
    },
    creationDate: {
      name: "creationDate",
      displayName: "Creation Date",
      type: "date",
      dateKind: "datetime",
      noOffset: true,
      role: "value",
    },
  },
  methods: {
  },
  dataSources: {
  },
}
export const User = domain.types.User = {
  name: "User",
  displayName: "User",
  get displayProp() { return this.props.name }, 
  type: "model",
  controllerRoute: "User",
  get keyProp() { return this.props.id }, 
  behaviorFlags: 7,
  props: {
    firstName: {
      name: "firstName",
      displayName: "First Name",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "First Name is required.",
        minLength: val => !val || val.length >= 1 || "First Name must be at least 1 characters.",
        maxLength: val => !val || val.length <= 100 || "First Name may not be more than 100 characters.",
      }
    },
    lastName: {
      name: "lastName",
      displayName: "Last Name",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Last Name is required.",
        minLength: val => !val || val.length >= 1 || "Last Name must be at least 1 characters.",
        maxLength: val => !val || val.length <= 100 || "Last Name may not be more than 100 characters.",
      }
    },
    wsuId: {
      name: "wsuId",
      displayName: "W S U Id",
      type: "number",
      role: "value",
      rules: {
        required: val => val != null || "W S U Id is required.",
      }
    },
    major: {
      name: "major",
      displayName: "Major",
      type: "string",
      role: "value",
      rules: {
        minLength: val => !val || val.length >= 3 || "Major must be at least 3 characters.",
        maxLength: val => !val || val.length <= 30 || "Major may not be more than 30 characters.",
      }
    },
    graduationDate: {
      name: "graduationDate",
      displayName: "Graduation Date",
      type: "string",
      role: "value",
      rules: {
        minLength: val => !val || val.length >= 1 || "Graduation Date must be at least 1 characters.",
        maxLength: val => !val || val.length <= 100 || "Graduation Date may not be more than 100 characters.",
      }
    },
    gpa: {
      name: "gpa",
      displayName: "G P A",
      type: "number",
      role: "value",
    },
    experience: {
      name: "experience",
      displayName: "Experience",
      type: "string",
      role: "value",
      rules: {
        minLength: val => !val || val.length >= 1 || "Experience must be at least 1 characters.",
        maxLength: val => !val || val.length <= 1500 || "Experience may not be more than 1500 characters.",
      }
    },
    electiveCourses: {
      name: "electiveCourses",
      displayName: "Elective Courses",
      type: "string",
      role: "value",
      rules: {
        minLength: val => !val || val.length >= 1 || "Elective Courses must be at least 1 characters.",
        maxLength: val => !val || val.length <= 1500 || "Elective Courses may not be more than 1500 characters.",
      }
    },
    name: {
      name: "name",
      displayName: "Name",
      type: "string",
      role: "value",
      dontSerialize: true,
    },
    id: {
      name: "id",
      displayName: "Id",
      type: "string",
      role: "primaryKey",
      hidden: 3,
    },
    userName: {
      name: "userName",
      displayName: "User Name",
      type: "string",
      role: "value",
    },
    normalizedUserName: {
      name: "normalizedUserName",
      displayName: "Normalized User Name",
      type: "string",
      role: "value",
    },
    email: {
      name: "email",
      displayName: "Email",
      type: "string",
      role: "value",
    },
    normalizedEmail: {
      name: "normalizedEmail",
      displayName: "Normalized Email",
      type: "string",
      role: "value",
    },
    emailConfirmed: {
      name: "emailConfirmed",
      displayName: "Email Confirmed",
      type: "boolean",
      role: "value",
    },
    passwordHash: {
      name: "passwordHash",
      displayName: "Password Hash",
      type: "string",
      role: "value",
    },
    securityStamp: {
      name: "securityStamp",
      displayName: "Security Stamp",
      type: "string",
      role: "value",
    },
    concurrencyStamp: {
      name: "concurrencyStamp",
      displayName: "Concurrency Stamp",
      type: "string",
      role: "value",
    },
    phoneNumber: {
      name: "phoneNumber",
      displayName: "Phone Number",
      type: "string",
      role: "value",
    },
    phoneNumberConfirmed: {
      name: "phoneNumberConfirmed",
      displayName: "Phone Number Confirmed",
      type: "boolean",
      role: "value",
    },
    twoFactorEnabled: {
      name: "twoFactorEnabled",
      displayName: "Two Factor Enabled",
      type: "boolean",
      role: "value",
    },
    lockoutEnd: {
      name: "lockoutEnd",
      displayName: "Lockout End",
      type: "date",
      dateKind: "datetime",
      role: "value",
    },
    lockoutEnabled: {
      name: "lockoutEnabled",
      displayName: "Lockout Enabled",
      type: "boolean",
      role: "value",
    },
    accessFailedCount: {
      name: "accessFailedCount",
      displayName: "Access Failed Count",
      type: "number",
      role: "value",
    },
  },
  methods: {
  },
  dataSources: {
  },
}

interface AppDomain extends Domain {
  enums: {
  }
  types: {
    Application: typeof Application
    Field: typeof Field
    Language: typeof Language
    Post: typeof Post
    User: typeof User
  }
  services: {
  }
}

solidify(domain)

export default domain as unknown as AppDomain
