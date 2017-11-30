using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A011161
{
public static readonly long[] Value={ 2L,3L,7L,7L,7L,3L,0L,9L,9L,1L,5L,7L,4L,2L,4L,8L,7L,6L,4L,8L,7L,6L,2L,4L,4L,5L,3L,6L,6L,3L,5L,7L,6L,6L,8L,3L,1L,7L,3L,7L,1L,0L,8L,0L,0L,6L,2L,5L,4L,0L,2L,3L,7L,7L,0L,7L,3L,6L,2L,4L,7L,3L,5L,2L,6L,0L,0L,1L,3L,4L,6L,5L,1L,8L,9L,4L,1L,3L,5L,4L,7L,0L,6L,5L,1L,7L,3L,8L,1L,8L,3L,9L,9L,2L,3L,6L,5L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011161Inst : IEnumerable<long>
{
public static readonly long[] Value=A011161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011161.Bytes);
public long this[int i]=>Value[i];

public static A011161Inst Instance=new A011161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011160
{
public static readonly long[] Value={ 2L,3L,7L,1L,4L,4L,0L,6L,0L,9L,7L,7L,9L,3L,1L,1L,7L,4L,7L,3L,5L,2L,5L,6L,5L,8L,6L,7L,1L,6L,1L,3L,3L,1L,4L,4L,2L,6L,8L,3L,7L,4L,3L,7L,2L,5L,9L,3L,6L,2L,4L,8L,9L,5L,5L,0L,4L,9L,3L,0L,0L,9L,5L,7L,4L,1L,9L,7L,8L,3L,7L,7L,3L,5L,5L,1L,7L,3L,7L,3L,5L,1L,9L,5L,7L,5L,8L,4L,2L,4L,2L,1L,1L,5L,4L,8L,4L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011160Inst : IEnumerable<long>
{
public static readonly long[] Value=A011160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011160.Bytes);
public long this[int i]=>Value[i];

public static A011160Inst Instance=new A011160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011159
{
public static readonly long[] Value={ 2L,3L,6L,5L,0L,8L,2L,7L,6L,8L,6L,3L,6L,5L,6L,3L,5L,6L,4L,6L,7L,3L,1L,5L,4L,9L,5L,4L,1L,6L,5L,9L,7L,2L,9L,4L,6L,3L,7L,1L,4L,3L,1L,3L,3L,1L,5L,9L,4L,0L,2L,1L,8L,6L,2L,1L,4L,1L,1L,9L,5L,6L,8L,8L,1L,3L,5L,8L,0L,1L,1L,7L,2L,8L,6L,7L,4L,1L,7L,2L,9L,3L,2L,4L,1L,4L,6L,1L,2L,9L,9L,4L,7L,9L,5L,5L,8L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011159Inst : IEnumerable<long>
{
public static readonly long[] Value=A011159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011159.Bytes);
public long this[int i]=>Value[i];

public static A011159Inst Instance=new A011159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011158
{
public static readonly long[] Value={ 2L,3L,5L,8L,6L,5L,5L,8L,1L,8L,2L,4L,0L,7L,3L,5L,6L,2L,6L,6L,0L,4L,1L,4L,5L,1L,3L,4L,7L,6L,8L,4L,0L,2L,7L,8L,8L,8L,8L,4L,6L,1L,3L,0L,4L,9L,6L,2L,3L,0L,7L,9L,6L,5L,2L,6L,1L,7L,0L,0L,8L,9L,8L,2L,4L,9L,3L,3L,3L,5L,6L,5L,4L,6L,1L,1L,8L,4L,5L,2L,6L,1L,6L,0L,1L,6L,6L,4L,2L,5L,5L,7L,5L,1L,7L,3L,7L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011158Inst : IEnumerable<long>
{
public static readonly long[] Value=A011158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011158.Bytes);
public long this[int i]=>Value[i];

public static A011158Inst Instance=new A011158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011157
{
public static readonly long[] Value={ 2L,3L,5L,2L,1L,5L,8L,0L,4L,5L,0L,4L,9L,3L,4L,7L,1L,4L,5L,1L,6L,9L,9L,5L,5L,6L,2L,7L,8L,8L,3L,5L,7L,0L,5L,1L,3L,4L,2L,8L,0L,5L,3L,3L,4L,4L,4L,7L,3L,9L,6L,4L,9L,1L,5L,0L,2L,8L,2L,2L,3L,8L,6L,9L,9L,2L,3L,5L,4L,6L,8L,0L,6L,1L,4L,8L,4L,5L,9L,8L,0L,3L,2L,3L,2L,0L,4L,7L,6L,7L,3L,2L,8L,2L,7L,4L,2L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011157Inst : IEnumerable<long>
{
public static readonly long[] Value=A011157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011157.Bytes);
public long this[int i]=>Value[i];

public static A011157Inst Instance=new A011157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011156
{
public static readonly long[] Value={ 2L,3L,4L,5L,5L,8L,7L,6L,6L,8L,5L,0L,5L,0L,0L,3L,0L,1L,1L,7L,1L,2L,8L,1L,6L,6L,9L,6L,2L,4L,7L,4L,4L,7L,2L,1L,9L,1L,1L,5L,1L,5L,6L,1L,3L,4L,4L,4L,2L,4L,6L,9L,0L,6L,5L,5L,8L,6L,5L,1L,5L,6L,5L,2L,2L,0L,3L,7L,5L,7L,7L,1L,6L,5L,7L,4L,1L,0L,5L,4L,6L,9L,1L,7L,5L,7L,5L,3L,8L,7L,4L,5L,5L,5L,0L,0L,7L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011156Inst : IEnumerable<long>
{
public static readonly long[] Value=A011156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011156.Bytes);
public long this[int i]=>Value[i];

public static A011156Inst Instance=new A011156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011155
{
public static readonly long[] Value={ 2L,3L,3L,8L,9L,4L,2L,8L,3L,7L,4L,2L,8L,0L,2L,0L,3L,4L,4L,7L,9L,7L,0L,8L,5L,4L,7L,8L,1L,0L,9L,5L,0L,5L,6L,9L,3L,0L,0L,1L,4L,6L,5L,8L,2L,3L,3L,7L,8L,0L,1L,9L,2L,7L,1L,0L,2L,6L,4L,3L,6L,6L,0L,7L,6L,7L,4L,1L,2L,4L,5L,1L,3L,2L,9L,3L,3L,6L,1L,1L,9L,5L,8L,9L,1L,1L,9L,1L,7L,7L,6L,5L,9L,5L,6L,7L,3L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011155Inst : IEnumerable<long>
{
public static readonly long[] Value=A011155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011155.Bytes);
public long this[int i]=>Value[i];

public static A011155Inst Instance=new A011155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011154
{
public static readonly long[] Value={ 2L,3L,3L,2L,2L,2L,1L,6L,2L,6L,1L,6L,0L,2L,4L,1L,8L,5L,0L,2L,9L,4L,2L,7L,1L,3L,8L,8L,1L,6L,5L,8L,6L,5L,3L,5L,0L,7L,4L,5L,1L,8L,7L,9L,9L,1L,4L,4L,6L,7L,8L,6L,0L,3L,7L,4L,1L,1L,5L,9L,7L,6L,9L,1L,5L,0L,7L,6L,0L,0L,2L,5L,4L,8L,1L,1L,0L,0L,9L,9L,0L,2L,7L,4L,4L,9L,3L,8L,4L,8L,3L,0L,7L,9L,6L,0L,3L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011154Inst : IEnumerable<long>
{
public static readonly long[] Value=A011154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011154.Bytes);
public long this[int i]=>Value[i];

public static A011154Inst Instance=new A011154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011153
{
public static readonly long[] Value={ 2L,3L,2L,5L,4L,2L,2L,0L,3L,0L,4L,3L,8L,9L,9L,6L,3L,9L,1L,3L,1L,9L,9L,5L,1L,7L,9L,2L,8L,5L,4L,6L,7L,9L,8L,4L,6L,6L,0L,0L,3L,5L,1L,0L,2L,1L,7L,8L,5L,3L,3L,0L,2L,1L,7L,1L,8L,9L,1L,6L,6L,7L,3L,7L,7L,3L,0L,2L,5L,1L,4L,2L,3L,9L,6L,1L,8L,2L,9L,0L,6L,3L,2L,0L,8L,8L,9L,5L,4L,2L,6L,8L,3L,5L,7L,2L,4L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011153Inst : IEnumerable<long>
{
public static readonly long[] Value=A011153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011153.Bytes);
public long this[int i]=>Value[i];

public static A011153Inst Instance=new A011153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011152
{
public static readonly long[] Value={ 2L,3L,1L,8L,5L,4L,1L,9L,6L,2L,9L,7L,8L,0L,5L,0L,4L,1L,1L,6L,8L,8L,0L,6L,6L,2L,9L,2L,2L,9L,5L,8L,7L,2L,1L,2L,3L,3L,8L,3L,0L,9L,9L,7L,7L,7L,6L,9L,4L,1L,7L,5L,5L,3L,0L,6L,2L,6L,5L,6L,1L,1L,8L,6L,5L,9L,5L,7L,4L,7L,1L,8L,2L,2L,8L,6L,1L,2L,7L,3L,3L,1L,4L,4L,9L,5L,7L,7L,3L,5L,4L,8L,9L,6L,8L,5L,5L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011152Inst : IEnumerable<long>
{
public static readonly long[] Value=A011152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011152.Bytes);
public long this[int i]=>Value[i];

public static A011152Inst Instance=new A011152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011151
{
public static readonly long[] Value={ 2L,3L,1L,1L,5L,7L,9L,2L,4L,8L,7L,3L,0L,0L,2L,9L,1L,4L,7L,8L,9L,1L,2L,2L,3L,8L,5L,9L,3L,3L,2L,6L,5L,1L,8L,9L,1L,0L,8L,8L,4L,1L,5L,1L,9L,2L,9L,3L,2L,6L,2L,5L,7L,6L,4L,3L,3L,2L,9L,6L,8L,4L,5L,4L,6L,2L,0L,1L,6L,1L,8L,5L,6L,8L,1L,2L,5L,1L,7L,6L,8L,2L,8L,2L,6L,0L,1L,8L,3L,5L,4L,2L,2L,8L,7L,7L,3L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011151Inst : IEnumerable<long>
{
public static readonly long[] Value=A011151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011151.Bytes);
public long this[int i]=>Value[i];

public static A011151Inst Instance=new A011151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011150
{
public static readonly long[] Value={ 2L,3L,0L,4L,5L,3L,1L,6L,1L,9L,8L,0L,2L,1L,4L,0L,6L,3L,1L,9L,8L,8L,1L,8L,8L,4L,3L,6L,5L,5L,6L,0L,9L,5L,3L,9L,9L,7L,4L,0L,1L,1L,1L,8L,1L,7L,7L,1L,7L,5L,9L,0L,8L,8L,6L,2L,7L,0L,1L,4L,3L,5L,0L,4L,9L,6L,5L,0L,7L,4L,2L,6L,3L,8L,2L,0L,6L,1L,1L,1L,4L,7L,1L,3L,9L,8L,2L,8L,8L,3L,8L,0L,6L,1L,9L,0L,4L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011150Inst : IEnumerable<long>
{
public static readonly long[] Value=A011150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011150.Bytes);
public long this[int i]=>Value[i];

public static A011150Inst Instance=new A011150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011133
{
public static readonly long[] Value={ 2L,1L,6L,8L,9L,4L,3L,5L,4L,2L,3L,9L,5L,3L,9L,7L,2L,2L,7L,4L,9L,1L,2L,1L,9L,8L,4L,4L,8L,2L,2L,3L,5L,9L,5L,0L,4L,4L,2L,1L,4L,7L,2L,6L,8L,2L,5L,0L,7L,9L,1L,9L,7L,4L,8L,0L,0L,8L,0L,6L,9L,7L,7L,2L,7L,1L,4L,5L,5L,8L,8L,8L,4L,9L,0L,2L,4L,9L,0L,3L,0L,2L,8L,2L,2L,9L,6L,6L,5L,4L,7L,8L,9L,1L,7L,6L,7L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011133Inst : IEnumerable<long>
{
public static readonly long[] Value=A011133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011133.Bytes);
public long this[int i]=>Value[i];

public static A011133Inst Instance=new A011133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011132
{
public static readonly long[] Value={ 2L,1L,5L,9L,8L,3L,0L,0L,1L,1L,7L,6L,4L,4L,6L,6L,1L,5L,5L,6L,4L,3L,0L,2L,1L,9L,7L,5L,7L,6L,7L,8L,5L,0L,7L,4L,9L,5L,9L,6L,5L,2L,0L,6L,7L,1L,6L,6L,6L,9L,2L,7L,7L,1L,7L,2L,4L,9L,6L,2L,8L,0L,1L,6L,8L,8L,6L,3L,8L,4L,0L,7L,3L,9L,1L,3L,8L,9L,3L,3L,2L,7L,0L,5L,0L,3L,0L,9L,8L,8L,4L,6L,3L,7L,8L,0L,8L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011132Inst : IEnumerable<long>
{
public static readonly long[] Value=A011132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011132.Bytes);
public long this[int i]=>Value[i];

public static A011132Inst Instance=new A011132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011131
{
public static readonly long[] Value={ 2L,1L,5L,0L,5L,6L,0L,0L,1L,2L,8L,1L,1L,1L,3L,9L,4L,7L,6L,8L,4L,7L,4L,5L,0L,3L,6L,8L,8L,5L,8L,7L,7L,5L,3L,5L,7L,6L,3L,9L,1L,7L,9L,2L,8L,0L,4L,5L,8L,0L,4L,8L,5L,7L,0L,0L,8L,0L,3L,4L,9L,8L,4L,0L,6L,4L,7L,6L,6L,9L,1L,8L,2L,1L,3L,0L,6L,3L,7L,3L,5L,9L,4L,4L,7L,2L,1L,4L,3L,9L,0L,4L,4L,7L,6L,2L,3L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011131Inst : IEnumerable<long>
{
public static readonly long[] Value=A011131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011131.Bytes);
public long this[int i]=>Value[i];

public static A011131Inst Instance=new A011131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011130
{
public static readonly long[] Value={ 2L,1L,4L,1L,1L,2L,7L,3L,6L,8L,3L,3L,8L,3L,2L,3L,8L,4L,2L,3L,4L,6L,8L,6L,7L,3L,6L,0L,0L,4L,1L,7L,2L,9L,5L,5L,3L,7L,7L,7L,4L,5L,8L,7L,4L,0L,1L,6L,9L,9L,3L,4L,7L,5L,0L,0L,8L,8L,0L,5L,4L,7L,9L,1L,7L,9L,5L,9L,1L,0L,2L,7L,9L,4L,2L,0L,4L,7L,0L,1L,9L,4L,8L,1L,5L,7L,9L,8L,0L,6L,3L,9L,7L,7L,8L,2L,5L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011130Inst : IEnumerable<long>
{
public static readonly long[] Value=A011130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011130.Bytes);
public long this[int i]=>Value[i];

public static A011130Inst Instance=new A011130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011129
{
public static readonly long[] Value={ 2L,1L,3L,1L,5L,2L,5L,5L,1L,3L,2L,7L,0L,9L,4L,8L,4L,8L,7L,1L,9L,1L,3L,3L,4L,8L,1L,0L,3L,6L,7L,3L,9L,1L,9L,7L,3L,9L,8L,7L,8L,6L,2L,7L,3L,8L,4L,6L,6L,5L,0L,4L,9L,9L,9L,1L,2L,6L,0L,1L,9L,5L,8L,3L,1L,1L,8L,7L,7L,4L,8L,5L,0L,3L,8L,0L,1L,4L,2L,8L,2L,6L,6L,8L,3L,8L,3L,5L,6L,0L,5L,2L,4L,6L,3L,8L,6L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011129Inst : IEnumerable<long>
{
public static readonly long[] Value=A011129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011129.Bytes);
public long this[int i]=>Value[i];

public static A011129Inst Instance=new A011129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011128
{
public static readonly long[] Value={ 2L,1L,2L,1L,7L,4L,7L,4L,6L,0L,8L,4L,1L,8L,9L,7L,8L,5L,2L,6L,3L,9L,9L,0L,5L,0L,3L,1L,0L,7L,9L,4L,1L,6L,8L,3L,3L,4L,4L,2L,4L,4L,7L,8L,9L,9L,3L,7L,7L,3L,0L,0L,1L,3L,5L,8L,4L,5L,5L,0L,6L,4L,0L,4L,9L,6L,4L,6L,7L,7L,3L,7L,9L,2L,9L,4L,4L,1L,5L,6L,3L,7L,7L,5L,5L,0L,0L,3L,4L,9L,7L,6L,8L,0L,1L,5L,7L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011128Inst : IEnumerable<long>
{
public static readonly long[] Value=A011128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011128.Bytes);
public long this[int i]=>Value[i];

public static A011128Inst Instance=new A011128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011127
{
public static readonly long[] Value={ 2L,1L,1L,1L,7L,8L,5L,7L,6L,4L,9L,6L,6L,7L,5L,3L,9L,1L,2L,7L,3L,2L,5L,6L,7L,3L,3L,0L,5L,5L,0L,2L,3L,3L,4L,8L,6L,3L,0L,3L,2L,0L,2L,6L,5L,3L,6L,3L,0L,6L,3L,7L,8L,2L,0L,8L,0L,9L,0L,3L,8L,7L,8L,6L,0L,3L,7L,6L,2L,2L,6L,4L,9L,6L,9L,5L,4L,0L,5L,6L,4L,4L,8L,4L,4L,7L,9L,1L,1L,4L,2L,5L,5L,4L,8L,9L,6L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011127Inst : IEnumerable<long>
{
public static readonly long[] Value=A011127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011127.Bytes);
public long this[int i]=>Value[i];

public static A011127Inst Instance=new A011127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011126
{
public static readonly long[] Value={ 2L,1L,0L,1L,6L,3L,2L,4L,7L,8L,2L,7L,5L,7L,8L,4L,7L,3L,1L,4L,2L,8L,8L,2L,9L,9L,0L,4L,7L,6L,6L,7L,3L,8L,8L,4L,4L,2L,3L,6L,7L,9L,2L,8L,8L,9L,9L,5L,9L,0L,5L,5L,8L,7L,4L,2L,6L,8L,5L,3L,6L,6L,7L,7L,0L,1L,1L,1L,2L,8L,8L,5L,5L,9L,7L,3L,0L,3L,2L,5L,6L,0L,3L,7L,4L,0L,2L,7L,6L,3L,3L,5L,4L,9L,2L,2L,0L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011126Inst : IEnumerable<long>
{
public static readonly long[] Value=A011126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011126.Bytes);
public long this[int i]=>Value[i];

public static A011126Inst Instance=new A011126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011125
{
public static readonly long[] Value={ 2L,0L,9L,1L,2L,7L,9L,1L,0L,5L,1L,8L,2L,5L,4L,6L,4L,6L,1L,3L,0L,5L,9L,7L,0L,5L,8L,2L,4L,4L,1L,0L,3L,6L,5L,0L,4L,9L,4L,0L,6L,8L,9L,7L,4L,3L,0L,1L,2L,3L,8L,1L,3L,8L,1L,8L,0L,0L,7L,3L,2L,7L,6L,0L,9L,6L,6L,3L,9L,9L,5L,0L,0L,5L,5L,8L,0L,8L,7L,1L,9L,7L,2L,3L,7L,5L,4L,6L,1L,7L,6L,7L,0L,7L,8L,3L,5L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011125Inst : IEnumerable<long>
{
public static readonly long[] Value=A011125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011125.Bytes);
public long this[int i]=>Value[i];

public static A011125Inst Instance=new A011125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011124
{
public static readonly long[] Value={ 2L,0L,8L,0L,7L,1L,6L,5L,4L,9L,2L,6L,1L,8L,4L,3L,7L,2L,9L,6L,9L,2L,7L,4L,2L,2L,9L,8L,7L,5L,8L,5L,8L,4L,2L,3L,2L,4L,8L,1L,0L,2L,9L,1L,0L,1L,4L,6L,4L,4L,2L,6L,9L,8L,6L,6L,4L,4L,5L,0L,8L,1L,8L,5L,9L,1L,9L,1L,2L,9L,0L,4L,9L,0L,9L,5L,2L,2L,5L,4L,7L,5L,5L,5L,4L,9L,8L,0L,8L,8L,6L,2L,5L,4L,3L,4L,9L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011124Inst : IEnumerable<long>
{
public static readonly long[] Value=A011124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011124.Bytes);
public long this[int i]=>Value[i];

public static A011124Inst Instance=new A011124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011123
{
public static readonly long[] Value={ 2L,0L,6L,9L,9L,3L,5L,0L,5L,4L,0L,8L,1L,6L,1L,4L,0L,6L,1L,5L,4L,2L,6L,2L,3L,4L,2L,0L,5L,4L,8L,6L,8L,9L,1L,9L,9L,8L,5L,1L,6L,1L,4L,4L,8L,6L,7L,3L,3L,9L,0L,2L,1L,1L,8L,0L,0L,3L,3L,8L,8L,6L,1L,3L,6L,1L,0L,5L,0L,5L,2L,7L,4L,4L,4L,4L,2L,4L,9L,8L,0L,2L,6L,9L,3L,8L,0L,9L,3L,9L,9L,6L,3L,5L,5L,9L,5L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011123Inst : IEnumerable<long>
{
public static readonly long[] Value=A011123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011123.Bytes);
public long this[int i]=>Value[i];

public static A011123Inst Instance=new A011123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011122
{
public static readonly long[] Value={ 2L,0L,5L,8L,9L,2L,4L,1L,3L,6L,4L,7L,8L,5L,1L,7L,2L,5L,2L,4L,6L,0L,0L,3L,0L,4L,1L,6L,0L,6L,6L,1L,8L,6L,5L,8L,6L,9L,1L,8L,1L,3L,3L,7L,9L,9L,4L,6L,4L,7L,2L,2L,0L,0L,0L,6L,1L,4L,6L,7L,4L,0L,0L,3L,1L,1L,2L,0L,9L,0L,6L,6L,0L,3L,9L,8L,6L,0L,9L,1L,8L,2L,2L,5L,1L,8L,5L,6L,1L,3L,6L,7L,7L,9L,1L,1L,5L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011122Inst : IEnumerable<long>
{
public static readonly long[] Value=A011122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011122.Bytes);
public long this[int i]=>Value[i];

public static A011122Inst Instance=new A011122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011121
{
public static readonly long[] Value={ 2L,0L,4L,7L,6L,7L,2L,5L,1L,1L,0L,7L,9L,2L,1L,9L,2L,9L,6L,2L,1L,2L,8L,3L,7L,3L,5L,6L,3L,2L,8L,6L,2L,1L,8L,7L,5L,4L,9L,6L,2L,1L,9L,1L,8L,5L,1L,9L,6L,6L,9L,0L,2L,1L,1L,9L,5L,5L,8L,2L,1L,6L,3L,1L,8L,6L,1L,5L,0L,8L,6L,5L,2L,4L,2L,5L,8L,9L,2L,1L,3L,3L,8L,7L,0L,1L,8L,2L,1L,2L,7L,3L,3L,9L,9L,4L,6L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011121Inst : IEnumerable<long>
{
public static readonly long[] Value=A011121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011121.Bytes);
public long this[int i]=>Value[i];

public static A011121Inst Instance=new A011121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011120
{
public static readonly long[] Value={ 2L,0L,3L,6L,1L,6L,8L,0L,0L,4L,6L,4L,0L,3L,9L,8L,0L,1L,7L,3L,6L,0L,8L,7L,4L,1L,6L,4L,1L,4L,5L,3L,1L,7L,6L,9L,4L,2L,6L,1L,8L,1L,6L,1L,6L,7L,5L,7L,8L,5L,3L,5L,1L,8L,6L,1L,1L,3L,5L,5L,0L,0L,8L,5L,2L,9L,1L,4L,1L,4L,9L,4L,6L,8L,6L,5L,9L,1L,3L,5L,9L,1L,0L,6L,7L,6L,1L,3L,0L,8L,8L,9L,9L,3L,4L,3L,1L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011120Inst : IEnumerable<long>
{
public static readonly long[] Value=A011120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011120.Bytes);
public long this[int i]=>Value[i];

public static A011120Inst Instance=new A011120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011119
{
public static readonly long[] Value={ 2L,0L,2L,4L,3L,9L,7L,4L,5L,8L,4L,9L,9L,8L,8L,5L,0L,4L,2L,5L,1L,0L,8L,1L,7L,2L,4L,5L,5L,4L,1L,9L,3L,7L,4L,1L,9L,1L,1L,4L,6L,2L,1L,7L,0L,1L,0L,7L,3L,1L,1L,8L,3L,5L,5L,3L,6L,1L,9L,7L,9L,5L,0L,7L,7L,7L,4L,9L,8L,8L,7L,2L,1L,8L,5L,6L,6L,2L,2L,3L,3L,9L,4L,7L,8L,2L,4L,5L,6L,9L,2L,0L,2L,1L,9L,1L,5L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011119Inst : IEnumerable<long>
{
public static readonly long[] Value=A011119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011119.Bytes);
public long this[int i]=>Value[i];

public static A011119Inst Instance=new A011119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011118
{
public static readonly long[] Value={ 2L,0L,1L,2L,3L,4L,6L,6L,1L,7L,0L,8L,5L,5L,5L,8L,3L,2L,4L,7L,7L,8L,5L,6L,0L,8L,6L,2L,9L,9L,5L,5L,2L,4L,6L,6L,6L,5L,2L,4L,1L,3L,4L,7L,2L,6L,2L,3L,6L,5L,0L,3L,2L,3L,4L,6L,7L,5L,1L,3L,5L,9L,1L,2L,0L,9L,9L,1L,0L,4L,4L,4L,2L,1L,8L,2L,4L,6L,8L,6L,6L,5L,9L,0L,6L,3L,6L,8L,6L,5L,9L,5L,3L,5L,5L,1L,6L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011118Inst : IEnumerable<long>
{
public static readonly long[] Value=A011118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011118.Bytes);
public long this[int i]=>Value[i];

public static A011118Inst Instance=new A011118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011101
{
public static readonly long[] Value={ 1L,7L,4L,1L,1L,0L,1L,1L,2L,6L,5L,9L,2L,2L,4L,8L,2L,7L,8L,2L,7L,2L,5L,4L,0L,0L,3L,4L,9L,5L,9L,4L,9L,2L,1L,9L,7L,9L,5L,8L,2L,5L,0L,8L,4L,8L,6L,9L,6L,0L,0L,6L,0L,9L,6L,4L,8L,3L,7L,1L,9L,1L,3L,7L,0L,1L,3L,5L,0L,0L,0L,3L,5L,5L,0L,4L,9L,5L,6L,0L,2L,0L,3L,7L,6L,7L,5L,7L,5L,2L,9L,7L,4L,3L,3L,4L,0L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011101Inst : IEnumerable<long>
{
public static readonly long[] Value=A011101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011101.Bytes);
public long this[int i]=>Value[i];

public static A011101Inst Instance=new A011101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011100
{
public static readonly long[] Value={ 1L,7L,1L,8L,7L,7L,1L,9L,2L,7L,5L,8L,7L,4L,7L,8L,7L,7L,7L,0L,1L,3L,5L,2L,1L,4L,5L,2L,0L,4L,4L,4L,0L,9L,1L,5L,7L,1L,3L,5L,4L,5L,8L,9L,1L,7L,9L,5L,1L,7L,5L,3L,6L,7L,6L,0L,4L,2L,9L,2L,1L,4L,5L,1L,1L,6L,0L,0L,6L,8L,3L,6L,0L,2L,3L,9L,0L,6L,3L,8L,5L,9L,8L,9L,7L,6L,2L,0L,2L,8L,6L,9L,0L,9L,5L,0L,5L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011100Inst : IEnumerable<long>
{
public static readonly long[] Value=A011100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011100.Bytes);
public long this[int i]=>Value[i];

public static A011100Inst Instance=new A011100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011099
{
public static readonly long[] Value={ 1L,6L,9L,5L,2L,1L,8L,2L,0L,3L,0L,7L,2L,4L,3L,5L,4L,8L,1L,5L,4L,9L,3L,4L,3L,5L,8L,4L,6L,0L,7L,7L,6L,7L,1L,1L,5L,2L,9L,4L,3L,8L,0L,5L,6L,4L,6L,8L,4L,0L,9L,1L,5L,9L,3L,0L,9L,9L,6L,1L,6L,3L,5L,8L,0L,5L,4L,5L,8L,3L,2L,3L,6L,0L,9L,0L,8L,0L,8L,1L,7L,7L,4L,4L,1L,5L,8L,9L,0L,0L,3L,2L,5L,3L,7L,1L,1L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011099Inst : IEnumerable<long>
{
public static readonly long[] Value=A011099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011099.Bytes);
public long this[int i]=>Value[i];

public static A011099Inst Instance=new A011099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011098
{
public static readonly long[] Value={ 1L,6L,7L,0L,2L,7L,7L,6L,5L,2L,3L,3L,4L,8L,1L,0L,3L,9L,4L,8L,0L,3L,6L,5L,2L,8L,9L,1L,3L,1L,2L,7L,1L,4L,6L,3L,1L,2L,9L,1L,0L,6L,8L,8L,4L,5L,6L,9L,0L,0L,4L,6L,2L,4L,9L,8L,0L,2L,7L,1L,7L,1L,4L,2L,8L,7L,1L,7L,3L,1L,0L,1L,8L,5L,8L,5L,3L,7L,3L,1L,5L,8L,4L,2L,9L,0L,2L,9L,6L,5L,6L,3L,1L,9L,7L,1L,3L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011098Inst : IEnumerable<long>
{
public static readonly long[] Value=A011098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011098.Bytes);
public long this[int i]=>Value[i];

public static A011098Inst Instance=new A011098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011097
{
public static readonly long[] Value={ 1L,6L,4L,3L,7L,5L,1L,8L,2L,9L,5L,1L,7L,2L,2L,5L,7L,6L,2L,3L,0L,8L,4L,9L,7L,9L,3L,6L,2L,3L,0L,9L,7L,9L,5L,1L,7L,3L,8L,3L,4L,9L,2L,5L,8L,9L,9L,4L,5L,4L,7L,5L,2L,0L,0L,4L,1L,1L,0L,2L,9L,7L,6L,7L,5L,3L,2L,1L,0L,7L,6L,9L,2L,4L,9L,2L,0L,9L,9L,7L,9L,2L,9L,9L,7L,6L,2L,0L,1L,9L,8L,4L,1L,8L,9L,4L,7L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011097Inst : IEnumerable<long>
{
public static readonly long[] Value=A011097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011097.Bytes);
public long this[int i]=>Value[i];

public static A011097Inst Instance=new A011097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011096
{
public static readonly long[] Value={ 1L,6L,1L,5L,3L,9L,4L,2L,6L,6L,2L,0L,2L,1L,7L,8L,0L,0L,1L,5L,0L,8L,1L,4L,7L,8L,8L,2L,0L,6L,3L,8L,3L,5L,8L,4L,5L,4L,1L,6L,5L,3L,5L,2L,0L,5L,4L,6L,9L,2L,9L,0L,7L,8L,7L,1L,0L,7L,6L,8L,6L,9L,0L,2L,1L,6L,9L,9L,6L,8L,2L,4L,6L,9L,2L,5L,7L,8L,4L,3L,3L,4L,6L,8L,1L,1L,4L,3L,6L,6L,9L,6L,5L,8L,6L,1L,6L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011096Inst : IEnumerable<long>
{
public static readonly long[] Value=A011096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011096.Bytes);
public long this[int i]=>Value[i];

public static A011096Inst Instance=new A011096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011095
{
public static readonly long[] Value={ 1L,5L,8L,4L,8L,9L,3L,1L,9L,2L,4L,6L,1L,1L,1L,3L,4L,8L,5L,2L,0L,2L,1L,0L,1L,3L,7L,3L,3L,9L,1L,5L,0L,7L,0L,1L,3L,2L,6L,9L,4L,4L,2L,1L,3L,3L,8L,2L,5L,0L,3L,9L,0L,6L,8L,3L,1L,6L,2L,9L,6L,8L,1L,2L,3L,1L,6L,6L,5L,6L,8L,6L,3L,6L,6L,8L,4L,5L,3L,9L,8L,0L,1L,1L,0L,2L,0L,2L,7L,2L,3L,8L,4L,6L,1L,1L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011095Inst : IEnumerable<long>
{
public static readonly long[] Value=A011095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011095.Bytes);
public long this[int i]=>Value[i];

public static A011095Inst Instance=new A011095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011094
{
public static readonly long[] Value={ 1L,5L,5L,1L,8L,4L,5L,5L,7L,3L,9L,1L,5L,3L,5L,9L,6L,7L,4L,2L,7L,3L,3L,4L,5L,1L,3L,5L,5L,1L,6L,6L,9L,9L,3L,2L,3L,2L,6L,2L,3L,4L,6L,2L,9L,3L,8L,0L,9L,6L,6L,7L,8L,3L,7L,7L,3L,6L,3L,4L,0L,4L,9L,9L,7L,8L,2L,9L,0L,6L,3L,5L,7L,1L,7L,0L,7L,0L,8L,0L,7L,2L,4L,8L,2L,2L,6L,6L,8L,7L,3L,0L,9L,3L,2L,5L,9L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011094Inst : IEnumerable<long>
{
public static readonly long[] Value=A011094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011094.Bytes);
public long this[int i]=>Value[i];

public static A011094Inst Instance=new A011094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011093
{
public static readonly long[] Value={ 1L,5L,1L,5L,7L,1L,6L,5L,6L,6L,5L,1L,0L,3L,9L,8L,0L,8L,2L,3L,4L,7L,2L,5L,9L,8L,0L,1L,3L,0L,6L,4L,4L,5L,2L,3L,8L,6L,8L,1L,2L,8L,3L,5L,4L,2L,9L,7L,8L,1L,4L,1L,6L,4L,2L,0L,3L,7L,5L,0L,5L,2L,4L,2L,0L,9L,7L,4L,5L,3L,6L,7L,7L,2L,0L,2L,0L,5L,8L,2L,7L,7L,6L,4L,1L,1L,7L,6L,1L,3L,4L,8L,4L,9L,4L,3L,1L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011093Inst : IEnumerable<long>
{
public static readonly long[] Value=A011093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011093.Bytes);
public long this[int i]=>Value[i];

public static A011093Inst Instance=new A011093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011092
{
public static readonly long[] Value={ 1L,4L,7L,5L,7L,7L,3L,1L,6L,1L,5L,9L,4L,5L,5L,2L,0L,6L,9L,2L,7L,6L,9L,1L,6L,6L,9L,5L,6L,3L,2L,2L,4L,4L,1L,0L,6L,5L,4L,4L,0L,9L,3L,6L,1L,3L,7L,4L,0L,2L,0L,3L,5L,6L,7L,7L,7L,0L,9L,0L,4L,1L,6L,8L,8L,8L,4L,5L,2L,1L,7L,6L,7L,4L,9L,9L,2L,0L,8L,3L,6L,0L,7L,1L,4L,4L,1L,1L,0L,8L,2L,3L,5L,1L,2L,9L,8L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011092Inst : IEnumerable<long>
{
public static readonly long[] Value=A011092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011092.Bytes);
public long this[int i]=>Value[i];

public static A011092Inst Instance=new A011092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011091
{
public static readonly long[] Value={ 1L,4L,3L,0L,9L,6L,9L,0L,8L,1L,1L,0L,5L,2L,5L,5L,5L,0L,1L,0L,4L,5L,2L,2L,4L,4L,1L,3L,1L,4L,3L,1L,1L,6L,9L,0L,4L,9L,7L,2L,6L,4L,9L,9L,3L,9L,6L,6L,1L,2L,8L,1L,7L,3L,9L,9L,8L,8L,3L,6L,8L,5L,7L,9L,7L,5L,8L,2L,8L,2L,5L,0L,2L,7L,8L,3L,2L,3L,3L,4L,9L,9L,8L,5L,6L,0L,8L,8L,1L,6L,0L,4L,6L,8L,1L,3L,3L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011091Inst : IEnumerable<long>
{
public static readonly long[] Value=A011091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011091.Bytes);
public long this[int i]=>Value[i];

public static A011091Inst Instance=new A011091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011090
{
public static readonly long[] Value={ 3L,1L,5L,4L,3L,4L,2L,1L,4L,5L,5L,2L,9L,9L,0L,4L,2L,3L,4L,9L,2L,3L,1L,2L,6L,8L,4L,9L,2L,9L,4L,6L,8L,7L,9L,8L,0L,4L,9L,6L,2L,3L,6L,2L,9L,3L,3L,0L,9L,8L,3L,5L,7L,8L,9L,9L,5L,4L,1L,0L,1L,7L,5L,8L,1L,9L,9L,1L,8L,5L,5L,2L,6L,8L,7L,2L,4L,9L,1L,2L,1L,5L,0L,8L,2L,8L,2L,5L,4L,3L,8L,9L,2L,2L,8L,0L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011090Inst : IEnumerable<long>
{
public static readonly long[] Value=A011090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011090.Bytes);
public long this[int i]=>Value[i];

public static A011090Inst Instance=new A011090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011089
{
public static readonly long[] Value={ 3L,1L,4L,6L,3L,4L,6L,2L,8L,3L,6L,4L,5L,7L,8L,8L,6L,2L,0L,6L,2L,1L,8L,9L,2L,6L,4L,2L,2L,8L,2L,8L,1L,3L,8L,1L,5L,6L,1L,8L,5L,6L,0L,2L,3L,8L,0L,6L,6L,2L,4L,4L,6L,2L,4L,0L,2L,2L,3L,9L,2L,8L,9L,0L,8L,2L,0L,3L,3L,7L,3L,9L,6L,0L,5L,3L,5L,4L,9L,5L,3L,5L,5L,4L,2L,0L,0L,5L,6L,3L,1L,0L,5L,6L,2L,1L,9L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011089Inst : IEnumerable<long>
{
public static readonly long[] Value=A011089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011089.Bytes);
public long this[int i]=>Value[i];

public static A011089Inst Instance=new A011089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011088
{
public static readonly long[] Value={ 3L,1L,3L,8L,2L,8L,8L,9L,9L,2L,7L,1L,4L,9L,9L,6L,0L,8L,0L,4L,5L,5L,7L,7L,2L,1L,2L,7L,2L,8L,7L,0L,1L,2L,3L,7L,3L,5L,1L,2L,0L,7L,2L,3L,8L,5L,2L,5L,1L,7L,9L,4L,6L,1L,6L,5L,0L,9L,9L,9L,8L,7L,5L,7L,5L,2L,3L,5L,3L,1L,9L,0L,5L,9L,5L,3L,8L,4L,6L,3L,3L,2L,3L,2L,3L,0L,2L,5L,0L,5L,2L,4L,4L,6L,6L,0L,6L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011088Inst : IEnumerable<long>
{
public static readonly long[] Value=A011088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011088.Bytes);
public long this[int i]=>Value[i];

public static A011088Inst Instance=new A011088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011087
{
public static readonly long[] Value={ 3L,1L,3L,0L,1L,6L,9L,1L,6L,0L,1L,4L,6L,5L,7L,4L,6L,3L,3L,1L,6L,8L,9L,7L,0L,9L,9L,8L,3L,1L,7L,3L,7L,9L,6L,1L,9L,6L,2L,1L,4L,5L,3L,8L,8L,5L,5L,4L,9L,5L,7L,8L,4L,4L,5L,6L,3L,9L,6L,1L,8L,1L,8L,4L,0L,2L,1L,6L,4L,6L,8L,8L,2L,1L,0L,5L,7L,6L,4L,0L,1L,7L,4L,8L,4L,0L,7L,0L,5L,4L,3L,8L,2L,0L,9L,1L,7L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011087Inst : IEnumerable<long>
{
public static readonly long[] Value=A011087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011087.Bytes);
public long this[int i]=>Value[i];

public static A011087Inst Instance=new A011087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011086
{
public static readonly long[] Value={ 3L,1L,2L,1L,9L,8L,5L,6L,4L,1L,3L,5L,2L,1L,4L,4L,9L,6L,1L,3L,4L,1L,0L,3L,2L,4L,9L,8L,0L,5L,7L,8L,1L,5L,8L,6L,3L,3L,9L,4L,5L,6L,1L,4L,0L,5L,3L,0L,1L,0L,6L,5L,9L,8L,0L,1L,4L,1L,3L,4L,8L,3L,0L,4L,5L,9L,6L,6L,6L,9L,5L,8L,6L,9L,9L,4L,5L,1L,5L,8L,0L,3L,6L,8L,0L,8L,6L,3L,2L,8L,3L,7L,9L,8L,5L,3L,9L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011086Inst : IEnumerable<long>
{
public static readonly long[] Value=A011086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011086.Bytes);
public long this[int i]=>Value[i];

public static A011086Inst Instance=new A011086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011069
{
public static readonly long[] Value={ 2L,9L,6L,2L,2L,5L,6L,6L,3L,7L,6L,6L,5L,2L,9L,8L,9L,2L,1L,3L,9L,1L,8L,2L,7L,6L,8L,1L,2L,3L,7L,3L,2L,6L,2L,7L,3L,6L,7L,0L,8L,8L,2L,0L,9L,2L,8L,1L,5L,4L,9L,6L,1L,0L,2L,4L,7L,8L,4L,7L,0L,5L,1L,6L,8L,3L,1L,5L,8L,2L,2L,2L,3L,3L,7L,2L,7L,7L,8L,1L,2L,8L,4L,0L,3L,1L,5L,1L,7L,7L,0L,7L,7L,9L,2L,7L,6L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011069Inst : IEnumerable<long>
{
public static readonly long[] Value=A011069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011069.Bytes);
public long this[int i]=>Value[i];

public static A011069Inst Instance=new A011069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011068
{
public static readonly long[] Value={ 2L,9L,5L,2L,5L,9L,1L,7L,2L,3L,7L,3L,7L,1L,8L,9L,3L,5L,4L,8L,6L,7L,4L,2L,1L,3L,0L,6L,3L,2L,0L,1L,4L,0L,1L,0L,0L,2L,8L,7L,3L,4L,8L,0L,8L,1L,2L,0L,4L,0L,6L,3L,7L,2L,5L,0L,6L,4L,1L,3L,5L,3L,1L,2L,7L,9L,9L,5L,8L,6L,1L,9L,4L,5L,9L,8L,5L,4L,2L,6L,9L,8L,4L,7L,1L,5L,4L,6L,2L,5L,2L,3L,4L,0L,8L,1L,0L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011068Inst : IEnumerable<long>
{
public static readonly long[] Value=A011068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011068.Bytes);
public long this[int i]=>Value[i];

public static A011068Inst Instance=new A011068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011067
{
public static readonly long[] Value={ 2L,9L,4L,2L,8L,3L,0L,9L,5L,6L,3L,8L,2L,7L,1L,1L,8L,4L,5L,3L,5L,7L,3L,1L,1L,6L,7L,4L,0L,9L,8L,1L,7L,1L,1L,6L,7L,5L,1L,8L,1L,3L,4L,3L,7L,1L,4L,4L,4L,9L,7L,1L,1L,1L,6L,3L,3L,5L,0L,4L,2L,1L,9L,1L,9L,5L,1L,7L,3L,5L,6L,3L,2L,6L,9L,9L,4L,5L,0L,4L,4L,8L,1L,7L,7L,5L,8L,5L,0L,1L,3L,8L,9L,3L,3L,8L,6L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011067Inst : IEnumerable<long>
{
public static readonly long[] Value=A011067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011067.Bytes);
public long this[int i]=>Value[i];

public static A011067Inst Instance=new A011067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011066
{
public static readonly long[] Value={ 2L,9L,3L,2L,9L,7L,2L,0L,8L,7L,6L,6L,8L,5L,1L,8L,3L,2L,9L,8L,6L,4L,7L,8L,6L,8L,7L,5L,0L,8L,9L,7L,7L,1L,2L,9L,1L,9L,3L,6L,5L,0L,3L,8L,5L,3L,9L,1L,6L,1L,6L,5L,5L,6L,2L,0L,9L,9L,8L,1L,2L,9L,2L,0L,6L,7L,9L,4L,6L,2L,6L,3L,1L,7L,3L,0L,2L,2L,1L,3L,1L,3L,5L,4L,8L,7L,8L,5L,8L,7L,6L,1L,4L,8L,1L,8L,5L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011066Inst : IEnumerable<long>
{
public static readonly long[] Value=A011066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011066.Bytes);
public long this[int i]=>Value[i];

public static A011066Inst Instance=new A011066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011065
{
public static readonly long[] Value={ 2L,9L,2L,3L,0L,1L,2L,7L,8L,5L,6L,9L,1L,7L,6L,4L,8L,3L,9L,8L,8L,4L,7L,3L,3L,8L,1L,4L,5L,5L,6L,1L,6L,0L,9L,3L,4L,3L,4L,9L,6L,4L,3L,0L,0L,9L,9L,4L,2L,7L,7L,8L,2L,9L,3L,9L,6L,2L,9L,4L,0L,5L,1L,4L,1L,2L,3L,1L,3L,8L,9L,0L,0L,3L,7L,7L,0L,5L,0L,9L,5L,6L,8L,6L,2L,2L,8L,9L,0L,3L,6L,2L,8L,1L,3L,9L,3L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011065Inst : IEnumerable<long>
{
public static readonly long[] Value=A011065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011065.Bytes);
public long this[int i]=>Value[i];

public static A011065Inst Instance=new A011065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011064
{
public static readonly long[] Value={ 2L,9L,1L,2L,9L,5L,0L,6L,3L,0L,2L,4L,3L,9L,4L,0L,5L,2L,1L,7L,0L,2L,3L,2L,3L,7L,6L,4L,9L,4L,6L,5L,0L,4L,8L,7L,4L,2L,7L,9L,5L,3L,9L,1L,4L,7L,0L,6L,9L,4L,9L,1L,2L,6L,2L,1L,8L,3L,7L,7L,5L,2L,9L,8L,5L,8L,7L,0L,1L,4L,4L,7L,1L,7L,3L,7L,1L,7L,0L,1L,3L,9L,1L,7L,1L,7L,9L,8L,1L,5L,7L,9L,2L,6L,2L,6L,6L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011064Inst : IEnumerable<long>
{
public static readonly long[] Value=A011064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011064.Bytes);
public long this[int i]=>Value[i];

public static A011064Inst Instance=new A011064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011063
{
public static readonly long[] Value={ 2L,9L,0L,2L,7L,8L,3L,1L,0L,8L,1L,8L,7L,0L,9L,9L,5L,7L,4L,1L,3L,0L,3L,4L,7L,6L,0L,8L,3L,8L,2L,6L,9L,6L,0L,5L,0L,8L,1L,1L,9L,3L,1L,5L,8L,5L,4L,8L,4L,6L,2L,7L,9L,1L,5L,2L,9L,5L,4L,8L,1L,0L,5L,1L,3L,1L,1L,8L,8L,7L,1L,0L,6L,3L,9L,9L,1L,5L,3L,6L,2L,6L,3L,5L,9L,9L,2L,5L,9L,9L,2L,6L,8L,8L,5L,2L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011063Inst : IEnumerable<long>
{
public static readonly long[] Value=A011063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011063.Bytes);
public long this[int i]=>Value[i];

public static A011063Inst Instance=new A011063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011062
{
public static readonly long[] Value={ 2L,8L,9L,2L,5L,0L,7L,6L,0L,8L,5L,1L,9L,0L,7L,7L,9L,4L,5L,9L,3L,2L,9L,7L,3L,7L,2L,9L,9L,5L,1L,5L,3L,0L,6L,4L,0L,0L,3L,5L,0L,9L,8L,3L,5L,6L,0L,3L,8L,4L,7L,1L,5L,1L,7L,8L,5L,4L,9L,0L,5L,4L,6L,4L,2L,2L,6L,2L,3L,4L,2L,2L,3L,8L,8L,3L,6L,8L,3L,0L,4L,8L,8L,7L,2L,9L,6L,4L,0L,4L,3L,6L,4L,5L,5L,8L,7L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011062Inst : IEnumerable<long>
{
public static readonly long[] Value=A011062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011062.Bytes);
public long this[int i]=>Value[i];

public static A011062Inst Instance=new A011062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011061
{
public static readonly long[] Value={ 2L,8L,8L,2L,1L,2L,1L,4L,1L,7L,1L,0L,2L,0L,0L,5L,9L,3L,2L,1L,7L,6L,4L,9L,6L,0L,7L,6L,9L,3L,6L,1L,4L,6L,6L,6L,5L,5L,6L,5L,1L,0L,1L,8L,1L,4L,3L,0L,0L,5L,7L,4L,3L,7L,1L,3L,2L,6L,8L,9L,7L,8L,7L,8L,9L,6L,8L,6L,4L,8L,9L,0L,1L,0L,6L,4L,1L,8L,0L,6L,4L,6L,3L,9L,9L,2L,3L,3L,4L,8L,6L,1L,0L,5L,5L,3L,5L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011061Inst : IEnumerable<long>
{
public static readonly long[] Value=A011061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011061.Bytes);
public long this[int i]=>Value[i];

public static A011061Inst Instance=new A011061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011060
{
public static readonly long[] Value={ 2L,8L,7L,1L,6L,2L,1L,7L,1L,1L,0L,2L,5L,9L,0L,0L,6L,2L,2L,2L,9L,8L,6L,0L,1L,3L,7L,5L,5L,1L,2L,5L,6L,6L,4L,6L,7L,6L,1L,9L,5L,1L,8L,1L,4L,5L,6L,1L,8L,6L,3L,5L,6L,6L,1L,0L,4L,1L,4L,2L,0L,8L,7L,2L,4L,7L,9L,0L,6L,6L,6L,8L,0L,2L,8L,7L,9L,5L,6L,5L,9L,9L,7L,2L,5L,4L,6L,9L,3L,0L,6L,1L,4L,8L,7L,5L,9L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011060Inst : IEnumerable<long>
{
public static readonly long[] Value=A011060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011060.Bytes);
public long this[int i]=>Value[i];

public static A011060Inst Instance=new A011060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011059
{
public static readonly long[] Value={ 2L,8L,6L,1L,0L,0L,5L,5L,5L,2L,5L,7L,6L,3L,0L,5L,2L,8L,9L,4L,6L,6L,5L,5L,7L,4L,4L,5L,1L,9L,6L,2L,4L,7L,0L,1L,7L,1L,1L,9L,5L,5L,3L,1L,7L,5L,8L,9L,6L,2L,9L,1L,8L,0L,1L,9L,2L,9L,4L,1L,8L,5L,8L,5L,5L,0L,8L,0L,7L,8L,3L,4L,4L,6L,7L,8L,1L,0L,8L,8L,3L,0L,3L,1L,5L,8L,2L,1L,7L,9L,5L,2L,0L,9L,9L,7L,7L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011059Inst : IEnumerable<long>
{
public static readonly long[] Value=A011059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011059.Bytes);
public long this[int i]=>Value[i];

public static A011059Inst Instance=new A011059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011058
{
public static readonly long[] Value={ 2L,8L,5L,0L,2L,6L,9L,8L,8L,2L,7L,7L,1L,7L,9L,8L,2L,1L,8L,7L,6L,6L,7L,4L,6L,7L,8L,3L,0L,6L,3L,8L,4L,2L,7L,2L,8L,1L,1L,5L,4L,7L,2L,3L,0L,5L,6L,1L,5L,6L,8L,9L,9L,8L,7L,9L,2L,1L,1L,9L,5L,3L,4L,5L,2L,2L,2L,1L,9L,0L,4L,7L,8L,1L,6L,4L,1L,4L,7L,1L,3L,7L,7L,0L,5L,6L,6L,2L,1L,2L,8L,2L,9L,1L,4L,8L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011058Inst : IEnumerable<long>
{
public static readonly long[] Value=A011058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011058.Bytes);
public long this[int i]=>Value[i];

public static A011058Inst Instance=new A011058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011057
{
public static readonly long[] Value={ 2L,8L,3L,9L,4L,1L,1L,5L,1L,4L,4L,3L,3L,6L,7L,7L,4L,4L,4L,0L,8L,2L,2L,6L,2L,9L,3L,9L,0L,7L,9L,9L,2L,6L,3L,4L,0L,1L,1L,9L,6L,8L,1L,7L,1L,1L,7L,4L,3L,5L,5L,3L,4L,3L,5L,1L,2L,9L,4L,6L,4L,7L,9L,4L,4L,8L,9L,9L,9L,3L,8L,6L,3L,3L,1L,3L,3L,9L,0L,6L,3L,4L,8L,7L,4L,9L,1L,4L,9L,8L,3L,9L,7L,4L,8L,4L,6L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011057Inst : IEnumerable<long>
{
public static readonly long[] Value=A011057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011057.Bytes);
public long this[int i]=>Value[i];

public static A011057Inst Instance=new A011057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011056
{
public static readonly long[] Value={ 2L,8L,1L,7L,3L,1L,3L,2L,4L,7L,2L,6L,1L,2L,5L,7L,5L,5L,8L,7L,7L,5L,9L,2L,5L,4L,4L,9L,8L,1L,5L,6L,6L,7L,0L,7L,8L,3L,7L,7L,7L,6L,5L,4L,5L,6L,8L,1L,7L,1L,2L,1L,5L,5L,7L,7L,1L,1L,6L,3L,4L,8L,3L,0L,1L,3L,7L,3L,4L,2L,6L,9L,6L,0L,5L,6L,3L,7L,1L,0L,1L,6L,8L,8L,9L,5L,6L,3L,3L,0L,3L,0L,4L,0L,6L,4L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011056Inst : IEnumerable<long>
{
public static readonly long[] Value=A011056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011056.Bytes);
public long this[int i]=>Value[i];

public static A011056Inst Instance=new A011056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011055
{
public static readonly long[] Value={ 2L,8L,0L,6L,0L,6L,6L,2L,6L,3L,2L,9L,6L,6L,8L,3L,2L,7L,3L,7L,6L,1L,4L,8L,8L,7L,6L,8L,4L,9L,9L,9L,3L,5L,7L,0L,0L,5L,0L,6L,0L,5L,4L,0L,3L,8L,5L,4L,6L,0L,4L,8L,6L,5L,2L,6L,1L,0L,2L,2L,9L,3L,5L,4L,7L,3L,3L,2L,1L,8L,2L,1L,7L,4L,1L,1L,4L,6L,2L,8L,5L,6L,1L,1L,5L,6L,9L,2L,9L,7L,8L,3L,2L,2L,2L,9L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011055Inst : IEnumerable<long>
{
public static readonly long[] Value=A011055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011055.Bytes);
public long this[int i]=>Value[i];

public static A011055Inst Instance=new A011055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011054
{
public static readonly long[] Value={ 2L,7L,9L,4L,6L,8L,2L,3L,9L,2L,6L,7L,1L,2L,4L,1L,3L,4L,3L,9L,9L,2L,9L,7L,3L,8L,1L,6L,5L,8L,8L,4L,5L,8L,9L,7L,3L,4L,7L,3L,3L,9L,1L,1L,0L,0L,2L,7L,0L,1L,4L,3L,3L,1L,0L,2L,8L,0L,1L,7L,0L,5L,7L,9L,2L,8L,1L,3L,7L,6L,8L,6L,9L,0L,9L,7L,2L,9L,9L,9L,1L,6L,5L,8L,8L,5L,0L,8L,1L,5L,3L,0L,2L,6L,2L,0L,3L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011054Inst : IEnumerable<long>
{
public static readonly long[] Value=A011054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011054.Bytes);
public long this[int i]=>Value[i];

public static A011054Inst Instance=new A011054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011021
{
public static readonly long[] Value={ 2L,2L,5L,8L,1L,0L,0L,8L,6L,4L,3L,5L,3L,2L,2L,5L,6L,5L,9L,5L,2L,1L,1L,7L,1L,8L,0L,1L,4L,9L,1L,0L,1L,9L,4L,9L,1L,1L,0L,8L,1L,6L,7L,3L,0L,4L,3L,3L,9L,9L,4L,1L,9L,4L,4L,3L,7L,6L,8L,7L,3L,8L,3L,0L,7L,1L,3L,2L,0L,5L,8L,0L,2L,2L,2L,1L,2L,2L,3L,5L,0L,4L,1L,4L,0L,9L,6L,5L,0L,6L,6L,6L,7L,7L,2L,1L,4L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011021Inst : IEnumerable<long>
{
public static readonly long[] Value=A011021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011021.Bytes);
public long this[int i]=>Value[i];

public static A011021Inst Instance=new A011021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011020
{
public static readonly long[] Value={ 2L,2L,1L,3L,3L,6L,3L,8L,3L,9L,4L,0L,0L,6L,4L,3L,1L,8L,4L,8L,1L,7L,5L,8L,0L,5L,4L,6L,8L,8L,0L,6L,6L,3L,2L,9L,7L,1L,0L,7L,8L,3L,6L,3L,6L,5L,0L,5L,9L,8L,1L,8L,9L,5L,1L,0L,3L,3L,6L,4L,0L,4L,0L,9L,3L,5L,0L,0L,7L,6L,9L,7L,0L,6L,9L,4L,1L,5L,9L,6L,6L,3L,4L,8L,8L,0L,0L,2L,1L,5L,8L,9L,2L,9L,3L,9L,0L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011020Inst : IEnumerable<long>
{
public static readonly long[] Value=A011020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011020.Bytes);
public long this[int i]=>Value[i];

public static A011020Inst Instance=new A011020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011019
{
public static readonly long[] Value={ 2L,1L,8L,9L,9L,3L,8L,7L,0L,3L,0L,9L,4L,8L,4L,2L,2L,2L,8L,2L,3L,6L,6L,6L,0L,1L,5L,0L,9L,1L,7L,8L,8L,6L,0L,2L,9L,9L,7L,1L,8L,9L,9L,6L,0L,6L,7L,7L,3L,2L,4L,7L,9L,5L,4L,7L,7L,9L,2L,3L,6L,6L,6L,4L,1L,7L,0L,5L,6L,6L,6L,0L,2L,3L,8L,3L,6L,6L,8L,5L,7L,8L,5L,8L,0L,2L,3L,3L,6L,4L,6L,1L,5L,2L,0L,9L,3L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011019Inst : IEnumerable<long>
{
public static readonly long[] Value=A011019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011019.Bytes);
public long this[int i]=>Value[i];

public static A011019Inst Instance=new A011019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011018
{
public static readonly long[] Value={ 2L,1L,6L,5L,7L,3L,6L,7L,7L,0L,6L,6L,7L,9L,9L,3L,6L,1L,1L,7L,3L,5L,0L,5L,2L,7L,8L,9L,5L,0L,0L,7L,3L,5L,5L,4L,5L,2L,4L,8L,0L,6L,9L,8L,5L,2L,4L,6L,0L,9L,4L,8L,0L,5L,2L,1L,3L,3L,6L,9L,8L,3L,7L,8L,6L,0L,0L,5L,6L,6L,3L,0L,8L,4L,6L,4L,4L,0L,2L,3L,0L,6L,6L,9L,3L,0L,7L,2L,1L,7L,6L,3L,3L,7L,0L,3L,5L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011018Inst : IEnumerable<long>
{
public static readonly long[] Value=A011018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011018.Bytes);
public long this[int i]=>Value[i];

public static A011018Inst Instance=new A011018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011017
{
public static readonly long[] Value={ 2L,1L,4L,0L,6L,9L,5L,1L,4L,2L,9L,2L,8L,0L,7L,2L,3L,2L,6L,5L,4L,6L,7L,9L,6L,3L,0L,0L,0L,6L,5L,1L,3L,6L,7L,8L,1L,7L,6L,6L,5L,1L,3L,5L,5L,5L,6L,8L,8L,4L,0L,8L,1L,4L,2L,0L,9L,6L,5L,7L,8L,4L,1L,6L,0L,0L,3L,5L,2L,8L,9L,2L,9L,4L,8L,2L,4L,9L,2L,7L,2L,2L,0L,1L,1L,8L,2L,8L,8L,4L,8L,8L,2L,1L,7L,8L,6L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011017Inst : IEnumerable<long>
{
public static readonly long[] Value=A011017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011017.Bytes);
public long this[int i]=>Value[i];

public static A011017Inst Instance=new A011017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011016
{
public static readonly long[] Value={ 2L,1L,1L,4L,7L,4L,2L,5L,2L,6L,8L,8L,1L,1L,2L,8L,2L,3L,9L,0L,7L,0L,0L,7L,4L,0L,0L,0L,0L,5L,7L,2L,1L,1L,4L,5L,3L,9L,6L,2L,1L,5L,7L,9L,2L,0L,4L,9L,0L,6L,0L,5L,8L,1L,8L,4L,2L,3L,1L,7L,7L,1L,0L,8L,4L,3L,0L,3L,9L,1L,6L,5L,9L,6L,8L,5L,0L,2L,2L,1L,7L,8L,3L,6L,2L,3L,7L,1L,7L,8L,4L,7L,1L,4L,2L,3L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011016Inst : IEnumerable<long>
{
public static readonly long[] Value=A011016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011016.Bytes);
public long this[int i]=>Value[i];

public static A011016Inst Instance=new A011016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011015
{
public static readonly long[] Value={ 2L,0L,8L,7L,7L,9L,7L,6L,2L,9L,9L,2L,9L,8L,4L,3L,9L,3L,1L,3L,3L,7L,3L,6L,3L,4L,0L,8L,6L,1L,0L,0L,1L,4L,3L,4L,3L,0L,0L,1L,2L,9L,6L,6L,7L,6L,5L,4L,6L,3L,4L,1L,0L,1L,4L,5L,2L,8L,5L,8L,2L,7L,8L,5L,3L,1L,5L,3L,4L,5L,3L,5L,2L,7L,3L,7L,7L,2L,3L,8L,3L,4L,1L,6L,9L,1L,2L,8L,5L,5L,1L,6L,5L,3L,0L,0L,4L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011015Inst : IEnumerable<long>
{
public static readonly long[] Value=A011015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011015.Bytes);
public long this[int i]=>Value[i];

public static A011015Inst Instance=new A011015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011014
{
public static readonly long[] Value={ 2L,0L,5L,9L,7L,6L,7L,1L,4L,3L,9L,0L,7L,1L,1L,7L,7L,5L,5L,8L,3L,0L,2L,7L,7L,2L,5L,5L,2L,0L,1L,0L,1L,0L,7L,8L,0L,1L,0L,2L,6L,9L,2L,7L,4L,4L,1L,5L,5L,4L,0L,4L,0L,7L,8L,5L,9L,7L,2L,0L,1L,4L,4L,6L,6L,2L,3L,2L,5L,5L,0L,5L,0L,0L,2L,3L,7L,4L,9L,8L,5L,6L,3L,7L,6L,9L,2L,1L,0L,5L,1L,3L,7L,1L,3L,7L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011014Inst : IEnumerable<long>
{
public static readonly long[] Value=A011014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011014.Bytes);
public long this[int i]=>Value[i];

public static A011014Inst Instance=new A011014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011013
{
public static readonly long[] Value={ 2L,0L,3L,0L,5L,4L,3L,1L,8L,4L,8L,6L,8L,9L,3L,0L,7L,1L,7L,8L,6L,7L,0L,5L,9L,4L,7L,3L,3L,6L,3L,3L,3L,8L,6L,5L,3L,2L,4L,3L,0L,7L,0L,0L,0L,3L,1L,0L,3L,1L,4L,0L,0L,7L,9L,9L,5L,7L,1L,6L,6L,5L,4L,7L,8L,3L,3L,3L,8L,9L,0L,8L,8L,3L,9L,3L,2L,8L,0L,0L,3L,1L,9L,1L,7L,0L,6L,8L,3L,2L,4L,3L,4L,8L,0L,6L,3L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011013Inst : IEnumerable<long>
{
public static readonly long[] Value=A011013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011013.Bytes);
public long this[int i]=>Value[i];

public static A011013Inst Instance=new A011013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011012
{
public static readonly long[] Value={ 1L,9L,6L,7L,9L,8L,9L,6L,7L,1L,2L,6L,5L,4L,3L,0L,4L,1L,8L,5L,3L,9L,2L,2L,7L,2L,0L,4L,2L,8L,1L,5L,2L,3L,4L,5L,7L,7L,7L,3L,0L,9L,8L,0L,8L,9L,9L,3L,0L,7L,9L,9L,6L,0L,2L,8L,0L,6L,1L,6L,0L,0L,9L,1L,5L,3L,8L,5L,5L,0L,6L,6L,3L,9L,2L,5L,0L,8L,6L,0L,0L,0L,8L,7L,0L,3L,6L,3L,0L,0L,9L,5L,6L,3L,6L,4L,9L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011012Inst : IEnumerable<long>
{
public static readonly long[] Value=A011012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011012.Bytes);
public long this[int i]=>Value[i];

public static A011012Inst Instance=new A011012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011011
{
public static readonly long[] Value={ 1L,9L,3L,4L,3L,3L,6L,4L,2L,0L,2L,6L,7L,6L,6L,9L,3L,0L,8L,9L,1L,7L,8L,6L,1L,8L,3L,5L,3L,7L,2L,9L,7L,6L,0L,0L,8L,0L,4L,2L,5L,3L,0L,8L,4L,3L,4L,7L,0L,8L,0L,2L,6L,3L,9L,3L,8L,2L,1L,0L,8L,6L,2L,1L,8L,5L,6L,0L,4L,4L,7L,3L,0L,8L,5L,3L,3L,8L,7L,7L,4L,2L,2L,0L,1L,5L,0L,9L,4L,2L,5L,4L,0L,3L,1L,7L,5L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011011Inst : IEnumerable<long>
{
public static readonly long[] Value=A011011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011011.Bytes);
public long this[int i]=>Value[i];

public static A011011Inst Instance=new A011011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011010
{
public static readonly long[] Value={ 1L,8L,9L,8L,8L,2L,8L,9L,2L,2L,1L,1L,5L,9L,4L,1L,7L,7L,9L,6L,9L,4L,9L,3L,2L,0L,8L,8L,0L,3L,9L,8L,0L,5L,9L,8L,4L,0L,6L,5L,7L,2L,1L,5L,6L,4L,1L,5L,7L,5L,9L,2L,5L,8L,5L,7L,2L,4L,0L,8L,3L,3L,2L,7L,0L,6L,9L,2L,8L,3L,6L,1L,9L,1L,5L,7L,8L,8L,5L,1L,6L,6L,8L,8L,2L,7L,8L,5L,6L,0L,8L,9L,5L,2L,5L,9L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011010Inst : IEnumerable<long>
{
public static readonly long[] Value=A011010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011010.Bytes);
public long this[int i]=>Value[i];

public static A011010Inst Instance=new A011010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011009
{
public static readonly long[] Value={ 1L,8L,6L,1L,2L,0L,9L,7L,1L,8L,2L,0L,4L,1L,9L,9L,1L,9L,7L,8L,8L,2L,4L,3L,7L,4L,9L,3L,9L,6L,6L,4L,6L,8L,1L,7L,5L,5L,0L,2L,4L,0L,8L,4L,5L,1L,3L,5L,5L,3L,0L,4L,7L,5L,0L,1L,8L,7L,9L,5L,3L,0L,2L,2L,1L,5L,7L,9L,2L,6L,8L,2L,7L,9L,9L,1L,8L,9L,7L,9L,2L,5L,1L,0L,3L,1L,5L,5L,6L,4L,2L,1L,9L,8L,2L,4L,6L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011009Inst : IEnumerable<long>
{
public static readonly long[] Value=A011009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011009.Bytes);
public long this[int i]=>Value[i];

public static A011009Inst Instance=new A011009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011008
{
public static readonly long[] Value={ 1L,8L,2L,1L,1L,6L,0L,2L,8L,6L,8L,3L,7L,8L,7L,1L,8L,9L,8L,4L,4L,6L,6L,4L,3L,2L,1L,2L,8L,3L,8L,0L,2L,2L,7L,2L,8L,2L,1L,7L,1L,1L,8L,1L,2L,9L,6L,8L,2L,9L,1L,7L,0L,1L,4L,6L,4L,8L,0L,2L,7L,2L,7L,1L,1L,6L,4L,2L,9L,3L,5L,4L,9L,3L,6L,4L,0L,4L,6L,8L,2L,5L,4L,3L,7L,8L,2L,2L,1L,6L,1L,8L,8L,7L,1L,3L,5L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011008Inst : IEnumerable<long>
{
public static readonly long[] Value=A011008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011008.Bytes);
public long this[int i]=>Value[i];

public static A011008Inst Instance=new A011008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011007
{
public static readonly long[] Value={ 1L,7L,7L,8L,2L,7L,9L,4L,1L,0L,0L,3L,8L,9L,2L,2L,8L,0L,1L,2L,2L,5L,4L,2L,1L,1L,9L,5L,1L,9L,2L,6L,8L,4L,8L,4L,4L,7L,3L,5L,7L,9L,0L,5L,2L,6L,4L,0L,2L,2L,5L,5L,3L,5L,8L,0L,1L,1L,8L,3L,0L,7L,2L,2L,7L,7L,6L,3L,0L,1L,8L,8L,1L,5L,3L,9L,4L,9L,3L,8L,0L,4L,9L,0L,0L,3L,0L,0L,3L,9L,9L,2L,7L,8L,7L,0L,2L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011007Inst : IEnumerable<long>
{
public static readonly long[] Value=A011007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011007.Bytes);
public long this[int i]=>Value[i];

public static A011007Inst Instance=new A011007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011006
{
public static readonly long[] Value={ 1L,6L,8L,1L,7L,9L,2L,8L,3L,0L,5L,0L,7L,4L,2L,9L,0L,8L,6L,0L,6L,2L,2L,5L,0L,9L,5L,2L,4L,6L,6L,4L,2L,9L,7L,9L,0L,0L,8L,0L,0L,6L,8L,5L,2L,4L,7L,1L,3L,5L,6L,9L,0L,2L,1L,6L,2L,6L,4L,5L,2L,1L,7L,1L,9L,4L,9L,8L,4L,9L,5L,0L,9L,9L,0L,7L,8L,0L,4L,4L,7L,9L,6L,2L,8L,6L,4L,8L,0L,0L,8L,3L,9L,8L,5L,8L,5L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011006Inst : IEnumerable<long>
{
public static readonly long[] Value=A011006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011006.Bytes);
public long this[int i]=>Value[i];

public static A011006Inst Instance=new A011006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010989
{
public static readonly long[] Value={ 1L,37L,703L,9139L,91390L,749398L,5245786L,32224114L,177232627L,886163135L,4076350421L,17417133617L,69668534468L,262596783764L,937845656300L,3188675231420L,10363194502115L,32308782859535L,96926348578605L,280576272201225L,785613562163430L,2132379668729310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010989Inst : IEnumerable<long>
{
public static readonly long[] Value=A010989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010989.Bytes);
public long this[int i]=>Value[i];

public static A010989Inst Instance=new A010989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010988
{
public static readonly long[] Value={ 1L,36L,666L,8436L,82251L,658008L,4496388L,26978328L,145008513L,708930508L,3190187286L,13340783196L,52251400851L,192928249296L,675248872536L,2250829575120L,7174519270695L,21945588357420L,64617565719070L,183649923622620L,505037289962205L,1346766106565880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010988Inst : IEnumerable<long>
{
public static readonly long[] Value=A010988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010988.Bytes);
public long this[int i]=>Value[i];

public static A010988Inst Instance=new A010988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010987
{
public static readonly long[] Value={ 1L,35L,630L,7770L,73815L,575757L,3838380L,22481940L,118030185L,563921995L,2481256778L,10150595910L,38910617655L,140676848445L,482320623240L,1575580702584L,4923689695575L,14771069086725L,42671977361650L,119032357903550L,321387366339585L,841728816603675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010987Inst : IEnumerable<long>
{
public static readonly long[] Value=A010987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010987.Bytes);
public long this[int i]=>Value[i];

public static A010987Inst Instance=new A010987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010986
{
public static readonly long[] Value={ 1L,34L,595L,7140L,66045L,501942L,3262623L,18643560L,95548245L,445891810L,1917334783L,7669339132L,28760021745L,101766230790L,341643774795L,1093260079344L,3348108992991L,9847379391150L,27900908274925L,76360380541900L,202355008436035L,520341450264090L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010986Inst : IEnumerable<long>
{
public static readonly long[] Value=A010986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010986.Bytes);
public long this[int i]=>Value[i];

public static A010986Inst Instance=new A010986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010985
{
public static readonly long[] Value={ 1L,33L,561L,6545L,58905L,435897L,2760681L,15380937L,76904685L,350343565L,1471442973L,5752004349L,21090682613L,73006209045L,239877544005L,751616304549L,2254848913647L,6499270398159L,18053528883775L,48459472266975L,125994627894135L,317986441828055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010985Inst : IEnumerable<long>
{
public static readonly long[] Value=A010985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010985.Bytes);
public long this[int i]=>Value[i];

public static A010985Inst Instance=new A010985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010984
{
public static readonly long[] Value={ 1L,32L,528L,5984L,52360L,376992L,2324784L,12620256L,61523748L,273438880L,1121099408L,4280561376L,15338678264L,51915526432L,166871334960L,511738760544L,1503232609098L,4244421484512L,11554258485616L,30405943383200L,77535155627160L,191991813933920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010984Inst : IEnumerable<long>
{
public static readonly long[] Value=A010984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010984.Bytes);
public long this[int i]=>Value[i];

public static A010984Inst Instance=new A010984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010983
{
public static readonly long[] Value={ 1L,31L,496L,5456L,46376L,324632L,1947792L,10295472L,48903492L,211915132L,847660528L,3159461968L,11058116888L,36576848168L,114955808528L,344867425584L,991493848554L,2741188875414L,7309837001104L,18851684897584L,47129212243960L,114456658306760L,270533919634160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010983Inst : IEnumerable<long>
{
public static readonly long[] Value=A010983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010983.Bytes);
public long this[int i]=>Value[i];

public static A010983Inst Instance=new A010983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010982
{
public static readonly long[] Value={ 1L,30L,465L,4960L,40920L,278256L,1623160L,8347680L,38608020L,163011640L,635745396L,2311801440L,7898654920L,25518731280L,78378960360L,229911617056L,646626422970L,1749695026860L,4568648125690L,11541847896480L,28277527346376L,67327446062800L,156077261327400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010982Inst : IEnumerable<long>
{
public static readonly long[] Value=A010982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010982.Bytes);
public long this[int i]=>Value[i];

public static A010982Inst Instance=new A010982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010981
{
public static readonly long[] Value={ 1L,29L,435L,4495L,35960L,237336L,1344904L,6724520L,30260340L,124403620L,472733756L,1676056044L,5586853480L,17620076360L,52860229080L,151532656696L,416714805914L,1103068603890L,2818953098830L,6973199770790L,16735679449896L,39049918716424L,88749815264600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010981Inst : IEnumerable<long>
{
public static readonly long[] Value=A010981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010981.Bytes);
public long this[int i]=>Value[i];

public static A010981Inst Instance=new A010981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010980
{
public static readonly long[] Value={ 1L,28L,406L,4060L,31465L,201376L,1107568L,5379616L,23535820L,94143280L,348330136L,1203322288L,3910797436L,12033222880L,35240152720L,98672427616L,265182149218L,686353797976L,1715884494940L,4154246671960L,9762479679106L,22314239266528L,49699896548176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010980Inst : IEnumerable<long>
{
public static readonly long[] Value=A010980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010980.Bytes);
public long this[int i]=>Value[i];

public static A010980Inst Instance=new A010980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010979
{
public static readonly long[] Value={ 1L,27L,378L,3654L,27405L,169911L,906192L,4272048L,18156204L,70607460L,254186856L,854992152L,2707475148L,8122425444L,23206929840L,63432274896L,166509721602L,421171648758L,1029530696964L,2438362177020L,5608233007146L,12551759587422L,27385657281648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010979Inst : IEnumerable<long>
{
public static readonly long[] Value=A010979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010979.Bytes);
public long this[int i]=>Value[i];

public static A010979Inst Instance=new A010979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010978
{
public static readonly long[] Value={ 1L,26L,351L,3276L,23751L,142506L,736281L,3365856L,13884156L,52451256L,183579396L,600805296L,1852482996L,5414950296L,15084504396L,40225345056L,103077446706L,254661927156L,608359048206L,1408831480056L,3169870830126L,6943526580276L,14833897694226L,30957699535776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010978Inst : IEnumerable<long>
{
public static readonly long[] Value=A010978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010978.Bytes);
public long this[int i]=>Value[i];

public static A010978Inst Instance=new A010978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010977
{
public static readonly long[] Value={ 1L,25L,325L,2925L,20475L,118755L,593775L,2629575L,10518300L,38567100L,131128140L,417225900L,1251677700L,3562467300L,9669554100L,25140840660L,62852101650L,151584480450L,353697121050L,800472431850L,1761039350070L,3773655750150L,7890371113950L,16123801841550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010977Inst : IEnumerable<long>
{
public static readonly long[] Value=A010977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010977.Bytes);
public long this[int i]=>Value[i];

public static A010977Inst Instance=new A010977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010976
{
public static readonly long[] Value={ 1L,24L,300L,2600L,17550L,98280L,475020L,2035800L,7888725L,28048800L,92561040L,286097760L,834451800L,2310789600L,6107086800L,15471286560L,37711260990L,88732378800L,202112640600L,446775310800L,960566918220L,2012616400080L,4116715363800L,8233430727600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010976Inst : IEnumerable<long>
{
public static readonly long[] Value=A010976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010976.Bytes);
public long this[int i]=>Value[i];

public static A010976Inst Instance=new A010976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010975
{
public static readonly long[] Value={ 1L,23L,276L,2300L,14950L,80730L,376740L,1560780L,5852925L,20160075L,64512240L,193536720L,548354040L,1476337800L,3796297200L,9364199760L,22239974430L,51021117810L,113380261800L,244662670200L,513791607420L,1052049481860L,2104098963720L,4116715363800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010975Inst : IEnumerable<long>
{
public static readonly long[] Value=A010975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010975.Bytes);
public long this[int i]=>Value[i];

public static A010975Inst Instance=new A010975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010974
{
public static readonly long[] Value={ 1L,22L,253L,2024L,12650L,65780L,296010L,1184040L,4292145L,14307150L,44352165L,129024480L,354817320L,927983760L,2319959400L,5567902560L,12875774670L,28781143380L,62359143990L,131282408400L,269128937220L,538257874440L,1052049481860L,2012616400080L,3773655750150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010974Inst : IEnumerable<long>
{
public static readonly long[] Value=A010974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010974.Bytes);
public long this[int i]=>Value[i];

public static A010974Inst Instance=new A010974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010957
{
public static readonly long[] Value={ 1L,41L,820L,10660L,101270L,749398L,4496388L,22481940L,95548245L,350343565L,1121099408L,3159461968L,7898654920L,17620076360L,35240152720L,63432274896L,103077446706L,151584480450L,202112640600L,244662670200L,269128937220L,269128937220L,244662670200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010957Inst : IEnumerable<long>
{
public static readonly long[] Value=A010957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010957.Bytes);
public long this[int i]=>Value[i];

public static A010957Inst Instance=new A010957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010956
{
public static readonly long[] Value={ 1L,40L,780L,9880L,91390L,658008L,3838380L,18643560L,76904685L,273438880L,847660528L,2311801440L,5586853480L,12033222880L,23206929840L,40225345056L,62852101650L,88732378800L,113380261800L,131282408400L,137846528820L,131282408400L,113380261800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010956Inst : IEnumerable<long>
{
public static readonly long[] Value=A010956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010956.Bytes);
public long this[int i]=>Value[i];

public static A010956Inst Instance=new A010956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010955
{
public static readonly long[] Value={ 1L,39L,741L,9139L,82251L,575757L,3262623L,15380937L,61523748L,211915132L,635745396L,1676056044L,3910797436L,8122425444L,15084504396L,25140840660L,37711260990L,51021117810L,62359143990L,68923264410L,68923264410L,62359143990L,51021117810L,37711260990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010955Inst : IEnumerable<long>
{
public static readonly long[] Value=A010955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010955.Bytes);
public long this[int i]=>Value[i];

public static A010955Inst Instance=new A010955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010954
{
public static readonly long[] Value={ 1L,38L,703L,8436L,73815L,501942L,2760681L,12620256L,48903492L,163011640L,472733756L,1203322288L,2707475148L,5414950296L,9669554100L,15471286560L,22239974430L,28781143380L,33578000610L,35345263800L,33578000610L,28781143380L,22239974430L,15471286560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010954Inst : IEnumerable<long>
{
public static readonly long[] Value=A010954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010954.Bytes);
public long this[int i]=>Value[i];

public static A010954Inst Instance=new A010954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010953
{
public static readonly long[] Value={ 1L,37L,666L,7770L,66045L,435897L,2324784L,10295472L,38608020L,124403620L,348330136L,854992152L,1852482996L,3562467300L,6107086800L,9364199760L,12875774670L,15905368710L,17672631900L,17672631900L,15905368710L,12875774670L,9364199760L,6107086800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010953Inst : IEnumerable<long>
{
public static readonly long[] Value=A010953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010953.Bytes);
public long this[int i]=>Value[i];

public static A010953Inst Instance=new A010953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010952
{
public static readonly long[] Value={ 1L,36L,630L,7140L,58905L,376992L,1947792L,8347680L,30260340L,94143280L,254186856L,600805296L,1251677700L,2310789600L,3796297200L,5567902560L,7307872110L,8597496600L,9075135300L,8597496600L,7307872110L,5567902560L,3796297200L,2310789600L,1251677700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010952Inst : IEnumerable<long>
{
public static readonly long[] Value=A010952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010952.Bytes);
public long this[int i]=>Value[i];

public static A010952Inst Instance=new A010952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010951
{
public static readonly long[] Value={ 1L,35L,595L,6545L,52360L,324632L,1623160L,6724520L,23535820L,70607460L,183579396L,417225900L,834451800L,1476337800L,2319959400L,3247943160L,4059928950L,4537567650L,4537567650L,4059928950L,3247943160L,2319959400L,1476337800L,834451800L,417225900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010951Inst : IEnumerable<long>
{
public static readonly long[] Value=A010951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010951.Bytes);
public long this[int i]=>Value[i];

public static A010951Inst Instance=new A010951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010950
{
public static readonly long[] Value={ 1L,34L,561L,5984L,46376L,278256L,1344904L,5379616L,18156204L,52451256L,131128140L,286097760L,548354040L,927983760L,1391975640L,1855967520L,2203961430L,2333606220L,2203961430L,1855967520L,1391975640L,927983760L,548354040L,286097760L,131128140L,52451256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010950Inst : IEnumerable<long>
{
public static readonly long[] Value=A010950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010950.Bytes);
public long this[int i]=>Value[i];

public static A010950Inst Instance=new A010950Inst();

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