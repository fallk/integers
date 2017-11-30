using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A040785
{
public static readonly long[] Value={ 28L,1L,1L,7L,1L,1L,1L,5L,18L,1L,5L,2L,1L,1L,4L,1L,1L,2L,5L,1L,18L,5L,1L,1L,1L,7L,1L,1L,56L,1L,1L,7L,1L,1L,1L,5L,18L,1L,5L,2L,1L,1L,4L,1L,1L,2L,5L,1L,18L,5L,1L,1L,1L,7L,1L,1L,56L,1L,1L,7L,1L,1L,1L,5L,18L,1L,5L,2L,1L,1L,4L,1L,1L,2L,5L,1L,18L,5L,1L,1L,1L,7L,1L,1L,56L,1L,1L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040785Inst : IEnumerable<long>
{
public static readonly long[] Value=A040785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040785.Bytes);
public long this[int i]=>Value[i];

public static A040785Inst Instance=new A040785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040784
{
public static readonly long[] Value={ 28L,1L,1L,18L,1L,1L,56L,1L,1L,18L,1L,1L,56L,1L,1L,18L,1L,1L,56L,1L,1L,18L,1L,1L,56L,1L,1L,18L,1L,1L,56L,1L,1L,18L,1L,1L,56L,1L,1L,18L,1L,1L,56L,1L,1L,18L,1L,1L,56L,1L,1L,18L,1L,1L,56L,1L,1L,18L,1L,1L,56L,1L,1L,18L,1L,1L,56L,1L,1L,18L,1L,1L,56L,1L,1L,18L,1L,1L,56L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040784Inst : IEnumerable<long>
{
public static readonly long[] Value=A040784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040784.Bytes);
public long this[int i]=>Value[i];

public static A040784Inst Instance=new A040784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040783
{
public static readonly long[] Value={ 28L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L,2L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040783Inst : IEnumerable<long>
{
public static readonly long[] Value=A040783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040783.Bytes);
public long this[int i]=>Value[i];

public static A040783Inst Instance=new A040783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040782
{
public static readonly long[] Value={ 28L,2L,10L,1L,8L,1L,1L,2L,1L,1L,1L,3L,6L,18L,1L,4L,1L,2L,1L,27L,1L,2L,1L,4L,1L,18L,6L,3L,1L,1L,1L,2L,1L,1L,8L,1L,10L,2L,56L,2L,10L,1L,8L,1L,1L,2L,1L,1L,1L,3L,6L,18L,1L,4L,1L,2L,1L,27L,1L,2L,1L,4L,1L,18L,6L,3L,1L,1L,1L,2L,1L,1L,8L,1L,10L,2L,56L,2L,10L,1L,8L,1L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040782Inst : IEnumerable<long>
{
public static readonly long[] Value=A040782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040782.Bytes);
public long this[int i]=>Value[i];

public static A040782Inst Instance=new A040782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040781
{
public static readonly long[] Value={ 28L,2L,5L,1L,4L,1L,5L,2L,56L,2L,5L,1L,4L,1L,5L,2L,56L,2L,5L,1L,4L,1L,5L,2L,56L,2L,5L,1L,4L,1L,5L,2L,56L,2L,5L,1L,4L,1L,5L,2L,56L,2L,5L,1L,4L,1L,5L,2L,56L,2L,5L,1L,4L,1L,5L,2L,56L,2L,5L,1L,4L,1L,5L,2L,56L,2L,5L,1L,4L,1L,5L,2L,56L,2L,5L,1L,4L,1L,5L,2L,56L,2L,5L,1L,4L,1L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040781Inst : IEnumerable<long>
{
public static readonly long[] Value=A040781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040781.Bytes);
public long this[int i]=>Value[i];

public static A040781Inst Instance=new A040781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040684
{
public static readonly long[] Value={ 26L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L,52L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040684Inst : IEnumerable<long>
{
public static readonly long[] Value=A040684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040684.Bytes);
public long this[int i]=>Value[i];

public static A040684Inst Instance=new A040684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040683
{
public static readonly long[] Value={ 26L,1L,1L,1L,4L,1L,1L,1L,52L,1L,1L,1L,4L,1L,1L,1L,52L,1L,1L,1L,4L,1L,1L,1L,52L,1L,1L,1L,4L,1L,1L,1L,52L,1L,1L,1L,4L,1L,1L,1L,52L,1L,1L,1L,4L,1L,1L,1L,52L,1L,1L,1L,4L,1L,1L,1L,52L,1L,1L,1L,4L,1L,1L,1L,52L,1L,1L,1L,4L,1L,1L,1L,52L,1L,1L,1L,4L,1L,1L,1L,52L,1L,1L,1L,4L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040683Inst : IEnumerable<long>
{
public static readonly long[] Value=A040683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040683.Bytes);
public long this[int i]=>Value[i];

public static A040683Inst Instance=new A040683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040682
{
public static readonly long[] Value={ 26L,1L,1L,1L,2L,7L,4L,3L,3L,4L,7L,2L,1L,1L,1L,52L,1L,1L,1L,2L,7L,4L,3L,3L,4L,7L,2L,1L,1L,1L,52L,1L,1L,1L,2L,7L,4L,3L,3L,4L,7L,2L,1L,1L,1L,52L,1L,1L,1L,2L,7L,4L,3L,3L,4L,7L,2L,1L,1L,1L,52L,1L,1L,1L,2L,7L,4L,3L,3L,4L,7L,2L,1L,1L,1L,52L,1L,1L,1L,2L,7L,4L,3L,3L,4L,7L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040682Inst : IEnumerable<long>
{
public static readonly long[] Value=A040682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040682.Bytes);
public long this[int i]=>Value[i];

public static A040682Inst Instance=new A040682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040681
{
public static readonly long[] Value={ 26L,1L,1L,1L,1L,4L,4L,4L,1L,1L,1L,1L,52L,1L,1L,1L,1L,4L,4L,4L,1L,1L,1L,1L,52L,1L,1L,1L,1L,4L,4L,4L,1L,1L,1L,1L,52L,1L,1L,1L,1L,4L,4L,4L,1L,1L,1L,1L,52L,1L,1L,1L,1L,4L,4L,4L,1L,1L,1L,1L,52L,1L,1L,1L,1L,4L,4L,4L,1L,1L,1L,1L,52L,1L,1L,1L,1L,4L,4L,4L,1L,1L,1L,1L,52L,1L,1L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040681Inst : IEnumerable<long>
{
public static readonly long[] Value=A040681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040681.Bytes);
public long this[int i]=>Value[i];

public static A040681Inst Instance=new A040681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040680
{
public static readonly long[] Value={ 26L,1L,1L,2L,3L,2L,1L,1L,52L,1L,1L,2L,3L,2L,1L,1L,52L,1L,1L,2L,3L,2L,1L,1L,52L,1L,1L,2L,3L,2L,1L,1L,52L,1L,1L,2L,3L,2L,1L,1L,52L,1L,1L,2L,3L,2L,1L,1L,52L,1L,1L,2L,3L,2L,1L,1L,52L,1L,1L,2L,3L,2L,1L,1L,52L,1L,1L,2L,3L,2L,1L,1L,52L,1L,1L,2L,3L,2L,1L,1L,52L,1L,1L,2L,3L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040680Inst : IEnumerable<long>
{
public static readonly long[] Value=A040680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040680.Bytes);
public long this[int i]=>Value[i];

public static A040680Inst Instance=new A040680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040679
{
public static readonly long[] Value={ 26L,1L,1L,3L,26L,3L,1L,1L,52L,1L,1L,3L,26L,3L,1L,1L,52L,1L,1L,3L,26L,3L,1L,1L,52L,1L,1L,3L,26L,3L,1L,1L,52L,1L,1L,3L,26L,3L,1L,1L,52L,1L,1L,3L,26L,3L,1L,1L,52L,1L,1L,3L,26L,3L,1L,1L,52L,1L,1L,3L,26L,3L,1L,1L,52L,1L,1L,3L,26L,3L,1L,1L,52L,1L,1L,3L,26L,3L,1L,1L,52L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040679Inst : IEnumerable<long>
{
public static readonly long[] Value=A040679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040679.Bytes);
public long this[int i]=>Value[i];

public static A040679Inst Instance=new A040679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040678
{
public static readonly long[] Value={ 26L,1L,1L,4L,3L,10L,3L,4L,1L,1L,52L,1L,1L,4L,3L,10L,3L,4L,1L,1L,52L,1L,1L,4L,3L,10L,3L,4L,1L,1L,52L,1L,1L,4L,3L,10L,3L,4L,1L,1L,52L,1L,1L,4L,3L,10L,3L,4L,1L,1L,52L,1L,1L,4L,3L,10L,3L,4L,1L,1L,52L,1L,1L,4L,3L,10L,3L,4L,1L,1L,52L,1L,1L,4L,3L,10L,3L,4L,1L,1L,52L,1L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040678Inst : IEnumerable<long>
{
public static readonly long[] Value=A040678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040678.Bytes);
public long this[int i]=>Value[i];

public static A040678Inst Instance=new A040678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040677
{
public static readonly long[] Value={ 26L,1L,1L,7L,13L,7L,1L,1L,52L,1L,1L,7L,13L,7L,1L,1L,52L,1L,1L,7L,13L,7L,1L,1L,52L,1L,1L,7L,13L,7L,1L,1L,52L,1L,1L,7L,13L,7L,1L,1L,52L,1L,1L,7L,13L,7L,1L,1L,52L,1L,1L,7L,13L,7L,1L,1L,52L,1L,1L,7L,13L,7L,1L,1L,52L,1L,1L,7L,13L,7L,1L,1L,52L,1L,1L,7L,13L,7L,1L,1L,52L,1L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040677Inst : IEnumerable<long>
{
public static readonly long[] Value=A040677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040677.Bytes);
public long this[int i]=>Value[i];

public static A040677Inst Instance=new A040677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040676
{
public static readonly long[] Value={ 26L,1L,1L,17L,5L,1L,5L,17L,1L,1L,52L,1L,1L,17L,5L,1L,5L,17L,1L,1L,52L,1L,1L,17L,5L,1L,5L,17L,1L,1L,52L,1L,1L,17L,5L,1L,5L,17L,1L,1L,52L,1L,1L,17L,5L,1L,5L,17L,1L,1L,52L,1L,1L,17L,5L,1L,5L,17L,1L,1L,52L,1L,1L,17L,5L,1L,5L,17L,1L,1L,52L,1L,1L,17L,5L,1L,5L,17L,1L,1L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040676Inst : IEnumerable<long>
{
public static readonly long[] Value=A040676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040676.Bytes);
public long this[int i]=>Value[i];

public static A040676Inst Instance=new A040676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040675
{
public static readonly long[] Value={ 26L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L,2L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040675Inst : IEnumerable<long>
{
public static readonly long[] Value=A040675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040675.Bytes);
public long this[int i]=>Value[i];

public static A040675Inst Instance=new A040675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040674
{
public static readonly long[] Value={ 26L,2L,10L,10L,2L,52L,2L,10L,10L,2L,52L,2L,10L,10L,2L,52L,2L,10L,10L,2L,52L,2L,10L,10L,2L,52L,2L,10L,10L,2L,52L,2L,10L,10L,2L,52L,2L,10L,10L,2L,52L,2L,10L,10L,2L,52L,2L,10L,10L,2L,52L,2L,10L,10L,2L,52L,2L,10L,10L,2L,52L,2L,10L,10L,2L,52L,2L,10L,10L,2L,52L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040674Inst : IEnumerable<long>
{
public static readonly long[] Value=A040674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040674.Bytes);
public long this[int i]=>Value[i];

public static A040674Inst Instance=new A040674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040673
{
public static readonly long[] Value={ 26L,2L,5L,2L,1L,1L,1L,1L,12L,1L,1L,1L,1L,2L,5L,2L,52L,2L,5L,2L,1L,1L,1L,1L,12L,1L,1L,1L,1L,2L,5L,2L,52L,2L,5L,2L,1L,1L,1L,1L,12L,1L,1L,1L,1L,2L,5L,2L,52L,2L,5L,2L,1L,1L,1L,1L,12L,1L,1L,1L,1L,2L,5L,2L,52L,2L,5L,2L,1L,1L,1L,1L,12L,1L,1L,1L,1L,2L,5L,2L,52L,2L,5L,2L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040673Inst : IEnumerable<long>
{
public static readonly long[] Value=A040673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040673.Bytes);
public long this[int i]=>Value[i];

public static A040673Inst Instance=new A040673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040672
{
public static readonly long[] Value={ 26L,2L,3L,1L,1L,2L,1L,25L,1L,2L,1L,1L,3L,2L,52L,2L,3L,1L,1L,2L,1L,25L,1L,2L,1L,1L,3L,2L,52L,2L,3L,1L,1L,2L,1L,25L,1L,2L,1L,1L,3L,2L,52L,2L,3L,1L,1L,2L,1L,25L,1L,2L,1L,1L,3L,2L,52L,2L,3L,1L,1L,2L,1L,25L,1L,2L,1L,1L,3L,2L,52L,2L,3L,1L,1L,2L,1L,25L,1L,2L,1L,1L,3L,2L,52L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040672Inst : IEnumerable<long>
{
public static readonly long[] Value=A040672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040672.Bytes);
public long this[int i]=>Value[i];

public static A040672Inst Instance=new A040672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040671
{
public static readonly long[] Value={ 26L,2L,2L,1L,1L,1L,1L,2L,2L,52L,2L,2L,1L,1L,1L,1L,2L,2L,52L,2L,2L,1L,1L,1L,1L,2L,2L,52L,2L,2L,1L,1L,1L,1L,2L,2L,52L,2L,2L,1L,1L,1L,1L,2L,2L,52L,2L,2L,1L,1L,1L,1L,2L,2L,52L,2L,2L,1L,1L,1L,1L,2L,2L,52L,2L,2L,1L,1L,1L,1L,2L,2L,52L,2L,2L,1L,1L,1L,1L,2L,2L,52L,2L,2L,1L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040671Inst : IEnumerable<long>
{
public static readonly long[] Value=A040671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040671.Bytes);
public long this[int i]=>Value[i];

public static A040671Inst Instance=new A040671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040670
{
public static readonly long[] Value={ 26L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L,52L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040670Inst : IEnumerable<long>
{
public static readonly long[] Value=A040670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040670.Bytes);
public long this[int i]=>Value[i];

public static A040670Inst Instance=new A040670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040669
{
public static readonly long[] Value={ 26L,2L,1L,1L,1L,1L,1L,2L,52L,2L,1L,1L,1L,1L,1L,2L,52L,2L,1L,1L,1L,1L,1L,2L,52L,2L,1L,1L,1L,1L,1L,2L,52L,2L,1L,1L,1L,1L,1L,2L,52L,2L,1L,1L,1L,1L,1L,2L,52L,2L,1L,1L,1L,1L,1L,2L,52L,2L,1L,1L,1L,1L,1L,2L,52L,2L,1L,1L,1L,1L,1L,2L,52L,2L,1L,1L,1L,1L,1L,2L,52L,2L,1L,1L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040669Inst : IEnumerable<long>
{
public static readonly long[] Value=A040669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040669.Bytes);
public long this[int i]=>Value[i];

public static A040669Inst Instance=new A040669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040508
{
public static readonly long[] Value={ 23L,15L,2L,1L,4L,2L,4L,1L,2L,15L,46L,15L,2L,1L,4L,2L,4L,1L,2L,15L,46L,15L,2L,1L,4L,2L,4L,1L,2L,15L,46L,15L,2L,1L,4L,2L,4L,1L,2L,15L,46L,15L,2L,1L,4L,2L,4L,1L,2L,15L,46L,15L,2L,1L,4L,2L,4L,1L,2L,15L,46L,15L,2L,1L,4L,2L,4L,1L,2L,15L,46L,15L,2L,1L,4L,2L,4L,1L,2L,15L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040508Inst : IEnumerable<long>
{
public static readonly long[] Value=A040508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040508.Bytes);
public long this[int i]=>Value[i];

public static A040508Inst Instance=new A040508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040507
{
public static readonly long[] Value={ 23L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040507Inst : IEnumerable<long>
{
public static readonly long[] Value=A040507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040507.Bytes);
public long this[int i]=>Value[i];

public static A040507Inst Instance=new A040507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040506
{
public static readonly long[] Value={ 23L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040506Inst : IEnumerable<long>
{
public static readonly long[] Value=A040506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040506.Bytes);
public long this[int i]=>Value[i];

public static A040506Inst Instance=new A040506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040505
{
public static readonly long[] Value={ 22L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040505Inst : IEnumerable<long>
{
public static readonly long[] Value=A040505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040505.Bytes);
public long this[int i]=>Value[i];

public static A040505Inst Instance=new A040505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040504
{
public static readonly long[] Value={ 22L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040504Inst : IEnumerable<long>
{
public static readonly long[] Value=A040504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040504.Bytes);
public long this[int i]=>Value[i];

public static A040504Inst Instance=new A040504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040503
{
public static readonly long[] Value={ 22L,1L,14L,3L,4L,1L,3L,2L,1L,3L,1L,8L,2L,1L,1L,2L,2L,6L,7L,2L,22L,2L,7L,6L,2L,2L,1L,1L,2L,8L,1L,3L,1L,2L,3L,1L,4L,3L,14L,1L,44L,1L,14L,3L,4L,1L,3L,2L,1L,3L,1L,8L,2L,1L,1L,2L,2L,6L,7L,2L,22L,2L,7L,6L,2L,2L,1L,1L,2L,8L,1L,3L,1L,2L,3L,1L,4L,3L,14L,1L,44L,1L,14L,3L,4L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040503Inst : IEnumerable<long>
{
public static readonly long[] Value=A040503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040503.Bytes);
public long this[int i]=>Value[i];

public static A040503Inst Instance=new A040503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040502
{
public static readonly long[] Value={ 22L,1L,10L,2L,10L,1L,44L,1L,10L,2L,10L,1L,44L,1L,10L,2L,10L,1L,44L,1L,10L,2L,10L,1L,44L,1L,10L,2L,10L,1L,44L,1L,10L,2L,10L,1L,44L,1L,10L,2L,10L,1L,44L,1L,10L,2L,10L,1L,44L,1L,10L,2L,10L,1L,44L,1L,10L,2L,10L,1L,44L,1L,10L,2L,10L,1L,44L,1L,10L,2L,10L,1L,44L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040502Inst : IEnumerable<long>
{
public static readonly long[] Value=A040502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040502.Bytes);
public long this[int i]=>Value[i];

public static A040502Inst Instance=new A040502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040501
{
public static readonly long[] Value={ 22L,1L,8L,5L,1L,1L,1L,1L,2L,1L,10L,1L,2L,1L,1L,1L,1L,5L,8L,1L,44L,1L,8L,5L,1L,1L,1L,1L,2L,1L,10L,1L,2L,1L,1L,1L,1L,5L,8L,1L,44L,1L,8L,5L,1L,1L,1L,1L,2L,1L,10L,1L,2L,1L,1L,1L,1L,5L,8L,1L,44L,1L,8L,5L,1L,1L,1L,1L,2L,1L,10L,1L,2L,1L,1L,1L,1L,5L,8L,1L,44L,1L,8L,5L,1L,1L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040501Inst : IEnumerable<long>
{
public static readonly long[] Value=A040501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040501.Bytes);
public long this[int i]=>Value[i];

public static A040501Inst Instance=new A040501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040500
{
public static readonly long[] Value={ 22L,1L,6L,1L,1L,1L,4L,2L,3L,14L,1L,21L,1L,14L,3L,2L,4L,1L,1L,1L,6L,1L,44L,1L,6L,1L,1L,1L,4L,2L,3L,14L,1L,21L,1L,14L,3L,2L,4L,1L,1L,1L,6L,1L,44L,1L,6L,1L,1L,1L,4L,2L,3L,14L,1L,21L,1L,14L,3L,2L,4L,1L,1L,1L,6L,1L,44L,1L,6L,1L,1L,1L,4L,2L,3L,14L,1L,21L,1L,14L,3L,2L,4L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040500Inst : IEnumerable<long>
{
public static readonly long[] Value=A040500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040500.Bytes);
public long this[int i]=>Value[i];

public static A040500Inst Instance=new A040500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040499
{
public static readonly long[] Value={ 22L,1L,5L,1L,1L,4L,1L,1L,5L,1L,44L,1L,5L,1L,1L,4L,1L,1L,5L,1L,44L,1L,5L,1L,1L,4L,1L,1L,5L,1L,44L,1L,5L,1L,1L,4L,1L,1L,5L,1L,44L,1L,5L,1L,1L,4L,1L,1L,5L,1L,44L,1L,5L,1L,1L,4L,1L,1L,5L,1L,44L,1L,5L,1L,1L,4L,1L,1L,5L,1L,44L,1L,5L,1L,1L,4L,1L,1L,5L,1L,44L,1L,5L,1L,1L,4L,1L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040499Inst : IEnumerable<long>
{
public static readonly long[] Value=A040499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040499.Bytes);
public long this[int i]=>Value[i];

public static A040499Inst Instance=new A040499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040498
{
public static readonly long[] Value={ 22L,1L,4L,1L,2L,1L,2L,8L,1L,3L,3L,1L,8L,2L,1L,2L,1L,4L,1L,44L,1L,4L,1L,2L,1L,2L,8L,1L,3L,3L,1L,8L,2L,1L,2L,1L,4L,1L,44L,1L,4L,1L,2L,1L,2L,8L,1L,3L,3L,1L,8L,2L,1L,2L,1L,4L,1L,44L,1L,4L,1L,2L,1L,2L,8L,1L,3L,3L,1L,8L,2L,1L,2L,1L,4L,1L,44L,1L,4L,1L,2L,1L,2L,8L,1L,3L,3L,1L,8L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040498Inst : IEnumerable<long>
{
public static readonly long[] Value=A040498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040498.Bytes);
public long this[int i]=>Value[i];

public static A040498Inst Instance=new A040498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040497
{
public static readonly long[] Value={ 22L,1L,4L,11L,4L,1L,44L,1L,4L,11L,4L,1L,44L,1L,4L,11L,4L,1L,44L,1L,4L,11L,4L,1L,44L,1L,4L,11L,4L,1L,44L,1L,4L,11L,4L,1L,44L,1L,4L,11L,4L,1L,44L,1L,4L,11L,4L,1L,44L,1L,4L,11L,4L,1L,44L,1L,4L,11L,4L,1L,44L,1L,4L,11L,4L,1L,44L,1L,4L,11L,4L,1L,44L,1L,4L,11L,4L,1L,44L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040497Inst : IEnumerable<long>
{
public static readonly long[] Value=A040497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040497.Bytes);
public long this[int i]=>Value[i];

public static A040497Inst Instance=new A040497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040496
{
public static readonly long[] Value={ 22L,1L,3L,1L,1L,2L,1L,2L,3L,7L,3L,2L,1L,2L,1L,1L,3L,1L,44L,1L,3L,1L,1L,2L,1L,2L,3L,7L,3L,2L,1L,2L,1L,1L,3L,1L,44L,1L,3L,1L,1L,2L,1L,2L,3L,7L,3L,2L,1L,2L,1L,1L,3L,1L,44L,1L,3L,1L,1L,2L,1L,2L,3L,7L,3L,2L,1L,2L,1L,1L,3L,1L,44L,1L,3L,1L,1L,2L,1L,2L,3L,7L,3L,2L,1L,2L,1L,1L,3L,1L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040496Inst : IEnumerable<long>
{
public static readonly long[] Value=A040496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040496.Bytes);
public long this[int i]=>Value[i];

public static A040496Inst Instance=new A040496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040495
{
public static readonly long[] Value={ 22L,1L,3L,6L,3L,1L,44L,1L,3L,6L,3L,1L,44L,1L,3L,6L,3L,1L,44L,1L,3L,6L,3L,1L,44L,1L,3L,6L,3L,1L,44L,1L,3L,6L,3L,1L,44L,1L,3L,6L,3L,1L,44L,1L,3L,6L,3L,1L,44L,1L,3L,6L,3L,1L,44L,1L,3L,6L,3L,1L,44L,1L,3L,6L,3L,1L,44L,1L,3L,6L,3L,1L,44L,1L,3L,6L,3L,1L,44L,1L,3L,6L,3L,1L,44L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040495Inst : IEnumerable<long>
{
public static readonly long[] Value=A040495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040495.Bytes);
public long this[int i]=>Value[i];

public static A040495Inst Instance=new A040495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040494
{
public static readonly long[] Value={ 22L,1L,2L,1L,4L,3L,3L,2L,10L,1L,14L,4L,14L,1L,10L,2L,3L,3L,4L,1L,2L,1L,44L,1L,2L,1L,4L,3L,3L,2L,10L,1L,14L,4L,14L,1L,10L,2L,3L,3L,4L,1L,2L,1L,44L,1L,2L,1L,4L,3L,3L,2L,10L,1L,14L,4L,14L,1L,10L,2L,3L,3L,4L,1L,2L,1L,44L,1L,2L,1L,4L,3L,3L,2L,10L,1L,14L,4L,14L,1L,10L,2L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040494Inst : IEnumerable<long>
{
public static readonly long[] Value=A040494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040494.Bytes);
public long this[int i]=>Value[i];

public static A040494Inst Instance=new A040494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040493
{
public static readonly long[] Value={ 22L,1L,2L,1L,1L,14L,1L,1L,2L,1L,44L,1L,2L,1L,1L,14L,1L,1L,2L,1L,44L,1L,2L,1L,1L,14L,1L,1L,2L,1L,44L,1L,2L,1L,1L,14L,1L,1L,2L,1L,44L,1L,2L,1L,1L,14L,1L,1L,2L,1L,44L,1L,2L,1L,1L,14L,1L,1L,2L,1L,44L,1L,2L,1L,1L,14L,1L,1L,2L,1L,44L,1L,2L,1L,1L,14L,1L,1L,2L,1L,44L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040493Inst : IEnumerable<long>
{
public static readonly long[] Value=A040493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040493.Bytes);
public long this[int i]=>Value[i];

public static A040493Inst Instance=new A040493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040396
{
public static readonly long[] Value={ 20L,2L,2L,1L,1L,1L,5L,4L,1L,12L,1L,4L,5L,1L,1L,1L,2L,2L,40L,2L,2L,1L,1L,1L,5L,4L,1L,12L,1L,4L,5L,1L,1L,1L,2L,2L,40L,2L,2L,1L,1L,1L,5L,4L,1L,12L,1L,4L,5L,1L,1L,1L,2L,2L,40L,2L,2L,1L,1L,1L,5L,4L,1L,12L,1L,4L,5L,1L,1L,1L,2L,2L,40L,2L,2L,1L,1L,1L,5L,4L,1L,12L,1L,4L,5L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040396Inst : IEnumerable<long>
{
public static readonly long[] Value=A040396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040396.Bytes);
public long this[int i]=>Value[i];

public static A040396Inst Instance=new A040396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040395
{
public static readonly long[] Value={ 20L,2L,1L,1L,9L,1L,1L,2L,40L,2L,1L,1L,9L,1L,1L,2L,40L,2L,1L,1L,9L,1L,1L,2L,40L,2L,1L,1L,9L,1L,1L,2L,40L,2L,1L,1L,9L,1L,1L,2L,40L,2L,1L,1L,9L,1L,1L,2L,40L,2L,1L,1L,9L,1L,1L,2L,40L,2L,1L,1L,9L,1L,1L,2L,40L,2L,1L,1L,9L,1L,1L,2L,40L,2L,1L,1L,9L,1L,1L,2L,40L,2L,1L,1L,9L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040395Inst : IEnumerable<long>
{
public static readonly long[] Value=A040395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040395.Bytes);
public long this[int i]=>Value[i];

public static A040395Inst Instance=new A040395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040394
{
public static readonly long[] Value={ 20L,2L,1L,2L,4L,6L,1L,1L,3L,1L,1L,6L,4L,2L,1L,2L,40L,2L,1L,2L,4L,6L,1L,1L,3L,1L,1L,6L,4L,2L,1L,2L,40L,2L,1L,2L,4L,6L,1L,1L,3L,1L,1L,6L,4L,2L,1L,2L,40L,2L,1L,2L,4L,6L,1L,1L,3L,1L,1L,6L,4L,2L,1L,2L,40L,2L,1L,2L,4L,6L,1L,1L,3L,1L,1L,6L,4L,2L,1L,2L,40L,2L,1L,2L,4L,6L,1L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040394Inst : IEnumerable<long>
{
public static readonly long[] Value=A040394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040394.Bytes);
public long this[int i]=>Value[i];

public static A040394Inst Instance=new A040394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040393
{
public static readonly long[] Value={ 20L,2L,1L,7L,2L,7L,1L,2L,40L,2L,1L,7L,2L,7L,1L,2L,40L,2L,1L,7L,2L,7L,1L,2L,40L,2L,1L,7L,2L,7L,1L,2L,40L,2L,1L,7L,2L,7L,1L,2L,40L,2L,1L,7L,2L,7L,1L,2L,40L,2L,1L,7L,2L,7L,1L,2L,40L,2L,1L,7L,2L,7L,1L,2L,40L,2L,1L,7L,2L,7L,1L,2L,40L,2L,1L,7L,2L,7L,1L,2L,40L,2L,1L,7L,2L,7L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040393Inst : IEnumerable<long>
{
public static readonly long[] Value=A040393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040393.Bytes);
public long this[int i]=>Value[i];

public static A040393Inst Instance=new A040393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040392
{
public static readonly long[] Value={ 20L,3L,9L,1L,4L,1L,9L,3L,40L,3L,9L,1L,4L,1L,9L,3L,40L,3L,9L,1L,4L,1L,9L,3L,40L,3L,9L,1L,4L,1L,9L,3L,40L,3L,9L,1L,4L,1L,9L,3L,40L,3L,9L,1L,4L,1L,9L,3L,40L,3L,9L,1L,4L,1L,9L,3L,40L,3L,9L,1L,4L,1L,9L,3L,40L,3L,9L,1L,4L,1L,9L,3L,40L,3L,9L,1L,4L,1L,9L,3L,40L,3L,9L,1L,4L,1L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040392Inst : IEnumerable<long>
{
public static readonly long[] Value=A040392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040392.Bytes);
public long this[int i]=>Value[i];

public static A040392Inst Instance=new A040392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040391
{
public static readonly long[] Value={ 20L,3L,2L,1L,3L,1L,4L,3L,2L,13L,10L,13L,2L,3L,4L,1L,3L,1L,2L,3L,40L,3L,2L,1L,3L,1L,4L,3L,2L,13L,10L,13L,2L,3L,4L,1L,3L,1L,2L,3L,40L,3L,2L,1L,3L,1L,4L,3L,2L,13L,10L,13L,2L,3L,4L,1L,3L,1L,2L,3L,40L,3L,2L,1L,3L,1L,4L,3L,2L,13L,10L,13L,2L,3L,4L,1L,3L,1L,2L,3L,40L,3L,2L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040391Inst : IEnumerable<long>
{
public static readonly long[] Value=A040391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040391.Bytes);
public long this[int i]=>Value[i];

public static A040391Inst Instance=new A040391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040390
{
public static readonly long[] Value={ 20L,3L,1L,1L,1L,19L,1L,1L,1L,3L,40L,3L,1L,1L,1L,19L,1L,1L,1L,3L,40L,3L,1L,1L,1L,19L,1L,1L,1L,3L,40L,3L,1L,1L,1L,19L,1L,1L,1L,3L,40L,3L,1L,1L,1L,19L,1L,1L,1L,3L,40L,3L,1L,1L,1L,19L,1L,1L,1L,3L,40L,3L,1L,1L,1L,19L,1L,1L,1L,3L,40L,3L,1L,1L,1L,19L,1L,1L,1L,3L,40L,3L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040390Inst : IEnumerable<long>
{
public static readonly long[] Value=A040390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040390.Bytes);
public long this[int i]=>Value[i];

public static A040390Inst Instance=new A040390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040389
{
public static readonly long[] Value={ 20L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L,4L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040389Inst : IEnumerable<long>
{
public static readonly long[] Value=A040389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040389.Bytes);
public long this[int i]=>Value[i];

public static A040389Inst Instance=new A040389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040388
{
public static readonly long[] Value={ 20L,4L,2L,7L,1L,1L,1L,4L,2L,2L,13L,13L,2L,2L,4L,1L,1L,1L,7L,2L,4L,40L,4L,2L,7L,1L,1L,1L,4L,2L,2L,13L,13L,2L,2L,4L,1L,1L,1L,7L,2L,4L,40L,4L,2L,7L,1L,1L,1L,4L,2L,2L,13L,13L,2L,2L,4L,1L,1L,1L,7L,2L,4L,40L,4L,2L,7L,1L,1L,1L,4L,2L,2L,13L,13L,2L,2L,4L,1L,1L,1L,7L,2L,4L,40L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040388Inst : IEnumerable<long>
{
public static readonly long[] Value=A040388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040388.Bytes);
public long this[int i]=>Value[i];

public static A040388Inst Instance=new A040388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040387
{
public static readonly long[] Value={ 20L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L,5L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040387Inst : IEnumerable<long>
{
public static readonly long[] Value=A040387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040387.Bytes);
public long this[int i]=>Value[i];

public static A040387Inst Instance=new A040387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040386
{
public static readonly long[] Value={ 20L,5L,1L,2L,1L,5L,40L,5L,1L,2L,1L,5L,40L,5L,1L,2L,1L,5L,40L,5L,1L,2L,1L,5L,40L,5L,1L,2L,1L,5L,40L,5L,1L,2L,1L,5L,40L,5L,1L,2L,1L,5L,40L,5L,1L,2L,1L,5L,40L,5L,1L,2L,1L,5L,40L,5L,1L,2L,1L,5L,40L,5L,1L,2L,1L,5L,40L,5L,1L,2L,1L,5L,40L,5L,1L,2L,1L,5L,40L,5L,1L,2L,1L,5L,40L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040386Inst : IEnumerable<long>
{
public static readonly long[] Value=A040386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040386.Bytes);
public long this[int i]=>Value[i];

public static A040386Inst Instance=new A040386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040385
{
public static readonly long[] Value={ 20L,6L,1L,2L,4L,7L,1L,4L,1L,7L,4L,2L,1L,6L,40L,6L,1L,2L,4L,7L,1L,4L,1L,7L,4L,2L,1L,6L,40L,6L,1L,2L,4L,7L,1L,4L,1L,7L,4L,2L,1L,6L,40L,6L,1L,2L,4L,7L,1L,4L,1L,7L,4L,2L,1L,6L,40L,6L,1L,2L,4L,7L,1L,4L,1L,7L,4L,2L,1L,6L,40L,6L,1L,2L,4L,7L,1L,4L,1L,7L,4L,2L,1L,6L,40L,6L,1L,2L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040385Inst : IEnumerable<long>
{
public static readonly long[] Value=A040385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040385.Bytes);
public long this[int i]=>Value[i];

public static A040385Inst Instance=new A040385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040384
{
public static readonly long[] Value={ 20L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L,8L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040384Inst : IEnumerable<long>
{
public static readonly long[] Value=A040384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040384.Bytes);
public long this[int i]=>Value[i];

public static A040384Inst Instance=new A040384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040383
{
public static readonly long[] Value={ 20L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L,10L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040383Inst : IEnumerable<long>
{
public static readonly long[] Value=A040383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040383.Bytes);
public long this[int i]=>Value[i];

public static A040383Inst Instance=new A040383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040382
{
public static readonly long[] Value={ 20L,13L,2L,1L,3L,1L,3L,1L,2L,13L,40L,13L,2L,1L,3L,1L,3L,1L,2L,13L,40L,13L,2L,1L,3L,1L,3L,1L,2L,13L,40L,13L,2L,1L,3L,1L,3L,1L,2L,13L,40L,13L,2L,1L,3L,1L,3L,1L,2L,13L,40L,13L,2L,1L,3L,1L,3L,1L,2L,13L,40L,13L,2L,1L,3L,1L,3L,1L,2L,13L,40L,13L,2L,1L,3L,1L,3L,1L,2L,13L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040382Inst : IEnumerable<long>
{
public static readonly long[] Value=A040382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040382.Bytes);
public long this[int i]=>Value[i];

public static A040382Inst Instance=new A040382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040381
{
public static readonly long[] Value={ 20L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L,20L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040381Inst : IEnumerable<long>
{
public static readonly long[] Value=A040381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040381.Bytes);
public long this[int i]=>Value[i];

public static A040381Inst Instance=new A040381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040380
{
public static readonly long[] Value={ 20L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040380Inst : IEnumerable<long>
{
public static readonly long[] Value=A040380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040380.Bytes);
public long this[int i]=>Value[i];

public static A040380Inst Instance=new A040380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040379
{
public static readonly long[] Value={ 19L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040379Inst : IEnumerable<long>
{
public static readonly long[] Value=A040379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040379.Bytes);
public long this[int i]=>Value[i];

public static A040379Inst Instance=new A040379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040378
{
public static readonly long[] Value={ 19L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040378Inst : IEnumerable<long>
{
public static readonly long[] Value=A040378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040378.Bytes);
public long this[int i]=>Value[i];

public static A040378Inst Instance=new A040378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040377
{
public static readonly long[] Value={ 19L,1L,12L,3L,4L,9L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,9L,4L,3L,12L,1L,38L,1L,12L,3L,4L,9L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,9L,4L,3L,12L,1L,38L,1L,12L,3L,4L,9L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,9L,4L,3L,12L,1L,38L,1L,12L,3L,4L,9L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,9L,4L,3L,12L,1L,38L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040377Inst : IEnumerable<long>
{
public static readonly long[] Value=A040377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040377.Bytes);
public long this[int i]=>Value[i];

public static A040377Inst Instance=new A040377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040376
{
public static readonly long[] Value={ 19L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040376Inst : IEnumerable<long>
{
public static readonly long[] Value=A040376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040376.Bytes);
public long this[int i]=>Value[i];

public static A040376Inst Instance=new A040376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040375
{
public static readonly long[] Value={ 19L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040375Inst : IEnumerable<long>
{
public static readonly long[] Value=A040375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040375.Bytes);
public long this[int i]=>Value[i];

public static A040375Inst Instance=new A040375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040374
{
public static readonly long[] Value={ 19L,1L,5L,1L,1L,1L,3L,1L,3L,5L,2L,2L,5L,3L,1L,3L,1L,1L,1L,5L,1L,38L,1L,5L,1L,1L,1L,3L,1L,3L,5L,2L,2L,5L,3L,1L,3L,1L,1L,1L,5L,1L,38L,1L,5L,1L,1L,1L,3L,1L,3L,5L,2L,2L,5L,3L,1L,3L,1L,1L,1L,5L,1L,38L,1L,5L,1L,1L,1L,3L,1L,3L,5L,2L,2L,5L,3L,1L,3L,1L,1L,1L,5L,1L,38L,1L,5L,1L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040374Inst : IEnumerable<long>
{
public static readonly long[] Value=A040374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040374.Bytes);
public long this[int i]=>Value[i];

public static A040374Inst Instance=new A040374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040373
{
public static readonly long[] Value={ 19L,1L,4L,1L,2L,4L,1L,1L,1L,1L,12L,1L,1L,1L,1L,4L,2L,1L,4L,1L,38L,1L,4L,1L,2L,4L,1L,1L,1L,1L,12L,1L,1L,1L,1L,4L,2L,1L,4L,1L,38L,1L,4L,1L,2L,4L,1L,1L,1L,1L,12L,1L,1L,1L,1L,4L,2L,1L,4L,1L,38L,1L,4L,1L,2L,4L,1L,1L,1L,1L,12L,1L,1L,1L,1L,4L,2L,1L,4L,1L,38L,1L,4L,1L,2L,4L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040373Inst : IEnumerable<long>
{
public static readonly long[] Value=A040373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040373.Bytes);
public long this[int i]=>Value[i];

public static A040373Inst Instance=new A040373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040372
{
public static readonly long[] Value={ 19L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040372Inst : IEnumerable<long>
{
public static readonly long[] Value=A040372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040372.Bytes);
public long this[int i]=>Value[i];

public static A040372Inst Instance=new A040372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040371
{
public static readonly long[] Value={ 19L,1L,3L,2L,2L,1L,1L,2L,19L,2L,1L,1L,2L,2L,3L,1L,38L,1L,3L,2L,2L,1L,1L,2L,19L,2L,1L,1L,2L,2L,3L,1L,38L,1L,3L,2L,2L,1L,1L,2L,19L,2L,1L,1L,2L,2L,3L,1L,38L,1L,3L,2L,2L,1L,1L,2L,19L,2L,1L,1L,2L,2L,3L,1L,38L,1L,3L,2L,2L,1L,1L,2L,19L,2L,1L,1L,2L,2L,3L,1L,38L,1L,3L,2L,2L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040371Inst : IEnumerable<long>
{
public static readonly long[] Value=A040371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040371.Bytes);
public long this[int i]=>Value[i];

public static A040371Inst Instance=new A040371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040370
{
public static readonly long[] Value={ 19L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040370Inst : IEnumerable<long>
{
public static readonly long[] Value=A040370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040370.Bytes);
public long this[int i]=>Value[i];

public static A040370Inst Instance=new A040370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040369
{
public static readonly long[] Value={ 19L,1L,2L,1L,1L,1L,1L,2L,1L,38L,1L,2L,1L,1L,1L,1L,2L,1L,38L,1L,2L,1L,1L,1L,1L,2L,1L,38L,1L,2L,1L,1L,1L,1L,2L,1L,38L,1L,2L,1L,1L,1L,1L,2L,1L,38L,1L,2L,1L,1L,1L,1L,2L,1L,38L,1L,2L,1L,1L,1L,1L,2L,1L,38L,1L,2L,1L,1L,1L,1L,2L,1L,38L,1L,2L,1L,1L,1L,1L,2L,1L,38L,1L,2L,1L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040369Inst : IEnumerable<long>
{
public static readonly long[] Value=A040369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040369.Bytes);
public long this[int i]=>Value[i];

public static A040369Inst Instance=new A040369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040368
{
public static readonly long[] Value={ 19L,1L,2L,3L,4L,12L,1L,8L,1L,12L,4L,3L,2L,1L,38L,1L,2L,3L,4L,12L,1L,8L,1L,12L,4L,3L,2L,1L,38L,1L,2L,3L,4L,12L,1L,8L,1L,12L,4L,3L,2L,1L,38L,1L,2L,3L,4L,12L,1L,8L,1L,12L,4L,3L,2L,1L,38L,1L,2L,3L,4L,12L,1L,8L,1L,12L,4L,3L,2L,1L,38L,1L,2L,3L,4L,12L,1L,8L,1L,12L,4L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040368Inst : IEnumerable<long>
{
public static readonly long[] Value=A040368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040368.Bytes);
public long this[int i]=>Value[i];

public static A040368Inst Instance=new A040368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040367
{
public static readonly long[] Value={ 19L,1L,2L,19L,2L,1L,38L,1L,2L,19L,2L,1L,38L,1L,2L,19L,2L,1L,38L,1L,2L,19L,2L,1L,38L,1L,2L,19L,2L,1L,38L,1L,2L,19L,2L,1L,38L,1L,2L,19L,2L,1L,38L,1L,2L,19L,2L,1L,38L,1L,2L,19L,2L,1L,38L,1L,2L,19L,2L,1L,38L,1L,2L,19L,2L,1L,38L,1L,2L,19L,2L,1L,38L,1L,2L,19L,2L,1L,38L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040367Inst : IEnumerable<long>
{
public static readonly long[] Value=A040367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040367.Bytes);
public long this[int i]=>Value[i];

public static A040367Inst Instance=new A040367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040366
{
public static readonly long[] Value={ 19L,1L,1L,1L,4L,1L,18L,1L,4L,1L,1L,1L,38L,1L,1L,1L,4L,1L,18L,1L,4L,1L,1L,1L,38L,1L,1L,1L,4L,1L,18L,1L,4L,1L,1L,1L,38L,1L,1L,1L,4L,1L,18L,1L,4L,1L,1L,1L,38L,1L,1L,1L,4L,1L,18L,1L,4L,1L,1L,1L,38L,1L,1L,1L,4L,1L,18L,1L,4L,1L,1L,1L,38L,1L,1L,1L,4L,1L,18L,1L,4L,1L,1L,1L,38L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040366Inst : IEnumerable<long>
{
public static readonly long[] Value=A040366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040366.Bytes);
public long this[int i]=>Value[i];

public static A040366Inst Instance=new A040366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040365
{
public static readonly long[] Value={ 19L,1L,1L,1L,1L,1L,3L,1L,2L,1L,3L,1L,1L,1L,1L,1L,38L,1L,1L,1L,1L,1L,3L,1L,2L,1L,3L,1L,1L,1L,1L,1L,38L,1L,1L,1L,1L,1L,3L,1L,2L,1L,3L,1L,1L,1L,1L,1L,38L,1L,1L,1L,1L,1L,3L,1L,2L,1L,3L,1L,1L,1L,1L,1L,38L,1L,1L,1L,1L,1L,3L,1L,2L,1L,3L,1L,1L,1L,1L,1L,38L,1L,1L,1L,1L,1L,3L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040365Inst : IEnumerable<long>
{
public static readonly long[] Value=A040365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040365.Bytes);
public long this[int i]=>Value[i];

public static A040365Inst Instance=new A040365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040316
{
public static readonly long[] Value={ 18L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040316Inst : IEnumerable<long>
{
public static readonly long[] Value=A040316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040316.Bytes);
public long this[int i]=>Value[i];

public static A040316Inst Instance=new A040316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040315
{
public static readonly long[] Value={ 18L,3L,1L,1L,1L,2L,5L,1L,2L,2L,11L,1L,3L,7L,18L,7L,3L,1L,11L,2L,2L,1L,5L,2L,1L,1L,1L,3L,36L,3L,1L,1L,1L,2L,5L,1L,2L,2L,11L,1L,3L,7L,18L,7L,3L,1L,11L,2L,2L,1L,5L,2L,1L,1L,1L,3L,36L,3L,1L,1L,1L,2L,5L,1L,2L,2L,11L,1L,3L,7L,18L,7L,3L,1L,11L,2L,2L,1L,5L,2L,1L,1L,1L,3L,36L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040315Inst : IEnumerable<long>
{
public static readonly long[] Value=A040315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040315.Bytes);
public long this[int i]=>Value[i];

public static A040315Inst Instance=new A040315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040314
{
public static readonly long[] Value={ 18L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040314Inst : IEnumerable<long>
{
public static readonly long[] Value=A040314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040314.Bytes);
public long this[int i]=>Value[i];

public static A040314Inst Instance=new A040314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040313
{
public static readonly long[] Value={ 18L,4L,1L,1L,8L,1L,1L,4L,36L,4L,1L,1L,8L,1L,1L,4L,36L,4L,1L,1L,8L,1L,1L,4L,36L,4L,1L,1L,8L,1L,1L,4L,36L,4L,1L,1L,8L,1L,1L,4L,36L,4L,1L,1L,8L,1L,1L,4L,36L,4L,1L,1L,8L,1L,1L,4L,36L,4L,1L,1L,8L,1L,1L,4L,36L,4L,1L,1L,8L,1L,1L,4L,36L,4L,1L,1L,8L,1L,1L,4L,36L,4L,1L,1L,8L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040313Inst : IEnumerable<long>
{
public static readonly long[] Value=A040313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040313.Bytes);
public long this[int i]=>Value[i];

public static A040313Inst Instance=new A040313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040312
{
public static readonly long[] Value={ 18L,5L,5L,1L,6L,2L,3L,1L,1L,2L,1L,2L,1L,11L,2L,1L,1L,17L,1L,1L,2L,11L,1L,2L,1L,2L,1L,1L,3L,2L,6L,1L,5L,5L,36L,5L,5L,1L,6L,2L,3L,1L,1L,2L,1L,2L,1L,11L,2L,1L,1L,17L,1L,1L,2L,11L,1L,2L,1L,2L,1L,1L,3L,2L,6L,1L,5L,5L,36L,5L,5L,1L,6L,2L,3L,1L,1L,2L,1L,2L,1L,11L,2L,1L,1L,17L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040312Inst : IEnumerable<long>
{
public static readonly long[] Value=A040312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040312.Bytes);
public long this[int i]=>Value[i];

public static A040312Inst Instance=new A040312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040311
{
public static readonly long[] Value={ 18L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040311Inst : IEnumerable<long>
{
public static readonly long[] Value=A040311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040311.Bytes);
public long this[int i]=>Value[i];

public static A040311Inst Instance=new A040311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040310
{
public static readonly long[] Value={ 18L,7L,4L,2L,1L,1L,4L,1L,1L,2L,4L,7L,36L,7L,4L,2L,1L,1L,4L,1L,1L,2L,4L,7L,36L,7L,4L,2L,1L,1L,4L,1L,1L,2L,4L,7L,36L,7L,4L,2L,1L,1L,4L,1L,1L,2L,4L,7L,36L,7L,4L,2L,1L,1L,4L,1L,1L,2L,4L,7L,36L,7L,4L,2L,1L,1L,4L,1L,1L,2L,4L,7L,36L,7L,4L,2L,1L,1L,4L,1L,1L,2L,4L,7L,36L,7L,4L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040310Inst : IEnumerable<long>
{
public static readonly long[] Value=A040310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040310.Bytes);
public long this[int i]=>Value[i];

public static A040310Inst Instance=new A040310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040309
{
public static readonly long[] Value={ 18L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040309Inst : IEnumerable<long>
{
public static readonly long[] Value=A040309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040309.Bytes);
public long this[int i]=>Value[i];

public static A040309Inst Instance=new A040309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040308
{
public static readonly long[] Value={ 18L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040308Inst : IEnumerable<long>
{
public static readonly long[] Value=A040308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040308.Bytes);
public long this[int i]=>Value[i];

public static A040308Inst Instance=new A040308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040307
{
public static readonly long[] Value={ 18L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040307Inst : IEnumerable<long>
{
public static readonly long[] Value=A040307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040307.Bytes);
public long this[int i]=>Value[i];

public static A040307Inst Instance=new A040307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040306
{
public static readonly long[] Value={ 18L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040306Inst : IEnumerable<long>
{
public static readonly long[] Value=A040306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040306.Bytes);
public long this[int i]=>Value[i];

public static A040306Inst Instance=new A040306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040305
{
public static readonly long[] Value={ 17L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040305Inst : IEnumerable<long>
{
public static readonly long[] Value=A040305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040305.Bytes);
public long this[int i]=>Value[i];

public static A040305Inst Instance=new A040305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040304
{
public static readonly long[] Value={ 17L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040304Inst : IEnumerable<long>
{
public static readonly long[] Value=A040304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040304.Bytes);
public long this[int i]=>Value[i];

public static A040304Inst Instance=new A040304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040303
{
public static readonly long[] Value={ 17L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040303Inst : IEnumerable<long>
{
public static readonly long[] Value=A040303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040303.Bytes);
public long this[int i]=>Value[i];

public static A040303Inst Instance=new A040303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040302
{
public static readonly long[] Value={ 17L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040302Inst : IEnumerable<long>
{
public static readonly long[] Value=A040302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040302.Bytes);
public long this[int i]=>Value[i];

public static A040302Inst Instance=new A040302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040301
{
public static readonly long[] Value={ 17L,1L,6L,5L,1L,4L,3L,1L,3L,4L,1L,5L,6L,1L,34L,1L,6L,5L,1L,4L,3L,1L,3L,4L,1L,5L,6L,1L,34L,1L,6L,5L,1L,4L,3L,1L,3L,4L,1L,5L,6L,1L,34L,1L,6L,5L,1L,4L,3L,1L,3L,4L,1L,5L,6L,1L,34L,1L,6L,5L,1L,4L,3L,1L,3L,4L,1L,5L,6L,1L,34L,1L,6L,5L,1L,4L,3L,1L,3L,4L,1L,5L,6L,1L,34L,1L,6L,5L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040301Inst : IEnumerable<long>
{
public static readonly long[] Value=A040301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040301.Bytes);
public long this[int i]=>Value[i];

public static A040301Inst Instance=new A040301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040268
{
public static readonly long[] Value={ 16L,1L,7L,2L,7L,1L,32L,1L,7L,2L,7L,1L,32L,1L,7L,2L,7L,1L,32L,1L,7L,2L,7L,1L,32L,1L,7L,2L,7L,1L,32L,1L,7L,2L,7L,1L,32L,1L,7L,2L,7L,1L,32L,1L,7L,2L,7L,1L,32L,1L,7L,2L,7L,1L,32L,1L,7L,2L,7L,1L,32L,1L,7L,2L,7L,1L,32L,1L,7L,2L,7L,1L,32L,1L,7L,2L,7L,1L,32L,1L,7L,2L,7L,1L,32L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040268Inst : IEnumerable<long>
{
public static readonly long[] Value=A040268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040268.Bytes);
public long this[int i]=>Value[i];

public static A040268Inst Instance=new A040268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040267
{
public static readonly long[] Value={ 16L,1L,5L,1L,3L,2L,1L,4L,8L,4L,1L,2L,3L,1L,5L,1L,32L,1L,5L,1L,3L,2L,1L,4L,8L,4L,1L,2L,3L,1L,5L,1L,32L,1L,5L,1L,3L,2L,1L,4L,8L,4L,1L,2L,3L,1L,5L,1L,32L,1L,5L,1L,3L,2L,1L,4L,8L,4L,1L,2L,3L,1L,5L,1L,32L,1L,5L,1L,3L,2L,1L,4L,8L,4L,1L,2L,3L,1L,5L,1L,32L,1L,5L,1L,3L,2L,1L,4L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040267Inst : IEnumerable<long>
{
public static readonly long[] Value=A040267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040267.Bytes);
public long this[int i]=>Value[i];

public static A040267Inst Instance=new A040267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040266
{
public static readonly long[] Value={ 16L,1L,4L,1L,1L,1L,3L,10L,1L,15L,1L,10L,3L,1L,1L,1L,4L,1L,32L,1L,4L,1L,1L,1L,3L,10L,1L,15L,1L,10L,3L,1L,1L,1L,4L,1L,32L,1L,4L,1L,1L,1L,3L,10L,1L,15L,1L,10L,3L,1L,1L,1L,4L,1L,32L,1L,4L,1L,1L,1L,3L,10L,1L,15L,1L,10L,3L,1L,1L,1L,4L,1L,32L,1L,4L,1L,1L,1L,3L,10L,1L,15L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040266Inst : IEnumerable<long>
{
public static readonly long[] Value=A040266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040266.Bytes);
public long this[int i]=>Value[i];

public static A040266Inst Instance=new A040266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040265
{
public static readonly long[] Value={ 16L,1L,3L,1L,4L,1L,3L,1L,32L,1L,3L,1L,4L,1L,3L,1L,32L,1L,3L,1L,4L,1L,3L,1L,32L,1L,3L,1L,4L,1L,3L,1L,32L,1L,3L,1L,4L,1L,3L,1L,32L,1L,3L,1L,4L,1L,3L,1L,32L,1L,3L,1L,4L,1L,3L,1L,32L,1L,3L,1L,4L,1L,3L,1L,32L,1L,3L,1L,4L,1L,3L,1L,32L,1L,3L,1L,4L,1L,3L,1L,32L,1L,3L,1L,4L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040265Inst : IEnumerable<long>
{
public static readonly long[] Value=A040265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040265.Bytes);
public long this[int i]=>Value[i];

public static A040265Inst Instance=new A040265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040264
{
public static readonly long[] Value={ 16L,1L,3L,4L,1L,1L,6L,6L,1L,1L,4L,3L,1L,32L,1L,3L,4L,1L,1L,6L,6L,1L,1L,4L,3L,1L,32L,1L,3L,4L,1L,1L,6L,6L,1L,1L,4L,3L,1L,32L,1L,3L,4L,1L,1L,6L,6L,1L,1L,4L,3L,1L,32L,1L,3L,4L,1L,1L,6L,6L,1L,1L,4L,3L,1L,32L,1L,3L,4L,1L,1L,6L,6L,1L,1L,4L,3L,1L,32L,1L,3L,4L,1L,1L,6L,6L,1L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040264Inst : IEnumerable<long>
{
public static readonly long[] Value=A040264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040264.Bytes);
public long this[int i]=>Value[i];

public static A040264Inst Instance=new A040264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040263
{
public static readonly long[] Value={ 16L,1L,2L,1L,2L,1L,32L,1L,2L,1L,2L,1L,32L,1L,2L,1L,2L,1L,32L,1L,2L,1L,2L,1L,32L,1L,2L,1L,2L,1L,32L,1L,2L,1L,2L,1L,32L,1L,2L,1L,2L,1L,32L,1L,2L,1L,2L,1L,32L,1L,2L,1L,2L,1L,32L,1L,2L,1L,2L,1L,32L,1L,2L,1L,2L,1L,32L,1L,2L,1L,2L,1L,32L,1L,2L,1L,2L,1L,32L,1L,2L,1L,2L,1L,32L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040263Inst : IEnumerable<long>
{
public static readonly long[] Value=A040263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040263.Bytes);
public long this[int i]=>Value[i];

public static A040263Inst Instance=new A040263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040262
{
public static readonly long[] Value={ 16L,1L,2L,2L,1L,2L,2L,1L,32L,1L,2L,2L,1L,2L,2L,1L,32L,1L,2L,2L,1L,2L,2L,1L,32L,1L,2L,2L,1L,2L,2L,1L,32L,1L,2L,2L,1L,2L,2L,1L,32L,1L,2L,2L,1L,2L,2L,1L,32L,1L,2L,2L,1L,2L,2L,1L,32L,1L,2L,2L,1L,2L,2L,1L,32L,1L,2L,2L,1L,2L,2L,1L,32L,1L,2L,2L,1L,2L,2L,1L,32L,1L,2L,2L,1L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040262Inst : IEnumerable<long>
{
public static readonly long[] Value=A040262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040262.Bytes);
public long this[int i]=>Value[i];

public static A040262Inst Instance=new A040262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040261
{
public static readonly long[] Value={ 16L,1L,2L,16L,2L,1L,32L,1L,2L,16L,2L,1L,32L,1L,2L,16L,2L,1L,32L,1L,2L,16L,2L,1L,32L,1L,2L,16L,2L,1L,32L,1L,2L,16L,2L,1L,32L,1L,2L,16L,2L,1L,32L,1L,2L,16L,2L,1L,32L,1L,2L,16L,2L,1L,32L,1L,2L,16L,2L,1L,32L,1L,2L,16L,2L,1L,32L,1L,2L,16L,2L,1L,32L,1L,2L,16L,2L,1L,32L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040261Inst : IEnumerable<long>
{
public static readonly long[] Value=A040261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040261.Bytes);
public long this[int i]=>Value[i];

public static A040261Inst Instance=new A040261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040260
{
public static readonly long[] Value={ 16L,1L,1L,1L,4L,10L,1L,7L,2L,2L,3L,3L,2L,2L,7L,1L,10L,4L,1L,1L,1L,32L,1L,1L,1L,4L,10L,1L,7L,2L,2L,3L,3L,2L,2L,7L,1L,10L,4L,1L,1L,1L,32L,1L,1L,1L,4L,10L,1L,7L,2L,2L,3L,3L,2L,2L,7L,1L,10L,4L,1L,1L,1L,32L,1L,1L,1L,4L,10L,1L,7L,2L,2L,3L,3L,2L,2L,7L,1L,10L,4L,1L,1L,1L,32L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040260Inst : IEnumerable<long>
{
public static readonly long[] Value=A040260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040260.Bytes);
public long this[int i]=>Value[i];

public static A040260Inst Instance=new A040260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040259
{
public static readonly long[] Value={ 16L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,32L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,32L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,32L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,32L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,32L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,32L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,32L,1L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040259Inst : IEnumerable<long>
{
public static readonly long[] Value=A040259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040259.Bytes);
public long this[int i]=>Value[i];

public static A040259Inst Instance=new A040259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040258
{
public static readonly long[] Value={ 16L,1L,1L,2L,1L,1L,32L,1L,1L,2L,1L,1L,32L,1L,1L,2L,1L,1L,32L,1L,1L,2L,1L,1L,32L,1L,1L,2L,1L,1L,32L,1L,1L,2L,1L,1L,32L,1L,1L,2L,1L,1L,32L,1L,1L,2L,1L,1L,32L,1L,1L,2L,1L,1L,32L,1L,1L,2L,1L,1L,32L,1L,1L,2L,1L,1L,32L,1L,1L,2L,1L,1L,32L,1L,1L,2L,1L,1L,32L,1L,1L,2L,1L,1L,32L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040258Inst : IEnumerable<long>
{
public static readonly long[] Value=A040258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040258.Bytes);
public long this[int i]=>Value[i];

public static A040258Inst Instance=new A040258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040257
{
public static readonly long[] Value={ 16L,1L,1L,4L,4L,1L,1L,32L,1L,1L,4L,4L,1L,1L,32L,1L,1L,4L,4L,1L,1L,32L,1L,1L,4L,4L,1L,1L,32L,1L,1L,4L,4L,1L,1L,32L,1L,1L,4L,4L,1L,1L,32L,1L,1L,4L,4L,1L,1L,32L,1L,1L,4L,4L,1L,1L,32L,1L,1L,4L,4L,1L,1L,32L,1L,1L,4L,4L,1L,1L,32L,1L,1L,4L,4L,1L,1L,32L,1L,1L,4L,4L,1L,1L,32L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040257Inst : IEnumerable<long>
{
public static readonly long[] Value=A040257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040257.Bytes);
public long this[int i]=>Value[i];

public static A040257Inst Instance=new A040257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040256
{
public static readonly long[] Value={ 16L,1L,1L,10L,1L,1L,32L,1L,1L,10L,1L,1L,32L,1L,1L,10L,1L,1L,32L,1L,1L,10L,1L,1L,32L,1L,1L,10L,1L,1L,32L,1L,1L,10L,1L,1L,32L,1L,1L,10L,1L,1L,32L,1L,1L,10L,1L,1L,32L,1L,1L,10L,1L,1L,32L,1L,1L,10L,1L,1L,32L,1L,1L,10L,1L,1L,32L,1L,1L,10L,1L,1L,32L,1L,1L,10L,1L,1L,32L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040256Inst : IEnumerable<long>
{
public static readonly long[] Value=A040256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040256.Bytes);
public long this[int i]=>Value[i];

public static A040256Inst Instance=new A040256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040255
{
public static readonly long[] Value={ 16L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040255Inst : IEnumerable<long>
{
public static readonly long[] Value=A040255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040255.Bytes);
public long this[int i]=>Value[i];

public static A040255Inst Instance=new A040255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040254
{
public static readonly long[] Value={ 16L,2L,6L,10L,1L,4L,1L,1L,2L,1L,2L,1L,15L,1L,2L,1L,2L,1L,1L,4L,1L,10L,6L,2L,32L,2L,6L,10L,1L,4L,1L,1L,2L,1L,2L,1L,15L,1L,2L,1L,2L,1L,1L,4L,1L,10L,6L,2L,32L,2L,6L,10L,1L,4L,1L,1L,2L,1L,2L,1L,15L,1L,2L,1L,2L,1L,1L,4L,1L,10L,6L,2L,32L,2L,6L,10L,1L,4L,1L,1L,2L,1L,2L,1L,15L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040254Inst : IEnumerable<long>
{
public static readonly long[] Value=A040254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040254.Bytes);
public long this[int i]=>Value[i];

public static A040254Inst Instance=new A040254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}