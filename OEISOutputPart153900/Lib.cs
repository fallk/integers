using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A197005
{
public static readonly long[] Value={ 1L,0L,3L,7L,0L,5L,7L,0L,8L,3L,7L,3L,6L,5L,1L,5L,0L,0L,4L,6L,6L,1L,4L,7L,9L,5L,8L,3L,7L,5L,8L,4L,2L,7L,7L,6L,0L,5L,2L,2L,2L,3L,4L,3L,4L,3L,1L,3L,9L,2L,5L,1L,5L,3L,1L,6L,5L,5L,2L,9L,5L,2L,4L,2L,0L,6L,8L,4L,8L,7L,9L,8L,7L,2L,3L,9L,7L,5L,1L,8L,7L,8L,7L,4L,8L,1L,7L,2L,3L,2L,2L,4L,5L,5L,9L,3L,3L,2L,8L,0L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197005Inst : IEnumerable<long>
{
public static readonly long[] Value=A197005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197005.Bytes);
public long this[int i]=>Value[i];

public static A197005Inst Instance=new A197005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197006
{
public static readonly long[] Value={ 4L,6L,0L,8L,8L,5L,5L,8L,0L,8L,6L,0L,9L,6L,5L,9L,7L,6L,9L,8L,7L,9L,8L,1L,2L,8L,2L,5L,1L,3L,6L,9L,8L,2L,7L,7L,2L,4L,3L,7L,4L,9L,9L,9L,8L,7L,4L,3L,9L,3L,4L,3L,5L,6L,9L,3L,2L,5L,7L,8L,4L,3L,3L,9L,2L,4L,8L,3L,4L,7L,5L,2L,2L,8L,8L,0L,3L,8L,7L,9L,7L,1L,3L,0L,5L,0L,5L,9L,7L,4L,8L,0L,7L,6L,7L,9L,4L,3L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197006Inst : IEnumerable<long>
{
public static readonly long[] Value=A197006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197006.Bytes);
public long this[int i]=>Value[i];

public static A197006Inst Instance=new A197006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197007
{
public static readonly long[] Value={ 1L,2L,0L,0L,4L,9L,9L,0L,7L,2L,3L,8L,7L,9L,9L,7L,9L,0L,6L,1L,2L,5L,0L,4L,6L,5L,1L,2L,4L,4L,2L,7L,1L,1L,3L,4L,2L,4L,3L,7L,6L,8L,0L,1L,7L,5L,1L,3L,2L,9L,9L,4L,0L,6L,8L,6L,6L,0L,5L,0L,4L,2L,1L,9L,0L,9L,4L,4L,4L,7L,6L,1L,0L,3L,8L,1L,3L,6L,2L,4L,2L,6L,8L,5L,5L,6L,4L,8L,5L,6L,0L,5L,1L,1L,4L,3L,3L,6L,6L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197007Inst : IEnumerable<long>
{
public static readonly long[] Value=A197007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197007.Bytes);
public long this[int i]=>Value[i];

public static A197007Inst Instance=new A197007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197008
{
public static readonly long[] Value={ 4L,1L,6L,1L,9L,3L,8L,1L,8L,4L,9L,4L,1L,4L,6L,2L,7L,5L,2L,3L,9L,0L,0L,8L,0L,7L,2L,2L,9L,4L,6L,6L,9L,9L,6L,3L,7L,7L,8L,9L,3L,2L,5L,5L,8L,7L,5L,5L,0L,9L,3L,0L,3L,0L,2L,4L,2L,9L,6L,2L,3L,8L,5L,2L,7L,0L,6L,8L,8L,5L,0L,3L,6L,5L,0L,2L,9L,1L,5L,9L,3L,8L,2L,4L,6L,1L,3L,8L,8L,2L,2L,0L,6L,7L,8L,3L,6L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197008Inst : IEnumerable<long>
{
public static readonly long[] Value=A197008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197008.Bytes);
public long this[int i]=>Value[i];

public static A197008Inst Instance=new A197008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197009
{
public static readonly long[] Value={ 1L,0L,4L,4L,7L,3L,5L,8L,2L,5L,1L,0L,2L,5L,9L,1L,9L,6L,4L,4L,6L,7L,0L,4L,6L,7L,1L,2L,5L,0L,4L,4L,0L,4L,1L,1L,3L,0L,4L,8L,6L,5L,8L,9L,3L,2L,8L,0L,5L,0L,5L,9L,5L,7L,8L,8L,7L,4L,2L,8L,3L,1L,8L,2L,0L,8L,4L,6L,5L,0L,8L,0L,5L,9L,3L,0L,7L,3L,2L,6L,8L,9L,7L,2L,4L,3L,1L,3L,3L,0L,3L,9L,5L,6L,6L,9L,3L,8L,4L,5L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197009Inst : IEnumerable<long>
{
public static readonly long[] Value=A197009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197009.Bytes);
public long this[int i]=>Value[i];

public static A197009Inst Instance=new A197009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197010
{
public static readonly long[] Value={ 4L,6L,7L,2L,8L,1L,6L,0L,5L,3L,7L,6L,0L,1L,2L,1L,3L,3L,7L,8L,1L,6L,3L,0L,7L,2L,6L,8L,8L,4L,4L,2L,5L,0L,1L,3L,8L,1L,1L,6L,5L,1L,4L,2L,4L,6L,7L,6L,6L,7L,0L,6L,4L,5L,1L,6L,4L,1L,1L,5L,8L,9L,7L,7L,7L,0L,6L,7L,5L,6L,3L,4L,7L,2L,2L,9L,6L,3L,6L,4L,1L,5L,5L,0L,3L,8L,9L,3L,6L,1L,1L,6L,6L,2L,0L,5L,3L,7L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197010Inst : IEnumerable<long>
{
public static readonly long[] Value=A197010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197010.Bytes);
public long this[int i]=>Value[i];

public static A197010Inst Instance=new A197010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197011
{
public static readonly long[] Value={ 1L,2L,1L,4L,5L,5L,6L,2L,7L,2L,0L,0L,1L,0L,5L,6L,9L,8L,0L,2L,9L,9L,8L,8L,0L,1L,6L,7L,5L,4L,7L,7L,7L,7L,6L,2L,0L,4L,2L,9L,7L,3L,0L,6L,2L,9L,3L,4L,2L,3L,0L,1L,1L,0L,7L,5L,5L,0L,6L,1L,4L,8L,2L,3L,4L,8L,8L,0L,8L,3L,4L,2L,2L,5L,6L,0L,8L,4L,2L,7L,4L,5L,6L,0L,0L,6L,6L,7L,4L,8L,5L,3L,8L,8L,8L,6L,5L,7L,1L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197011Inst : IEnumerable<long>
{
public static readonly long[] Value=A197011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197011.Bytes);
public long this[int i]=>Value[i];

public static A197011Inst Instance=new A197011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197012
{
public static readonly long[] Value={ 5L,4L,0L,5L,5L,9L,8L,7L,2L,7L,4L,2L,3L,4L,8L,3L,8L,2L,5L,4L,3L,0L,6L,0L,8L,6L,5L,2L,6L,9L,5L,6L,2L,3L,9L,8L,1L,9L,6L,0L,3L,9L,2L,4L,4L,0L,4L,9L,8L,0L,1L,3L,0L,3L,6L,6L,3L,9L,7L,6L,0L,3L,2L,3L,3L,9L,8L,6L,0L,8L,6L,0L,8L,5L,3L,4L,6L,6L,5L,1L,6L,3L,4L,7L,5L,3L,1L,7L,7L,1L,9L,2L,6L,1L,2L,9L,3L,0L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197012Inst : IEnumerable<long>
{
public static readonly long[] Value=A197012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197012.Bytes);
public long this[int i]=>Value[i];

public static A197012Inst Instance=new A197012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197013
{
public static readonly long[] Value={ 6L,6L,0L,3L,6L,6L,1L,0L,2L,4L,2L,3L,4L,0L,2L,9L,5L,8L,5L,8L,8L,6L,9L,4L,5L,2L,3L,7L,2L,9L,2L,8L,6L,5L,4L,8L,4L,8L,1L,7L,6L,2L,3L,2L,7L,9L,8L,7L,9L,1L,0L,6L,8L,1L,2L,6L,8L,1L,1L,8L,6L,7L,3L,9L,8L,5L,2L,0L,9L,7L,6L,3L,9L,1L,0L,5L,6L,7L,4L,1L,1L,1L,6L,6L,7L,8L,7L,8L,2L,1L,3L,3L,0L,7L,3L,1L,5L,8L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197013Inst : IEnumerable<long>
{
public static readonly long[] Value=A197013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197013.Bytes);
public long this[int i]=>Value[i];

public static A197013Inst Instance=new A197013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197014
{
public static readonly long[] Value={ 7L,0L,2L,3L,4L,8L,2L,3L,7L,9L,2L,1L,9L,9L,6L,5L,9L,2L,6L,8L,4L,4L,5L,6L,0L,1L,4L,4L,1L,2L,9L,1L,5L,0L,4L,8L,0L,2L,7L,3L,2L,7L,6L,1L,6L,6L,0L,3L,5L,3L,4L,0L,6L,2L,6L,7L,2L,3L,9L,5L,1L,5L,6L,7L,6L,5L,5L,5L,8L,5L,2L,9L,4L,8L,0L,5L,6L,7L,0L,4L,3L,8L,9L,6L,9L,7L,6L,1L,5L,3L,8L,3L,8L,3L,1L,5L,9L,1L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197014Inst : IEnumerable<long>
{
public static readonly long[] Value=A197014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197014.Bytes);
public long this[int i]=>Value[i];

public static A197014Inst Instance=new A197014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197015
{
public static readonly long[] Value={ 9L,8L,6L,5L,6L,6L,2L,5L,5L,5L,4L,3L,5L,0L,9L,0L,1L,9L,2L,5L,4L,8L,5L,4L,4L,3L,2L,6L,6L,8L,9L,0L,5L,4L,2L,4L,3L,0L,8L,4L,7L,5L,1L,4L,6L,9L,0L,9L,0L,6L,0L,3L,2L,0L,5L,0L,7L,0L,2L,4L,9L,6L,6L,4L,5L,1L,4L,4L,2L,2L,1L,3L,9L,2L,4L,8L,3L,8L,3L,7L,8L,0L,7L,6L,5L,6L,3L,0L,4L,2L,1L,8L,6L,6L,5L,0L,3L,6L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197015Inst : IEnumerable<long>
{
public static readonly long[] Value=A197015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197015.Bytes);
public long this[int i]=>Value[i];

public static A197015Inst Instance=new A197015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197016
{
public static readonly long[] Value={ 4L,2L,8L,7L,7L,8L,5L,3L,6L,0L,3L,0L,6L,1L,2L,8L,6L,3L,6L,1L,3L,6L,9L,1L,7L,4L,1L,0L,4L,8L,9L,9L,9L,7L,0L,4L,9L,0L,6L,0L,5L,8L,9L,3L,6L,1L,5L,2L,0L,2L,6L,8L,5L,1L,9L,9L,3L,7L,8L,8L,2L,4L,6L,9L,8L,4L,7L,1L,3L,9L,3L,2L,2L,8L,8L,8L,9L,7L,9L,4L,8L,6L,0L,3L,5L,1L,0L,1L,5L,5L,4L,3L,3L,2L,3L,1L,2L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197016Inst : IEnumerable<long>
{
public static readonly long[] Value=A197016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197016.Bytes);
public long this[int i]=>Value[i];

public static A197016Inst Instance=new A197016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197017
{
public static readonly long[] Value={ 2L,9L,7L,1L,0L,5L,6L,3L,5L,2L,7L,4L,8L,2L,2L,7L,1L,6L,7L,1L,2L,2L,1L,4L,4L,3L,6L,5L,2L,6L,3L,1L,6L,1L,9L,9L,4L,0L,7L,2L,9L,6L,0L,7L,1L,0L,8L,5L,6L,7L,0L,4L,0L,0L,5L,6L,7L,6L,8L,6L,4L,5L,5L,2L,4L,8L,5L,8L,2L,3L,6L,9L,4L,8L,4L,1L,8L,0L,8L,1L,7L,7L,0L,0L,6L,8L,2L,3L,8L,4L,1L,4L,6L,4L,9L,0L,9L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197017Inst : IEnumerable<long>
{
public static readonly long[] Value=A197017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197017.Bytes);
public long this[int i]=>Value[i];

public static A197017Inst Instance=new A197017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197018
{
public static readonly long[] Value={ 2L,1L,8L,7L,2L,9L,4L,8L,8L,8L,0L,3L,6L,4L,4L,0L,6L,5L,8L,9L,7L,2L,8L,5L,2L,2L,3L,2L,6L,8L,1L,2L,1L,0L,4L,9L,3L,0L,3L,6L,3L,6L,1L,9L,9L,7L,3L,1L,4L,1L,4L,9L,9L,5L,8L,2L,2L,1L,6L,6L,9L,4L,6L,6L,9L,0L,3L,1L,8L,5L,8L,6L,5L,0L,7L,6L,2L,9L,6L,0L,6L,3L,4L,5L,6L,6L,6L,1L,3L,7L,9L,4L,2L,8L,4L,3L,0L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197018Inst : IEnumerable<long>
{
public static readonly long[] Value=A197018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197018.Bytes);
public long this[int i]=>Value[i];

public static A197018Inst Instance=new A197018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197019
{
public static readonly long[] Value={ 1L,7L,1L,9L,9L,4L,5L,1L,7L,3L,4L,8L,1L,0L,1L,6L,9L,0L,7L,3L,9L,0L,2L,4L,8L,6L,5L,4L,4L,8L,7L,1L,4L,9L,5L,4L,3L,9L,4L,8L,8L,2L,2L,2L,6L,6L,4L,9L,3L,9L,8L,1L,5L,8L,8L,7L,3L,3L,3L,6L,3L,7L,9L,7L,1L,0L,0L,0L,0L,9L,9L,8L,4L,8L,7L,9L,6L,2L,8L,7L,0L,9L,0L,3L,8L,6L,7L,0L,8L,8L,4L,8L,6L,8L,9L,7L,3L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197019Inst : IEnumerable<long>
{
public static readonly long[] Value=A197019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197019.Bytes);
public long this[int i]=>Value[i];

public static A197019Inst Instance=new A197019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197020
{
public static readonly long[] Value={ 4L,6L,1L,9L,2L,3L,1L,8L,7L,7L,0L,5L,2L,2L,8L,2L,3L,8L,2L,1L,7L,1L,5L,3L,0L,3L,3L,3L,6L,9L,3L,8L,9L,9L,9L,9L,6L,2L,0L,4L,3L,4L,7L,2L,6L,7L,0L,5L,6L,8L,8L,6L,5L,7L,9L,7L,6L,7L,0L,6L,4L,3L,0L,3L,7L,9L,5L,1L,1L,3L,9L,4L,1L,1L,5L,2L,5L,1L,1L,1L,6L,7L,9L,9L,7L,9L,8L,7L,4L,3L,0L,9L,9L,4L,4L,1L,5L,0L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197020Inst : IEnumerable<long>
{
public static readonly long[] Value=A197020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197020.Bytes);
public long this[int i]=>Value[i];

public static A197020Inst Instance=new A197020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197021
{
public static readonly long[] Value={ 3L,7L,1L,8L,1L,1L,0L,4L,1L,7L,3L,6L,1L,7L,2L,1L,8L,4L,0L,1L,9L,5L,6L,4L,7L,3L,5L,1L,5L,8L,8L,5L,7L,9L,0L,2L,8L,9L,7L,0L,6L,2L,6L,3L,9L,2L,8L,8L,3L,6L,4L,8L,1L,7L,8L,7L,7L,3L,4L,1L,4L,7L,3L,3L,1L,8L,5L,2L,8L,8L,2L,0L,5L,1L,3L,1L,2L,7L,3L,1L,4L,2L,0L,5L,9L,8L,0L,8L,0L,0L,1L,2L,2L,6L,8L,5L,7L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197021Inst : IEnumerable<long>
{
public static readonly long[] Value=A197021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197021.Bytes);
public long this[int i]=>Value[i];

public static A197021Inst Instance=new A197021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197022
{
public static readonly long[] Value={ 3L,0L,4L,6L,7L,5L,3L,6L,3L,3L,0L,6L,6L,0L,7L,4L,5L,2L,4L,0L,2L,1L,6L,8L,4L,3L,1L,6L,6L,7L,7L,5L,8L,1L,9L,5L,4L,8L,5L,6L,3L,6L,3L,6L,9L,6L,8L,1L,4L,2L,8L,7L,7L,9L,1L,0L,1L,1L,4L,9L,8L,1L,8L,4L,3L,6L,2L,9L,3L,8L,8L,3L,2L,7L,2L,6L,0L,2L,1L,7L,2L,3L,5L,2L,6L,2L,5L,4L,5L,3L,2L,3L,4L,0L,4L,7L,2L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197022Inst : IEnumerable<long>
{
public static readonly long[] Value=A197022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197022.Bytes);
public long this[int i]=>Value[i];

public static A197022Inst Instance=new A197022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197023
{
public static readonly long[] Value={ 3L,9L,5L,8L,6L,2L,4L,3L,7L,8L,4L,7L,4L,8L,0L,7L,9L,8L,2L,4L,0L,7L,0L,7L,7L,2L,2L,5L,6L,6L,3L,1L,5L,5L,2L,7L,3L,3L,4L,3L,4L,3L,9L,2L,9L,2L,4L,9L,1L,0L,0L,0L,8L,2L,5L,0L,4L,4L,2L,7L,9L,6L,3L,2L,5L,1L,2L,6L,4L,4L,3L,7L,9L,1L,1L,1L,8L,8L,1L,3L,0L,8L,6L,6L,5L,3L,8L,4L,8L,9L,0L,0L,5L,9L,1L,5L,8L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197023Inst : IEnumerable<long>
{
public static readonly long[] Value=A197023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197023.Bytes);
public long this[int i]=>Value[i];

public static A197023Inst Instance=new A197023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197024
{
public static readonly long[] Value={ 2L,3L,4L,0L,0L,5L,1L,4L,0L,5L,9L,5L,1L,3L,7L,9L,0L,1L,7L,3L,4L,7L,2L,7L,6L,2L,3L,7L,6L,7L,2L,2L,9L,9L,6L,0L,6L,2L,0L,4L,5L,8L,8L,8L,6L,4L,7L,4L,9L,5L,1L,1L,9L,4L,1L,4L,4L,3L,8L,1L,0L,3L,3L,4L,0L,3L,0L,6L,3L,4L,2L,1L,9L,4L,1L,8L,8L,9L,9L,4L,7L,3L,6L,2L,2L,0L,5L,9L,8L,6L,0L,2L,2L,8L,6L,1L,5L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197024Inst : IEnumerable<long>
{
public static readonly long[] Value=A197024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197024.Bytes);
public long this[int i]=>Value[i];

public static A197024Inst Instance=new A197024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197025
{
public static readonly long[] Value={ 7L,0L,9L,9L,1L,4L,9L,2L,6L,8L,6L,0L,4L,3L,9L,9L,2L,1L,4L,0L,9L,5L,9L,3L,8L,8L,9L,1L,6L,2L,5L,5L,8L,8L,7L,3L,4L,8L,0L,0L,2L,9L,4L,2L,6L,7L,8L,4L,6L,5L,6L,6L,5L,4L,0L,4L,6L,9L,1L,2L,2L,1L,1L,0L,5L,0L,6L,6L,9L,0L,1L,8L,1L,5L,4L,2L,7L,7L,6L,0L,0L,7L,2L,4L,9L,1L,9L,4L,6L,5L,3L,3L,2L,0L,2L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197025Inst : IEnumerable<long>
{
public static readonly long[] Value=A197025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197025.Bytes);
public long this[int i]=>Value[i];

public static A197025Inst Instance=new A197025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197026
{
public static readonly long[] Value={ 4L,2L,7L,4L,3L,2L,4L,5L,1L,6L,9L,3L,5L,8L,5L,8L,2L,7L,1L,9L,2L,6L,8L,0L,2L,4L,1L,7L,9L,6L,1L,6L,4L,7L,2L,0L,3L,6L,8L,0L,0L,9L,4L,8L,2L,8L,2L,9L,0L,5L,0L,9L,5L,2L,2L,1L,7L,3L,9L,7L,4L,6L,3L,4L,1L,8L,3L,1L,9L,9L,8L,4L,8L,5L,3L,6L,3L,3L,8L,1L,6L,4L,3L,8L,6L,8L,1L,5L,0L,4L,5L,9L,7L,8L,4L,7L,7L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197026Inst : IEnumerable<long>
{
public static readonly long[] Value=A197026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197026.Bytes);
public long this[int i]=>Value[i];

public static A197026Inst Instance=new A197026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197027
{
public static readonly long[] Value={ 1L,3L,2L,1L,1L,3L,7L,4L,7L,6L,5L,2L,2L,8L,5L,9L,7L,8L,2L,8L,0L,9L,0L,0L,9L,8L,4L,9L,5L,8L,2L,5L,1L,6L,2L,4L,4L,3L,1L,5L,6L,3L,7L,9L,7L,6L,8L,2L,7L,5L,4L,6L,2L,6L,4L,4L,3L,4L,6L,5L,0L,4L,2L,9L,9L,8L,3L,5L,8L,8L,3L,0L,0L,9L,6L,6L,5L,9L,9L,7L,7L,4L,3L,6L,5L,9L,4L,4L,1L,1L,3L,4L,6L,0L,4L,5L,4L,3L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197027Inst : IEnumerable<long>
{
public static readonly long[] Value=A197027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197027.Bytes);
public long this[int i]=>Value[i];

public static A197027Inst Instance=new A197027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197028
{
public static readonly long[] Value={ 7L,3L,6L,6L,0L,6L,6L,3L,4L,1L,4L,7L,1L,5L,1L,8L,2L,4L,9L,9L,2L,0L,7L,8L,9L,0L,5L,0L,8L,2L,4L,5L,2L,0L,6L,4L,8L,2L,2L,7L,6L,0L,6L,3L,9L,9L,8L,3L,9L,0L,2L,7L,9L,1L,5L,0L,8L,1L,4L,8L,0L,8L,0L,6L,8L,3L,6L,8L,0L,1L,0L,5L,1L,2L,3L,8L,5L,3L,9L,8L,9L,0L,6L,3L,9L,4L,3L,6L,5L,7L,3L,0L,8L,0L,0L,9L,2L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197028Inst : IEnumerable<long>
{
public static readonly long[] Value=A197028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197028.Bytes);
public long this[int i]=>Value[i];

public static A197028Inst Instance=new A197028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197029
{
public static readonly long[] Value={ 5L,0L,6L,0L,6L,4L,3L,3L,3L,2L,1L,6L,5L,2L,4L,5L,1L,0L,0L,5L,4L,6L,3L,7L,6L,2L,1L,7L,7L,3L,4L,7L,1L,4L,4L,1L,1L,6L,9L,4L,8L,7L,3L,8L,8L,6L,1L,8L,3L,2L,2L,7L,7L,3L,2L,8L,6L,6L,4L,0L,3L,6L,7L,1L,7L,8L,8L,6L,3L,1L,4L,2L,1L,9L,5L,5L,2L,2L,8L,4L,0L,9L,3L,3L,8L,4L,7L,3L,0L,0L,8L,5L,2L,6L,1L,4L,6L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197029Inst : IEnumerable<long>
{
public static readonly long[] Value=A197029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197029.Bytes);
public long this[int i]=>Value[i];

public static A197029Inst Instance=new A197029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197030
{
public static readonly long[] Value={ 5L,0L,6L,0L,9L,5L,4L,6L,4L,3L,7L,5L,4L,8L,9L,2L,5L,1L,4L,6L,3L,0L,1L,2L,3L,8L,5L,0L,4L,5L,3L,0L,6L,4L,4L,0L,9L,0L,0L,3L,3L,8L,5L,3L,3L,1L,4L,6L,5L,4L,0L,1L,5L,6L,1L,9L,5L,4L,2L,7L,4L,3L,1L,2L,0L,2L,7L,4L,0L,1L,6L,0L,2L,7L,6L,2L,4L,5L,2L,8L,2L,5L,8L,5L,5L,3L,7L,3L,3L,6L,6L,2L,2L,9L,6L,3L,7L,8L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197030Inst : IEnumerable<long>
{
public static readonly long[] Value=A197030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197030.Bytes);
public long this[int i]=>Value[i];

public static A197030Inst Instance=new A197030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197031
{
public static readonly long[] Value={ 3L,3L,9L,7L,3L,4L,6L,9L,5L,1L,0L,1L,7L,6L,9L,3L,4L,4L,1L,2L,7L,7L,9L,1L,3L,7L,5L,5L,5L,0L,1L,4L,1L,0L,7L,9L,0L,4L,8L,9L,4L,8L,3L,4L,8L,7L,5L,2L,7L,1L,7L,7L,6L,3L,8L,3L,9L,0L,1L,6L,2L,1L,4L,8L,3L,4L,9L,4L,4L,0L,2L,8L,9L,4L,5L,1L,6L,7L,8L,5L,1L,6L,6L,0L,9L,9L,1L,1L,3L,2L,6L,0L,6L,7L,1L,8L,4L,5L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197031Inst : IEnumerable<long>
{
public static readonly long[] Value=A197031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197031.Bytes);
public long this[int i]=>Value[i];

public static A197031Inst Instance=new A197031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197032
{
public static readonly long[] Value={ 2L,3L,5L,3L,2L,0L,9L,9L,6L,4L,1L,9L,9L,3L,2L,4L,4L,2L,9L,4L,8L,3L,1L,0L,1L,3L,3L,2L,5L,7L,7L,3L,8L,8L,4L,5L,7L,2L,7L,0L,7L,0L,5L,6L,1L,3L,8L,5L,6L,8L,4L,6L,8L,2L,6L,8L,0L,6L,6L,9L,3L,0L,4L,2L,6L,5L,1L,5L,1L,8L,9L,7L,2L,3L,2L,2L,0L,9L,2L,0L,8L,5L,9L,1L,8L,1L,6L,4L,7L,0L,6L,9L,1L,1L,1L,6L,4L,5L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197032Inst : IEnumerable<long>
{
public static readonly long[] Value=A197032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197032.Bytes);
public long this[int i]=>Value[i];

public static A197032Inst Instance=new A197032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197033
{
public static readonly long[] Value={ 1L,8L,4L,4L,2L,7L,1L,6L,8L,1L,7L,0L,0L,1L,7L,1L,8L,6L,4L,7L,7L,9L,9L,5L,7L,7L,4L,4L,2L,7L,3L,5L,7L,0L,2L,9L,8L,4L,1L,3L,4L,8L,7L,6L,3L,3L,8L,7L,7L,0L,9L,5L,0L,9L,1L,5L,7L,4L,7L,9L,4L,0L,1L,7L,8L,6L,4L,8L,7L,6L,8L,3L,4L,3L,8L,5L,3L,8L,8L,6L,1L,2L,4L,8L,5L,0L,6L,4L,4L,7L,0L,9L,9L,7L,5L,8L,1L,8L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197033Inst : IEnumerable<long>
{
public static readonly long[] Value=A197033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197033.Bytes);
public long this[int i]=>Value[i];

public static A197033Inst Instance=new A197033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197034
{
public static readonly long[] Value={ 3L,4L,7L,7L,9L,6L,7L,2L,4L,3L,0L,0L,9L,0L,1L,2L,4L,7L,4L,6L,4L,6L,9L,2L,5L,0L,8L,1L,3L,4L,2L,1L,7L,5L,1L,0L,1L,4L,4L,7L,5L,4L,9L,5L,5L,2L,7L,5L,8L,1L,9L,3L,4L,4L,4L,2L,3L,5L,9L,0L,9L,9L,3L,8L,6L,0L,4L,6L,0L,4L,0L,6L,3L,1L,9L,6L,0L,1L,1L,8L,7L,6L,9L,8L,4L,9L,7L,7L,5L,3L,6L,2L,6L,5L,5L,3L,0L,8L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197034Inst : IEnumerable<long>
{
public static readonly long[] Value=A197034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197034.Bytes);
public long this[int i]=>Value[i];

public static A197034Inst Instance=new A197034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197035
{
public static readonly long[] Value={ 2L,6L,0L,8L,1L,9L,4L,0L,2L,4L,9L,6L,1L,0L,1L,8L,9L,0L,1L,9L,9L,0L,1L,4L,4L,5L,4L,2L,8L,3L,5L,2L,2L,3L,9L,5L,9L,0L,8L,3L,5L,8L,9L,1L,1L,5L,8L,7L,9L,5L,9L,7L,6L,7L,4L,4L,9L,4L,9L,1L,7L,7L,5L,6L,3L,8L,5L,7L,7L,4L,4L,9L,2L,8L,8L,4L,1L,8L,9L,9L,6L,8L,0L,3L,9L,1L,0L,4L,3L,1L,5L,5L,9L,0L,5L,1L,4L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197035Inst : IEnumerable<long>
{
public static readonly long[] Value=A197035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197035.Bytes);
public long this[int i]=>Value[i];

public static A197035Inst Instance=new A197035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197036
{
public static readonly long[] Value={ 1L,2L,6L,6L,0L,6L,5L,8L,7L,7L,7L,5L,2L,0L,0L,8L,3L,3L,5L,5L,9L,8L,2L,4L,4L,6L,2L,5L,2L,1L,4L,7L,1L,7L,5L,3L,7L,6L,0L,7L,6L,7L,0L,3L,1L,1L,3L,5L,4L,9L,6L,2L,2L,0L,6L,8L,0L,8L,1L,3L,5L,3L,3L,1L,2L,1L,3L,5L,7L,5L,0L,1L,6L,1L,2L,2L,7L,7L,5L,4L,7L,0L,3L,9L,4L,8L,1L,8L,3L,5L,7L,1L,4L,7L,2L,8L,0L,1L,0L,1L,8L,7L,1L,0L,3L,6L,1L,3L,4L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197036Inst : IEnumerable<long>
{
public static readonly long[] Value=A197036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197036.Bytes);
public long this[int i]=>Value[i];

public static A197036Inst Instance=new A197036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197037
{
public static readonly long[] Value={ 7L,1L,0L,2L,4L,3L,1L,8L,5L,9L,3L,7L,8L,9L,0L,8L,8L,8L,7L,3L,8L,5L,2L,6L,6L,7L,7L,8L,1L,1L,6L,5L,0L,7L,4L,4L,9L,4L,4L,4L,0L,9L,9L,5L,8L,3L,2L,9L,7L,0L,3L,1L,9L,8L,1L,2L,3L,0L,1L,5L,1L,6L,5L,5L,7L,3L,9L,6L,9L,1L,1L,5L,6L,8L,8L,2L,3L,8L,1L,8L,0L,9L,7L,7L,3L,5L,4L,0L,3L,9L,1L,5L,7L,9L,1L,1L,7L,2L,5L,8L,3L,3L,6L,3L,6L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197037Inst : IEnumerable<long>
{
public static readonly long[] Value=A197037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197037.Bytes);
public long this[int i]=>Value[i];

public static A197037Inst Instance=new A197037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197038
{
public static readonly long[] Value={ 12L,412L,436L,916L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197038Inst : IEnumerable<long>
{
public static readonly long[] Value=A197038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197038.Bytes);
public long this[int i]=>Value[i];

public static A197038Inst Instance=new A197038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197039
{
public static readonly long[] Value={ 1L,4L,9L,10L,12L,21L,22L,40L,48L,84L,88L,90L,100L,102L,120L,123L,126L,132L,162L,168L,186L,201L,202L,210L,213L,216L,220L,231L,261L,312L,321L,333L,400L,408L,480L,612L,618L,621L,681L,804L,808L,816L,840L,861L,880L,900L,1000L,1002L,1020L,1023L,1026L,1032L,1062L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197039Inst : IEnumerable<long>
{
public static readonly long[] Value=A197039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197039.Bytes);
public long this[int i]=>Value[i];

public static A197039Inst Instance=new A197039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197040
{
public static readonly long[] Value={ 3L,8L,9L,8L,9L,9L,6L,9L,10L,8L,7L,9L,6L,8L,7L,8L,11L,6L,7L,8L,9L,8L,7L,6L,8L,10L,6L,6L,6L,8L,8L,8L,8L,9L,6L,9L,7L,6L,7L,8L,8L,9L,7L,11L,7L,8L,5L,9L,8L,9L,9L,7L,6L,7L,9L,6L,7L,9L,7L,8L,10L,5L,9L,7L,7L,7L,7L,6L,9L,9L,6L,8L,7L,9L,8L,6L,9L,5L,9L,9L,8L,6L,6L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197040Inst : IEnumerable<long>
{
public static readonly long[] Value=A197040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197040.Bytes);
public long this[int i]=>Value[i];

public static A197040Inst Instance=new A197040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197041
{
public static readonly long[] Value={ 1L,7L,120L,7407L,1563352L,1146653592L,2887590375825L,24713390632082079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197041Inst : IEnumerable<long>
{
public static readonly long[] Value=A197041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197041.Bytes);
public long this[int i]=>Value[i];

public static A197041Inst Instance=new A197041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197042
{
public static readonly long[] Value={ 2L,20L,120L,698L,4080L,24074L,141856L,833758L,4909544L,28899922L,170120402L,1001361542L,5894102732L,34694985108L,204224876622L,1202124327402L,7076038423114L,41651567268298L,245173129915012L,1443158678807678L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197042Inst : IEnumerable<long>
{
public static readonly long[] Value=A197042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197042.Bytes);
public long this[int i]=>Value[i];

public static A197042Inst Instance=new A197042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197043
{
public static readonly long[] Value={ 3L,65L,698L,7407L,79785L,855746L,9248339L,99900759L,1077578216L,11625151797L,125460417513L,1353828298540L,14607942448781L,157629746459857L,1700936665665566L,18354053399564603L,198051140064611759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197043Inst : IEnumerable<long>
{
public static readonly long[] Value=A197043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197043.Bytes);
public long this[int i]=>Value[i];

public static A197043Inst Instance=new A197043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197044
{
public static readonly BigInteger[] Value={ 5L,203L,4080L,79785L,1563352L,31096170L,621506173L,12367566377L,246209727883L,4904183446578L,97655063600656L,1944656969992804L,38726607687532464L,771192417913040813L,15357390085688256362UL,BigInteger.Parse("305826177600042178901") };
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
public class A197044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197044Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197044.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197044.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197044Inst Instance=new A197044Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197045
{
public static readonly BigInteger[] Value={ 8L,648L,24074L,855746L,31096170L,1146653592L,42346212260L,1557004531014L,57353100417462L,2112382332611192L,77779202686257778L,2864298209626136384L,BigInteger.Parse("105477500014169550206"),BigInteger.Parse("3884216011047782491710"),BigInteger.Parse("143037133564177615552516") };
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
public class A197045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197045Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197045.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197045.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197045Inst Instance=new A197045Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197046
{
public static readonly BigInteger[] Value={ 13L,2057L,141856L,9248339L,621506173L,42346212260L,2887590375825L,196473830384459L,13380873189121311L,910764986424304753L,BigInteger.Parse("61996774523408648312"),BigInteger.Parse("4220890096247905089568"),BigInteger.Parse("287338357690684994223092") };
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
public class A197046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197046Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197046.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197046.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197046Inst Instance=new A197046Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197047
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,2L,3L,20L,20L,3L,5L,65L,120L,65L,5L,8L,203L,698L,698L,203L,8L,13L,648L,4080L,7407L,4080L,648L,13L,21L,2057L,24074L,79785L,79785L,24074L,2057L,21L,34L,6527L,141856L,855746L,1563352L,855746L,141856L,6527L,34L,55L,20740L,833758L,9248339L,31096170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197047Inst : IEnumerable<long>
{
public static readonly long[] Value=A197047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197047.Bytes);
public long this[int i]=>Value[i];

public static A197047Inst Instance=new A197047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197048
{
public static readonly long[] Value={ 1L,2L,10L,42L,358L,4468L,88056L,2745186L,134355866L,10264692132L,1234801357470L,232966546265096L,68939282741912248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197048Inst : IEnumerable<long>
{
public static readonly long[] Value=A197048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197048.Bytes);
public long this[int i]=>Value[i];

public static A197048Inst Instance=new A197048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197049
{
public static readonly long[] Value={ 2L,4L,10L,18L,38L,78L,156L,320L,654L,1326L,2706L,5518L,11228L,22884L,46634L,94978L,193518L,394286L,803220L,1636448L,3334030L,6792334L,13838202L,28192958L,57437684L,117018884L,238404906L,485705682L,989536598L,2016000430L,4107230284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197049Inst : IEnumerable<long>
{
public static readonly long[] Value=A197049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197049.Bytes);
public long this[int i]=>Value[i];

public static A197049Inst Instance=new A197049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197050
{
public static readonly long[] Value={ 3L,6L,18L,42L,108L,274L,692L,1754L,4442L,11248L,28488L,72146L,182712L,462728L,1171876L,2967826L,7516146L,19034954L,48206826L,122085820L,309187486L,783030352L,1983057390L,5022176478L,12718873752L,32211084212L,81575929322L,206594481604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197050Inst : IEnumerable<long>
{
public static readonly long[] Value=A197050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197050.Bytes);
public long this[int i]=>Value[i];

public static A197050Inst Instance=new A197050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197051
{
public static readonly long[] Value={ 4L,10L,38L,108L,358L,1132L,3580L,11382L,36270L,114992L,365628L,1162290L,3692624L,11733828L,37293892L,118504546L,376583590L,1196750110L,3803034578L,12085297922L,38405269512L,122045123484L,387837623386L,1232482503260L,3916616317912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197051Inst : IEnumerable<long>
{
public static readonly long[] Value=A197051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197051.Bytes);
public long this[int i]=>Value[i];

public static A197051Inst Instance=new A197051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197052
{
public static readonly long[] Value={ 5L,16L,78L,274L,1132L,4468L,17742L,70616L,281202L,1117442L,4448148L,17693664L,70390082L,280040518L,1114106280L,4432207738L,17633023628L,70149839190L,279079644000L,1110273409628L,4417041071578L,17572471614384L,69909222737482L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197052Inst : IEnumerable<long>
{
public static readonly long[] Value=A197052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197052.Bytes);
public long this[int i]=>Value[i];

public static A197052Inst Instance=new A197052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197053
{
public static readonly long[] Value={ 7L,26L,156L,692L,3580L,17742L,88056L,439338L,2192602L,10912392L,54394628L,271160024L,1351103246L,6733077562L,33557756016L,167232569172L,833404135538L,4153405692526L,20698773896328L,103153449929238L,514074952403758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197053Inst : IEnumerable<long>
{
public static readonly long[] Value=A197053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197053.Bytes);
public long this[int i]=>Value[i];

public static A197053Inst Instance=new A197053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197054
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,3L,4L,4L,3L,4L,6L,10L,6L,4L,5L,10L,18L,18L,10L,5L,7L,16L,38L,42L,38L,16L,7L,9L,26L,78L,108L,108L,78L,26L,9L,12L,42L,156L,274L,358L,274L,156L,42L,12L,16L,68L,320L,692L,1132L,1132L,692L,320L,68L,16L,21L,110L,654L,1754L,3580L,4468L,3580L,1754L,654L,110L,21L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197054Inst : IEnumerable<long>
{
public static readonly long[] Value=A197054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197054.Bytes);
public long this[int i]=>Value[i];

public static A197054Inst Instance=new A197054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197055
{
public static readonly long[] Value={ 1L,2L,6L,18L,48L,211L,1685L,17107L,194842L,2735810L,54757712L,1541398741L,56647655849L,2661035439470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197055Inst : IEnumerable<long>
{
public static readonly long[] Value=A197055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197055.Bytes);
public long this[int i]=>Value[i];

public static A197055Inst Instance=new A197055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197056
{
public static readonly long[] Value={ 1L,3L,6L,10L,14L,22L,38L,67L,111L,179L,291L,485L,812L,1348L,2220L,3660L,6060L,10053L,16653L,27541L,45541L,75367L,124786L,206574L,341850L,565666L,936146L,1549447L,2564507L,4244263L,7024071L,11624777L,19239384L,31841864L,52698776L,87216664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197056Inst : IEnumerable<long>
{
public static readonly long[] Value=A197056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197056.Bytes);
public long this[int i]=>Value[i];

public static A197056Inst Instance=new A197056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197057
{
public static readonly long[] Value={ 1L,4L,10L,18L,28L,47L,93L,189L,357L,640L,1156L,2162L,4102L,7697L,14243L,26307L,48917L,91394L,170572L,317326L,589634L,1096821L,2042877L,3805343L,7083795L,13181280L,24530278L,45664276L,85014554L,158256855L,294565501L,548276423L,1020572419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197057Inst : IEnumerable<long>
{
public static readonly long[] Value=A197057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197057.Bytes);
public long this[int i]=>Value[i];

public static A197057Inst Instance=new A197057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197058
{
public static readonly long[] Value={ 1L,5L,14L,28L,48L,90L,200L,447L,937L,1881L,3813L,7947L,16720L,34862L,71998L,148612L,308152L,640701L,1330955L,2759769L,5719391L,11860647L,24611330L,51069476L,105937956L,219719928L,455740768L,945408061L,1961252075L,4068435185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197058Inst : IEnumerable<long>
{
public static readonly long[] Value=A197058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197058.Bytes);
public long this[int i]=>Value[i];

public static A197058Inst Instance=new A197058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197059
{
public static readonly long[] Value={ 1L,7L,22L,47L,90L,211L,547L,1364L,3190L,7411L,17630L,42520L,101976L,242655L,576887L,1375887L,3286861L,7846310L,18711439L,44618322L,106438197L,253962851L,605897990L,1445349638L,3447805485L,8224998562L,19621841396L,46809917238L,111668032901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197059Inst : IEnumerable<long>
{
public static readonly long[] Value=A197059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197059.Bytes);
public long this[int i]=>Value[i];

public static A197059Inst Instance=new A197059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197060
{
public static readonly long[] Value={ 1L,10L,38L,93L,200L,547L,1685L,4932L,13343L,35901L,99603L,280909L,785677L,2175329L,6019355L,16730920L,46595762L,129615164L,360051905L,1000167816L,2780017546L,7729131408L,21485039780L,59712094301L,165955469526L,461272868992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197060Inst : IEnumerable<long>
{
public static readonly long[] Value=A197060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197060.Bytes);
public long this[int i]=>Value[i];

public static A197060Inst Instance=new A197060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197061
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,6L,4L,1L,1L,5L,10L,10L,5L,1L,1L,7L,14L,18L,14L,7L,1L,1L,10L,22L,28L,28L,22L,10L,1L,1L,14L,38L,47L,48L,47L,38L,14L,1L,1L,19L,67L,93L,90L,90L,93L,67L,19L,1L,1L,26L,111L,189L,200L,211L,200L,189L,111L,26L,1L,1L,36L,179L,357L,447L,547L,547L,447L,357L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197061Inst : IEnumerable<long>
{
public static readonly long[] Value=A197061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197061.Bytes);
public long this[int i]=>Value[i];

public static A197061Inst Instance=new A197061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197062
{
public static readonly long[] Value={ 3L,8L,13L,17L,31L,32L,50L,55L,75L,91L,98L,100L,105L,129L,162L,183L,241L,288L,311L,334L,381L,392L,413L,489L,553L,578L,615L,651L,670L,722L,726L,741L,844L,968L,1013L,1152L,1164L,1261L,1264L,1461L,1561L,1601L,1682L,1800L,1809L,1905L,1979L,2048L,2225L,2312L,2450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197062Inst : IEnumerable<long>
{
public static readonly long[] Value=A197062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197062.Bytes);
public long this[int i]=>Value[i];

public static A197062Inst Instance=new A197062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197063
{
public static readonly BigInteger[] Value={ 1L,5L,76L,3466L,645970L,387792259L,814152081238L,5880410307808966L,BigInteger.Parse("145748906353392828573") };
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
public class A197063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197063Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197063.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197063.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197063Inst Instance=new A197063Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197064
{
public static readonly long[] Value={ 3L,11L,76L,408L,2026L,10582L,55882L,292564L,1530151L,8011519L,41953630L,219665320L,1150106497L,6021786417L,31529327887L,165083020845L,864350463984L,4525614428894L,23695466872796L,124066050968884L,649591959407978L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197064Inst : IEnumerable<long>
{
public static readonly long[] Value=A197064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197064.Bytes);
public long this[int i]=>Value[i];

public static A197064Inst Instance=new A197064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197065
{
public static readonly long[] Value={ 4L,34L,408L,3466L,33407L,338295L,3302634L,32228538L,317069301L,3110367731L,30494103708L,299200276162L,2935153005359L,28791440736323L,282438007986238L,2770639649805104L,27178969275479327L,266616968388816645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197065Inst : IEnumerable<long>
{
public static readonly long[] Value=A197065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197065.Bytes);
public long this[int i]=>Value[i];

public static A197065Inst Instance=new A197065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197066
{
public static readonly BigInteger[] Value={ 6L,101L,2026L,33407L,645970L,11800402L,211057159L,3846342121L,70050139103L,1273134867769L,23158212416004L,421168937252570L,7658668692237200L,139281021815759142L,2532960317909556863L,BigInteger.Parse("46063788501768631565") };
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
public class A197066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197066Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197066.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197066.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197066Inst Instance=new A197066Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197067
{
public static readonly BigInteger[] Value={ 9L,299L,10582L,338295L,11800402L,387792259L,12999535244L,440670363348L,14820242617606L,498301224553681L,16772367971351743L,564485156664944432L,BigInteger.Parse("18997537893037092284"),BigInteger.Parse("639342717193072673719"),BigInteger.Parse("21516206463644850941597") };
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
public class A197067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197067Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197067.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197067.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197067Inst Instance=new A197067Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197068
{
public static readonly BigInteger[] Value={ 13L,890L,55882L,3302634L,211057159L,12999535244L,814152081238L,50916124396857L,3169573665892646L,197847302932994974L,12351729551918734858UL,BigInteger.Parse("770687990728503616778"),BigInteger.Parse("48091585181900385239782"),BigInteger.Parse("3001138140644565155352997") };
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
public class A197068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197068Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197068.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197068.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197068Inst Instance=new A197068Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197069
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,3L,4L,11L,11L,4L,6L,34L,76L,34L,6L,9L,101L,408L,408L,101L,9L,13L,299L,2026L,3466L,2026L,299L,13L,19L,890L,10582L,33407L,33407L,10582L,890L,19L,28L,2643L,55882L,338295L,645970L,338295L,55882L,2643L,28L,41L,7855L,292564L,3302634L,11800402L,11800402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197069Inst : IEnumerable<long>
{
public static readonly long[] Value=A197069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197069.Bytes);
public long this[int i]=>Value[i];

public static A197069Inst Instance=new A197069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197070
{
public static readonly long[] Value={ 9L,0L,1L,5L,4L,2L,6L,7L,7L,3L,6L,9L,6L,9L,5L,7L,1L,4L,0L,4L,9L,8L,0L,3L,6L,2L,1L,1L,3L,3L,5L,8L,7L,4L,9L,3L,0L,7L,3L,7L,3L,9L,7L,1L,9L,2L,5L,5L,3L,7L,4L,1L,6L,1L,3L,4L,4L,2L,0L,3L,6L,6L,6L,5L,0L,6L,3L,7L,8L,6L,5L,4L,3L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197070Inst : IEnumerable<long>
{
public static readonly long[] Value=A197070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197070.Bytes);
public long this[int i]=>Value[i];

public static A197070Inst Instance=new A197070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197071
{
public static readonly long[] Value={ 1L,3L,6L,4L,3L,7L,6L,3L,5L,3L,8L,4L,1L,8L,4L,1L,3L,4L,7L,4L,8L,5L,7L,8L,3L,6L,2L,5L,4L,3L,1L,3L,5L,5L,7L,7L,0L,2L,1L,0L,1L,2L,7L,4L,8L,3L,7L,2L,3L,9L,2L,4L,3L,9L,9L,9L,0L,0L,8L,5L,4L,7L,3L,1L,9L,9L,5L,9L,2L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197071Inst : IEnumerable<long>
{
public static readonly long[] Value=A197071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197071.Bytes);
public long this[int i]=>Value[i];

public static A197071Inst Instance=new A197071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197072
{
public static readonly long[] Value={ -1L,1L,5L,15L,25L,49L,97L,181L,433L,819L,1541L,3147L,6271L,12469L,25087L,49455L,99255L,196057L,391815L,781893L,1555935L,3106511L,6191001L,12351963L,24658715L,49173803L,98136735L,195868789L,391110307L,780774507L,1559147549L,3113261723L,6218243597L,12419791799L,24808942497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197072Inst : IEnumerable<long>
{
public static readonly long[] Value=A197072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197072.Bytes);
public long this[int i]=>Value[i];

public static A197072Inst Instance=new A197072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197073
{
public static readonly long[] Value={ 1L,6L,51L,1407L,109286L,25822213L,17446576240L,34357189974652L,197907262786979354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197073Inst : IEnumerable<long>
{
public static readonly long[] Value=A197073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197073.Bytes);
public long this[int i]=>Value[i];

public static A197073Inst Instance=new A197073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197074
{
public static readonly long[] Value={ 3L,13L,51L,205L,812L,3295L,13286L,53418L,215148L,866828L,3490915L,14058935L,56624663L,228059383L,918511377L,3699344410L,14899280605L,60007424663L,241682293896L,973385377892L,3920348996747L,15789363847963L,63592303009792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197074Inst : IEnumerable<long>
{
public static readonly long[] Value=A197074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197074.Bytes);
public long this[int i]=>Value[i];

public static A197074Inst Instance=new A197074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197075
{
public static readonly long[] Value={ 4L,34L,205L,1407L,9492L,65251L,445506L,3041309L,20782756L,142011656L,970224226L,6628930320L,45292120759L,309453920284L,2114314490865L,14445886493697L,98700314097726L,674361537935123L,4607518893055747L,31480487717138869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197075Inst : IEnumerable<long>
{
public static readonly long[] Value=A197075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197075.Bytes);
public long this[int i]=>Value[i];

public static A197075Inst Instance=new A197075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197076
{
public static readonly long[] Value={ 6L,81L,812L,9492L,109286L,1282123L,14895018L,173097490L,2014367937L,23437273689L,272686908212L,3172875930820L,36918402757845L,429566882643506L,4998281938091148L,58158282162055320L,676709925624440764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197076Inst : IEnumerable<long>
{
public static readonly long[] Value=A197076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197076.Bytes);
public long this[int i]=>Value[i];

public static A197076Inst Instance=new A197076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197077
{
public static readonly BigInteger[] Value={ 9L,199L,3295L,65251L,1282123L,25822213L,513380599L,10204673140L,203083535620L,4041562578683L,80433524292272L,1600907292520303L,31864518855986700L,634235619536089218L,12624003209531266181UL,BigInteger.Parse("251272907445585611658") };
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
public class A197077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197077Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197077.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197077.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197077Inst Instance=new A197077Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197078
{
public static readonly BigInteger[] Value={ 13L,487L,13286L,445506L,14895018L,513380599L,17446576240L,592290047724L,20128502440024L,683993118482402L,23243767206546673L,789980959730204326L,BigInteger.Parse("26850332922315114822"),BigInteger.Parse("912620325896540690864"),BigInteger.Parse("31019623434344238447439") };
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
public class A197078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197078Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197078.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197078.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197078Inst Instance=new A197078Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197079
{
public static readonly long[] Value={ 1L,2L,2L,3L,6L,3L,4L,13L,13L,4L,6L,34L,51L,34L,6L,9L,81L,205L,205L,81L,9L,13L,199L,812L,1407L,812L,199L,13L,19L,487L,3295L,9492L,9492L,3295L,487L,19L,28L,1190L,13286L,65251L,109286L,65251L,13286L,1190L,28L,41L,2910L,53418L,445506L,1282123L,1282123L,445506L,53418L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197079Inst : IEnumerable<long>
{
public static readonly long[] Value=A197079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197079.Bytes);
public long this[int i]=>Value[i];

public static A197079Inst Instance=new A197079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197080
{
public static readonly long[] Value={ 1L,5L,1L,2L,14L,1L,3L,3L,2L,2L,2L,7L,1L,4L,10L,1L,2L,2L,31L,1L,4L,1L,9L,2L,8L,1L,2L,1L,4L,1L,3L,1L,4L,2L,1L,3L,63L,1L,1L,1L,44L,1L,2L,7L,3L,2L,5L,5L,5L,9L,1L,1L,2L,10L,1L,1L,1L,2L,1L,19L,4L,2L,1L,5L,5L,16L,1L,47L,198L,3L,1L,111L,3L,2L,3L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197080Inst : IEnumerable<long>
{
public static readonly long[] Value=A197080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197080.Bytes);
public long this[int i]=>Value[i];

public static A197080Inst Instance=new A197080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197081
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,1L,2L,2L,2L,3L,3L,2L,3L,4L,3L,4L,4L,4L,5L,6L,5L,4L,6L,6L,7L,7L,7L,7L,9L,10L,8L,9L,9L,11L,12L,12L,11L,11L,13L,15L,16L,13L,15L,16L,17L,20L,19L,17L,20L,23L,20L,22L,23L,23L,27L,29L,26L,25L,30L,31L,32L,34L,33L,32L,38L,41L,37L,39L,41L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197081Inst : IEnumerable<long>
{
public static readonly long[] Value=A197081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197081.Bytes);
public long this[int i]=>Value[i];

public static A197081Inst Instance=new A197081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197082
{
public static readonly BigInteger[] Value={ 2L,9L,75L,625L,5145L,42875L,352947L,2941225L,28824005L,282475249L,4882786447L,60287465315L,744365643175L,10212696624361L,118890080527911L,1387050939492295L,17125833028425275L,211451611881577375L,2584630720649942503L,BigInteger.Parse("30088718564300934153"),BigInteger.Parse("351035049916844231785") };
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
public class A197082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197082Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197082.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197082.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197082Inst Instance=new A197082Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197083
{
public static readonly long[] Value={ 0L,10L,96L,445L,1431L,3681L,8141L,16142L,29466L,50412L,81862L,127347L,191113L,278187L,394443L,546668L,742628L,991134L,1302108L,1686649L,2157099L,2727109L,3411705L,4227354L,5192030L,6325280L,7648290L,9183951L,10956925L,12993711L,15322711L,17974296L,20980872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197083Inst : IEnumerable<long>
{
public static readonly long[] Value=A197083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197083.Bytes);
public long this[int i]=>Value[i];

public static A197083Inst Instance=new A197083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197084
{
public static readonly long[] Value={ 1L,2L,25L,631L,71867L,21996614L,21989908007L,68650847877254L,670636652224421841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197084Inst : IEnumerable<long>
{
public static readonly long[] Value=A197084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197084.Bytes);
public long this[int i]=>Value[i];

public static A197084Inst Instance=new A197084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197085
{
public static readonly long[] Value={ 1L,5L,25L,96L,422L,1780L,7537L,31911L,135283L,573054L,2427879L,10286742L,43582082L,184647156L,782310778L,3314472134L,14042671183L,59495654829L,252069704002L,1067962669281L,4524717892087L,19170212756069L,81219883046173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197085Inst : IEnumerable<long>
{
public static readonly long[] Value=A197085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197085.Bytes);
public long this[int i]=>Value[i];

public static A197085Inst Instance=new A197085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197086
{
public static readonly long[] Value={ 1L,10L,96L,631L,5101L,37952L,289564L,2200339L,16713718L,127074214L,965583306L,7338942170L,55775566553L,423896532807L,3221643820945L,24484602637498L,186084334450133L,1414249624483974L,10748366775916853L,81688112676072415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197086Inst : IEnumerable<long>
{
public static readonly long[] Value=A197086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197086.Bytes);
public long this[int i]=>Value[i];

public static A197086Inst Instance=new A197086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197087
{
public static readonly long[] Value={ 1L,26L,422L,5101L,71867L,939690L,12635748L,168802858L,2257145231L,30181119596L,403549336200L,5395982997113L,72149973349274L,964732771720273L,12899599151591706L,172482705147134597L,2306295510150788549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197087Inst : IEnumerable<long>
{
public static readonly long[] Value=A197087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197087.Bytes);
public long this[int i]=>Value[i];

public static A197087Inst Instance=new A197087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197088
{
public static readonly BigInteger[] Value={ 1L,65L,1780L,37952L,939690L,21996614L,522569033L,12390326286L,293837693200L,6966924806564L,165206045134788L,3917486496222700L,92893560385495116L,2202749723178772681L,BigInteger.Parse("52232959654975192248"),BigInteger.Parse("1238579861912517506541") };
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
public class A197088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197088Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197088.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197088.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197088Inst Instance=new A197088Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197089
{
public static readonly BigInteger[] Value={ 1L,161L,7537L,289564L,12635748L,522569033L,21989908007L,923559415946L,38737498552503L,1625808615727565L,68233833241429320L,2863571252883915815L,BigInteger.Parse("120178359677506216775"),BigInteger.Parse("5043597906899270802555"),BigInteger.Parse("211668526758336137032851") };
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
public class A197089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197089Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197089.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197089.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197089Inst Instance=new A197089Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197090
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,5L,5L,1L,1L,10L,25L,10L,1L,1L,26L,96L,96L,26L,1L,1L,65L,422L,631L,422L,65L,1L,1L,161L,1780L,5101L,5101L,1780L,161L,1L,1L,403L,7537L,37952L,71867L,37952L,7537L,403L,1L,1L,1006L,31911L,289564L,939690L,939690L,289564L,31911L,1006L,1L,1L,2511L,135283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197090Inst : IEnumerable<long>
{
public static readonly long[] Value=A197090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197090.Bytes);
public long this[int i]=>Value[i];

public static A197090Inst Instance=new A197090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197091
{
public static readonly BigInteger[] Value={ 1L,7L,74L,3477L,457357L,183439730L,227951140324L,864930843239459L,10066466828015680364UL,BigInteger.Parse("359074320635161326740035") };
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
public class A197091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197091Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197091.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197091.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197091Inst Instance=new A197091Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197092
{
public static readonly long[] Value={ 1L,7L,18L,55L,163L,484L,1439L,4275L,12704L,37749L,112171L,333314L,990437L,2943067L,8745274L,25986435L,77218255L,229452748L,681814987L,2026001783L,6020230272L,17889013145L,53156902119L,157954841890L,469360159865L,1394695832255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197092Inst : IEnumerable<long>
{
public static readonly long[] Value=A197092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197092.Bytes);
public long this[int i]=>Value[i];

public static A197092Inst Instance=new A197092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197093
{
public static readonly long[] Value={ 2L,18L,74L,384L,1880L,9274L,45843L,226260L,1117379L,5517062L,27241839L,134512788L,664185673L,3279563167L,16193558462L,79959241428L,394816250117L,1949491619113L,9626041441314L,47530685870146L,234693161662954L,1158848838643225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197093Inst : IEnumerable<long>
{
public static readonly long[] Value=A197093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197093.Bytes);
public long this[int i]=>Value[i];

public static A197093Inst Instance=new A197093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197094
{
public static readonly long[] Value={ 3L,55L,384L,3477L,30071L,259856L,2253537L,19514155L,169056920L,1464412705L,12685404677L,109886670038L,951885707773L,8245652221757L,71427443730770L,618735770258261L,5359759927360759L,46428585278694262L,402184717612536457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197094Inst : IEnumerable<long>
{
public static readonly long[] Value=A197094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197094.Bytes);
public long this[int i]=>Value[i];

public static A197094Inst Instance=new A197094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197095
{
public static readonly long[] Value={ 5L,163L,1880L,30071L,457357L,6929744L,105551542L,1604683081L,24408630177L,371223947273L,5645973938300L,85870216988266L,1306005491430390L,19863143482191568L,302100042452359958L,4594662801689083927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197095Inst : IEnumerable<long>
{
public static readonly long[] Value=A197095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197095.Bytes);
public long this[int i]=>Value[i];

public static A197095Inst Instance=new A197095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197096
{
public static readonly BigInteger[] Value={ 8L,484L,9274L,259856L,6929744L,183439730L,4886330995L,129901784708L,3454992362269L,91881627486594L,2443544908738875L,64984869174255048L,1728236147537632767L,BigInteger.Parse("45961525529160717907"),BigInteger.Parse("1222321979162332900054") };
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
public class A197096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197096Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197096.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197096.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197096Inst Instance=new A197096Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197097
{
public static readonly BigInteger[] Value={ 13L,1439L,45843L,2253537L,105551542L,4886330995L,227951140324L,10611747125529L,494205872758082L,23013994189839780L,1071725356148151651L,BigInteger.Parse("49908553928282027953"),BigInteger.Parse("2324157974481616112739"),BigInteger.Parse("108232267483106900191660") };
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
public class A197097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197097Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197097.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197097.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197097Inst Instance=new A197097Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197098
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,2L,3L,18L,18L,3L,5L,55L,74L,55L,5L,8L,163L,384L,384L,163L,8L,13L,484L,1880L,3477L,1880L,484L,13L,21L,1439L,9274L,30071L,30071L,9274L,1439L,21L,34L,4275L,45843L,259856L,457357L,259856L,45843L,4275L,34L,55L,12704L,226260L,2253537L,6929744L,6929744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197098Inst : IEnumerable<long>
{
public static readonly long[] Value=A197098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197098.Bytes);
public long this[int i]=>Value[i];

public static A197098Inst Instance=new A197098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197099
{
public static readonly long[] Value={ 1L,2L,4L,32L,48L,180L,189L,224L,288L,360L,432L,1280L,1344L,1536L,1600L,4096L,28672L,46656L,54000L,108000L,131220L,150528L,225792L,262440L,405450L,442800L,525312L,532480L,590400L,594000L,630784L,633600L,655360L,792000L,819200L,885600L,950400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197099Inst : IEnumerable<long>
{
public static readonly long[] Value=A197099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197099.Bytes);
public long this[int i]=>Value[i];

public static A197099Inst Instance=new A197099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197100
{
public static readonly long[] Value={ -3L,-3L,-5L,5L,1L,1L,13L,-71L,47L,97L,-65L,23L,73L,-149L,719L,-345L,2453L,299L,1737L,7851L,5359L,22021L,30039L,45211L,143627L,210871L,404681L,627271L,1446107L,2401465L,5033375L,8279849L,16695395L,30641101L,59192219L,107592545L,209720011L,386315899L,747523379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197100Inst : IEnumerable<long>
{
public static readonly long[] Value=A197100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197100.Bytes);
public long this[int i]=>Value[i];

public static A197100Inst Instance=new A197100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197101
{
public static readonly BigInteger[] Value={ 2L,78L,50831L,478107878L,63216096026066L,BigInteger.Parse("117783697209668555853") };
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
public class A197101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197101Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197101.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197101.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197101Inst Instance=new A197101Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197102
{
public static readonly long[] Value={ 2L,6L,16L,61L,212L,753L,2661L,9415L,33302L,117802L,416703L,1474018L,5214089L,18443961L,65242401L,230783990L,816359440L,2887733833L,10214871388L,36133384697L,127815754113L,452126672783L,1599321849338L,5657331300590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197102Inst : IEnumerable<long>
{
public static readonly long[] Value=A197102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197102.Bytes);
public long this[int i]=>Value[i];

public static A197102Inst Instance=new A197102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197103
{
public static readonly long[] Value={ 6L,78L,1015L,13526L,181032L,2421376L,32393085L,433365018L,5797636941L,77561969587L,1037640271854L,13881766929498L,185713161140663L,2484509257009467L,33238281011983990L,444668628838107492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197103Inst : IEnumerable<long>
{
public static readonly long[] Value=A197103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197103.Bytes);
public long this[int i]=>Value[i];

public static A197103Inst Instance=new A197103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197104
{
public static readonly BigInteger[] Value={ 16L,1015L,50831L,2548972L,127561432L,6385146382L,319626874708L,15999836095846L,800916441358294L,40092114594159126L,2006923132890272745L,BigInteger.Parse("100462160201819897870"),BigInteger.Parse("5028914884473383292290"),BigInteger.Parse("251736423646820731452182") };
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
public class A197104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197104Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197104.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197104.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197104Inst Instance=new A197104Inst();

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