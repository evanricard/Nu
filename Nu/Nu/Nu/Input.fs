﻿module Nu.Input
open OpenTK
open Nu.Core

/// Describes human input.
/// A serializable value type.
type [<StructuralEquality; NoComparison>] HumanInput =
    | PadInput // of ...
    | KeyboardInput // of ...
    | MouseInput // of ...

/// Describes a mouse button.
/// A serializable value type.
type [<StructuralEquality; NoComparison>] MouseButton =
    | MouseLeft
    | MouseRight
    | MouseCenter

/// Describes a mouse event.
/// A serializable value type.
type [<StructuralEquality; NoComparison>] MouseEvent =
    { Button : MouseButton
      Position : Vector2 }

type [<StructuralEquality; NoComparison>] MouseState =
    { MouseLeftDown : bool
      MouseRightDown : bool
      MouseCenterDown : bool }