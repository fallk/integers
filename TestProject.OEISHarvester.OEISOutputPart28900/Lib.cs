using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A021829
{
public static readonly long[] Value={ 1L,21L,297L,3577L,39753L,422793L,4384969L,44813769L,454009545L,4575676105L,45971643081L,461011315401L,4617904831177L,46225887853257L,462540273695433L,4627092539587273L,46281069938293449L,462871589543951049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021829Inst : IEnumerable<long>
{
public static readonly long[] Value=A021829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021829.Bytes);
public long this[int i]=>Value[i];

public static A021829Inst Instance=new A021829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021828
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,3L,5L,9L,2L,2L,3L,3L,0L,0L,9L,7L,0L,8L,7L,3L,7L,8L,6L,4L,0L,7L,7L,6L,6L,9L,9L,0L,2L,9L,1L,2L,6L,2L,1L,3L,5L,9L,2L,2L,3L,3L,0L,0L,9L,7L,0L,8L,7L,3L,7L,8L,6L,4L,0L,7L,7L,6L,6L,9L,9L,0L,2L,9L,1L,2L,6L,2L,1L,3L,5L,9L,2L,2L,3L,3L,0L,0L,9L,7L,0L,8L,7L,3L,7L,8L,6L,4L,0L,7L,7L,6L,6L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021828Inst : IEnumerable<long>
{
public static readonly long[] Value=A021828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021828.Bytes);
public long this[int i]=>Value[i];

public static A021828Inst Instance=new A021828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021827
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,5L,0L,6L,6L,8L,2L,8L,6L,7L,5L,5L,7L,7L,1L,5L,6L,7L,4L,3L,6L,2L,0L,8L,9L,9L,1L,4L,9L,4L,5L,3L,2L,1L,9L,9L,2L,7L,0L,9L,5L,9L,9L,0L,2L,7L,9L,4L,6L,5L,3L,7L,0L,5L,9L,5L,3L,8L,2L,7L,4L,6L,0L,5L,1L,0L,3L,2L,8L,0L,6L,8L,0L,4L,3L,7L,4L,2L,4L,0L,5L,8L,3L,2L,3L,2L,0L,7L,7L,7L,6L,4L,2L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021827Inst : IEnumerable<long>
{
public static readonly long[] Value=A021827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021827.Bytes);
public long this[int i]=>Value[i];

public static A021827Inst Instance=new A021827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021826
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,6L,5L,4L,5L,0L,1L,2L,1L,6L,5L,4L,5L,0L,1L,2L,1L,6L,5L,4L,5L,0L,1L,2L,1L,6L,5L,4L,5L,0L,1L,2L,1L,6L,5L,4L,5L,0L,1L,2L,1L,6L,5L,4L,5L,0L,1L,2L,1L,6L,5L,4L,5L,0L,1L,2L,1L,6L,5L,4L,5L,0L,1L,2L,1L,6L,5L,4L,5L,0L,1L,2L,1L,6L,5L,4L,5L,0L,1L,2L,1L,6L,5L,4L,5L,0L,1L,2L,1L,6L,5L,4L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021826Inst : IEnumerable<long>
{
public static readonly long[] Value=A021826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021826.Bytes);
public long this[int i]=>Value[i];

public static A021826Inst Instance=new A021826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021825
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,8L,0L,2L,6L,7L,9L,6L,5L,8L,9L,5L,2L,4L,9L,6L,9L,5L,4L,9L,3L,3L,0L,0L,8L,5L,2L,6L,1L,8L,7L,5L,7L,6L,1L,2L,6L,6L,7L,4L,7L,8L,6L,8L,4L,5L,3L,1L,0L,5L,9L,6L,8L,3L,3L,1L,3L,0L,3L,2L,8L,8L,6L,7L,2L,3L,5L,0L,7L,9L,1L,7L,1L,7L,4L,1L,7L,7L,8L,3L,1L,9L,1L,2L,3L,0L,2L,0L,7L,0L,6L,4L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021825Inst : IEnumerable<long>
{
public static readonly long[] Value=A021825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021825.Bytes);
public long this[int i]=>Value[i];

public static A021825Inst Instance=new A021825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021824
{
public static readonly long[] Value={ 1L,20L,267L,3010L,31073L,304920L,2901319L,27075950L,249555405L,2281579300L,20749095731L,188036746170L,1700122392697L,15347941075760L,138412864844703L,1247405586235270L,11236794818538149L,101192043527859900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021824Inst : IEnumerable<long>
{
public static readonly long[] Value=A021824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021824.Bytes);
public long this[int i]=>Value[i];

public static A021824Inst Instance=new A021824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021823
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021823Inst : IEnumerable<long>
{
public static readonly long[] Value=A021823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021823.Bytes);
public long this[int i]=>Value[i];

public static A021823Inst Instance=new A021823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021822
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,2L,4L,9L,3L,8L,8L,7L,5L,3L,0L,5L,6L,2L,3L,4L,7L,1L,8L,8L,2L,6L,4L,0L,5L,8L,6L,7L,9L,7L,0L,6L,6L,0L,1L,4L,6L,6L,9L,9L,2L,6L,6L,5L,0L,3L,6L,6L,7L,4L,8L,1L,6L,6L,2L,5L,9L,1L,6L,8L,7L,0L,4L,1L,5L,6L,4L,7L,9L,2L,1L,7L,6L,0L,3L,9L,1L,1L,9L,8L,0L,4L,4L,0L,0L,9L,7L,7L,9L,9L,5L,1L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021822Inst : IEnumerable<long>
{
public static readonly long[] Value=A021822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021822.Bytes);
public long this[int i]=>Value[i];

public static A021822Inst Instance=new A021822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021821
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,3L,9L,9L,0L,2L,0L,8L,0L,7L,8L,3L,3L,5L,3L,7L,3L,3L,1L,7L,0L,1L,3L,4L,6L,3L,8L,9L,2L,2L,8L,8L,8L,6L,1L,6L,8L,9L,1L,0L,6L,4L,8L,7L,1L,4L,8L,1L,0L,2L,8L,1L,5L,1L,7L,7L,4L,7L,8L,5L,8L,0L,1L,7L,1L,3L,5L,8L,6L,2L,9L,1L,3L,0L,9L,6L,6L,9L,5L,2L,2L,6L,4L,3L,8L,1L,8L,8L,4L,9L,4L,4L,9L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021821Inst : IEnumerable<long>
{
public static readonly long[] Value=A021821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021821.Bytes);
public long this[int i]=>Value[i];

public static A021821Inst Instance=new A021821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021804
{
public static readonly long[] Value={ 1L,18L,213L,2098L,18669L,155946L,1248661L,9704706L,73804797L,552214234L,4080381669L,29857556274L,216794571085L,1564401539082L,11232205936437L,80315244188002L,572351251736733L,4067348923173690L,28836875054284165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021804Inst : IEnumerable<long>
{
public static readonly long[] Value=A021804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021804.Bytes);
public long this[int i]=>Value[i];

public static A021804Inst Instance=new A021804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021803
{
public static readonly long[] Value={ 0L,0L,1L,2L,5L,1L,5L,6L,4L,4L,5L,5L,5L,6L,9L,4L,6L,1L,8L,2L,7L,2L,8L,4L,1L,0L,5L,1L,3L,1L,4L,1L,4L,2L,6L,7L,8L,3L,4L,7L,9L,3L,4L,9L,1L,8L,6L,4L,8L,3L,1L,0L,3L,8L,7L,9L,8L,4L,9L,8L,1L,2L,2L,6L,5L,3L,3L,1L,6L,6L,4L,5L,8L,0L,7L,2L,5L,9L,0L,7L,3L,8L,4L,2L,3L,0L,2L,8L,7L,8L,5L,9L,8L,2L,4L,7L,8L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021803Inst : IEnumerable<long>
{
public static readonly long[] Value=A021803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021803.Bytes);
public long this[int i]=>Value[i];

public static A021803Inst Instance=new A021803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021802
{
public static readonly long[] Value={ 0L,0L,1L,2L,5L,3L,1L,3L,2L,8L,3L,2L,0L,8L,0L,2L,0L,0L,5L,0L,1L,2L,5L,3L,1L,3L,2L,8L,3L,2L,0L,8L,0L,2L,0L,0L,5L,0L,1L,2L,5L,3L,1L,3L,2L,8L,3L,2L,0L,8L,0L,2L,0L,0L,5L,0L,1L,2L,5L,3L,1L,3L,2L,8L,3L,2L,0L,8L,0L,2L,0L,0L,5L,0L,1L,2L,5L,3L,1L,3L,2L,8L,3L,2L,0L,8L,0L,2L,0L,0L,5L,0L,1L,2L,5L,3L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021802Inst : IEnumerable<long>
{
public static readonly long[] Value=A021802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021802.Bytes);
public long this[int i]=>Value[i];

public static A021802Inst Instance=new A021802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021801
{
public static readonly long[] Value={ 0L,0L,1L,2L,5L,4L,7L,0L,5L,1L,4L,4L,2L,9L,1L,0L,9L,1L,5L,9L,3L,4L,7L,5L,5L,3L,3L,2L,4L,9L,6L,8L,6L,3L,2L,3L,7L,1L,3L,9L,2L,7L,2L,2L,7L,1L,0L,1L,6L,3L,1L,1L,1L,6L,6L,8L,7L,5L,7L,8L,4L,1L,9L,0L,7L,1L,5L,1L,8L,1L,9L,3L,2L,2L,4L,5L,9L,2L,2L,2L,0L,8L,2L,8L,1L,0L,5L,3L,9L,5L,2L,3L,2L,1L,2L,0L,4L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021801Inst : IEnumerable<long>
{
public static readonly long[] Value=A021801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021801.Bytes);
public long this[int i]=>Value[i];

public static A021801Inst Instance=new A021801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021800
{
public static readonly long[] Value={ 0L,0L,1L,2L,5L,6L,2L,8L,1L,4L,0L,7L,0L,3L,5L,1L,7L,5L,8L,7L,9L,3L,9L,6L,9L,8L,4L,9L,2L,4L,6L,2L,3L,1L,1L,5L,5L,7L,7L,8L,8L,9L,4L,4L,7L,2L,3L,6L,1L,8L,0L,9L,0L,4L,5L,2L,2L,6L,1L,3L,0L,6L,5L,3L,2L,6L,6L,3L,3L,1L,6L,5L,8L,2L,9L,1L,4L,5L,7L,2L,8L,6L,4L,3L,2L,1L,6L,0L,8L,0L,4L,0L,2L,0L,1L,0L,0L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021800Inst : IEnumerable<long>
{
public static readonly long[] Value=A021800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021800.Bytes);
public long this[int i]=>Value[i];

public static A021800Inst Instance=new A021800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021799
{
public static readonly long[] Value={ 0L,0L,1L,2L,5L,7L,8L,6L,1L,6L,3L,5L,2L,2L,0L,1L,2L,5L,7L,8L,6L,1L,6L,3L,5L,2L,2L,0L,1L,2L,5L,7L,8L,6L,1L,6L,3L,5L,2L,2L,0L,1L,2L,5L,7L,8L,6L,1L,6L,3L,5L,2L,2L,0L,1L,2L,5L,7L,8L,6L,1L,6L,3L,5L,2L,2L,0L,1L,2L,5L,7L,8L,6L,1L,6L,3L,5L,2L,2L,0L,1L,2L,5L,7L,8L,6L,1L,6L,3L,5L,2L,2L,0L,1L,2L,5L,7L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021799Inst : IEnumerable<long>
{
public static readonly long[] Value=A021799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021799.Bytes);
public long this[int i]=>Value[i];

public static A021799Inst Instance=new A021799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021798
{
public static readonly long[] Value={ 0L,0L,1L,2L,5L,9L,4L,4L,5L,8L,4L,3L,8L,2L,8L,7L,1L,5L,3L,6L,5L,2L,3L,9L,2L,9L,4L,7L,1L,0L,3L,2L,7L,4L,5L,5L,9L,1L,9L,3L,9L,5L,4L,6L,5L,9L,9L,4L,9L,6L,2L,2L,1L,6L,6L,2L,4L,6L,8L,5L,1L,3L,8L,5L,3L,9L,0L,4L,2L,8L,2L,1L,1L,5L,8L,6L,9L,0L,1L,7L,6L,3L,2L,2L,4L,1L,8L,1L,3L,6L,0L,2L,0L,1L,5L,1L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021798Inst : IEnumerable<long>
{
public static readonly long[] Value=A021798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021798.Bytes);
public long this[int i]=>Value[i];

public static A021798Inst Instance=new A021798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021797
{
public static readonly long[] Value={ 0L,0L,1L,2L,6L,1L,0L,3L,4L,0L,4L,7L,9L,1L,9L,2L,9L,3L,8L,2L,0L,9L,3L,3L,1L,6L,5L,1L,9L,5L,4L,6L,0L,2L,7L,7L,4L,2L,7L,4L,9L,0L,5L,4L,2L,2L,4L,4L,6L,4L,0L,6L,0L,5L,2L,9L,6L,3L,4L,3L,0L,0L,1L,2L,6L,1L,0L,3L,4L,0L,4L,7L,9L,1L,9L,2L,9L,3L,8L,2L,0L,9L,3L,3L,1L,6L,5L,1L,9L,5L,4L,6L,0L,2L,7L,7L,4L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021797Inst : IEnumerable<long>
{
public static readonly long[] Value=A021797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021797.Bytes);
public long this[int i]=>Value[i];

public static A021797Inst Instance=new A021797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021796
{
public static readonly long[] Value={ 0L,0L,1L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021796Inst : IEnumerable<long>
{
public static readonly long[] Value=A021796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021796.Bytes);
public long this[int i]=>Value[i];

public static A021796Inst Instance=new A021796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021795
{
public static readonly long[] Value={ 0L,0L,1L,2L,6L,4L,2L,2L,2L,5L,0L,3L,1L,6L,0L,5L,5L,6L,2L,5L,7L,9L,0L,1L,3L,9L,0L,6L,4L,4L,7L,5L,3L,4L,7L,6L,6L,1L,1L,8L,8L,3L,6L,9L,1L,5L,2L,9L,7L,0L,9L,2L,2L,8L,8L,2L,4L,2L,7L,3L,0L,7L,2L,0L,6L,0L,6L,8L,2L,6L,8L,0L,1L,5L,1L,7L,0L,6L,7L,0L,0L,3L,7L,9L,2L,6L,6L,7L,5L,0L,9L,4L,8L,1L,6L,6L,8L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021795Inst : IEnumerable<long>
{
public static readonly long[] Value=A021795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021795.Bytes);
public long this[int i]=>Value[i];

public static A021795Inst Instance=new A021795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021794
{
public static readonly long[] Value={ 1L,22L,335L,4460L,56061L,686802L,8317435L,100210120L,1204613321L,14466168782L,173649468135L,2084076423780L,25010353485781L,300131513309962L,3601614875036435L,43219563508677440L,518635692871953441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021794Inst : IEnumerable<long>
{
public static readonly long[] Value=A021794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021794.Bytes);
public long this[int i]=>Value[i];

public static A021794Inst Instance=new A021794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021793
{
public static readonly long[] Value={ 0L,0L,1L,2L,6L,7L,4L,2L,7L,1L,2L,2L,9L,4L,0L,4L,3L,0L,9L,2L,5L,2L,2L,1L,7L,9L,9L,7L,4L,6L,5L,1L,4L,5L,7L,5L,4L,1L,1L,9L,1L,3L,8L,1L,4L,9L,5L,5L,6L,4L,0L,0L,5L,0L,6L,9L,7L,0L,8L,4L,9L,1L,7L,6L,1L,7L,2L,3L,7L,0L,0L,8L,8L,7L,1L,9L,8L,9L,8L,6L,0L,5L,8L,3L,0L,1L,6L,4L,7L,6L,5L,5L,2L,5L,9L,8L,2L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021793Inst : IEnumerable<long>
{
public static readonly long[] Value=A021793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021793.Bytes);
public long this[int i]=>Value[i];

public static A021793Inst Instance=new A021793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021792
{
public static readonly long[] Value={ 0L,0L,1L,2L,6L,9L,0L,3L,5L,5L,3L,2L,9L,9L,4L,9L,2L,3L,8L,5L,7L,8L,6L,8L,0L,2L,0L,3L,0L,4L,5L,6L,8L,5L,2L,7L,9L,1L,8L,7L,8L,1L,7L,2L,5L,8L,8L,8L,3L,2L,4L,8L,7L,3L,0L,9L,6L,4L,4L,6L,7L,0L,0L,5L,0L,7L,6L,1L,4L,2L,1L,3L,1L,9L,7L,9L,6L,9L,5L,4L,3L,1L,4L,7L,2L,0L,8L,1L,2L,1L,8L,2L,7L,4L,1L,1L,1L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021792Inst : IEnumerable<long>
{
public static readonly long[] Value=A021792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021792.Bytes);
public long this[int i]=>Value[i];

public static A021792Inst Instance=new A021792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021791
{
public static readonly long[] Value={ 0L,0L,1L,2L,7L,0L,6L,4L,8L,0L,3L,0L,4L,9L,5L,5L,5L,2L,7L,3L,1L,8L,9L,3L,2L,6L,5L,5L,6L,5L,4L,3L,8L,3L,7L,3L,5L,7L,0L,5L,2L,0L,9L,6L,5L,6L,9L,2L,5L,0L,3L,1L,7L,6L,6L,2L,0L,0L,7L,6L,2L,3L,8L,8L,8L,1L,8L,2L,9L,7L,3L,3L,1L,6L,3L,9L,1L,3L,5L,9L,5L,9L,3L,3L,9L,2L,6L,3L,0L,2L,4L,1L,4L,2L,3L,1L,2L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021791Inst : IEnumerable<long>
{
public static readonly long[] Value=A021791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021791.Bytes);
public long this[int i]=>Value[i];

public static A021791Inst Instance=new A021791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021790
{
public static readonly long[] Value={ 0L,0L,1L,2L,7L,2L,2L,6L,4L,6L,3L,1L,0L,4L,3L,2L,5L,6L,9L,9L,7L,4L,5L,5L,4L,7L,0L,7L,3L,7L,9L,1L,3L,4L,8L,6L,0L,0L,5L,0L,8L,9L,0L,5L,8L,5L,2L,4L,1L,7L,3L,0L,2L,7L,9L,8L,9L,8L,2L,1L,8L,8L,2L,9L,5L,1L,6L,5L,3L,9L,4L,4L,0L,2L,0L,3L,5L,6L,2L,3L,4L,0L,9L,6L,6L,9L,2L,1L,1L,1L,9L,5L,9L,2L,8L,7L,5L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021790Inst : IEnumerable<long>
{
public static readonly long[] Value=A021790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021790.Bytes);
public long this[int i]=>Value[i];

public static A021790Inst Instance=new A021790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021789
{
public static readonly long[] Value={ 0L,0L,1L,2L,7L,3L,8L,8L,5L,3L,5L,0L,3L,1L,8L,4L,7L,1L,3L,3L,7L,5L,7L,9L,6L,1L,7L,8L,3L,4L,3L,9L,4L,9L,0L,4L,4L,5L,8L,5L,9L,8L,7L,2L,6L,1L,1L,4L,6L,4L,9L,6L,8L,1L,5L,2L,8L,6L,6L,2L,4L,2L,0L,3L,8L,2L,1L,6L,5L,6L,0L,5L,0L,9L,5L,5L,4L,1L,4L,0L,1L,2L,7L,3L,8L,8L,5L,3L,5L,0L,3L,1L,8L,4L,7L,1L,3L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021789Inst : IEnumerable<long>
{
public static readonly long[] Value=A021789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021789.Bytes);
public long this[int i]=>Value[i];

public static A021789Inst Instance=new A021789Inst();

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

public static class A021645
{
public static readonly long[] Value={ 0L,0L,1L,5L,6L,0L,0L,6L,2L,4L,0L,2L,4L,9L,6L,0L,9L,9L,8L,4L,3L,9L,9L,3L,7L,5L,9L,7L,5L,0L,3L,9L,0L,0L,1L,5L,6L,0L,0L,6L,2L,4L,0L,2L,4L,9L,6L,0L,9L,9L,8L,4L,3L,9L,9L,3L,7L,5L,9L,7L,5L,0L,3L,9L,0L,0L,1L,5L,6L,0L,0L,6L,2L,4L,0L,2L,4L,9L,6L,0L,9L,9L,8L,4L,3L,9L,9L,3L,7L,5L,9L,7L,5L,0L,3L,9L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021645Inst : IEnumerable<long>
{
public static readonly long[] Value=A021645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021645.Bytes);
public long this[int i]=>Value[i];

public static A021645Inst Instance=new A021645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021644
{
public static readonly long[] Value={ 1L,22L,329L,4202L,49437L,554070L,6019393L,64026754L,670939973L,6954808718L,71511447657L,730821626106L,7433874254509L,75344008884166L,761482226728721L,7679159391907058L,77306290980599445L,777180486491935614L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021644Inst : IEnumerable<long>
{
public static readonly long[] Value=A021644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021644.Bytes);
public long this[int i]=>Value[i];

public static A021644Inst Instance=new A021644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021643
{
public static readonly long[] Value={ 0L,0L,1L,5L,6L,4L,9L,4L,5L,2L,2L,6L,9L,1L,7L,0L,5L,7L,9L,0L,2L,9L,7L,3L,3L,9L,5L,9L,3L,1L,1L,4L,2L,4L,1L,0L,0L,1L,5L,6L,4L,9L,4L,5L,2L,2L,6L,9L,1L,7L,0L,5L,7L,9L,0L,2L,9L,7L,3L,3L,9L,5L,9L,3L,1L,1L,4L,2L,4L,1L,0L,0L,1L,5L,6L,4L,9L,4L,5L,2L,2L,6L,9L,1L,7L,0L,5L,7L,9L,0L,2L,9L,7L,3L,3L,9L,5L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021643Inst : IEnumerable<long>
{
public static readonly long[] Value=A021643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021643.Bytes);
public long this[int i]=>Value[i];

public static A021643Inst Instance=new A021643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021642
{
public static readonly long[] Value={ 0L,0L,1L,5L,6L,7L,3L,9L,8L,1L,1L,9L,1L,2L,2L,2L,5L,7L,0L,5L,3L,2L,9L,1L,5L,3L,6L,0L,5L,0L,1L,5L,6L,7L,3L,9L,8L,1L,1L,9L,1L,2L,2L,2L,5L,7L,0L,5L,3L,2L,9L,1L,5L,3L,6L,0L,5L,0L,1L,5L,6L,7L,3L,9L,8L,1L,1L,9L,1L,2L,2L,2L,5L,7L,0L,5L,3L,2L,9L,1L,5L,3L,6L,0L,5L,0L,1L,5L,6L,7L,3L,9L,8L,1L,1L,9L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021642Inst : IEnumerable<long>
{
public static readonly long[] Value=A021642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021642.Bytes);
public long this[int i]=>Value[i];

public static A021642Inst Instance=new A021642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021641
{
public static readonly long[] Value={ 0L,0L,1L,5L,6L,9L,8L,5L,8L,7L,1L,2L,7L,1L,5L,8L,5L,5L,5L,7L,2L,9L,9L,8L,4L,3L,0L,1L,4L,1L,2L,8L,7L,2L,8L,4L,1L,4L,4L,4L,2L,7L,0L,0L,1L,5L,6L,9L,8L,5L,8L,7L,1L,2L,7L,1L,5L,8L,5L,5L,5L,7L,2L,9L,9L,8L,4L,3L,0L,1L,4L,1L,2L,8L,7L,2L,8L,4L,1L,4L,4L,4L,2L,7L,0L,0L,1L,5L,6L,9L,8L,5L,8L,7L,1L,2L,7L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021641Inst : IEnumerable<long>
{
public static readonly long[] Value=A021641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021641.Bytes);
public long this[int i]=>Value[i];

public static A021641Inst Instance=new A021641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021640
{
public static readonly long[] Value={ 0L,0L,1L,5L,7L,2L,3L,2L,7L,0L,4L,4L,0L,2L,5L,1L,5L,7L,2L,3L,2L,7L,0L,4L,4L,0L,2L,5L,1L,5L,7L,2L,3L,2L,7L,0L,4L,4L,0L,2L,5L,1L,5L,7L,2L,3L,2L,7L,0L,4L,4L,0L,2L,5L,1L,5L,7L,2L,3L,2L,7L,0L,4L,4L,0L,2L,5L,1L,5L,7L,2L,3L,2L,7L,0L,4L,4L,0L,2L,5L,1L,5L,7L,2L,3L,2L,7L,0L,4L,4L,0L,2L,5L,1L,5L,7L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021640Inst : IEnumerable<long>
{
public static readonly long[] Value=A021640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021640.Bytes);
public long this[int i]=>Value[i];

public static A021640Inst Instance=new A021640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021639
{
public static readonly long[] Value={ 0L,0L,1L,5L,7L,4L,8L,0L,3L,1L,4L,9L,6L,0L,6L,2L,9L,9L,2L,1L,2L,5L,9L,8L,4L,2L,5L,1L,9L,6L,8L,5L,0L,3L,9L,3L,7L,0L,0L,7L,8L,7L,4L,0L,1L,5L,7L,4L,8L,0L,3L,1L,4L,9L,6L,0L,6L,2L,9L,9L,2L,1L,2L,5L,9L,8L,4L,2L,5L,1L,9L,6L,8L,5L,0L,3L,9L,3L,7L,0L,0L,7L,8L,7L,4L,0L,1L,5L,7L,4L,8L,0L,3L,1L,4L,9L,6L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021639Inst : IEnumerable<long>
{
public static readonly long[] Value=A021639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021639.Bytes);
public long this[int i]=>Value[i];

public static A021639Inst Instance=new A021639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021638
{
public static readonly long[] Value={ 0L,0L,1L,5L,7L,7L,2L,8L,7L,0L,6L,6L,2L,4L,6L,0L,5L,6L,7L,8L,2L,3L,3L,4L,3L,8L,4L,8L,5L,8L,0L,4L,4L,1L,6L,4L,0L,3L,7L,8L,5L,4L,8L,8L,9L,5L,8L,9L,9L,0L,5L,3L,6L,2L,7L,7L,6L,0L,2L,5L,2L,3L,6L,5L,9L,3L,0L,5L,9L,9L,3L,6L,9L,0L,8L,5L,1L,7L,3L,5L,0L,1L,5L,7L,7L,2L,8L,7L,0L,6L,6L,2L,4L,6L,0L,5L,6L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021638Inst : IEnumerable<long>
{
public static readonly long[] Value=A021638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021638.Bytes);
public long this[int i]=>Value[i];

public static A021638Inst Instance=new A021638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021637
{
public static readonly long[] Value={ 0L,0L,1L,5L,7L,9L,7L,7L,8L,8L,3L,0L,9L,6L,3L,6L,6L,5L,0L,8L,6L,8L,8L,7L,8L,3L,5L,7L,0L,3L,0L,0L,1L,5L,7L,9L,7L,7L,8L,8L,3L,0L,9L,6L,3L,6L,6L,5L,0L,8L,6L,8L,8L,7L,8L,3L,5L,7L,0L,3L,0L,0L,1L,5L,7L,9L,7L,7L,8L,8L,3L,0L,9L,6L,3L,6L,6L,5L,0L,8L,6L,8L,8L,7L,8L,3L,5L,7L,0L,3L,0L,0L,1L,5L,7L,9L,7L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021637Inst : IEnumerable<long>
{
public static readonly long[] Value=A021637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021637.Bytes);
public long this[int i]=>Value[i];

public static A021637Inst Instance=new A021637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021636
{
public static readonly long[] Value={ 0L,0L,1L,5L,8L,2L,2L,7L,8L,4L,8L,1L,0L,1L,2L,6L,5L,8L,2L,2L,7L,8L,4L,8L,1L,0L,1L,2L,6L,5L,8L,2L,2L,7L,8L,4L,8L,1L,0L,1L,2L,6L,5L,8L,2L,2L,7L,8L,4L,8L,1L,0L,1L,2L,6L,5L,8L,2L,2L,7L,8L,4L,8L,1L,0L,1L,2L,6L,5L,8L,2L,2L,7L,8L,4L,8L,1L,0L,1L,2L,6L,5L,8L,2L,2L,7L,8L,4L,8L,1L,0L,1L,2L,6L,5L,8L,2L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021636Inst : IEnumerable<long>
{
public static readonly long[] Value=A021636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021636.Bytes);
public long this[int i]=>Value[i];

public static A021636Inst Instance=new A021636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021635
{
public static readonly long[] Value={ 0L,0L,1L,5L,8L,4L,7L,8L,6L,0L,5L,3L,8L,8L,2L,7L,2L,5L,8L,3L,2L,0L,1L,2L,6L,7L,8L,2L,8L,8L,4L,3L,1L,0L,6L,1L,8L,0L,6L,6L,5L,6L,1L,0L,1L,4L,2L,6L,3L,0L,7L,4L,4L,8L,4L,9L,4L,4L,5L,3L,2L,4L,8L,8L,1L,1L,4L,1L,0L,4L,5L,9L,5L,8L,7L,9L,5L,5L,6L,2L,5L,9L,9L,0L,4L,9L,1L,2L,8L,3L,6L,7L,6L,7L,0L,3L,6L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021635Inst : IEnumerable<long>
{
public static readonly long[] Value=A021635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021635.Bytes);
public long this[int i]=>Value[i];

public static A021635Inst Instance=new A021635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021634
{
public static readonly long[] Value={ 1L,21L,298L,3594L,39763L,417567L,4236796L,41963988L,408348325L,3920543913L,37248255694L,350941450782L,3284131050487L,30562445793459L,283104150028192L,2612274474873576L,24025167335391049L,220344082704460605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021634Inst : IEnumerable<long>
{
public static readonly long[] Value=A021634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021634.Bytes);
public long this[int i]=>Value[i];

public static A021634Inst Instance=new A021634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021633
{
public static readonly long[] Value={ 0L,0L,1L,5L,8L,9L,8L,2L,5L,1L,1L,9L,2L,3L,6L,8L,8L,3L,9L,4L,2L,7L,6L,6L,2L,9L,5L,7L,0L,7L,4L,7L,2L,1L,7L,8L,0L,6L,0L,4L,1L,3L,3L,5L,4L,5L,3L,1L,0L,0L,1L,5L,8L,9L,8L,2L,5L,1L,1L,9L,2L,3L,6L,8L,8L,3L,9L,4L,2L,7L,6L,6L,2L,9L,5L,7L,0L,7L,4L,7L,2L,1L,7L,8L,0L,6L,0L,4L,1L,3L,3L,5L,4L,5L,3L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021633Inst : IEnumerable<long>
{
public static readonly long[] Value=A021633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021633.Bytes);
public long this[int i]=>Value[i];

public static A021633Inst Instance=new A021633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021632
{
public static readonly long[] Value={ 0L,0L,1L,5L,9L,2L,3L,5L,6L,6L,8L,7L,8L,9L,8L,0L,8L,9L,1L,7L,1L,9L,7L,4L,5L,2L,2L,2L,9L,2L,9L,9L,3L,6L,3L,0L,5L,7L,3L,2L,4L,8L,4L,0L,7L,6L,4L,3L,3L,1L,2L,1L,0L,1L,9L,1L,0L,8L,2L,8L,0L,2L,5L,4L,7L,7L,7L,0L,7L,0L,0L,6L,3L,6L,9L,4L,2L,6L,7L,5L,1L,5L,9L,2L,3L,5L,6L,6L,8L,7L,8L,9L,8L,0L,8L,9L,1L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021632Inst : IEnumerable<long>
{
public static readonly long[] Value=A021632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021632.Bytes);
public long this[int i]=>Value[i];

public static A021632Inst Instance=new A021632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021631
{
public static readonly long[] Value={ 0L,0L,1L,5L,9L,4L,8L,9L,6L,3L,3L,1L,7L,3L,8L,4L,3L,7L,0L,0L,1L,5L,9L,4L,8L,9L,6L,3L,3L,1L,7L,3L,8L,4L,3L,7L,0L,0L,1L,5L,9L,4L,8L,9L,6L,3L,3L,1L,7L,3L,8L,4L,3L,7L,0L,0L,1L,5L,9L,4L,8L,9L,6L,3L,3L,1L,7L,3L,8L,4L,3L,7L,0L,0L,1L,5L,9L,4L,8L,9L,6L,3L,3L,1L,7L,3L,8L,4L,3L,7L,0L,0L,1L,5L,9L,4L,8L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021631Inst : IEnumerable<long>
{
public static readonly long[] Value=A021631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021631.Bytes);
public long this[int i]=>Value[i];

public static A021631Inst Instance=new A021631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021630
{
public static readonly long[] Value={ 0L,0L,1L,5L,9L,7L,4L,4L,4L,0L,8L,9L,4L,5L,6L,8L,6L,9L,0L,0L,9L,5L,8L,4L,6L,6L,4L,5L,3L,6L,7L,4L,1L,2L,1L,4L,0L,5L,7L,5L,0L,7L,9L,8L,7L,2L,2L,0L,4L,4L,7L,2L,8L,4L,3L,4L,5L,0L,4L,7L,9L,2L,3L,3L,2L,2L,6L,8L,3L,7L,0L,6L,0L,7L,0L,2L,8L,7L,5L,3L,9L,9L,3L,6L,1L,0L,2L,2L,3L,6L,4L,2L,1L,7L,2L,5L,2L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021630Inst : IEnumerable<long>
{
public static readonly long[] Value=A021630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021630.Bytes);
public long this[int i]=>Value[i];

public static A021630Inst Instance=new A021630Inst();

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

public static class A021612
{
public static readonly long[] Value={ 0L,0L,1L,6L,4L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021612Inst : IEnumerable<long>
{
public static readonly long[] Value=A021612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021612.Bytes);
public long this[int i]=>Value[i];

public static A021612Inst Instance=new A021612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021611
{
public static readonly long[] Value={ 0L,0L,1L,6L,4L,7L,4L,4L,6L,4L,5L,7L,9L,9L,0L,1L,1L,5L,3L,2L,1L,2L,5L,2L,0L,5L,9L,3L,0L,8L,0L,7L,2L,4L,8L,7L,6L,4L,4L,1L,5L,1L,5L,6L,5L,0L,7L,4L,1L,3L,5L,0L,9L,0L,6L,0L,9L,5L,5L,5L,1L,8L,9L,4L,5L,6L,3L,4L,2L,6L,6L,8L,8L,6L,3L,2L,6L,1L,9L,4L,3L,9L,8L,6L,8L,2L,0L,4L,2L,8L,3L,3L,6L,0L,7L,9L,0L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021611Inst : IEnumerable<long>
{
public static readonly long[] Value=A021611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021611.Bytes);
public long this[int i]=>Value[i];

public static A021611Inst Instance=new A021611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021610
{
public static readonly long[] Value={ 0L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021610Inst : IEnumerable<long>
{
public static readonly long[] Value=A021610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021610.Bytes);
public long this[int i]=>Value[i];

public static A021610Inst Instance=new A021610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021609
{
public static readonly long[] Value={ 0L,0L,1L,6L,5L,2L,8L,9L,2L,5L,6L,1L,9L,8L,3L,4L,7L,1L,0L,7L,4L,3L,8L,0L,1L,6L,5L,2L,8L,9L,2L,5L,6L,1L,9L,8L,3L,4L,7L,1L,0L,7L,4L,3L,8L,0L,1L,6L,5L,2L,8L,9L,2L,5L,6L,1L,9L,8L,3L,4L,7L,1L,0L,7L,4L,3L,8L,0L,1L,6L,5L,2L,8L,9L,2L,5L,6L,1L,9L,8L,3L,4L,7L,1L,0L,7L,4L,3L,8L,0L,1L,6L,5L,2L,8L,9L,2L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021609Inst : IEnumerable<long>
{
public static readonly long[] Value=A021609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021609.Bytes);
public long this[int i]=>Value[i];

public static A021609Inst Instance=new A021609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021608
{
public static readonly long[] Value={ 0L,0L,1L,6L,5L,5L,6L,2L,9L,1L,3L,9L,0L,7L,2L,8L,4L,7L,6L,8L,2L,1L,1L,9L,2L,0L,5L,2L,9L,8L,0L,1L,3L,2L,4L,5L,0L,3L,3L,1L,1L,2L,5L,8L,2L,7L,8L,1L,4L,5L,6L,9L,5L,3L,6L,4L,2L,3L,8L,4L,1L,0L,5L,9L,6L,0L,2L,6L,4L,9L,0L,0L,6L,6L,2L,2L,5L,1L,6L,5L,5L,6L,2L,9L,1L,3L,9L,0L,7L,2L,8L,4L,7L,6L,8L,2L,1L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021608Inst : IEnumerable<long>
{
public static readonly long[] Value=A021608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021608.Bytes);
public long this[int i]=>Value[i];

public static A021608Inst Instance=new A021608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021607
{
public static readonly long[] Value={ 0L,0L,1L,6L,5L,8L,3L,7L,4L,7L,9L,2L,7L,0L,3L,1L,5L,0L,9L,1L,2L,1L,0L,6L,1L,3L,5L,9L,8L,6L,7L,3L,3L,0L,0L,1L,6L,5L,8L,3L,7L,4L,7L,9L,2L,7L,0L,3L,1L,5L,0L,9L,1L,2L,1L,0L,6L,1L,3L,5L,9L,8L,6L,7L,3L,3L,0L,0L,1L,6L,5L,8L,3L,7L,4L,7L,9L,2L,7L,0L,3L,1L,5L,0L,9L,1L,2L,1L,0L,6L,1L,3L,5L,9L,8L,6L,7L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021607Inst : IEnumerable<long>
{
public static readonly long[] Value=A021607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021607.Bytes);
public long this[int i]=>Value[i];

public static A021607Inst Instance=new A021607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021606
{
public static readonly long[] Value={ 0L,0L,1L,6L,6L,1L,1L,2L,9L,5L,6L,8L,1L,0L,6L,3L,1L,2L,2L,9L,2L,3L,5L,8L,8L,0L,3L,9L,8L,6L,7L,1L,0L,9L,6L,3L,4L,5L,5L,1L,4L,9L,5L,0L,1L,6L,6L,1L,1L,2L,9L,5L,6L,8L,1L,0L,6L,3L,1L,2L,2L,9L,2L,3L,5L,8L,8L,0L,3L,9L,8L,6L,7L,1L,0L,9L,6L,3L,4L,5L,5L,1L,4L,9L,5L,0L,1L,6L,6L,1L,1L,2L,9L,5L,6L,8L,1L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021606Inst : IEnumerable<long>
{
public static readonly long[] Value=A021606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021606.Bytes);
public long this[int i]=>Value[i];

public static A021606Inst Instance=new A021606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021605
{
public static readonly long[] Value={ 0L,0L,1L,6L,6L,3L,8L,9L,3L,5L,1L,0L,8L,1L,5L,3L,0L,7L,8L,2L,0L,2L,9L,9L,5L,0L,0L,8L,3L,1L,9L,4L,6L,7L,5L,5L,4L,0L,7L,6L,5L,3L,9L,1L,0L,1L,4L,9L,7L,5L,0L,4L,1L,5L,9L,7L,3L,3L,7L,7L,7L,0L,3L,8L,2L,6L,9L,5L,5L,0L,7L,4L,8L,7L,5L,2L,0L,7L,9L,8L,6L,6L,8L,8L,8L,5L,1L,9L,1L,3L,4L,7L,7L,5L,3L,7L,4L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021605Inst : IEnumerable<long>
{
public static readonly long[] Value=A021605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021605.Bytes);
public long this[int i]=>Value[i];

public static A021605Inst Instance=new A021605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021604
{
public static readonly long[] Value={ 1L,21L,300L,3670L,41511L,449151L,4730890L,48987840L,501640821L,5098774681L,51564400680L,519680849610L,5225067192931L,52448485198611L,525869552045670L,5268388442396980L,52751734942121841L,527992303241992941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021604Inst : IEnumerable<long>
{
public static readonly long[] Value=A021604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021604.Bytes);
public long this[int i]=>Value[i];

public static A021604Inst Instance=new A021604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021603
{
public static readonly long[] Value={ 0L,0L,1L,6L,6L,9L,4L,4L,9L,0L,8L,1L,8L,0L,3L,0L,0L,5L,0L,0L,8L,3L,4L,7L,2L,4L,5L,4L,0L,9L,0L,1L,5L,0L,2L,5L,0L,4L,1L,7L,3L,6L,2L,2L,7L,0L,4L,5L,0L,7L,5L,1L,2L,5L,2L,0L,8L,6L,8L,1L,1L,3L,5L,2L,2L,5L,3L,7L,5L,6L,2L,6L,0L,4L,3L,4L,0L,5L,6L,7L,6L,1L,2L,6L,8L,7L,8L,1L,3L,0L,2L,1L,7L,0L,2L,8L,3L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021603Inst : IEnumerable<long>
{
public static readonly long[] Value=A021603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021603.Bytes);
public long this[int i]=>Value[i];

public static A021603Inst Instance=new A021603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021602
{
public static readonly long[] Value={ 0L,0L,1L,6L,7L,2L,2L,4L,0L,8L,0L,2L,6L,7L,5L,5L,8L,5L,2L,8L,4L,2L,8L,0L,9L,3L,6L,4L,5L,4L,8L,4L,9L,4L,9L,8L,3L,2L,7L,7L,5L,9L,1L,9L,7L,3L,2L,4L,4L,1L,4L,7L,1L,5L,7L,1L,9L,0L,6L,3L,5L,4L,5L,1L,5L,0L,5L,0L,1L,6L,7L,2L,2L,4L,0L,8L,0L,2L,6L,7L,5L,5L,8L,5L,2L,8L,4L,2L,8L,0L,9L,3L,6L,4L,5L,4L,8L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021602Inst : IEnumerable<long>
{
public static readonly long[] Value=A021602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021602.Bytes);
public long this[int i]=>Value[i];

public static A021602Inst Instance=new A021602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021601
{
public static readonly long[] Value={ 0L,0L,1L,6L,7L,5L,0L,4L,1L,8L,7L,6L,0L,4L,6L,9L,0L,1L,1L,7L,2L,5L,2L,9L,3L,1L,3L,2L,3L,2L,8L,3L,0L,8L,2L,0L,7L,7L,0L,5L,1L,9L,2L,6L,2L,9L,8L,1L,5L,7L,4L,5L,3L,9L,3L,6L,3L,4L,8L,4L,0L,8L,7L,1L,0L,2L,1L,7L,7L,5L,5L,4L,4L,3L,8L,8L,6L,0L,9L,7L,1L,5L,2L,4L,2L,8L,8L,1L,0L,7L,2L,0L,2L,6L,8L,0L,0L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021601Inst : IEnumerable<long>
{
public static readonly long[] Value=A021601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021601.Bytes);
public long this[int i]=>Value[i];

public static A021601Inst Instance=new A021601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021600
{
public static readonly long[] Value={ 0L,0L,1L,6L,7L,7L,8L,5L,2L,3L,4L,8L,9L,9L,3L,2L,8L,8L,5L,9L,0L,6L,0L,4L,0L,2L,6L,8L,4L,5L,6L,3L,7L,5L,8L,3L,8L,9L,2L,6L,1L,7L,4L,4L,9L,6L,6L,4L,4L,2L,9L,5L,3L,0L,2L,0L,1L,3L,4L,2L,2L,8L,1L,8L,7L,9L,1L,9L,4L,6L,3L,0L,8L,7L,2L,4L,8L,3L,2L,2L,1L,4L,7L,6L,5L,1L,0L,0L,6L,7L,1L,1L,4L,0L,9L,3L,9L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021600Inst : IEnumerable<long>
{
public static readonly long[] Value=A021600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021600.Bytes);
public long this[int i]=>Value[i];

public static A021600Inst Instance=new A021600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021599
{
public static readonly long[] Value={ 0L,0L,1L,6L,8L,0L,6L,7L,2L,2L,6L,8L,9L,0L,7L,5L,6L,3L,0L,2L,5L,2L,1L,0L,0L,8L,4L,0L,3L,3L,6L,1L,3L,4L,4L,5L,3L,7L,8L,1L,5L,1L,2L,6L,0L,5L,0L,4L,2L,0L,1L,6L,8L,0L,6L,7L,2L,2L,6L,8L,9L,0L,7L,5L,6L,3L,0L,2L,5L,2L,1L,0L,0L,8L,4L,0L,3L,3L,6L,1L,3L,4L,4L,5L,3L,7L,8L,1L,5L,1L,2L,6L,0L,5L,0L,4L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021599Inst : IEnumerable<long>
{
public static readonly long[] Value=A021599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021599.Bytes);
public long this[int i]=>Value[i];

public static A021599Inst Instance=new A021599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021598
{
public static readonly long[] Value={ 0L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021598Inst : IEnumerable<long>
{
public static readonly long[] Value=A021598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021598.Bytes);
public long this[int i]=>Value[i];

public static A021598Inst Instance=new A021598Inst();

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

public static class A021580
{
public static readonly long[] Value={ 0L,0L,1L,7L,3L,6L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021580Inst : IEnumerable<long>
{
public static readonly long[] Value=A021580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021580.Bytes);
public long this[int i]=>Value[i];

public static A021580Inst Instance=new A021580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021579
{
public static readonly long[] Value={ 0L,0L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021579Inst : IEnumerable<long>
{
public static readonly long[] Value=A021579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021579.Bytes);
public long this[int i]=>Value[i];

public static A021579Inst Instance=new A021579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021578
{
public static readonly long[] Value={ 0L,0L,1L,7L,4L,2L,1L,6L,0L,2L,7L,8L,7L,4L,5L,6L,4L,4L,5L,9L,9L,3L,0L,3L,1L,3L,5L,8L,8L,8L,5L,0L,1L,7L,4L,2L,1L,6L,0L,2L,7L,8L,7L,4L,5L,6L,4L,4L,5L,9L,9L,3L,0L,3L,1L,3L,5L,8L,8L,8L,5L,0L,1L,7L,4L,2L,1L,6L,0L,2L,7L,8L,7L,4L,5L,6L,4L,4L,5L,9L,9L,3L,0L,3L,1L,3L,5L,8L,8L,8L,5L,0L,1L,7L,4L,2L,1L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021578Inst : IEnumerable<long>
{
public static readonly long[] Value=A021578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021578.Bytes);
public long this[int i]=>Value[i];

public static A021578Inst Instance=new A021578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021577
{
public static readonly long[] Value={ 0L,0L,1L,7L,4L,5L,2L,0L,0L,6L,9L,8L,0L,8L,0L,2L,7L,9L,2L,3L,2L,1L,1L,1L,6L,9L,2L,8L,4L,4L,6L,7L,7L,1L,3L,7L,8L,7L,0L,8L,5L,5L,1L,4L,8L,3L,4L,2L,0L,5L,9L,3L,3L,6L,8L,2L,3L,7L,3L,4L,7L,2L,9L,4L,9L,3L,8L,9L,1L,7L,9L,7L,5L,5L,6L,7L,1L,9L,0L,2L,2L,6L,8L,7L,6L,0L,9L,0L,7L,5L,0L,4L,3L,6L,3L,0L,0L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021577Inst : IEnumerable<long>
{
public static readonly long[] Value=A021577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021577.Bytes);
public long this[int i]=>Value[i];

public static A021577Inst Instance=new A021577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021576
{
public static readonly long[] Value={ 0L,0L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021576Inst : IEnumerable<long>
{
public static readonly long[] Value=A021576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021576.Bytes);
public long this[int i]=>Value[i];

public static A021576Inst Instance=new A021576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021575
{
public static readonly long[] Value={ 0L,0L,1L,7L,5L,1L,3L,1L,3L,4L,8L,5L,1L,1L,3L,8L,3L,5L,3L,7L,6L,5L,3L,2L,3L,9L,9L,2L,9L,9L,4L,7L,4L,6L,0L,5L,9L,5L,4L,4L,6L,5L,8L,4L,9L,3L,8L,7L,0L,4L,0L,2L,8L,0L,2L,1L,0L,1L,5L,7L,6L,1L,8L,2L,1L,3L,6L,6L,0L,2L,4L,5L,1L,8L,3L,8L,8L,7L,9L,1L,5L,9L,3L,6L,9L,5L,2L,7L,1L,4L,5L,3L,5L,9L,0L,1L,9L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021575Inst : IEnumerable<long>
{
public static readonly long[] Value=A021575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021575.Bytes);
public long this[int i]=>Value[i];

public static A021575Inst Instance=new A021575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021574
{
public static readonly long[] Value={ 0L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021574Inst : IEnumerable<long>
{
public static readonly long[] Value=A021574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021574.Bytes);
public long this[int i]=>Value[i];

public static A021574Inst Instance=new A021574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021573
{
public static readonly long[] Value={ 0L,0L,1L,7L,5L,7L,4L,6L,9L,2L,4L,4L,2L,8L,8L,2L,2L,4L,9L,5L,6L,0L,6L,3L,2L,6L,8L,8L,9L,2L,7L,9L,4L,3L,7L,6L,0L,9L,8L,4L,1L,8L,2L,7L,7L,6L,8L,0L,1L,4L,0L,5L,9L,7L,5L,3L,9L,5L,4L,3L,0L,5L,7L,9L,9L,6L,4L,8L,5L,0L,6L,1L,5L,1L,1L,4L,2L,3L,5L,5L,0L,0L,8L,7L,8L,7L,3L,4L,6L,2L,2L,1L,4L,4L,1L,1L,2L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021573Inst : IEnumerable<long>
{
public static readonly long[] Value=A021573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021573.Bytes);
public long this[int i]=>Value[i];

public static A021573Inst Instance=new A021573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021572
{
public static readonly long[] Value={ 0L,0L,1L,7L,6L,0L,5L,6L,3L,3L,8L,0L,2L,8L,1L,6L,9L,0L,1L,4L,0L,8L,4L,5L,0L,7L,0L,4L,2L,2L,5L,3L,5L,2L,1L,1L,2L,6L,7L,6L,0L,5L,6L,3L,3L,8L,0L,2L,8L,1L,6L,9L,0L,1L,4L,0L,8L,4L,5L,0L,7L,0L,4L,2L,2L,5L,3L,5L,2L,1L,1L,2L,6L,7L,6L,0L,5L,6L,3L,3L,8L,0L,2L,8L,1L,6L,9L,0L,1L,4L,0L,8L,4L,5L,0L,7L,0L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021572Inst : IEnumerable<long>
{
public static readonly long[] Value=A021572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021572.Bytes);
public long this[int i]=>Value[i];

public static A021572Inst Instance=new A021572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021571
{
public static readonly long[] Value={ 0L,0L,1L,7L,6L,3L,6L,6L,8L,4L,3L,0L,3L,3L,5L,0L,9L,7L,0L,0L,1L,7L,6L,3L,6L,6L,8L,4L,3L,0L,3L,3L,5L,0L,9L,7L,0L,0L,1L,7L,6L,3L,6L,6L,8L,4L,3L,0L,3L,3L,5L,0L,9L,7L,0L,0L,1L,7L,6L,3L,6L,6L,8L,4L,3L,0L,3L,3L,5L,0L,9L,7L,0L,0L,1L,7L,6L,3L,6L,6L,8L,4L,3L,0L,3L,3L,5L,0L,9L,7L,0L,0L,1L,7L,6L,3L,6L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021571Inst : IEnumerable<long>
{
public static readonly long[] Value=A021571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021571.Bytes);
public long this[int i]=>Value[i];

public static A021571Inst Instance=new A021571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021570
{
public static readonly long[] Value={ 0L,0L,1L,7L,6L,6L,7L,8L,4L,4L,5L,2L,2L,9L,6L,8L,1L,9L,7L,8L,7L,9L,8L,5L,8L,6L,5L,7L,2L,4L,3L,8L,1L,6L,2L,5L,4L,4L,1L,6L,9L,6L,1L,1L,3L,0L,7L,4L,2L,0L,4L,9L,4L,6L,9L,9L,6L,4L,6L,6L,4L,3L,1L,0L,9L,5L,4L,0L,6L,3L,6L,0L,4L,2L,4L,0L,2L,8L,2L,6L,8L,5L,5L,1L,2L,3L,6L,7L,4L,9L,1L,1L,6L,6L,0L,7L,7L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021570Inst : IEnumerable<long>
{
public static readonly long[] Value=A021570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021570.Bytes);
public long this[int i]=>Value[i];

public static A021570Inst Instance=new A021570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021569
{
public static readonly long[] Value={ 0L,0L,1L,7L,6L,9L,9L,1L,1L,5L,0L,4L,4L,2L,4L,7L,7L,8L,7L,6L,1L,0L,6L,1L,9L,4L,6L,9L,0L,2L,6L,5L,4L,8L,6L,7L,2L,5L,6L,6L,3L,7L,1L,6L,8L,1L,4L,1L,5L,9L,2L,9L,2L,0L,3L,5L,3L,9L,8L,2L,3L,0L,0L,8L,8L,4L,9L,5L,5L,7L,5L,2L,2L,1L,2L,3L,8L,9L,3L,8L,0L,5L,3L,0L,9L,7L,3L,4L,5L,1L,3L,2L,7L,4L,3L,3L,6L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021569Inst : IEnumerable<long>
{
public static readonly long[] Value=A021569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021569.Bytes);
public long this[int i]=>Value[i];

public static A021569Inst Instance=new A021569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021568
{
public static readonly long[] Value={ 0L,0L,1L,7L,7L,3L,0L,4L,9L,6L,4L,5L,3L,9L,0L,0L,7L,0L,9L,2L,1L,9L,8L,5L,8L,1L,5L,6L,0L,2L,8L,3L,6L,8L,7L,9L,4L,3L,2L,6L,2L,4L,1L,1L,3L,4L,7L,5L,1L,7L,7L,3L,0L,4L,9L,6L,4L,5L,3L,9L,0L,0L,7L,0L,9L,2L,1L,9L,8L,5L,8L,1L,5L,6L,0L,2L,8L,3L,6L,8L,7L,9L,4L,3L,2L,6L,2L,4L,1L,1L,3L,4L,7L,5L,1L,7L,7L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021568Inst : IEnumerable<long>
{
public static readonly long[] Value=A021568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021568.Bytes);
public long this[int i]=>Value[i];

public static A021568Inst Instance=new A021568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021567
{
public static readonly long[] Value={ 0L,0L,1L,7L,7L,6L,1L,9L,8L,9L,3L,4L,2L,8L,0L,6L,3L,9L,4L,3L,1L,6L,1L,6L,3L,4L,1L,0L,3L,0L,1L,9L,5L,3L,8L,1L,8L,8L,2L,7L,7L,0L,8L,7L,0L,3L,3L,7L,4L,7L,7L,7L,9L,7L,5L,1L,3L,3L,2L,1L,4L,9L,2L,0L,0L,7L,1L,0L,4L,7L,9L,5L,7L,3L,7L,1L,2L,2L,5L,5L,7L,7L,2L,6L,4L,6L,5L,3L,6L,4L,1L,2L,0L,7L,8L,1L,5L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021567Inst : IEnumerable<long>
{
public static readonly long[] Value=A021567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021567.Bytes);
public long this[int i]=>Value[i];

public static A021567Inst Instance=new A021567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021566
{
public static readonly long[] Value={ 0L,0L,1L,7L,7L,9L,3L,5L,9L,4L,3L,0L,6L,0L,4L,9L,8L,2L,2L,0L,6L,4L,0L,5L,6L,9L,3L,9L,5L,0L,1L,7L,7L,9L,3L,5L,9L,4L,3L,0L,6L,0L,4L,9L,8L,2L,2L,0L,6L,4L,0L,5L,6L,9L,3L,9L,5L,0L,1L,7L,7L,9L,3L,5L,9L,4L,3L,0L,6L,0L,4L,9L,8L,2L,2L,0L,6L,4L,0L,5L,6L,9L,3L,9L,5L,0L,1L,7L,7L,9L,3L,5L,9L,4L,3L,0L,6L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021566Inst : IEnumerable<long>
{
public static readonly long[] Value=A021566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021566.Bytes);
public long this[int i]=>Value[i];

public static A021566Inst Instance=new A021566Inst();

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

public static class A021548
{
public static readonly long[] Value={ 0L,0L,1L,8L,3L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021548Inst : IEnumerable<long>
{
public static readonly long[] Value=A021548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021548.Bytes);
public long this[int i]=>Value[i];

public static A021548Inst Instance=new A021548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021547
{
public static readonly long[] Value={ 0L,0L,1L,8L,4L,1L,6L,2L,0L,6L,2L,6L,1L,5L,1L,0L,1L,2L,8L,9L,1L,3L,4L,4L,3L,8L,3L,0L,5L,7L,0L,9L,0L,2L,3L,9L,4L,1L,0L,6L,8L,1L,3L,9L,9L,6L,3L,1L,6L,7L,5L,8L,7L,4L,7L,6L,9L,7L,9L,7L,4L,2L,1L,7L,3L,1L,1L,2L,3L,3L,8L,8L,5L,8L,1L,9L,5L,2L,1L,1L,7L,8L,6L,3L,7L,2L,0L,0L,7L,3L,6L,6L,4L,8L,2L,5L,0L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021547Inst : IEnumerable<long>
{
public static readonly long[] Value=A021547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021547.Bytes);
public long this[int i]=>Value[i];

public static A021547Inst Instance=new A021547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021546
{
public static readonly long[] Value={ 0L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021546Inst : IEnumerable<long>
{
public static readonly long[] Value=A021546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021546.Bytes);
public long this[int i]=>Value[i];

public static A021546Inst Instance=new A021546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021545
{
public static readonly long[] Value={ 0L,0L,1L,8L,4L,8L,4L,2L,8L,8L,3L,5L,4L,8L,9L,8L,3L,3L,6L,4L,1L,4L,0L,4L,8L,0L,5L,9L,1L,4L,9L,7L,2L,2L,7L,3L,5L,6L,7L,4L,6L,7L,6L,5L,2L,4L,9L,5L,3L,7L,8L,9L,2L,7L,9L,1L,1L,2L,7L,5L,4L,1L,5L,8L,9L,6L,4L,8L,7L,9L,8L,5L,2L,1L,2L,5L,6L,9L,3L,1L,6L,0L,8L,1L,3L,3L,0L,8L,6L,8L,7L,6L,1L,5L,5L,2L,6L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021545Inst : IEnumerable<long>
{
public static readonly long[] Value=A021545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021545.Bytes);
public long this[int i]=>Value[i];

public static A021545Inst Instance=new A021545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021544
{
public static readonly long[] Value={ 1L,19L,242L,2606L,25659L,239313L,2153884L,18910012L,163042517L,1386706607L,11670306726L,97399296618L,807453069775L,6657437827501L,54644202679568L,446846543376824L,3642622865166633L,29615936742107595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021544Inst : IEnumerable<long>
{
public static readonly long[] Value=A021544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021544.Bytes);
public long this[int i]=>Value[i];

public static A021544Inst Instance=new A021544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021543
{
public static readonly long[] Value={ 0L,0L,1L,8L,5L,5L,2L,8L,7L,5L,6L,9L,5L,7L,3L,2L,8L,3L,8L,5L,8L,9L,9L,8L,1L,4L,4L,7L,1L,2L,4L,3L,0L,4L,2L,6L,7L,1L,6L,1L,4L,1L,0L,0L,1L,8L,5L,5L,2L,8L,7L,5L,6L,9L,5L,7L,3L,2L,8L,3L,8L,5L,8L,9L,9L,8L,1L,4L,4L,7L,1L,2L,4L,3L,0L,4L,2L,6L,7L,1L,6L,1L,4L,1L,0L,0L,1L,8L,5L,5L,2L,8L,7L,5L,6L,9L,5L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021543Inst : IEnumerable<long>
{
public static readonly long[] Value=A021543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021543.Bytes);
public long this[int i]=>Value[i];

public static A021543Inst Instance=new A021543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021542
{
public static readonly long[] Value={ 0L,0L,1L,8L,5L,8L,7L,3L,6L,0L,5L,9L,4L,7L,9L,5L,5L,3L,9L,0L,3L,3L,4L,5L,7L,2L,4L,9L,0L,7L,0L,6L,3L,1L,9L,7L,0L,2L,6L,0L,2L,2L,3L,0L,4L,8L,3L,2L,7L,1L,3L,7L,5L,4L,6L,4L,6L,8L,4L,0L,1L,4L,8L,6L,9L,8L,8L,8L,4L,7L,5L,8L,3L,6L,4L,3L,1L,2L,2L,6L,7L,6L,5L,7L,9L,9L,2L,5L,6L,5L,0L,5L,5L,7L,6L,2L,0L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021542Inst : IEnumerable<long>
{
public static readonly long[] Value=A021542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021542.Bytes);
public long this[int i]=>Value[i];

public static A021542Inst Instance=new A021542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021541
{
public static readonly long[] Value={ 0L,0L,1L,8L,6L,2L,1L,9L,7L,3L,9L,2L,9L,2L,3L,6L,4L,9L,9L,0L,6L,8L,9L,0L,1L,3L,0L,3L,5L,3L,8L,1L,7L,5L,0L,4L,6L,5L,5L,4L,9L,3L,4L,8L,2L,3L,0L,9L,1L,2L,4L,7L,6L,7L,2L,2L,5L,3L,2L,5L,8L,8L,4L,5L,4L,3L,7L,6L,1L,6L,3L,8L,7L,3L,3L,7L,0L,5L,7L,7L,2L,8L,1L,1L,9L,1L,8L,0L,6L,3L,3L,1L,4L,7L,1L,1L,3L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021541Inst : IEnumerable<long>
{
public static readonly long[] Value=A021541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021541.Bytes);
public long this[int i]=>Value[i];

public static A021541Inst Instance=new A021541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021540
{
public static readonly long[] Value={ 0L,0L,1L,8L,6L,5L,6L,7L,1L,6L,4L,1L,7L,9L,1L,0L,4L,4L,7L,7L,6L,1L,1L,9L,4L,0L,2L,9L,8L,5L,0L,7L,4L,6L,2L,6L,8L,6L,5L,6L,7L,1L,6L,4L,1L,7L,9L,1L,0L,4L,4L,7L,7L,6L,1L,1L,9L,4L,0L,2L,9L,8L,5L,0L,7L,4L,6L,2L,6L,8L,6L,5L,6L,7L,1L,6L,4L,1L,7L,9L,1L,0L,4L,4L,7L,7L,6L,1L,1L,9L,4L,0L,2L,9L,8L,5L,0L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021540Inst : IEnumerable<long>
{
public static readonly long[] Value=A021540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021540.Bytes);
public long this[int i]=>Value[i];

public static A021540Inst Instance=new A021540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021539
{
public static readonly long[] Value={ 0L,0L,1L,8L,6L,9L,1L,5L,8L,8L,7L,8L,5L,0L,4L,6L,7L,2L,8L,9L,7L,1L,9L,6L,2L,6L,1L,6L,8L,2L,2L,4L,2L,9L,9L,0L,6L,5L,4L,2L,0L,5L,6L,0L,7L,4L,7L,6L,6L,3L,5L,5L,1L,4L,0L,1L,8L,6L,9L,1L,5L,8L,8L,7L,8L,5L,0L,4L,6L,7L,2L,8L,9L,7L,1L,9L,6L,2L,6L,1L,6L,8L,2L,2L,4L,2L,9L,9L,0L,6L,5L,4L,2L,0L,5L,6L,0L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021539Inst : IEnumerable<long>
{
public static readonly long[] Value=A021539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021539.Bytes);
public long this[int i]=>Value[i];

public static A021539Inst Instance=new A021539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021538
{
public static readonly long[] Value={ 0L,0L,1L,8L,7L,2L,6L,5L,9L,1L,7L,6L,0L,2L,9L,9L,6L,2L,5L,4L,6L,8L,1L,6L,4L,7L,9L,4L,0L,0L,7L,4L,9L,0L,6L,3L,6L,7L,0L,4L,1L,1L,9L,8L,5L,0L,1L,8L,7L,2L,6L,5L,9L,1L,7L,6L,0L,2L,9L,9L,6L,2L,5L,4L,6L,8L,1L,6L,4L,7L,9L,4L,0L,0L,7L,4L,9L,0L,6L,3L,6L,7L,0L,4L,1L,1L,9L,8L,5L,0L,1L,8L,7L,2L,6L,5L,9L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021538Inst : IEnumerable<long>
{
public static readonly long[] Value=A021538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021538.Bytes);
public long this[int i]=>Value[i];

public static A021538Inst Instance=new A021538Inst();

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