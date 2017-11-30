using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A193010
{
public static readonly long[] Value={ 1L,7L,8L,3L,9L,2L,2L,9L,9L,6L,3L,1L,2L,8L,7L,8L,7L,6L,7L,8L,4L,6L,2L,3L,6L,9L,1L,6L,0L,9L,0L,1L,7L,0L,9L,7L,2L,5L,1L,0L,2L,9L,8L,6L,0L,6L,3L,3L,8L,4L,1L,2L,1L,7L,8L,7L,0L,7L,0L,0L,0L,7L,3L,6L,6L,8L,9L,5L,2L,5L,9L,7L,4L,0L,0L,2L,0L,3L,0L,2L,5L,3L,5L,4L,8L,2L,6L,1L,5L,6L,5L,0L,5L,6L,7L,1L,9L,4L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193010Inst : IEnumerable<long>
{
public static readonly long[] Value=A193010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193010.Bytes);
public long this[int i]=>Value[i];

public static A193010Inst Instance=new A193010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193011
{
public static readonly long[] Value={ 1L,4L,3L,1L,9L,7L,4L,5L,2L,9L,1L,0L,0L,8L,0L,2L,3L,2L,6L,4L,1L,5L,0L,3L,6L,4L,7L,7L,2L,4L,6L,4L,1L,0L,8L,4L,9L,9L,0L,8L,8L,9L,2L,8L,6L,2L,3L,8L,9L,1L,3L,5L,5L,1L,7L,4L,6L,3L,3L,8L,8L,6L,4L,3L,3L,5L,0L,1L,0L,7L,1L,2L,6L,6L,1L,3L,3L,6L,4L,0L,8L,9L,0L,9L,5L,6L,1L,9L,7L,3L,1L,0L,8L,5L,2L,8L,5L,9L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193011Inst : IEnumerable<long>
{
public static readonly long[] Value=A193011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193011.Bytes);
public long this[int i]=>Value[i];

public static A193011Inst Instance=new A193011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193012
{
public static readonly long[] Value={ 7L,0L,5L,8L,4L,5L,4L,7L,0L,4L,5L,7L,2L,3L,4L,3L,9L,3L,7L,3L,7L,8L,0L,8L,7L,5L,3L,5L,0L,2L,0L,3L,9L,3L,8L,7L,5L,3L,0L,4L,3L,1L,8L,8L,8L,8L,8L,7L,3L,4L,5L,0L,0L,1L,8L,4L,7L,1L,7L,3L,7L,3L,9L,7L,9L,6L,7L,2L,0L,9L,7L,7L,0L,0L,2L,2L,9L,0L,3L,5L,1L,3L,1L,6L,4L,6L,9L,6L,1L,8L,8L,3L,1L,6L,8L,5L,4L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193012Inst : IEnumerable<long>
{
public static readonly long[] Value=A193012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193012.Bytes);
public long this[int i]=>Value[i];

public static A193012Inst Instance=new A193012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193013
{
public static readonly long[] Value={ 5L,7L,6L,7L,0L,2L,1L,2L,3L,1L,9L,4L,6L,3L,3L,9L,1L,8L,1L,8L,5L,4L,0L,4L,3L,4L,7L,7L,5L,6L,1L,3L,7L,5L,3L,4L,8L,2L,0L,0L,5L,7L,3L,4L,8L,0L,5L,1L,9L,8L,0L,9L,6L,0L,4L,5L,2L,5L,5L,0L,9L,3L,7L,0L,0L,3L,3L,4L,1L,7L,6L,0L,2L,3L,7L,9L,5L,3L,8L,7L,1L,0L,1L,3L,5L,4L,0L,6L,3L,8L,6L,7L,0L,2L,4L,3L,7L,9L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193013Inst : IEnumerable<long>
{
public static readonly long[] Value=A193013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193013.Bytes);
public long this[int i]=>Value[i];

public static A193013Inst Instance=new A193013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193014
{
public static readonly long[] Value={ 3L,8L,5L,6L,0L,5L,1L,3L,7L,9L,5L,5L,7L,4L,8L,8L,2L,9L,1L,5L,1L,3L,2L,4L,3L,5L,9L,1L,7L,2L,1L,3L,2L,5L,0L,1L,0L,3L,5L,4L,6L,4L,1L,1L,1L,4L,3L,9L,7L,4L,7L,2L,5L,0L,9L,0L,5L,2L,9L,4L,8L,7L,1L,8L,9L,0L,0L,3L,6L,1L,0L,6L,6L,5L,7L,7L,4L,8L,6L,5L,8L,3L,1L,4L,8L,2L,7L,5L,8L,8L,7L,3L,0L,4L,5L,4L,8L,3L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193014Inst : IEnumerable<long>
{
public static readonly long[] Value=A193014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193014.Bytes);
public long this[int i]=>Value[i];

public static A193014Inst Instance=new A193014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193015
{
public static readonly long[] Value={ 1L,9L,3L,3L,1L,3L,2L,3L,9L,9L,0L,6L,4L,1L,7L,3L,0L,4L,8L,7L,6L,4L,4L,3L,7L,9L,6L,0L,9L,0L,5L,8L,8L,0L,5L,5L,9L,9L,1L,9L,4L,4L,9L,3L,1L,3L,0L,7L,3L,5L,1L,4L,7L,2L,5L,7L,1L,4L,5L,8L,9L,2L,3L,2L,1L,5L,0L,7L,9L,1L,9L,0L,7L,6L,5L,1L,8L,5L,7L,4L,3L,0L,0L,5L,9L,2L,3L,9L,0L,4L,6L,3L,6L,6L,3L,9L,6L,0L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193015Inst : IEnumerable<long>
{
public static readonly long[] Value=A193015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193015.Bytes);
public long this[int i]=>Value[i];

public static A193015Inst Instance=new A193015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193016
{
public static readonly long[] Value={ 1L,3L,7L,7L,6L,7L,5L,3L,2L,7L,4L,9L,0L,9L,4L,6L,5L,4L,6L,2L,1L,1L,5L,6L,5L,1L,2L,1L,0L,7L,0L,3L,9L,1L,7L,7L,3L,6L,9L,5L,8L,3L,5L,1L,5L,6L,0L,4L,1L,3L,1L,2L,2L,0L,0L,2L,6L,7L,3L,2L,1L,5L,9L,2L,5L,7L,6L,0L,2L,5L,7L,9L,2L,0L,9L,9L,3L,9L,1L,1L,3L,0L,2L,1L,8L,1L,0L,8L,8L,7L,7L,0L,5L,3L,3L,3L,0L,5L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193016Inst : IEnumerable<long>
{
public static readonly long[] Value=A193016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193016.Bytes);
public long this[int i]=>Value[i];

public static A193016Inst Instance=new A193016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193017
{
public static readonly long[] Value={ 1L,5L,9L,0L,6L,0L,9L,7L,5L,6L,4L,0L,6L,4L,6L,1L,4L,6L,2L,9L,6L,9L,7L,9L,3L,1L,1L,9L,9L,9L,9L,5L,8L,2L,9L,1L,6L,5L,1L,8L,3L,5L,3L,6L,7L,5L,0L,3L,1L,0L,6L,0L,7L,0L,6L,1L,3L,5L,5L,4L,1L,8L,1L,3L,4L,7L,4L,4L,4L,6L,7L,8L,3L,2L,3L,6L,8L,4L,4L,5L,1L,0L,5L,4L,2L,3L,3L,7L,6L,6L,0L,4L,2L,0L,0L,7L,9L,8L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193017Inst : IEnumerable<long>
{
public static readonly long[] Value=A193017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193017.Bytes);
public long this[int i]=>Value[i];

public static A193017Inst Instance=new A193017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193018
{
public static readonly long[] Value={ 23L,87L,119L,201L,312L,376L,455L,616L,760L,840L,1055L,1136L,1248L,1472L,1719L,1959L,2064L,2472L,2764L,2976L,3264L,3407L,3584L,4032L,4336L,4848L,4992L,5088L,5523L,5900L,6112L,6624L,7360L,7680L,7680L,8448L,8960L,9152L,9856L,10208L,11136L,11904L,12256L,12256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193018Inst : IEnumerable<long>
{
public static readonly long[] Value=A193018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193018.Bytes);
public long this[int i]=>Value[i];

public static A193018Inst Instance=new A193018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193019
{
public static readonly long[] Value={ 5L,2L,8L,7L,6L,6L,3L,7L,2L,9L,4L,4L,8L,9L,7L,6L,1L,4L,2L,4L,7L,4L,9L,7L,7L,7L,9L,7L,7L,8L,8L,1L,4L,8L,1L,5L,1L,8L,7L,2L,3L,7L,0L,6L,3L,6L,8L,3L,3L,1L,9L,1L,0L,7L,6L,2L,7L,4L,6L,9L,6L,4L,3L,5L,9L,6L,5L,3L,1L,8L,5L,4L,9L,9L,5L,8L,0L,7L,9L,5L,9L,6L,8L,4L,9L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193019Inst : IEnumerable<long>
{
public static readonly long[] Value=A193019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193019.Bytes);
public long this[int i]=>Value[i];

public static A193019Inst Instance=new A193019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193052
{
public static readonly long[] Value={ -1L,-2L,0L,34L,288L,1858L,10800L,59554L,318528L,1671298L,8658000L,44456674L,226831968L,1151999938L,5830297200L,29429487394L,148249876608L,745630443778L,3745590368400L,18797446159714L,94264433228448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193052Inst : IEnumerable<long>
{
public static readonly long[] Value=A193052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193052.Bytes);
public long this[int i]=>Value[i];

public static A193052Inst Instance=new A193052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193053
{
public static readonly long[] Value={ 1L,5L,10L,17L,26L,36L,49L,62L,79L,95L,116L,135L,160L,182L,211L,236L,269L,297L,334L,365L,406L,440L,485L,522L,571L,611L,664L,707L,764L,810L,871L,920L,985L,1037L,1106L,1161L,1234L,1292L,1369L,1430L,1511L,1575L,1660L,1727L,1816L,1886L,1979L,2052L,2149L,2225L,2326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193053Inst : IEnumerable<long>
{
public static readonly long[] Value=A193053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193053.Bytes);
public long this[int i]=>Value[i];

public static A193053Inst Instance=new A193053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193054
{
public static readonly BigInteger[] Value={ 0L,0L,1067638L,34524432316L,1250063279938854L,BigInteger.Parse("38350427205194670084"),BigInteger.Parse("1254934986399237346242334"),BigInteger.Parse("40157773188600794694366079616"),BigInteger.Parse("1293153423896688571314211086231916"),BigInteger.Parse("41575689378315795601749194654016984354"),BigInteger.Parse("1337089200028352592236847382536061361269314") };
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
public class A193054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193054Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193054.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193054.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193054Inst Instance=new A193054Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193055
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,44202L,55488142L,34524432316L,13267364410532L,7112881119092574L,4235482818156697040L,BigInteger.Parse("2122880233853945590892"),BigInteger.Parse("1105420672289849239070962"),BigInteger.Parse("586820057145837880942582376"),BigInteger.Parse("311550865881297158579957164664"),BigInteger.Parse("162703111270636640083076205067310") };
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
public class A193055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193055Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193055.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193055.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193055Inst Instance=new A193055Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193056
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,1L,0L,3L,2L,1L,0L,0L,0L,1L,1L,4L,0L,0L,0L,0L,1L,1L,0L,0L,2L,1L,3L,0L,0L,-1L,0L,5L,1L,1L,1L,0L,0L,1L,1L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,2L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,6L,1L,-1L,0L,0L,1L,-1L,0L,0L,0L,1L,0L,0L,1L,-1L,0L,0L,4L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,-1L,1L,0L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193056Inst : IEnumerable<long>
{
public static readonly long[] Value=A193056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193056.Bytes);
public long this[int i]=>Value[i];

public static A193056Inst Instance=new A193056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193057
{
public static readonly long[] Value={ 1L,2L,4L,13L,43L,179L,754L,3752L,18910L,107947L,626797L,4007984L,26177428L,184572504L,1333510143L,10251720776L,80925610461L,672581036971L,5745786626079L,51276472540865L,470474128209758L,4483074757033617L,43904371855787890L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193057Inst : IEnumerable<long>
{
public static readonly long[] Value=A193057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193057.Bytes);
public long this[int i]=>Value[i];

public static A193057Inst Instance=new A193057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193058
{
public static readonly long[] Value={ 1L,2L,4L,11L,35L,132L,575L,2666L,13366L,75702L,440671L,2729413L,18532000L,128377424L,932516735L,7310526099L,58152253376L,481264505644L,4246485063225L,37932739729104L,350480039796036L,3421582485716585L,33772551636563403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193058Inst : IEnumerable<long>
{
public static readonly long[] Value=A193058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193058.Bytes);
public long this[int i]=>Value[i];

public static A193058Inst Instance=new A193058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193059
{
public static readonly long[] Value={ 1L,2L,4L,11L,30L,103L,423L,1898L,9186L,48459L,277813L,1682335L,10842496L,73622545L,532098309L,4013332419L,31553670222L,258169433450L,2231159821028L,19826045896926L,182181813932571L,1733395478474786L,17237091890882863L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193059Inst : IEnumerable<long>
{
public static readonly long[] Value=A193059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193059.Bytes);
public long this[int i]=>Value[i];

public static A193059Inst Instance=new A193059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193060
{
public static readonly long[] Value={ 1L,2L,4L,11L,30L,87L,326L,1384L,6412L,32253L,175410L,1018513L,6293033L,41087200L,283470860L,2066593574L,15747134967L,125214779885L,1039530874036L,8970143588253L,80678526525259L,749250973396318L,7210243966377770L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193060Inst : IEnumerable<long>
{
public static readonly long[] Value=A193060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193060.Bytes);
public long this[int i]=>Value[i];

public static A193060Inst Instance=new A193060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193061
{
public static readonly long[] Value={ 1L,2L,4L,11L,30L,87L,273L,1060L,4629L,22118L,114675L,637508L,3764980L,23493473L,154648476L,1074598386L,7847796726L,59999039043L,478914675838L,3978488873259L,34374954527318L,308440229973719L,2865860328108722L,27538413740887632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193061Inst : IEnumerable<long>
{
public static readonly long[] Value=A193061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193061.Bytes);
public long this[int i]=>Value[i];

public static A193061Inst Instance=new A193061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193062
{
public static readonly long[] Value={ 1L,2L,4L,11L,30L,87L,273L,884L,3528L,15794L,77546L,411280L,2330917L,13986818L,88229024L,584296099L,4065067511L,29670613826L,226603232720L,1805007845631L,14960664057034L,128832477724303L,1150304120201088L,10631476589401031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193062Inst : IEnumerable<long>
{
public static readonly long[] Value=A193062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193062.Bytes);
public long this[int i]=>Value[i];

public static A193062Inst Instance=new A193062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193063
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193063Inst : IEnumerable<long>
{
public static readonly long[] Value=A193063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193063.Bytes);
public long this[int i]=>Value[i];

public static A193063Inst Instance=new A193063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193064
{
public static readonly long[] Value={ 2L,3L,5L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193064Inst : IEnumerable<long>
{
public static readonly long[] Value=A193064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193064.Bytes);
public long this[int i]=>Value[i];

public static A193064Inst Instance=new A193064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193065
{
public static readonly long[] Value={ 9L,25L,289L,729L,1521L,1681L,2401L,3481L,5041L,7921L,10201L,15625L,17161L,27889L,28561L,29929L,83521L,85849L,146689L,257049L,279841L,458329L,491401L,531441L,552049L,579121L,597529L,683929L,703921L,707281L,734449L,829921L,1190281L,1203409L,1352569L,1394761L,1423249L,1481089L,1885129L,2036329L,2211169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193065Inst : IEnumerable<long>
{
public static readonly long[] Value=A193065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193065.Bytes);
public long this[int i]=>Value[i];

public static A193065Inst Instance=new A193065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193066
{
public static readonly long[] Value={ 3L,5L,17L,27L,39L,41L,49L,59L,71L,89L,101L,125L,131L,167L,169L,173L,289L,293L,383L,507L,529L,677L,701L,729L,743L,761L,773L,827L,839L,841L,857L,911L,1091L,1097L,1163L,1181L,1193L,1217L,1373L,1427L,1487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193066Inst : IEnumerable<long>
{
public static readonly long[] Value=A193066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193066.Bytes);
public long this[int i]=>Value[i];

public static A193066Inst Instance=new A193066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193067
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,0L,5L,2L,8L,0L,9L,1L,11L,0L,3L,9L,15L,0L,17L,3L,5L,0L,21L,2L,34L,0L,30L,5L,27L,0L,29L,8L,9L,0L,15L,8L,35L,0L,11L,6L,39L,0L,41L,9L,24L,0L,45L,9L,76L,0L,15L,11L,51L,0L,27L,10L,17L,0L,57L,3L,59L,0L,40L,61L,33L,0L,65L,15L,21L,0L,69L,16L,71L,0L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193067Inst : IEnumerable<long>
{
public static readonly long[] Value=A193067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193067.Bytes);
public long this[int i]=>Value[i];

public static A193067Inst Instance=new A193067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193100
{
public static readonly BigInteger[] Value={ 1L,3L,63L,6804L,1990170L,1145276496L,1172421884088L,1981846981092069L,5166650461467914874L,BigInteger.Parse("19710026486212156729362"),BigInteger.Parse("105613632141369240315500892"),BigInteger.Parse("768455476842781911036557334267"),BigInteger.Parse("7380326961188107570497477933701847") };
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
public class A193100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193100Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193100.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193100.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193100Inst Instance=new A193100Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193101
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,2L,1L,2L,3L,2L,3L,4L,3L,1L,2L,3L,2L,3L,4L,3L,2L,3L,4L,3L,1L,2L,3L,2L,3L,4L,3L,2L,3L,4L,3L,4L,5L,4L,2L,3L,1L,2L,3L,2L,3L,3L,3L,2L,3L,2L,3L,4L,3L,4L,2L,3L,3L,3L,4L,4L,4L,3L,1L,2L,3L,2L,3L,4L,3L,2L,3L,4L,3L,4L,3L,4L,2L,3L,4L,3L,4L,2L,3L,3L,3L,4L,4L,2L,3L,4L,3L,1L,2L,3L,2L,3L,4L,3L,2L,3L,4L,3L,4L,2L,3L,2L,3L,4L,3L,4L,3L,4L,3L,4L,5L,4L,2L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193101Inst : IEnumerable<long>
{
public static readonly long[] Value=A193101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193101.Bytes);
public long this[int i]=>Value[i];

public static A193101Inst Instance=new A193101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193102
{
public static readonly long[] Value={ 1L,8L,71L,478L,3248L,19674L,116885L,655064L,3602627L,19082622L,99353815L,503974610L,2518347829L,12341129010L,59691674707L,284343349874L,1339171125620L,6229010760982L,28686750790598L,130740792179088L,590661906472634L,2644740541614160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193102Inst : IEnumerable<long>
{
public static readonly long[] Value=A193102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193102.Bytes);
public long this[int i]=>Value[i];

public static A193102Inst Instance=new A193102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193103
{
public static readonly long[] Value={ 1L,14L,161L,1678L,15524L,134844L,1113797L,8791370L,66966377L,495285252L,3566916109L,25105766336L,173194384597L,1173147905334L,7817490983485L,51328840496684L,332461481754542L,2126710086580138L,13448964442250078L,84145658562788118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193103Inst : IEnumerable<long>
{
public static readonly long[] Value=A193103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193103.Bytes);
public long this[int i]=>Value[i];

public static A193103Inst Instance=new A193103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193104
{
public static readonly long[] Value={ 1L,12L,165L,1820L,19610L,190006L,1823415L,16461130L,146258245L,1254022900L,10573576571L,86961051682L,705575418795L,5616255032890L,44167926438195L,342310177217866L,2624766747036662L,19886684916153110L,149283882397744910L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193104Inst : IEnumerable<long>
{
public static readonly long[] Value=A193104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193104.Bytes);
public long this[int i]=>Value[i];

public static A193104Inst Instance=new A193104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193105
{
public static readonly long[] Value={ 37L,115L,122L,166L,334L,372L,541L,1805L,2532L,2773L,2861L,3340L,4148L,4980L,5157L,5898L,6522L,6529L,7557L,10915L,28415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193105Inst : IEnumerable<long>
{
public static readonly long[] Value=A193105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193105.Bytes);
public long this[int i]=>Value[i];

public static A193105Inst Instance=new A193105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193106
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,6L,2L,3L,4L,1L,2L,3L,3L,4L,5L,2L,3L,4L,4L,5L,6L,3L,4L,1L,2L,3L,4L,4L,5L,2L,3L,4L,5L,5L,6L,3L,4L,5L,2L,3L,4L,4L,5L,1L,2L,3L,4L,5L,6L,2L,3L,4L,2L,3L,4L,3L,4L,5L,2L,3L,4L,4L,5L,6L,3L,4L,5L,3L,4L,5L,1L,2L,2L,3L,4L,5L,2L,3L,3L,4L,5L,3L,3L,4L,4L,2L,3L,3L,4L,5L,5L,3L,2L,3L,4L,5L,4L,4L,3L,2L,3L,3L,4L,5L,4L,1L,2L,3L,4L,5L,4L,2L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193106Inst : IEnumerable<long>
{
public static readonly long[] Value=A193106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193106.Bytes);
public long this[int i]=>Value[i];

public static A193106Inst Instance=new A193106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193107
{
public static readonly long[] Value={ 11L,26L,40L,54L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193107Inst : IEnumerable<long>
{
public static readonly long[] Value=A193107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193107.Bytes);
public long this[int i]=>Value[i];

public static A193107Inst Instance=new A193107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193108
{
public static readonly long[] Value={ 1L,4L,0L,0L,5L,6L,4L,0L,5L,0L,6L,4L,5L,0L,0L,6L,9L,0L,0L,0L,1L,4L,0L,0L,5L,6L,4L,0L,5L,0L,6L,4L,5L,0L,0L,6L,9L,0L,0L,0L,1L,4L,0L,0L,5L,6L,4L,0L,5L,0L,6L,4L,5L,0L,0L,6L,9L,0L,0L,0L,1L,4L,0L,0L,5L,6L,4L,0L,5L,0L,6L,4L,5L,0L,0L,6L,9L,0L,0L,0L,1L,4L,0L,0L,5L,6L,4L,0L,5L,0L,6L,4L,5L,0L,0L,6L,9L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193108Inst : IEnumerable<long>
{
public static readonly long[] Value=A193108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193108.Bytes);
public long this[int i]=>Value[i];

public static A193108Inst Instance=new A193108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193109
{
public static readonly long[] Value={ 0L,1L,9L,3L,225L,15L,65835L,1605L,19425L,2397347205L,153535525935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193109Inst : IEnumerable<long>
{
public static readonly long[] Value=A193109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193109.Bytes);
public long this[int i]=>Value[i];

public static A193109Inst Instance=new A193109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193110
{
public static readonly long[] Value={ 1L,1L,3L,9L,33L,137L,635L,3233L,17881L,106489L,678091L,4590225L,32873625L,248056497L,1965232403L,16297012121L,141080069057L,1271902272241L,11916559511731L,115805756278393L,1165319447579313L,12123219789825273L,130206136096941195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193110Inst : IEnumerable<long>
{
public static readonly long[] Value=A193110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193110.Bytes);
public long this[int i]=>Value[i];

public static A193110Inst Instance=new A193110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193111
{
public static readonly long[] Value={ 1L,1L,2L,6L,19L,63L,218L,781L,2869L,10742L,40846L,157318L,612446L,2406100L,9527159L,37981611L,152328497L,614167702L,2487941464L,10121128882L,41330709103L,169362297620L,696187639438L,2870017515884L,11862845007114L,49152859179055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193111Inst : IEnumerable<long>
{
public static readonly long[] Value=A193111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193111.Bytes);
public long this[int i]=>Value[i];

public static A193111Inst Instance=new A193111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193112
{
public static readonly long[] Value={ 1L,1L,3L,13L,63L,328L,1796L,10200L,59529L,354837L,2151079L,13221261L,82200739L,516053099L,3266812048L,20829635112L,133651716406L,862342656359L,5591505085491L,36416212224801L,238114435569354L,1562560513492974L,10287406857203911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193112Inst : IEnumerable<long>
{
public static readonly long[] Value=A193112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193112.Bytes);
public long this[int i]=>Value[i];

public static A193112Inst Instance=new A193112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193113
{
public static readonly long[] Value={ 1L,1L,4L,23L,151L,1074L,8059L,62814L,503619L,4126954L,34411602L,291025337L,2490377810L,21523367553L,187603609077L,1647252368595L,14556722879278L,129366008725176L,1155458240271571L,10366549508487178L,93382085749705066L,844255894224907354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193113Inst : IEnumerable<long>
{
public static readonly long[] Value=A193113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193113.Bytes);
public long this[int i]=>Value[i];

public static A193113Inst Instance=new A193113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193114
{
public static readonly long[] Value={ 1L,1L,2L,5L,13L,37L,111L,345L,1103L,3604L,11977L,40356L,137543L,473317L,1642258L,5738828L,20179338L,71346433L,253485527L,904536366L,3240418665L,11649734335L,42017535527L,151992797355L,551298507620L,2004602732825L,7305747551718L,26682235709115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193114Inst : IEnumerable<long>
{
public static readonly long[] Value=A193114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193114.Bytes);
public long this[int i]=>Value[i];

public static A193114Inst Instance=new A193114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193115
{
public static readonly long[] Value={ 1L,1L,3L,12L,54L,265L,1373L,7388L,40888L,231250L,1330618L,7764670L,45841323L,273316120L,1643345418L,9953021248L,60665811025L,371850104167L,2290623433302L,14173331572490L,88049709138896L,548978010516319L,3434070688405887L,21545961024510032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193115Inst : IEnumerable<long>
{
public static readonly long[] Value=A193115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193115.Bytes);
public long this[int i]=>Value[i];

public static A193115Inst Instance=new A193115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193148
{
public static readonly BigInteger[] Value={ 1L,1L,5L,38642L,3568248132106250L,BigInteger.Parse("3246169059975118817432899391647432842916250") };
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
public class A193148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193148Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193148.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193148.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193148Inst Instance=new A193148Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193149
{
public static readonly BigInteger[] Value={ 1L,3L,2000L,336140000000000000L,BigInteger.Parse("32554045772335662075602200334460661252301125121982623937237672411739217889067008") };
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
public class A193149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193149Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193149.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193149.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193149Inst Instance=new A193149Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193150
{
public static readonly BigInteger[] Value={ 1L,1L,6L,162000000L,BigInteger.Parse("88781992297267257678613355957281627503968032277449748250624000") };
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
public class A193150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193150Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193150.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193150.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193150Inst Instance=new A193150Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193151
{
public static readonly BigInteger[] Value={ 1L,4L,129600L,17210368000000L,BigInteger.Parse("14344087024170010017792000"),BigInteger.Parse("108802808353712082212104996827371705204736"),BigInteger.Parse("10395932534012968042533315321842530487986106853298174278238208") };
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
public class A193151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193151Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193151.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193151.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193151Inst Instance=new A193151Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193152
{
public static readonly BigInteger[] Value={ 54L,600L,9610L,202800L,5329646L,167968080L,6179829138L,260151206520L,12337375641382L,651015233505000L,37840126019474714L,2402561511036567776L,BigInteger.Parse("165461166543219825630"),BigInteger.Parse("12285812875257176823072"),BigInteger.Parse("978456001614356104964386"),BigInteger.Parse("83203281212934340605312360"),BigInteger.Parse("7524376956227661294000910358"),BigInteger.Parse("721103578185352149703877262840") };
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
public class A193152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193152Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193152.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193152.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193152Inst Instance=new A193152Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193153
{
public static readonly BigInteger[] Value={ 1296L,82944L,9150625L,1575296100L,391476713761L,132821015040000L,59042071787233536L,BigInteger.Parse("33317165538875522500"),BigInteger.Parse("23276866101199344597601"),BigInteger.Parse("19729668557004748392960000"),BigInteger.Parse("19950922411933407541569256321"),BigInteger.Parse("23731310247317631978185581240644") };
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
public class A193153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193153Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193153.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193153.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193153Inst Instance=new A193153Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193154
{
public static readonly BigInteger[] Value={ 1L,3L,384L,2048000L,518400000000L,7192939211224252416L,BigInteger.Parse("6266608900058816862941609984"),BigInteger.Parse("388040545518272905743826242144898646016"),BigInteger.Parse("1911283738799704422875920401026220178381209600000000") };
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
public class A193154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193154Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193154.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193154.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193154Inst Instance=new A193154Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193155
{
public static readonly BigInteger[] Value={ 0L,4L,8L,126L,3269L,169942L,17345573L,3495586809L,1389897952334L,1090163075958998L,1686816727834550231L,BigInteger.Parse("5148938004752209696533"),BigInteger.Parse("31005486113751088602024098"),BigInteger.Parse("368324363978199003012362844935") };
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
public class A193155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193155Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193155.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193155.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193155Inst Instance=new A193155Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193156
{
public static readonly long[] Value={ 0L,1L,21L,1093L,172217L,81613877L,113899763795L,468482952092893L,5676720267644621509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193156Inst : IEnumerable<long>
{
public static readonly long[] Value=A193156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193156.Bytes);
public long this[int i]=>Value[i];

public static A193156Inst Instance=new A193156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193157
{
public static readonly long[] Value={ 0L,4L,50L,7220L,3617435L,7105087996L,53464012176143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193157Inst : IEnumerable<long>
{
public static readonly long[] Value=A193157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193157.Bytes);
public long this[int i]=>Value[i];

public static A193157Inst Instance=new A193157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193158
{
public static readonly long[] Value={ 0L,1L,37L,10853L,11355309L,57056784509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193158Inst : IEnumerable<long>
{
public static readonly long[] Value=A193158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193158.Bytes);
public long this[int i]=>Value[i];

public static A193158Inst Instance=new A193158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193159
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,10L,11L,12L,13L,14L,20L,23L,24L,26L,28L,29L,40L,52L,56L,58L,104L,116L,232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193159Inst : IEnumerable<long>
{
public static readonly long[] Value=A193159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193159.Bytes);
public long this[int i]=>Value[i];

public static A193159Inst Instance=new A193159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193160
{
public static readonly BigInteger[] Value={ 1L,2L,9L,68L,760L,11664L,233828L,5905696L,182846592L,6792372480L,297550188672L,15153482847744L,886517886778368L,58975120009537536L,4422337095720648960L,BigInteger.Parse("370957479138591903744"),BigInteger.Parse("34576037926690499493888"),BigInteger.Parse("3559813114275891217760256") };
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
public class A193160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193160Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193160.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193160.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193160Inst Instance=new A193160Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193161
{
public static readonly BigInteger[] Value={ 1L,1L,3L,17L,152L,1944L,33404L,738212L,20316288L,679237248L,27050017152L,1262790237312L,68193683598336L,4212508572109824L,294822473048043264L,BigInteger.Parse("23184842446161993984"),BigInteger.Parse("2033884583922970558464"),BigInteger.Parse("197767395237549512097792"),BigInteger.Parse("21194678534706844531458048") };
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
public class A193161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193161Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193161.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193161.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193161Inst Instance=new A193161Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193162
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,76L,671L,7697L,111843L,2008907L,43535348L,1116843468L,33429830141L,1153626512945L,45418011807581L,2021303380235475L,100882231471330500L,5607445909955932548L,BigInteger.Parse("345003931787057849067"),BigInteger.Parse("23367696786768525050769") };
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
public class A193162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193162Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193162.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193162.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193162Inst Instance=new A193162Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193163
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,2L,7L,1L,2L,49L,1L,2L,25L,26L,1L,2L,1L,2L,1L,2L,41282L,1L,2L,145L,40585L,1L,2L,26L,48L,40472L,1L,2L,1L,2L,519326767L,1L,2L,12973363226L,1L,2L,1441L,1442L,1L,2L,2615428934649L,1L,2L,40465L,43153254185213L,43153254226251L,1L,2L,1L,2L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193163Inst : IEnumerable<long>
{
public static readonly long[] Value=A193163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193163.Bytes);
public long this[int i]=>Value[i];

public static A193163Inst Instance=new A193163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193180
{
public static readonly long[] Value={ 2L,1L,5L,8L,5L,6L,1L,2L,2L,6L,1L,1L,5L,1L,8L,2L,0L,1L,1L,8L,1L,4L,9L,7L,1L,0L,5L,7L,1L,6L,2L,7L,8L,3L,0L,3L,2L,9L,7L,7L,4L,0L,9L,9L,4L,8L,6L,4L,4L,6L,5L,1L,7L,2L,4L,4L,4L,0L,3L,0L,9L,4L,4L,9L,5L,8L,7L,1L,6L,9L,0L,4L,3L,0L,1L,6L,5L,7L,3L,5L,8L,7L,8L,5L,3L,0L,5L,5L,7L,5L,3L,8L,7L,2L,4L,9L,5L,9L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193180Inst : IEnumerable<long>
{
public static readonly long[] Value=A193180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193180.Bytes);
public long this[int i]=>Value[i];

public static A193180Inst Instance=new A193180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193181
{
public static readonly BigInteger[] Value={ 2L,10L,10L,170L,2210L,81770L,408850L,408850L,16762850L,1693047850L,103275918850L,2995001646650L,2995001646650L,590015324390050L,66671731656075650L,17134635035611442050UL,17134635035611442050UL,17134635035611442050UL,BigInteger.Parse("3101368941445671011050") };
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
public class A193181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193181Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193181.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193181.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193181Inst Instance=new A193181Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193182
{
public static readonly long[] Value={ 5L,0L,3L,6L,8L,6L,6L,6L,4L,2L,3L,9L,1L,3L,8L,5L,1L,0L,8L,6L,5L,4L,3L,3L,9L,4L,9L,4L,5L,9L,3L,8L,4L,6L,2L,2L,0L,5L,0L,5L,1L,1L,4L,1L,9L,7L,9L,8L,5L,3L,6L,7L,6L,3L,2L,3L,7L,9L,1L,8L,2L,2L,3L,9L,4L,1L,3L,7L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193182Inst : IEnumerable<long>
{
public static readonly long[] Value=A193182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193182.Bytes);
public long this[int i]=>Value[i];

public static A193182Inst Instance=new A193182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193183
{
public static readonly BigInteger[] Value={ 4L,36L,95L,1169L,33801L,2107545L,268584665L,68722397483L,35184451704151L,36028800045063009L,BigInteger.Parse("73786976454230149101"),BigInteger.Parse("302231454915324617869969"),BigInteger.Parse("2475880078571947551781268217"),BigInteger.Parse("40564819207303508564612061601737") };
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
public class A193183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193183Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193183.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193183.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193183Inst Instance=new A193183Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193184
{
public static readonly BigInteger[] Value={ 5L,64L,320L,5000L,191008L,14760960L,2327810048L,744138184192L,482125942079488L,633412084252934144L,BigInteger.Parse("1687400357268217397248"),BigInteger.Parse("9114708361014996399816704"),BigInteger.Parse("99830224938625064018120802304") };
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
public class A193184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193184Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193184.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193184.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193184Inst Instance=new A193184Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193185
{
public static readonly long[] Value={ 6L,140L,2347L,109477L,21391089L,14299793331L,30535534087125L,199765892340671739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193185Inst : IEnumerable<long>
{
public static readonly long[] Value=A193185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193185.Bytes);
public long this[int i]=>Value[i];

public static A193185Inst Instance=new A193185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193186
{
public static readonly long[] Value={ 7L,216L,6258L,405648L,85784844L,49610954646L,76881172019418L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193186Inst : IEnumerable<long>
{
public static readonly long[] Value=A193186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193186.Bytes);
public long this[int i]=>Value[i];

public static A193186Inst Instance=new A193186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193187
{
public static readonly long[] Value={ 8L,364L,24403L,4239509L,3061405317L,9848613098653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193187Inst : IEnumerable<long>
{
public static readonly long[] Value=A193187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193187.Bytes);
public long this[int i]=>Value[i];

public static A193187Inst Instance=new A193187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193188
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,11L,38L,180L,1182L,10990L,145271L,2729980L,72836122L,2755533950L,147695390782L,11209247627416L,1204126434867322L,183035972377206269L,BigInteger.Parse("39363771818346412010"),BigInteger.Parse("11975532663667690562398"),BigInteger.Parse("5153451004764204946993962") };
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
public class A193188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193188Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193188.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193188.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193188Inst Instance=new A193188Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193189
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,21L,143L,1669L,33857L,1193884L,73213398L,7782525256L,1435756825940L,458580933408939L,254032043880526955L,BigInteger.Parse("243538638598143498007"),BigInteger.Parse("404846375019050008264450"),BigInteger.Parse("1164567481729705354758216971"),BigInteger.Parse("5808325975811136555473345566847") };
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
public class A193189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193189Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193189.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193189.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193189Inst Instance=new A193189Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193190
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,35L,394L,8804L,397482L,35759656L,6485002635L,2338622693988L,1698239604693650L,2450945990748440102L,BigInteger.Parse("7121092086085582889354"),BigInteger.Parse("41114705331946969977079884"),BigInteger.Parse("477857552284771772990908082576") };
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
public class A193190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193190Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193190.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193190.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193190Inst Instance=new A193190Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193191
{
public static readonly BigInteger[] Value={ 1L,1L,2L,7L,53L,887L,32679L,2747187L,508394434L,214213272638L,198419328607654L,418226185357910272L,BigInteger.Parse("1937353825293000128681"),BigInteger.Parse("20419649837290401081275737"),BigInteger.Parse("472970434622490946099542458239"),BigInteger.Parse("24925951955494891233466080771797644") };
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
public class A193191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193191Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193191.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193191.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193191Inst Instance=new A193191Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193192
{
public static readonly BigInteger[] Value={ 1L,1L,2L,13L,184L,4725L,188596L,10765407L,829780846L,82924007284L,10420182259194L,1607406366386249L,298555458341808338L,BigInteger.Parse("65711158773953092780"),BigInteger.Parse("16910051487116790543954"),BigInteger.Parse("5030141451818448773854244"),BigInteger.Parse("1712632076858599057432066794") };
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
public class A193192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193192Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193192.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193192.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193192Inst Instance=new A193192Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193193
{
public static readonly BigInteger[] Value={ 1L,1L,3L,22L,334L,8831L,359836L,20845201L,1625007715L,163854289212L,20739421240200L,3218400384155498L,600776969761195428L,BigInteger.Parse("132793055529329858607"),BigInteger.Parse("34298178516935957467888"),BigInteger.Parse("10235014757932193318825335") };
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
public class A193193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193193Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193193.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193193.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193193Inst Instance=new A193193Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193194
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,20L,262L,5367L,158413L,6318384L,326575077L,21199737973L,1687053244236L,161418184139781L,18276066372054109L,2416167457088427950L,BigInteger.Parse("368773198369779785338"),BigInteger.Parse("64348161941454274119082"),BigInteger.Parse("12728047101293068225626576"),BigInteger.Parse("2832615019902477894227329544") };
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
public class A193194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193194Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193194.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193194.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193194Inst Instance=new A193194Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193195
{
public static readonly BigInteger[] Value={ 1L,1L,2L,8L,63L,866L,18444L,559083L,22773527L,1197061138L,78782852673L,6341384941543L,612605031308910L,69931195961966196L,9310803519433216321UL,BigInteger.Parse("1429869869684956113511"),BigInteger.Parse("250857267705012344767575"),BigInteger.Parse("49858270430813771746874366"),BigInteger.Parse("11143529422156562195864991584") };
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
public class A193195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193195Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193195.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193195.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193195Inst Instance=new A193195Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193228
{
public static readonly long[] Value={ 1L,39L,185L,511L,1089L,1991L,3289L,5055L,7361L,10279L,13881L,18239L,23425L,29511L,36569L,44671L,53889L,64295L,75961L,88959L,103361L,119239L,136665L,155711L,176449L,198951L,223289L,249535L,277761L,308039L,340441L,375039L,411905L,451111L,492729L,536831L,583489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193228Inst : IEnumerable<long>
{
public static readonly long[] Value=A193228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193228.Bytes);
public long this[int i]=>Value[i];

public static A193228Inst Instance=new A193228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193229
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,2L,15L,15L,12L,6L,105L,105L,90L,60L,24L,945L,945L,840L,630L,360L,120L,10395L,10395L,9450L,7560L,5040L,2520L,720L,135135L,135135L,124740L,103950L,75600L,45360L,20160L,5040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193229Inst : IEnumerable<long>
{
public static readonly long[] Value=A193229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193229.Bytes);
public long this[int i]=>Value[i];

public static A193229Inst Instance=new A193229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193230
{
public static readonly long[] Value={ 1L,11L,60L,30L,15L,74L,37L,168L,84L,42L,21L,104L,52L,26L,13L,72L,36L,18L,9L,50L,25L,122L,61L,272L,136L,68L,34L,17L,88L,44L,22L,11L,60L,30L,15L,74L,37L,168L,84L,42L,21L,104L,52L,26L,13L,72L,36L,18L,9L,50L,25L,122L,61L,272L,136L,68L,34L,17L,88L,44L,22L,11L,60L,30L,15L,74L,37L,168L,84L,42L,21L,104L,52L,26L,13L,72L,36L,18L,9L,50L,25L,122L,61L,272L,136L,68L,34L,17L,88L,44L,22L,11L,60L,30L,15L,74L,37L,168L,84L,42L,21L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193230Inst : IEnumerable<long>
{
public static readonly long[] Value=A193230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193230.Bytes);
public long this[int i]=>Value[i];

public static A193230Inst Instance=new A193230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193231
{
public static readonly long[] Value={ 0L,1L,3L,2L,5L,4L,6L,7L,15L,14L,12L,13L,10L,11L,9L,8L,17L,16L,18L,19L,20L,21L,23L,22L,30L,31L,29L,28L,27L,26L,24L,25L,51L,50L,48L,49L,54L,55L,53L,52L,60L,61L,63L,62L,57L,56L,58L,59L,34L,35L,33L,32L,39L,38L,36L,37L,45L,44L,46L,47L,40L,41L,43L,42L,85L,84L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193231Inst : IEnumerable<long>
{
public static readonly long[] Value=A193231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193231.Bytes);
public long this[int i]=>Value[i];

public static A193231Inst Instance=new A193231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193232
{
public static readonly long[] Value={ 0L,1L,2L,4L,14L,1L,20L,8L,44L,1L,54L,116L,58L,97L,8L,112L,248L,97L,202L,116L,166L,65L,188L,424L,132L,449L,158L,484L,114L,449L,16L,480L,1008L,449L,914L,484L,894L,449L,804L,40L,796L,65L,966L,116L,938L,1953L,920L,2032L,872L,1953L,858L,1652L,790L,1665L,844L,1352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193232Inst : IEnumerable<long>
{
public static readonly long[] Value=A193232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193232.Bytes);
public long this[int i]=>Value[i];

public static A193232Inst Instance=new A193232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193233
{
public static readonly long[] Value={ 1L,-3L,2L,0L,1L,-12L,63L,-190L,363L,-455L,370L,-180L,40L,0L,1L,-39L,732L,-8806L,76293L,-507084L,2689452L,-11689056L,42424338L,-130362394L,342624075L,-776022242L,1522861581L,-2598606825L,3863562996L,-5007519752L,5652058863L,-5541107684L,4697231261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193233Inst : IEnumerable<long>
{
public static readonly long[] Value=A193233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193233.Bytes);
public long this[int i]=>Value[i];

public static A193233Inst Instance=new A193233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193234
{
public static readonly long[] Value={ 1L,2L,6L,20L,66L,228L,804L,2872L,10374L,37780L,138436L,509832L,1885396L,6996472L,26039592L,97160592L,363332534L,1361320284L,5109306148L,19205627608L,72292274076L,272454449560L,1027979651384L,3882579544656L,14677889406396L,55536827825096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193234Inst : IEnumerable<long>
{
public static readonly long[] Value=A193234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193234.Bytes);
public long this[int i]=>Value[i];

public static A193234Inst Instance=new A193234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193235
{
public static readonly long[] Value={ 1L,2L,6L,20L,62L,204L,684L,2312L,7926L,27436L,95572L,334872L,1178796L,4164984L,14763096L,52471056L,186928422L,667295052L,2386388356L,8547855032L,30661465476L,110125076328L,395989755496L,1425411710064L,5135888179644L,18521445768696L,66847890766152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193235Inst : IEnumerable<long>
{
public static readonly long[] Value=A193235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193235.Bytes);
public long this[int i]=>Value[i];

public static A193235Inst Instance=new A193235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193236
{
public static readonly long[] Value={ 1L,3L,18L,111L,765L,5481L,40581L,306099L,2342034L,18108270L,141176412L,1108011312L,8744143401L,69325981191L,551800999215L,4406974587918L,35300439813735L,283495238613855L,2281964065354899L,18406084773140820L,148734744069134439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193236Inst : IEnumerable<long>
{
public static readonly long[] Value=A193236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193236.Bytes);
public long this[int i]=>Value[i];

public static A193236Inst Instance=new A193236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193237
{
public static readonly long[] Value={ 1L,3L,18L,141L,1125L,9261L,78255L,673137L,5864238L,51592770L,457484382L,4082618376L,36627119109L,330070717935L,2985857903655L,27099681108948L,246666402397287L,2250904657271427L,20586440729350197L,188659279149885810L,1732045683183434379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193237Inst : IEnumerable<long>
{
public static readonly long[] Value=A193237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193237.Bytes);
public long this[int i]=>Value[i];

public static A193237Inst Instance=new A193237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193238
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,2L,2L,1L,2L,1L,2L,1L,1L,1L,1L,2L,2L,1L,2L,1L,2L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,2L,2L,1L,2L,1L,2L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,2L,2L,1L,2L,1L,2L,1L,1L,0L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193238Inst : IEnumerable<long>
{
public static readonly long[] Value=A193238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193238.Bytes);
public long this[int i]=>Value[i];

public static A193238Inst Instance=new A193238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193239
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,1L,6L,1L,6L,1L,0L,1L,0L,1L,4L,-1L,0L,-1L,-1L,1L,4L,-1L,0L,-1L,-1L,5L,0L,1L,0L,1L,6L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,-1L,0L,7L,-1L,1L,6L,7L,0L,1L,-1L,1L,2L,1L,-1L,1L,2L,7L,-1L,-1L,0L,1L,0L,1L,-1L,1L,-1L,1L,-1L,3L,0L,-1L,-1L,9L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193239Inst : IEnumerable<long>
{
public static readonly long[] Value=A193239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193239.Bytes);
public long this[int i]=>Value[i];

public static A193239Inst Instance=new A193239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193240
{
public static readonly long[] Value={ 110L,11101L,10110L,11101011L,1110100111000L,1110001101111L,1100100110101100L,1110011000111111L,1100110101111011100L,1000110010101111L,1111101001000000010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193240Inst : IEnumerable<long>
{
public static readonly long[] Value=A193240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193240.Bytes);
public long this[int i]=>Value[i];

public static A193240Inst Instance=new A193240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193241
{
public static readonly BigInteger[] Value={ 10100L,11100001L,11111011010L,1111110111101L,1111101110011110L,111010001110001001L,BigInteger.Parse("110011110000010000010"),10100101110110101001UL,BigInteger.Parse("1110100101000001111001010000"),BigInteger.Parse("111010111010100100100000111"),BigInteger.Parse("111101010011100000011010100") };
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
public class A193241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193241Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193241.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193241.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193241Inst Instance=new A193241Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193242
{
public static readonly BigInteger[] Value={ 1L,3L,16L,125L,4096L,248832L,113379904L,94931877133L,722204136308736L,9223372036854775808UL,BigInteger.Parse("1117730665547154976408576"),BigInteger.Parse("214633637635011206805784100864"),BigInteger.Parse("397495155639882245867698528490622976") };
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
public class A193242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193242Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193242.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193242.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193242Inst Instance=new A193242Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193243
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193243Inst : IEnumerable<long>
{
public static readonly long[] Value=A193243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193243.Bytes);
public long this[int i]=>Value[i];

public static A193243Inst Instance=new A193243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193260
{
public static readonly long[] Value={ 1L,2L,5L,6L,7L,9L,10L,11L,15L,16L,17L,19L,20L,21L,23L,24L,25L,28L,29L,30L,32L,33L,34L,36L,37L,38L,43L,44L,45L,47L,48L,49L,51L,52L,53L,56L,57L,58L,60L,61L,62L,64L,65L,66L,69L,70L,71L,73L,74L,75L,77L,78L,79L,83L,84L,85L,87L,88L,89L,91L,92L,93L,96L,97L,98L,100L,101L,102L,104L,105L,106L,109L,110L,111L,113L,114L,115L,117L,118L,119L,125L,126L,127L,129L,130L,131L,133L,134L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193260Inst : IEnumerable<long>
{
public static readonly long[] Value=A193260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193260.Bytes);
public long this[int i]=>Value[i];

public static A193260Inst Instance=new A193260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193261
{
public static readonly long[] Value={ 1L,-2L,0L,1L,0L,0L,1L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,2L,0L,0L,0L,0L,0L,-2L,0L,0L,-3L,0L,0L,-1L,0L,0L,4L,0L,0L,4L,0L,0L,1L,0L,0L,-4L,0L,0L,-6L,0L,0L,-1L,0L,0L,5L,0L,0L,8L,0L,0L,1L,0L,0L,-8L,0L,0L,-10L,0L,0L,-2L,0L,0L,11L,0L,0L,14L,0L,0L,4L,0L,0L,-14L,0L,0L,-19L,0L,0L,-4L,0L,0L,17L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193261Inst : IEnumerable<long>
{
public static readonly long[] Value=A193261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193261.Bytes);
public long this[int i]=>Value[i];

public static A193261Inst Instance=new A193261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193262
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,3L,1L,1L,2L,2L,0L,3L,0L,2L,3L,4L,2L,1L,3L,4L,2L,0L,4L,2L,5L,2L,2L,5L,2L,2L,5L,2L,4L,1L,0L,1L,2L,0L,8L,3L,0L,2L,2L,5L,3L,0L,1L,5L,7L,1L,3L,1L,2L,4L,5L,5L,1L,0L,3L,2L,4L,3L,4L,2L,3L,3L,1L,3L,2L,0L,8L,3L,4L,3L,0L,9L,1L,6L,0L,2L,5L,2L,2L,9L,1L,5L,4L,3L,1L,7L,5L,2L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193262Inst : IEnumerable<long>
{
public static readonly long[] Value=A193262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193262.Bytes);
public long this[int i]=>Value[i];

public static A193262Inst Instance=new A193262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193263
{
public static readonly long[] Value={ 1L,1L,-1L,2L,-5L,12L,-26L,52L,-101L,201L,-422L,927L,-2070L,4579L,-9894L,20789L,-42517L,84937L,-166570L,322700L,-622500L,1207056L,-2376168L,4787523L,-9908610L,21021499L,-45404102L,98952388L,-215756156L,467541948L,-1002478352L,2121546013L,-4427208709L,9110572776L,-18503242145L,37135048484L,-73759839074L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193263Inst : IEnumerable<long>
{
public static readonly long[] Value=A193263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193263.Bytes);
public long this[int i]=>Value[i];

public static A193263Inst Instance=new A193263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193264
{
public static readonly BigInteger[] Value={ 1L,2L,18L,324L,9140L,359460L,18408600L,1174201280L,90423766800L,8215991163000L,865420074120800L,104218992780067440L,14188585798246317120UL,BigInteger.Parse("2163608674997595229040"),BigInteger.Parse("366682177870608886473600"),BigInteger.Parse("68611838511981521881152000"),BigInteger.Parse("14093827998013078645611495680") };
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
public class A193264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193264Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193264.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193264.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193264Inst Instance=new A193264Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193265
{
public static readonly BigInteger[] Value={ 1L,1L,6L,81L,1828L,59910L,2629800L,146775160L,10047085200L,821599116300L,78674552192800L,8684916065005620L,1091429676788178240L,BigInteger.Parse("154543476785542516360"),BigInteger.Parse("24445478524707259098240"),BigInteger.Parse("4288239906998845117572000"),BigInteger.Parse("829048705765475214447735040") };
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
public class A193265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193265Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193265.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193265.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193265Inst Instance=new A193265Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193266
{
public static readonly long[] Value={ 2L,8L,10L,20L,38L,40L,58L,70L,98L,100L,110L,160L,170L,188L,190L,220L,308L,350L,380L,538L,568L,598L,628L,640L,680L,688L,698L,740L,748L,818L,850L,968L,1010L,1028L,1048L,1088L,1190L,1228L,1300L,1378L,1420L,1430L,1448L,1528L,1540L,1550L,1568L,1580L,1730L,1738L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193266Inst : IEnumerable<long>
{
public static readonly long[] Value=A193266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193266.Bytes);
public long this[int i]=>Value[i];

public static A193266Inst Instance=new A193266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193267
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,6L,1L,8L,1L,2L,1L,12L,1L,2L,1L,16L,1L,18L,1L,20L,1L,2L,1L,24L,1L,2L,1L,4L,1L,6L,1L,32L,1L,2L,1L,36L,1L,2L,1L,40L,1L,42L,1L,4L,1L,2L,1L,48L,1L,2L,1L,4L,1L,54L,1L,8L,1L,2L,1L,60L,1L,2L,1L,64L,1L,6L,1L,4L,1L,2L,1L,72L,1L,2L,1L,4L,1L,6L,1L,80L,1L,2L,1L,84L,1L,2L,1L,8L,1L,18L,1L,4L,1L,2L,1L,96L,1L,2L,1L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A193267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193267Inst : IEnumerable<long>
{
public static readonly long[] Value=A193267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A193267.Bytes);
public long this[int i]=>Value[i];

public static A193267Inst Instance=new A193267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193268
{
public static readonly BigInteger[] Value={ 1L,2L,12L,108L,1476L,30744L,978696L,47696148L,3562705944L,408229283700L,71800542715032L,19393574332167000L,8047409187443508720L,BigInteger.Parse("5131576344077602362144"),BigInteger.Parse("5029742282540253810124752") };
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
public class A193268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193268Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193268.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193268.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193268Inst Instance=new A193268Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A193269
{
public static readonly BigInteger[] Value={ 1L,2L,32L,1544L,176621L,47206184L,29472402866L,42983827798496L,146444618198769125L,BigInteger.Parse("1165528963636440929600"),BigInteger.Parse("21669813287735290595660642"),BigInteger.Parse("941174635410204103533009279920"),BigInteger.Parse("95492317441878732465782043745326917") };
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
public class A193269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A193269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A193269Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A193269.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A193269.Bytes);
public BigInteger this[int i]=>Value[i];

public static A193269Inst Instance=new A193269Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}