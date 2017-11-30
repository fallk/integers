using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A200005
{
public static readonly long[] Value={ 1L,3L,6L,0L,8L,3L,2L,2L,5L,5L,3L,9L,0L,6L,6L,8L,9L,0L,4L,6L,7L,1L,8L,3L,9L,2L,8L,5L,6L,9L,1L,3L,2L,6L,3L,6L,8L,8L,2L,5L,4L,9L,7L,9L,2L,6L,2L,5L,5L,0L,8L,5L,8L,3L,1L,1L,0L,7L,4L,1L,3L,2L,6L,7L,8L,2L,0L,6L,1L,0L,6L,2L,3L,0L,1L,3L,9L,9L,4L,2L,4L,7L,4L,6L,2L,9L,0L,5L,6L,4L,0L,9L,9L,1L,4L,8L,2L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200005Inst : IEnumerable<long>
{
public static readonly long[] Value=A200005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200005.Bytes);
public long this[int i]=>Value[i];

public static A200005Inst Instance=new A200005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200006
{
public static readonly long[] Value={ 3L,1L,9L,1L,6L,5L,5L,8L,4L,4L,9L,3L,9L,5L,6L,1L,1L,4L,5L,0L,9L,4L,4L,8L,2L,8L,0L,4L,6L,1L,2L,3L,8L,7L,8L,6L,4L,5L,0L,7L,4L,1L,1L,2L,3L,8L,1L,1L,0L,4L,6L,5L,8L,9L,6L,6L,4L,5L,3L,7L,3L,6L,2L,4L,0L,6L,0L,0L,9L,7L,9L,2L,3L,1L,2L,2L,5L,3L,6L,7L,3L,1L,2L,1L,1L,7L,2L,2L,3L,0L,9L,5L,8L,1L,8L,9L,0L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200006Inst : IEnumerable<long>
{
public static readonly long[] Value=A200006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200006.Bytes);
public long this[int i]=>Value[i];

public static A200006Inst Instance=new A200006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200007
{
public static readonly long[] Value={ 9L,3L,5L,7L,8L,1L,9L,5L,4L,5L,6L,0L,2L,0L,1L,6L,9L,0L,6L,4L,7L,6L,9L,0L,3L,5L,6L,7L,4L,8L,3L,5L,0L,6L,5L,5L,1L,8L,6L,4L,5L,4L,2L,4L,0L,5L,5L,1L,0L,1L,8L,8L,3L,7L,9L,3L,0L,4L,1L,7L,2L,9L,1L,9L,1L,7L,6L,6L,5L,6L,9L,6L,0L,6L,1L,3L,3L,0L,9L,3L,0L,3L,4L,5L,2L,2L,9L,7L,6L,1L,1L,2L,8L,2L,8L,0L,6L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200007Inst : IEnumerable<long>
{
public static readonly long[] Value=A200007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200007.Bytes);
public long this[int i]=>Value[i];

public static A200007Inst Instance=new A200007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200008
{
public static readonly long[] Value={ 4L,0L,3L,9L,5L,4L,8L,5L,6L,2L,7L,7L,0L,9L,9L,0L,5L,7L,8L,7L,9L,3L,5L,3L,4L,4L,6L,4L,2L,2L,1L,1L,0L,4L,1L,1L,1L,7L,5L,9L,3L,5L,1L,4L,1L,8L,7L,3L,6L,5L,1L,0L,3L,8L,3L,8L,8L,8L,5L,6L,4L,5L,4L,9L,5L,7L,2L,7L,5L,8L,6L,8L,5L,8L,4L,8L,9L,0L,1L,6L,0L,8L,0L,0L,5L,2L,9L,6L,5L,2L,1L,1L,0L,7L,6L,1L,7L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200008Inst : IEnumerable<long>
{
public static readonly long[] Value=A200008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200008.Bytes);
public long this[int i]=>Value[i];

public static A200008Inst Instance=new A200008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200009
{
public static readonly long[] Value={ 5L,9L,2L,4L,7L,0L,2L,9L,0L,7L,9L,2L,5L,0L,3L,9L,3L,2L,9L,3L,1L,2L,8L,2L,2L,7L,6L,2L,8L,8L,0L,6L,3L,2L,4L,8L,3L,9L,9L,2L,9L,0L,6L,5L,3L,9L,7L,4L,8L,6L,4L,5L,5L,8L,1L,0L,3L,1L,3L,1L,1L,7L,5L,0L,1L,1L,5L,9L,3L,8L,8L,5L,9L,1L,7L,1L,8L,4L,8L,5L,2L,6L,8L,7L,3L,3L,8L,7L,8L,5L,7L,1L,8L,6L,2L,9L,6L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200009Inst : IEnumerable<long>
{
public static readonly long[] Value=A200009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200009.Bytes);
public long this[int i]=>Value[i];

public static A200009Inst Instance=new A200009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200010
{
public static readonly long[] Value={ 5L,6L,0L,9L,8L,7L,7L,2L,9L,2L,3L,5L,9L,1L,1L,3L,7L,5L,2L,7L,7L,4L,3L,7L,0L,2L,8L,5L,3L,3L,6L,6L,8L,2L,3L,1L,7L,9L,9L,0L,9L,2L,1L,5L,5L,1L,9L,4L,7L,5L,5L,4L,2L,4L,5L,2L,8L,3L,2L,9L,7L,2L,2L,5L,4L,0L,7L,4L,4L,5L,9L,4L,6L,4L,3L,0L,6L,8L,8L,2L,4L,4L,1L,5L,5L,2L,8L,5L,5L,6L,6L,3L,2L,9L,2L,4L,0L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200010Inst : IEnumerable<long>
{
public static readonly long[] Value=A200010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200010.Bytes);
public long this[int i]=>Value[i];

public static A200010Inst Instance=new A200010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200011
{
public static readonly long[] Value={ 1L,1L,4L,9L,5L,5L,4L,6L,2L,7L,2L,7L,7L,4L,7L,3L,1L,8L,9L,0L,6L,9L,5L,2L,2L,4L,9L,4L,7L,4L,4L,4L,0L,9L,0L,2L,0L,1L,1L,3L,9L,6L,8L,1L,7L,7L,9L,1L,3L,9L,2L,4L,4L,8L,1L,3L,1L,9L,2L,5L,2L,4L,8L,6L,3L,4L,8L,5L,5L,1L,5L,3L,5L,9L,0L,5L,7L,3L,7L,8L,3L,9L,3L,2L,6L,2L,5L,3L,2L,9L,9L,1L,6L,6L,5L,1L,2L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200011Inst : IEnumerable<long>
{
public static readonly long[] Value=A200011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200011.Bytes);
public long this[int i]=>Value[i];

public static A200011Inst Instance=new A200011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200012
{
public static readonly long[] Value={ 3L,9L,4L,1L,2L,4L,1L,9L,2L,8L,5L,8L,9L,7L,5L,9L,6L,0L,0L,9L,9L,7L,0L,5L,3L,9L,9L,3L,5L,4L,5L,9L,0L,0L,9L,8L,5L,3L,6L,9L,2L,2L,4L,9L,6L,1L,9L,3L,9L,1L,2L,2L,9L,7L,9L,2L,1L,9L,8L,4L,8L,1L,1L,6L,8L,5L,3L,1L,1L,8L,7L,4L,1L,7L,6L,0L,2L,4L,8L,1L,7L,9L,3L,5L,8L,3L,4L,5L,6L,0L,3L,0L,7L,1L,7L,9L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200012Inst : IEnumerable<long>
{
public static readonly long[] Value=A200012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200012.Bytes);
public long this[int i]=>Value[i];

public static A200012Inst Instance=new A200012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200013
{
public static readonly long[] Value={ 1L,4L,5L,0L,9L,3L,8L,4L,4L,9L,6L,3L,4L,9L,7L,4L,4L,3L,1L,1L,2L,8L,2L,8L,5L,5L,7L,6L,6L,9L,0L,3L,5L,7L,7L,3L,8L,9L,4L,4L,7L,4L,8L,7L,0L,1L,1L,5L,3L,4L,6L,3L,9L,8L,7L,6L,5L,4L,2L,3L,5L,8L,6L,2L,6L,2L,9L,6L,1L,9L,2L,8L,4L,3L,0L,8L,1L,3L,5L,0L,5L,9L,1L,7L,2L,0L,8L,4L,3L,0L,4L,9L,7L,0L,9L,4L,6L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200013Inst : IEnumerable<long>
{
public static readonly long[] Value=A200013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200013.Bytes);
public long this[int i]=>Value[i];

public static A200013Inst Instance=new A200013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200014
{
public static readonly long[] Value={ 2L,9L,4L,3L,4L,8L,7L,7L,2L,3L,3L,5L,6L,8L,6L,3L,9L,8L,3L,6L,9L,6L,5L,7L,8L,9L,0L,2L,0L,3L,6L,1L,9L,5L,0L,3L,0L,8L,6L,7L,2L,1L,9L,9L,0L,0L,5L,9L,4L,0L,0L,3L,2L,8L,8L,8L,6L,8L,4L,1L,8L,0L,1L,6L,5L,1L,9L,9L,9L,8L,1L,5L,0L,7L,0L,7L,8L,4L,3L,8L,3L,5L,7L,8L,4L,4L,7L,6L,2L,2L,5L,3L,2L,2L,6L,0L,3L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200014Inst : IEnumerable<long>
{
public static readonly long[] Value=A200014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200014.Bytes);
public long this[int i]=>Value[i];

public static A200014Inst Instance=new A200014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200015
{
public static readonly long[] Value={ 1L,6L,9L,0L,7L,7L,9L,7L,3L,8L,9L,6L,9L,8L,1L,5L,3L,3L,4L,9L,5L,7L,5L,0L,4L,8L,5L,7L,5L,5L,8L,8L,0L,9L,5L,4L,3L,4L,2L,1L,3L,2L,4L,1L,6L,3L,9L,0L,6L,5L,4L,5L,2L,8L,5L,4L,4L,5L,1L,8L,3L,8L,5L,4L,9L,7L,2L,6L,1L,2L,8L,7L,2L,5L,7L,1L,9L,9L,7L,4L,5L,7L,7L,4L,3L,1L,6L,4L,5L,7L,1L,3L,7L,0L,0L,8L,8L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200015Inst : IEnumerable<long>
{
public static readonly long[] Value=A200015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200015.Bytes);
public long this[int i]=>Value[i];

public static A200015Inst Instance=new A200015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200016
{
public static readonly long[] Value={ 2L,3L,1L,9L,3L,1L,7L,3L,6L,5L,0L,8L,0L,7L,7L,0L,6L,8L,2L,7L,9L,2L,1L,6L,2L,9L,5L,0L,7L,8L,0L,8L,0L,1L,1L,5L,5L,2L,8L,9L,5L,6L,6L,7L,4L,9L,1L,7L,6L,0L,4L,6L,3L,1L,5L,8L,1L,2L,1L,7L,4L,2L,7L,6L,4L,9L,1L,9L,4L,3L,4L,9L,1L,6L,1L,6L,1L,4L,6L,5L,4L,1L,6L,9L,0L,8L,8L,3L,0L,5L,2L,0L,0L,8L,3L,6L,2L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200016Inst : IEnumerable<long>
{
public static readonly long[] Value=A200016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200016.Bytes);
public long this[int i]=>Value[i];

public static A200016Inst Instance=new A200016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200017
{
public static readonly long[] Value={ 1L,8L,7L,5L,2L,0L,0L,6L,8L,8L,7L,5L,6L,6L,9L,0L,1L,3L,7L,0L,0L,0L,9L,9L,5L,4L,4L,2L,7L,0L,2L,2L,4L,9L,1L,3L,9L,1L,5L,1L,8L,7L,1L,7L,6L,0L,4L,2L,4L,5L,7L,9L,4L,7L,0L,6L,9L,5L,5L,6L,0L,1L,4L,9L,5L,6L,5L,1L,5L,3L,3L,6L,8L,6L,6L,1L,5L,7L,7L,6L,9L,0L,2L,9L,6L,4L,3L,2L,2L,4L,4L,2L,9L,3L,0L,2L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200017Inst : IEnumerable<long>
{
public static readonly long[] Value=A200017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200017.Bytes);
public long this[int i]=>Value[i];

public static A200017Inst Instance=new A200017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200018
{
public static readonly long[] Value={ 8L,0L,9L,6L,2L,9L,9L,9L,9L,1L,2L,9L,5L,5L,2L,4L,1L,3L,1L,8L,6L,1L,0L,9L,6L,9L,8L,4L,8L,4L,0L,2L,7L,1L,3L,2L,1L,9L,6L,6L,9L,1L,7L,6L,0L,3L,5L,6L,5L,4L,5L,3L,7L,8L,5L,3L,8L,9L,4L,7L,8L,4L,6L,3L,2L,9L,8L,3L,6L,9L,0L,8L,2L,3L,2L,1L,6L,6L,6L,8L,3L,9L,6L,9L,0L,1L,7L,5L,9L,9L,6L,0L,8L,6L,5L,1L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200018Inst : IEnumerable<long>
{
public static readonly long[] Value=A200018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200018.Bytes);
public long this[int i]=>Value[i];

public static A200018Inst Instance=new A200018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200019
{
public static readonly long[] Value={ 1L,2L,5L,4L,1L,8L,7L,9L,6L,2L,4L,7L,7L,9L,1L,9L,5L,5L,3L,3L,6L,3L,9L,1L,2L,3L,2L,6L,3L,2L,1L,8L,0L,1L,3L,7L,4L,2L,6L,0L,6L,2L,4L,1L,3L,8L,6L,9L,8L,6L,9L,2L,8L,5L,1L,5L,7L,7L,7L,5L,1L,6L,0L,3L,0L,8L,2L,5L,6L,2L,2L,5L,8L,3L,8L,4L,0L,8L,2L,4L,8L,4L,9L,2L,4L,2L,6L,4L,5L,9L,4L,9L,4L,6L,1L,3L,9L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200019Inst : IEnumerable<long>
{
public static readonly long[] Value=A200019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200019.Bytes);
public long this[int i]=>Value[i];

public static A200019Inst Instance=new A200019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200020
{
public static readonly long[] Value={ 6L,4L,0L,0L,4L,9L,1L,9L,1L,1L,4L,2L,5L,7L,7L,1L,1L,5L,7L,3L,9L,8L,3L,5L,2L,6L,9L,6L,7L,5L,8L,4L,1L,2L,0L,1L,2L,9L,6L,6L,3L,4L,6L,8L,4L,7L,7L,3L,3L,5L,0L,9L,7L,1L,1L,0L,6L,6L,7L,1L,3L,8L,2L,1L,5L,6L,7L,3L,9L,6L,0L,7L,9L,0L,4L,4L,6L,2L,3L,0L,8L,5L,8L,3L,7L,5L,0L,9L,3L,3L,0L,9L,7L,6L,3L,5L,8L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200020Inst : IEnumerable<long>
{
public static readonly long[] Value=A200020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200020.Bytes);
public long this[int i]=>Value[i];

public static A200020Inst Instance=new A200020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200021
{
public static readonly long[] Value={ 1L,4L,7L,6L,3L,6L,8L,7L,4L,8L,3L,8L,0L,9L,2L,0L,3L,9L,1L,6L,7L,1L,6L,9L,6L,8L,8L,9L,7L,8L,9L,8L,3L,6L,4L,1L,6L,4L,3L,6L,9L,3L,2L,3L,2L,3L,1L,9L,7L,3L,2L,4L,9L,9L,3L,0L,3L,6L,9L,4L,0L,4L,4L,5L,3L,9L,6L,6L,8L,4L,3L,0L,8L,6L,1L,5L,8L,0L,7L,6L,0L,1L,2L,4L,0L,6L,0L,1L,7L,3L,0L,4L,8L,3L,3L,6L,9L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200021Inst : IEnumerable<long>
{
public static readonly long[] Value=A200021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200021.Bytes);
public long this[int i]=>Value[i];

public static A200021Inst Instance=new A200021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200022
{
public static readonly long[] Value={ 5L,1L,4L,5L,1L,4L,8L,3L,0L,4L,7L,6L,4L,5L,8L,6L,8L,6L,5L,6L,5L,6L,3L,8L,9L,4L,5L,6L,7L,5L,3L,7L,1L,8L,1L,5L,9L,5L,2L,1L,1L,1L,9L,8L,3L,6L,7L,0L,3L,4L,0L,2L,2L,7L,8L,2L,0L,3L,9L,7L,8L,3L,7L,7L,5L,8L,1L,9L,3L,2L,4L,4L,5L,9L,9L,6L,6L,4L,1L,8L,7L,7L,8L,9L,1L,5L,6L,2L,9L,3L,8L,0L,2L,0L,5L,0L,3L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200022Inst : IEnumerable<long>
{
public static readonly long[] Value=A200022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200022.Bytes);
public long this[int i]=>Value[i];

public static A200022Inst Instance=new A200022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200023
{
public static readonly long[] Value={ 1L,6L,6L,9L,6L,9L,2L,1L,6L,9L,6L,4L,9L,7L,6L,3L,4L,5L,8L,2L,5L,2L,8L,3L,8L,3L,0L,5L,9L,8L,4L,9L,1L,7L,3L,3L,5L,9L,3L,7L,7L,5L,8L,9L,9L,6L,5L,9L,1L,6L,9L,9L,1L,6L,8L,2L,8L,2L,4L,0L,8L,4L,9L,6L,1L,1L,2L,9L,1L,0L,5L,6L,2L,3L,4L,4L,1L,3L,3L,4L,1L,9L,3L,2L,5L,7L,8L,3L,8L,7L,2L,9L,5L,5L,6L,9L,3L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200023Inst : IEnumerable<long>
{
public static readonly long[] Value=A200023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200023.Bytes);
public long this[int i]=>Value[i];

public static A200023Inst Instance=new A200023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200024
{
public static readonly long[] Value={ 4L,2L,3L,5L,2L,7L,2L,9L,4L,7L,1L,8L,6L,9L,1L,1L,6L,1L,8L,5L,7L,4L,1L,1L,5L,5L,5L,0L,9L,6L,9L,2L,8L,8L,3L,4L,0L,2L,6L,1L,3L,5L,4L,6L,3L,4L,7L,0L,2L,5L,0L,3L,2L,6L,3L,0L,0L,0L,1L,8L,3L,3L,2L,6L,9L,9L,7L,3L,3L,7L,4L,3L,5L,0L,7L,9L,3L,7L,1L,8L,8L,5L,4L,1L,2L,8L,7L,8L,7L,0L,5L,2L,5L,4L,1L,4L,7L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200024Inst : IEnumerable<long>
{
public static readonly long[] Value=A200024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200024.Bytes);
public long this[int i]=>Value[i];

public static A200024Inst Instance=new A200024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200025
{
public static readonly long[] Value={ 1L,8L,3L,0L,7L,3L,3L,4L,5L,3L,2L,9L,0L,8L,6L,3L,5L,9L,9L,2L,1L,0L,2L,3L,5L,9L,5L,4L,7L,3L,4L,1L,4L,7L,8L,8L,4L,5L,3L,6L,6L,7L,8L,1L,2L,8L,3L,2L,4L,2L,1L,4L,9L,5L,2L,2L,9L,5L,8L,1L,6L,4L,2L,6L,7L,1L,0L,0L,0L,8L,5L,1L,1L,9L,4L,6L,2L,3L,6L,2L,0L,3L,8L,0L,5L,5L,4L,6L,3L,7L,8L,8L,4L,3L,4L,1L,1L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200025Inst : IEnumerable<long>
{
public static readonly long[] Value=A200025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200025.Bytes);
public long this[int i]=>Value[i];

public static A200025Inst Instance=new A200025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200026
{
public static readonly long[] Value={ 9L,5L,5L,9L,0L,8L,7L,9L,8L,4L,8L,1L,6L,1L,3L,4L,1L,3L,5L,3L,7L,3L,0L,1L,4L,3L,9L,5L,8L,4L,4L,0L,6L,1L,0L,3L,5L,9L,4L,8L,9L,8L,6L,6L,8L,6L,7L,5L,3L,9L,4L,3L,2L,8L,6L,5L,9L,3L,6L,8L,9L,4L,2L,2L,4L,3L,3L,7L,9L,9L,4L,8L,6L,9L,8L,5L,4L,7L,3L,9L,0L,1L,1L,1L,9L,1L,2L,8L,8L,5L,8L,4L,3L,9L,8L,0L,0L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200026Inst : IEnumerable<long>
{
public static readonly long[] Value=A200026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200026.Bytes);
public long this[int i]=>Value[i];

public static A200026Inst Instance=new A200026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200027
{
public static readonly long[] Value={ 1L,3L,1L,4L,4L,8L,5L,6L,0L,9L,1L,9L,7L,7L,6L,1L,9L,6L,5L,5L,1L,9L,2L,1L,9L,8L,6L,7L,6L,1L,0L,9L,1L,0L,6L,0L,0L,1L,2L,8L,8L,8L,9L,4L,4L,1L,4L,1L,6L,8L,4L,7L,5L,3L,8L,0L,0L,2L,1L,2L,0L,7L,0L,0L,4L,7L,7L,1L,9L,8L,2L,3L,4L,9L,0L,0L,2L,9L,7L,4L,5L,7L,6L,7L,9L,0L,4L,2L,7L,1L,0L,0L,5L,0L,1L,4L,0L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200027Inst : IEnumerable<long>
{
public static readonly long[] Value=A200027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200027.Bytes);
public long this[int i]=>Value[i];

public static A200027Inst Instance=new A200027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200028
{
public static readonly long[] Value={ 1L,1L,5L,23L,123L,714L,4371L,27789L,181703L,1214166L,8254642L,56915989L,397055129L,2797402939L,19875881883L,142255845279L,1024672816559L,7422364394376L,54034027247172L,395121014784661L,2900916414217452L,21375452831552800L,158025136138734047L,1171770189246765570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200028Inst : IEnumerable<long>
{
public static readonly long[] Value=A200028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200028.Bytes);
public long this[int i]=>Value[i];

public static A200028Inst Instance=new A200028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200029
{
public static readonly long[] Value={ 1L,1L,4L,18L,89L,483L,2765L,16441L,100553L,628496L,3996864L,25778259L,168216339L,1108586737L,7367790912L,49326025289L,332342006775L,2251828394103L,15333892329935L,104883312564708L,720280904233625L,4964456716210287L,34329831032740121L,238109354053880367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200029Inst : IEnumerable<long>
{
public static readonly long[] Value=A200029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200029.Bytes);
public long this[int i]=>Value[i];

public static A200029Inst Instance=new A200029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200030
{
public static readonly long[] Value={ 1L,1L,1L,3L,11L,42L,167L,685L,2879L,12338L,53718L,236961L,1056825L,4757575L,21590295L,98665559L,453663399L,2097270984L,9742489832L,45452945649L,212884993100L,1000597657272L,4718101921367L,22312506322722L,105802828419669L,502945922930746L,2396283673887013L,11441289644315619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200030Inst : IEnumerable<long>
{
public static readonly long[] Value=A200030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200030.Bytes);
public long this[int i]=>Value[i];

public static A200030Inst Instance=new A200030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200031
{
public static readonly BigInteger[] Value={ 1L,5L,25L,150L,1000L,7125L,53125L,409375L,3234375L,26059375L,213296875L,1768625000L,14825156250L,125419296875L,1069473046875L,9182583593750L,79319843750000L,688837802734375L,6010580419921875L,52670308222656250L,463321803125000000L,4089876834521484375L,BigInteger.Parse("36217014743896484375") };
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
public class A200031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200031Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200031.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A200031.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200031Inst Instance=new A200031Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200032
{
public static readonly long[] Value={ 0L,4L,2L,28L,26L,168L,214L,1140L,1882L,7930L,15222L,56732L,122760L,416928L,975508L,3116724L,7715598L,23651892L,60875844L,181428684L,479853296L,1403488666L,3783362306L,10927395294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200032Inst : IEnumerable<long>
{
public static readonly long[] Value=A200032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200032.Bytes);
public long this[int i]=>Value[i];

public static A200032Inst Instance=new A200032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200033
{
public static readonly long[] Value={ 0L,6L,14L,84L,264L,1450L,5268L,25070L,102854L,460146L,1954930L,8681238L,37537698L,165783402L,725328338L,3201189116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200033Inst : IEnumerable<long>
{
public static readonly long[] Value=A200033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200033.Bytes);
public long this[int i]=>Value[i];

public static A200033Inst Instance=new A200033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200034
{
public static readonly long[] Value={ 0L,8L,28L,218L,1074L,7384L,41228L,262004L,1565836L,9730070L,59336930L,368674288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200034Inst : IEnumerable<long>
{
public static readonly long[] Value=A200034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200034.Bytes);
public long this[int i]=>Value[i];

public static A200034Inst Instance=new A200034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200035
{
public static readonly long[] Value={ 0L,10L,52L,444L,3054L,25814L,192280L,1557104L,12157838L,97030120L,768491618L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200035Inst : IEnumerable<long>
{
public static readonly long[] Value=A200035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200035.Bytes);
public long this[int i]=>Value[i];

public static A200035Inst Instance=new A200035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200036
{
public static readonly long[] Value={ 0L,12L,78L,808L,7104L,72220L,674234L,6674940L,64642466L,635825548L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200036Inst : IEnumerable<long>
{
public static readonly long[] Value=A200036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200036.Bytes);
public long this[int i]=>Value[i];

public static A200036Inst Instance=new A200036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200037
{
public static readonly long[] Value={ 0L,14L,114L,1330L,14156L,169170L,1882238L,22017152L,254776338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200037Inst : IEnumerable<long>
{
public static readonly long[] Value=A200037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200037.Bytes);
public long this[int i]=>Value[i];

public static A200037Inst Instance=new A200037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200038
{
public static readonly long[] Value={ 0L,0L,2L,0L,4L,0L,0L,6L,2L,2L,0L,8L,14L,28L,0L,0L,10L,28L,84L,26L,2L,0L,12L,52L,218L,264L,168L,0L,0L,14L,78L,444L,1074L,1450L,214L,2L,0L,16L,114L,808L,3054L,7384L,5268L,1140L,0L,0L,18L,152L,1330L,7104L,25814L,41228L,25070L,1882L,2L,0L,20L,200L,2068L,14156L,72220L,192280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200038Inst : IEnumerable<long>
{
public static readonly long[] Value=A200038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200038.Bytes);
public long this[int i]=>Value[i];

public static A200038Inst Instance=new A200038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200039
{
public static readonly long[] Value={ 0L,2L,14L,28L,52L,78L,114L,152L,200L,250L,310L,372L,444L,518L,602L,688L,784L,882L,990L,1100L,1220L,1342L,1474L,1608L,1752L,1898L,2054L,2212L,2380L,2550L,2730L,2912L,3104L,3298L,3502L,3708L,3924L,4142L,4370L,4600L,4840L,5082L,5334L,5588L,5852L,6118L,6394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200039Inst : IEnumerable<long>
{
public static readonly long[] Value=A200039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200039.Bytes);
public long this[int i]=>Value[i];

public static A200039Inst Instance=new A200039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200040
{
public static readonly long[] Value={ 2L,28L,84L,218L,444L,808L,1330L,2068L,2996L,4230L,5740L,7552L,9746L,12348L,15304L,18782L,22732L,27144L,32162L,37784L,43912L,50790L,58332L,66496L,75494L,85280L,95736L,107166L,119452L,132524L,146646L,161752L,177688L,194822L,213008L,232132L,252534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200040Inst : IEnumerable<long>
{
public static readonly long[] Value=A200040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200040.Bytes);
public long this[int i]=>Value[i];

public static A200040Inst Instance=new A200040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200041
{
public static readonly long[] Value={ 0L,26L,264L,1074L,3054L,7104L,14156L,25546L,42928L,67782L,102250L,148624L,209216L,286370L,383924L,503834L,650334L,826512L,1036716L,1283846L,1574252L,1909734L,2297538L,2740864L,3246472L,3817174L,4462780L,5184398L,5992386L,6889492L,7886048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200041Inst : IEnumerable<long>
{
public static readonly long[] Value=A200041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200041.Bytes);
public long this[int i]=>Value[i];

public static A200041Inst Instance=new A200041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200042
{
public static readonly long[] Value={ 2L,168L,1450L,7384L,25814L,72220L,169170L,351964L,667998L,1174860L,1958474L,3119900L,4772250L,7066336L,10146330L,14251004L,19583286L,26418704L,35030826L,45705392L,58910542L,75014652L,94447002L,117742012L,145274026L,177897944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200042Inst : IEnumerable<long>
{
public static readonly long[] Value=A200042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200042.Bytes);
public long this[int i]=>Value[i];

public static A200042Inst Instance=new A200042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200043
{
public static readonly long[] Value={ 0L,214L,5268L,41228L,192280L,674234L,1882238L,4559584L,9869410L,19627458L,36265862L,63537830L,105895974L,169797756L,263132194L,395819648L,579860740L,831059432L,1166406254L,1608524888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200043Inst : IEnumerable<long>
{
public static readonly long[] Value=A200043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200043.Bytes);
public long this[int i]=>Value[i];

public static A200043Inst Instance=new A200043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200044
{
public static readonly long[] Value={ 1L,2L,6L,2L,10L,4L,28L,20L,11L,1L,11L,132L,119L,105L,90L,74L,57L,39L,20L,400L,379L,357L,334L,310L,285L,259L,232L,204L,175L,145L,114L,82L,49L,15L,525L,489L,452L,414L,375L,335L,294L,252L,209L,165L,120L,74L,27L,1296L,1247L,1197L,1146L,1094L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200044Inst : IEnumerable<long>
{
public static readonly long[] Value=A200044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200044.Bytes);
public long this[int i]=>Value[i];

public static A200044Inst Instance=new A200044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200045
{
public static readonly long[] Value={ 4L,16L,252L,64L,3912L,228984L,256L,59928L,12870096L,2545607472L,1024L,906912L,696448224L,465659203104L,272454472598400L,4096L,13571712L,36376835616L,79102304162784L,140221913588582784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200045Inst : IEnumerable<long>
{
public static readonly long[] Value=A200045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200045.Bytes);
public long this[int i]=>Value[i];

public static A200045Inst Instance=new A200045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200046
{
public static readonly long[] Value={ 15L,25L,33L,35L,39L,55L,57L,69L,75L,95L,99L,115L,117L,119L,121L,123L,125L,129L,135L,143L,145L,153L,155L,169L,175L,195L,203L,205L,209L,215L,217L,221L,225L,235L,247L,253L,255L,259L,273L,275L,285L,289L,295L,299L,305L,309L,315L,319L,321L,323L,325L,333L,335L,339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200046Inst : IEnumerable<long>
{
public static readonly long[] Value=A200046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200046.Bytes);
public long this[int i]=>Value[i];

public static A200046Inst Instance=new A200046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200047
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,3L,5L,9L,15L,25L,42L,70L,116L,192L,317L,522L,858L,1408L,2307L,3775L,6170L,10074L,16433L,26784L,43623L,71002L,115497L,187777L,305147L,495669L,804839L,1306404L,2119884L,3438952L,5577396L,9043549L,14660810L,23762784L,38509220L,62397495L,101090631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200047Inst : IEnumerable<long>
{
public static readonly long[] Value=A200047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200047.Bytes);
public long this[int i]=>Value[i];

public static A200047Inst Instance=new A200047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200048
{
public static readonly long[] Value={ 4L,59L,220L,581L,1162L,2105L,3370L,5171L,7384L,10319L,13744L,18089L,22990L,29021L,35662L,43655L,52300L,62531L,73444L,86189L,99634L,115169L,131410L,150011L,169312L,191255L,213880L,239441L,265654L,295109L,325174L,358799L,392980L,431051L,469612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200048Inst : IEnumerable<long>
{
public static readonly long[] Value=A200048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200048.Bytes);
public long this[int i]=>Value[i];

public static A200048Inst Instance=new A200048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200049
{
public static readonly long[] Value={ 2L,3L,5L,7L,9L,12L,14L,16L,20L,21L,27L,29L,30L,34L,37L,44L,45L,48L,52L,53L,58L,61L,65L,71L,75L,76L,78L,79L,84L,93L,97L,100L,101L,109L,111L,115L,119L,122L,128L,132L,133L,142L,144L,146L,147L,157L,165L,169L,170L,172L,178L,180L,188L,193L,198L,202L,203L,207L,211L,213L,221L,231L,233L,234L,238L,251L,254L,261L,263L,267L,271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200049Inst : IEnumerable<long>
{
public static readonly long[] Value=A200049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200049.Bytes);
public long this[int i]=>Value[i];

public static A200049Inst Instance=new A200049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200050
{
public static readonly long[] Value={ 1L,2L,9L,35L,54L,104L,135L,209L,350L,405L,594L,740L,819L,989L,1274L,1595L,1710L,2079L,2345L,2484L,2925L,3239L,3740L,4464L,4850L,5049L,5459L,5670L,6104L,7749L,8255L,9044L,9315L,10730L,11025L,11934L,12879L,13529L,14534L,15575L,15930L,17765L,18144L,18914L,19305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200050Inst : IEnumerable<long>
{
public static readonly long[] Value=A200050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200050.Bytes);
public long this[int i]=>Value[i];

public static A200050Inst Instance=new A200050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200051
{
public static readonly long[] Value={ 1L,4L,10L,26L,68L,178L,472L,1276L,3462L,9496L,26024L,71956L,198740L,552814L,1535556L,4290252L,11968194L,33553214L,93917400L,264020106L,741024426L,2087799972L,5872999754L,16577458520L,46720454112L,132081262316L,372843051320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200051Inst : IEnumerable<long>
{
public static readonly long[] Value=A200051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200051.Bytes);
public long this[int i]=>Value[i];

public static A200051Inst Instance=new A200051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200052
{
public static readonly long[] Value={ 1L,6L,22L,78L,288L,1098L,4224L,16432L,64310L,253692L,1003374L,3992358L,15908668L,63684848L,255153798L,1026057576L,4127971346L,16658240722L,67237254862L,272092306164L,1101134446908L,4466186295698L,18113540529096L,73607652658268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200052Inst : IEnumerable<long>
{
public static readonly long[] Value=A200052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200052.Bytes);
public long this[int i]=>Value[i];

public static A200052Inst Instance=new A200052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200053
{
public static readonly long[] Value={ 1L,8L,36L,172L,840L,4172L,20978L,106674L,545698L,2811236L,14534258L,75522854L,393338058L,2056376914L,10767639532L,56550307652L,297322835298L,1567022163228L,8265441146830L,43685281805084L,231022736833454L,1223830782531260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200053Inst : IEnumerable<long>
{
public static readonly long[] Value=A200053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200053.Bytes);
public long this[int i]=>Value[i];

public static A200053Inst Instance=new A200053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200054
{
public static readonly long[] Value={ 1L,10L,56L,324L,1948L,11962L,74338L,466548L,2947742L,18746754L,119701782L,767860824L,4938868628L,31876070432L,206122332340L,1336425077996L,8676994345132L,56457974059982L,367738443114696L,2399500033305708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200054Inst : IEnumerable<long>
{
public static readonly long[] Value=A200054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200054.Bytes);
public long this[int i]=>Value[i];

public static A200054Inst Instance=new A200054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200055
{
public static readonly long[] Value={ 1L,12L,78L,546L,3914L,28554L,211242L,1577878L,11867186L,89815404L,682642050L,5211283212L,39897460856L,306446600454L,2358644800468L,18199380449274L,140644480480176L,1089068472750998L,8443172123261506L,65564035662489652L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200055Inst : IEnumerable<long>
{
public static readonly long[] Value=A200055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200055.Bytes);
public long this[int i]=>Value[i];

public static A200055Inst Instance=new A200055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200056
{
public static readonly long[] Value={ 1L,14L,106L,850L,7074L,59910L,514168L,4453946L,38855488L,341052122L,3006680636L,26619825378L,236386648574L,2105717447626L,18798362729604L,168222072625668L,1507848061916274L,13541292792666004L,121763260320351938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200056Inst : IEnumerable<long>
{
public static readonly long[] Value=A200056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200056.Bytes);
public long this[int i]=>Value[i];

public static A200056Inst Instance=new A200056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200057
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,4L,1L,6L,10L,4L,1L,8L,22L,26L,6L,1L,10L,36L,78L,68L,10L,1L,12L,56L,172L,288L,178L,14L,1L,14L,78L,324L,840L,1098L,472L,22L,1L,16L,106L,546L,1948L,4172L,4224L,1276L,34L,1L,18L,136L,850L,3914L,11962L,20978L,16432L,3462L,52L,1L,20L,172L,1252L,7074L,28554L,74338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200057Inst : IEnumerable<long>
{
public static readonly long[] Value=A200057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200057.Bytes);
public long this[int i]=>Value[i];

public static A200057Inst Instance=new A200057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200058
{
public static readonly long[] Value={ 4L,26L,78L,172L,324L,546L,850L,1252L,1764L,2398L,3170L,4092L,5176L,6438L,7890L,9544L,11416L,13518L,15862L,18464L,21336L,24490L,27942L,31704L,35788L,40210L,44982L,50116L,55628L,61530L,67834L,74556L,81708L,89302L,97354L,105876L,114880L,124382L,134394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200058Inst : IEnumerable<long>
{
public static readonly long[] Value=A200058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200058.Bytes);
public long this[int i]=>Value[i];

public static A200058Inst Instance=new A200058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200059
{
public static readonly long[] Value={ 6L,68L,288L,840L,1948L,3914L,7074L,11862L,18732L,28244L,40970L,57598L,78816L,105444L,138284L,178282L,226362L,283598L,351026L,429852L,521230L,626492L,746910L,883944L,1038982L,1213616L,1409348L,1627896L,1870884L,2140158L,2437454L,2764750L,3123900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200059Inst : IEnumerable<long>
{
public static readonly long[] Value=A200059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200059.Bytes);
public long this[int i]=>Value[i];

public static A200059Inst Instance=new A200059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200060
{
public static readonly long[] Value={ 10L,178L,1098L,4172L,11962L,28554L,59910L,114232L,202314L,337902L,538054L,823496L,1218978L,1753638L,2461350L,3381092L,4557298L,6040218L,7886274L,10158420L,12926498L,16267598L,20266414L,25015604L,30616142L,37177686L,44818926L,53667948L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200060Inst : IEnumerable<long>
{
public static readonly long[] Value=A200060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200060.Bytes);
public long this[int i]=>Value[i];

public static A200060Inst Instance=new A200060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200061
{
public static readonly long[] Value={ 14L,472L,4224L,20978L,74338L,211242L,514168L,1115572L,2215290L,4099888L,7165376L,11941380L,19119208L,29580842L,44432366L,65037696L,93057524L,130487666L,179703518L,243503094L,325156994L,428455996L,557766736L,718083722L,915090720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200061Inst : IEnumerable<long>
{
public static readonly long[] Value=A200061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200061.Bytes);
public long this[int i]=>Value[i];

public static A200061Inst Instance=new A200061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200062
{
public static readonly long[] Value={ 0L,1L,1L,4L,1L,15L,1L,41L,23L,133L,1L,650L,1L,1725L,961L,6930L,1L,30323L,1L,99716L,40431L,352729L,1L,1709125L,35467L,5200315L,2008233L,20960538L,1L,93058849L,1L,312220259L,105533203L,1166803129L,20194059L,5478229800L,1L,17672631921L,5731781295L,71539226243L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200062Inst : IEnumerable<long>
{
public static readonly long[] Value=A200062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200062.Bytes);
public long this[int i]=>Value[i];

public static A200062Inst Instance=new A200062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200063
{
public static readonly long[] Value={ 1L,2L,8L,32L,46L,392L,12230L,155942L,659488L,1025582L,1047128L,3437088L,1449322158L,1452777560L,1691887144L,4558298126L,4840156480L,39554086678L,353617531486L,608231808384L,619986226720L,969355365422L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200063Inst : IEnumerable<long>
{
public static readonly long[] Value=A200063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200063.Bytes);
public long this[int i]=>Value[i];

public static A200063Inst Instance=new A200063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200064
{
public static readonly long[] Value={ 1L,3L,1L,8L,2L,3L,4L,4L,1L,5L,7L,8L,6L,5L,8L,8L,4L,7L,2L,4L,0L,2L,3L,4L,0L,8L,1L,6L,6L,4L,5L,1L,1L,3L,1L,2L,1L,8L,7L,1L,3L,6L,2L,0L,4L,8L,6L,2L,7L,6L,7L,7L,4L,8L,8L,6L,2L,2L,8L,6L,6L,2L,6L,7L,6L,4L,7L,0L,4L,7L,5L,7L,6L,0L,4L,2L,4L,0L,1L,1L,7L,9L,4L,0L,5L,3L,0L,8L,2L,0L,1L,4L,0L,6L,3L,1L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200064Inst : IEnumerable<long>
{
public static readonly long[] Value=A200064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200064.Bytes);
public long this[int i]=>Value[i];

public static A200064Inst Instance=new A200064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200065
{
public static readonly long[] Value={ 0L,0L,13L,0L,0L,0L,17L,0L,19L,0L,1111111111111111111L,0L,113L,0L,0L,0L,1117L,0L,11119L,0L,111121L,0L,1123L,0L,0L,0L,127L,0L,1129L,0L,131L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200065Inst : IEnumerable<long>
{
public static readonly long[] Value=A200065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200065.Bytes);
public long this[int i]=>Value[i];

public static A200065Inst Instance=new A200065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200066
{
public static readonly long[] Value={ 3L,4L,5L,5L,6L,7L,8L,9L,10L,11L,11L,13L,17L,19L,19L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200066Inst : IEnumerable<long>
{
public static readonly long[] Value=A200066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200066.Bytes);
public long this[int i]=>Value[i];

public static A200066Inst Instance=new A200066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200067
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,6L,12L,20L,30L,45L,63L,84L,112L,144L,180L,225L,275L,330L,396L,468L,546L,637L,735L,840L,960L,1088L,1224L,1377L,1539L,1710L,1900L,2100L,2310L,2541L,2783L,3036L,3312L,3600L,3900L,4225L,4563L,4914L,5292L,5684L,6090L,6525L,6975L,7440L,7936L,8448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200067Inst : IEnumerable<long>
{
public static readonly long[] Value=A200067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200067.Bytes);
public long this[int i]=>Value[i];

public static A200067Inst Instance=new A200067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200068
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,5L,1L,1L,1L,7L,3L,1L,3L,0L,0L,2L,11L,4L,2L,4L,3L,1L,3L,0L,1L,1L,1L,0L,1L,15L,8L,3L,8L,3L,3L,7L,1L,2L,3L,1L,3L,2L,0L,1L,2L,0L,0L,1L,0L,1L,22L,11L,7L,12L,4L,5L,13L,5L,4L,7L,4L,4L,5L,0L,3L,6L,2L,1L,2L,1L,2L,3L,0L,0L,2L,1L,0L,0L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200068Inst : IEnumerable<long>
{
public static readonly long[] Value=A200068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200068.Bytes);
public long this[int i]=>Value[i];

public static A200068Inst Instance=new A200068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200069
{
public static readonly long[] Value={ 1L,4L,29L,168L,1049L,6380L,39157L,239568L,1467313L,8983636L,55009613L,336825720L,2062427849L,12628445756L,77325345061L,473471175072L,2899114186081L,17751582020260L,108694812500093L,665549816263752L,4075231827556217L,24953074921653644L,152790313444845397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200069Inst : IEnumerable<long>
{
public static readonly long[] Value=A200069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200069.Bytes);
public long this[int i]=>Value[i];

public static A200069Inst Instance=new A200069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200070
{
public static readonly long[] Value={ 110L,182L,220L,364L,374L,440L,494L,550L,728L,748L,782L,880L,988L,1100L,1210L,1274L,1334L,1456L,1496L,1564L,1760L,1976L,2200L,2294L,2366L,2420L,2548L,2668L,2750L,2912L,2992L,3128L,3182L,3520L,3854L,3952L,4114L,4400L,4588L,4732L,4840L,4982L,5096L,5336L,5500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200070Inst : IEnumerable<long>
{
public static readonly long[] Value=A200070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200070.Bytes);
public long this[int i]=>Value[i];

public static A200070Inst Instance=new A200070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200071
{
public static readonly long[] Value={ 447L,2042L,4942L,8673L,17232L,18321L,38232L,52953L,54468L,54974L,55174L,57229L,66567L,71132L,83071L,101499L,113667L,121206L,133047L,173932L,297907L,325286L,430353L,447131L,656079L,702969L,842151L,937313L,1061846L,1173886L,1613346L,1721094L,1754679L,1759310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200071Inst : IEnumerable<long>
{
public static readonly long[] Value=A200071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200071.Bytes);
public long this[int i]=>Value[i];

public static A200071Inst Instance=new A200071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200072
{
public static readonly long[] Value={ 1123L,1143L,6235L,8457L,11565L,21917L,22857L,33285L,41319L,58195L,119571L,124723L,128363L,173922L,178703L,188115L,243939L,280158L,308859L,309709L,409485L,430581L,565571L,703845L,961237L,1153362L,1170291L,1327998L,1409794L,1536651L,1586195L,1649395L,1665868L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200072Inst : IEnumerable<long>
{
public static readonly long[] Value=A200072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200072.Bytes);
public long this[int i]=>Value[i];

public static A200072Inst Instance=new A200072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200073
{
public static readonly long[] Value={ 1L,4L,3L,11L,15L,5L,29L,56L,35L,7L,76L,189L,171L,66L,9L,199L,605L,715L,407L,110L,11L,521L,1872L,2730L,2054L,832L,169L,13L,1364L,5655L,9810L,9180L,4965L,1533L,245L,15L,3571L,16779L,33745L,37774L,25585L,10642L,2618L,340L,17L,9349L,49096L,112309L,146357L,119168L,62453L,20862L,4218L,456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200073Inst : IEnumerable<long>
{
public static readonly long[] Value=A200073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200073.Bytes);
public long this[int i]=>Value[i];

public static A200073Inst Instance=new A200073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200074
{
public static readonly long[] Value={ 1L,1L,3L,9L,30L,108L,406L,1577L,6280L,25499L,105169L,439388L,1855636L,7908909L,33975250L,146954693L,639460707L,2797384235L,12295494109L,54272825103L,240480529815L,1069257987503L,4769306203838L,21334400243252L,95687482105807L,430217846136134L,1938651904470374L,8754225470415889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200074Inst : IEnumerable<long>
{
public static readonly long[] Value=A200074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200074.Bytes);
public long this[int i]=>Value[i];

public static A200074Inst Instance=new A200074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200075
{
public static readonly long[] Value={ 1L,1L,3L,11L,45L,198L,914L,4367L,21414L,107155L,544987L,2808978L,14640073L,77025373L,408544815L,2182206259L,11727989593L,63373962690L,344109933186L,1876562458845L,10273572074493L,56443282489240L,311097732946200L,1719707775782826L,9531914043637385L,52963938340248863L,294966593345731623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200075Inst : IEnumerable<long>
{
public static readonly long[] Value=A200075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200075.Bytes);
public long this[int i]=>Value[i];

public static A200075Inst Instance=new A200075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200076
{
public static readonly long[] Value={ 1L,3L,3L,3L,7L,9L,9L,15L,7L,3L,11L,29L,43L,73L,25L,5L,27L,53L,97L,123L,29L,41L,93L,85L,35L,35L,17L,9L,55L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200076Inst : IEnumerable<long>
{
public static readonly long[] Value=A200076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200076.Bytes);
public long this[int i]=>Value[i];

public static A200076Inst Instance=new A200076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200077
{
public static readonly long[] Value={ 1L,4L,6L,8L,14L,18L,24L,56L,26L,26L,54L,226L,260L,482L,196L,54L,128L,728L,1226L,4106L,1168L,272L,892L,4798L,1390L,1298L,962L,216L,470L,2104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200077Inst : IEnumerable<long>
{
public static readonly long[] Value=A200077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200077.Bytes);
public long this[int i]=>Value[i];

public static A200077Inst Instance=new A200077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200078
{
public static readonly long[] Value={ 1L,5L,9L,17L,27L,37L,85L,169L,151L,219L,533L,1553L,2333L,4197L,2607L,2419L,6343L,25235L,55337L,113875L,35671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200078Inst : IEnumerable<long>
{
public static readonly long[] Value=A200078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200078.Bytes);
public long this[int i]=>Value[i];

public static A200078Inst Instance=new A200078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200079
{
public static readonly long[] Value={ 1L,6L,12L,26L,58L,108L,202L,394L,468L,848L,2560L,7740L,11372L,28356L,20660L,20032L,68026L,312678L,662542L,1536878L,812306L,461910L,1466416L,10325202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200079Inst : IEnumerable<long>
{
public static readonly long[] Value=A200079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200079.Bytes);
public long this[int i]=>Value[i];

public static A200079Inst Instance=new A200079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200080
{
public static readonly long[] Value={ 1L,7L,17L,43L,111L,245L,429L,855L,1863L,3573L,10241L,30645L,50043L,160499L,149009L,149121L,755895L,3366835L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200080Inst : IEnumerable<long>
{
public static readonly long[] Value=A200080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200080.Bytes);
public long this[int i]=>Value[i];

public static A200080Inst Instance=new A200080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200081
{
public static readonly long[] Value={ 1L,8L,22L,64L,182L,454L,1046L,2546L,5056L,11638L,33262L,101112L,191802L,688304L,769106L,1102184L,5220960L,23546744L,49886556L,135889790L,142614238L,121124812L,570957758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200081Inst : IEnumerable<long>
{
public static readonly long[] Value=A200081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200081.Bytes);
public long this[int i]=>Value[i];

public static A200081Inst Instance=new A200081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200082
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,1L,4L,3L,2L,1L,5L,6L,3L,2L,1L,6L,9L,8L,7L,2L,1L,7L,12L,17L,14L,9L,2L,1L,8L,17L,26L,27L,18L,9L,2L,1L,9L,22L,43L,58L,37L,24L,15L,2L,1L,10L,27L,64L,111L,108L,85L,56L,7L,2L,1L,11L,34L,89L,182L,245L,202L,169L,26L,3L,2L,1L,12L,41L,122L,279L,454L,429L,394L,151L,26L,11L,2L,1L,13L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200082Inst : IEnumerable<long>
{
public static readonly long[] Value=A200082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200082.Bytes);
public long this[int i]=>Value[i];

public static A200082Inst Instance=new A200082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200083
{
public static readonly long[] Value={ 2L,3L,8L,17L,26L,43L,64L,89L,122L,163L,208L,269L,334L,407L,496L,597L,702L,831L,968L,1117L,1286L,1471L,1664L,1889L,2122L,2371L,2648L,2945L,3250L,3595L,3952L,4329L,4738L,5171L,5616L,6109L,6614L,7143L,7712L,8309L,8918L,9583L,10264L,10973L,11726L,12511L,13312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200083Inst : IEnumerable<long>
{
public static readonly long[] Value=A200083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200083.Bytes);
public long this[int i]=>Value[i];

public static A200083Inst Instance=new A200083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200084
{
public static readonly long[] Value={ 2L,7L,14L,27L,58L,111L,182L,279L,404L,617L,872L,1199L,1580L,2045L,2678L,3437L,4300L,5305L,6430L,7903L,9530L,11389L,13420L,15707L,18460L,21537L,24870L,28553L,32518L,37265L,42342L,47905L,53828L,60267L,67620L,75589L,84034L,93127L,102734L,113729L,125300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200084Inst : IEnumerable<long>
{
public static readonly long[] Value=A200084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200084.Bytes);
public long this[int i]=>Value[i];

public static A200084Inst Instance=new A200084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200085
{
public static readonly long[] Value={ 2L,9L,18L,37L,108L,245L,454L,759L,1172L,2001L,3144L,4663L,6568L,8945L,12690L,17353L,23022L,29787L,37710L,48921L,62130L,77465L,95100L,115177L,141596L,171767L,205850L,244065L,286652L,340277L,400038L,466375L,539488L,619685L,717388L,824733L,942014L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200085Inst : IEnumerable<long>
{
public static readonly long[] Value=A200085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200085.Bytes);
public long this[int i]=>Value[i];

public static A200085Inst Instance=new A200085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200086
{
public static readonly long[] Value={ 2L,9L,24L,85L,202L,429L,1046L,2145L,4022L,6955L,11438L,17927L,26868L,41817L,62238L,89715L,125864L,172459L,231700L,305753L,409430L,537577L,695264L,886875L,1116878L,1391945L,1717032L,2134089L,2625830L,3201035L,3869292L,4642295L,5530982L,6546651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200086Inst : IEnumerable<long>
{
public static readonly long[] Value=A200086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200086.Bytes);
public long this[int i]=>Value[i];

public static A200086Inst Instance=new A200086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200087
{
public static readonly long[] Value={ 1L,2L,53L,5L,71L,26L,9L,8L,19L,72L,149L,27L,91L,18L,21L,17L,43L,20L,29L,50L,35L,150L,45L,28L,99L,92L,773L,34L,171L,42L,33L,32L,123L,44L,49L,41L,75227L,58L,137L,51L,295L,48L,789L,68L,47L,46L,65L,57L,891L,100L,269L,90L,111L,428L,921L,64L,131L,172L,105L,203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200087Inst : IEnumerable<long>
{
public static readonly long[] Value=A200087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200087.Bytes);
public long this[int i]=>Value[i];

public static A200087Inst Instance=new A200087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200088
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,13L,16L,19L,21L,22L,25L,28L,30L,31L,34L,37L,43L,46L,49L,51L,52L,55L,58L,60L,61L,64L,67L,73L,76L,79L,85L,88L,94L,97L,100L,101L,102L,103L,106L,109L,111L,112L,115L,118L,120L,121L,124L,127L,133L,136L,139L,141L,142L,145L,148L,150L,151L,154L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200088Inst : IEnumerable<long>
{
public static readonly long[] Value=A200088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200088.Bytes);
public long this[int i]=>Value[i];

public static A200088Inst Instance=new A200088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200089
{
public static readonly long[] Value={ 1L,4L,3L,8L,6L,9L,2L,9L,4L,3L,2L,8L,8L,2L,2L,6L,4L,4L,3L,9L,2L,8L,2L,5L,3L,6L,9L,6L,2L,0L,3L,7L,4L,9L,1L,4L,2L,8L,5L,1L,7L,2L,3L,1L,9L,3L,7L,9L,6L,1L,0L,8L,4L,4L,0L,4L,3L,6L,3L,4L,1L,6L,9L,7L,3L,2L,3L,4L,4L,5L,6L,2L,6L,6L,2L,8L,4L,1L,1L,4L,1L,2L,4L,8L,2L,0L,5L,7L,1L,7L,3L,8L,1L,6L,7L,0L,8L,8L,3L,1L,3L,8L,5L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200089Inst : IEnumerable<long>
{
public static readonly long[] Value=A200089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200089.Bytes);
public long this[int i]=>Value[i];

public static A200089Inst Instance=new A200089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200090
{
public static readonly long[] Value={ 15015L,45045L,51051L,62985L,72930L,74613L,75075L,105105L,106590L,135135L,145860L,153153L,156009L,165165L,187473L,188955L,190190L,195195L,213180L,218790L,222870L,223839L,225225L,279565L,291720L,314925L,315315L,319770L,335478L,357357L,364650L,375375L,380380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200090Inst : IEnumerable<long>
{
public static readonly long[] Value=A200090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200090.Bytes);
public long this[int i]=>Value[i];

public static A200090Inst Instance=new A200090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200091
{
public static readonly long[] Value={ 1L,1L,1L,6L,1L,20L,1L,50L,90L,1L,112L,630L,1L,238L,2940L,2520L,1L,492L,11508L,30240L,1L,1002L,40950L,226800L,113400L,1L,2024L,137610L,1367520L,2079000L,1L,4070L,445896L,7271880L,22869000L,7484400L,1L,8164L,1410552L,35692800L,196396200L,194594400L,1L,16354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200091Inst : IEnumerable<long>
{
public static readonly long[] Value=A200091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200091.Bytes);
public long this[int i]=>Value[i];

public static A200091Inst Instance=new A200091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200092
{
public static readonly long[] Value={ 1L,1L,1L,1L,20L,1L,70L,1L,182L,1L,420L,1680L,1L,912L,12600L,1L,1914L,62370L,1L,3938L,256410L,369600L,1L,8008L,949806L,4804800L,1L,16172L,3297294L,38678640L,1L,32526L,10966956L,248047800L,168168000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200092Inst : IEnumerable<long>
{
public static readonly long[] Value=A200092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200092.Bytes);
public long this[int i]=>Value[i];

public static A200092Inst Instance=new A200092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200093
{
public static readonly long[] Value={ 8L,0L,2L,9L,9L,2L,1L,5L,4L,2L,9L,7L,8L,8L,4L,2L,5L,0L,7L,2L,0L,3L,3L,5L,4L,5L,3L,4L,7L,4L,8L,7L,1L,2L,7L,4L,2L,9L,2L,1L,4L,1L,3L,5L,7L,7L,0L,0L,7L,2L,7L,7L,8L,3L,0L,6L,5L,8L,5L,4L,6L,2L,3L,2L,9L,7L,3L,5L,2L,1L,2L,9L,9L,1L,4L,3L,9L,4L,2L,5L,5L,9L,3L,6L,6L,4L,9L,4L,1L,0L,6L,9L,9L,2L,0L,4L,1L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200093Inst : IEnumerable<long>
{
public static readonly long[] Value=A200093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200093.Bytes);
public long this[int i]=>Value[i];

public static A200093Inst Instance=new A200093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200094
{
public static readonly long[] Value={ 1L,4L,9L,2L,6L,6L,5L,9L,2L,3L,5L,2L,5L,1L,3L,2L,2L,0L,6L,9L,6L,9L,2L,4L,3L,0L,5L,9L,8L,3L,4L,9L,3L,6L,8L,6L,1L,2L,4L,0L,4L,8L,8L,9L,5L,6L,1L,6L,3L,5L,6L,4L,3L,2L,6L,8L,3L,4L,4L,8L,4L,7L,9L,6L,0L,6L,9L,1L,2L,4L,2L,5L,9L,1L,7L,2L,9L,7L,0L,3L,5L,3L,3L,6L,8L,4L,1L,3L,1L,4L,1L,0L,3L,0L,8L,7L,9L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200094Inst : IEnumerable<long>
{
public static readonly long[] Value=A200094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200094.Bytes);
public long this[int i]=>Value[i];

public static A200094Inst Instance=new A200094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200095
{
public static readonly long[] Value={ 6L,7L,7L,1L,1L,9L,4L,1L,1L,6L,9L,7L,9L,4L,3L,1L,3L,0L,1L,8L,4L,1L,7L,9L,5L,2L,0L,0L,9L,8L,9L,1L,7L,0L,2L,1L,5L,5L,6L,6L,4L,5L,5L,5L,2L,5L,3L,3L,6L,9L,3L,2L,4L,4L,3L,7L,6L,9L,1L,1L,5L,4L,0L,1L,8L,3L,5L,0L,3L,8L,3L,8L,7L,6L,2L,7L,8L,4L,0L,3L,8L,9L,9L,8L,9L,8L,2L,7L,3L,9L,2L,3L,4L,8L,4L,8L,2L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200095Inst : IEnumerable<long>
{
public static readonly long[] Value=A200095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200095.Bytes);
public long this[int i]=>Value[i];

public static A200095Inst Instance=new A200095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200096
{
public static readonly long[] Value={ 1L,6L,5L,4L,6L,9L,9L,7L,8L,2L,2L,9L,3L,9L,0L,1L,0L,7L,1L,1L,3L,1L,6L,8L,6L,6L,8L,1L,8L,3L,0L,8L,0L,0L,6L,3L,5L,4L,6L,5L,9L,6L,8L,5L,5L,6L,7L,0L,3L,5L,0L,6L,3L,0L,7L,5L,3L,8L,7L,7L,2L,4L,0L,1L,0L,7L,0L,3L,8L,7L,2L,6L,4L,8L,7L,7L,0L,4L,0L,0L,3L,7L,8L,7L,1L,8L,7L,6L,8L,5L,2L,5L,7L,6L,2L,3L,7L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200096Inst : IEnumerable<long>
{
public static readonly long[] Value=A200096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200096.Bytes);
public long this[int i]=>Value[i];

public static A200096Inst Instance=new A200096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200097
{
public static readonly long[] Value={ 5L,7L,6L,8L,9L,1L,1L,7L,6L,9L,6L,2L,1L,8L,6L,4L,3L,5L,7L,5L,2L,4L,3L,6L,5L,9L,7L,7L,1L,8L,2L,6L,1L,6L,8L,8L,1L,3L,0L,0L,1L,4L,9L,2L,6L,4L,9L,3L,8L,9L,4L,3L,7L,3L,7L,0L,9L,4L,4L,4L,3L,6L,3L,0L,1L,9L,9L,8L,0L,5L,6L,2L,7L,8L,9L,7L,6L,0L,4L,1L,7L,0L,4L,0L,7L,2L,5L,0L,1L,3L,7L,5L,2L,3L,3L,7L,1L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200097Inst : IEnumerable<long>
{
public static readonly long[] Value=A200097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200097.Bytes);
public long this[int i]=>Value[i];

public static A200097Inst Instance=new A200097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200098
{
public static readonly long[] Value={ 1L,7L,9L,6L,4L,6L,7L,4L,1L,8L,6L,3L,5L,0L,0L,8L,4L,2L,7L,0L,7L,8L,8L,5L,2L,3L,6L,6L,1L,4L,9L,4L,9L,0L,9L,3L,7L,7L,3L,8L,6L,0L,8L,3L,6L,2L,1L,3L,7L,1L,9L,9L,8L,4L,1L,8L,1L,9L,2L,1L,5L,3L,1L,6L,9L,4L,3L,4L,1L,7L,4L,7L,5L,9L,0L,5L,3L,9L,8L,9L,7L,9L,9L,3L,1L,0L,0L,7L,7L,3L,9L,4L,9L,0L,9L,4L,3L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200098Inst : IEnumerable<long>
{
public static readonly long[] Value=A200098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200098.Bytes);
public long this[int i]=>Value[i];

public static A200098Inst Instance=new A200098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200099
{
public static readonly long[] Value={ 1L,0L,5L,3L,3L,5L,2L,9L,8L,3L,6L,0L,0L,1L,5L,3L,7L,3L,3L,2L,8L,1L,1L,1L,0L,1L,5L,7L,9L,9L,9L,4L,6L,8L,4L,6L,4L,9L,7L,0L,2L,8L,5L,2L,7L,9L,2L,2L,5L,9L,2L,3L,5L,3L,4L,2L,2L,3L,2L,3L,5L,1L,9L,8L,5L,0L,7L,9L,9L,4L,3L,8L,1L,7L,4L,0L,4L,9L,1L,8L,0L,3L,9L,2L,4L,8L,9L,8L,6L,2L,2L,7L,8L,6L,5L,8L,5L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200099Inst : IEnumerable<long>
{
public static readonly long[] Value=A200099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200099.Bytes);
public long this[int i]=>Value[i];

public static A200099Inst Instance=new A200099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200100
{
public static readonly long[] Value={ 1L,3L,5L,4L,5L,7L,5L,5L,5L,8L,2L,1L,5L,8L,5L,7L,8L,4L,4L,9L,0L,8L,9L,0L,7L,7L,0L,1L,6L,4L,6L,4L,6L,3L,7L,1L,8L,8L,1L,7L,4L,5L,1L,3L,4L,2L,1L,0L,6L,2L,6L,4L,5L,6L,2L,3L,4L,1L,1L,1L,6L,9L,6L,7L,0L,1L,4L,2L,1L,3L,1L,9L,1L,6L,3L,0L,2L,2L,8L,8L,3L,3L,1L,9L,0L,4L,0L,2L,9L,8L,1L,8L,3L,5L,3L,7L,7L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200100Inst : IEnumerable<long>
{
public static readonly long[] Value=A200100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200100.Bytes);
public long this[int i]=>Value[i];

public static A200100Inst Instance=new A200100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200101
{
public static readonly long[] Value={ 9L,1L,7L,7L,0L,1L,3L,1L,5L,8L,3L,1L,6L,0L,0L,4L,7L,5L,1L,7L,0L,5L,2L,4L,3L,9L,0L,9L,5L,3L,9L,2L,1L,4L,8L,7L,7L,1L,8L,1L,9L,6L,1L,1L,6L,8L,5L,9L,0L,0L,5L,7L,1L,1L,5L,1L,0L,0L,4L,8L,9L,0L,0L,2L,2L,4L,8L,9L,4L,4L,8L,7L,9L,0L,0L,7L,1L,1L,5L,4L,2L,2L,3L,0L,2L,3L,3L,9L,9L,7L,4L,4L,0L,5L,8L,6L,8L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200101Inst : IEnumerable<long>
{
public static readonly long[] Value=A200101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200101.Bytes);
public long this[int i]=>Value[i];

public static A200101Inst Instance=new A200101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200102
{
public static readonly long[] Value={ 1L,5L,0L,4L,0L,7L,4L,3L,6L,5L,6L,0L,3L,9L,0L,8L,4L,5L,6L,2L,5L,7L,7L,0L,9L,6L,8L,1L,3L,1L,2L,5L,9L,7L,2L,7L,8L,5L,5L,0L,0L,6L,5L,6L,0L,9L,3L,9L,5L,9L,0L,8L,3L,2L,2L,3L,4L,0L,3L,8L,1L,1L,2L,3L,9L,7L,6L,0L,1L,6L,5L,6L,2L,7L,5L,7L,6L,0L,1L,4L,0L,7L,0L,4L,0L,8L,6L,7L,1L,7L,2L,8L,3L,5L,5L,4L,8L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200102Inst : IEnumerable<long>
{
public static readonly long[] Value=A200102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200102.Bytes);
public long this[int i]=>Value[i];

public static A200102Inst Instance=new A200102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200103
{
public static readonly long[] Value={ 7L,9L,9L,2L,0L,0L,8L,1L,6L,8L,9L,5L,0L,9L,7L,0L,0L,5L,9L,4L,4L,4L,6L,0L,0L,6L,9L,2L,3L,2L,1L,1L,0L,1L,0L,4L,1L,2L,5L,1L,2L,1L,2L,6L,7L,1L,1L,1L,6L,1L,4L,3L,6L,3L,7L,8L,0L,2L,0L,8L,4L,8L,6L,9L,4L,0L,5L,8L,0L,2L,7L,0L,8L,4L,8L,0L,7L,3L,4L,1L,6L,4L,1L,1L,8L,9L,1L,8L,7L,8L,2L,4L,3L,0L,4L,5L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200103Inst : IEnumerable<long>
{
public static readonly long[] Value=A200103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200103.Bytes);
public long this[int i]=>Value[i];

public static A200103Inst Instance=new A200103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200104
{
public static readonly long[] Value={ 1L,6L,4L,3L,5L,5L,6L,5L,6L,7L,5L,2L,0L,1L,7L,1L,6L,5L,6L,9L,0L,6L,5L,2L,4L,7L,6L,1L,6L,3L,4L,8L,8L,8L,1L,6L,9L,4L,6L,0L,7L,4L,9L,2L,9L,7L,7L,5L,1L,3L,9L,1L,4L,8L,5L,7L,2L,0L,1L,3L,8L,1L,5L,2L,2L,6L,2L,9L,4L,3L,3L,5L,9L,0L,4L,2L,1L,6L,1L,2L,9L,4L,5L,5L,9L,5L,8L,9L,8L,4L,0L,0L,3L,6L,4L,1L,3L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200104Inst : IEnumerable<long>
{
public static readonly long[] Value=A200104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200104.Bytes);
public long this[int i]=>Value[i];

public static A200104Inst Instance=new A200104Inst();

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