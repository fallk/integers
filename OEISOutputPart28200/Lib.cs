using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A021733
{
public static readonly long[] Value={ 0L,0L,1L,3L,7L,1L,7L,4L,2L,1L,1L,2L,4L,8L,2L,8L,5L,3L,2L,2L,3L,5L,9L,3L,9L,6L,4L,3L,3L,4L,7L,0L,5L,0L,7L,5L,4L,4L,5L,8L,1L,6L,1L,8L,6L,5L,5L,6L,9L,2L,7L,2L,9L,7L,6L,6L,8L,0L,3L,8L,4L,0L,8L,7L,7L,9L,1L,4L,9L,5L,1L,9L,8L,9L,0L,2L,6L,0L,6L,3L,1L,0L,0L,1L,3L,7L,1L,7L,4L,2L,1L,1L,2L,4L,8L,2L,8L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021733Inst : IEnumerable<long>
{
public static readonly long[] Value=A021733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021733.Bytes);
public long this[int i]=>Value[i];

public static A021733Inst Instance=new A021733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021732
{
public static readonly long[] Value={ 0L,0L,1L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021732Inst : IEnumerable<long>
{
public static readonly long[] Value=A021732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021732.Bytes);
public long this[int i]=>Value[i];

public static A021732Inst Instance=new A021732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021731
{
public static readonly long[] Value={ 0L,0L,1L,3L,7L,5L,5L,1L,5L,8L,1L,8L,4L,3L,1L,9L,1L,1L,9L,6L,6L,9L,8L,7L,6L,2L,0L,3L,5L,7L,6L,3L,4L,1L,1L,2L,7L,9L,2L,2L,9L,7L,1L,1L,1L,4L,1L,6L,7L,8L,1L,2L,9L,2L,9L,8L,4L,8L,6L,9L,3L,2L,5L,9L,9L,7L,2L,4L,8L,9L,6L,8L,3L,6L,3L,1L,3L,6L,1L,7L,6L,0L,6L,6L,0L,2L,4L,7L,5L,9L,2L,8L,4L,7L,3L,1L,7L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021731Inst : IEnumerable<long>
{
public static readonly long[] Value=A021731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021731.Bytes);
public long this[int i]=>Value[i];

public static A021731Inst Instance=new A021731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021730
{
public static readonly long[] Value={ 0L,0L,1L,3L,7L,7L,4L,1L,0L,4L,6L,8L,3L,1L,9L,5L,5L,9L,2L,2L,8L,6L,5L,0L,1L,3L,7L,7L,4L,1L,0L,4L,6L,8L,3L,1L,9L,5L,5L,9L,2L,2L,8L,6L,5L,0L,1L,3L,7L,7L,4L,1L,0L,4L,6L,8L,3L,1L,9L,5L,5L,9L,2L,2L,8L,6L,5L,0L,1L,3L,7L,7L,4L,1L,0L,4L,6L,8L,3L,1L,9L,5L,5L,9L,2L,2L,8L,6L,5L,0L,1L,3L,7L,7L,4L,1L,0L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021730Inst : IEnumerable<long>
{
public static readonly long[] Value=A021730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021730.Bytes);
public long this[int i]=>Value[i];

public static A021730Inst Instance=new A021730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021729
{
public static readonly long[] Value={ 0L,0L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021729Inst : IEnumerable<long>
{
public static readonly long[] Value=A021729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021729.Bytes);
public long this[int i]=>Value[i];

public static A021729Inst Instance=new A021729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021728
{
public static readonly long[] Value={ 0L,0L,1L,3L,8L,1L,2L,1L,5L,4L,6L,9L,6L,1L,3L,2L,5L,9L,6L,6L,8L,5L,0L,8L,2L,8L,7L,2L,9L,2L,8L,1L,7L,6L,7L,9L,5L,5L,8L,0L,1L,1L,0L,4L,9L,7L,2L,3L,7L,5L,6L,9L,0L,6L,0L,7L,7L,3L,4L,8L,0L,6L,6L,2L,9L,8L,3L,4L,2L,5L,4L,1L,4L,3L,6L,4L,6L,4L,0L,8L,8L,3L,9L,7L,7L,9L,0L,0L,5L,5L,2L,4L,8L,6L,1L,8L,7L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021728Inst : IEnumerable<long>
{
public static readonly long[] Value=A021728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021728.Bytes);
public long this[int i]=>Value[i];

public static A021728Inst Instance=new A021728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021727
{
public static readonly long[] Value={ 0L,0L,1L,3L,8L,3L,1L,2L,5L,8L,6L,4L,4L,5L,3L,6L,6L,5L,2L,8L,3L,5L,4L,0L,8L,0L,2L,2L,1L,3L,0L,0L,1L,3L,8L,3L,1L,2L,5L,8L,6L,4L,4L,5L,3L,6L,6L,5L,2L,8L,3L,5L,4L,0L,8L,0L,2L,2L,1L,3L,0L,0L,1L,3L,8L,3L,1L,2L,5L,8L,6L,4L,4L,5L,3L,6L,6L,5L,2L,8L,3L,5L,4L,0L,8L,0L,2L,2L,1L,3L,0L,0L,1L,3L,8L,3L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021727Inst : IEnumerable<long>
{
public static readonly long[] Value=A021727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021727.Bytes);
public long this[int i]=>Value[i];

public static A021727Inst Instance=new A021727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021726
{
public static readonly long[] Value={ 0L,0L,1L,3L,8L,5L,0L,4L,1L,5L,5L,1L,2L,4L,6L,5L,3L,7L,3L,9L,6L,1L,2L,1L,8L,8L,3L,6L,5L,6L,5L,0L,9L,6L,9L,5L,2L,9L,0L,8L,5L,8L,7L,2L,5L,7L,6L,1L,7L,7L,2L,8L,5L,3L,1L,8L,5L,5L,9L,5L,5L,6L,7L,8L,6L,7L,0L,3L,6L,0L,1L,1L,0L,8L,0L,3L,3L,2L,4L,0L,9L,9L,7L,2L,2L,9L,9L,1L,6L,8L,9L,7L,5L,0L,6L,9L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021726Inst : IEnumerable<long>
{
public static readonly long[] Value=A021726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021726.Bytes);
public long this[int i]=>Value[i];

public static A021726Inst Instance=new A021726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021725
{
public static readonly long[] Value={ 0L,0L,1L,3L,8L,6L,9L,6L,2L,5L,5L,2L,0L,1L,1L,0L,9L,5L,7L,0L,0L,4L,1L,6L,0L,8L,8L,7L,6L,5L,6L,0L,3L,3L,2L,8L,7L,1L,0L,1L,2L,4L,8L,2L,6L,6L,2L,9L,6L,8L,0L,9L,9L,8L,6L,1L,3L,0L,3L,7L,4L,4L,7L,9L,8L,8L,9L,0L,4L,2L,9L,9L,5L,8L,3L,9L,1L,1L,2L,3L,4L,3L,9L,6L,6L,7L,1L,2L,8L,9L,8L,7L,5L,1L,7L,3L,3L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021725Inst : IEnumerable<long>
{
public static readonly long[] Value=A021725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021725.Bytes);
public long this[int i]=>Value[i];

public static A021725Inst Instance=new A021725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021724
{
public static readonly long[] Value={ 1L,26L,465L,7150L,101621L,1378026L,18123145L,233349350L,2958918141L,37094306626L,461004657425L,5690785933950L,69876732453061L,854393804284826L,10411455807073305L,126524771262956950L,1534170271000826381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021724Inst : IEnumerable<long>
{
public static readonly long[] Value=A021724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021724.Bytes);
public long this[int i]=>Value[i];

public static A021724Inst Instance=new A021724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021723
{
public static readonly long[] Value={ 0L,0L,1L,3L,9L,0L,8L,2L,0L,5L,8L,4L,1L,4L,4L,6L,4L,5L,3L,4L,0L,7L,5L,1L,0L,4L,3L,1L,1L,5L,4L,3L,8L,1L,0L,8L,4L,8L,4L,0L,0L,5L,5L,6L,3L,2L,8L,2L,3L,3L,6L,5L,7L,8L,5L,8L,1L,3L,6L,3L,0L,0L,4L,1L,7L,2L,4L,6L,1L,7L,5L,2L,4L,3L,3L,9L,3L,6L,0L,2L,2L,2L,5L,3L,1L,2L,9L,3L,4L,6L,3L,1L,4L,3L,2L,5L,4L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021723Inst : IEnumerable<long>
{
public static readonly long[] Value=A021723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021723.Bytes);
public long this[int i]=>Value[i];

public static A021723Inst Instance=new A021723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021722
{
public static readonly long[] Value={ 0L,0L,1L,3L,9L,2L,7L,5L,7L,6L,6L,0L,1L,6L,7L,1L,3L,0L,9L,1L,9L,2L,2L,0L,0L,5L,5L,7L,1L,0L,3L,0L,6L,4L,0L,6L,6L,8L,5L,2L,3L,6L,7L,6L,8L,8L,0L,2L,2L,2L,8L,4L,1L,2L,2L,5L,6L,2L,6L,7L,4L,0L,9L,4L,7L,0L,7L,5L,2L,0L,8L,9L,1L,3L,6L,4L,9L,0L,2L,5L,0L,6L,9L,6L,3L,7L,8L,8L,3L,0L,0L,8L,3L,5L,6L,5L,4L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021722Inst : IEnumerable<long>
{
public static readonly long[] Value=A021722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021722.Bytes);
public long this[int i]=>Value[i];

public static A021722Inst Instance=new A021722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021721
{
public static readonly long[] Value={ 0L,0L,1L,3L,9L,4L,7L,0L,0L,1L,3L,9L,4L,7L,0L,0L,1L,3L,9L,4L,7L,0L,0L,1L,3L,9L,4L,7L,0L,0L,1L,3L,9L,4L,7L,0L,0L,1L,3L,9L,4L,7L,0L,0L,1L,3L,9L,4L,7L,0L,0L,1L,3L,9L,4L,7L,0L,0L,1L,3L,9L,4L,7L,0L,0L,1L,3L,9L,4L,7L,0L,0L,1L,3L,9L,4L,7L,0L,0L,1L,3L,9L,4L,7L,0L,0L,1L,3L,9L,4L,7L,0L,0L,1L,3L,9L,4L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021721Inst : IEnumerable<long>
{
public static readonly long[] Value=A021721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021721.Bytes);
public long this[int i]=>Value[i];

public static A021721Inst Instance=new A021721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021720
{
public static readonly long[] Value={ 0L,0L,1L,3L,9L,6L,6L,4L,8L,0L,4L,4L,6L,9L,2L,7L,3L,7L,4L,3L,0L,1L,6L,7L,5L,9L,7L,7L,6L,5L,3L,6L,3L,1L,2L,8L,4L,9L,1L,6L,2L,0L,1L,1L,1L,7L,3L,1L,8L,4L,3L,5L,7L,5L,4L,1L,8L,9L,9L,4L,4L,1L,3L,4L,0L,7L,8L,2L,1L,2L,2L,9L,0L,5L,0L,2L,7L,9L,3L,2L,9L,6L,0L,8L,9L,3L,8L,5L,4L,7L,4L,8L,6L,0L,3L,3L,5L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021720Inst : IEnumerable<long>
{
public static readonly long[] Value=A021720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021720.Bytes);
public long this[int i]=>Value[i];

public static A021720Inst Instance=new A021720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021719
{
public static readonly long[] Value={ 0L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021719Inst : IEnumerable<long>
{
public static readonly long[] Value=A021719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021719.Bytes);
public long this[int i]=>Value[i];

public static A021719Inst Instance=new A021719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021718
{
public static readonly long[] Value={ 0L,0L,1L,4L,0L,0L,5L,6L,0L,2L,2L,4L,0L,8L,9L,6L,3L,5L,8L,5L,4L,3L,4L,1L,7L,3L,6L,6L,9L,4L,6L,7L,7L,8L,7L,1L,1L,4L,8L,4L,5L,9L,3L,8L,3L,7L,5L,3L,5L,0L,1L,4L,0L,0L,5L,6L,0L,2L,2L,4L,0L,8L,9L,6L,3L,5L,8L,5L,4L,3L,4L,1L,7L,3L,6L,6L,9L,4L,6L,7L,7L,8L,7L,1L,1L,4L,8L,4L,5L,9L,3L,8L,3L,7L,5L,3L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021718Inst : IEnumerable<long>
{
public static readonly long[] Value=A021718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021718.Bytes);
public long this[int i]=>Value[i];

public static A021718Inst Instance=new A021718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021717
{
public static readonly long[] Value={ 0L,0L,1L,4L,0L,2L,5L,2L,4L,5L,4L,4L,1L,7L,9L,5L,2L,3L,1L,4L,1L,6L,5L,4L,9L,7L,8L,9L,6L,2L,1L,3L,1L,8L,3L,7L,3L,0L,7L,1L,5L,2L,8L,7L,5L,1L,7L,5L,3L,1L,5L,5L,6L,8L,0L,2L,2L,4L,4L,0L,3L,9L,2L,7L,0L,6L,8L,7L,2L,3L,7L,0L,2L,6L,6L,4L,7L,9L,6L,6L,3L,3L,9L,4L,1L,0L,9L,3L,9L,6L,9L,1L,4L,4L,4L,6L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021717Inst : IEnumerable<long>
{
public static readonly long[] Value=A021717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021717.Bytes);
public long this[int i]=>Value[i];

public static A021717Inst Instance=new A021717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021716
{
public static readonly long[] Value={ 0L,0L,1L,4L,0L,4L,4L,9L,4L,3L,8L,2L,0L,2L,2L,4L,7L,1L,9L,1L,0L,1L,1L,2L,3L,5L,9L,5L,5L,0L,5L,6L,1L,7L,9L,7L,7L,5L,2L,8L,0L,8L,9L,8L,8L,7L,6L,4L,0L,4L,4L,9L,4L,3L,8L,2L,0L,2L,2L,4L,7L,1L,9L,1L,0L,1L,1L,2L,3L,5L,9L,5L,5L,0L,5L,6L,1L,7L,9L,7L,7L,5L,2L,8L,0L,8L,9L,8L,8L,7L,6L,4L,0L,4L,4L,9L,4L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021716Inst : IEnumerable<long>
{
public static readonly long[] Value=A021716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021716.Bytes);
public long this[int i]=>Value[i];

public static A021716Inst Instance=new A021716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021715
{
public static readonly long[] Value={ 0L,0L,1L,4L,0L,6L,4L,6L,9L,7L,6L,0L,9L,0L,0L,1L,4L,0L,6L,4L,6L,9L,7L,6L,0L,9L,0L,0L,1L,4L,0L,6L,4L,6L,9L,7L,6L,0L,9L,0L,0L,1L,4L,0L,6L,4L,6L,9L,7L,6L,0L,9L,0L,0L,1L,4L,0L,6L,4L,6L,9L,7L,6L,0L,9L,0L,0L,1L,4L,0L,6L,4L,6L,9L,7L,6L,0L,9L,0L,0L,1L,4L,0L,6L,4L,6L,9L,7L,6L,0L,9L,0L,0L,1L,4L,0L,6L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021715Inst : IEnumerable<long>
{
public static readonly long[] Value=A021715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021715.Bytes);
public long this[int i]=>Value[i];

public static A021715Inst Instance=new A021715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021714
{
public static readonly long[] Value={ 1L,25L,428L,6278L,84879L,1092243L,13601506L,165488176L,1979095877L,23357343581L,272803757304L,3159571375194L,36342586372795L,415641464948839L,4730786270092622L,53625950549096132L,605758471885400433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021714Inst : IEnumerable<long>
{
public static readonly long[] Value=A021714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021714.Bytes);
public long this[int i]=>Value[i];

public static A021714Inst Instance=new A021714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021713
{
public static readonly long[] Value={ 0L,0L,1L,4L,1L,0L,4L,3L,7L,2L,3L,5L,5L,4L,3L,0L,1L,8L,3L,3L,5L,6L,8L,4L,0L,6L,2L,0L,5L,9L,2L,3L,8L,3L,6L,3L,8L,9L,2L,8L,0L,6L,7L,7L,0L,0L,9L,8L,7L,3L,0L,6L,0L,6L,4L,8L,8L,0L,1L,1L,2L,8L,3L,4L,9L,7L,8L,8L,4L,3L,4L,4L,1L,4L,6L,6L,8L,5L,4L,7L,2L,4L,9L,6L,4L,7L,3L,9L,0L,6L,9L,1L,1L,1L,4L,2L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021713Inst : IEnumerable<long>
{
public static readonly long[] Value=A021713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021713.Bytes);
public long this[int i]=>Value[i];

public static A021713Inst Instance=new A021713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021712
{
public static readonly long[] Value={ 0L,0L,1L,4L,1L,2L,4L,2L,9L,3L,7L,8L,5L,3L,1L,0L,7L,3L,4L,4L,6L,3L,2L,7L,6L,8L,3L,6L,1L,5L,8L,1L,9L,2L,0L,9L,0L,3L,9L,5L,4L,8L,0L,2L,2L,5L,9L,8L,8L,7L,0L,0L,5L,6L,4L,9L,7L,1L,7L,5L,1L,4L,1L,2L,4L,2L,9L,3L,7L,8L,5L,3L,1L,0L,7L,3L,4L,4L,6L,3L,2L,7L,6L,8L,3L,6L,1L,5L,8L,1L,9L,2L,0L,9L,0L,3L,9L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021712Inst : IEnumerable<long>
{
public static readonly long[] Value=A021712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021712.Bytes);
public long this[int i]=>Value[i];

public static A021712Inst Instance=new A021712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021711
{
public static readonly long[] Value={ 0L,0L,1L,4L,1L,4L,4L,2L,7L,1L,5L,7L,0L,0L,1L,4L,1L,4L,4L,2L,7L,1L,5L,7L,0L,0L,1L,4L,1L,4L,4L,2L,7L,1L,5L,7L,0L,0L,1L,4L,1L,4L,4L,2L,7L,1L,5L,7L,0L,0L,1L,4L,1L,4L,4L,2L,7L,1L,5L,7L,0L,0L,1L,4L,1L,4L,4L,2L,7L,1L,5L,7L,0L,0L,1L,4L,1L,4L,4L,2L,7L,1L,5L,7L,0L,0L,1L,4L,1L,4L,4L,2L,7L,1L,5L,7L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021711Inst : IEnumerable<long>
{
public static readonly long[] Value=A021711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021711.Bytes);
public long this[int i]=>Value[i];

public static A021711Inst Instance=new A021711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021710
{
public static readonly long[] Value={ 0L,0L,1L,4L,1L,6L,4L,3L,0L,5L,9L,4L,9L,0L,0L,8L,4L,9L,8L,5L,8L,3L,5L,6L,9L,4L,0L,5L,0L,9L,9L,1L,5L,0L,1L,4L,1L,6L,4L,3L,0L,5L,9L,4L,9L,0L,0L,8L,4L,9L,8L,5L,8L,3L,5L,6L,9L,4L,0L,5L,0L,9L,9L,1L,5L,0L,1L,4L,1L,6L,4L,3L,0L,5L,9L,4L,9L,0L,0L,8L,4L,9L,8L,5L,8L,3L,5L,6L,9L,4L,0L,5L,0L,9L,9L,1L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021710Inst : IEnumerable<long>
{
public static readonly long[] Value=A021710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021710.Bytes);
public long this[int i]=>Value[i];

public static A021710Inst Instance=new A021710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021693
{
public static readonly long[] Value={ 0L,0L,1L,4L,5L,1L,3L,7L,8L,8L,0L,9L,8L,6L,9L,3L,7L,5L,9L,0L,7L,1L,1L,1L,7L,5L,6L,1L,6L,8L,3L,5L,9L,9L,4L,1L,9L,4L,4L,8L,4L,7L,6L,0L,5L,2L,2L,4L,9L,6L,3L,7L,1L,5L,5L,2L,9L,7L,5L,3L,2L,6L,5L,6L,0L,2L,3L,2L,2L,2L,0L,6L,0L,9L,5L,7L,9L,1L,0L,0L,1L,4L,5L,1L,3L,7L,8L,8L,0L,9L,8L,6L,9L,3L,7L,5L,9L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021693Inst : IEnumerable<long>
{
public static readonly long[] Value=A021693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021693.Bytes);
public long this[int i]=>Value[i];

public static A021693Inst Instance=new A021693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021692
{
public static readonly long[] Value={ 0L,0L,1L,4L,5L,3L,4L,8L,8L,3L,7L,2L,0L,9L,3L,0L,2L,3L,2L,5L,5L,8L,1L,3L,9L,5L,3L,4L,8L,8L,3L,7L,2L,0L,9L,3L,0L,2L,3L,2L,5L,5L,8L,1L,3L,9L,5L,3L,4L,8L,8L,3L,7L,2L,0L,9L,3L,0L,2L,3L,2L,5L,5L,8L,1L,3L,9L,5L,3L,4L,8L,8L,3L,7L,2L,0L,9L,3L,0L,2L,3L,2L,5L,5L,8L,1L,3L,9L,5L,3L,4L,8L,8L,3L,7L,2L,0L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021692Inst : IEnumerable<long>
{
public static readonly long[] Value=A021692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021692.Bytes);
public long this[int i]=>Value[i];

public static A021692Inst Instance=new A021692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021691
{
public static readonly long[] Value={ 0L,0L,1L,4L,5L,5L,6L,0L,4L,0L,7L,5L,6L,9L,1L,4L,1L,1L,9L,3L,5L,9L,5L,3L,4L,2L,0L,6L,6L,9L,5L,7L,7L,8L,7L,4L,8L,1L,8L,0L,4L,9L,4L,9L,0L,5L,3L,8L,5L,7L,3L,5L,0L,8L,0L,0L,5L,8L,2L,2L,4L,1L,6L,3L,0L,2L,7L,6L,5L,6L,4L,7L,7L,4L,3L,8L,1L,3L,6L,8L,2L,6L,7L,8L,3L,1L,1L,4L,9L,9L,2L,7L,2L,1L,9L,7L,9L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021691Inst : IEnumerable<long>
{
public static readonly long[] Value=A021691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021691.Bytes);
public long this[int i]=>Value[i];

public static A021691Inst Instance=new A021691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021690
{
public static readonly long[] Value={ 0L,0L,1L,4L,5L,7L,7L,2L,5L,9L,4L,7L,5L,2L,1L,8L,6L,5L,8L,8L,9L,2L,1L,2L,8L,2L,7L,9L,8L,8L,3L,3L,8L,1L,9L,2L,4L,1L,9L,8L,2L,5L,0L,7L,2L,8L,8L,6L,2L,9L,7L,3L,7L,6L,0L,9L,3L,2L,9L,4L,4L,6L,0L,6L,4L,1L,3L,9L,9L,4L,1L,6L,9L,0L,9L,6L,2L,0L,9L,9L,1L,2L,5L,3L,6L,4L,4L,3L,1L,4L,8L,6L,8L,8L,0L,4L,6L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021690Inst : IEnumerable<long>
{
public static readonly long[] Value=A021690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021690.Bytes);
public long this[int i]=>Value[i];

public static A021690Inst Instance=new A021690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021689
{
public static readonly long[] Value={ 0L,0L,1L,4L,5L,9L,8L,5L,4L,0L,1L,4L,5L,9L,8L,5L,4L,0L,1L,4L,5L,9L,8L,5L,4L,0L,1L,4L,5L,9L,8L,5L,4L,0L,1L,4L,5L,9L,8L,5L,4L,0L,1L,4L,5L,9L,8L,5L,4L,0L,1L,4L,5L,9L,8L,5L,4L,0L,1L,4L,5L,9L,8L,5L,4L,0L,1L,4L,5L,9L,8L,5L,4L,0L,1L,4L,5L,9L,8L,5L,4L,0L,1L,4L,5L,9L,8L,5L,4L,0L,1L,4L,5L,9L,8L,5L,4L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021689Inst : IEnumerable<long>
{
public static readonly long[] Value=A021689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021689.Bytes);
public long this[int i]=>Value[i];

public static A021689Inst Instance=new A021689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021688
{
public static readonly long[] Value={ 0L,0L,1L,4L,6L,1L,9L,8L,8L,3L,0L,4L,0L,9L,3L,5L,6L,7L,2L,5L,1L,4L,6L,1L,9L,8L,8L,3L,0L,4L,0L,9L,3L,5L,6L,7L,2L,5L,1L,4L,6L,1L,9L,8L,8L,3L,0L,4L,0L,9L,3L,5L,6L,7L,2L,5L,1L,4L,6L,1L,9L,8L,8L,3L,0L,4L,0L,9L,3L,5L,6L,7L,2L,5L,1L,4L,6L,1L,9L,8L,8L,3L,0L,4L,0L,9L,3L,5L,6L,7L,2L,5L,1L,4L,6L,1L,9L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021688Inst : IEnumerable<long>
{
public static readonly long[] Value=A021688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021688.Bytes);
public long this[int i]=>Value[i];

public static A021688Inst Instance=new A021688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021687
{
public static readonly long[] Value={ 0L,0L,1L,4L,6L,4L,1L,2L,8L,8L,4L,3L,3L,3L,8L,2L,1L,3L,7L,6L,2L,8L,1L,1L,1L,2L,7L,3L,7L,9L,2L,0L,9L,3L,7L,0L,4L,2L,4L,5L,9L,7L,3L,6L,4L,5L,6L,8L,0L,8L,1L,9L,9L,1L,2L,1L,5L,2L,2L,6L,9L,3L,9L,9L,7L,0L,7L,1L,7L,4L,2L,3L,1L,3L,3L,2L,3L,5L,7L,2L,4L,7L,4L,3L,7L,7L,7L,4L,5L,2L,4L,1L,5L,8L,1L,2L,5L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021687Inst : IEnumerable<long>
{
public static readonly long[] Value=A021687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021687.Bytes);
public long this[int i]=>Value[i];

public static A021687Inst Instance=new A021687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021686
{
public static readonly long[] Value={ 0L,0L,1L,4L,6L,6L,2L,7L,5L,6L,5L,9L,8L,2L,4L,0L,4L,6L,9L,2L,0L,8L,2L,1L,1L,1L,4L,3L,6L,9L,5L,0L,1L,4L,6L,6L,2L,7L,5L,6L,5L,9L,8L,2L,4L,0L,4L,6L,9L,2L,0L,8L,2L,1L,1L,1L,4L,3L,6L,9L,5L,0L,1L,4L,6L,6L,2L,7L,5L,6L,5L,9L,8L,2L,4L,0L,4L,6L,9L,2L,0L,8L,2L,1L,1L,1L,4L,3L,6L,9L,5L,0L,1L,4L,6L,6L,2L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021686Inst : IEnumerable<long>
{
public static readonly long[] Value=A021686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021686.Bytes);
public long this[int i]=>Value[i];

public static A021686Inst Instance=new A021686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021685
{
public static readonly long[] Value={ 0L,0L,1L,4L,6L,8L,4L,2L,8L,7L,8L,1L,2L,0L,4L,1L,1L,1L,6L,0L,0L,5L,8L,7L,3L,7L,1L,5L,1L,2L,4L,8L,1L,6L,4L,4L,6L,4L,0L,2L,3L,4L,9L,4L,8L,6L,0L,4L,9L,9L,2L,6L,5L,7L,8L,5L,6L,0L,9L,3L,9L,7L,9L,4L,4L,1L,9L,9L,7L,0L,6L,3L,1L,4L,2L,4L,3L,7L,5L,9L,1L,7L,7L,6L,7L,9L,8L,8L,2L,5L,2L,5L,6L,9L,7L,5L,0L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021685Inst : IEnumerable<long>
{
public static readonly long[] Value=A021685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021685.Bytes);
public long this[int i]=>Value[i];

public static A021685Inst Instance=new A021685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021684
{
public static readonly long[] Value={ 1L,23L,360L,4810L,59111L,690573L,7801990L,86089520L,933531621L,9989073523L,105774639620L,1110701801430L,11583617458531L,120125571974873L,1239860303429250L,12746044308940540L,130587414625807841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021684Inst : IEnumerable<long>
{
public static readonly long[] Value=A021684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021684.Bytes);
public long this[int i]=>Value[i];

public static A021684Inst Instance=new A021684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021683
{
public static readonly long[] Value={ 0L,0L,1L,4L,7L,2L,7L,5L,4L,0L,5L,0L,0L,7L,3L,6L,3L,7L,7L,0L,2L,5L,0L,3L,6L,8L,1L,8L,8L,5L,1L,2L,5L,1L,8L,4L,0L,9L,4L,2L,5L,6L,2L,5L,9L,2L,0L,4L,7L,1L,2L,8L,1L,2L,9L,6L,0L,2L,3L,5L,6L,4L,0L,6L,4L,8L,0L,1L,1L,7L,8L,2L,0L,3L,2L,4L,0L,0L,5L,8L,9L,1L,0L,1L,6L,2L,0L,0L,2L,9L,4L,5L,5L,0L,8L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021683Inst : IEnumerable<long>
{
public static readonly long[] Value=A021683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021683.Bytes);
public long this[int i]=>Value[i];

public static A021683Inst Instance=new A021683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021682
{
public static readonly long[] Value={ 0L,0L,1L,4L,7L,4L,9L,2L,6L,2L,5L,3L,6L,8L,7L,3L,1L,5L,6L,3L,4L,2L,1L,8L,2L,8L,9L,0L,8L,5L,5L,4L,5L,7L,2L,2L,7L,1L,3L,8L,6L,4L,3L,0L,6L,7L,8L,4L,6L,6L,0L,7L,6L,6L,9L,6L,1L,6L,5L,1L,9L,1L,7L,4L,0L,4L,1L,2L,9L,7L,9L,3L,5L,1L,0L,3L,2L,4L,4L,8L,3L,7L,7L,5L,8L,1L,1L,2L,0L,9L,4L,3L,9L,5L,2L,8L,0L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021682Inst : IEnumerable<long>
{
public static readonly long[] Value=A021682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021682.Bytes);
public long this[int i]=>Value[i];

public static A021682Inst Instance=new A021682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021681
{
public static readonly long[] Value={ 0L,0L,1L,4L,7L,7L,1L,0L,4L,8L,7L,4L,4L,4L,6L,0L,8L,5L,6L,7L,2L,0L,8L,2L,7L,1L,7L,8L,7L,2L,9L,6L,8L,9L,8L,0L,7L,9L,7L,6L,3L,6L,6L,3L,2L,2L,0L,0L,8L,8L,6L,2L,6L,2L,9L,2L,4L,6L,6L,7L,6L,5L,1L,4L,0L,3L,2L,4L,9L,6L,3L,0L,7L,2L,3L,7L,8L,1L,3L,8L,8L,4L,7L,8L,5L,8L,1L,9L,7L,9L,3L,2L,0L,5L,3L,1L,7L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021681Inst : IEnumerable<long>
{
public static readonly long[] Value=A021681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021681.Bytes);
public long this[int i]=>Value[i];

public static A021681Inst Instance=new A021681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021680
{
public static readonly long[] Value={ 0L,0L,1L,4L,7L,9L,2L,8L,9L,9L,4L,0L,8L,2L,8L,4L,0L,2L,3L,6L,6L,8L,6L,3L,9L,0L,5L,3L,2L,5L,4L,4L,3L,7L,8L,6L,9L,8L,2L,2L,4L,8L,5L,2L,0L,7L,1L,0L,0L,5L,9L,1L,7L,1L,5L,9L,7L,6L,3L,3L,1L,3L,6L,0L,9L,4L,6L,7L,4L,5L,5L,6L,2L,1L,3L,0L,1L,7L,7L,5L,1L,4L,7L,9L,2L,8L,9L,9L,4L,0L,8L,2L,8L,4L,0L,2L,3L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021680Inst : IEnumerable<long>
{
public static readonly long[] Value=A021680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021680.Bytes);
public long this[int i]=>Value[i];

public static A021680Inst Instance=new A021680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021679
{
public static readonly long[] Value={ 0L,0L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021679Inst : IEnumerable<long>
{
public static readonly long[] Value=A021679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021679.Bytes);
public long this[int i]=>Value[i];

public static A021679Inst Instance=new A021679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021678
{
public static readonly long[] Value={ 0L,0L,1L,4L,8L,3L,6L,7L,9L,5L,2L,5L,2L,2L,2L,5L,5L,1L,9L,2L,8L,7L,8L,3L,3L,8L,2L,7L,8L,9L,3L,1L,7L,5L,0L,7L,4L,1L,8L,3L,9L,7L,6L,2L,6L,1L,1L,2L,7L,5L,9L,6L,4L,3L,9L,1L,6L,9L,1L,3L,9L,4L,6L,5L,8L,7L,5L,3L,7L,0L,9L,1L,9L,8L,8L,1L,3L,0L,5L,6L,3L,7L,9L,8L,2L,1L,9L,5L,8L,4L,5L,6L,9L,7L,3L,2L,9L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021678Inst : IEnumerable<long>
{
public static readonly long[] Value=A021678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021678.Bytes);
public long this[int i]=>Value[i];

public static A021678Inst Instance=new A021678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021661
{
public static readonly long[] Value={ 0L,0L,1L,5L,2L,2L,0L,7L,0L,0L,1L,5L,2L,2L,0L,7L,0L,0L,1L,5L,2L,2L,0L,7L,0L,0L,1L,5L,2L,2L,0L,7L,0L,0L,1L,5L,2L,2L,0L,7L,0L,0L,1L,5L,2L,2L,0L,7L,0L,0L,1L,5L,2L,2L,0L,7L,0L,0L,1L,5L,2L,2L,0L,7L,0L,0L,1L,5L,2L,2L,0L,7L,0L,0L,1L,5L,2L,2L,0L,7L,0L,0L,1L,5L,2L,2L,0L,7L,0L,0L,1L,5L,2L,2L,0L,7L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021661Inst : IEnumerable<long>
{
public static readonly long[] Value=A021661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021661.Bytes);
public long this[int i]=>Value[i];

public static A021661Inst Instance=new A021661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021660
{
public static readonly long[] Value={ 0L,0L,1L,5L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021660Inst : IEnumerable<long>
{
public static readonly long[] Value=A021660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021660.Bytes);
public long this[int i]=>Value[i];

public static A021660Inst Instance=new A021660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021659
{
public static readonly long[] Value={ 0L,0L,1L,5L,2L,6L,7L,1L,7L,5L,5L,7L,2L,5L,1L,9L,0L,8L,3L,9L,6L,9L,4L,6L,5L,6L,4L,8L,8L,5L,4L,9L,6L,1L,8L,3L,2L,0L,6L,1L,0L,6L,8L,7L,0L,2L,2L,9L,0L,0L,7L,6L,3L,3L,5L,8L,7L,7L,8L,6L,2L,5L,9L,5L,4L,1L,9L,8L,4L,7L,3L,2L,8L,2L,4L,4L,2L,7L,4L,8L,0L,9L,1L,6L,0L,3L,0L,5L,3L,4L,3L,5L,1L,1L,4L,5L,0L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021659Inst : IEnumerable<long>
{
public static readonly long[] Value=A021659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021659.Bytes);
public long this[int i]=>Value[i];

public static A021659Inst Instance=new A021659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021658
{
public static readonly long[] Value={ 0L,0L,1L,5L,2L,9L,0L,5L,1L,9L,8L,7L,7L,6L,7L,5L,8L,4L,0L,9L,7L,8L,5L,9L,3L,2L,7L,2L,1L,7L,1L,2L,5L,3L,8L,2L,2L,6L,2L,9L,9L,6L,9L,4L,1L,8L,9L,6L,0L,2L,4L,4L,6L,4L,8L,3L,1L,8L,0L,4L,2L,8L,1L,3L,4L,5L,5L,6L,5L,7L,4L,9L,2L,3L,5L,4L,7L,4L,0L,0L,6L,1L,1L,6L,2L,0L,7L,9L,5L,1L,0L,7L,0L,3L,3L,6L,3L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021658Inst : IEnumerable<long>
{
public static readonly long[] Value=A021658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021658.Bytes);
public long this[int i]=>Value[i];

public static A021658Inst Instance=new A021658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021657
{
public static readonly long[] Value={ 0L,0L,1L,5L,3L,1L,3L,9L,3L,5L,6L,8L,1L,4L,7L,0L,1L,3L,7L,8L,2L,5L,4L,2L,1L,1L,3L,3L,2L,3L,1L,2L,4L,0L,4L,2L,8L,7L,9L,0L,1L,9L,9L,0L,8L,1L,1L,6L,3L,8L,5L,9L,1L,1L,1L,7L,9L,1L,7L,3L,0L,4L,7L,4L,7L,3L,2L,0L,0L,6L,1L,2L,5L,5L,7L,4L,2L,7L,2L,5L,8L,8L,0L,5L,5L,1L,3L,0L,1L,6L,8L,4L,5L,3L,2L,9L,2L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021657Inst : IEnumerable<long>
{
public static readonly long[] Value=A021657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021657.Bytes);
public long this[int i]=>Value[i];

public static A021657Inst Instance=new A021657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021656
{
public static readonly long[] Value={ 0L,0L,1L,5L,3L,3L,7L,4L,2L,3L,3L,1L,2L,8L,8L,3L,4L,3L,5L,5L,8L,2L,8L,2L,2L,0L,8L,5L,8L,8L,9L,5L,7L,0L,5L,5L,2L,1L,4L,7L,2L,3L,9L,2L,6L,3L,8L,0L,3L,6L,8L,0L,9L,8L,1L,5L,9L,5L,0L,9L,2L,0L,2L,4L,5L,3L,9L,8L,7L,7L,3L,0L,0L,6L,1L,3L,4L,9L,6L,9L,3L,2L,5L,1L,5L,3L,3L,7L,4L,2L,3L,3L,1L,2L,8L,8L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021656Inst : IEnumerable<long>
{
public static readonly long[] Value=A021656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021656.Bytes);
public long this[int i]=>Value[i];

public static A021656Inst Instance=new A021656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021655
{
public static readonly long[] Value={ 0L,0L,1L,5L,3L,6L,0L,9L,8L,3L,1L,0L,2L,9L,1L,8L,5L,8L,6L,7L,8L,9L,5L,5L,4L,5L,3L,1L,4L,9L,0L,0L,1L,5L,3L,6L,0L,9L,8L,3L,1L,0L,2L,9L,1L,8L,5L,8L,6L,7L,8L,9L,5L,5L,4L,5L,3L,1L,4L,9L,0L,0L,1L,5L,3L,6L,0L,9L,8L,3L,1L,0L,2L,9L,1L,8L,5L,8L,6L,7L,8L,9L,5L,5L,4L,5L,3L,1L,4L,9L,0L,0L,1L,5L,3L,6L,0L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021655Inst : IEnumerable<long>
{
public static readonly long[] Value=A021655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021655.Bytes);
public long this[int i]=>Value[i];

public static A021655Inst Instance=new A021655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021654
{
public static readonly long[] Value={ 0L,0L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021654Inst : IEnumerable<long>
{
public static readonly long[] Value=A021654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021654.Bytes);
public long this[int i]=>Value[i];

public static A021654Inst Instance=new A021654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021653
{
public static readonly long[] Value={ 0L,0L,1L,5L,4L,0L,8L,3L,2L,0L,4L,9L,3L,0L,6L,6L,2L,5L,5L,7L,7L,8L,1L,2L,0L,1L,8L,4L,8L,9L,9L,8L,4L,5L,9L,1L,6L,7L,9L,5L,0L,6L,9L,3L,3L,7L,4L,4L,2L,2L,1L,8L,7L,9L,8L,1L,5L,1L,0L,0L,1L,5L,4L,0L,8L,3L,2L,0L,4L,9L,3L,0L,6L,6L,2L,5L,5L,7L,7L,8L,1L,2L,0L,1L,8L,4L,8L,9L,9L,8L,4L,5L,9L,1L,6L,7L,9L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021653Inst : IEnumerable<long>
{
public static readonly long[] Value=A021653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021653.Bytes);
public long this[int i]=>Value[i];

public static A021653Inst Instance=new A021653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021652
{
public static readonly long[] Value={ 0L,0L,1L,5L,4L,3L,2L,0L,9L,8L,7L,6L,5L,4L,3L,2L,0L,9L,8L,7L,6L,5L,4L,3L,2L,0L,9L,8L,7L,6L,5L,4L,3L,2L,0L,9L,8L,7L,6L,5L,4L,3L,2L,0L,9L,8L,7L,6L,5L,4L,3L,2L,0L,9L,8L,7L,6L,5L,4L,3L,2L,0L,9L,8L,7L,6L,5L,4L,3L,2L,0L,9L,8L,7L,6L,5L,4L,3L,2L,0L,9L,8L,7L,6L,5L,4L,3L,2L,0L,9L,8L,7L,6L,5L,4L,3L,2L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021652Inst : IEnumerable<long>
{
public static readonly long[] Value=A021652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021652.Bytes);
public long this[int i]=>Value[i];

public static A021652Inst Instance=new A021652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021651
{
public static readonly long[] Value={ 0L,0L,1L,5L,4L,5L,5L,9L,5L,0L,5L,4L,0L,9L,5L,8L,2L,6L,8L,9L,3L,3L,5L,3L,9L,4L,1L,2L,6L,7L,3L,8L,7L,9L,4L,4L,3L,5L,8L,5L,7L,8L,0L,5L,2L,5L,5L,0L,2L,3L,1L,8L,3L,9L,2L,5L,8L,1L,1L,4L,3L,7L,4L,0L,3L,4L,0L,0L,3L,0L,9L,1L,1L,9L,0L,1L,0L,8L,1L,9L,1L,6L,5L,3L,7L,8L,6L,7L,0L,7L,8L,8L,2L,5L,3L,4L,7L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021651Inst : IEnumerable<long>
{
public static readonly long[] Value=A021651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021651.Bytes);
public long this[int i]=>Value[i];

public static A021651Inst Instance=new A021651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021650
{
public static readonly long[] Value={ 0L,0L,1L,5L,4L,7L,9L,8L,7L,6L,1L,6L,0L,9L,9L,0L,7L,1L,2L,0L,7L,4L,3L,0L,3L,4L,0L,5L,5L,7L,2L,7L,5L,5L,4L,1L,7L,9L,5L,6L,6L,5L,6L,3L,4L,6L,7L,4L,9L,2L,2L,6L,0L,0L,6L,1L,9L,1L,9L,5L,0L,4L,6L,4L,3L,9L,6L,2L,8L,4L,8L,2L,9L,7L,2L,1L,3L,6L,2L,2L,2L,9L,1L,0L,2L,1L,6L,7L,1L,8L,2L,6L,6L,2L,5L,3L,8L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021650Inst : IEnumerable<long>
{
public static readonly long[] Value=A021650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021650.Bytes);
public long this[int i]=>Value[i];

public static A021650Inst Instance=new A021650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021649
{
public static readonly long[] Value={ 0L,0L,1L,5L,5L,0L,3L,8L,7L,5L,9L,6L,8L,9L,9L,2L,2L,4L,8L,0L,6L,2L,0L,1L,5L,5L,0L,3L,8L,7L,5L,9L,6L,8L,9L,9L,2L,2L,4L,8L,0L,6L,2L,0L,1L,5L,5L,0L,3L,8L,7L,5L,9L,6L,8L,9L,9L,2L,2L,4L,8L,0L,6L,2L,0L,1L,5L,5L,0L,3L,8L,7L,5L,9L,6L,8L,9L,9L,2L,2L,4L,8L,0L,6L,2L,0L,1L,5L,5L,0L,3L,8L,7L,5L,9L,6L,8L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021649Inst : IEnumerable<long>
{
public static readonly long[] Value=A021649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021649.Bytes);
public long this[int i]=>Value[i];

public static A021649Inst Instance=new A021649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021648
{
public static readonly long[] Value={ 0L,0L,1L,5L,5L,2L,7L,9L,5L,0L,3L,1L,0L,5L,5L,9L,0L,0L,6L,2L,1L,1L,1L,8L,0L,1L,2L,4L,2L,2L,3L,6L,0L,2L,4L,8L,4L,4L,7L,2L,0L,4L,9L,6L,8L,9L,4L,4L,0L,9L,9L,3L,7L,8L,8L,8L,1L,9L,8L,7L,5L,7L,7L,6L,3L,9L,7L,5L,1L,5L,5L,2L,7L,9L,5L,0L,3L,1L,0L,5L,5L,9L,0L,0L,6L,2L,1L,1L,1L,8L,0L,1L,2L,4L,2L,2L,3L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021648Inst : IEnumerable<long>
{
public static readonly long[] Value=A021648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021648.Bytes);
public long this[int i]=>Value[i];

public static A021648Inst Instance=new A021648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021647
{
public static readonly long[] Value={ 0L,0L,1L,5L,5L,5L,2L,0L,9L,9L,5L,3L,3L,4L,3L,7L,0L,1L,3L,9L,9L,6L,8L,8L,9L,5L,8L,0L,0L,9L,3L,3L,1L,2L,5L,9L,7L,2L,0L,0L,6L,2L,2L,0L,8L,3L,9L,8L,1L,3L,3L,7L,4L,8L,0L,5L,5L,9L,8L,7L,5L,5L,8L,3L,2L,0L,3L,7L,3L,2L,5L,0L,3L,8L,8L,8L,0L,2L,4L,8L,8L,3L,3L,5L,9L,2L,5L,3L,4L,9L,9L,2L,2L,2L,3L,9L,5L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021647Inst : IEnumerable<long>
{
public static readonly long[] Value=A021647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021647.Bytes);
public long this[int i]=>Value[i];

public static A021647Inst Instance=new A021647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021646
{
public static readonly long[] Value={ 0L,0L,1L,5L,5L,7L,6L,3L,2L,3L,9L,8L,7L,5L,3L,8L,9L,4L,0L,8L,0L,9L,9L,6L,8L,8L,4L,7L,3L,5L,2L,0L,2L,4L,9L,2L,2L,1L,1L,8L,3L,8L,0L,0L,6L,2L,3L,0L,5L,2L,9L,5L,9L,5L,0L,1L,5L,5L,7L,6L,3L,2L,3L,9L,8L,7L,5L,3L,8L,9L,4L,0L,8L,0L,9L,9L,6L,8L,8L,4L,7L,3L,5L,2L,0L,2L,4L,9L,2L,2L,1L,1L,8L,3L,8L,0L,0L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021646Inst : IEnumerable<long>
{
public static readonly long[] Value=A021646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021646.Bytes);
public long this[int i]=>Value[i];

public static A021646Inst Instance=new A021646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021629
{
public static readonly long[] Value={ 1L,23L,366L,5062L,65555L,820701L,10087792L,122732444L,1484551749L,17896987459L,215340503378L,2588122883346L,31085733296983L,373226612833097L,4480104054056724L,53770941570620968L,645319149365603657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021629Inst : IEnumerable<long>
{
public static readonly long[] Value=A021629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021629.Bytes);
public long this[int i]=>Value[i];

public static A021629Inst Instance=new A021629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021628
{
public static readonly long[] Value={ 0L,0L,1L,6L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021628Inst : IEnumerable<long>
{
public static readonly long[] Value=A021628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021628.Bytes);
public long this[int i]=>Value[i];

public static A021628Inst Instance=new A021628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021627
{
public static readonly long[] Value={ 0L,0L,1L,6L,0L,5L,1L,3L,6L,4L,3L,6L,5L,9L,7L,1L,1L,0L,7L,5L,4L,4L,1L,4L,1L,2L,5L,2L,0L,0L,6L,4L,2L,0L,5L,4L,5L,7L,4L,6L,3L,8L,8L,4L,4L,3L,0L,1L,7L,6L,5L,6L,5L,0L,0L,8L,0L,2L,5L,6L,8L,2L,1L,8L,2L,9L,8L,5L,5L,5L,3L,7L,7L,2L,0L,7L,0L,6L,2L,6L,0L,0L,3L,2L,1L,0L,2L,7L,2L,8L,7L,3L,1L,9L,4L,2L,2L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021627Inst : IEnumerable<long>
{
public static readonly long[] Value=A021627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021627.Bytes);
public long this[int i]=>Value[i];

public static A021627Inst Instance=new A021627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021626
{
public static readonly long[] Value={ 0L,0L,1L,6L,0L,7L,7L,1L,7L,0L,4L,1L,8L,0L,0L,6L,4L,3L,0L,8L,6L,8L,1L,6L,7L,2L,0L,2L,5L,7L,2L,3L,4L,7L,2L,6L,6L,8L,8L,1L,0L,2L,8L,9L,3L,8L,9L,0L,6L,7L,5L,2L,4L,1L,1L,5L,7L,5L,5L,6L,2L,7L,0L,0L,9L,6L,4L,6L,3L,0L,2L,2L,5L,0L,8L,0L,3L,8L,5L,8L,5L,2L,0L,9L,0L,0L,3L,2L,1L,5L,4L,3L,4L,0L,8L,3L,6L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021626Inst : IEnumerable<long>
{
public static readonly long[] Value=A021626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021626.Bytes);
public long this[int i]=>Value[i];

public static A021626Inst Instance=new A021626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021625
{
public static readonly long[] Value={ 0L,0L,1L,6L,1L,0L,3L,0L,5L,9L,5L,8L,1L,3L,2L,0L,4L,5L,0L,8L,8L,5L,6L,6L,8L,2L,7L,6L,9L,7L,2L,6L,2L,4L,7L,9L,8L,7L,1L,1L,7L,5L,5L,2L,3L,3L,4L,9L,4L,3L,6L,3L,9L,2L,9L,1L,4L,6L,5L,3L,7L,8L,4L,2L,1L,9L,0L,0L,1L,6L,1L,0L,3L,0L,5L,9L,5L,8L,1L,3L,2L,0L,4L,5L,0L,8L,8L,5L,6L,6L,8L,2L,7L,6L,9L,7L,2L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021625Inst : IEnumerable<long>
{
public static readonly long[] Value=A021625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021625.Bytes);
public long this[int i]=>Value[i];

public static A021625Inst Instance=new A021625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021624
{
public static readonly long[] Value={ 0L,0L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021624Inst : IEnumerable<long>
{
public static readonly long[] Value=A021624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021624.Bytes);
public long this[int i]=>Value[i];

public static A021624Inst Instance=new A021624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021623
{
public static readonly long[] Value={ 0L,0L,1L,6L,1L,5L,5L,0L,8L,8L,8L,5L,2L,9L,8L,8L,6L,9L,1L,4L,3L,7L,8L,0L,2L,9L,0L,7L,9L,1L,5L,9L,9L,3L,5L,3L,7L,9L,6L,4L,4L,5L,8L,8L,0L,4L,5L,2L,3L,4L,2L,4L,8L,7L,8L,8L,3L,6L,8L,3L,3L,6L,0L,2L,5L,8L,4L,8L,1L,4L,2L,1L,6L,4L,7L,8L,1L,9L,0L,6L,3L,0L,0L,4L,8L,4L,6L,5L,2L,6L,6L,5L,5L,8L,9L,6L,6L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021623Inst : IEnumerable<long>
{
public static readonly long[] Value=A021623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021623.Bytes);
public long this[int i]=>Value[i];

public static A021623Inst Instance=new A021623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021622
{
public static readonly long[] Value={ 0L,0L,1L,6L,1L,8L,1L,2L,2L,9L,7L,7L,3L,4L,6L,2L,7L,8L,3L,1L,7L,1L,5L,2L,1L,0L,3L,5L,5L,9L,8L,7L,0L,5L,5L,0L,1L,6L,1L,8L,1L,2L,2L,9L,7L,7L,3L,4L,6L,2L,7L,8L,3L,1L,7L,1L,5L,2L,1L,0L,3L,5L,5L,9L,8L,7L,0L,5L,5L,0L,1L,6L,1L,8L,1L,2L,2L,9L,7L,7L,3L,4L,6L,2L,7L,8L,3L,1L,7L,1L,5L,2L,1L,0L,3L,5L,5L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021622Inst : IEnumerable<long>
{
public static readonly long[] Value=A021622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021622.Bytes);
public long this[int i]=>Value[i];

public static A021622Inst Instance=new A021622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021621
{
public static readonly long[] Value={ 0L,0L,1L,6L,2L,0L,7L,4L,5L,5L,4L,2L,9L,4L,9L,7L,5L,6L,8L,8L,8L,1L,6L,8L,5L,5L,7L,5L,3L,6L,4L,6L,6L,7L,7L,4L,7L,1L,6L,3L,6L,9L,5L,2L,9L,9L,8L,3L,7L,9L,2L,5L,4L,4L,5L,7L,0L,5L,0L,2L,4L,3L,1L,1L,1L,8L,3L,1L,4L,4L,2L,4L,6L,3L,5L,3L,3L,2L,2L,5L,2L,8L,3L,6L,3L,0L,4L,7L,0L,0L,1L,6L,2L,0L,7L,4L,5L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021621Inst : IEnumerable<long>
{
public static readonly long[] Value=A021621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021621.Bytes);
public long this[int i]=>Value[i];

public static A021621Inst Instance=new A021621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021620
{
public static readonly long[] Value={ 0L,0L,1L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021620Inst : IEnumerable<long>
{
public static readonly long[] Value=A021620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021620.Bytes);
public long this[int i]=>Value[i];

public static A021620Inst Instance=new A021620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021619
{
public static readonly long[] Value={ 0L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021619Inst : IEnumerable<long>
{
public static readonly long[] Value=A021619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021619.Bytes);
public long this[int i]=>Value[i];

public static A021619Inst Instance=new A021619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021618
{
public static readonly long[] Value={ 0L,0L,1L,6L,2L,8L,6L,6L,4L,4L,9L,5L,1L,1L,4L,0L,0L,6L,5L,1L,4L,6L,5L,7L,9L,8L,0L,4L,5L,6L,0L,2L,6L,0L,5L,8L,6L,3L,1L,9L,2L,1L,8L,2L,4L,1L,0L,4L,2L,3L,4L,5L,2L,7L,6L,8L,7L,2L,9L,6L,4L,1L,6L,9L,3L,8L,1L,1L,0L,7L,4L,9L,1L,8L,5L,6L,6L,7L,7L,5L,2L,4L,4L,2L,9L,9L,6L,7L,4L,2L,6L,7L,1L,0L,0L,9L,7L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021618Inst : IEnumerable<long>
{
public static readonly long[] Value=A021618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021618.Bytes);
public long this[int i]=>Value[i];

public static A021618Inst Instance=new A021618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021617
{
public static readonly long[] Value={ 0L,0L,1L,6L,3L,1L,3L,2L,1L,3L,7L,0L,3L,0L,9L,9L,5L,1L,0L,6L,0L,3L,5L,8L,8L,9L,0L,7L,0L,1L,4L,6L,8L,1L,8L,9L,2L,3L,3L,2L,7L,8L,9L,5L,5L,9L,5L,4L,3L,2L,3L,0L,0L,1L,6L,3L,1L,3L,2L,1L,3L,7L,0L,3L,0L,9L,9L,5L,1L,0L,6L,0L,3L,5L,8L,8L,9L,0L,7L,0L,1L,4L,6L,8L,1L,8L,9L,2L,3L,3L,2L,7L,8L,9L,5L,5L,9L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021617Inst : IEnumerable<long>
{
public static readonly long[] Value=A021617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021617.Bytes);
public long this[int i]=>Value[i];

public static A021617Inst Instance=new A021617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021616
{
public static readonly long[] Value={ 0L,0L,1L,6L,3L,3L,9L,8L,6L,9L,2L,8L,1L,0L,4L,5L,7L,5L,1L,6L,3L,3L,9L,8L,6L,9L,2L,8L,1L,0L,4L,5L,7L,5L,1L,6L,3L,3L,9L,8L,6L,9L,2L,8L,1L,0L,4L,5L,7L,5L,1L,6L,3L,3L,9L,8L,6L,9L,2L,8L,1L,0L,4L,5L,7L,5L,1L,6L,3L,3L,9L,8L,6L,9L,2L,8L,1L,0L,4L,5L,7L,5L,1L,6L,3L,3L,9L,8L,6L,9L,2L,8L,1L,0L,4L,5L,7L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021616Inst : IEnumerable<long>
{
public static readonly long[] Value=A021616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021616.Bytes);
public long this[int i]=>Value[i];

public static A021616Inst Instance=new A021616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021615
{
public static readonly long[] Value={ 0L,0L,1L,6L,3L,6L,6L,6L,1L,2L,1L,1L,1L,2L,9L,2L,9L,6L,2L,3L,5L,6L,7L,9L,2L,1L,4L,4L,0L,2L,6L,1L,8L,6L,5L,7L,9L,3L,7L,8L,0L,6L,8L,7L,3L,9L,7L,7L,0L,8L,6L,7L,4L,3L,0L,4L,4L,1L,8L,9L,8L,5L,2L,7L,0L,0L,4L,9L,0L,9L,9L,8L,3L,6L,3L,3L,3L,8L,7L,8L,8L,8L,7L,0L,7L,0L,3L,7L,6L,4L,3L,2L,0L,7L,8L,5L,5L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021615Inst : IEnumerable<long>
{
public static readonly long[] Value=A021615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021615.Bytes);
public long this[int i]=>Value[i];

public static A021615Inst Instance=new A021615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021614
{
public static readonly long[] Value={ 1L,22L,332L,4322L,52353L,609924L,6948544L,78112924L,871004585L,9663416906L,106874239836L,1179653481006L,13004446987897L,143246730136168L,1577098731557408L,17357778969071768L,191003419177941489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021614Inst : IEnumerable<long>
{
public static readonly long[] Value=A021614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021614.Bytes);
public long this[int i]=>Value[i];

public static A021614Inst Instance=new A021614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021597
{
public static readonly long[] Value={ 0L,0L,1L,6L,8L,6L,3L,4L,0L,6L,4L,0L,8L,0L,9L,4L,4L,3L,5L,0L,7L,5L,8L,8L,5L,3L,2L,8L,8L,3L,6L,4L,2L,4L,9L,5L,7L,8L,4L,1L,4L,8L,3L,9L,7L,9L,7L,6L,3L,9L,1L,2L,3L,1L,0L,2L,8L,6L,6L,7L,7L,9L,0L,8L,9L,3L,7L,6L,0L,5L,3L,9L,6L,2L,9L,0L,0L,5L,0L,5L,9L,0L,2L,1L,9L,2L,2L,4L,2L,8L,3L,3L,0L,5L,2L,2L,7L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021597Inst : IEnumerable<long>
{
public static readonly long[] Value=A021597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021597.Bytes);
public long this[int i]=>Value[i];

public static A021597Inst Instance=new A021597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021596
{
public static readonly long[] Value={ 0L,0L,1L,6L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021596Inst : IEnumerable<long>
{
public static readonly long[] Value=A021596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021596.Bytes);
public long this[int i]=>Value[i];

public static A021596Inst Instance=new A021596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021595
{
public static readonly long[] Value={ 0L,0L,1L,6L,9L,2L,0L,4L,7L,3L,7L,7L,3L,2L,6L,5L,6L,5L,1L,4L,3L,8L,2L,4L,0L,2L,7L,0L,7L,2L,7L,5L,8L,0L,3L,7L,2L,2L,5L,0L,4L,2L,3L,0L,1L,1L,8L,4L,4L,3L,3L,1L,6L,4L,1L,2L,8L,5L,9L,5L,6L,0L,0L,6L,7L,6L,8L,1L,8L,9L,5L,0L,9L,3L,0L,6L,2L,6L,0L,5L,7L,5L,2L,9L,6L,1L,0L,8L,2L,9L,1L,0L,3L,2L,1L,4L,8L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021595Inst : IEnumerable<long>
{
public static readonly long[] Value=A021595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021595.Bytes);
public long this[int i]=>Value[i];

public static A021595Inst Instance=new A021595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021594
{
public static readonly long[] Value={ 1L,20L,270L,3100L,32711L,328440L,3195340L,30437000L,285695421L,2653625260L,24459281210L,224170373700L,2045792060131L,18609941810480L,168874176353880L,1529560509125200L,13833895100278841L,124980009723284100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021594Inst : IEnumerable<long>
{
public static readonly long[] Value=A021594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021594.Bytes);
public long this[int i]=>Value[i];

public static A021594Inst Instance=new A021594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021593
{
public static readonly long[] Value={ 0L,0L,1L,6L,9L,7L,7L,9L,2L,8L,6L,9L,2L,6L,9L,9L,4L,9L,0L,6L,6L,2L,1L,3L,9L,2L,1L,9L,0L,1L,5L,2L,8L,0L,1L,3L,5L,8L,2L,3L,4L,2L,9L,5L,4L,1L,5L,9L,5L,9L,2L,5L,2L,9L,7L,1L,1L,3L,7L,5L,2L,1L,2L,2L,2L,4L,1L,0L,8L,6L,5L,8L,7L,4L,3L,6L,3L,3L,2L,7L,6L,7L,4L,0L,2L,3L,7L,6L,9L,1L,0L,0L,1L,6L,9L,7L,7L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021593Inst : IEnumerable<long>
{
public static readonly long[] Value=A021593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021593.Bytes);
public long this[int i]=>Value[i];

public static A021593Inst Instance=new A021593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021592
{
public static readonly long[] Value={ 0L,0L,1L,7L,0L,0L,6L,8L,0L,2L,7L,2L,1L,0L,8L,8L,4L,3L,5L,3L,7L,4L,1L,4L,9L,6L,5L,9L,8L,6L,3L,9L,4L,5L,5L,7L,8L,2L,3L,1L,2L,9L,2L,5L,1L,7L,0L,0L,6L,8L,0L,2L,7L,2L,1L,0L,8L,8L,4L,3L,5L,3L,7L,4L,1L,4L,9L,6L,5L,9L,8L,6L,3L,9L,4L,5L,5L,7L,8L,2L,3L,1L,2L,9L,2L,5L,1L,7L,0L,0L,6L,8L,0L,2L,7L,2L,1L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021592Inst : IEnumerable<long>
{
public static readonly long[] Value=A021592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021592.Bytes);
public long this[int i]=>Value[i];

public static A021592Inst Instance=new A021592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021591
{
public static readonly long[] Value={ 0L,0L,1L,7L,0L,3L,5L,7L,7L,5L,1L,2L,7L,7L,6L,8L,3L,1L,3L,4L,5L,8L,2L,6L,2L,3L,5L,0L,9L,3L,6L,9L,6L,7L,6L,3L,2L,0L,2L,7L,2L,5L,7L,2L,4L,0L,2L,0L,4L,4L,2L,9L,3L,0L,1L,5L,3L,3L,2L,1L,9L,7L,6L,1L,4L,9L,9L,1L,4L,8L,2L,1L,1L,2L,4L,3L,6L,1L,1L,5L,8L,4L,3L,2L,7L,0L,8L,6L,8L,8L,2L,4L,5L,3L,1L,5L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021591Inst : IEnumerable<long>
{
public static readonly long[] Value=A021591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021591.Bytes);
public long this[int i]=>Value[i];

public static A021591Inst Instance=new A021591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021590
{
public static readonly long[] Value={ 0L,0L,1L,7L,0L,6L,4L,8L,4L,6L,4L,1L,6L,3L,8L,2L,2L,5L,2L,5L,5L,9L,7L,2L,6L,9L,6L,2L,4L,5L,7L,3L,3L,7L,8L,8L,3L,9L,5L,9L,0L,4L,4L,3L,6L,8L,6L,0L,0L,6L,8L,2L,5L,9L,3L,8L,5L,6L,6L,5L,5L,2L,9L,0L,1L,0L,2L,3L,8L,9L,0L,7L,8L,4L,9L,8L,2L,9L,3L,5L,1L,5L,3L,5L,8L,3L,6L,1L,7L,7L,4L,7L,4L,4L,0L,2L,7L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021590Inst : IEnumerable<long>
{
public static readonly long[] Value=A021590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021590.Bytes);
public long this[int i]=>Value[i];

public static A021590Inst Instance=new A021590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021589
{
public static readonly long[] Value={ 0L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021589Inst : IEnumerable<long>
{
public static readonly long[] Value=A021589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021589.Bytes);
public long this[int i]=>Value[i];

public static A021589Inst Instance=new A021589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021588
{
public static readonly long[] Value={ 0L,0L,1L,7L,1L,2L,3L,2L,8L,7L,6L,7L,1L,2L,3L,2L,8L,7L,6L,7L,1L,2L,3L,2L,8L,7L,6L,7L,1L,2L,3L,2L,8L,7L,6L,7L,1L,2L,3L,2L,8L,7L,6L,7L,1L,2L,3L,2L,8L,7L,6L,7L,1L,2L,3L,2L,8L,7L,6L,7L,1L,2L,3L,2L,8L,7L,6L,7L,1L,2L,3L,2L,8L,7L,6L,7L,1L,2L,3L,2L,8L,7L,6L,7L,1L,2L,3L,2L,8L,7L,6L,7L,1L,2L,3L,2L,8L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021588Inst : IEnumerable<long>
{
public static readonly long[] Value=A021588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021588.Bytes);
public long this[int i]=>Value[i];

public static A021588Inst Instance=new A021588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021587
{
public static readonly long[] Value={ 0L,0L,1L,7L,1L,5L,2L,6L,5L,8L,6L,6L,2L,0L,9L,2L,6L,2L,4L,3L,5L,6L,7L,7L,5L,3L,0L,0L,1L,7L,1L,5L,2L,6L,5L,8L,6L,6L,2L,0L,9L,2L,6L,2L,4L,3L,5L,6L,7L,7L,5L,3L,0L,0L,1L,7L,1L,5L,2L,6L,5L,8L,6L,6L,2L,0L,9L,2L,6L,2L,4L,3L,5L,6L,7L,7L,5L,3L,0L,0L,1L,7L,1L,5L,2L,6L,5L,8L,6L,6L,2L,0L,9L,2L,6L,2L,4L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021587Inst : IEnumerable<long>
{
public static readonly long[] Value=A021587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021587.Bytes);
public long this[int i]=>Value[i];

public static A021587Inst Instance=new A021587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021586
{
public static readonly long[] Value={ 0L,0L,1L,7L,1L,8L,2L,1L,3L,0L,5L,8L,4L,1L,9L,2L,4L,3L,9L,8L,6L,2L,5L,4L,2L,9L,5L,5L,3L,2L,6L,4L,6L,0L,4L,8L,1L,0L,9L,9L,6L,5L,6L,3L,5L,7L,3L,8L,8L,3L,1L,6L,1L,5L,1L,2L,0L,2L,7L,4L,9L,1L,4L,0L,8L,9L,3L,4L,7L,0L,7L,9L,0L,3L,7L,8L,0L,0L,6L,8L,7L,2L,8L,5L,2L,2L,3L,3L,6L,7L,6L,9L,7L,5L,9L,4L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021586Inst : IEnumerable<long>
{
public static readonly long[] Value=A021586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021586.Bytes);
public long this[int i]=>Value[i];

public static A021586Inst Instance=new A021586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021585
{
public static readonly long[] Value={ 0L,0L,1L,7L,2L,1L,1L,7L,0L,3L,9L,5L,8L,6L,9L,1L,9L,1L,0L,4L,9L,9L,1L,3L,9L,4L,1L,4L,8L,0L,2L,0L,6L,5L,4L,0L,4L,4L,7L,5L,0L,4L,3L,0L,2L,9L,2L,5L,9L,8L,9L,6L,7L,2L,9L,7L,7L,6L,2L,4L,7L,8L,4L,8L,5L,3L,7L,0L,0L,5L,1L,6L,3L,5L,1L,1L,1L,8L,7L,6L,0L,7L,5L,7L,3L,1L,4L,9L,7L,4L,1L,8L,2L,4L,4L,4L,0L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021585Inst : IEnumerable<long>
{
public static readonly long[] Value=A021585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021585.Bytes);
public long this[int i]=>Value[i];

public static A021585Inst Instance=new A021585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021584
{
public static readonly long[] Value={ 0L,0L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021584Inst : IEnumerable<long>
{
public static readonly long[] Value=A021584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021584.Bytes);
public long this[int i]=>Value[i];

public static A021584Inst Instance=new A021584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021583
{
public static readonly long[] Value={ 0L,0L,1L,7L,2L,7L,1L,1L,5L,7L,1L,6L,7L,5L,3L,0L,2L,2L,4L,5L,2L,5L,0L,4L,3L,1L,7L,7L,8L,9L,2L,9L,1L,8L,8L,2L,5L,5L,6L,1L,3L,1L,2L,6L,0L,7L,9L,4L,4L,7L,3L,2L,2L,9L,7L,0L,6L,3L,9L,0L,3L,2L,8L,1L,5L,1L,9L,8L,6L,1L,8L,3L,0L,7L,4L,2L,6L,5L,9L,7L,5L,8L,2L,0L,3L,7L,9L,9L,6L,5L,4L,5L,7L,6L,8L,5L,6L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021583Inst : IEnumerable<long>
{
public static readonly long[] Value=A021583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021583.Bytes);
public long this[int i]=>Value[i];

public static A021583Inst Instance=new A021583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021582
{
public static readonly long[] Value={ 0L,0L,1L,7L,3L,0L,1L,0L,3L,8L,0L,6L,2L,2L,8L,3L,7L,3L,7L,0L,2L,4L,2L,2L,1L,4L,5L,3L,2L,8L,7L,1L,9L,7L,2L,3L,1L,8L,3L,3L,9L,1L,0L,0L,3L,4L,6L,0L,2L,0L,7L,6L,1L,2L,4L,5L,6L,7L,4L,7L,4L,0L,4L,8L,4L,4L,2L,9L,0L,6L,5L,7L,4L,3L,9L,4L,4L,6L,3L,6L,6L,7L,8L,2L,0L,0L,6L,9L,2L,0L,4L,1L,5L,2L,2L,4L,9L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021582Inst : IEnumerable<long>
{
public static readonly long[] Value=A021582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021582.Bytes);
public long this[int i]=>Value[i];

public static A021582Inst Instance=new A021582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021565
{
public static readonly long[] Value={ 0L,0L,1L,7L,8L,2L,5L,3L,1L,1L,9L,4L,2L,9L,5L,9L,0L,0L,1L,7L,8L,2L,5L,3L,1L,1L,9L,4L,2L,9L,5L,9L,0L,0L,1L,7L,8L,2L,5L,3L,1L,1L,9L,4L,2L,9L,5L,9L,0L,0L,1L,7L,8L,2L,5L,3L,1L,1L,9L,4L,2L,9L,5L,9L,0L,0L,1L,7L,8L,2L,5L,3L,1L,1L,9L,4L,2L,9L,5L,9L,0L,0L,1L,7L,8L,2L,5L,3L,1L,1L,9L,4L,2L,9L,5L,9L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021565Inst : IEnumerable<long>
{
public static readonly long[] Value=A021565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021565.Bytes);
public long this[int i]=>Value[i];

public static A021565Inst Instance=new A021565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021564
{
public static readonly long[] Value={ 0L,0L,1L,7L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021564Inst : IEnumerable<long>
{
public static readonly long[] Value=A021564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021564.Bytes);
public long this[int i]=>Value[i];

public static A021564Inst Instance=new A021564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021563
{
public static readonly long[] Value={ 0L,0L,1L,7L,8L,8L,9L,0L,8L,7L,6L,5L,6L,5L,2L,9L,5L,1L,6L,9L,9L,4L,6L,3L,3L,2L,7L,3L,7L,0L,3L,0L,4L,1L,1L,4L,4L,9L,0L,1L,6L,1L,0L,0L,1L,7L,8L,8L,9L,0L,8L,7L,6L,5L,6L,5L,2L,9L,5L,1L,6L,9L,9L,4L,6L,3L,3L,2L,7L,3L,7L,0L,3L,0L,4L,1L,1L,4L,4L,9L,0L,1L,6L,1L,0L,0L,1L,7L,8L,8L,9L,0L,8L,7L,6L,5L,6L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021563Inst : IEnumerable<long>
{
public static readonly long[] Value=A021563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021563.Bytes);
public long this[int i]=>Value[i];

public static A021563Inst Instance=new A021563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021562
{
public static readonly long[] Value={ 0L,0L,1L,7L,9L,2L,1L,1L,4L,6L,9L,5L,3L,4L,0L,5L,0L,1L,7L,9L,2L,1L,1L,4L,6L,9L,5L,3L,4L,0L,5L,0L,1L,7L,9L,2L,1L,1L,4L,6L,9L,5L,3L,4L,0L,5L,0L,1L,7L,9L,2L,1L,1L,4L,6L,9L,5L,3L,4L,0L,5L,0L,1L,7L,9L,2L,1L,1L,4L,6L,9L,5L,3L,4L,0L,5L,0L,1L,7L,9L,2L,1L,1L,4L,6L,9L,5L,3L,4L,0L,5L,0L,1L,7L,9L,2L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021562Inst : IEnumerable<long>
{
public static readonly long[] Value=A021562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021562.Bytes);
public long this[int i]=>Value[i];

public static A021562Inst Instance=new A021562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021561
{
public static readonly long[] Value={ 0L,0L,1L,7L,9L,5L,3L,3L,2L,1L,3L,6L,4L,4L,5L,2L,4L,2L,3L,6L,9L,8L,3L,8L,4L,2L,0L,1L,0L,7L,7L,1L,9L,9L,2L,8L,1L,8L,6L,7L,1L,4L,5L,4L,2L,1L,9L,0L,3L,0L,5L,2L,0L,6L,4L,6L,3L,1L,9L,5L,6L,9L,1L,2L,0L,2L,8L,7L,2L,5L,3L,1L,4L,1L,8L,3L,1L,2L,3L,8L,7L,7L,9L,1L,7L,4L,1L,4L,7L,2L,1L,7L,2L,3L,5L,1L,8L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021561Inst : IEnumerable<long>
{
public static readonly long[] Value=A021561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021561.Bytes);
public long this[int i]=>Value[i];

public static A021561Inst Instance=new A021561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021560
{
public static readonly long[] Value={ 0L,0L,1L,7L,9L,8L,5L,6L,1L,1L,5L,1L,0L,7L,9L,1L,3L,6L,6L,9L,0L,6L,4L,7L,4L,8L,2L,0L,1L,4L,3L,8L,8L,4L,8L,9L,2L,0L,8L,6L,3L,3L,0L,9L,3L,5L,2L,5L,1L,7L,9L,8L,5L,6L,1L,1L,5L,1L,0L,7L,9L,1L,3L,6L,6L,9L,0L,6L,4L,7L,4L,8L,2L,0L,1L,4L,3L,8L,8L,4L,8L,9L,2L,0L,8L,6L,3L,3L,0L,9L,3L,5L,2L,5L,1L,7L,9L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021560Inst : IEnumerable<long>
{
public static readonly long[] Value=A021560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021560.Bytes);
public long this[int i]=>Value[i];

public static A021560Inst Instance=new A021560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021559
{
public static readonly long[] Value={ 0L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021559Inst : IEnumerable<long>
{
public static readonly long[] Value=A021559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021559.Bytes);
public long this[int i]=>Value[i];

public static A021559Inst Instance=new A021559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021558
{
public static readonly long[] Value={ 0L,0L,1L,8L,0L,5L,0L,5L,4L,1L,5L,1L,6L,2L,4L,5L,4L,8L,7L,3L,6L,4L,6L,2L,0L,9L,3L,8L,6L,2L,8L,1L,5L,8L,8L,4L,4L,7L,6L,5L,3L,4L,2L,9L,6L,0L,2L,8L,8L,8L,0L,8L,6L,6L,4L,2L,5L,9L,9L,2L,7L,7L,9L,7L,8L,3L,3L,9L,3L,5L,0L,1L,8L,0L,5L,0L,5L,4L,1L,5L,1L,6L,2L,4L,5L,4L,8L,7L,3L,6L,4L,6L,2L,0L,9L,3L,8L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021558Inst : IEnumerable<long>
{
public static readonly long[] Value=A021558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021558.Bytes);
public long this[int i]=>Value[i];

public static A021558Inst Instance=new A021558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021557
{
public static readonly long[] Value={ 0L,0L,1L,8L,0L,8L,3L,1L,8L,2L,6L,4L,0L,1L,4L,4L,6L,6L,5L,4L,6L,1L,1L,2L,1L,1L,5L,7L,3L,2L,3L,6L,8L,8L,9L,6L,9L,2L,5L,8L,5L,8L,9L,5L,1L,1L,7L,5L,4L,0L,6L,8L,7L,1L,6L,0L,9L,4L,0L,3L,2L,5L,4L,9L,7L,2L,8L,7L,5L,2L,2L,6L,0L,3L,9L,7L,8L,3L,0L,0L,1L,8L,0L,8L,3L,1L,8L,2L,6L,4L,0L,1L,4L,4L,6L,6L,5L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021557Inst : IEnumerable<long>
{
public static readonly long[] Value=A021557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021557.Bytes);
public long this[int i]=>Value[i];

public static A021557Inst Instance=new A021557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021556
{
public static readonly long[] Value={ 0L,0L,1L,8L,1L,1L,5L,9L,4L,2L,0L,2L,8L,9L,8L,5L,5L,0L,7L,2L,4L,6L,3L,7L,6L,8L,1L,1L,5L,9L,4L,2L,0L,2L,8L,9L,8L,5L,5L,0L,7L,2L,4L,6L,3L,7L,6L,8L,1L,1L,5L,9L,4L,2L,0L,2L,8L,9L,8L,5L,5L,0L,7L,2L,4L,6L,3L,7L,6L,8L,1L,1L,5L,9L,4L,2L,0L,2L,8L,9L,8L,5L,5L,0L,7L,2L,4L,6L,3L,7L,6L,8L,1L,1L,5L,9L,4L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021556Inst : IEnumerable<long>
{
public static readonly long[] Value=A021556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021556.Bytes);
public long this[int i]=>Value[i];

public static A021556Inst Instance=new A021556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021555
{
public static readonly long[] Value={ 0L,0L,1L,8L,1L,4L,8L,8L,2L,0L,3L,2L,6L,6L,7L,8L,7L,6L,5L,8L,8L,0L,2L,1L,7L,7L,8L,5L,8L,4L,3L,9L,2L,0L,1L,4L,5L,1L,9L,0L,5L,6L,2L,6L,1L,3L,4L,3L,0L,1L,2L,7L,0L,4L,1L,7L,4L,2L,2L,8L,6L,7L,5L,1L,3L,6L,1L,1L,6L,1L,5L,2L,4L,5L,0L,0L,9L,0L,7L,4L,4L,1L,0L,1L,6L,3L,3L,3L,9L,3L,8L,2L,9L,4L,0L,1L,0L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021555Inst : IEnumerable<long>
{
public static readonly long[] Value=A021555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021555.Bytes);
public long this[int i]=>Value[i];

public static A021555Inst Instance=new A021555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021554
{
public static readonly long[] Value={ 0L,0L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021554Inst : IEnumerable<long>
{
public static readonly long[] Value=A021554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021554.Bytes);
public long this[int i]=>Value[i];

public static A021554Inst Instance=new A021554Inst();

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