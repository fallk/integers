using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A016422
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,1L };
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
public class A016422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016422Inst : IEnumerable<long>
{
public static readonly long[] Value=A016422.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016422.Bytes);
public long this[int i]=>Value[i];

public static A016422Inst Instance=new A016422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016421
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,0L,0L,-1L,-1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,-1L,-1L,0L,0L,-1L,-1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,-1L,-1L,0L,0L,-1L,-1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,-1L,-1L,0L,1L,0L,0L,0L,1L,1L,0L,-1L,-1L,-1L,0L,0L };
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
public class A016421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016421Inst : IEnumerable<long>
{
public static readonly long[] Value=A016421.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016421.Bytes);
public long this[int i]=>Value[i];

public static A016421Inst Instance=new A016421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016420
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,1L,-1L,1L,-1L,0L };
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
public class A016420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016420Inst : IEnumerable<long>
{
public static readonly long[] Value=A016420.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016420.Bytes);
public long this[int i]=>Value[i];

public static A016420Inst Instance=new A016420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016419
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,-1L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,-1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,-1L,0L,-1L,0L,0L,0L,1L,0L,0L,0L,-1L,0L,0L,0L,1L,0L,1L,0L,0L };
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
public class A016419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016419Inst : IEnumerable<long>
{
public static readonly long[] Value=A016419.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016419.Bytes);
public long this[int i]=>Value[i];

public static A016419Inst Instance=new A016419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016418
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,-1L,0L,0L };
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
public class A016418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016418Inst : IEnumerable<long>
{
public static readonly long[] Value=A016418.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016418.Bytes);
public long this[int i]=>Value[i];

public static A016418Inst Instance=new A016418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016417
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L };
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
public class A016417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016417Inst : IEnumerable<long>
{
public static readonly long[] Value=A016417.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016417.Bytes);
public long this[int i]=>Value[i];

public static A016417Inst Instance=new A016417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016416
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,-1L,-1L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,-1L,-1L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,-1L,0L,-1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,-1L,0L,-1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,-1L,0L,-1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,-1L,0L,-1L };
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
public class A016416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016416Inst : IEnumerable<long>
{
public static readonly long[] Value=A016416.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016416.Bytes);
public long this[int i]=>Value[i];

public static A016416Inst Instance=new A016416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016415
{
public static readonly long[] Value={ 1L,-1L,1L,0L,0L,0L,0L,1L,-1L,1L,0L,1L,-1L,1L,0L,0L,0L,0L,1L,-1L,1L,-1L,1L,-1L,0L,0L,0L,0L,-1L,1L,-1L,0L,-1L,0L,0L,-1L,0L,0L,0L,-1L,0L,0L,0L,-1L,0L,1L,-1L,0L,0L,1L,-1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,-1L,1L,0L,0L,-1L,1L,0L,-1L,0L,0L,0L };
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
public class A016415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016415Inst : IEnumerable<long>
{
public static readonly long[] Value=A016415.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016415.Bytes);
public long this[int i]=>Value[i];

public static A016415Inst Instance=new A016415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016414
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,0L,0L,-1L,-1L,-1L,-1L,-1L,0L,-1L,-1L,-1L,-1L,-1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,-1L,-1L,-1L,-1L,-1L,0L,-1L,-1L,-1L,-1L,-1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,-1L,-1L,-1L,-2L,-2L,-2L };
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
public class A016414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016414Inst : IEnumerable<long>
{
public static readonly long[] Value=A016414.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016414.Bytes);
public long this[int i]=>Value[i];

public static A016414Inst Instance=new A016414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016413
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L };
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
public class A016413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016413Inst : IEnumerable<long>
{
public static readonly long[] Value=A016413.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016413.Bytes);
public long this[int i]=>Value[i];

public static A016413Inst Instance=new A016413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016412
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,-1L,0L,0L,-1L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,-1L,-1L,0L,0L,-1L,-1L,0L,0L,-1L,-1L,0L,0L,-1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,-1L,0L,1L,0L,-1L,0L,0L,-1L,-1L,0L,0L,-1L,0L,1L,0L };
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
public class A016412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016412Inst : IEnumerable<long>
{
public static readonly long[] Value=A016412.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016412.Bytes);
public long this[int i]=>Value[i];

public static A016412Inst Instance=new A016412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016411
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,1L };
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
public class A016411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016411Inst : IEnumerable<long>
{
public static readonly long[] Value=A016411.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016411.Bytes);
public long this[int i]=>Value[i];

public static A016411Inst Instance=new A016411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016410
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,-1L,-1L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,-1L,-1L,-1L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,1L,0L,1L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,1L,0L,1L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,1L,0L,1L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,1L,0L,1L,0L };
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
public class A016410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016410Inst : IEnumerable<long>
{
public static readonly long[] Value=A016410.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016410.Bytes);
public long this[int i]=>Value[i];

public static A016410Inst Instance=new A016410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016409
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,-1L,-1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,-1L,-1L,0L,0L,0L,0L,0L,1L,1L,0L,-1L,-1L,0L,0L,-1L,-1L,0L,1L,1L,0L,0L,1L,1L,0L,-1L,-1L,0L,0L,-1L,-1L,0L,1L,1L,0L,0L,1L,1L,0L,-1L,-1L,0L,1L,0L,-1L,0L,1L,1L,0L,-1L,0L,1L,0L,-1L,-1L,0L,1L,0L,-1L,0L,1L };
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
public class A016409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016409Inst : IEnumerable<long>
{
public static readonly long[] Value=A016409.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016409.Bytes);
public long this[int i]=>Value[i];

public static A016409Inst Instance=new A016409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016408
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,-1L,-2L,-1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,-1L,-1L,-2L,-1L,-1L,0L,-1L,-1L,-2L,-1L,-1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,-1L,0L,-1L,0L };
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
public class A016408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016408Inst : IEnumerable<long>
{
public static readonly long[] Value=A016408.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016408.Bytes);
public long this[int i]=>Value[i];

public static A016408Inst Instance=new A016408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016407
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,1L,-1L,0L,0L,0L,1L,-1L,1L,-1L,0L,0L,0L,1L,-1L,1L,-1L,0L,0L };
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
public class A016407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016407Inst : IEnumerable<long>
{
public static readonly long[] Value=A016407.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016407.Bytes);
public long this[int i]=>Value[i];

public static A016407Inst Instance=new A016407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016406
{
public static readonly long[] Value={ 1L,0L,-1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,-1L,0L,2L,0L,-1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,-1L,0L,1L,0L,-1L,0L,1L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,-1L,0L,0L,0L,-1L,0L,0L,0L,-1L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,1L,0L,-1L,0L,1L,0L,-1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,-1L };
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
public class A016406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016406Inst : IEnumerable<long>
{
public static readonly long[] Value=A016406.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016406.Bytes);
public long this[int i]=>Value[i];

public static A016406Inst Instance=new A016406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016405
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,-1L,0L,0L,0L,0L,0L,0L,-1L,-1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,-1L,-1L,0L,0L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,0L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,1L,1L,0L,-1L,-1L,0L,1L,1L,1L,0L,-1L,-1L,-1L };
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
public class A016405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016405Inst : IEnumerable<long>
{
public static readonly long[] Value=A016405.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016405.Bytes);
public long this[int i]=>Value[i];

public static A016405Inst Instance=new A016405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016404
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,1L,-1L,0L,1L };
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
public class A016404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016404Inst : IEnumerable<long>
{
public static readonly long[] Value=A016404.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016404.Bytes);
public long this[int i]=>Value[i];

public static A016404Inst Instance=new A016404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016403
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L };
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
public class A016403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016403Inst : IEnumerable<long>
{
public static readonly long[] Value=A016403.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016403.Bytes);
public long this[int i]=>Value[i];

public static A016403Inst Instance=new A016403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016402
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,-1L,-1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,-1L,-1L,0L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,-1L,0L,1L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,-1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,-1L,0L,0L,-1L };
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
public class A016402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016402Inst : IEnumerable<long>
{
public static readonly long[] Value=A016402.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016402.Bytes);
public long this[int i]=>Value[i];

public static A016402Inst Instance=new A016402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016401
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,1L,-1L,0L };
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
public class A016401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016401Inst : IEnumerable<long>
{
public static readonly long[] Value=A016401.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016401.Bytes);
public long this[int i]=>Value[i];

public static A016401Inst Instance=new A016401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016400
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,0L,0L,-1L,-1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,-1L,0L,1L,1L,0L,0L,1L,1L,0L,-1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,-1L,0L,1L,1L,0L,0L,1L,1L,0L,-1L,-1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,-1L,-1L,0L,0L,0L,-1L,0L,1L,1L,0L,-1L,-1L,0L,0L,0L,-1L,-1L,0L,1L,1L };
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
public class A016400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016400Inst : IEnumerable<long>
{
public static readonly long[] Value=A016400.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016400.Bytes);
public long this[int i]=>Value[i];

public static A016400Inst Instance=new A016400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016399
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,1L };
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
public class A016399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016399Inst : IEnumerable<long>
{
public static readonly long[] Value=A016399.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016399.Bytes);
public long this[int i]=>Value[i];

public static A016399Inst Instance=new A016399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016398
{
public static readonly long[] Value={ 1L,-1L,1L,0L,0L,1L,-1L,1L,0L,0L,0L,0L,0L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,0L,0L,0L,0L,0L,-1L,1L,0L,-1L,1L,-1L,1L,0L,-1L,1L,0L,-1L,1L,-1L,0L,1L,-2L,1L,0L,-1L,1L,-1L,0L,1L,-2L,1L,0L,-1L,1L,-1L,0L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,0L,0L,0L,0L,0L,-1L,1L,0L,-1L,1L,-1L,1L };
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
public class A016398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016398Inst : IEnumerable<long>
{
public static readonly long[] Value=A016398.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016398.Bytes);
public long this[int i]=>Value[i];

public static A016398Inst Instance=new A016398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016397
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,0L,0L,-1L,-1L,-1L,-1L,-2L,-1L,-1L,-1L,-1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,-1L,-1L,-1L,-1L,-2L,-1L,-1L,-1L,-1L,0L,0L,1L,1L,2L,2L,2L,1L,1L,0L,0L,-1L,-1L,-1L,-1L,-2L,-1L,-1L,-1L,0L,1L,1L,2L,2L,1L,1L,1L,0L,0L,0L };
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
public class A016397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016397Inst : IEnumerable<long>
{
public static readonly long[] Value=A016397.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016397.Bytes);
public long this[int i]=>Value[i];

public static A016397Inst Instance=new A016397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016396
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,0L,0L };
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
public class A016396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016396Inst : IEnumerable<long>
{
public static readonly long[] Value=A016396.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016396.Bytes);
public long this[int i]=>Value[i];

public static A016396Inst Instance=new A016396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016395
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L };
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
public class A016395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016395Inst : IEnumerable<long>
{
public static readonly long[] Value=A016395.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016395.Bytes);
public long this[int i]=>Value[i];

public static A016395Inst Instance=new A016395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016394
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,-1L,0L,0L,0L,0L,-1L,-1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,-1L,0L,1L,0L,0L,0L,-1L,-1L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,1L,0L,-1L,0L,0L,-1L,0L,1L,0L,0L,0L,-1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,-1L,0L,0L,-1L,0L,0L,-1L };
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
public class A016394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016394Inst : IEnumerable<long>
{
public static readonly long[] Value=A016394.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016394.Bytes);
public long this[int i]=>Value[i];

public static A016394Inst Instance=new A016394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016393
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L };
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
public class A016393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016393Inst : IEnumerable<long>
{
public static readonly long[] Value=A016393.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016393.Bytes);
public long this[int i]=>Value[i];

public static A016393Inst Instance=new A016393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016392
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,-1L,-1L,0L,0L,0L,1L,1L,0L,0L,0L,-1L,-1L,0L,0L,0L,1L,1L,0L,0L,0L,-1L,-1L,0L,0L,0L,1L,1L,0L,0L,0L,-1L,-1L,-1L,-1L,0L,1L,1L,1L,1L,0L,-1L,-1L,-1L,-1L,0L,1L,1L,1L,1L,0L,-1L,-1L,-1L,-1L,0L,1L,1L,1L,1L,0L,-1L,-1L,-1L,-1L,0L,1L,1L,1L,1L,1L,0L,-1L,-1L,-1L,-1L,0L };
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
public class A016392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016392Inst : IEnumerable<long>
{
public static readonly long[] Value=A016392.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016392.Bytes);
public long this[int i]=>Value[i];

public static A016392Inst Instance=new A016392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016391
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,0L };
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
public class A016391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016391Inst : IEnumerable<long>
{
public static readonly long[] Value=A016391.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016391.Bytes);
public long this[int i]=>Value[i];

public static A016391Inst Instance=new A016391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016390
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,0L,0L,-1L,-1L,-1L,0L,0L,0L,0L,0L,0L,0L,-1L,-1L,-1L,0L,1L,1L,1L,1L,1L,1L,0L,-1L,-1L,-1L,0L,0L,0L,0L,0L,0L,0L,-1L,-1L,-1L,0L,1L,1L,1L,1L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,0L,0L,0L,-1L,-2L,-2L,-1L,0L,1L,1L,1L,1L,1L,0L,-1L,-2L,-1L,0L,1L,1L,1L,1L,1L,0L,-1L,-2L };
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
public class A016390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016390Inst : IEnumerable<long>
{
public static readonly long[] Value=A016390.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016390.Bytes);
public long this[int i]=>Value[i];

public static A016390Inst Instance=new A016390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016389
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L };
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
public class A016389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016389Inst : IEnumerable<long>
{
public static readonly long[] Value=A016389.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016389.Bytes);
public long this[int i]=>Value[i];

public static A016389Inst Instance=new A016389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016388
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,-1L,-1L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,-1L,-1L,-1L,-1L,-1L,-1L,0L,0L,1L,1L,2L,1L,1L,0L,0L,-1L,-1L,-1L,-1L,-1L,-1L,0L,0L,1L,1L,2L,1L,1L,0L,0L,-1L,-1L,-1L,-1L,-1L,-1L,0L,0L,1L,1L,2L,1L,1L,0L,0L,-1L,-1L,-1L,-1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,-1L };
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
public class A016388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016388Inst : IEnumerable<long>
{
public static readonly long[] Value=A016388.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016388.Bytes);
public long this[int i]=>Value[i];

public static A016388Inst Instance=new A016388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016387
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,1L,-1L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,1L,-1L,1L,-1L,0L,0L };
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
public class A016387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016387Inst : IEnumerable<long>
{
public static readonly long[] Value=A016387.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016387.Bytes);
public long this[int i]=>Value[i];

public static A016387Inst Instance=new A016387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016386
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,0L };
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
public class A016386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016386Inst : IEnumerable<long>
{
public static readonly long[] Value=A016386.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016386.Bytes);
public long this[int i]=>Value[i];

public static A016386Inst Instance=new A016386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016385
{
public static readonly long[] Value={ 1L,-1L,1L,0L,0L,1L,-1L,1L,0L,0L,0L,1L,-1L,1L,0L,-1L,2L,-2L,1L,0L,-1L,1L,-1L,0L,0L,0L,-1L,1L,-1L,0L,1L,-2L,2L,-2L,1L,0L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,0L,1L,-2L,2L,-2L,1L,0L,-1L,1L,-1L,0L,0L,0L,-1L,1L,-1L,0L,1L,-2L,2L,-1L,0L,1L,-1L,1L,0L,0L,0L,1L,-1L,1L,0L,0L,1L,-1L,1L };
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
public class A016385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016385Inst : IEnumerable<long>
{
public static readonly long[] Value=A016385.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016385.Bytes);
public long this[int i]=>Value[i];

public static A016385Inst Instance=new A016385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016384
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,1L,-1L,0L,0L,0L,1L,-1L,1L,-1L,0L,0L,0L,1L,-1L,1L,-1L,0L,0L,0L,1L,-1L,1L,-1L,0L,0L,0L,1L,-1L,1L,-1L,0L,0L };
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
public class A016384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016384Inst : IEnumerable<long>
{
public static readonly long[] Value=A016384.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016384.Bytes);
public long this[int i]=>Value[i];

public static A016384Inst Instance=new A016384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016383
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,1L,-1L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,0L,0L,0L };
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
public class A016383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016383Inst : IEnumerable<long>
{
public static readonly long[] Value=A016383.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016383.Bytes);
public long this[int i]=>Value[i];

public static A016383Inst Instance=new A016383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016382
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,-1L,-1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,-1L,-1L,-1L,-1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,-1L,-1L,-1L,-1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,-1L,-1L,-1L,-1L,-1L,-1L,0L,1L,1L,1L,1L,1L,1L,0L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,0L,1L,1L,1L,1L,1L,1L,0L,-1L,-1L,-1L };
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
public class A016382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016382Inst : IEnumerable<long>
{
public static readonly long[] Value=A016382.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016382.Bytes);
public long this[int i]=>Value[i];

public static A016382Inst Instance=new A016382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016381
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,1L };
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
public class A016381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016381Inst : IEnumerable<long>
{
public static readonly long[] Value=A016381.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016381.Bytes);
public long this[int i]=>Value[i];

public static A016381Inst Instance=new A016381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016380
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,-2L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,0L };
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
public class A016380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016380Inst : IEnumerable<long>
{
public static readonly long[] Value=A016380.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016380.Bytes);
public long this[int i]=>Value[i];

public static A016380Inst Instance=new A016380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016379
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,-1L,-1L,0L,0L,0L,1L,1L,0L,0L,0L,-1L,-1L,0L,0L,0L,1L,1L,0L,0L,0L,-1L,-1L,0L,0L,0L,1L,0L,-1L,0L,0L,-1L,0L,1L,0L,0L,1L,0L,-1L,0L,0L,-1L,0L,1L,0L,0L,1L,0L,-1L,0L,0L,-1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,-1L,0L,0L,-1L,0L,1L,0L,0L,1L,0L,-1L,0L,0L,-1L,0L,1L };
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
public class A016379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016379Inst : IEnumerable<long>
{
public static readonly long[] Value=A016379.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016379.Bytes);
public long this[int i]=>Value[i];

public static A016379Inst Instance=new A016379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016378
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,-1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,0L,-1L,0L,-1L,0L,0L,0L,1L,0L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,0L,-1L,0L,-1L,0L,0L,0L,1L,0L,0L,0L,-1L,0L,0L };
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
public class A016378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016378Inst : IEnumerable<long>
{
public static readonly long[] Value=A016378.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016378.Bytes);
public long this[int i]=>Value[i];

public static A016378Inst Instance=new A016378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016377
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,1L,0L,-1L,0L };
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
public class A016377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016377Inst : IEnumerable<long>
{
public static readonly long[] Value=A016377.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016377.Bytes);
public long this[int i]=>Value[i];

public static A016377Inst Instance=new A016377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016376
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L };
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
public class A016376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016376Inst : IEnumerable<long>
{
public static readonly long[] Value=A016376.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016376.Bytes);
public long this[int i]=>Value[i];

public static A016376Inst Instance=new A016376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016375
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,-1L,-1L,0L,0L,0L,1L,1L,0L,0L,0L,-1L,-1L,0L,0L,0L,1L,1L,0L,0L,0L,-1L,-1L,0L,0L,-1L,0L,1L,0L,0L,1L,0L,-1L,0L,0L,-1L,0L,1L,0L,0L,1L,0L,-1L,0L,0L,-1L,0L,1L,0L,0L,1L,0L,-1L,0L,1L,0L,0L,1L,0L,-1L,0L,0L,-1L,0L,1L,0L,0L,1L,0L,-1L,0L,0L,-1L,0L,1L,0L,0L };
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
public class A016375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016375Inst : IEnumerable<long>
{
public static readonly long[] Value=A016375.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016375.Bytes);
public long this[int i]=>Value[i];

public static A016375Inst Instance=new A016375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016374
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,1L,0L,-1L,0L,0L };
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
public class A016374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016374Inst : IEnumerable<long>
{
public static readonly long[] Value=A016374.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016374.Bytes);
public long this[int i]=>Value[i];

public static A016374Inst Instance=new A016374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016373
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,-1L,-1L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,-1L };
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
public class A016373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016373Inst : IEnumerable<long>
{
public static readonly long[] Value=A016373.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016373.Bytes);
public long this[int i]=>Value[i];

public static A016373Inst Instance=new A016373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016372
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,-1L,-1L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,-1L,-2L,-2L,-1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,-1L,-2L,-2L,-1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,-1L,-2L,-2L,-1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,-1L,-2L,-2L,-2L,-1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,-1L,-2L,-2L,-2L };
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
public class A016372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016372Inst : IEnumerable<long>
{
public static readonly long[] Value=A016372.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016372.Bytes);
public long this[int i]=>Value[i];

public static A016372Inst Instance=new A016372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016371
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,-1L,0L,0L,0L,-1L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,-1L,0L,0L,0L,-1L,0L,0L,0L,-1L,0L,0L,0L,0L };
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
public class A016371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016371Inst : IEnumerable<long>
{
public static readonly long[] Value=A016371.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016371.Bytes);
public long this[int i]=>Value[i];

public static A016371Inst Instance=new A016371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016370
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,0L,0L,-1L,-1L,-1L,0L,0L,0L,-1L,-1L,-1L,0L,0L,0L,0L,1L,2L,2L,1L,0L,0L,0L,0L,-1L,-1L,-1L,0L,0L,0L,-1L,-1L,-1L,0L,0L,1L,1L,2L,2L,2L,1L,0L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,0L,1L,2L,2L,2L,2L,2L,1L,0L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,0L,1L,2L };
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
public class A016370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016370Inst : IEnumerable<long>
{
public static readonly long[] Value=A016370.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016370.Bytes);
public long this[int i]=>Value[i];

public static A016370Inst Instance=new A016370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016369
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,-1L,-1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,-1L,-1L,-1L,-1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,-1L,-1L,-1L,-1L,0L,1L,1L,1L,1L,1L,1L,0L,-1L,-1L,-1L,-1L,-1L,-1L,0L,1L,1L,1L,1L,1L,0L,-1L,-1L,-1L,-1L,-1L,-1L,0L,1L,1L,1L,1L,1L,1L,0L,-1L,-1L,-1L,-1L,0L,0L,0L,1L,1L };
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
public class A016369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016369Inst : IEnumerable<long>
{
public static readonly long[] Value=A016369.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016369.Bytes);
public long this[int i]=>Value[i];

public static A016369Inst Instance=new A016369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016368
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,-1L,0L,-1L,0L,-1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L };
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
public class A016368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016368Inst : IEnumerable<long>
{
public static readonly long[] Value=A016368.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016368.Bytes);
public long this[int i]=>Value[i];

public static A016368Inst Instance=new A016368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016367
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,1L,-1L,0L,0L,0L,1L,-1L,1L,-1L,0L,0L,0L,1L,-1L,1L,-1L,0L,0L,0L,1L,-1L,1L,-1L,0L,0L,0L,1L,-1L,1L,-1L,0L,0L,0L,1L,-1L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L };
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
public class A016367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016367Inst : IEnumerable<long>
{
public static readonly long[] Value=A016367.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016367.Bytes);
public long this[int i]=>Value[i];

public static A016367Inst Instance=new A016367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016366
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,-1L,-1L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,-1L,-1L,-1L,-1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,-1L,-1L,-1L,-1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,-1L,-1L,-1L,0L,1L,2L,1L,0L,-1L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,-1L,0L,1L,2L,1L,0L,-1L,-1L,-1L };
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
public class A016366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016366Inst : IEnumerable<long>
{
public static readonly long[] Value=A016366.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016366.Bytes);
public long this[int i]=>Value[i];

public static A016366Inst Instance=new A016366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016365
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L };
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
public class A016365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016365Inst : IEnumerable<long>
{
public static readonly long[] Value=A016365.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016365.Bytes);
public long this[int i]=>Value[i];

public static A016365Inst Instance=new A016365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016364
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,1L,0L,0L,-1L,0L };
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
public class A016364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016364Inst : IEnumerable<long>
{
public static readonly long[] Value=A016364.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016364.Bytes);
public long this[int i]=>Value[i];

public static A016364Inst Instance=new A016364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016363
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,-1L,-1L,0L,0L,0L,0L,0L,1L,1L,0L,-1L,-1L,0L,0L,-1L,-1L,0L,1L,1L,0L,0L,1L,1L,0L,-1L,-1L,0L,1L,0L,-1L,0L,1L,1L,0L,-1L,0L,1L,0L,-1L,-1L,0L,1L,0L,-1L,-1L,0L,1L,0L,-1L,0L,1L,1L,0L,-1L,0L,1L,0L,-1L,-1L,0L,1L,1L,0L,0L,1L,1L,0L,-1L,-1L,0L,0L,-1L,-1L,0L };
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
public class A016363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016363Inst : IEnumerable<long>
{
public static readonly long[] Value=A016363.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016363.Bytes);
public long this[int i]=>Value[i];

public static A016363Inst Instance=new A016363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016362
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,0L,0L,-1L,-1L,-1L,0L,-1L,-1L,-1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,-1L,-1L,-1L,0L,-1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,-1L,-1L,0L,0L,-1L,-1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,-1L,-1L,0L,0L,-1L,-1L,0L,1L,0L,0L,0L };
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
public class A016362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016362Inst : IEnumerable<long>
{
public static readonly long[] Value=A016362.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016362.Bytes);
public long this[int i]=>Value[i];

public static A016362Inst Instance=new A016362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016361
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,-1L,-1L,0L,0L,0L,1L,1L,0L,0L,0L,-1L,-1L,0L,0L,0L,1L,1L,0L,-1L,-1L,-1L,-1L,0L,1L,1L,1L,1L,0L,-1L,-1L,-1L,-1L,0L,1L,1L,1L,1L,0L,-1L,-1L,-1L,0L,1L,1L,1L,1L,0L,-1L,-1L,-1L,-1L,0L,1L,1L,1L,1L,0L,-1L,-1L,-1L,-1L,0L,1L,1L,0L,0L,0L,-1L,-1L,0L,0L,0L,1L,1L,0L,0L,0L,-1L,-1L,0L,0L,0L,1L,1L };
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
public class A016361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016361Inst : IEnumerable<long>
{
public static readonly long[] Value=A016361.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016361.Bytes);
public long this[int i]=>Value[i];

public static A016361Inst Instance=new A016361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016360
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,0L,1L,0L,-1L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,0L,1L,0L,-1L,0L,1L,0L,-1L,0L,0L,1L,-1L,0L,0L,1L,0L,-1L,0L };
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
public class A016360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016360Inst : IEnumerable<long>
{
public static readonly long[] Value=A016360.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016360.Bytes);
public long this[int i]=>Value[i];

public static A016360Inst Instance=new A016360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016359
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L };
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
public class A016359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016359Inst : IEnumerable<long>
{
public static readonly long[] Value=A016359.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016359.Bytes);
public long this[int i]=>Value[i];

public static A016359Inst Instance=new A016359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016358
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,1L,-1L,0L,1L,-1L,0L,1L,0L,-1L,0L,1L,-1L,0L,1L,0L,-1L,0L,1L,-1L,0L,1L,0L,-1L,0L,1L };
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
public class A016358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016358Inst : IEnumerable<long>
{
public static readonly long[] Value=A016358.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016358.Bytes);
public long this[int i]=>Value[i];

public static A016358Inst Instance=new A016358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016357
{
public static readonly long[] Value={ 1L,-1L,1L,0L,0L,1L,-1L,2L,-1L,1L,0L,0L,1L,-1L,1L,-1L,1L,-1L,0L,0L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,-1L,0L,0L,-1L,1L,-1L,1L,-1L,1L,0L,0L,1L,-1L,2L,-1L,1L,0L,0L,1L,-1L,1L };
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
public class A016357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016357Inst : IEnumerable<long>
{
public static readonly long[] Value=A016357.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016357.Bytes);
public long this[int i]=>Value[i];

public static A016357Inst Instance=new A016357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016356
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,0L,1L,-1L,1L,0L,-1L,1L,-1L };
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
public class A016356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016356Inst : IEnumerable<long>
{
public static readonly long[] Value=A016356.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016356.Bytes);
public long this[int i]=>Value[i];

public static A016356Inst Instance=new A016356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016355
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,-1L };
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
public class A016355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016355Inst : IEnumerable<long>
{
public static readonly long[] Value=A016355.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016355.Bytes);
public long this[int i]=>Value[i];

public static A016355Inst Instance=new A016355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016354
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,1L };
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
public class A016354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016354Inst : IEnumerable<long>
{
public static readonly long[] Value=A016354.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016354.Bytes);
public long this[int i]=>Value[i];

public static A016354Inst Instance=new A016354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016353
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,-1L,-1L,-1L,0L,0L,0L,0L,0L,-1L,-1L,0L,1L,1L,1L,1L,0L,-1L,-1L,0L,0L,0L,0L,0L,-1L,-1L,0L,1L,1L,1L,1L,0L,-1L,-1L,0L,1L,1L,1L,0L,-1L,-2L,-1L,0L,1L,1L,1L,0L,-1L,-2L,-1L,0L,1L,1L,1L,0L,-1L,-1L,0L,1L,1L,1L,1L,0L,-1L,-1L,0L,0L,0L,0L,0L,-1L,-1L,0L,1L,1L,1L,1L };
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
public class A016353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016353Inst : IEnumerable<long>
{
public static readonly long[] Value=A016353.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016353.Bytes);
public long this[int i]=>Value[i];

public static A016353Inst Instance=new A016353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016352
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,-1L,-1L,0L,0L,0L,1L,1L,0L,0L,0L,-1L,-1L,0L,0L,-1L,0L,1L,0L,0L,1L,0L,-1L,0L,0L,-1L,0L,1L,0L,0L,1L,0L,-1L,0L,1L,0L,0L,1L,0L,-1L,0L,0L,-1L,0L,1L,0L,0L,1L,0L,-1L,0L,0L,-1L,-1L,0L,0L,0L,1L,1L,0L,0L,0L,-1L,-1L,0L,0L,0L,1L,1L };
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
public class A016352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016352Inst : IEnumerable<long>
{
public static readonly long[] Value=A016352.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016352.Bytes);
public long this[int i]=>Value[i];

public static A016352Inst Instance=new A016352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016351
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,0L,-1L,0L,0L,0L,1L,0L,-1L,0L,0L,1L,0L,-1L,0L,0L,0L,1L,0L,-1L,0L,0L,1L,0L,0L,-1L,0L,0L,1L,0L,-1L,0L,0L,1L,0L,0L,-1L };
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
public class A016351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016351Inst : IEnumerable<long>
{
public static readonly long[] Value=A016351.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016351.Bytes);
public long this[int i]=>Value[i];

public static A016351Inst Instance=new A016351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016350
{
public static readonly long[] Value={ 1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L };
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
public class A016350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016350Inst : IEnumerable<long>
{
public static readonly long[] Value=A016350.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016350.Bytes);
public long this[int i]=>Value[i];

public static A016350Inst Instance=new A016350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016301
{
public static readonly long[] Value={ 1L,18L,237L,2810L,31941L,356538L,3947917L,43557210L,479780181L,5280836858L,58105480797L,639241667610L,7032065242021L,77354752161978L,850912446296877L,9360087771874010L,102961219803721461L,1132574689406603898L };
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
public class A016301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016301Inst : IEnumerable<long>
{
public static readonly long[] Value=A016301.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016301.Bytes);
public long this[int i]=>Value[i];

public static A016301Inst Instance=new A016301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016300
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,-1L };
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
public class A016300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016300Inst : IEnumerable<long>
{
public static readonly long[] Value=A016300.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016300.Bytes);
public long this[int i]=>Value[i];

public static A016300Inst Instance=new A016300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016299
{
public static readonly long[] Value={ 1L,17L,209L,2293L,23961L,244797L,2473969L,24869813L,249349001L,2496744877L,24983724129L,249918620133L,2499593099641L,24997965496157L,249989827476689L,2499949137375253L,24999745686859881L,249998728434266637L };
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
public class A016299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016299Inst : IEnumerable<long>
{
public static readonly long[] Value=A016299.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016299.Bytes);
public long this[int i]=>Value[i];

public static A016299Inst Instance=new A016299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016298
{
public static readonly long[] Value={ 1L,16L,183L,1850L,17681L,164316L,1504843L,13673710L,123714261L,1116683216L,10066424303L,90679197570L,816519676441L,7350711587716L,66166576804563L,595550053849430L,5360204797752221L,48243114745437816L };
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
public class A016298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016298Inst : IEnumerable<long>
{
public static readonly long[] Value=A016298.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016298.Bytes);
public long this[int i]=>Value[i];

public static A016298Inst Instance=new A016298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016297
{
public static readonly long[] Value={ 1L,15L,159L,1475L,12831L,107835L,888679L,7239555L,58567311L,471793355L,3790622199L,30406356435L,243657749791L,1951296498075L,15620544499719L,125015218606115L,1000376061956271L,8004280061317995L,64040598319145239L };
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
public class A016297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016297Inst : IEnumerable<long>
{
public static readonly long[] Value=A016297.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016297.Bytes);
public long this[int i]=>Value[i];

public static A016297Inst Instance=new A016297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016296
{
public static readonly long[] Value={ 1L,14L,137L,1162L,9165L,69342L,511393L,3709874L,26619989L,189594790L,1343438889L,9485451066L,66805055773L,469669890158L,3297861746225L,23135894831938L,162205576930917L,1136710604184246L,7963332057891001L };
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
public class A016296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016296Inst : IEnumerable<long>
{
public static readonly long[] Value=A016296.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016296.Bytes);
public long this[int i]=>Value[i];

public static A016296Inst Instance=new A016296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016295
{
public static readonly long[] Value={ 1L,13L,117L,905L,6461L,43953L,289717L,1868425L,11861421L,74423393L,462815717L,2858273145L,17556537181L,107373722833L,654414852117L,3977351721065L,24118423433741L,145982106270273L,882250466222917L };
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
public class A016295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016295Inst : IEnumerable<long>
{
public static readonly long[] Value=A016295.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016295.Bytes);
public long this[int i]=>Value[i];

public static A016295Inst Instance=new A016295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016294
{
public static readonly long[] Value={ 1L,18L,244L,3048L,37072L,446880L,5370688L,64480896L,773901568L,9287342592L,111450207232L,1337410873344L,16048964030464L,192587702575104L,2311052967755776L,27732637760520192L,332791661716111360L };
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
public class A016294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016294Inst : IEnumerable<long>
{
public static readonly long[] Value=A016294.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016294.Bytes);
public long this[int i]=>Value[i];

public static A016294Inst Instance=new A016294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016293
{
public static readonly BigInteger[] Value={ 1L,17L,215L,2485L,27831L,308157L,3397855L,37409045L,411630311L,4528457197L,49815125295L,547974764805L,6027755963191L,66305449804637L,729360484705535L,8022967479211765L,88252650861198471L,970779193832790477L,10678571269599386575UL,BigInteger.Parse("117464284515348541925") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016293Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A016293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016293.Bytes);
public BigInteger this[int i]=>Value[i];

public static A016293Inst Instance=new A016293Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016292
{
public static readonly BigInteger[] Value={ 1L,16L,188L,2000L,20496L,206976L,2077888L,20811520L,208246016L,2082983936L,20831935488L,208327741440L,2083310964736L,20833243856896L,208332975423488L,2083331901685760L,20833327606726656L,208333310426873856L,2083333241707429888L,BigInteger.Parse("20833332966829588480") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016292Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A016292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016292.Bytes);
public BigInteger this[int i]=>Value[i];

public static A016292Inst Instance=new A016292Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016291
{
public static readonly BigInteger[] Value={ 1L,15L,163L,1587L,14779L,135027L,1223371L,11042979L,99517627L,896182419L,8067737899L,72618027651L,653595799195L,5882496402291L,52943004475147L,476489187727203L,4288411279413883L,38595735874332243L,347361760307681515L,3126256392524423235L,BigInteger.Parse("28136309731742016091") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016291Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A016291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016291.Bytes);
public BigInteger this[int i]=>Value[i];

public static A016291Inst Instance=new A016291Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016290
{
public static readonly BigInteger[] Value={ 1L,14L,140L,1240L,10416L,85344L,690880L,5559680L,44608256L,357389824L,2861214720L,22898104320L,183218384896L,1465881288704L,11727587164160L,93822844764160L,750591347982336L,6004765143465984L,48038258586419200L,384306618446643200L,3074455146595352576L,BigInteger.Parse("24595649968853745664") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016290Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A016290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016290.Bytes);
public BigInteger this[int i]=>Value[i];

public static A016290Inst Instance=new A016290Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016289
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,-1L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,-1L };
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
public class A016289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016289Inst : IEnumerable<long>
{
public static readonly long[] Value=A016289.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016289.Bytes);
public long this[int i]=>Value[i];

public static A016289Inst Instance=new A016289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016288
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L };
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
public class A016288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016288Inst : IEnumerable<long>
{
public static readonly long[] Value=A016288.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016288.Bytes);
public long this[int i]=>Value[i];

public static A016288Inst Instance=new A016288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016287
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L };
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
public class A016287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016287Inst : IEnumerable<long>
{
public static readonly long[] Value=A016287.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016287.Bytes);
public long this[int i]=>Value[i];

public static A016287Inst Instance=new A016287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016286
{
public static readonly long[] Value={ 1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L };
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
public class A016286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016286Inst : IEnumerable<long>
{
public static readonly long[] Value=A016286.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016286.Bytes);
public long this[int i]=>Value[i];

public static A016286Inst Instance=new A016286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016269
{
public static readonly long[] Value={ 1L,9L,55L,285L,1351L,6069L,26335L,111645L,465751L,1921029L,7859215L,31964205L,129442951L,522538389L,2104469695L,8460859965L,33972448951L,136276954149L,546269553775L,2188563950925L,8764714059751L };
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
public class A016269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016269Inst : IEnumerable<long>
{
public static readonly long[] Value=A016269.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016269.Bytes);
public long this[int i]=>Value[i];

public static A016269Inst Instance=new A016269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016268
{
public static readonly long[] Value={ 1L,24L,421L,6516L,94297L,1308720L,17653357L,233276172L,3035108833L,39015048456L,496711748533L,6274383820068L,78744877055209L,982913508020832L,12212686913191549L,151147215944655804L,1864311294185799025L };
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
public class A016268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016268Inst : IEnumerable<long>
{
public static readonly long[] Value=A016268.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016268.Bytes);
public long this[int i]=>Value[i];

public static A016268Inst Instance=new A016268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016267
{
public static readonly long[] Value={ 1L,23L,387L,5755L,80171L,1073163L,13989067L,178979915L,2258870091L,28217552203L,349721737547L,4307771961675L,52804374651211L,644763606925643L,7848274394218827L,95290403841737035L,1154595957211955531L };
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
public class A016267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016267Inst : IEnumerable<long>
{
public static readonly long[] Value=A016267.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016267.Bytes);
public long this[int i]=>Value[i];

public static A016267Inst Instance=new A016267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016266
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L };
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
public class A016266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016266Inst : IEnumerable<long>
{
public static readonly long[] Value=A016266.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016266.Bytes);
public long this[int i]=>Value[i];

public static A016266Inst Instance=new A016266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016265
{
public static readonly long[] Value={ 1L,22L,353L,4994L,66045L,837606L,10324777L,124683658L,1482631349L,17420055950L,202731726561L,2341160103282L,26863872247213L,306613705830454L,3483861875246105L,39433591738818266L,444880620238112037L };
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
public class A016265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016265Inst : IEnumerable<long>
{
public static readonly long[] Value=A016265.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016265.Bytes);
public long this[int i]=>Value[i];

public static A016265Inst Instance=new A016265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016264
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,0L,-1L,0L,0L,1L,0L,-1L,0L,0L,1L,0L,0L,-1L,0L,1L,0L,0L,-1L,0L,1L,0L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,0L,-1L,0L,0L,1L,0L,-1L,0L,0L,1L,0L,0L,-1L,0L,1L,0L,0L,-1L,0L,1L,0L,0L,0L,-1L,1L,0L,0L,0L,-1L };
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
public class A016264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016264Inst : IEnumerable<long>
{
public static readonly long[] Value=A016264.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016264.Bytes);
public long this[int i]=>Value[i];

public static A016264Inst Instance=new A016264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016263
{
public static readonly long[] Value={ 1L,22L,355L,5080L,68341L,886522L,11236135L,140214460L,1731001081L,21207861022L,258416964715L,3136307268640L,37953420452221L,458300644483522L,5525344125314095L,66535757027375620L,800513732040965761L };
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
public class A016263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016263Inst : IEnumerable<long>
{
public static readonly long[] Value=A016263.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016263.Bytes);
public long this[int i]=>Value[i];

public static A016263Inst Instance=new A016263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016262
{
public static readonly BigInteger[] Value={ 1L,21L,322L,4362L,55363L,675423L,8027524L,93683604L,1078947205L,12304267305L,139269572806L,1567268992926L,17557692150727L,195994212714867L,2181672731375368L,24230027568735528L,268614950968549129L,2973526290066165309L,BigInteger.Parse("32877645655436942410"),BigInteger.Parse("363173810392188482610") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016262Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A016262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016262.Bytes);
public BigInteger this[int i]=>Value[i];

public static A016262Inst Instance=new A016262Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016261
{
public static readonly BigInteger[] Value={ 1L,20L,291L,3730L,44681L,513240L,5730271L,62683550L,675263061L,7188478660L,75807419051L,793377882570L,8251512054241L,85374719599280L,879483587504631L,9026463398652790L,92349281698986221L,942254646401987100L,9591402928728995011UL,BigInteger.Parse("97433737469672066210") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016261Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A016261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016261.Bytes);
public BigInteger this[int i]=>Value[i];

public static A016261Inst Instance=new A016261Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016260
{
public static readonly long[] Value={ 1L,21L,325L,4485L,58501L,739461L,9173125L,112474245L,1368864901L,16579770501L,200184379525L,2412029622405L,29022892013701L,348902996523141L,4191862297147525L,50342558276728965L,604432385008416901L };
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
public class A016260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016260Inst : IEnumerable<long>
{
public static readonly long[] Value=A016260.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016260.Bytes);
public long this[int i]=>Value[i];

public static A016260Inst Instance=new A016260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016259
{
public static readonly long[] Value={ 1L,20L,293L,3808L,46569L,549708L,6346381L,72206936L,813450257L,9101344516L,101341923189L,1124578223184L,12448896999865L,137566159357244L,1518254091799517L,16741005720753352L,184472748615956193L };
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
public class A016259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016259Inst : IEnumerable<long>
{
public static readonly long[] Value=A016259.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A016259.Bytes);
public long this[int i]=>Value[i];

public static A016259Inst Instance=new A016259Inst();

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