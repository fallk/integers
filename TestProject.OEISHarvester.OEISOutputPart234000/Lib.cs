using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

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

public static class A011162
{
public static readonly long[] Value={ 2L,3L,8L,3L,9L,5L,5L,5L,0L,3L,4L,5L,4L,8L,9L,9L,6L,9L,8L,0L,3L,8L,9L,1L,3L,5L,1L,2L,6L,1L,1L,7L,3L,7L,5L,1L,1L,5L,4L,5L,2L,7L,8L,1L,9L,0L,6L,1L,3L,8L,6L,5L,1L,5L,3L,7L,9L,6L,9L,1L,8L,7L,6L,1L,1L,0L,0L,1L,0L,3L,7L,2L,7L,1L,1L,2L,4L,3L,3L,2L,4L,2L,3L,5L,2L,7L,4L,4L,1L,9L,6L,8L,0L,0L,5L,3L,5L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011162Inst : IEnumerable<long>
{
public static readonly long[] Value=A011162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011162.Bytes);
public long this[int i]=>Value[i];

public static A011162Inst Instance=new A011162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011163
{
public static readonly long[] Value={ 2L,3L,9L,0L,1L,1L,5L,6L,7L,7L,3L,5L,2L,1L,8L,7L,0L,4L,6L,1L,4L,2L,5L,7L,1L,9L,6L,7L,7L,8L,2L,7L,1L,9L,2L,6L,8L,8L,7L,7L,4L,8L,8L,3L,0L,0L,9L,6L,9L,1L,1L,5L,4L,7L,9L,7L,2L,0L,2L,5L,2L,0L,0L,5L,3L,9L,2L,7L,3L,8L,5L,6L,2L,4L,8L,5L,9L,2L,4L,8L,8L,6L,7L,6L,6L,7L,2L,7L,0L,1L,7L,0L,0L,5L,1L,1L,5L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011163Inst : IEnumerable<long>
{
public static readonly long[] Value=A011163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011163.Bytes);
public long this[int i]=>Value[i];

public static A011163Inst Instance=new A011163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011164
{
public static readonly long[] Value={ 2L,3L,9L,6L,2L,1L,2L,9L,9L,0L,4L,8L,1L,7L,6L,9L,8L,1L,1L,9L,0L,5L,4L,4L,6L,2L,8L,0L,8L,3L,8L,7L,0L,3L,9L,6L,0L,5L,2L,7L,8L,7L,5L,7L,3L,0L,7L,6L,6L,4L,9L,6L,8L,9L,8L,8L,5L,3L,2L,8L,9L,2L,8L,4L,1L,2L,2L,7L,1L,6L,3L,3L,3L,9L,7L,8L,7L,5L,3L,0L,0L,4L,8L,8L,2L,6L,5L,3L,3L,3L,4L,0L,7L,9L,8L,6L,2L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011164Inst : IEnumerable<long>
{
public static readonly long[] Value=A011164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011164.Bytes);
public long this[int i]=>Value[i];

public static A011164Inst Instance=new A011164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011165
{
public static readonly long[] Value={ 2L,4L,0L,2L,2L,4L,8L,8L,6L,7L,9L,6L,2L,8L,6L,2L,4L,6L,6L,4L,8L,4L,1L,9L,9L,7L,8L,7L,1L,9L,8L,3L,3L,0L,6L,4L,8L,8L,2L,4L,0L,5L,1L,8L,2L,3L,3L,0L,4L,6L,4L,6L,4L,5L,1L,9L,3L,6L,0L,7L,1L,7L,1L,6L,8L,3L,1L,1L,9L,3L,1L,9L,3L,2L,2L,4L,4L,8L,2L,9L,7L,7L,2L,7L,0L,6L,6L,2L,5L,2L,8L,7L,0L,5L,6L,2L,7L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011165Inst : IEnumerable<long>
{
public static readonly long[] Value=A011165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011165.Bytes);
public long this[int i]=>Value[i];

public static A011165Inst Instance=new A011165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011182
{
public static readonly long[] Value={ 2L,4L,9L,6L,6L,3L,0L,9L,3L,1L,7L,3L,2L,0L,8L,7L,0L,3L,7L,4L,2L,3L,6L,1L,7L,8L,6L,8L,1L,5L,5L,0L,8L,9L,7L,8L,6L,3L,5L,8L,2L,8L,1L,8L,2L,0L,1L,8L,5L,2L,8L,7L,1L,2L,5L,4L,4L,8L,1L,2L,5L,6L,9L,6L,1L,6L,5L,7L,3L,0L,4L,0L,2L,3L,6L,4L,7L,5L,7L,9L,0L,2L,1L,9L,6L,9L,0L,3L,7L,8L,4L,3L,3L,9L,0L,5L,6L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011182Inst : IEnumerable<long>
{
public static readonly long[] Value=A011182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011182.Bytes);
public long this[int i]=>Value[i];

public static A011182Inst Instance=new A011182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011183
{
public static readonly long[] Value={ 2L,5L,0L,1L,7L,5L,7L,5L,2L,7L,1L,4L,0L,8L,4L,3L,5L,1L,3L,0L,8L,7L,2L,4L,4L,8L,5L,4L,9L,2L,6L,2L,9L,8L,3L,7L,2L,0L,6L,0L,4L,5L,7L,4L,7L,0L,6L,8L,0L,9L,7L,7L,9L,7L,9L,9L,3L,2L,6L,1L,3L,5L,7L,8L,6L,5L,1L,7L,1L,6L,3L,9L,7L,0L,0L,6L,1L,1L,8L,9L,9L,7L,4L,2L,2L,8L,0L,0L,7L,9L,8L,8L,3L,3L,3L,9L,8L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011183Inst : IEnumerable<long>
{
public static readonly long[] Value=A011183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011183.Bytes);
public long this[int i]=>Value[i];

public static A011183Inst Instance=new A011183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011184
{
public static readonly long[] Value={ 2L,5L,0L,6L,8L,4L,2L,4L,4L,2L,1L,3L,4L,1L,0L,0L,2L,2L,3L,9L,3L,2L,2L,6L,1L,6L,5L,2L,3L,6L,8L,4L,9L,2L,9L,2L,1L,0L,4L,2L,9L,2L,0L,4L,6L,5L,9L,6L,3L,1L,4L,4L,0L,0L,2L,5L,6L,9L,5L,4L,3L,0L,9L,1L,0L,2L,8L,8L,4L,3L,8L,0L,7L,2L,5L,1L,0L,1L,1L,4L,1L,6L,3L,1L,7L,6L,5L,7L,8L,3L,3L,0L,0L,1L,3L,2L,9L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011184Inst : IEnumerable<long>
{
public static readonly long[] Value=A011184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011184.Bytes);
public long this[int i]=>Value[i];

public static A011184Inst Instance=new A011184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011185
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,13L,21L,30L,39L,53L,74L,95L,128L,152L,182L,212L,258L,316L,374L,413L,476L,531L,546L,608L,717L,798L,862L,965L,1060L,1161L,1307L,1386L,1435L,1556L,1722L,1834L,1934L,2058L,2261L,2497L,2699L,2874L,3061L,3197L,3332L,3629L,3712L,3868L,4140L,4447L,4640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011185Inst : IEnumerable<long>
{
public static readonly long[] Value=A011185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011185.Bytes);
public long this[int i]=>Value[i];

public static A011185Inst Instance=new A011185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011186
{
public static readonly long[] Value={ 1L,2L,1L,9L,0L,1L,3L,6L,5L,4L,2L,0L,4L,4L,7L,5L,4L,4L,0L,9L,1L,1L,6L,9L,1L,0L,0L,2L,5L,9L,2L,5L,6L,0L,8L,5L,7L,2L,7L,7L,4L,1L,1L,9L,3L,5L,8L,5L,9L,9L,6L,0L,8L,0L,6L,5L,9L,0L,9L,7L,1L,5L,1L,4L,8L,3L,2L,0L,6L,7L,2L,9L,5L,4L,5L,9L,6L,6L,7L,9L,9L,3L,8L,1L,7L,2L,5L,8L,1L,4L,0L,3L,1L,3L,7L,0L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011186Inst : IEnumerable<long>
{
public static readonly long[] Value=A011186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011186.Bytes);
public long this[int i]=>Value[i];

public static A011186Inst Instance=new A011186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011187
{
public static readonly long[] Value={ 3L,79L,457645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011187Inst : IEnumerable<long>
{
public static readonly long[] Value=A011187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011187.Bytes);
public long this[int i]=>Value[i];

public static A011187Inst Instance=new A011187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011188
{
public static readonly long[] Value={ 1L,1L,6L,6L,5L,2L,9L,0L,3L,9L,5L,7L,6L,1L,1L,6L,5L,8L,0L,8L,9L,3L,6L,9L,2L,6L,3L,4L,6L,6L,0L,6L,6L,8L,0L,6L,1L,4L,1L,7L,9L,0L,9L,1L,5L,3L,8L,9L,8L,8L,9L,8L,3L,5L,4L,9L,0L,9L,2L,6L,5L,7L,6L,1L,7L,7L,2L,3L,5L,4L,2L,2L,0L,4L,9L,0L,1L,7L,8L,1L,3L,9L,9L,4L,5L,0L,6L,2L,5L,4L,0L,8L,2L,7L,9L,4L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011188Inst : IEnumerable<long>
{
public static readonly long[] Value=A011188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011188.Bytes);
public long this[int i]=>Value[i];

public static A011188Inst Instance=new A011188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011189
{
public static readonly long[] Value={ 5L,5L,4L,7L,35L,12L,38L,70L,10L,82L,92L,118L,94L,121L,133L,184L,98L,306L,7L,420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011189Inst : IEnumerable<long>
{
public static readonly long[] Value=A011189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011189.Bytes);
public long this[int i]=>Value[i];

public static A011189Inst Instance=new A011189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011190
{
public static readonly long[] Value={ 1L,1L,3L,4L,3L,1L,2L,5L,2L,2L,1L,9L,5L,4L,6L,2L,5L,8L,0L,9L,9L,2L,4L,9L,7L,7L,3L,2L,9L,1L,7L,1L,1L,9L,1L,3L,8L,9L,3L,8L,3L,0L,1L,9L,2L,0L,7L,9L,6L,6L,9L,5L,9L,6L,2L,0L,1L,6L,1L,9L,2L,6L,6L,4L,3L,1L,8L,2L,8L,7L,1L,0L,5L,7L,7L,8L,0L,4L,9L,0L,0L,9L,0L,4L,8L,0L,3L,7L,0L,4L,8L,4L,1L,6L,3L,0L,1L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011190Inst : IEnumerable<long>
{
public static readonly long[] Value=A011190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011190.Bytes);
public long this[int i]=>Value[i];

public static A011190Inst Instance=new A011190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011191
{
public static readonly long[] Value={ 6L,3L,7L,4L,18L,1L,21L,35L,76L,82L,56L,25L,98L,149L,111L,170L,166L,195L,113L,306L,221L,367L,533L,373L,360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011191Inst : IEnumerable<long>
{
public static readonly long[] Value=A011191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011191.Bytes);
public long this[int i]=>Value[i];

public static A011191Inst Instance=new A011191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011192
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,3L,1L,4L,7L,6L,0L,9L,6L,4L,8L,6L,9L,2L,0L,2L,6L,2L,0L,8L,8L,9L,7L,7L,1L,4L,9L,3L,9L,1L,3L,5L,3L,8L,4L,5L,0L,5L,3L,1L,7L,8L,1L,8L,0L,4L,8L,2L,0L,9L,7L,2L,1L,1L,8L,0L,4L,8L,4L,4L,0L,9L,0L,5L,5L,6L,2L,5L,2L,1L,0L,0L,5L,8L,2L,4L,1L,6L,2L,0L,0L,5L,8L,7L,7L,6L,8L,8L,8L,0L,4L,7L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011192Inst : IEnumerable<long>
{
public static readonly long[] Value=A011192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011192.Bytes);
public long this[int i]=>Value[i];

public static A011192Inst Instance=new A011192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011193
{
public static readonly long[] Value={ 2L,9L,16L,25L,2L,38L,16L,31L,93L,115L,112L,128L,117L,173L,254L,96L,15L,88L,235L,308L,13L,501L,151L,171L,301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011193Inst : IEnumerable<long>
{
public static readonly long[] Value=A011193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011193.Bytes);
public long this[int i]=>Value[i];

public static A011193Inst Instance=new A011193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011194
{
public static readonly long[] Value={ 1L,0L,9L,6L,8L,2L,4L,9L,7L,9L,6L,9L,4L,6L,2L,5L,9L,6L,0L,6L,8L,1L,4L,7L,1L,7L,7L,8L,0L,2L,8L,8L,0L,3L,3L,8L,7L,8L,2L,7L,8L,4L,7L,3L,2L,1L,5L,2L,7L,1L,4L,2L,3L,5L,0L,0L,4L,2L,0L,2L,6L,5L,9L,0L,5L,1L,1L,5L,2L,5L,7L,1L,8L,7L,2L,8L,1L,1L,2L,0L,9L,9L,3L,2L,1L,9L,0L,9L,2L,2L,7L,1L,0L,3L,9L,4L,7L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011194Inst : IEnumerable<long>
{
public static readonly long[] Value=A011194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011194.Bytes);
public long this[int i]=>Value[i];

public static A011194Inst Instance=new A011194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011195
{
public static readonly long[] Value={ 0L,4L,35L,140L,390L,880L,1729L,3080L,5100L,7980L,11935L,17204L,24050L,32760L,43645L,57040L,73304L,92820L,115995L,143260L,175070L,211904L,254265L,302680L,357700L,419900L,489879L,568260L,655690L,752840L,860405L,979104L,1109680L,1252900L,1409555L,1580460L,1766454L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011195Inst : IEnumerable<long>
{
public static readonly long[] Value=A011195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011195.Bytes);
public long this[int i]=>Value[i];

public static A011195Inst Instance=new A011195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011196
{
public static readonly long[] Value={ 1L,0L,8L,4L,9L,6L,3L,9L,1L,3L,6L,4L,3L,6L,3L,7L,1L,2L,9L,6L,6L,7L,0L,7L,7L,5L,2L,3L,8L,7L,5L,4L,5L,4L,8L,4L,7L,6L,1L,1L,6L,8L,6L,3L,6L,9L,4L,7L,7L,6L,5L,0L,7L,7L,5L,2L,3L,8L,0L,6L,9L,2L,6L,4L,4L,3L,2L,3L,3L,2L,8L,8L,3L,7L,8L,7L,6L,0L,4L,3L,1L,9L,5L,6L,3L,5L,9L,3L,5L,9L,0L,3L,9L,9L,2L,5L,3L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011196Inst : IEnumerable<long>
{
public static readonly long[] Value=A011196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011196.Bytes);
public long this[int i]=>Value[i];

public static A011196Inst Instance=new A011196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011197
{
public static readonly long[] Value={ 0L,20L,315L,1820L,6630L,18480L,43225L,89320L,168300L,295260L,489335L,774180L,1178450L,1736280L,2487765L,3479440L,4764760L,6404580L,8467635L,11031020L,14180670L,18011840L,22629585L,28149240L,34696900L,42409900L,51437295L,61940340L,74092970L,88082280L,104109005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011197Inst : IEnumerable<long>
{
public static readonly long[] Value=A011197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011197.Bytes);
public long this[int i]=>Value[i];

public static A011197Inst Instance=new A011197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011230
{
public static readonly long[] Value={ 1L,3L,8L,3L,0L,8L,7L,5L,5L,4L,2L,6L,8L,4L,8L,8L,4L,9L,2L,6L,4L,0L,6L,5L,8L,5L,1L,3L,5L,3L,4L,8L,2L,2L,5L,9L,0L,8L,7L,7L,0L,4L,2L,7L,3L,6L,2L,1L,0L,2L,5L,1L,1L,4L,8L,7L,1L,9L,0L,8L,4L,2L,9L,2L,5L,3L,9L,7L,5L,8L,7L,5L,9L,4L,5L,4L,9L,0L,7L,9L,5L,4L,8L,5L,5L,1L,4L,6L,4L,7L,8L,4L,7L,3L,3L,4L,4L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011230Inst : IEnumerable<long>
{
public static readonly long[] Value=A011230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011230.Bytes);
public long this[int i]=>Value[i];

public static A011230Inst Instance=new A011230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011231
{
public static readonly long[] Value={ 1L,3L,2L,0L,4L,6L,9L,2L,4L,7L,7L,5L,6L,1L,2L,3L,7L,9L,1L,8L,0L,9L,3L,2L,7L,3L,3L,1L,5L,0L,0L,2L,6L,3L,0L,8L,2L,7L,3L,6L,6L,0L,0L,1L,5L,1L,9L,7L,3L,3L,5L,8L,2L,5L,1L,8L,0L,2L,6L,6L,1L,2L,8L,8L,3L,5L,4L,6L,7L,1L,7L,4L,3L,6L,5L,2L,8L,9L,1L,9L,8L,5L,5L,3L,3L,7L,2L,8L,8L,2L,4L,0L,9L,4L,6L,7L,3L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011231Inst : IEnumerable<long>
{
public static readonly long[] Value=A011231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011231.Bytes);
public long this[int i]=>Value[i];

public static A011231Inst Instance=new A011231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011232
{
public static readonly long[] Value={ 1L,2L,7L,5L,3L,7L,3L,1L,0L,6L,8L,5L,8L,4L,5L,4L,0L,8L,5L,3L,8L,6L,0L,0L,9L,7L,5L,0L,4L,5L,8L,7L,9L,2L,2L,7L,3L,4L,5L,3L,7L,0L,4L,7L,5L,5L,3L,9L,6L,7L,7L,0L,4L,2L,7L,5L,5L,2L,3L,6L,1L,3L,2L,2L,9L,6L,9L,5L,0L,6L,9L,6L,1L,9L,3L,9L,9L,3L,9L,9L,4L,8L,3L,6L,1L,6L,7L,6L,0L,1L,4L,9L,0L,8L,0L,5L,7L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011232Inst : IEnumerable<long>
{
public static readonly long[] Value=A011232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011232.Bytes);
public long this[int i]=>Value[i];

public static A011232Inst Instance=new A011232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011233
{
public static readonly long[] Value={ 1L,2L,4L,1L,3L,6L,5L,8L,1L,7L,0L,1L,5L,2L,0L,8L,6L,7L,7L,5L,7L,6L,6L,2L,6L,3L,9L,1L,2L,9L,5L,0L,9L,3L,6L,2L,2L,9L,6L,7L,5L,9L,6L,7L,0L,0L,5L,5L,1L,5L,3L,2L,4L,2L,2L,3L,7L,5L,0L,8L,9L,4L,2L,3L,8L,6L,0L,1L,8L,6L,8L,2L,3L,3L,8L,1L,3L,9L,6L,9L,3L,0L,4L,5L,7L,9L,6L,0L,3L,6L,5L,9L,4L,2L,8L,0L,5L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011233Inst : IEnumerable<long>
{
public static readonly long[] Value=A011233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011233.Bytes);
public long this[int i]=>Value[i];

public static A011233Inst Instance=new A011233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011234
{
public static readonly long[] Value={ 1L,2L,1L,4L,8L,1L,4L,0L,4L,4L,0L,3L,9L,0L,6L,6L,9L,3L,9L,3L,9L,8L,7L,4L,7L,3L,8L,1L,4L,0L,5L,0L,9L,1L,2L,9L,0L,7L,1L,8L,3L,8L,8L,0L,3L,5L,0L,6L,4L,1L,2L,7L,5L,4L,3L,5L,5L,6L,2L,5L,1L,1L,8L,0L,5L,9L,5L,0L,3L,3L,6L,5L,8L,2L,2L,3L,7L,1L,7L,4L,7L,9L,9L,0L,9L,7L,2L,5L,9L,8L,4L,6L,9L,0L,0L,0L,9L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011234Inst : IEnumerable<long>
{
public static readonly long[] Value=A011234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011234.Bytes);
public long this[int i]=>Value[i];

public static A011234Inst Instance=new A011234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011235
{
public static readonly long[] Value={ 1L,1L,9L,3L,5L,1L,2L,8L,3L,7L,1L,6L,9L,6L,2L,0L,2L,5L,0L,8L,1L,7L,6L,2L,7L,5L,5L,4L,0L,3L,5L,8L,5L,8L,6L,9L,2L,3L,7L,4L,8L,0L,9L,3L,2L,4L,8L,4L,6L,6L,1L,4L,5L,5L,8L,1L,6L,2L,2L,4L,5L,1L,8L,6L,6L,9L,4L,7L,8L,4L,0L,6L,3L,0L,7L,1L,0L,1L,6L,2L,4L,9L,1L,6L,1L,8L,0L,8L,9L,5L,3L,1L,1L,7L,3L,4L,6L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011235Inst : IEnumerable<long>
{
public static readonly long[] Value=A011235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011235.Bytes);
public long this[int i]=>Value[i];

public static A011235Inst Instance=new A011235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011236
{
public static readonly long[] Value={ 1L,1L,7L,6L,0L,4L,7L,4L,2L,8L,5L,7L,9L,5L,1L,4L,5L,9L,9L,4L,3L,3L,6L,6L,3L,8L,8L,7L,3L,1L,1L,3L,8L,0L,8L,9L,8L,7L,3L,7L,4L,0L,4L,5L,7L,2L,4L,7L,7L,8L,7L,9L,6L,2L,6L,6L,4L,2L,7L,1L,2L,2L,4L,1L,7L,2L,4L,4L,6L,4L,6L,0L,0L,4L,5L,7L,2L,2L,8L,7L,1L,9L,8L,6L,0L,4L,6L,9L,3L,8L,8L,0L,7L,4L,1L,4L,7L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011236Inst : IEnumerable<long>
{
public static readonly long[] Value=A011236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011236.Bytes);
public long this[int i]=>Value[i];

public static A011236Inst Instance=new A011236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011237
{
public static readonly long[] Value={ 1L,1L,6L,1L,4L,6L,8L,7L,8L,2L,6L,1L,3L,1L,0L,5L,6L,5L,9L,5L,0L,6L,5L,9L,7L,7L,8L,4L,8L,5L,9L,2L,4L,0L,8L,6L,5L,7L,9L,8L,3L,4L,7L,6L,2L,4L,1L,7L,5L,9L,4L,9L,1L,7L,1L,8L,8L,9L,7L,4L,0L,2L,5L,9L,1L,2L,4L,2L,9L,0L,6L,9L,6L,1L,4L,2L,0L,1L,0L,5L,3L,8L,6L,7L,7L,4L,6L,5L,3L,8L,4L,8L,6L,2L,6L,7L,0L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011237Inst : IEnumerable<long>
{
public static readonly long[] Value=A011237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011237.Bytes);
public long this[int i]=>Value[i];

public static A011237Inst Instance=new A011237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011238
{
public static readonly long[] Value={ 1L,1L,4L,9L,1L,1L,6L,7L,2L,5L,0L,3L,5L,4L,1L,7L,7L,1L,0L,4L,1L,9L,3L,1L,0L,5L,0L,0L,1L,0L,9L,9L,5L,0L,5L,1L,3L,1L,5L,3L,9L,5L,3L,2L,9L,6L,4L,7L,3L,1L,7L,8L,4L,0L,4L,0L,8L,3L,7L,2L,2L,9L,1L,0L,9L,9L,5L,8L,4L,3L,5L,7L,4L,0L,3L,0L,1L,0L,8L,7L,6L,3L,0L,3L,1L,3L,3L,9L,5L,7L,9L,2L,1L,5L,4L,8L,6L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011238Inst : IEnumerable<long>
{
public static readonly long[] Value=A011238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011238.Bytes);
public long this[int i]=>Value[i];

public static A011238Inst Instance=new A011238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011239
{
public static readonly long[] Value={ 1L,1L,3L,8L,5L,1L,7L,9L,1L,6L,4L,2L,9L,3L,6L,4L,2L,9L,7L,1L,7L,0L,6L,7L,4L,1L,3L,3L,9L,4L,9L,5L,8L,1L,1L,8L,7L,6L,1L,5L,1L,3L,3L,9L,3L,5L,7L,3L,4L,6L,9L,1L,8L,7L,2L,7L,7L,2L,1L,2L,7L,0L,7L,5L,1L,0L,3L,1L,2L,7L,1L,6L,2L,5L,8L,5L,9L,4L,8L,8L,1L,8L,7L,9L,6L,4L,4L,2L,5L,8L,0L,4L,6L,1L,8L,4L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011239Inst : IEnumerable<long>
{
public static readonly long[] Value=A011239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011239.Bytes);
public long this[int i]=>Value[i];

public static A011239Inst Instance=new A011239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011240
{
public static readonly long[] Value={ 1L,1L,2L,9L,3L,2L,4L,1L,8L,1L,4L,7L,2L,4L,6L,5L,4L,5L,4L,1L,7L,0L,0L,5L,7L,3L,6L,8L,6L,1L,7L,8L,2L,1L,9L,2L,4L,4L,5L,7L,9L,5L,8L,6L,6L,2L,4L,0L,9L,6L,1L,4L,3L,2L,8L,3L,3L,3L,1L,6L,9L,9L,5L,2L,6L,6L,8L,5L,9L,5L,1L,0L,8L,5L,8L,6L,0L,7L,8L,7L,8L,9L,3L,1L,6L,4L,4L,2L,3L,5L,1L,7L,7L,8L,4L,9L,5L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011240Inst : IEnumerable<long>
{
public static readonly long[] Value=A011240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011240.Bytes);
public long this[int i]=>Value[i];

public static A011240Inst Instance=new A011240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011241
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,7L,3L,7L,3L,5L,4L,2L,5L,9L,4L,5L,5L,3L,9L,7L,9L,0L,5L,1L,8L,1L,8L,0L,4L,6L,2L,8L,9L,2L,2L,3L,2L,8L,1L,8L,3L,9L,3L,5L,0L,5L,4L,7L,1L,6L,8L,9L,1L,0L,1L,9L,9L,8L,2L,8L,3L,0L,9L,7L,7L,0L,3L,8L,2L,4L,6L,1L,8L,6L,5L,0L,6L,9L,0L,9L,3L,7L,4L,3L,4L,7L,7L,2L,8L,8L,1L,0L,4L,2L,1L,8L,8L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011241Inst : IEnumerable<long>
{
public static readonly long[] Value=A011241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011241.Bytes);
public long this[int i]=>Value[i];

public static A011241Inst Instance=new A011241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011242
{
public static readonly long[] Value={ 1L,1L,1L,4L,1L,6L,5L,9L,7L,3L,7L,2L,8L,8L,7L,3L,4L,2L,9L,7L,2L,4L,3L,5L,6L,6L,5L,7L,7L,3L,8L,7L,0L,6L,1L,0L,7L,2L,7L,8L,0L,2L,3L,9L,7L,1L,7L,8L,0L,0L,0L,7L,4L,2L,2L,0L,9L,5L,1L,0L,5L,8L,4L,1L,3L,9L,2L,2L,9L,4L,0L,7L,8L,6L,7L,4L,2L,4L,8L,2L,3L,5L,1L,3L,9L,7L,7L,8L,5L,2L,5L,5L,1L,6L,0L,3L,6L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011242Inst : IEnumerable<long>
{
public static readonly long[] Value=A011242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011242.Bytes);
public long this[int i]=>Value[i];

public static A011242Inst Instance=new A011242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011243
{
public static readonly long[] Value={ 1L,1L,0L,7L,8L,4L,4L,5L,9L,7L,6L,2L,1L,8L,0L,1L,1L,3L,5L,8L,9L,7L,1L,7L,0L,5L,4L,5L,5L,9L,7L,7L,9L,1L,4L,2L,5L,8L,9L,8L,2L,1L,1L,0L,6L,0L,2L,8L,1L,7L,4L,3L,8L,4L,2L,5L,8L,8L,5L,4L,6L,4L,6L,3L,1L,9L,4L,3L,3L,4L,5L,0L,7L,5L,9L,8L,0L,8L,8L,5L,1L,6L,1L,7L,5L,4L,5L,0L,3L,8L,2L,2L,9L,2L,8L,7L,6L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011243Inst : IEnumerable<long>
{
public static readonly long[] Value=A011243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011243.Bytes);
public long this[int i]=>Value[i];

public static A011243Inst Instance=new A011243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011244
{
public static readonly long[] Value={ 1L,1L,0L,2L,1L,8L,6L,0L,2L,9L,6L,8L,7L,8L,5L,0L,3L,5L,2L,8L,5L,7L,9L,9L,7L,1L,1L,1L,0L,6L,5L,8L,2L,1L,7L,9L,1L,6L,2L,1L,9L,8L,9L,3L,2L,3L,6L,3L,4L,3L,6L,7L,8L,0L,3L,2L,7L,8L,7L,9L,3L,5L,8L,3L,4L,3L,5L,4L,8L,3L,7L,5L,8L,1L,8L,4L,9L,5L,3L,8L,8L,3L,2L,4L,5L,0L,2L,3L,4L,5L,1L,5L,3L,9L,7L,0L,2L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011244Inst : IEnumerable<long>
{
public static readonly long[] Value=A011244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011244.Bytes);
public long this[int i]=>Value[i];

public static A011244Inst Instance=new A011244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011245
{
public static readonly long[] Value={ 1L,120L,945L,3640L,9945L,22176L,43225L,76560L,126225L,196840L,293601L,422280L,589225L,801360L,1066185L,1391776L,1786785L,2260440L,2822545L,3483480L,4254201L,5146240L,6171705L,7343280L,8674225L,10178376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011245Inst : IEnumerable<long>
{
public static readonly long[] Value=A011245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011245.Bytes);
public long this[int i]=>Value[i];

public static A011245Inst Instance=new A011245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011262
{
public static readonly long[] Value={ 1L,4L,9L,2L,25L,36L,49L,16L,3L,100L,121L,18L,169L,196L,225L,8L,289L,12L,361L,50L,441L,484L,529L,144L,5L,676L,81L,98L,841L,900L,961L,64L,1089L,1156L,1225L,6L,1369L,1444L,1521L,400L,1681L,1764L,1849L,242L,75L,2116L,2209L,72L,7L,20L,2601L,338L,2809L,324L,3025L,784L,3249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011262Inst : IEnumerable<long>
{
public static readonly long[] Value=A011262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011262.Bytes);
public long this[int i]=>Value[i];

public static A011262Inst Instance=new A011262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011263
{
public static readonly long[] Value={ 1L,2L,7L,6L,5L,1L,8L,0L,0L,7L,0L,0L,9L,2L,4L,1L,6L,5L,9L,6L,8L,4L,3L,9L,8L,6L,5L,0L,5L,8L,2L,7L,1L,6L,2L,8L,2L,1L,4L,2L,6L,0L,8L,9L,9L,5L,9L,4L,8L,4L,7L,8L,3L,5L,3L,0L,7L,4L,3L,6L,4L,2L,2L,0L,5L,1L,3L,8L,2L,6L,8L,2L,3L,5L,8L,8L,7L,5L,9L,2L,1L,6L,1L,0L,0L,0L,4L,3L,6L,5L,5L,4L,1L,8L,4L,3L,3L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011263Inst : IEnumerable<long>
{
public static readonly long[] Value=A011263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011263.Bytes);
public long this[int i]=>Value[i];

public static A011263Inst Instance=new A011263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011264
{
public static readonly long[] Value={ 1L,1L,1L,8L,1L,1L,1L,4L,27L,1L,1L,8L,1L,1L,1L,32L,1L,27L,1L,8L,1L,1L,1L,4L,125L,1L,9L,8L,1L,1L,1L,16L,1L,1L,1L,216L,1L,1L,1L,4L,1L,1L,1L,8L,27L,1L,1L,32L,343L,125L,1L,8L,1L,9L,1L,4L,1L,1L,1L,8L,1L,1L,27L,128L,1L,1L,1L,8L,1L,1L,1L,108L,1L,1L,125L,8L,1L,1L,1L,32L,243L,1L,1L,8L,1L,1L,1L,4L,1L,27L,1L,8L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011264Inst : IEnumerable<long>
{
public static readonly long[] Value=A011264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011264.Bytes);
public long this[int i]=>Value[i];

public static A011264Inst Instance=new A011264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011265
{
public static readonly long[] Value={ 1L,2L,2L,1L,0L,9L,4L,6L,2L,3L,4L,9L,8L,6L,5L,5L,3L,8L,8L,2L,3L,0L,7L,7L,0L,4L,3L,7L,1L,4L,0L,1L,1L,5L,4L,2L,8L,6L,5L,6L,4L,1L,9L,3L,6L,6L,9L,4L,8L,3L,2L,7L,4L,5L,4L,2L,4L,7L,2L,7L,4L,7L,7L,9L,5L,7L,3L,1L,7L,6L,1L,3L,3L,1L,2L,4L,6L,6L,1L,9L,0L,7L,7L,9L,5L,4L,6L,9L,3L,5L,6L,3L,5L,8L,4L,9L,3L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011265Inst : IEnumerable<long>
{
public static readonly long[] Value=A011265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011265.Bytes);
public long this[int i]=>Value[i];

public static A011265Inst Instance=new A011265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011266
{
public static readonly BigInteger[] Value={ 1L,1L,4L,48L,1536L,122880L,23592960L,10569646080L,10823317585920L,24936923717959680L,BigInteger.Parse("127677049435953561600"),BigInteger.Parse("1438154284846580917862400"),BigInteger.Parse("35344079704389572637386342400"),BigInteger.Parse("1882001556099335963795547960115200") };
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
public class A011266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011266Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A011266.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A011266.Bytes);
public BigInteger this[int i]=>Value[i];

public static A011266Inst Instance=new A011266Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011267
{
public static readonly long[] Value={ 1L,1L,8L,4L,1L,4L,0L,5L,9L,4L,9L,8L,8L,8L,5L,7L,1L,4L,2L,4L,3L,7L,5L,7L,8L,7L,0L,7L,4L,4L,0L,5L,8L,4L,1L,4L,4L,7L,2L,8L,8L,3L,4L,8L,7L,6L,3L,3L,8L,9L,4L,1L,3L,0L,4L,5L,1L,8L,9L,7L,0L,3L,0L,6L,4L,4L,8L,7L,8L,5L,6L,7L,9L,9L,8L,7L,0L,2L,9L,4L,3L,0L,2L,7L,0L,1L,9L,4L,1L,1L,8L,5L,3L,7L,4L,2L,8L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011267Inst : IEnumerable<long>
{
public static readonly long[] Value=A011267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011267.Bytes);
public long this[int i]=>Value[i];

public static A011267Inst Instance=new A011267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011268
{
public static readonly long[] Value={ 1L,1L,2L,1L,10L,3L,1L,30L,44L,4L,1L,70L,284L,134L,5L,1L,140L,1224L,1594L,329L,6L,1L,252L,4110L,11330L,6552L,700L,7L,1L,420L,11616L,58432L,71484L,21822L,1344L,8L,1L,660L,28908L,241098L,534562L,347274L,62370L,2388L,9L,1L,990L,65208L,842842L,3069360L,3612924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011268Inst : IEnumerable<long>
{
public static readonly long[] Value=A011268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011268.Bytes);
public long this[int i]=>Value[i];

public static A011268Inst Instance=new A011268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011269
{
public static readonly long[] Value={ 1L,1L,5L,7L,7L,5L,3L,6L,7L,2L,5L,1L,6L,5L,9L,0L,6L,2L,9L,2L,7L,5L,6L,2L,2L,9L,9L,1L,1L,9L,6L,6L,7L,6L,1L,2L,5L,1L,5L,7L,1L,2L,1L,9L,0L,0L,7L,8L,2L,6L,6L,5L,3L,5L,2L,9L,8L,5L,3L,5L,1L,1L,6L,0L,5L,5L,4L,8L,5L,8L,6L,9L,4L,1L,2L,8L,4L,6L,3L,4L,5L,0L,2L,9L,7L,8L,7L,3L,4L,3L,9L,0L,0L,4L,3L,3L,0L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011269Inst : IEnumerable<long>
{
public static readonly long[] Value=A011269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011269.Bytes);
public long this[int i]=>Value[i];

public static A011269Inst Instance=new A011269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011270
{
public static readonly long[] Value={ 1L,1L,4L,18L,90L,481L,2690L,15547L,92124L,556664L,3417062L,21248966L,133576724L,847465593L,5419399722L,34895368578L,226050057378L,1472170887755L,9633297762870L,63305402213336L,417612181048826L,2764492667188504L,18358282050480384L,122265756020847943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011270Inst : IEnumerable<long>
{
public static readonly long[] Value=A011270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011270.Bytes);
public long this[int i]=>Value[i];

public static A011270Inst Instance=new A011270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011271
{
public static readonly long[] Value={ 1L,1L,3L,7L,9L,7L,2L,8L,8L,0L,4L,6L,8L,8L,1L,3L,2L,8L,2L,7L,3L,8L,6L,5L,7L,3L,4L,0L,9L,3L,0L,6L,4L,1L,1L,4L,7L,0L,6L,4L,4L,9L,5L,5L,4L,1L,0L,5L,9L,8L,1L,8L,2L,8L,9L,6L,4L,3L,8L,6L,1L,4L,4L,8L,9L,0L,6L,8L,1L,5L,9L,5L,4L,2L,5L,9L,4L,8L,8L,2L,3L,8L,7L,1L,2L,4L,3L,4L,8L,0L,9L,4L,5L,3L,6L,6L,3L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011271Inst : IEnumerable<long>
{
public static readonly long[] Value=A011271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011271.Bytes);
public long this[int i]=>Value[i];

public static A011271Inst Instance=new A011271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011272
{
public static readonly long[] Value={ 0L,1L,3L,13L,64L,339L,1885L,10851L,64109L,386510L,2368354L,14706331L,92337618L,585239903L,3739309053L,24059542845L,155756019048L,1013801283133L,6630587014935L,43553555324502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011272Inst : IEnumerable<long>
{
public static readonly long[] Value=A011272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011272.Bytes);
public long this[int i]=>Value[i];

public static A011272Inst Instance=new A011272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011273
{
public static readonly long[] Value={ 1L,1L,2L,2L,5L,9L,5L,4L,8L,1L,8L,5L,9L,7L,7L,5L,7L,3L,5L,7L,5L,2L,2L,3L,5L,0L,9L,6L,4L,3L,7L,9L,8L,1L,2L,5L,9L,5L,7L,3L,9L,6L,8L,5L,4L,5L,4L,1L,0L,7L,3L,8L,0L,6L,4L,4L,7L,3L,2L,5L,2L,8L,0L,0L,3L,5L,6L,7L,8L,5L,7L,3L,9L,3L,4L,5L,3L,1L,6L,1L,9L,3L,1L,7L,6L,0L,5L,1L,2L,2L,3L,8L,4L,1L,9L,2L,3L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011273Inst : IEnumerable<long>
{
public static readonly long[] Value=A011273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011273.Bytes);
public long this[int i]=>Value[i];

public static A011273Inst Instance=new A011273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011274
{
public static readonly long[] Value={ 1L,2L,1L,7L,4L,1L,31L,18L,6L,1L,154L,90L,33L,8L,1L,820L,481L,185L,52L,10L,1L,4575L,2690L,1065L,324L,75L,12L,1L,26398L,15547L,6276L,2006L,515L,102L,14L,1L,156233L,92124L,37711L,12468L,3420L,766L,133L,16L,1L,943174L,556664L,230277L,78030L,22412L,5439L,1085L,168L,18L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011274Inst : IEnumerable<long>
{
public static readonly long[] Value=A011274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011274.Bytes);
public long this[int i]=>Value[i];

public static A011274Inst Instance=new A011274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011275
{
public static readonly long[] Value={ 1L,4L,6L,7L,7L,9L,9L,2L,6L,7L,6L,2L,2L,0L,6L,9L,5L,4L,0L,9L,2L,0L,5L,1L,7L,1L,1L,4L,8L,1L,6L,8L,6L,1L,2L,5L,4L,7L,9L,5L,6L,4L,2L,6L,5L,7L,0L,0L,5L,1L,7L,3L,9L,9L,5L,9L,4L,8L,3L,8L,2L,3L,5L,7L,8L,5L,7L,3L,7L,2L,4L,0L,7L,0L,1L,0L,3L,4L,1L,4L,2L,6L,0L,5L,9L,5L,9L,4L,9L,7L,6L,8L,9L,3L,2L,8L,8L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011275Inst : IEnumerable<long>
{
public static readonly long[] Value=A011275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011275.Bytes);
public long this[int i]=>Value[i];

public static A011275Inst Instance=new A011275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011276
{
public static readonly long[] Value={ 1L,3L,8L,9L,4L,9L,5L,4L,9L,4L,3L,7L,3L,1L,3L,7L,6L,3L,7L,1L,2L,9L,9L,8L,5L,2L,1L,7L,3L,5L,3L,0L,1L,1L,6L,2L,2L,1L,1L,3L,0L,4L,6L,7L,1L,4L,4L,9L,1L,0L,0L,0L,2L,0L,4L,9L,4L,5L,6L,2L,8L,6L,7L,9L,0L,3L,1L,6L,0L,0L,2L,4L,2L,4L,1L,0L,3L,1L,6L,5L,8L,1L,3L,8L,4L,1L,7L,5L,6L,3L,8L,9L,7L,5L,4L,2L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011276Inst : IEnumerable<long>
{
public static readonly long[] Value=A011276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011276.Bytes);
public long this[int i]=>Value[i];

public static A011276Inst Instance=new A011276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011277
{
public static readonly long[] Value={ 1L,3L,3L,3L,5L,2L,1L,4L,3L,2L,1L,6L,3L,3L,2L,4L,0L,2L,5L,6L,7L,5L,9L,3L,1L,7L,1L,5L,2L,9L,5L,3L,3L,1L,0L,9L,2L,4L,1L,5L,6L,6L,7L,9L,6L,4L,7L,6L,4L,3L,7L,0L,9L,9L,3L,3L,2L,9L,5L,4L,9L,9L,8L,7L,1L,6L,2L,7L,5L,8L,9L,4L,3L,1L,8L,0L,1L,9L,5L,8L,1L,8L,6L,4L,9L,0L,1L,3L,4L,9L,8L,0L,0L,4L,7L,3L,2L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011277Inst : IEnumerable<long>
{
public static readonly long[] Value=A011277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011277.Bytes);
public long this[int i]=>Value[i];

public static A011277Inst Instance=new A011277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011278
{
public static readonly long[] Value={ 1L,2L,9L,1L,5L,4L,9L,6L,6L,5L,0L,1L,4L,8L,8L,3L,8L,7L,5L,4L,1L,0L,0L,7L,5L,5L,4L,6L,4L,7L,2L,0L,8L,7L,5L,4L,2L,9L,7L,5L,9L,5L,5L,2L,6L,3L,1L,6L,0L,7L,8L,2L,5L,1L,0L,3L,0L,5L,4L,9L,8L,7L,2L,3L,6L,3L,5L,4L,5L,2L,2L,6L,7L,5L,4L,4L,4L,6L,6L,3L,4L,0L,6L,5L,5L,7L,0L,2L,0L,0L,1L,6L,7L,9L,4L,6L,2L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011278Inst : IEnumerable<long>
{
public static readonly long[] Value=A011278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011278.Bytes);
public long this[int i]=>Value[i];

public static A011278Inst Instance=new A011278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011279
{
public static readonly long[] Value={ 1L,2L,5L,8L,9L,2L,5L,4L,1L,1L,7L,9L,4L,1L,6L,7L,2L,1L,0L,4L,2L,3L,9L,5L,4L,1L,0L,6L,3L,9L,5L,8L,0L,0L,6L,0L,6L,0L,9L,3L,6L,1L,7L,4L,0L,9L,4L,6L,6L,9L,3L,1L,0L,6L,9L,1L,0L,7L,9L,2L,3L,0L,1L,9L,5L,2L,6L,6L,4L,7L,6L,1L,5L,7L,8L,2L,5L,0L,2L,0L,2L,4L,1L,2L,1L,0L,5L,0L,9L,6L,6L,2L,7L,5L,9L,4L,6L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011279Inst : IEnumerable<long>
{
public static readonly long[] Value=A011279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011279.Bytes);
public long this[int i]=>Value[i];

public static A011279Inst Instance=new A011279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011280
{
public static readonly long[] Value={ 1L,2L,3L,2L,8L,4L,6L,7L,3L,9L,4L,4L,2L,0L,6L,6L,1L,3L,9L,0L,5L,3L,4L,0L,0L,7L,8L,9L,7L,3L,0L,9L,4L,8L,0L,2L,2L,7L,6L,9L,9L,7L,5L,3L,4L,8L,3L,2L,0L,1L,5L,8L,9L,3L,0L,5L,3L,0L,9L,2L,0L,2L,1L,9L,7L,1L,3L,2L,3L,9L,8L,9L,7L,2L,4L,7L,4L,4L,2L,3L,7L,1L,7L,7L,6L,2L,8L,0L,1L,6L,4L,9L,9L,8L,2L,5L,6L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011280Inst : IEnumerable<long>
{
public static readonly long[] Value=A011280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011280.Bytes);
public long this[int i]=>Value[i];

public static A011280Inst Instance=new A011280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011281
{
public static readonly long[] Value={ 1L,2L,1L,1L,5L,2L,7L,6L,5L,8L,6L,2L,8L,5L,8L,8L,4L,4L,6L,3L,5L,8L,6L,0L,2L,9L,3L,3L,3L,2L,2L,9L,3L,8L,2L,2L,7L,7L,5L,0L,3L,2L,0L,1L,1L,6L,8L,1L,3L,3L,0L,6L,2L,6L,2L,5L,8L,2L,0L,3L,4L,4L,1L,5L,3L,9L,6L,5L,3L,5L,8L,2L,6L,0L,4L,0L,3L,3L,7L,8L,5L,6L,3L,1L,8L,2L,8L,4L,4L,5L,0L,5L,8L,4L,9L,2L,3L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011281Inst : IEnumerable<long>
{
public static readonly long[] Value=A011281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011281.Bytes);
public long this[int i]=>Value[i];

public static A011281Inst Instance=new A011281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011282
{
public static readonly long[] Value={ 1L,1L,9L,3L,7L,7L,6L,6L,4L,1L,7L,1L,4L,4L,3L,6L,5L,0L,6L,0L,9L,1L,6L,8L,1L,5L,7L,4L,0L,5L,7L,7L,2L,5L,6L,4L,9L,2L,3L,4L,4L,4L,0L,5L,9L,6L,0L,6L,9L,7L,7L,8L,9L,3L,5L,8L,5L,6L,6L,1L,6L,9L,5L,1L,0L,6L,2L,1L,7L,9L,8L,4L,5L,9L,6L,7L,1L,5L,1L,0L,9L,5L,0L,0L,8L,8L,9L,8L,0L,9L,8L,7L,1L,8L,4L,7L,9L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011282Inst : IEnumerable<long>
{
public static readonly long[] Value=A011282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011282.Bytes);
public long this[int i]=>Value[i];

public static A011282Inst Instance=new A011282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011283
{
public static readonly long[] Value={ 1L,1L,7L,8L,7L,6L,8L,6L,3L,4L,7L,9L,3L,5L,8L,7L,3L,1L,9L,2L,3L,1L,3L,8L,5L,4L,7L,9L,8L,8L,7L,2L,0L,6L,8L,9L,6L,8L,6L,2L,9L,6L,5L,5L,5L,5L,8L,1L,2L,7L,0L,5L,1L,7L,8L,3L,6L,8L,1L,5L,4L,5L,1L,7L,3L,0L,4L,8L,5L,1L,4L,9L,6L,7L,1L,6L,2L,8L,1L,4L,0L,7L,6L,5L,7L,9L,6L,5L,8L,9L,5L,8L,4L,5L,8L,5L,6L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011283Inst : IEnumerable<long>
{
public static readonly long[] Value=A011283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011283.Bytes);
public long this[int i]=>Value[i];

public static A011283Inst Instance=new A011283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011284
{
public static readonly long[] Value={ 1L,1L,6L,5L,9L,1L,4L,4L,0L,1L,1L,7L,9L,8L,3L,1L,7L,3L,6L,1L,4L,9L,1L,5L,2L,3L,9L,6L,8L,9L,5L,7L,6L,9L,8L,7L,6L,8L,0L,5L,1L,3L,2L,0L,5L,8L,7L,8L,2L,9L,3L,6L,5L,7L,6L,0L,0L,7L,6L,4L,3L,6L,3L,7L,8L,9L,9L,7L,2L,8L,7L,9L,4L,9L,6L,8L,8L,2L,1L,5L,0L,1L,6L,1L,2L,0L,8L,7L,1L,5L,9L,6L,9L,6L,0L,4L,5L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011284Inst : IEnumerable<long>
{
public static readonly long[] Value=A011284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011284.Bytes);
public long this[int i]=>Value[i];

public static A011284Inst Instance=new A011284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011285
{
public static readonly long[] Value={ 1L,1L,5L,4L,7L,8L,1L,9L,8L,4L,6L,8L,9L,4L,5L,8L,1L,7L,9L,6L,6L,6L,4L,8L,2L,8L,8L,7L,2L,9L,5L,5L,0L,8L,2L,8L,1L,5L,6L,6L,9L,4L,8L,0L,4L,1L,4L,7L,9L,6L,1L,1L,1L,2L,9L,9L,7L,7L,4L,2L,6L,8L,4L,8L,7L,1L,7L,9L,2L,9L,2L,0L,6L,9L,8L,0L,0L,4L,8L,1L,4L,0L,6L,0L,8L,5L,1L,3L,8L,1L,8L,0L,0L,8L,2L,7L,1L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011285Inst : IEnumerable<long>
{
public static readonly long[] Value=A011285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011285.Bytes);
public long this[int i]=>Value[i];

public static A011285Inst Instance=new A011285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011286
{
public static readonly long[] Value={ 1L,1L,4L,5L,0L,4L,7L,5L,6L,9L,9L,3L,8L,2L,8L,1L,7L,6L,2L,2L,5L,2L,1L,6L,6L,3L,7L,8L,7L,2L,5L,5L,4L,5L,1L,9L,9L,3L,3L,5L,6L,1L,6L,8L,8L,2L,8L,7L,8L,1L,0L,0L,0L,8L,4L,0L,5L,1L,9L,8L,9L,2L,5L,7L,2L,5L,2L,8L,7L,8L,7L,2L,2L,5L,3L,8L,6L,8L,4L,7L,5L,4L,7L,0L,2L,1L,2L,7L,0L,8L,4L,6L,0L,4L,9L,5L,0L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011286Inst : IEnumerable<long>
{
public static readonly long[] Value=A011286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011286.Bytes);
public long this[int i]=>Value[i];

public static A011286Inst Instance=new A011286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011287
{
public static readonly long[] Value={ 1L,1L,3L,6L,4L,6L,3L,6L,6L,6L,3L,8L,5L,7L,2L,4L,7L,4L,6L,6L,3L,7L,5L,6L,2L,9L,6L,7L,3L,2L,4L,7L,6L,2L,4L,0L,8L,7L,7L,4L,0L,8L,2L,2L,5L,3L,2L,3L,2L,0L,9L,0L,7L,2L,7L,6L,4L,2L,2L,2L,2L,2L,7L,3L,8L,2L,6L,6L,6L,3L,2L,9L,3L,9L,1L,1L,9L,5L,4L,8L,0L,6L,7L,5L,7L,3L,0L,5L,8L,7L,5L,2L,4L,4L,2L,9L,9L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011287Inst : IEnumerable<long>
{
public static readonly long[] Value=A011287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011287.Bytes);
public long this[int i]=>Value[i];

public static A011287Inst Instance=new A011287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011288
{
public static readonly long[] Value={ 1L,1L,2L,8L,8L,3L,7L,8L,9L,1L,6L,8L,4L,6L,8L,9L,0L,5L,6L,3L,2L,4L,1L,5L,6L,0L,8L,6L,0L,5L,1L,5L,1L,4L,3L,5L,4L,9L,3L,7L,5L,0L,7L,8L,4L,8L,8L,2L,7L,8L,2L,7L,8L,1L,2L,0L,7L,3L,1L,3L,6L,0L,5L,4L,6L,1L,2L,6L,2L,3L,4L,2L,6L,1L,4L,3L,1L,5L,1L,2L,2L,1L,1L,3L,8L,5L,1L,2L,8L,2L,1L,7L,9L,3L,0L,9L,8L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011288Inst : IEnumerable<long>
{
public static readonly long[] Value=A011288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011288.Bytes);
public long this[int i]=>Value[i];

public static A011288Inst Instance=new A011288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011289
{
public static readonly long[] Value={ 1L,1L,2L,2L,0L,1L,8L,4L,5L,4L,3L,0L,1L,9L,6L,3L,4L,3L,5L,5L,9L,1L,0L,3L,8L,9L,4L,6L,4L,7L,7L,9L,0L,5L,7L,3L,6L,7L,2L,2L,3L,0L,8L,5L,0L,7L,3L,6L,0L,5L,5L,2L,9L,6L,2L,4L,4L,5L,0L,7L,4L,4L,4L,8L,1L,7L,0L,1L,0L,3L,3L,0L,2L,6L,8L,6L,2L,2L,4L,3L,5L,5L,9L,4L,2L,3L,2L,2L,4L,1L,0L,6L,9L,3L,1L,9L,0L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011289Inst : IEnumerable<long>
{
public static readonly long[] Value=A011289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011289.Bytes);
public long this[int i]=>Value[i];

public static A011289Inst Instance=new A011289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011290
{
public static readonly long[] Value={ 1L,4L,9L,1L,3L,0L,1L,4L,7L,5L,4L,1L,3L,1L,0L,8L,9L,2L,4L,2L,0L,1L,4L,9L,4L,6L,6L,8L,7L,6L,4L,8L,2L,5L,3L,4L,4L,5L,4L,2L,6L,7L,6L,1L,2L,5L,3L,2L,6L,1L,5L,7L,7L,9L,8L,1L,5L,1L,8L,4L,8L,3L,1L,4L,7L,4L,1L,2L,8L,9L,3L,6L,0L,0L,1L,5L,4L,6L,4L,6L,6L,1L,7L,7L,9L,2L,7L,5L,9L,6L,9L,5L,4L,4L,8L,6L,3L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011290Inst : IEnumerable<long>
{
public static readonly long[] Value=A011290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011290.Bytes);
public long this[int i]=>Value[i];

public static A011290Inst Instance=new A011290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011291
{
public static readonly long[] Value={ 1L,4L,0L,8L,5L,4L,3L,8L,8L,8L,4L,2L,8L,6L,9L,9L,4L,1L,1L,4L,0L,6L,5L,8L,4L,6L,2L,8L,7L,5L,6L,8L,3L,1L,1L,6L,0L,4L,9L,8L,8L,5L,3L,4L,1L,2L,3L,4L,7L,8L,2L,0L,2L,4L,4L,6L,8L,9L,2L,2L,6L,3L,0L,2L,7L,1L,6L,8L,8L,8L,4L,2L,9L,0L,3L,2L,3L,3L,4L,4L,0L,6L,1L,1L,3L,5L,0L,7L,8L,0L,2L,7L,5L,1L,3L,8L,6L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011291Inst : IEnumerable<long>
{
public static readonly long[] Value=A011291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011291.Bytes);
public long this[int i]=>Value[i];

public static A011291Inst Instance=new A011291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011292
{
public static readonly long[] Value={ 1L,3L,4L,9L,5L,0L,3L,7L,1L,8L,7L,1L,9L,5L,4L,1L,6L,9L,0L,7L,8L,0L,6L,1L,8L,8L,6L,7L,5L,0L,0L,8L,1L,2L,2L,4L,6L,4L,7L,3L,8L,9L,6L,4L,4L,0L,5L,6L,6L,7L,6L,0L,4L,0L,1L,1L,3L,4L,3L,9L,5L,4L,3L,7L,8L,8L,2L,8L,5L,6L,7L,4L,2L,9L,7L,1L,6L,2L,0L,0L,7L,5L,8L,0L,0L,5L,1L,0L,9L,6L,7L,1L,3L,8L,2L,8L,1L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011292Inst : IEnumerable<long>
{
public static readonly long[] Value=A011292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011292.Bytes);
public long this[int i]=>Value[i];

public static A011292Inst Instance=new A011292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011293
{
public static readonly long[] Value={ 1L,3L,0L,5L,2L,9L,9L,8L,8L,0L,7L,9L,4L,9L,1L,9L,7L,8L,4L,0L,3L,3L,2L,9L,4L,8L,4L,1L,0L,5L,9L,1L,2L,9L,6L,6L,6L,3L,6L,8L,6L,2L,5L,4L,9L,6L,0L,8L,0L,0L,6L,1L,5L,9L,7L,0L,1L,7L,6L,1L,8L,5L,2L,0L,6L,2L,8L,8L,0L,7L,0L,6L,1L,3L,9L,9L,1L,5L,9L,9L,3L,5L,9L,6L,7L,2L,2L,9L,6L,9L,2L,2L,4L,9L,8L,9L,5L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011293Inst : IEnumerable<long>
{
public static readonly long[] Value=A011293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011293.Bytes);
public long this[int i]=>Value[i];

public static A011293Inst Instance=new A011293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011326
{
public static readonly long[] Value={ 1L,2L,3L,8L,3L,0L,7L,8L,1L,1L,9L,0L,1L,5L,4L,3L,1L,1L,2L,2L,5L,4L,1L,1L,9L,2L,3L,9L,3L,5L,0L,9L,5L,4L,3L,2L,2L,4L,5L,4L,5L,3L,2L,6L,9L,0L,8L,3L,7L,9L,0L,2L,3L,8L,0L,7L,7L,5L,1L,6L,3L,2L,1L,7L,2L,0L,5L,8L,7L,1L,0L,8L,6L,7L,6L,8L,9L,1L,5L,5L,9L,4L,4L,8L,4L,2L,8L,8L,4L,8L,2L,9L,8L,6L,6L,2L,8L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011326Inst : IEnumerable<long>
{
public static readonly long[] Value=A011326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011326.Bytes);
public long this[int i]=>Value[i];

public static A011326Inst Instance=new A011326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011327
{
public static readonly long[] Value={ 1L,2L,1L,8L,1L,1L,4L,0L,4L,3L,5L,6L,0L,7L,6L,8L,1L,9L,6L,6L,5L,9L,0L,2L,5L,7L,3L,3L,3L,7L,3L,6L,6L,7L,1L,5L,9L,3L,2L,8L,0L,7L,9L,8L,5L,3L,1L,9L,9L,7L,2L,0L,9L,7L,5L,8L,7L,2L,6L,5L,9L,8L,7L,9L,2L,1L,0L,6L,1L,4L,2L,4L,5L,3L,2L,0L,7L,6L,9L,4L,6L,9L,9L,2L,2L,3L,3L,5L,3L,0L,3L,8L,4L,7L,2L,8L,6L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011327Inst : IEnumerable<long>
{
public static readonly long[] Value=A011327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011327.Bytes);
public long this[int i]=>Value[i];

public static A011327Inst Instance=new A011327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011328
{
public static readonly long[] Value={ 1L,2L,0L,1L,0L,6L,7L,4L,0L,8L,3L,6L,7L,6L,4L,7L,6L,6L,9L,4L,2L,3L,8L,4L,4L,6L,7L,6L,0L,4L,7L,1L,7L,7L,0L,1L,4L,6L,5L,9L,7L,1L,6L,1L,2L,6L,6L,0L,6L,4L,0L,4L,3L,9L,4L,4L,9L,2L,8L,0L,2L,6L,5L,3L,4L,5L,5L,9L,1L,5L,5L,1L,4L,0L,3L,8L,2L,5L,8L,6L,7L,7L,5L,9L,7L,2L,8L,2L,3L,5L,3L,9L,8L,2L,2L,8L,5L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011328Inst : IEnumerable<long>
{
public static readonly long[] Value=A011328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011328.Bytes);
public long this[int i]=>Value[i];

public static A011328Inst Instance=new A011328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011329
{
public static readonly long[] Value={ 1L,1L,8L,6L,4L,8L,6L,7L,4L,3L,2L,3L,4L,9L,1L,4L,2L,8L,0L,8L,0L,5L,1L,1L,5L,9L,3L,8L,0L,5L,0L,6L,9L,6L,0L,4L,9L,2L,4L,2L,6L,4L,5L,8L,7L,8L,9L,8L,9L,8L,6L,4L,9L,6L,8L,5L,9L,2L,6L,4L,2L,0L,4L,2L,7L,5L,7L,1L,7L,9L,6L,6L,6L,4L,7L,4L,1L,5L,1L,0L,4L,1L,9L,5L,1L,9L,9L,5L,8L,2L,8L,6L,6L,4L,8L,4L,7L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011329Inst : IEnumerable<long>
{
public static readonly long[] Value=A011329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011329.Bytes);
public long this[int i]=>Value[i];

public static A011329Inst Instance=new A011329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011330
{
public static readonly long[] Value={ 1L,1L,7L,3L,8L,7L,3L,9L,3L,4L,9L,4L,2L,1L,7L,6L,0L,1L,6L,0L,6L,1L,5L,7L,9L,1L,7L,0L,7L,8L,6L,0L,1L,7L,4L,6L,7L,3L,2L,4L,8L,6L,9L,9L,4L,1L,4L,3L,9L,2L,5L,3L,1L,6L,3L,2L,5L,6L,6L,8L,8L,8L,3L,3L,7L,4L,1L,3L,8L,9L,4L,8L,4L,3L,8L,7L,4L,6L,7L,5L,1L,6L,6L,9L,3L,8L,3L,4L,0L,6L,4L,8L,4L,5L,4L,5L,7L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011330Inst : IEnumerable<long>
{
public static readonly long[] Value=A011330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011330.Bytes);
public long this[int i]=>Value[i];

public static A011330Inst Instance=new A011330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011331
{
public static readonly long[] Value={ 1L,1L,6L,2L,8L,5L,6L,3L,7L,8L,8L,7L,0L,9L,3L,7L,6L,9L,9L,4L,6L,9L,9L,3L,8L,0L,6L,1L,5L,6L,4L,7L,9L,0L,6L,0L,0L,6L,0L,5L,6L,7L,1L,8L,6L,8L,2L,8L,9L,8L,1L,1L,6L,1L,0L,9L,3L,6L,5L,5L,8L,1L,8L,8L,7L,0L,2L,1L,6L,4L,6L,6L,3L,4L,5L,2L,9L,6L,6L,7L,3L,1L,4L,0L,3L,0L,6L,8L,3L,5L,0L,6L,2L,9L,0L,6L,0L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011331Inst : IEnumerable<long>
{
public static readonly long[] Value=A011331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011331.Bytes);
public long this[int i]=>Value[i];

public static A011331Inst Instance=new A011331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011332
{
public static readonly long[] Value={ 1L,1L,5L,3L,1L,4L,9L,8L,3L,6L,5L,9L,5L,3L,0L,8L,1L,8L,7L,0L,5L,8L,0L,4L,4L,2L,2L,3L,4L,7L,8L,7L,2L,4L,8L,4L,4L,3L,6L,3L,5L,1L,8L,3L,1L,0L,4L,8L,8L,5L,4L,5L,8L,0L,9L,2L,5L,4L,9L,2L,4L,6L,0L,1L,8L,1L,8L,1L,0L,8L,8L,1L,2L,7L,9L,2L,8L,5L,0L,9L,3L,6L,3L,5L,9L,7L,1L,4L,1L,6L,4L,8L,4L,6L,9L,0L,3L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011332Inst : IEnumerable<long>
{
public static readonly long[] Value=A011332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011332.Bytes);
public long this[int i]=>Value[i];

public static A011332Inst Instance=new A011332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011333
{
public static readonly long[] Value={ 1L,1L,4L,4L,5L,3L,3L,7L,3L,3L,7L,1L,0L,7L,4L,1L,9L,6L,1L,0L,2L,7L,5L,3L,0L,4L,2L,2L,0L,4L,5L,2L,9L,9L,5L,2L,6L,5L,8L,6L,1L,3L,1L,2L,7L,0L,7L,2L,4L,5L,8L,4L,0L,1L,3L,6L,1L,0L,5L,2L,5L,3L,2L,0L,6L,2L,6L,6L,3L,1L,9L,7L,7L,0L,5L,3L,9L,7L,0L,2L,6L,5L,9L,4L,8L,4L,6L,7L,1L,3L,3L,5L,8L,6L,1L,9L,5L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011333Inst : IEnumerable<long>
{
public static readonly long[] Value=A011333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011333.Bytes);
public long this[int i]=>Value[i];

public static A011333Inst Instance=new A011333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011334
{
public static readonly long[] Value={ 1L,1L,3L,6L,8L,3L,4L,2L,9L,7L,8L,5L,5L,5L,9L,8L,5L,8L,4L,9L,9L,7L,1L,5L,2L,0L,7L,8L,4L,4L,7L,3L,4L,7L,4L,9L,8L,9L,3L,0L,3L,2L,8L,1L,9L,8L,8L,5L,0L,7L,1L,1L,4L,1L,7L,5L,6L,3L,1L,2L,4L,4L,0L,2L,6L,5L,4L,3L,7L,9L,7L,5L,8L,1L,5L,4L,9L,0L,8L,2L,4L,0L,6L,5L,1L,1L,1L,9L,8L,7L,6L,7L,3L,6L,7L,2L,7L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011334Inst : IEnumerable<long>
{
public static readonly long[] Value=A011334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011334.Bytes);
public long this[int i]=>Value[i];

public static A011334Inst Instance=new A011334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011335
{
public static readonly long[] Value={ 1L,5L,5L,2L,4L,6L,3L,2L,8L,9L,1L,5L,5L,4L,0L,8L,6L,5L,5L,5L,6L,1L,5L,2L,2L,2L,0L,7L,8L,7L,8L,7L,0L,5L,2L,8L,7L,6L,5L,8L,8L,6L,7L,8L,2L,7L,9L,0L,3L,5L,8L,9L,8L,8L,1L,1L,5L,8L,1L,8L,9L,9L,2L,8L,0L,4L,4L,5L,3L,6L,7L,8L,9L,4L,8L,6L,9L,3L,6L,5L,8L,1L,3L,7L,8L,8L,2L,2L,4L,6L,0L,5L,6L,5L,5L,2L,0L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011335Inst : IEnumerable<long>
{
public static readonly long[] Value=A011335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011335.Bytes);
public long this[int i]=>Value[i];

public static A011335Inst Instance=new A011335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011336
{
public static readonly long[] Value={ 1L,4L,5L,7L,9L,1L,6L,2L,4L,9L,5L,7L,6L,2L,8L,3L,5L,3L,0L,6L,9L,1L,3L,1L,1L,2L,7L,1L,1L,2L,2L,6L,0L,6L,9L,3L,4L,3L,0L,6L,9L,2L,6L,7L,6L,4L,4L,7L,1L,3L,5L,4L,2L,5L,2L,2L,1L,1L,1L,9L,4L,6L,6L,4L,4L,9L,3L,3L,7L,9L,2L,5L,1L,9L,7L,1L,8L,5L,5L,6L,5L,6L,5L,7L,0L,7L,8L,4L,6L,0L,1L,7L,6L,0L,1L,5L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011336Inst : IEnumerable<long>
{
public static readonly long[] Value=A011336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011336.Bytes);
public long this[int i]=>Value[i];

public static A011336Inst Instance=new A011336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011337
{
public static readonly long[] Value={ 1L,3L,9L,0L,8L,0L,4L,2L,3L,5L,0L,6L,2L,4L,5L,8L,1L,3L,7L,3L,6L,4L,6L,5L,9L,6L,6L,9L,8L,9L,5L,9L,2L,6L,5L,5L,0L,6L,0L,7L,6L,3L,6L,3L,9L,9L,7L,2L,0L,4L,1L,7L,2L,1L,0L,1L,8L,8L,3L,8L,7L,9L,4L,4L,2L,4L,6L,2L,8L,0L,1L,8L,8L,7L,7L,5L,8L,5L,9L,6L,1L,1L,2L,7L,0L,2L,1L,2L,0L,4L,5L,0L,4L,8L,6L,5L,6L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011337Inst : IEnumerable<long>
{
public static readonly long[] Value=A011337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011337.Bytes);
public long this[int i]=>Value[i];

public static A011337Inst Instance=new A011337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011338
{
public static readonly long[] Value={ 1L,3L,4L,0L,7L,4L,9L,2L,4L,0L,1L,9L,5L,2L,8L,0L,6L,0L,3L,9L,1L,0L,7L,5L,9L,9L,3L,9L,5L,1L,0L,3L,5L,4L,3L,9L,1L,1L,9L,2L,4L,6L,1L,0L,6L,7L,5L,1L,7L,6L,0L,0L,3L,5L,1L,8L,3L,6L,0L,4L,8L,3L,1L,2L,9L,7L,9L,7L,7L,2L,3L,7L,5L,6L,2L,3L,9L,8L,7L,0L,4L,7L,0L,2L,1L,9L,9L,3L,4L,6L,5L,6L,8L,4L,1L,6L,2L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011338Inst : IEnumerable<long>
{
public static readonly long[] Value=A011338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011338.Bytes);
public long this[int i]=>Value[i];

public static A011338Inst Instance=new A011338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011339
{
public static readonly long[] Value={ 1L,3L,0L,2L,0L,0L,5L,4L,5L,4L,3L,1L,7L,4L,6L,7L,7L,0L,4L,4L,9L,7L,2L,4L,9L,3L,0L,3L,0L,7L,7L,4L,2L,5L,6L,3L,0L,3L,2L,3L,0L,2L,8L,8L,9L,1L,5L,1L,1L,1L,9L,3L,5L,3L,9L,7L,6L,2L,7L,1L,8L,4L,8L,2L,7L,3L,7L,5L,7L,3L,7L,7L,5L,7L,0L,9L,8L,5L,0L,9L,9L,1L,4L,8L,8L,6L,7L,8L,7L,3L,5L,8L,9L,4L,7L,9L,1L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011339Inst : IEnumerable<long>
{
public static readonly long[] Value=A011339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011339.Bytes);
public long this[int i]=>Value[i];

public static A011339Inst Instance=new A011339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011340
{
public static readonly long[] Value={ 1L,2L,7L,1L,1L,4L,0L,2L,1L,2L,3L,5L,9L,7L,1L,3L,1L,3L,3L,9L,4L,3L,2L,5L,7L,9L,6L,5L,6L,1L,6L,7L,4L,4L,9L,4L,4L,5L,6L,8L,8L,4L,8L,9L,1L,1L,8L,5L,8L,4L,5L,4L,8L,6L,8L,9L,0L,2L,2L,0L,3L,0L,8L,5L,3L,9L,8L,1L,3L,3L,3L,7L,1L,6L,1L,3L,2L,8L,2L,9L,8L,2L,5L,8L,5L,0L,4L,6L,8L,0L,7L,4L,2L,2L,5L,2L,2L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011340Inst : IEnumerable<long>
{
public static readonly long[] Value=A011340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011340.Bytes);
public long this[int i]=>Value[i];

public static A011340Inst Instance=new A011340Inst();

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