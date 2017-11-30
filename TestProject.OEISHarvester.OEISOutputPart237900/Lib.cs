using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A019637
{
public static readonly long[] Value={ 4L,5L,9L,1L,9L,2L,3L,7L,2L,6L,8L,0L,2L,7L,6L,9L,9L,3L,1L,6L,3L,2L,6L,5L,7L,6L,4L,9L,2L,2L,2L,0L,5L,8L,4L,9L,9L,3L,8L,3L,9L,1L,3L,2L,4L,1L,1L,0L,1L,4L,5L,3L,8L,3L,5L,0L,6L,2L,9L,4L,5L,8L,3L,7L,5L,5L,3L,2L,8L,6L,5L,8L,7L,2L,3L,7L,1L,3L,0L,0L,3L,5L,9L,5L,8L,3L,5L,5L,9L,5L,8L,2L,8L,3L,8L,5L,1L,4L,2L };
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
public class A019637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019637Inst : IEnumerable<long>
{
public static readonly long[] Value=A019637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019637.Bytes);
public long this[int i]=>Value[i];

public static A019637Inst Instance=new A019637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019638
{
public static readonly long[] Value={ 3L,7L,5L,7L,0L,2L,8L,5L,0L,3L,7L,4L,7L,7L,2L,0L,8L,5L,3L,1L,5L,3L,9L,9L,2L,6L,2L,2L,0L,9L,0L,7L,7L,5L,1L,3L,5L,8L,5L,9L,5L,6L,5L,3L,7L,9L,0L,8L,3L,0L,0L,7L,6L,8L,3L,2L,3L,3L,3L,1L,9L,3L,2L,1L,6L,3L,4L,5L,0L,7L,2L,0L,7L,7L,3L,9L,4L,7L,0L,0L,2L,9L,4L,2L,0L,4L,7L,3L,0L,5L,6L,7L,7L,7L,6L,9L,6L,6L,2L };
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
public class A019638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019638Inst : IEnumerable<long>
{
public static readonly long[] Value=A019638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019638.Bytes);
public long this[int i]=>Value[i];

public static A019638Inst Instance=new A019638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019639
{
public static readonly long[] Value={ 3L,1L,7L,9L,0L,2L,4L,1L,1L,8L,5L,5L,5L,7L,6L,3L,7L,9L,8L,8L,2L,2L,6L,0L,9L,1L,4L,1L,7L,6L,9L,1L,1L,7L,4L,2L,2L,6L,5L,0L,4L,0L,1L,4L,7L,4L,6L,0L,8L,6L,9L,8L,8L,0L,8L,8L,8L,9L,7L,3L,1L,7L,3L,3L,6L,9L,0L,7L,3L,6L,8L,6L,8L,0L,8L,7L,2L,4L,3L,8L,7L,1L,0L,4L,8L,0L,9L,2L,5L,8L,6L,5L,0L,4L,2L,0L,4L,8L,3L };
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
public class A019639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019639Inst : IEnumerable<long>
{
public static readonly long[] Value=A019639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019639.Bytes);
public long this[int i]=>Value[i];

public static A019639Inst Instance=new A019639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019640
{
public static readonly long[] Value={ 2L,7L,5L,5L,1L,5L,4L,2L,3L,6L,0L,8L,1L,6L,6L,1L,9L,5L,8L,9L,7L,9L,5L,9L,4L,5L,8L,9L,5L,3L,3L,2L,3L,5L,0L,9L,9L,6L,3L,0L,3L,4L,7L,9L,4L,4L,6L,6L,0L,8L,7L,2L,3L,0L,1L,0L,3L,7L,7L,6L,7L,5L,0L,2L,5L,3L,1L,9L,7L,1L,9L,5L,2L,3L,4L,2L,2L,7L,8L,0L,2L,1L,5L,7L,5L,0L,1L,3L,5L,7L,4L,9L,7L,0L,3L,1L,0L,8L,5L };
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
public class A019640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019640Inst : IEnumerable<long>
{
public static readonly long[] Value=A019640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019640.Bytes);
public long this[int i]=>Value[i];

public static A019640Inst Instance=new A019640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019641
{
public static readonly long[] Value={ 2L,4L,3L,1L,0L,1L,8L,4L,4L,3L,6L,0L,1L,4L,6L,6L,4L,3L,4L,3L,9L,3L,7L,5L,9L,9L,3L,1L,9L,4L,1L,0L,8L,9L,7L,9L,3L,7L,9L,1L,4L,8L,3L,4L,8L,0L,5L,8L,3L,1L,2L,2L,6L,1L,8L,5L,6L,2L,7L,3L,6L,0L,3L,1L,6L,4L,5L,8L,5L,7L,6L,0L,5L,0L,0L,7L,8L,9L,2L,3L,7L,1L,9L,7L,7L,9L,5L,3L,1L,5L,4L,3L,8L,5L,5L,6L,8L,4L,0L };
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
public class A019641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019641Inst : IEnumerable<long>
{
public static readonly long[] Value=A019641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019641.Bytes);
public long this[int i]=>Value[i];

public static A019641Inst Instance=new A019641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019642
{
public static readonly long[] Value={ 2L,1L,7L,5L,1L,2L,1L,7L,6L,5L,3L,2L,7L,6L,2L,7L,8L,6L,2L,3L,5L,2L,3L,1L,1L,5L,1L,8L,0L,5L,2L,5L,5L,4L,0L,2L,6L,0L,2L,3L,9L,5L,8L,9L,0L,3L,6L,7L,9L,6L,3L,6L,0L,2L,7L,1L,3L,5L,0L,7L,9L,6L,0L,7L,2L,6L,2L,0L,8L,3L,1L,2L,0L,2L,7L,0L,2L,1L,9L,4L,9L,0L,7L,1L,7L,1L,1L,5L,9L,8L,0L,2L,3L,9L,7L,1L,9L,0L,9L };
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
public class A019642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019642Inst : IEnumerable<long>
{
public static readonly long[] Value=A019642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019642.Bytes);
public long this[int i]=>Value[i];

public static A019642Inst Instance=new A019642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019643
{
public static readonly long[] Value={ 1L,9L,6L,7L,9L,6L,7L,3L,1L,1L,4L,8L,6L,9L,0L,1L,3L,9L,9L,2L,7L,1L,1L,3L,8L,9L,9L,2L,5L,2L,3L,7L,3L,9L,3L,5L,6L,8L,7L,8L,8L,1L,9L,9L,6L,0L,4L,7L,2L,0L,5L,1L,6L,4L,3L,5L,9L,8L,4L,0L,5L,3L,5L,8L,9L,5L,1L,4L,0L,8L,5L,3L,7L,3L,8L,7L,3L,4L,1L,4L,4L,3L,9L,8L,2L,1L,5L,2L,5L,5L,3L,5L,5L,0L,2L,2L,2L,0L,3L };
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
public class A019643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019643Inst : IEnumerable<long>
{
public static readonly long[] Value=A019643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019643.Bytes);
public long this[int i]=>Value[i];

public static A019643Inst Instance=new A019643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019644
{
public static readonly long[] Value={ 1L,7L,9L,6L,8L,3L,9L,7L,1L,9L,1L,8L,3L,6L,9L,2L,5L,8L,1L,9L,4L,3L,2L,1L,3L,8L,6L,2L,7L,3L,9L,0L,6L,6L,3L,6L,9L,3L,2L,4L,1L,3L,9L,9L,6L,3L,9L,0L,9L,2L,6L,4L,5L,4L,4L,1L,5L,5L,0L,6L,5L,7L,6L,2L,5L,2L,0L,8L,5L,1L,2L,7L,3L,2L,6L,6L,7L,0L,3L,0L,5L,7L,5L,4L,8L,9L,2L,1L,8L,9L,6L,7L,1L,9L,7L,6L,7L,9L,4L };
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
public class A019644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019644Inst : IEnumerable<long>
{
public static readonly long[] Value=A019644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019644.Bytes);
public long this[int i]=>Value[i];

public static A019644Inst Instance=new A019644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019645
{
public static readonly long[] Value={ 2L,9L,2L,2L,2L,8L,2L,3L,6L,5L,3L,2L,2L,2L,7L,7L,8L,6L,4L,5L,4L,1L,6L,2L,3L,0L,7L,6L,1L,0L,7L,6L,8L,2L,3L,1L,5L,3L,9L,7L,9L,0L,7L,5L,5L,2L,6L,4L,6L,5L,6L,6L,8L,5L,9L,0L,1L,7L,7L,4L,0L,0L,1L,1L,4L,7L,1L,9L,5L,6L,1L,7L,2L,3L,6L,2L,9L,5L,6L,8L,8L,4L,4L,4L,3L,9L,5L,6L,5L,6L,7L,7L,6L,7L,0L,5L,8L,9L,2L };
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
public class A019645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019645Inst : IEnumerable<long>
{
public static readonly long[] Value=A019645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019645.Bytes);
public long this[int i]=>Value[i];

public static A019645Inst Instance=new A019645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019646
{
public static readonly long[] Value={ 1L,4L,6L,1L,1L,4L,1L,1L,8L,2L,6L,6L,1L,1L,3L,8L,9L,3L,2L,2L,7L,0L,8L,1L,1L,5L,3L,8L,0L,5L,3L,8L,4L,1L,1L,5L,7L,6L,9L,8L,9L,5L,3L,7L,7L,6L,3L,2L,3L,2L,8L,3L,4L,2L,9L,5L,0L,8L,8L,7L,0L,0L,0L,5L,7L,3L,5L,9L,7L,8L,0L,8L,6L,1L,8L,1L,4L,7L,8L,4L,4L,2L,2L,2L,1L,9L,7L,8L,2L,8L,3L,8L,8L,3L,5L,2L,9L,4L,6L };
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
public class A019646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019646Inst : IEnumerable<long>
{
public static readonly long[] Value=A019646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019646.Bytes);
public long this[int i]=>Value[i];

public static A019646Inst Instance=new A019646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019647
{
public static readonly long[] Value={ 9L,7L,4L,0L,9L,4L,1L,2L,1L,7L,7L,4L,0L,9L,2L,6L,2L,1L,5L,1L,3L,8L,7L,4L,3L,5L,8L,7L,0L,2L,5L,6L,0L,7L,7L,1L,7L,9L,9L,3L,0L,2L,5L,1L,7L,5L,4L,8L,8L,5L,5L,6L,1L,9L,6L,7L,2L,5L,8L,0L,0L,0L,3L,8L,2L,3L,9L,8L,5L,3L,9L,0L,7L,8L,7L,6L,5L,2L,2L,9L,4L,8L,1L,4L,6L,5L,2L,1L,8L,9L,2L,5L,5L,6L,8L,6L,3L,0L,8L };
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
public class A019647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019647Inst : IEnumerable<long>
{
public static readonly long[] Value=A019647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019647.Bytes);
public long this[int i]=>Value[i];

public static A019647Inst Instance=new A019647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019648
{
public static readonly long[] Value={ 7L,3L,0L,5L,7L,0L,5L,9L,1L,3L,3L,0L,5L,6L,9L,4L,6L,6L,1L,3L,5L,4L,0L,5L,7L,6L,9L,0L,2L,6L,9L,2L,0L,5L,7L,8L,8L,4L,9L,4L,7L,6L,8L,8L,8L,1L,6L,1L,6L,4L,1L,7L,1L,4L,7L,5L,4L,4L,3L,5L,0L,0L,2L,8L,6L,7L,9L,8L,9L,0L,4L,3L,0L,9L,0L,7L,3L,9L,2L,2L,1L,1L,1L,0L,9L,8L,9L,1L,4L,1L,9L,4L,1L,7L,6L,4L,7L,3L,1L };
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
public class A019648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019648Inst : IEnumerable<long>
{
public static readonly long[] Value=A019648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019648.Bytes);
public long this[int i]=>Value[i];

public static A019648Inst Instance=new A019648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019649
{
public static readonly long[] Value={ 5L,8L,4L,4L,5L,6L,4L,7L,3L,0L,6L,4L,4L,5L,5L,5L,7L,2L,9L,0L,8L,3L,2L,4L,6L,1L,5L,2L,2L,1L,5L,3L,6L,4L,6L,3L,0L,7L,9L,5L,8L,1L,5L,1L,0L,5L,2L,9L,3L,1L,3L,3L,7L,1L,8L,0L,3L,5L,4L,8L,0L,0L,2L,2L,9L,4L,3L,9L,1L,2L,3L,4L,4L,7L,2L,5L,9L,1L,3L,7L,6L,8L,8L,8L,7L,9L,1L,3L,1L,3L,5L,5L,3L,4L,1L,1L,7L,8L,4L };
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
public class A019649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019649Inst : IEnumerable<long>
{
public static readonly long[] Value=A019649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019649.Bytes);
public long this[int i]=>Value[i];

public static A019649Inst Instance=new A019649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019650
{
public static readonly long[] Value={ 4L,8L,7L,0L,4L,7L,0L,6L,0L,8L,8L,7L,0L,4L,6L,3L,1L,0L,7L,5L,6L,9L,3L,7L,1L,7L,9L,3L,5L,1L,2L,8L,0L,3L,8L,5L,8L,9L,9L,6L,5L,1L,2L,5L,8L,7L,7L,4L,4L,2L,7L,8L,0L,9L,8L,3L,6L,2L,9L,0L,0L,0L,1L,9L,1L,1L,9L,9L,2L,6L,9L,5L,3L,9L,3L,8L,2L,6L,1L,4L,7L,4L,0L,7L,3L,2L,6L,0L,9L,4L,6L,2L,7L,8L,4L,3L,1L,5L,4L };
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
public class A019650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019650Inst : IEnumerable<long>
{
public static readonly long[] Value=A019650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019650.Bytes);
public long this[int i]=>Value[i];

public static A019650Inst Instance=new A019650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019651
{
public static readonly long[] Value={ 4L,1L,7L,4L,6L,8L,9L,0L,9L,3L,3L,1L,7L,5L,3L,9L,8L,0L,6L,4L,8L,8L,0L,3L,2L,9L,6L,5L,8L,6L,8L,1L,1L,7L,5L,9L,3L,4L,2L,5L,5L,8L,2L,2L,1L,8L,0L,6L,6L,5L,2L,4L,0L,8L,4L,3L,1L,1L,0L,5L,7L,1L,5L,9L,2L,4L,5L,6L,5L,1L,6L,7L,4L,8L,0L,4L,2L,2L,4L,1L,2L,0L,6L,3L,4L,2L,2L,3L,6L,6L,8L,2L,3L,8L,6L,5L,5L,6L,0L };
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
public class A019651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019651Inst : IEnumerable<long>
{
public static readonly long[] Value=A019651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019651.Bytes);
public long this[int i]=>Value[i];

public static A019651Inst Instance=new A019651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019652
{
public static readonly long[] Value={ 3L,6L,5L,2L,8L,5L,2L,9L,5L,6L,6L,5L,2L,8L,4L,7L,3L,3L,0L,6L,7L,7L,0L,2L,8L,8L,4L,5L,1L,3L,4L,6L,0L,2L,8L,9L,4L,2L,4L,7L,3L,8L,4L,4L,4L,0L,8L,0L,8L,2L,0L,8L,5L,7L,3L,7L,7L,2L,1L,7L,5L,0L,1L,4L,3L,3L,9L,9L,4L,5L,2L,1L,5L,4L,5L,3L,6L,9L,6L,1L,0L,5L,5L,5L,4L,9L,4L,5L,7L,0L,9L,7L,0L,8L,8L,2L,3L,6L,5L };
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
public class A019652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019652Inst : IEnumerable<long>
{
public static readonly long[] Value=A019652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019652.Bytes);
public long this[int i]=>Value[i];

public static A019652Inst Instance=new A019652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019653
{
public static readonly long[] Value={ 3L,2L,4L,6L,9L,8L,0L,4L,0L,5L,9L,1L,3L,6L,4L,2L,0L,7L,1L,7L,1L,2L,9L,1L,4L,5L,2L,9L,0L,0L,8L,5L,3L,5L,9L,0L,5L,9L,9L,7L,6L,7L,5L,0L,5L,8L,4L,9L,6L,1L,8L,5L,3L,9L,8L,9L,0L,8L,6L,0L,0L,0L,1L,2L,7L,4L,6L,6L,1L,7L,9L,6L,9L,2L,9L,2L,1L,7L,4L,3L,1L,6L,0L,4L,8L,8L,4L,0L,6L,3L,0L,8L,5L,2L,2L,8L,7L,6L,9L };
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
public class A019653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019653Inst : IEnumerable<long>
{
public static readonly long[] Value=A019653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019653.Bytes);
public long this[int i]=>Value[i];

public static A019653Inst Instance=new A019653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019654
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,40L,655L,16573L };
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
public class A019654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019654Inst : IEnumerable<long>
{
public static readonly long[] Value=A019654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019654.Bytes);
public long this[int i]=>Value[i];

public static A019654Inst Instance=new A019654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019655
{
public static readonly long[] Value={ 2L,6L,5L,6L,6L,2L,0L,3L,3L,2L,1L,1L,1L,1L,6L,1L,6L,9L,5L,0L,3L,7L,8L,3L,9L,1L,6L,0L,0L,9L,7L,8L,9L,3L,0L,1L,3L,9L,9L,8L,0L,9L,7L,7L,7L,5L,1L,3L,3L,2L,4L,2L,5L,9L,9L,1L,0L,7L,0L,3L,6L,3L,7L,4L,0L,6L,5L,4L,1L,4L,7L,0L,2L,1L,4L,8L,1L,4L,2L,6L,2L,2L,2L,2L,1L,7L,7L,8L,6L,9L,7L,9L,7L,0L,0L,5L,3L,5L,6L };
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
public class A019655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019655Inst : IEnumerable<long>
{
public static readonly long[] Value=A019655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019655.Bytes);
public long this[int i]=>Value[i];

public static A019655Inst Instance=new A019655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019656
{
public static readonly long[] Value={ 2L,4L,3L,5L,2L,3L,5L,3L,0L,4L,4L,3L,5L,2L,3L,1L,5L,5L,3L,7L,8L,4L,6L,8L,5L,8L,9L,6L,7L,5L,6L,4L,0L,1L,9L,2L,9L,4L,9L,8L,2L,5L,6L,2L,9L,3L,8L,7L,2L,1L,3L,9L,0L,4L,9L,1L,8L,1L,4L,5L,0L,0L,0L,9L,5L,5L,9L,9L,6L,3L,4L,7L,6L,9L,6L,9L,1L,3L,0L,7L,3L,7L,0L,3L,6L,6L,3L,0L,4L,7L,3L,1L,3L,9L,2L,1L,5L,7L,7L };
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
public class A019656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019656Inst : IEnumerable<long>
{
public static readonly long[] Value=A019656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019656.Bytes);
public long this[int i]=>Value[i];

public static A019656Inst Instance=new A019656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019657
{
public static readonly long[] Value={ 2L,2L,4L,7L,9L,0L,9L,5L,1L,1L,7L,8L,6L,3L,6L,7L,5L,8L,8L,1L,0L,8L,9L,4L,0L,8L,2L,7L,7L,7L,5L,1L,4L,0L,2L,4L,2L,6L,1L,3L,7L,7L,5L,0L,4L,0L,4L,9L,7L,3L,5L,9L,1L,2L,2L,3L,2L,1L,3L,3L,8L,4L,7L,0L,3L,6L,3L,0L,4L,3L,2L,0L,9L,5L,0L,9L,9L,6L,6L,8L,3L,4L,1L,8L,7L,6L,5L,8L,8L,9L,8L,2L,8L,2L,3L,5L,3L,0L,1L };
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
public class A019657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019657Inst : IEnumerable<long>
{
public static readonly long[] Value=A019657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019657.Bytes);
public long this[int i]=>Value[i];

public static A019657Inst Instance=new A019657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019658
{
public static readonly long[] Value={ 2L,0L,8L,7L,3L,4L,4L,5L,4L,6L,6L,5L,8L,7L,6L,9L,9L,0L,3L,2L,4L,4L,0L,1L,6L,4L,8L,2L,9L,3L,4L,0L,5L,8L,7L,9L,6L,7L,1L,2L,7L,9L,1L,1L,0L,9L,0L,3L,3L,2L,6L,2L,0L,4L,2L,1L,5L,5L,5L,2L,8L,5L,7L,9L,6L,2L,2L,8L,2L,5L,8L,3L,7L,4L,0L,2L,1L,1L,2L,0L,6L,0L,3L,1L,7L,1L,1L,1L,8L,3L,4L,1L,1L,9L,3L,2L,7L,8L,0L };
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
public class A019658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019658Inst : IEnumerable<long>
{
public static readonly long[] Value=A019658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019658.Bytes);
public long this[int i]=>Value[i];

public static A019658Inst Instance=new A019658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019659
{
public static readonly long[] Value={ 1L,9L,4L,8L,1L,8L,8L,2L,4L,3L,5L,4L,8L,1L,8L,5L,2L,4L,3L,0L,2L,7L,7L,4L,8L,7L,1L,7L,4L,0L,5L,1L,2L,1L,5L,4L,3L,5L,9L,8L,6L,0L,5L,0L,3L,5L,0L,9L,7L,7L,1L,1L,2L,3L,9L,3L,4L,5L,1L,6L,0L,0L,0L,7L,6L,4L,7L,9L,7L,0L,7L,8L,1L,5L,7L,5L,3L,0L,4L,5L,8L,9L,6L,2L,9L,3L,0L,4L,3L,7L,8L,5L,1L,1L,3L,7L,2L,6L,1L };
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
public class A019659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019659Inst : IEnumerable<long>
{
public static readonly long[] Value=A019659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019659.Bytes);
public long this[int i]=>Value[i];

public static A019659Inst Instance=new A019659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019660
{
public static readonly long[] Value={ 1L,8L,2L,6L,4L,2L,6L,4L,7L,8L,3L,2L,6L,4L,2L,3L,6L,6L,5L,3L,3L,8L,5L,1L,4L,4L,2L,2L,5L,6L,7L,3L,0L,1L,4L,4L,7L,1L,2L,3L,6L,9L,2L,2L,2L,0L,4L,0L,4L,1L,0L,4L,2L,8L,6L,8L,8L,6L,0L,8L,7L,5L,0L,7L,1L,6L,9L,9L,7L,2L,6L,0L,7L,7L,2L,6L,8L,4L,8L,0L,5L,2L,7L,7L,7L,4L,7L,2L,8L,5L,4L,8L,5L,4L,4L,1L,1L,8L,2L };
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
public class A019660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019660Inst : IEnumerable<long>
{
public static readonly long[] Value=A019660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019660.Bytes);
public long this[int i]=>Value[i];

public static A019660Inst Instance=new A019660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019661
{
public static readonly long[] Value={ 1L,7L,1L,8L,9L,8L,9L,6L,2L,6L,6L,6L,0L,1L,6L,3L,4L,4L,9L,7L,3L,0L,3L,6L,6L,5L,1L,5L,3L,5L,7L,4L,6L,0L,1L,8L,5L,5L,2L,8L,1L,8L,0L,9L,1L,3L,3L,2L,1L,5L,0L,9L,9L,1L,7L,0L,6L,9L,2L,5L,8L,8L,3L,0L,2L,7L,7L,6L,2L,1L,2L,7L,7L,8L,6L,0L,5L,6L,2L,8L,7L,3L,2L,0L,2L,3L,2L,7L,3L,9L,2L,8L,0L,4L,1L,5L,2L,3L,0L };
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
public class A019661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019661Inst : IEnumerable<long>
{
public static readonly long[] Value=A019661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019661.Bytes);
public long this[int i]=>Value[i];

public static A019661Inst Instance=new A019661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019678
{
public static readonly long[] Value={ 2L,8L,5L,5L,9L,9L,3L,3L,2L,1L,4L,4L,5L,2L,6L,6L,5L,8L,0L,4L,2L,0L,5L,8L,4L,8L,9L,3L,8L,9L,0L,4L,5L,7L,1L,6L,7L,4L,5L,1L,9L,7L,2L,1L,8L,1L,2L,5L,0L,0L,9L,6L,2L,0L,0L,8L,8L,6L,3L,1L,3L,2L,6L,5L,7L,3L,4L,3L,7L,8L,5L,5L,1L,1L,6L,9L,2L,8L,0L,9L,0L,7L,8L,4L,3L,6L,6L,8L,0L,2L,3L,0L,3L,8L,2L,8L,8L,2L,4L };
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
public class A019678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019678Inst : IEnumerable<long>
{
public static readonly long[] Value=A019678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019678.Bytes);
public long this[int i]=>Value[i];

public static A019678Inst Instance=new A019678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019679
{
public static readonly long[] Value={ 2L,6L,1L,7L,9L,9L,3L,8L,7L,7L,9L,9L,1L,4L,9L,4L,3L,6L,5L,3L,8L,5L,5L,3L,6L,1L,5L,2L,7L,3L,2L,9L,1L,9L,0L,7L,0L,1L,6L,4L,3L,0L,7L,8L,3L,2L,8L,1L,2L,5L,8L,8L,1L,8L,4L,1L,4L,5L,7L,8L,7L,1L,6L,0L,2L,5L,6L,5L,1L,3L,6L,7L,1L,9L,0L,5L,1L,7L,4L,1L,6L,5L,5L,2L,3L,3L,6L,2L,3L,5L,4L,4L,5L,1L,7L,6L,4L,2L,2L };
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
public class A019679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019679Inst : IEnumerable<long>
{
public static readonly long[] Value=A019679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019679.Bytes);
public long this[int i]=>Value[i];

public static A019679Inst Instance=new A019679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019680
{
public static readonly long[] Value={ 2L,4L,1L,6L,6L,0L,9L,7L,3L,3L,5L,3L,0L,6L,1L,0L,1L,8L,3L,4L,3L,2L,8L,0L,2L,6L,0L,2L,5L,2L,2L,6L,9L,4L,5L,2L,6L,3L,0L,5L,5L,1L,4L,9L,2L,2L,5L,9L,6L,2L,3L,5L,2L,4L,6L,9L,0L,3L,8L,0L,3L,5L,3L,2L,5L,4L,4L,4L,7L,4L,1L,5L,8L,6L,8L,1L,6L,9L,9L,2L,2L,9L,7L,1L,3L,8L,7L,2L,9L,4L,2L,5L,7L,0L,8L,5L,9L,2L,8L };
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
public class A019680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019680Inst : IEnumerable<long>
{
public static readonly long[] Value=A019680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019680.Bytes);
public long this[int i]=>Value[i];

public static A019680Inst Instance=new A019680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019681
{
public static readonly long[] Value={ 2L,2L,4L,3L,9L,9L,4L,7L,5L,2L,5L,6L,4L,1L,3L,8L,0L,2L,7L,4L,7L,3L,3L,1L,6L,7L,0L,2L,3L,4L,2L,5L,0L,2L,0L,6L,0L,1L,4L,0L,8L,3L,5L,2L,8L,5L,2L,6L,7L,9L,3L,2L,7L,2L,9L,2L,6L,7L,8L,1L,7L,5L,6L,5L,9L,3L,4L,1L,5L,4L,5L,7L,5L,9L,1L,8L,7L,2L,0L,7L,1L,3L,3L,0L,5L,7L,3L,9L,1L,6L,0L,9L,5L,8L,6L,5L,5L,0L,4L };
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
public class A019681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019681Inst : IEnumerable<long>
{
public static readonly long[] Value=A019681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019681.Bytes);
public long this[int i]=>Value[i];

public static A019681Inst Instance=new A019681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019682
{
public static readonly BigInteger[] Value={ 1L,23L,363L,4891L,60515L,710619L,8059507L,89191307L,969344739L,10390594555L,110181318611L,1158295737963L,12091317123523L,125488476039131L,1296062772061875L,13331230899395659L,136647741897916067L,1396496332294665147L,14235133611505668499UL,BigInteger.Parse("144782868986965745195") };
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
public class A019682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019682Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019682.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019682.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019682Inst Instance=new A019682Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019683
{
public static readonly long[] Value={ 1L,9L,6L,3L,4L,9L,5L,4L,0L,8L,4L,9L,3L,6L,2L,0L,7L,7L,4L,0L,3L,9L,1L,5L,2L,1L,1L,4L,5L,4L,9L,6L,8L,9L,3L,0L,2L,6L,2L,3L,2L,3L,0L,8L,7L,4L,6L,0L,9L,4L,4L,1L,1L,3L,8L,1L,0L,9L,3L,4L,0L,3L,7L,0L,1L,9L,2L,3L,8L,5L,2L,5L,3L,9L,2L,8L,8L,8L,0L,6L,2L,4L,1L,4L,2L,5L,2L,1L,7L,6L,5L,8L,3L,8L,8L,2L,3L,1L,6L };
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
public class A019683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019683Inst : IEnumerable<long>
{
public static readonly long[] Value=A019683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019683.Bytes);
public long this[int i]=>Value[i];

public static A019683Inst Instance=new A019683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019684
{
public static readonly long[] Value={ 1L,8L,4L,7L,9L,9L,5L,6L,7L,8L,5L,8L,2L,2L,3L,1L,3L,1L,6L,7L,4L,2L,7L,3L,1L,4L,0L,1L,9L,2L,9L,1L,1L,9L,3L,4L,3L,6L,4L,5L,3L,9L,3L,7L,6L,4L,3L,3L,8L,2L,9L,7L,5L,4L,1L,7L,4L,9L,9L,6L,7L,4L,0L,7L,2L,3L,9L,8L,9L,2L,0L,0L,3L,6L,9L,7L,7L,6L,9L,9L,9L,9L,1L,9L,2L,9L,6L,1L,6L,6L,1L,9L,6L,5L,9L,5L,1L,2L,1L };
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
public class A019684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019684Inst : IEnumerable<long>
{
public static readonly long[] Value=A019684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019684.Bytes);
public long this[int i]=>Value[i];

public static A019684Inst Instance=new A019684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019685
{
public static readonly long[] Value={ 0L,1L,7L,4L,5L,3L,2L,9L,2L,5L,1L,9L,9L,4L,3L,2L,9L,5L,7L,6L,9L,2L,3L,6L,9L,0L,7L,6L,8L,4L,8L,8L,6L,1L,2L,7L,1L,3L,4L,4L,2L,8L,7L,1L,8L,8L,8L,5L,4L,1L,7L,2L,5L,4L,5L,6L,0L,9L,7L,1L,9L,1L,4L,4L,0L,1L,7L,1L,0L,0L,9L,1L,1L,4L,6L,0L,3L,4L,4L,9L,4L,4L,3L,6L,8L,2L,2L,4L,1L,5L,6L,9L,6L,3L,4L,5L,0L,9L,4L,8L };
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
public class A019685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019685Inst : IEnumerable<long>
{
public static readonly long[] Value=A019685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019685.Bytes);
public long this[int i]=>Value[i];

public static A019685Inst Instance=new A019685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019686
{
public static readonly long[] Value={ 1L,6L,5L,3L,4L,6L,9L,8L,1L,7L,6L,7L,8L,8L,3L,8L,5L,4L,6L,5L,5L,9L,2L,8L,5L,9L,9L,1L,1L,9L,9L,7L,3L,8L,3L,6L,0L,1L,0L,3L,7L,7L,3L,3L,6L,8L,0L,9L,2L,1L,6L,0L,9L,5L,8L,4L,0L,7L,8L,6L,5L,5L,7L,4L,8L,9L,8L,8L,5L,0L,7L,4L,0L,1L,5L,0L,6L,3L,6L,3L,1L,5L,0L,6L,7L,3L,8L,6L,7L,5L,0L,1L,8L,0L,0L,6L,1L,6L,1L };
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
public class A019686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019686Inst : IEnumerable<long>
{
public static readonly long[] Value=A019686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019686.Bytes);
public long this[int i]=>Value[i];

public static A019686Inst Instance=new A019686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019687
{
public static readonly BigInteger[] Value={ 1L,24L,397L,5628L,73513L,914112L,11008549L,129690276L,1504024705L,17241418920L,195930981181L,2211723344844L,24837316537177L,277785786712848L,3096821665511893L,34435641499407732L,382127489397444529L,4233421296687394296L,BigInteger.Parse("46837804552120354285") };
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
public class A019687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019687Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019687.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019687.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019687Inst Instance=new A019687Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019688
{
public static readonly long[] Value={ 1L,4L,9L,5L,9L,9L,6L,5L,0L,1L,7L,0L,9L,4L,2L,5L,3L,5L,1L,6L,4L,8L,8L,7L,7L,8L,0L,1L,5L,6L,1L,6L,6L,8L,0L,4L,0L,0L,9L,3L,8L,9L,0L,1L,9L,0L,1L,7L,8L,6L,2L,1L,8L,1L,9L,5L,1L,1L,8L,7L,8L,3L,7L,7L,2L,8L,9L,4L,3L,6L,3L,8L,3L,9L,4L,5L,8L,1L,3L,8L,0L,8L,8L,7L,0L,4L,9L,2L,7L,7L,3L,9L,7L,2L,4L,3L,6L,6L,9L };
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
public class A019688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019688Inst : IEnumerable<long>
{
public static readonly long[] Value=A019688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019688.Bytes);
public long this[int i]=>Value[i];

public static A019688Inst Instance=new A019688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019689
{
public static readonly long[] Value={ 1L,4L,2L,7L,9L,9L,6L,6L,6L,0L,7L,2L,2L,6L,3L,3L,2L,9L,0L,2L,1L,0L,2L,9L,2L,4L,4L,6L,9L,4L,5L,2L,2L,8L,5L,8L,3L,7L,2L,5L,9L,8L,6L,0L,9L,0L,6L,2L,5L,0L,4L,8L,1L,0L,0L,4L,4L,3L,1L,5L,6L,6L,3L,2L,8L,6L,7L,1L,8L,9L,2L,7L,5L,5L,8L,4L,6L,4L,0L,4L,5L,3L,9L,2L,1L,8L,3L,4L,0L,1L,1L,5L,1L,9L,1L,4L,4L,1L,2L };
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
public class A019689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019689Inst : IEnumerable<long>
{
public static readonly long[] Value=A019689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019689.Bytes);
public long this[int i]=>Value[i];

public static A019689Inst Instance=new A019689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019690
{
public static readonly long[] Value={ 1L,3L,6L,5L,9L,0L,9L,8L,4L,9L,3L,8L,6L,8L,6L,6L,6L,2L,5L,4L,1L,8L,5L,4L,0L,6L,0L,1L,4L,2L,5L,8L,7L,0L,8L,1L,9L,2L,1L,6L,1L,6L,0L,6L,0L,8L,4L,2L,3L,9L,5L,9L,0L,5L,2L,5L,9L,7L,8L,0L,1L,9L,9L,6L,6L,5L,5L,5L,7L,2L,3L,5L,0L,5L,5L,9L,2L,2L,1L,3L,0L,3L,7L,5L,1L,3L,1L,9L,4L,8L,9L,2L,7L,9L,1L,8L,1L,3L,3L };
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
public class A019690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019690Inst : IEnumerable<long>
{
public static readonly long[] Value=A019690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019690.Bytes);
public long this[int i]=>Value[i];

public static A019690Inst Instance=new A019690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019691
{
public static readonly long[] Value={ 1L,3L,0L,8L,9L,9L,6L,9L,3L,8L,9L,9L,5L,7L,4L,7L,1L,8L,2L,6L,9L,2L,7L,6L,8L,0L,7L,6L,3L,6L,6L,4L,5L,9L,5L,3L,5L,0L,8L,2L,1L,5L,3L,9L,1L,6L,4L,0L,6L,2L,9L,4L,0L,9L,2L,0L,7L,2L,8L,9L,3L,5L,8L,0L,1L,2L,8L,2L,5L,6L,8L,3L,5L,9L,5L,2L,5L,8L,7L,0L,8L,2L,7L,6L,1L,6L,8L,1L,1L,7L,7L,2L,2L,5L,8L,8L,2L,1L,1L };
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
public class A019691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019691Inst : IEnumerable<long>
{
public static readonly long[] Value=A019691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019691.Bytes);
public long this[int i]=>Value[i];

public static A019691Inst Instance=new A019691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019692
{
public static readonly long[] Value={ 6L,2L,8L,3L,1L,8L,5L,3L,0L,7L,1L,7L,9L,5L,8L,6L,4L,7L,6L,9L,2L,5L,2L,8L,6L,7L,6L,6L,5L,5L,9L,0L,0L,5L,7L,6L,8L,3L,9L,4L,3L,3L,8L,7L,9L,8L,7L,5L,0L,2L,1L,1L,6L,4L,1L,9L,4L,9L,8L,8L,9L,1L,8L,4L,6L,1L,5L,6L,3L,2L,8L,1L,2L,5L,7L,2L,4L,1L,7L,9L,9L,7L,2L,5L,6L,0L,6L,9L,6L,5L,0L,6L,8L,4L,2L,3L,4L,1L,3L };
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
public class A019692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019692Inst : IEnumerable<long>
{
public static readonly long[] Value=A019692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019692.Bytes);
public long this[int i]=>Value[i];

public static A019692Inst Instance=new A019692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019693
{
public static readonly long[] Value={ 2L,0L,9L,4L,3L,9L,5L,1L,0L,2L,3L,9L,3L,1L,9L,5L,4L,9L,2L,3L,0L,8L,4L,2L,8L,9L,2L,2L,1L,8L,6L,3L,3L,5L,2L,5L,6L,1L,3L,1L,4L,4L,6L,2L,6L,6L,2L,5L,0L,0L,7L,0L,5L,4L,7L,3L,1L,6L,6L,2L,9L,7L,2L,8L,2L,0L,5L,2L,1L,0L,9L,3L,7L,5L,2L,4L,1L,3L,9L,3L,3L,2L,4L,1L,8L,6L,8L,9L,8L,8L,3L,5L,6L,1L,4L,1L,1L,3L,7L };
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
public class A019693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019693Inst : IEnumerable<long>
{
public static readonly long[] Value=A019693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019693.Bytes);
public long this[int i]=>Value[i];

public static A019693Inst Instance=new A019693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019742
{
public static readonly long[] Value={ 1L,25L,431L,6365L,86511L,1117605L,13957591L,170189245L,2038704671L,24092243285L,281680643751L,3265150951725L,37583315950831L,430083097386565L,4897580558961911L,55540052099419805L,627607236896972991L };
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
public class A019742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019742Inst : IEnumerable<long>
{
public static readonly long[] Value=A019742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019742.Bytes);
public long this[int i]=>Value[i];

public static A019742Inst Instance=new A019742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019743
{
public static readonly long[] Value={ 4L,5L,3L,0L,4L,6L,9L,7L,1L,4L,0L,9L,8L,4L,0L,8L,7L,2L,5L,6L,0L,0L,4L,7L,9L,1L,1L,8L,9L,2L,1L,1L,0L,4L,1L,6L,2L,9L,2L,8L,7L,4L,5L,1L,5L,6L,1L,6L,6L,5L,9L,9L,2L,9L,1L,6L,1L,1L,6L,1L,2L,7L,1L,2L,8L,7L,3L,4L,6L,1L,0L,5L,0L,5L,8L,9L,2L,4L,5L,9L,9L,0L,9L,5L,2L,3L,0L,3L,6L,3L,0L,8L,7L,5L,2L,7L,7L,3L,7L };
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
public class A019743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019743Inst : IEnumerable<long>
{
public static readonly long[] Value=A019743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019743.Bytes);
public long this[int i]=>Value[i];

public static A019743Inst Instance=new A019743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019744
{
public static readonly long[] Value={ 3L,8L,8L,3L,2L,5L,9L,7L,5L,4L,9L,4L,1L,4L,9L,3L,1L,9L,3L,3L,7L,1L,8L,3L,9L,2L,4L,4L,7L,8L,9L,5L,1L,7L,8L,5L,3L,9L,3L,8L,9L,2L,4L,4L,1L,9L,5L,7L,1L,3L,7L,0L,8L,2L,1L,3L,8L,1L,3L,8L,2L,3L,2L,5L,3L,2L,0L,1L,0L,9L,4L,7L,1L,9L,3L,3L,6L,3L,9L,4L,2L,0L,8L,1L,6L,2L,6L,0L,2L,5L,5L,0L,3L,5L,9L,5L,2L,0L,3L };
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
public class A019744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019744Inst : IEnumerable<long>
{
public static readonly long[] Value=A019744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019744.Bytes);
public long this[int i]=>Value[i];

public static A019744Inst Instance=new A019744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019745
{
public static readonly long[] Value={ 3L,3L,9L,7L,8L,5L,2L,2L,8L,5L,5L,7L,3L,8L,0L,6L,5L,4L,4L,2L,0L,0L,3L,5L,9L,3L,3L,9L,1L,9L,0L,8L,2L,8L,1L,2L,2L,1L,9L,6L,5L,5L,8L,8L,6L,7L,1L,2L,4L,9L,4L,9L,4L,6L,8L,7L,0L,8L,7L,0L,9L,5L,3L,4L,6L,5L,5L,0L,9L,5L,7L,8L,7L,9L,4L,1L,9L,3L,4L,4L,9L,3L,2L,1L,4L,2L,2L,7L,7L,2L,3L,1L,5L,6L,4L,5L,8L,0L,3L };
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
public class A019745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019745Inst : IEnumerable<long>
{
public static readonly long[] Value=A019745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019745.Bytes);
public long this[int i]=>Value[i];

public static A019745Inst Instance=new A019745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019746
{
public static readonly long[] Value={ 3L,0L,2L,0L,3L,1L,3L,1L,4L,2L,7L,3L,2L,2L,7L,2L,4L,8L,3L,7L,3L,3L,6L,5L,2L,7L,4L,5L,9L,4L,7L,4L,0L,2L,7L,7L,5L,2L,8L,5L,8L,3L,0L,1L,0L,4L,1L,1L,1L,0L,6L,6L,1L,9L,4L,4L,0L,7L,7L,4L,1L,8L,0L,8L,5L,8L,2L,3L,0L,7L,3L,6L,7L,0L,5L,9L,4L,9L,7L,3L,2L,7L,3L,0L,1L,5L,3L,5L,7L,5L,3L,9L,1L,6L,8L,5L,1L,5L,8L };
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
public class A019746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019746Inst : IEnumerable<long>
{
public static readonly long[] Value=A019746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019746.Bytes);
public long this[int i]=>Value[i];

public static A019746Inst Instance=new A019746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019747
{
public static readonly long[] Value={ 1L,26L,468L,7240L,103376L,1406496L,18541888L,239158400L,3036523776L,38104777216L,473923294208L,5853743400960L,71911576293376L,879605537447936L,10721932937084928L,130329861195857920L,1580624998153650176L };
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
public class A019747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019747Inst : IEnumerable<long>
{
public static readonly long[] Value=A019747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019747.Bytes);
public long this[int i]=>Value[i];

public static A019747Inst Instance=new A019747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019748
{
public static readonly long[] Value={ 2L,4L,7L,1L,1L,6L,5L,2L,9L,8L,5L,9L,9L,1L,3L,2L,0L,3L,2L,1L,4L,5L,7L,1L,5L,8L,8L,3L,0L,4L,7L,8L,7L,4L,9L,9L,7L,9L,6L,1L,1L,3L,3L,7L,2L,1L,5L,4L,5L,4L,1L,7L,7L,9L,5L,4L,2L,4L,5L,1L,6L,0L,2L,5L,2L,0L,3L,7L,0L,6L,0L,2L,7L,5L,9L,4L,1L,3L,4L,1L,7L,6L,8L,8L,3L,0L,7L,4L,7L,0L,7L,7L,5L,0L,1L,5L,1L,2L,9L };
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
public class A019748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019748Inst : IEnumerable<long>
{
public static readonly long[] Value=A019748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019748.Bytes);
public long this[int i]=>Value[i];

public static A019748Inst Instance=new A019748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019749
{
public static readonly long[] Value={ 2L,2L,6L,5L,2L,3L,4L,8L,5L,7L,0L,4L,9L,2L,0L,4L,3L,6L,2L,8L,0L,0L,2L,3L,9L,5L,5L,9L,4L,6L,0L,5L,5L,2L,0L,8L,1L,4L,6L,4L,3L,7L,2L,5L,7L,8L,0L,8L,3L,2L,9L,9L,6L,4L,5L,8L,0L,5L,8L,0L,6L,3L,5L,6L,4L,3L,6L,7L,3L,0L,5L,2L,5L,2L,9L,4L,6L,2L,2L,9L,9L,5L,4L,7L,6L,1L,5L,1L,8L,1L,5L,4L,3L,7L,6L,3L,8L,6L,8L };
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
public class A019749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019749Inst : IEnumerable<long>
{
public static readonly long[] Value=A019749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019749.Bytes);
public long this[int i]=>Value[i];

public static A019749Inst Instance=new A019749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019750
{
public static readonly long[] Value={ 2L,0L,9L,0L,9L,8L,6L,0L,2L,1L,8L,9L,1L,5L,7L,3L,2L,5L,7L,9L,6L,9L,4L,5L,1L,9L,0L,1L,0L,4L,0L,5L,0L,9L,6L,1L,3L,6L,5L,9L,4L,2L,0L,8L,4L,1L,3L,0L,7L,6L,6L,1L,2L,1L,1L,5L,1L,3L,0L,5L,2L,0L,2L,1L,3L,2L,6L,2L,1L,2L,7L,9L,2L,5L,7L,9L,6L,5L,1L,9L,9L,5L,8L,2L,4L,1L,4L,0L,1L,3L,7L,3L,2L,7L,0L,5L,1L,0L,9L };
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
public class A019750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019750Inst : IEnumerable<long>
{
public static readonly long[] Value=A019750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019750.Bytes);
public long this[int i]=>Value[i];

public static A019750Inst Instance=new A019750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019751
{
public static readonly long[] Value={ 1L,9L,4L,1L,6L,2L,9L,8L,7L,7L,4L,7L,0L,7L,4L,6L,5L,9L,6L,6L,8L,5L,9L,1L,9L,6L,2L,2L,3L,9L,4L,7L,5L,8L,9L,2L,6L,9L,6L,9L,4L,6L,2L,2L,0L,9L,7L,8L,5L,6L,8L,5L,4L,1L,0L,6L,9L,0L,6L,9L,1L,1L,6L,2L,6L,6L,0L,0L,5L,4L,7L,3L,5L,9L,6L,6L,8L,1L,9L,7L,1L,0L,4L,0L,8L,1L,3L,0L,1L,2L,7L,5L,1L,7L,9L,7L,6L,0L,1L };
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
public class A019751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019751Inst : IEnumerable<long>
{
public static readonly long[] Value=A019751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019751.Bytes);
public long this[int i]=>Value[i];

public static A019751Inst Instance=new A019751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019752
{
public static readonly BigInteger[] Value={ 1L,27L,505L,8115L,120241L,1695387L,23126185L,308127555L,4034342881L,52117311147L,666165944665L,8442335850195L,106239836635921L,1329127977509307L,16546285315207945L,205119670292296035L,2533642759410327361L,BigInteger.Parse("31197987005034321867"),BigInteger.Parse("383112856942345668025") };
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
public class A019752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019752Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019752.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019752.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019752Inst Instance=new A019752Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019753
{
public static readonly long[] Value={ 1L,6L,9L,8L,9L,2L,6L,1L,4L,2L,7L,8L,6L,9L,0L,3L,2L,7L,2L,1L,0L,0L,1L,7L,9L,6L,6L,9L,5L,9L,5L,4L,1L,4L,0L,6L,1L,0L,9L,8L,2L,7L,9L,4L,3L,3L,5L,6L,2L,4L,7L,4L,7L,3L,4L,3L,5L,4L,3L,5L,4L,7L,6L,7L,3L,2L,7L,5L,4L,7L,8L,9L,3L,9L,7L,0L,9L,6L,7L,2L,4L,6L,6L,0L,7L,1L,1L,3L,8L,6L,1L,5L,7L,8L,2L,2L,9L,0L,1L };
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
public class A019753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019753Inst : IEnumerable<long>
{
public static readonly long[] Value=A019753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019753.Bytes);
public long this[int i]=>Value[i];

public static A019753Inst Instance=new A019753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019754
{
public static readonly long[] Value={ 1L,5L,9L,8L,9L,8L,9L,3L,1L,0L,8L,5L,8L,2L,6L,1L,9L,0L,3L,1L,5L,3L,1L,1L,0L,2L,7L,7L,2L,6L,6L,2L,7L,2L,0L,5L,7L,5L,0L,4L,2L,6L,2L,9L,9L,6L,2L,9L,4L,0L,9L,3L,8L,6L,7L,6L,2L,7L,6L,2L,8L,0L,1L,6L,3L,0L,8L,2L,8L,0L,3L,7L,0L,7L,9L,6L,2L,0L,4L,4L,6L,7L,3L,9L,4L,9L,3L,0L,6L,9L,3L,2L,5L,0L,0L,9L,7L,8L,9L };
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
public class A019754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019754Inst : IEnumerable<long>
{
public static readonly long[] Value=A019754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019754.Bytes);
public long this[int i]=>Value[i];

public static A019754Inst Instance=new A019754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019755
{
public static readonly long[] Value={ 1L,5L,1L,0L,1L,5L,6L,5L,7L,1L,3L,6L,6L,1L,3L,6L,2L,4L,1L,8L,6L,6L,8L,2L,6L,3L,7L,2L,9L,7L,3L,7L,0L,1L,3L,8L,7L,6L,4L,2L,9L,1L,5L,0L,5L,2L,0L,5L,5L,5L,3L,3L,0L,9L,7L,2L,0L,3L,8L,7L,0L,9L,0L,4L,2L,9L,1L,1L,5L,3L,6L,8L,3L,5L,2L,9L,7L,4L,8L,6L,6L,3L,6L,5L,0L,7L,6L,7L,8L,7L,6L,9L,5L,8L,4L,2L,5L,7L,9L };
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
public class A019755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019755Inst : IEnumerable<long>
{
public static readonly long[] Value=A019755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019755.Bytes);
public long this[int i]=>Value[i];

public static A019755Inst Instance=new A019755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019756
{
public static readonly long[] Value={ 1L,4L,3L,0L,6L,7L,4L,6L,4L,6L,5L,5L,7L,3L,9L,2L,2L,2L,9L,1L,3L,6L,9L,9L,3L,4L,0L,5L,9L,7L,5L,0L,8L,5L,5L,2L,5L,1L,3L,5L,3L,9L,3L,2L,0L,7L,2L,1L,0L,5L,0L,5L,0L,3L,9L,4L,5L,6L,2L,9L,8L,7L,5L,1L,4L,3L,3L,7L,2L,4L,5L,4L,2L,2L,9L,1L,3L,4L,0L,8L,3L,9L,2L,4L,8L,0L,9L,5L,8L,8L,3L,4L,3L,4L,2L,9L,8L,1L,1L };
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
public class A019756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019756Inst : IEnumerable<long>
{
public static readonly long[] Value=A019756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019756.Bytes);
public long this[int i]=>Value[i];

public static A019756Inst Instance=new A019756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019757
{
public static readonly long[] Value={ 1L,18L,217L,2190L,19981L,170898L,1398097L,11075670L,85654261L,650280378L,4865931577L,35994162750L,263799130141L,1918854559458L,13871649322657L,99770067275430L,714554190919621L,5099624595840138L,36287658424563337L };
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
public class A019757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019757Inst : IEnumerable<long>
{
public static readonly long[] Value=A019757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019757.Bytes);
public long this[int i]=>Value[i];

public static A019757Inst Instance=new A019757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019774
{
public static readonly long[] Value={ 1L,6L,4L,8L,7L,2L,1L,2L,7L,0L,7L,0L,0L,1L,2L,8L,1L,4L,6L,8L,4L,8L,6L,5L,0L,7L,8L,7L,8L,1L,4L,1L,6L,3L,5L,7L,1L,6L,5L,3L,7L,7L,6L,1L,0L,0L,7L,1L,0L,1L,4L,8L,0L,1L,1L,5L,7L,5L,0L,7L,9L,3L,1L,1L,6L,4L,0L,6L,6L,1L,0L,2L,1L,1L,9L,4L,2L,1L,5L,6L,0L,8L,6L,3L,2L,7L,7L,6L,5L,2L,0L,0L,5L,6L,3L,6L,6L,6L,4L };
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
public class A019774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019774Inst : IEnumerable<long>
{
public static readonly long[] Value=A019774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019774.Bytes);
public long this[int i]=>Value[i];

public static A019774Inst Instance=new A019774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019775
{
public static readonly long[] Value={ 8L,2L,4L,3L,6L,0L,6L,3L,5L,3L,5L,0L,0L,6L,4L,0L,7L,3L,4L,2L,4L,3L,2L,5L,3L,9L,3L,9L,0L,7L,0L,8L,1L,7L,8L,5L,8L,2L,6L,8L,8L,8L,0L,5L,0L,3L,5L,5L,0L,7L,4L,0L,0L,5L,7L,8L,7L,5L,3L,9L,6L,5L,5L,8L,2L,0L,3L,3L,0L,5L,1L,0L,5L,9L,7L,1L,0L,7L,8L,0L,4L,3L,1L,6L,3L,8L,8L,2L,6L,0L,0L,2L,8L,1L,8L,3L,3L,2L,1L };
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
public class A019775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019775Inst : IEnumerable<long>
{
public static readonly long[] Value=A019775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019775.Bytes);
public long this[int i]=>Value[i];

public static A019775Inst Instance=new A019775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019776
{
public static readonly long[] Value={ 5L,4L,9L,5L,7L,3L,7L,5L,6L,9L,0L,0L,0L,4L,2L,7L,1L,5L,6L,1L,6L,2L,1L,6L,9L,2L,9L,2L,7L,1L,3L,8L,7L,8L,5L,7L,2L,1L,7L,9L,2L,5L,3L,6L,6L,9L,0L,3L,3L,8L,2L,6L,7L,0L,5L,2L,5L,0L,2L,6L,4L,3L,7L,2L,1L,3L,5L,5L,3L,6L,7L,3L,7L,3L,1L,4L,0L,5L,2L,0L,2L,8L,7L,7L,5L,9L,2L,1L,7L,3L,3L,5L,2L,1L,2L,2L,2L,1L,4L };
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
public class A019776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019776Inst : IEnumerable<long>
{
public static readonly long[] Value=A019776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019776.Bytes);
public long this[int i]=>Value[i];

public static A019776Inst Instance=new A019776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019777
{
public static readonly long[] Value={ 4L,1L,2L,1L,8L,0L,3L,1L,7L,6L,7L,5L,0L,3L,2L,0L,3L,6L,7L,1L,2L,1L,6L,2L,6L,9L,6L,9L,5L,3L,5L,4L,0L,8L,9L,2L,9L,1L,3L,4L,4L,4L,0L,2L,5L,1L,7L,7L,5L,3L,7L,0L,0L,2L,8L,9L,3L,7L,6L,9L,8L,2L,7L,9L,1L,0L,1L,6L,5L,2L,5L,5L,2L,9L,8L,5L,5L,3L,9L,0L,2L,1L,5L,8L,1L,9L,4L,1L,3L,0L,0L,1L,4L,0L,9L,1L,6L,6L,0L };
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
public class A019777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019777Inst : IEnumerable<long>
{
public static readonly long[] Value=A019777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019777.Bytes);
public long this[int i]=>Value[i];

public static A019777Inst Instance=new A019777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019778
{
public static readonly long[] Value={ 3L,2L,9L,7L,4L,4L,2L,5L,4L,1L,4L,0L,0L,2L,5L,6L,2L,9L,3L,6L,9L,7L,3L,0L,1L,5L,7L,5L,6L,2L,8L,3L,2L,7L,1L,4L,3L,3L,0L,7L,5L,5L,2L,2L,0L,1L,4L,2L,0L,2L,9L,6L,0L,2L,3L,1L,5L,0L,1L,5L,8L,6L,2L,3L,2L,8L,1L,3L,2L,2L,0L,4L,2L,3L,8L,8L,4L,3L,1L,2L,1L,7L,2L,6L,5L,5L,5L,3L,0L,4L,0L,1L,1L,2L,7L,3L,3L,2L,8L };
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
public class A019778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019778Inst : IEnumerable<long>
{
public static readonly long[] Value=A019778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019778.Bytes);
public long this[int i]=>Value[i];

public static A019778Inst Instance=new A019778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019779
{
public static readonly long[] Value={ 2L,7L,4L,7L,8L,6L,8L,7L,8L,4L,5L,0L,0L,2L,1L,3L,5L,7L,8L,0L,8L,1L,0L,8L,4L,6L,4L,6L,3L,5L,6L,9L,3L,9L,2L,8L,6L,0L,8L,9L,6L,2L,6L,8L,3L,4L,5L,1L,6L,9L,1L,3L,3L,5L,2L,6L,2L,5L,1L,3L,2L,1L,8L,6L,0L,6L,7L,7L,6L,8L,3L,6L,8L,6L,5L,7L,0L,2L,6L,0L,1L,4L,3L,8L,7L,9L,6L,0L,8L,6L,6L,7L,6L,0L,6L,1L,1L,0L,7L };
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
public class A019779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019779Inst : IEnumerable<long>
{
public static readonly long[] Value=A019779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019779.Bytes);
public long this[int i]=>Value[i];

public static A019779Inst Instance=new A019779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019780
{
public static readonly long[] Value={ 2L,3L,5L,5L,3L,1L,6L,1L,0L,1L,0L,0L,0L,1L,8L,3L,0L,6L,6L,9L,2L,6L,6L,4L,3L,9L,8L,2L,5L,9L,1L,6L,6L,2L,2L,4L,5L,2L,1L,9L,6L,8L,0L,1L,4L,3L,8L,7L,1L,6L,4L,0L,0L,1L,6L,5L,3L,5L,8L,2L,7L,5L,8L,8L,0L,5L,8L,0L,8L,7L,1L,7L,3L,1L,3L,4L,5L,9L,3L,7L,2L,6L,6L,1L,8L,2L,5L,2L,1L,7L,1L,5L,0L,9L,0L,9L,5L,2L,0L };
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
public class A019780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019780Inst : IEnumerable<long>
{
public static readonly long[] Value=A019780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019780.Bytes);
public long this[int i]=>Value[i];

public static A019780Inst Instance=new A019780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019781
{
public static readonly long[] Value={ 2L,0L,6L,0L,9L,0L,1L,5L,8L,8L,3L,7L,5L,1L,6L,0L,1L,8L,3L,5L,6L,0L,8L,1L,3L,4L,8L,4L,7L,6L,7L,7L,0L,4L,4L,6L,4L,5L,6L,7L,2L,2L,0L,1L,2L,5L,8L,8L,7L,6L,8L,5L,0L,1L,4L,4L,6L,8L,8L,4L,9L,1L,3L,9L,5L,5L,0L,8L,2L,6L,2L,7L,6L,4L,9L,2L,7L,6L,9L,5L,1L,0L,7L,9L,0L,9L,7L,0L,6L,5L,0L,0L,7L,0L,4L,5L,8L,3L,0L };
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
public class A019781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019781Inst : IEnumerable<long>
{
public static readonly long[] Value=A019781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019781.Bytes);
public long this[int i]=>Value[i];

public static A019781Inst Instance=new A019781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019782
{
public static readonly long[] Value={ 1L,8L,3L,1L,9L,1L,2L,5L,2L,3L,0L,0L,0L,1L,4L,2L,3L,8L,5L,3L,8L,7L,3L,8L,9L,7L,6L,4L,2L,3L,7L,9L,5L,9L,5L,2L,4L,0L,5L,9L,7L,5L,1L,2L,2L,3L,0L,1L,1L,2L,7L,5L,5L,6L,8L,4L,1L,6L,7L,5L,4L,7L,9L,0L,7L,1L,1L,8L,4L,5L,5L,7L,9L,1L,0L,4L,6L,8L,4L,0L,0L,9L,5L,9L,1L,9L,7L,3L,9L,1L,1L,1L,7L,3L,7L,4L,0L,7L,1L };
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
public class A019782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019782Inst : IEnumerable<long>
{
public static readonly long[] Value=A019782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019782.Bytes);
public long this[int i]=>Value[i];

public static A019782Inst Instance=new A019782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019783
{
public static readonly long[] Value={ 1L,19L,243L,2615L,25571L,235599L,2086603L,17981815L,151979091L,1266533279L,10446235163L,85502523015L,695860175011L,5639142048559L,45552803794923L,367090952376215L,2952891339001331L,23720875971413439L };
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
public class A019783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019783Inst : IEnumerable<long>
{
public static readonly long[] Value=A019783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019783.Bytes);
public long this[int i]=>Value[i];

public static A019783Inst Instance=new A019783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019784
{
public static readonly long[] Value={ 1L,4L,9L,8L,8L,3L,7L,5L,1L,8L,8L,1L,8L,2L,9L,8L,3L,1L,5L,3L,1L,6L,9L,5L,5L,2L,6L,1L,6L,4L,9L,2L,3L,9L,6L,1L,0L,5L,9L,4L,3L,4L,1L,9L,0L,9L,7L,3L,6L,4L,9L,8L,1L,9L,2L,3L,4L,0L,9L,8L,1L,1L,9L,2L,4L,0L,0L,6L,0L,0L,9L,2L,8L,3L,5L,8L,3L,7L,7L,8L,2L,6L,0L,2L,9L,7L,9L,6L,8L,3L,6L,4L,1L,4L,8L,7L,8L,7L,6L };
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
public class A019784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019784Inst : IEnumerable<long>
{
public static readonly long[] Value=A019784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019784.Bytes);
public long this[int i]=>Value[i];

public static A019784Inst Instance=new A019784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019785
{
public static readonly long[] Value={ 1L,3L,7L,3L,9L,3L,4L,3L,9L,2L,2L,5L,0L,1L,0L,6L,7L,8L,9L,0L,4L,0L,5L,4L,2L,3L,2L,3L,1L,7L,8L,4L,6L,9L,6L,4L,3L,0L,4L,4L,8L,1L,3L,4L,1L,7L,2L,5L,8L,4L,5L,6L,6L,7L,6L,3L,1L,2L,5L,6L,6L,0L,9L,3L,0L,3L,3L,8L,8L,4L,1L,8L,4L,3L,2L,8L,5L,1L,3L,0L,0L,7L,1L,9L,3L,9L,8L,0L,4L,3L,3L,3L,8L,0L,3L,0L,5L,5L,3L };
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
public class A019785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019785Inst : IEnumerable<long>
{
public static readonly long[] Value=A019785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019785.Bytes);
public long this[int i]=>Value[i];

public static A019785Inst Instance=new A019785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019786
{
public static readonly long[] Value={ 1L,2L,6L,8L,2L,4L,7L,1L,3L,1L,3L,0L,7L,7L,9L,0L,8L,8L,2L,1L,9L,1L,2L,6L,9L,8L,3L,6L,7L,8L,0L,1L,2L,5L,8L,2L,4L,3L,4L,9L,0L,5L,8L,5L,3L,9L,0L,0L,7L,8L,0L,6L,1L,6L,2L,7L,5L,0L,0L,6L,1L,0L,0L,8L,9L,5L,4L,3L,5L,4L,6L,3L,1L,6L,8L,7L,8L,5L,8L,1L,6L,0L,4L,8L,6L,7L,5L,1L,1L,6L,9L,2L,7L,4L,1L,2L,8L,1L,8L };
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
public class A019786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019786Inst : IEnumerable<long>
{
public static readonly long[] Value=A019786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019786.Bytes);
public long this[int i]=>Value[i];

public static A019786Inst Instance=new A019786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019787
{
public static readonly long[] Value={ 1L,1L,7L,7L,6L,5L,8L,0L,5L,0L,5L,0L,0L,0L,9L,1L,5L,3L,3L,4L,6L,3L,3L,2L,1L,9L,9L,1L,2L,9L,5L,8L,3L,1L,1L,2L,2L,6L,0L,9L,8L,4L,0L,0L,7L,1L,9L,3L,5L,8L,2L,0L,0L,0L,8L,2L,6L,7L,9L,1L,3L,7L,9L,4L,0L,2L,9L,0L,4L,3L,5L,8L,6L,5L,6L,7L,2L,9L,6L,8L,6L,3L,3L,0L,9L,1L,2L,6L,0L,8L,5L,7L,5L,4L,5L,4L,7L,6L,0L };
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
public class A019787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019787Inst : IEnumerable<long>
{
public static readonly long[] Value=A019787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019787.Bytes);
public long this[int i]=>Value[i];

public static A019787Inst Instance=new A019787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019788
{
public static readonly long[] Value={ 1L,0L,9L,9L,1L,4L,7L,5L,1L,3L,8L,0L,0L,0L,8L,5L,4L,3L,1L,2L,3L,2L,4L,3L,3L,8L,5L,8L,5L,4L,2L,7L,7L,5L,7L,1L,4L,4L,3L,5L,8L,5L,0L,7L,3L,3L,8L,0L,6L,7L,6L,5L,3L,4L,1L,0L,5L,0L,0L,5L,2L,8L,7L,4L,4L,2L,7L,1L,0L,7L,3L,4L,7L,4L,6L,2L,8L,1L,0L,4L,0L,5L,7L,5L,5L,1L,8L,4L,3L,4L,6L,7L,0L,4L,2L,4L,4L,4L,2L };
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
public class A019788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019788Inst : IEnumerable<long>
{
public static readonly long[] Value=A019788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019788.Bytes);
public long this[int i]=>Value[i];

public static A019788Inst Instance=new A019788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019789
{
public static readonly long[] Value={ 1L,0L,3L,0L,4L,5L,0L,7L,9L,4L,1L,8L,7L,5L,8L,0L,0L,9L,1L,7L,8L,0L,4L,0L,6L,7L,4L,2L,3L,8L,3L,8L,5L,2L,2L,3L,2L,2L,8L,3L,6L,1L,0L,0L,6L,2L,9L,4L,3L,8L,4L,2L,5L,0L,7L,2L,3L,4L,4L,2L,4L,5L,6L,9L,7L,7L,5L,4L,1L,3L,1L,3L,8L,2L,4L,6L,3L,8L,4L,7L,5L,5L,3L,9L,5L,4L,8L,5L,3L,2L,5L,0L,3L,5L,2L,2L,9L,1L,5L };
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
public class A019789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019789Inst : IEnumerable<long>
{
public static readonly long[] Value=A019789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019789.Bytes);
public long this[int i]=>Value[i];

public static A019789Inst Instance=new A019789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019806
{
public static readonly long[] Value={ 1L,3L,7L,1L,5L,5L,5L,2L,8L,3L,2L,9L,2L,4L,2L,6L,0L,0L,1L,9L,7L,8L,5L,5L,0L,6L,2L,4L,8L,0L,4L,9L,4L,1L,6L,9L,1L,9L,8L,8L,3L,7L,4L,2L,9L,3L,6L,3L,9L,7L,5L,7L,8L,9L,5L,8L,8L,7L,1L,1L,5L,5L,5L,7L,5L,1L,5L,3L,0L,0L,0L,2L,9L,0L,6L,6L,2L,6L,9L,0L,2L,9L,1L,1L,9L,1L,9L,4L,1L,1L,2L,8L,2L,0L,8L,6L,9L,2L,6L };
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
public class A019806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019806Inst : IEnumerable<long>
{
public static readonly long[] Value=A019806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019806.Bytes);
public long this[int i]=>Value[i];

public static A019806Inst Instance=new A019806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019807
{
public static readonly long[] Value={ 1L,2L,2L,7L,1L,8L,1L,0L,4L,2L,9L,4L,5L,8L,5L,4L,8L,4L,3L,8L,7L,5L,5L,4L,5L,2L,9L,5L,8L,7L,8L,1L,0L,5L,7L,2L,4L,4L,1L,0L,6L,5L,0L,6L,8L,3L,7L,8L,2L,9L,4L,1L,2L,7L,5L,2L,6L,7L,4L,1L,9L,1L,8L,3L,0L,4L,0L,0L,0L,5L,2L,8L,9L,1L,6L,4L,5L,5L,6L,4L,9L,9L,7L,3L,8L,2L,2L,6L,3L,1L,1L,4L,7L,1L,3L,0L,4L,0L,8L };
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
public class A019807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019807Inst : IEnumerable<long>
{
public static readonly long[] Value=A019807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019807.Bytes);
public long this[int i]=>Value[i];

public static A019807Inst Instance=new A019807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019808
{
public static readonly long[] Value={ 1L,1L,1L,0L,3L,0L,6L,6L,5L,7L,9L,0L,3L,3L,9L,2L,4L,7L,7L,7L,9L,2L,1L,6L,0L,0L,2L,9L,6L,0L,4L,0L,0L,0L,4L,1L,7L,3L,2L,3L,9L,2L,2L,0L,4L,7L,2L,3L,2L,1L,8L,4L,9L,6L,3L,3L,3L,7L,1L,8L,8L,7L,8L,4L,6L,5L,5L,2L,4L,2L,8L,8L,0L,6L,7L,2L,6L,9L,3L,9L,7L,5L,9L,5L,3L,6L,3L,3L,3L,2L,9L,4L,2L,6L,4L,1L,7L,9L,7L };
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
public class A019808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019808Inst : IEnumerable<long>
{
public static readonly long[] Value=A019808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019808.Bytes);
public long this[int i]=>Value[i];

public static A019808Inst Instance=new A019808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019809
{
public static readonly long[] Value={ 1L,0L,1L,3L,7L,5L,8L,2L,5L,2L,8L,6L,8L,3L,1L,4L,8L,7L,1L,0L,2L,7L,6L,2L,4L,3L,7L,4L,8L,5L,5L,8L,2L,6L,4L,6L,7L,9L,9L,1L,4L,0L,7L,0L,8L,6L,6L,0L,3L,2L,9L,9L,3L,1L,4L,3L,5L,1L,3L,4L,6L,2L,8L,1L,6L,4L,1L,7L,4L,3L,4L,9L,9L,7L,4L,4L,6L,3L,3L,6L,3L,0L,2L,1L,8L,5L,3L,4L,7L,7L,9L,0L,4L,1L,5L,1L,2L,0L,6L };
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
public class A019809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019809Inst : IEnumerable<long>
{
public static readonly long[] Value=A019809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019809.Bytes);
public long this[int i]=>Value[i];

public static A019809Inst Instance=new A019809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019810
{
public static readonly long[] Value={ 0L,1L,7L,4L,5L,2L,4L,0L,6L,4L,3L,7L,2L,8L,3L,5L,1L,2L,8L,1L,9L,4L,1L,8L,9L,7L,8L,5L,1L,6L,3L,1L,6L,1L,9L,2L,4L,7L,2L,2L,5L,2L,7L,2L,0L,3L,0L,7L,1L,3L,9L,6L,4L,2L,6L,8L,3L,6L,1L,2L,4L,2L,7L,6L,4L,0L,5L,9L,7L,3L,8L,4L,2L,0L,3L,9L,2L,8L,0L,7L,0L,0L,4L,2L,0L,0L,1L,9L,2L,6L,7L,9L,1L,0L,2L,1L,3L,4L,6L,9L,1L,4L,4L,8L,8L };
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
public class A019810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019810Inst : IEnumerable<long>
{
public static readonly long[] Value=A019810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019810.Bytes);
public long this[int i]=>Value[i];

public static A019810Inst Instance=new A019810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019811
{
public static readonly long[] Value={ 0L,3L,4L,8L,9L,9L,4L,9L,6L,7L,0L,2L,5L,0L,0L,9L,7L,1L,6L,4L,5L,9L,9L,5L,1L,8L,1L,6L,2L,5L,3L,3L,2L,9L,3L,7L,3L,5L,4L,8L,2L,4L,5L,7L,6L,0L,4L,3L,2L,9L,6L,8L,7L,1L,4L,2L,5L,0L,0L,5L,7L,6L,6L,9L,4L,2L,0L,8L,4L,0L,5L,1L,2L,1L,3L,8L,2L,1L,3L,2L,5L,4L,5L,1L,1L,2L,3L,1L,5L,1L,4L,5L,9L,0L,2L,8L,5L,6L,5L,2L };
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
public class A019811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019811Inst : IEnumerable<long>
{
public static readonly long[] Value=A019811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019811.Bytes);
public long this[int i]=>Value[i];

public static A019811Inst Instance=new A019811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019812
{
public static readonly long[] Value={ 0L,5L,2L,3L,3L,5L,9L,5L,6L,2L,4L,2L,9L,4L,3L,8L,3L,2L,7L,2L,2L,1L,1L,8L,6L,2L,9L,6L,0L,9L,0L,7L,8L,4L,1L,8L,7L,3L,1L,0L,1L,8L,2L,5L,3L,9L,4L,0L,1L,6L,4L,9L,2L,0L,4L,8L,3L,5L,0L,9L,3L,8L,1L,5L,9L,9L,8L,5L,7L,1L,0L,4L,6L,4L,1L,7L,5L,4L,5L,4L,6L,8L,6L,4L,4L,6L,4L,5L,9L,8L,8L,1L,1L,8L,8L,6L,9L,3L,9L,8L };
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
public class A019812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019812Inst : IEnumerable<long>
{
public static readonly long[] Value=A019812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019812.Bytes);
public long this[int i]=>Value[i];

public static A019812Inst Instance=new A019812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019813
{
public static readonly long[] Value={ 0L,6L,9L,7L,5L,6L,4L,7L,3L,7L,4L,4L,1L,2L,5L,3L,0L,0L,7L,7L,5L,9L,5L,8L,8L,3L,5L,1L,9L,4L,1L,4L,3L,3L,2L,8L,6L,0L,0L,9L,0L,3L,2L,0L,1L,6L,5L,2L,7L,9L,6L,5L,2L,5L,0L,4L,3L,6L,1L,7L,2L,9L,6L,1L,3L,7L,0L,7L,1L,1L,2L,7L,0L,6L,6L,7L,8L,9L,1L,2L,2L,9L,1L,2L,5L,3L,7L,8L,5L,6L,8L,2L,8L,0L,7L,4L,2L,9L,2L,3L };
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
public class A019813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019813Inst : IEnumerable<long>
{
public static readonly long[] Value=A019813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019813.Bytes);
public long this[int i]=>Value[i];

public static A019813Inst Instance=new A019813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019814
{
public static readonly long[] Value={ 0L,8L,7L,1L,5L,5L,7L,4L,2L,7L,4L,7L,6L,5L,8L,1L,7L,3L,5L,5L,8L,0L,6L,4L,2L,7L,0L,8L,3L,7L,4L,7L,3L,5L,5L,1L,3L,7L,7L,7L,0L,1L,1L,5L,6L,1L,4L,9L,7L,0L,2L,6L,7L,2L,6L,1L,3L,7L,4L,3L,3L,6L,7L,5L,6L,8L,4L,2L,9L,8L,2L,7L,4L,8L,1L,6L,7L,6L,3L,3L,0L,5L,3L,7L,4L,0L,1L,2L,4L,8L,2L,7L,6L,9L,9L,6L,3L,7L,2L,1L };
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
public class A019814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019814Inst : IEnumerable<long>
{
public static readonly long[] Value=A019814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019814.Bytes);
public long this[int i]=>Value[i];

public static A019814Inst Instance=new A019814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019815
{
public static readonly long[] Value={ 1L,0L,4L,5L,2L,8L,4L,6L,3L,2L,6L,7L,6L,5L,3L,4L,7L,1L,3L,9L,9L,8L,3L,4L,1L,5L,4L,8L,0L,2L,4L,9L,8L,1L,1L,9L,0L,8L,0L,6L,5L,5L,8L,6L,9L,4L,7L,4L,5L,9L,3L,1L,1L,3L,9L,9L,3L,2L,7L,5L,4L,7L,6L,7L,1L,2L,4L,8L,4L,6L,5L,0L,6L,9L,3L,1L,8L,0L,0L,4L,6L,8L,2L,8L,1L,8L,0L,3L,9L,8L,7L,9L,8L,6L,0L,4L,4L,2L,6L };
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
public class A019815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019815Inst : IEnumerable<long>
{
public static readonly long[] Value=A019815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019815.Bytes);
public long this[int i]=>Value[i];

public static A019815Inst Instance=new A019815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019816
{
public static readonly long[] Value={ 1L,2L,1L,8L,6L,9L,3L,4L,3L,4L,0L,5L,1L,4L,7L,4L,8L,1L,1L,1L,2L,8L,9L,3L,9L,1L,9L,2L,3L,1L,5L,2L,5L,1L,7L,6L,0L,1L,3L,2L,3L,5L,6L,4L,6L,4L,7L,1L,4L,6L,8L,7L,2L,0L,9L,2L,7L,0L,4L,8L,8L,7L,3L,9L,7L,7L,9L,5L,1L,3L,7L,8L,7L,5L,2L,8L,0L,7L,3L,4L,6L,2L,7L,5L,4L,7L,5L,3L,3L,1L,9L,5L,6L,5L,9L,5L,9L,4L,0L };
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
public class A019816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019816Inst : IEnumerable<long>
{
public static readonly long[] Value=A019816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019816.Bytes);
public long this[int i]=>Value[i];

public static A019816Inst Instance=new A019816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019817
{
public static readonly long[] Value={ 1L,3L,9L,1L,7L,3L,1L,0L,0L,9L,6L,0L,0L,6L,5L,4L,4L,4L,1L,1L,2L,4L,9L,6L,6L,6L,3L,3L,0L,1L,1L,0L,5L,2L,7L,5L,4L,5L,5L,9L,2L,4L,9L,3L,1L,3L,7L,3L,5L,6L,8L,8L,7L,6L,6L,0L,1L,6L,8L,6L,6L,0L,3L,0L,1L,8L,1L,3L,3L,1L,1L,5L,7L,0L,0L,8L,6L,6L,6L,0L,9L,8L,5L,1L,4L,0L,4L,9L,3L,8L,8L,6L,4L,0L,2L,8L,4L,2L,6L };
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
public class A019817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019817Inst : IEnumerable<long>
{
public static readonly long[] Value=A019817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019817.Bytes);
public long this[int i]=>Value[i];

public static A019817Inst Instance=new A019817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019818
{
public static readonly long[] Value={ 1L,5L,6L,4L,3L,4L,4L,6L,5L,0L,4L,0L,2L,3L,0L,8L,6L,9L,0L,1L,0L,1L,0L,5L,3L,1L,9L,4L,6L,7L,1L,6L,6L,8L,9L,2L,3L,1L,3L,8L,9L,9L,8L,9L,2L,0L,8L,5L,6L,6L,0L,7L,9L,0L,0L,8L,4L,6L,4L,1L,3L,4L,6L,0L,5L,7L,7L,5L,8L,7L,9L,3L,3L,0L,5L,6L,2L,3L,5L,7L,9L,3L,3L,6L,6L,9L,5L,8L,7L,2L,6L,7L,6L,8L,4L,8L,6L,8L,8L };
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
public class A019818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019818Inst : IEnumerable<long>
{
public static readonly long[] Value=A019818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019818.Bytes);
public long this[int i]=>Value[i];

public static A019818Inst Instance=new A019818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019819
{
public static readonly long[] Value={ 1L,7L,3L,6L,4L,8L,1L,7L,7L,6L,6L,6L,9L,3L,0L,3L,4L,8L,8L,5L,1L,7L,1L,6L,6L,2L,6L,7L,6L,9L,3L,1L,4L,7L,9L,6L,0L,0L,0L,3L,7L,5L,6L,7L,7L,1L,8L,4L,0L,6L,9L,3L,8L,7L,2L,3L,6L,2L,4L,1L,3L,7L,8L,1L,3L,2L,0L,6L,5L,8L,2L,2L,1L,3L,9L,0L,1L,4L,7L,3L,5L,4L,2L,1L,5L,1L,6L,6L,1L,3L,1L,5L,7L,3L,9L,9L,5L,7L,4L };
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
public class A019819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019819Inst : IEnumerable<long>
{
public static readonly long[] Value=A019819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019819.Bytes);
public long this[int i]=>Value[i];

public static A019819Inst Instance=new A019819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019820
{
public static readonly long[] Value={ 1L,9L,0L,8L,0L,8L,9L,9L,5L,3L,7L,6L,5L,4L,4L,8L,1L,2L,4L,0L,5L,1L,4L,0L,4L,8L,7L,9L,5L,8L,3L,8L,7L,6L,1L,9L,6L,2L,7L,9L,2L,0L,7L,5L,1L,2L,7L,4L,0L,5L,5L,2L,6L,6L,9L,6L,8L,8L,1L,8L,1L,3L,2L,6L,1L,7L,9L,7L,8L,3L,9L,9L,2L,0L,2L,1L,7L,7L,5L,4L,6L,5L,0L,8L,8L,6L,5L,9L,2L,4L,7L,3L,9L,1L,6L,7L,1L,8L,8L };
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
public class A019820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019820Inst : IEnumerable<long>
{
public static readonly long[] Value=A019820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019820.Bytes);
public long this[int i]=>Value[i];

public static A019820Inst Instance=new A019820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019821
{
public static readonly long[] Value={ 2L,0L,7L,9L,1L,1L,6L,9L,0L,8L,1L,7L,7L,5L,9L,3L,3L,7L,1L,0L,1L,7L,4L,2L,2L,8L,4L,4L,0L,5L,1L,2L,5L,1L,6L,6L,2L,1L,6L,5L,8L,4L,7L,6L,0L,6L,2L,7L,7L,2L,3L,8L,3L,6L,4L,0L,7L,1L,8L,1L,9L,7L,3L,8L,8L,2L,3L,8L,2L,8L,2L,5L,6L,6L,4L,0L,7L,4L,3L,7L,6L,3L,0L,4L,6L,2L,8L,7L,5L,6L,7L,2L,2L,7L,2L,7L,5L,7L,3L };
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
public class A019821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019821Inst : IEnumerable<long>
{
public static readonly long[] Value=A019821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019821.Bytes);
public long this[int i]=>Value[i];

public static A019821Inst Instance=new A019821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019838
{
public static readonly long[] Value={ 4L,8L,4L,8L,0L,9L,6L,2L,0L,2L,4L,6L,3L,3L,7L,0L,2L,9L,0L,7L,5L,3L,7L,9L,6L,2L,2L,4L,1L,5L,7L,7L,6L,5L,6L,8L,2L,7L,6L,6L,5L,7L,4L,7L,6L,8L,3L,6L,8L,6L,6L,4L,6L,5L,7L,9L,7L,1L,0L,0L,4L,3L,8L,3L,1L,1L,0L,3L,4L,7L,4L,4L,7L,3L,2L,4L,0L,7L,9L,8L,3L,5L,1L,6L,9L,2L,6L,5L,8L,4L,7L,0L,3L,4L,6L,6L,7L,4L,9L };
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
public class A019838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019838Inst : IEnumerable<long>
{
public static readonly long[] Value=A019838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019838.Bytes);
public long this[int i]=>Value[i];

public static A019838Inst Instance=new A019838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019839
{
public static readonly BigInteger[] Value={ 1L,21L,301L,3681L,41461L,445641L,4658221L,47871201L,486836581L,4919066361L,49504632541L,496978967121L,4981629662101L,49888557269481L,499325240101261L,4995920923029441L,49975372950286021L,499851474762263001L,4999105033876312381L,BigInteger.Parse("49994611129771546161") };
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
public class A019839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019839Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019839.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019839.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019839Inst Instance=new A019839Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019840
{
public static readonly long[] Value={ 5L,1L,5L,0L,3L,8L,0L,7L,4L,9L,1L,0L,0L,5L,4L,2L,1L,0L,0L,8L,1L,6L,3L,1L,9L,3L,6L,3L,9L,8L,1L,3L,8L,2L,8L,3L,4L,1L,6L,0L,8L,2L,8L,3L,3L,7L,4L,6L,3L,1L,9L,4L,7L,3L,8L,6L,1L,2L,2L,0L,2L,7L,6L,2L,0L,0L,5L,0L,4L,4L,3L,6L,3L,7L,0L,9L,2L,9L,2L,3L,1L,8L,8L,0L,3L,7L,2L,8L,1L,0L,5L,8L,4L,6L,4L,3L,5L,9L,6L };
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
public class A019840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019840Inst : IEnumerable<long>
{
public static readonly long[] Value=A019840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019840.Bytes);
public long this[int i]=>Value[i];

public static A019840Inst Instance=new A019840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019841
{
public static readonly long[] Value={ 5L,2L,9L,9L,1L,9L,2L,6L,4L,2L,3L,3L,2L,0L,4L,9L,5L,4L,0L,4L,6L,7L,8L,1L,1L,5L,1L,8L,1L,6L,0L,8L,6L,6L,6L,8L,7L,7L,2L,0L,1L,7L,5L,4L,9L,9L,5L,8L,7L,9L,9L,9L,6L,4L,7L,6L,7L,7L,9L,2L,1L,0L,8L,6L,2L,0L,0L,4L,8L,8L,2L,6L,7L,4L,4L,1L,7L,3L,3L,2L,9L,5L,5L,5L,3L,5L,6L,8L,0L,6L,4L,8L,3L,5L,2L,7L,1L,3L,0L };
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
public class A019841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019841Inst : IEnumerable<long>
{
public static readonly long[] Value=A019841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019841.Bytes);
public long this[int i]=>Value[i];

public static A019841Inst Instance=new A019841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019842
{
public static readonly long[] Value={ 5L,4L,4L,6L,3L,9L,0L,3L,5L,0L,1L,5L,0L,2L,7L,0L,8L,2L,2L,2L,4L,0L,8L,3L,6L,9L,2L,0L,8L,1L,5L,6L,5L,3L,8L,1L,6L,0L,7L,9L,0L,4L,5L,8L,7L,7L,1L,8L,7L,6L,3L,9L,7L,5L,4L,5L,6L,1L,2L,5L,2L,4L,9L,0L,0L,9L,6L,2L,2L,1L,8L,9L,6L,0L,1L,6L,2L,5L,8L,8L,9L,8L,8L,0L,8L,5L,8L,5L,8L,9L,0L,1L,1L,3L,2L,8L,6L,5L,3L };
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
public class A019842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019842Inst : IEnumerable<long>
{
public static readonly long[] Value=A019842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019842.Bytes);
public long this[int i]=>Value[i];

public static A019842Inst Instance=new A019842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019843
{
public static readonly long[] Value={ 5L,5L,9L,1L,9L,2L,9L,0L,3L,4L,7L,0L,7L,4L,6L,8L,3L,0L,1L,6L,0L,4L,2L,8L,1L,3L,9L,9L,8L,5L,9L,8L,9L,2L,8L,7L,3L,0L,6L,6L,2L,1L,9L,4L,0L,3L,9L,5L,6L,6L,9L,4L,2L,1L,7L,9L,4L,8L,6L,9L,3L,5L,2L,2L,4L,5L,4L,0L,2L,8L,4L,7L,3L,9L,7L,6L,4L,2L,8L,3L,9L,1L,7L,7L,5L,0L,8L,8L,0L,5L,3L,1L,0L,7L,2L,6L,3L,9L,6L };
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
public class A019843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019843Inst : IEnumerable<long>
{
public static readonly long[] Value=A019843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019843.Bytes);
public long this[int i]=>Value[i];

public static A019843Inst Instance=new A019843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019844
{
public static readonly long[] Value={ 5L,7L,3L,5L,7L,6L,4L,3L,6L,3L,5L,1L,0L,4L,6L,0L,9L,6L,1L,0L,8L,0L,3L,1L,9L,1L,2L,8L,2L,6L,1L,5L,7L,8L,6L,4L,6L,2L,0L,4L,3L,3L,3L,7L,1L,4L,5L,0L,9L,8L,6L,3L,5L,1L,0L,8L,1L,0L,2L,7L,1L,1L,8L,1L,6L,9L,4L,5L,6L,8L,9L,9L,8L,5L,2L,5L,6L,1L,6L,1L,0L,0L,5L,9L,7L,2L,2L,0L,1L,2L,6L,4L,0L,2L,2L,0L,3L,3L,3L };
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
public class A019844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019844Inst : IEnumerable<long>
{
public static readonly long[] Value=A019844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019844.Bytes);
public long this[int i]=>Value[i];

public static A019844Inst Instance=new A019844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019845
{
public static readonly long[] Value={ 5L,8L,7L,7L,8L,5L,2L,5L,2L,2L,9L,2L,4L,7L,3L,1L,2L,9L,1L,6L,8L,7L,0L,5L,9L,5L,4L,6L,3L,9L,0L,7L,2L,7L,6L,8L,5L,9L,7L,6L,5L,2L,4L,3L,7L,6L,4L,3L,1L,4L,5L,9L,9L,1L,0L,7L,2L,2L,7L,2L,4L,8L,0L,7L,5L,7L,2L,7L,8L,4L,7L,4L,1L,6L,2L,3L,5L,1L,9L,5L,7L,5L,0L,8L,5L,0L,4L,0L,4L,9L,8L,6L,2L,7L,4L,1L,3L,3L,5L };
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
public class A019845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019845Inst : IEnumerable<long>
{
public static readonly long[] Value=A019845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019845.Bytes);
public long this[int i]=>Value[i];

public static A019845Inst Instance=new A019845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019846
{
public static readonly long[] Value={ 6L,0L,1L,8L,1L,5L,0L,2L,3L,1L,5L,2L,0L,4L,8L,2L,7L,9L,9L,1L,7L,9L,7L,7L,0L,0L,0L,4L,4L,1L,4L,8L,9L,8L,4L,1L,4L,2L,5L,6L,3L,7L,7L,0L,9L,8L,3L,0L,3L,9L,6L,1L,5L,6L,4L,8L,8L,4L,4L,7L,0L,2L,6L,5L,4L,5L,5L,4L,2L,7L,8L,9L,6L,1L,5L,1L,1L,9L,6L,3L,9L,7L,4L,2L,4L,6L,4L,6L,1L,8L,9L,6L,6L,3L,5L,5L,5L,8L,9L };
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
public class A019846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019846Inst : IEnumerable<long>
{
public static readonly long[] Value=A019846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019846.Bytes);
public long this[int i]=>Value[i];

public static A019846Inst Instance=new A019846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019847
{
public static readonly long[] Value={ 6L,1L,5L,6L,6L,1L,4L,7L,5L,3L,2L,5L,6L,5L,8L,2L,7L,9L,6L,6L,8L,8L,1L,1L,0L,9L,2L,8L,4L,3L,6L,5L,5L,6L,2L,8L,2L,5L,0L,9L,3L,0L,8L,7L,1L,5L,1L,5L,2L,1L,0L,3L,2L,5L,9L,8L,6L,2L,7L,3L,7L,5L,6L,5L,6L,7L,6L,3L,7L,2L,0L,3L,3L,6L,3L,2L,5L,1L,2L,3L,6L,0L,3L,1L,2L,8L,2L,8L,8L,0L,5L,3L,7L,1L,6L,4L,0L,7L,5L };
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
public class A019847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019847Inst : IEnumerable<long>
{
public static readonly long[] Value=A019847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019847.Bytes);
public long this[int i]=>Value[i];

public static A019847Inst Instance=new A019847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019848
{
public static readonly long[] Value={ 6L,2L,9L,3L,2L,0L,3L,9L,1L,0L,4L,9L,8L,3L,7L,4L,5L,2L,7L,0L,5L,9L,0L,2L,4L,5L,8L,2L,7L,9L,9L,7L,0L,4L,2L,6L,5L,6L,6L,8L,6L,2L,4L,1L,2L,1L,2L,9L,8L,6L,6L,6L,3L,9L,4L,6L,0L,3L,2L,8L,0L,2L,5L,7L,8L,0L,7L,5L,3L,0L,0L,9L,9L,8L,7L,2L,1L,3L,6L,3L,6L,7L,2L,4L,6L,4L,6L,9L,4L,6L,6L,0L,6L,8L,9L,9L,9L,8L,9L };
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
public class A019848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019848Inst : IEnumerable<long>
{
public static readonly long[] Value=A019848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019848.Bytes);
public long this[int i]=>Value[i];

public static A019848Inst Instance=new A019848Inst();

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