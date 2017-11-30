using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A021032
{
public static readonly long[] Value={ 0L,3L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021032Inst : IEnumerable<long>
{
public static readonly long[] Value=A021032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021032.Bytes);
public long this[int i]=>Value[i];

public static A021032Inst Instance=new A021032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021033
{
public static readonly long[] Value={ 0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021033Inst : IEnumerable<long>
{
public static readonly long[] Value=A021033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021033.Bytes);
public long this[int i]=>Value[i];

public static A021033Inst Instance=new A021033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021034
{
public static readonly long[] Value={ 1L,13L,116L,902L,6615L,47271L,333922L,2346784L,16455989L,115278449L,807210768L,5651264346L,39561225523L,276935720347L,1938571500254L,13570064940788L,94990648033617L,664935116841765L,4654547560235980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021034Inst : IEnumerable<long>
{
public static readonly long[] Value=A021034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021034.Bytes);
public long this[int i]=>Value[i];

public static A021034Inst Instance=new A021034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021035
{
public static readonly long[] Value={ 0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021035Inst : IEnumerable<long>
{
public static readonly long[] Value=A021035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021035.Bytes);
public long this[int i]=>Value[i];

public static A021035Inst Instance=new A021035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021036
{
public static readonly long[] Value={ 0L,3L,1L,2L,5L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021036Inst : IEnumerable<long>
{
public static readonly long[] Value=A021036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021036.Bytes);
public long this[int i]=>Value[i];

public static A021036Inst Instance=new A021036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021357
{
public static readonly long[] Value={ 0L,0L,2L,8L,3L,2L,8L,6L,1L,1L,8L,9L,8L,0L,1L,6L,9L,9L,7L,1L,6L,7L,1L,3L,8L,8L,1L,0L,1L,9L,8L,3L,0L,0L,2L,8L,3L,2L,8L,6L,1L,1L,8L,9L,8L,0L,1L,6L,9L,9L,7L,1L,6L,7L,1L,3L,8L,8L,1L,0L,1L,9L,8L,3L,0L,0L,2L,8L,3L,2L,8L,6L,1L,1L,8L,9L,8L,0L,1L,6L,9L,9L,7L,1L,6L,7L,1L,3L,8L,8L,1L,0L,1L,9L,8L,3L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021357Inst : IEnumerable<long>
{
public static readonly long[] Value=A021357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021357.Bytes);
public long this[int i]=>Value[i];

public static A021357Inst Instance=new A021357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021358
{
public static readonly long[] Value={ 0L,0L,2L,8L,2L,4L,8L,5L,8L,7L,5L,7L,0L,6L,2L,1L,4L,6L,8L,9L,2L,6L,5L,5L,3L,6L,7L,2L,3L,1L,6L,3L,8L,4L,1L,8L,0L,7L,9L,0L,9L,6L,0L,4L,5L,1L,9L,7L,7L,4L,0L,1L,1L,2L,9L,9L,4L,3L,5L,0L,2L,8L,2L,4L,8L,5L,8L,7L,5L,7L,0L,6L,2L,1L,4L,6L,8L,9L,2L,6L,5L,5L,3L,6L,7L,2L,3L,1L,6L,3L,8L,4L,1L,8L,0L,7L,9L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021358Inst : IEnumerable<long>
{
public static readonly long[] Value=A021358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021358.Bytes);
public long this[int i]=>Value[i];

public static A021358Inst Instance=new A021358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021359
{
public static readonly long[] Value={ 0L,0L,2L,8L,1L,6L,9L,0L,1L,4L,0L,8L,4L,5L,0L,7L,0L,4L,2L,2L,5L,3L,5L,2L,1L,1L,2L,6L,7L,6L,0L,5L,6L,3L,3L,8L,0L,2L,8L,1L,6L,9L,0L,1L,4L,0L,8L,4L,5L,0L,7L,0L,4L,2L,2L,5L,3L,5L,2L,1L,1L,2L,6L,7L,6L,0L,5L,6L,3L,3L,8L,0L,2L,8L,1L,6L,9L,0L,1L,4L,0L,8L,4L,5L,0L,7L,0L,4L,2L,2L,5L,3L,5L,2L,1L,1L,2L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021359Inst : IEnumerable<long>
{
public static readonly long[] Value=A021359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021359.Bytes);
public long this[int i]=>Value[i];

public static A021359Inst Instance=new A021359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021360
{
public static readonly long[] Value={ 0L,0L,2L,8L,0L,8L,9L,8L,8L,7L,6L,4L,0L,4L,4L,9L,4L,3L,8L,2L,0L,2L,2L,4L,7L,1L,9L,1L,0L,1L,1L,2L,3L,5L,9L,5L,5L,0L,5L,6L,1L,7L,9L,7L,7L,5L,2L,8L,0L,8L,9L,8L,8L,7L,6L,4L,0L,4L,4L,9L,4L,3L,8L,2L,0L,2L,2L,4L,7L,1L,9L,1L,0L,1L,1L,2L,3L,5L,9L,5L,5L,0L,5L,6L,1L,7L,9L,7L,7L,5L,2L,8L,0L,8L,9L,8L,8L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021360Inst : IEnumerable<long>
{
public static readonly long[] Value=A021360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021360.Bytes);
public long this[int i]=>Value[i];

public static A021360Inst Instance=new A021360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021361
{
public static readonly long[] Value={ 0L,0L,2L,8L,0L,1L,1L,2L,0L,4L,4L,8L,1L,7L,9L,2L,7L,1L,7L,0L,8L,6L,8L,3L,4L,7L,3L,3L,8L,9L,3L,5L,5L,7L,4L,2L,2L,9L,6L,9L,1L,8L,7L,6L,7L,5L,0L,7L,0L,0L,2L,8L,0L,1L,1L,2L,0L,4L,4L,8L,1L,7L,9L,2L,7L,1L,7L,0L,8L,6L,8L,3L,4L,7L,3L,3L,8L,9L,3L,5L,5L,7L,4L,2L,2L,9L,6L,9L,1L,8L,7L,6L,7L,5L,0L,7L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021361Inst : IEnumerable<long>
{
public static readonly long[] Value=A021361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021361.Bytes);
public long this[int i]=>Value[i];

public static A021361Inst Instance=new A021361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021362
{
public static readonly long[] Value={ 0L,0L,2L,7L,9L,3L,2L,9L,6L,0L,8L,9L,3L,8L,5L,4L,7L,4L,8L,6L,0L,3L,3L,5L,1L,9L,5L,5L,3L,0L,7L,2L,6L,2L,5L,6L,9L,8L,3L,2L,4L,0L,2L,2L,3L,4L,6L,3L,6L,8L,7L,1L,5L,0L,8L,3L,7L,9L,8L,8L,8L,2L,6L,8L,1L,5L,6L,4L,2L,4L,5L,8L,1L,0L,0L,5L,5L,8L,6L,5L,9L,2L,1L,7L,8L,7L,7L,0L,9L,4L,9L,7L,2L,0L,6L,7L,0L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021362Inst : IEnumerable<long>
{
public static readonly long[] Value=A021362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021362.Bytes);
public long this[int i]=>Value[i];

public static A021362Inst Instance=new A021362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021363
{
public static readonly long[] Value={ 0L,0L,2L,7L,8L,5L,5L,1L,5L,3L,2L,0L,3L,3L,4L,2L,6L,1L,8L,3L,8L,4L,4L,0L,1L,1L,1L,4L,2L,0L,6L,1L,2L,8L,1L,3L,3L,7L,0L,4L,7L,3L,5L,3L,7L,6L,0L,4L,4L,5L,6L,8L,2L,4L,5L,1L,2L,5L,3L,4L,8L,1L,8L,9L,4L,1L,5L,0L,4L,1L,7L,8L,2L,7L,2L,9L,8L,0L,5L,0L,1L,3L,9L,2L,7L,5L,7L,6L,6L,0L,1L,6L,7L,1L,3L,0L,9L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021363Inst : IEnumerable<long>
{
public static readonly long[] Value=A021363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021363.Bytes);
public long this[int i]=>Value[i];

public static A021363Inst Instance=new A021363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021364
{
public static readonly long[] Value={ 1L,15L,150L,1270L,9891L,73605L,533800L,3814140L,27018981L,190442395L,1338423450L,9390536610L,65820843271L,461096642385L,3229086629100L,22609268456680L,158287591978761L,1108104188689575L,7757094081310750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021364Inst : IEnumerable<long>
{
public static readonly long[] Value=A021364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021364.Bytes);
public long this[int i]=>Value[i];

public static A021364Inst Instance=new A021364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021365
{
public static readonly long[] Value={ 0L,0L,2L,7L,7L,0L,0L,8L,3L,1L,0L,2L,4L,9L,3L,0L,7L,4L,7L,9L,2L,2L,4L,3L,7L,6L,7L,3L,1L,3L,0L,1L,9L,3L,9L,0L,5L,8L,1L,7L,1L,7L,4L,5L,1L,5L,2L,3L,5L,4L,5L,7L,0L,6L,3L,7L,1L,1L,9L,1L,1L,3L,5L,7L,3L,4L,0L,7L,2L,0L,2L,2L,1L,6L,0L,6L,6L,4L,8L,1L,9L,9L,4L,4L,5L,9L,8L,3L,3L,7L,9L,5L,0L,1L,3L,8L,5L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021365Inst : IEnumerable<long>
{
public static readonly long[] Value=A021365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021365.Bytes);
public long this[int i]=>Value[i];

public static A021365Inst Instance=new A021365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021366
{
public static readonly long[] Value={ 0L,0L,2L,7L,6L,2L,4L,3L,0L,9L,3L,9L,2L,2L,6L,5L,1L,9L,3L,3L,7L,0L,1L,6L,5L,7L,4L,5L,8L,5L,6L,3L,5L,3L,5L,9L,1L,1L,6L,0L,2L,2L,0L,9L,9L,4L,4L,7L,5L,1L,3L,8L,1L,2L,1L,5L,4L,6L,9L,6L,1L,3L,2L,5L,9L,6L,6L,8L,5L,0L,8L,2L,8L,7L,2L,9L,2L,8L,1L,7L,6L,7L,9L,5L,5L,8L,0L,1L,1L,0L,4L,9L,7L,2L,3L,7L,5L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021366Inst : IEnumerable<long>
{
public static readonly long[] Value=A021366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021366.Bytes);
public long this[int i]=>Value[i];

public static A021366Inst Instance=new A021366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021367
{
public static readonly long[] Value={ 0L,0L,2L,7L,5L,4L,8L,2L,0L,9L,3L,6L,6L,3L,9L,1L,1L,8L,4L,5L,7L,3L,0L,0L,2L,7L,5L,4L,8L,2L,0L,9L,3L,6L,6L,3L,9L,1L,1L,8L,4L,5L,7L,3L,0L,0L,2L,7L,5L,4L,8L,2L,0L,9L,3L,6L,6L,3L,9L,1L,1L,8L,4L,5L,7L,3L,0L,0L,2L,7L,5L,4L,8L,2L,0L,9L,3L,6L,6L,3L,9L,1L,1L,8L,4L,5L,7L,3L,0L,0L,2L,7L,5L,4L,8L,2L,0L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021367Inst : IEnumerable<long>
{
public static readonly long[] Value=A021367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021367.Bytes);
public long this[int i]=>Value[i];

public static A021367Inst Instance=new A021367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021368
{
public static readonly long[] Value={ 0L,0L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021368Inst : IEnumerable<long>
{
public static readonly long[] Value=A021368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021368.Bytes);
public long this[int i]=>Value[i];

public static A021368Inst Instance=new A021368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021369
{
public static readonly long[] Value={ 0L,0L,2L,7L,3L,9L,7L,2L,6L,0L,2L,7L,3L,9L,7L,2L,6L,0L,2L,7L,3L,9L,7L,2L,6L,0L,2L,7L,3L,9L,7L,2L,6L,0L,2L,7L,3L,9L,7L,2L,6L,0L,2L,7L,3L,9L,7L,2L,6L,0L,2L,7L,3L,9L,7L,2L,6L,0L,2L,7L,3L,9L,7L,2L,6L,0L,2L,7L,3L,9L,7L,2L,6L,0L,2L,7L,3L,9L,7L,2L,6L,0L,2L,7L,3L,9L,7L,2L,6L,0L,2L,7L,3L,9L,7L,2L,6L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021369Inst : IEnumerable<long>
{
public static readonly long[] Value=A021369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021369.Bytes);
public long this[int i]=>Value[i];

public static A021369Inst Instance=new A021369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021370
{
public static readonly long[] Value={ 0L,0L,2L,7L,3L,2L,2L,4L,0L,4L,3L,7L,1L,5L,8L,4L,6L,9L,9L,4L,5L,3L,5L,5L,1L,9L,1L,2L,5L,6L,8L,3L,0L,6L,0L,1L,0L,9L,2L,8L,9L,6L,1L,7L,4L,8L,6L,3L,3L,8L,7L,9L,7L,8L,1L,4L,2L,0L,7L,6L,5L,0L,2L,7L,3L,2L,2L,4L,0L,4L,3L,7L,1L,5L,8L,4L,6L,9L,9L,4L,5L,3L,5L,5L,1L,9L,1L,2L,5L,6L,8L,3L,0L,6L,0L,1L,0L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021370Inst : IEnumerable<long>
{
public static readonly long[] Value=A021370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021370.Bytes);
public long this[int i]=>Value[i];

public static A021370Inst Instance=new A021370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021371
{
public static readonly long[] Value={ 0L,0L,2L,7L,2L,4L,7L,9L,5L,6L,4L,0L,3L,2L,6L,9L,7L,5L,4L,7L,6L,8L,3L,9L,2L,3L,7L,0L,5L,7L,2L,2L,0L,7L,0L,8L,4L,4L,6L,8L,6L,6L,4L,8L,5L,0L,1L,3L,6L,2L,3L,9L,7L,8L,2L,0L,1L,6L,3L,4L,8L,7L,7L,3L,8L,4L,1L,9L,6L,1L,8L,5L,2L,8L,6L,1L,0L,3L,5L,4L,2L,2L,3L,4L,3L,3L,2L,4L,2L,5L,0L,6L,8L,1L,1L,9L,8L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021371Inst : IEnumerable<long>
{
public static readonly long[] Value=A021371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021371.Bytes);
public long this[int i]=>Value[i];

public static A021371Inst Instance=new A021371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021372
{
public static readonly long[] Value={ 0L,0L,2L,7L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021372Inst : IEnumerable<long>
{
public static readonly long[] Value=A021372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021372.Bytes);
public long this[int i]=>Value[i];

public static A021372Inst Instance=new A021372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021389
{
public static readonly long[] Value={ 0L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021389Inst : IEnumerable<long>
{
public static readonly long[] Value=A021389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021389.Bytes);
public long this[int i]=>Value[i];

public static A021389Inst Instance=new A021389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021390
{
public static readonly long[] Value={ 0L,0L,2L,5L,9L,0L,6L,7L,3L,5L,7L,5L,1L,2L,9L,5L,3L,3L,6L,7L,8L,7L,5L,6L,4L,7L,6L,6L,8L,3L,9L,3L,7L,8L,2L,3L,8L,3L,4L,1L,9L,6L,8L,9L,1L,1L,9L,1L,7L,0L,9L,8L,4L,4L,5L,5L,9L,5L,8L,5L,4L,9L,2L,2L,2L,7L,9L,7L,9L,2L,7L,4L,6L,1L,1L,3L,9L,8L,9L,6L,3L,7L,3L,0L,5L,6L,9L,9L,4L,8L,1L,8L,6L,5L,2L,8L,4L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021390Inst : IEnumerable<long>
{
public static readonly long[] Value=A021390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021390.Bytes);
public long this[int i]=>Value[i];

public static A021390Inst Instance=new A021390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021391
{
public static readonly long[] Value={ 0L,0L,2L,5L,8L,3L,9L,7L,9L,3L,2L,8L,1L,6L,5L,3L,7L,4L,6L,7L,7L,0L,0L,2L,5L,8L,3L,9L,7L,9L,3L,2L,8L,1L,6L,5L,3L,7L,4L,6L,7L,7L,0L,0L,2L,5L,8L,3L,9L,7L,9L,3L,2L,8L,1L,6L,5L,3L,7L,4L,6L,7L,7L,0L,0L,2L,5L,8L,3L,9L,7L,9L,3L,2L,8L,1L,6L,5L,3L,7L,4L,6L,7L,7L,0L,0L,2L,5L,8L,3L,9L,7L,9L,3L,2L,8L,1L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021391Inst : IEnumerable<long>
{
public static readonly long[] Value=A021391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021391.Bytes);
public long this[int i]=>Value[i];

public static A021391Inst Instance=new A021391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021392
{
public static readonly long[] Value={ 0L,0L,2L,5L,7L,7L,3L,1L,9L,5L,8L,7L,6L,2L,8L,8L,6L,5L,9L,7L,9L,3L,8L,1L,4L,4L,3L,2L,9L,8L,9L,6L,9L,0L,7L,2L,1L,6L,4L,9L,4L,8L,4L,5L,3L,6L,0L,8L,2L,4L,7L,4L,2L,2L,6L,8L,0L,4L,1L,2L,3L,7L,1L,1L,3L,4L,0L,2L,0L,6L,1L,8L,5L,5L,6L,7L,0L,1L,0L,3L,0L,9L,2L,7L,8L,3L,5L,0L,5L,1L,5L,4L,6L,3L,9L,1L,7L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021392Inst : IEnumerable<long>
{
public static readonly long[] Value=A021392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021392.Bytes);
public long this[int i]=>Value[i];

public static A021392Inst Instance=new A021392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021393
{
public static readonly long[] Value={ 0L,0L,2L,5L,7L,0L,6L,9L,4L,0L,8L,7L,4L,0L,3L,5L,9L,8L,9L,7L,1L,7L,2L,2L,3L,6L,5L,0L,3L,8L,5L,6L,0L,4L,1L,1L,3L,1L,1L,0L,5L,3L,9L,8L,4L,5L,7L,5L,8L,3L,5L,4L,7L,5L,5L,7L,8L,4L,0L,6L,1L,6L,9L,6L,6L,5L,8L,0L,9L,7L,6L,8L,6L,3L,7L,5L,3L,2L,1L,3L,3L,6L,7L,6L,0L,9L,2L,5L,4L,4L,9L,8L,7L,1L,4L,6L,5L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021393Inst : IEnumerable<long>
{
public static readonly long[] Value=A021393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021393.Bytes);
public long this[int i]=>Value[i];

public static A021393Inst Instance=new A021393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021394
{
public static readonly long[] Value={ 1L,19L,254L,3014L,34155L,380073L,4199368L,46270588L,509296469L,5603570687L,61644604242L,678112219122L,7459321497343L,82052887210261L,902583169445276L,9928420525951016L,109212648498243177L,1201339224525513195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021394Inst : IEnumerable<long>
{
public static readonly long[] Value=A021394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021394.Bytes);
public long this[int i]=>Value[i];

public static A021394Inst Instance=new A021394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021395
{
public static readonly long[] Value={ 0L,0L,2L,5L,5L,7L,5L,4L,4L,7L,5L,7L,0L,3L,3L,2L,4L,8L,0L,8L,1L,8L,4L,1L,4L,3L,2L,2L,2L,5L,0L,6L,3L,9L,3L,8L,6L,1L,8L,9L,2L,5L,8L,3L,1L,2L,0L,2L,0L,4L,6L,0L,3L,5L,8L,0L,5L,6L,2L,6L,5L,9L,8L,4L,6L,5L,4L,7L,3L,1L,4L,5L,7L,8L,0L,0L,5L,1L,1L,5L,0L,8L,9L,5L,1L,4L,0L,6L,6L,4L,9L,6L,1L,6L,3L,6L,8L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021395Inst : IEnumerable<long>
{
public static readonly long[] Value=A021395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021395.Bytes);
public long this[int i]=>Value[i];

public static A021395Inst Instance=new A021395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021396
{
public static readonly long[] Value={ 0L,0L,2L,5L,5L,1L,0L,2L,0L,4L,0L,8L,1L,6L,3L,2L,6L,5L,3L,0L,6L,1L,2L,2L,4L,4L,8L,9L,7L,9L,5L,9L,1L,8L,3L,6L,7L,3L,4L,6L,9L,3L,8L,7L,7L,5L,5L,1L,0L,2L,0L,4L,0L,8L,1L,6L,3L,2L,6L,5L,3L,0L,6L,1L,2L,2L,4L,4L,8L,9L,7L,9L,5L,9L,1L,8L,3L,6L,7L,3L,4L,6L,9L,3L,8L,7L,7L,5L,5L,1L,0L,2L,0L,4L,0L,8L,1L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021396Inst : IEnumerable<long>
{
public static readonly long[] Value=A021396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021396.Bytes);
public long this[int i]=>Value[i];

public static A021396Inst Instance=new A021396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021397
{
public static readonly long[] Value={ 0L,0L,2L,5L,4L,4L,5L,2L,9L,2L,6L,2L,0L,8L,6L,5L,1L,3L,9L,9L,4L,9L,1L,0L,9L,4L,1L,4L,7L,5L,8L,2L,6L,9L,7L,2L,0L,1L,0L,1L,7L,8L,1L,1L,7L,0L,4L,8L,3L,4L,6L,0L,5L,5L,9L,7L,9L,6L,4L,3L,7L,6L,5L,9L,0L,3L,3L,0L,7L,8L,8L,8L,0L,4L,0L,7L,1L,2L,4L,6L,8L,1L,9L,3L,3L,8L,4L,2L,2L,3L,9L,1L,8L,5L,7L,5L,0L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021397Inst : IEnumerable<long>
{
public static readonly long[] Value=A021397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021397.Bytes);
public long this[int i]=>Value[i];

public static A021397Inst Instance=new A021397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021398
{
public static readonly long[] Value={ 0L,0L,2L,5L,3L,8L,0L,7L,1L,0L,6L,5L,9L,8L,9L,8L,4L,7L,7L,1L,5L,7L,3L,6L,0L,4L,0L,6L,0L,9L,1L,3L,7L,0L,5L,5L,8L,3L,7L,5L,6L,3L,4L,5L,1L,7L,7L,6L,6L,4L,9L,7L,4L,6L,1L,9L,2L,8L,9L,3L,4L,0L,1L,0L,1L,5L,2L,2L,8L,4L,2L,6L,3L,9L,5L,9L,3L,9L,0L,8L,6L,2L,9L,4L,4L,1L,6L,2L,4L,3L,6L,5L,4L,8L,2L,2L,3L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021398Inst : IEnumerable<long>
{
public static readonly long[] Value=A021398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021398.Bytes);
public long this[int i]=>Value[i];

public static A021398Inst Instance=new A021398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021399
{
public static readonly long[] Value={ 0L,0L,2L,5L,3L,1L,6L,4L,5L,5L,6L,9L,6L,2L,0L,2L,5L,3L,1L,6L,4L,5L,5L,6L,9L,6L,2L,0L,2L,5L,3L,1L,6L,4L,5L,5L,6L,9L,6L,2L,0L,2L,5L,3L,1L,6L,4L,5L,5L,6L,9L,6L,2L,0L,2L,5L,3L,1L,6L,4L,5L,5L,6L,9L,6L,2L,0L,2L,5L,3L,1L,6L,4L,5L,5L,6L,9L,6L,2L,0L,2L,5L,3L,1L,6L,4L,5L,5L,6L,9L,6L,2L,0L,2L,5L,3L,1L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021399Inst : IEnumerable<long>
{
public static readonly long[] Value=A021399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021399.Bytes);
public long this[int i]=>Value[i];

public static A021399Inst Instance=new A021399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021400
{
public static readonly long[] Value={ 0L,0L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021400Inst : IEnumerable<long>
{
public static readonly long[] Value=A021400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021400.Bytes);
public long this[int i]=>Value[i];

public static A021400Inst Instance=new A021400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021401
{
public static readonly long[] Value={ 0L,0L,2L,5L,1L,8L,8L,9L,1L,6L,8L,7L,6L,5L,7L,4L,3L,0L,7L,3L,0L,4L,7L,8L,5L,8L,9L,4L,2L,0L,6L,5L,4L,9L,1L,1L,8L,3L,8L,7L,9L,0L,9L,3L,1L,9L,8L,9L,9L,2L,4L,4L,3L,3L,2L,4L,9L,3L,7L,0L,2L,7L,7L,0L,7L,8L,0L,8L,5L,6L,4L,2L,3L,1L,7L,3L,8L,0L,3L,5L,2L,6L,4L,4L,8L,3L,6L,2L,7L,2L,0L,4L,0L,3L,0L,2L,2L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021401Inst : IEnumerable<long>
{
public static readonly long[] Value=A021401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021401.Bytes);
public long this[int i]=>Value[i];

public static A021401Inst Instance=new A021401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021402
{
public static readonly long[] Value={ 0L,0L,2L,5L,1L,2L,5L,6L,2L,8L,1L,4L,0L,7L,0L,3L,5L,1L,7L,5L,8L,7L,9L,3L,9L,6L,9L,8L,4L,9L,2L,4L,6L,2L,3L,1L,1L,5L,5L,7L,7L,8L,8L,9L,4L,4L,7L,2L,3L,6L,1L,8L,0L,9L,0L,4L,5L,2L,2L,6L,1L,3L,0L,6L,5L,3L,2L,6L,6L,3L,3L,1L,6L,5L,8L,2L,9L,1L,4L,5L,7L,2L,8L,6L,4L,3L,2L,1L,6L,0L,8L,0L,4L,0L,2L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021402Inst : IEnumerable<long>
{
public static readonly long[] Value=A021402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021402.Bytes);
public long this[int i]=>Value[i];

public static A021402Inst Instance=new A021402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021403
{
public static readonly long[] Value={ 0L,0L,2L,5L,0L,6L,2L,6L,5L,6L,6L,4L,1L,6L,0L,4L,0L,1L,0L,0L,2L,5L,0L,6L,2L,6L,5L,6L,6L,4L,1L,6L,0L,4L,0L,1L,0L,0L,2L,5L,0L,6L,2L,6L,5L,6L,6L,4L,1L,6L,0L,4L,0L,1L,0L,0L,2L,5L,0L,6L,2L,6L,5L,6L,6L,4L,1L,6L,0L,4L,0L,1L,0L,0L,2L,5L,0L,6L,2L,6L,5L,6L,6L,4L,1L,6L,0L,4L,0L,1L,0L,0L,2L,5L,0L,6L,2L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021403Inst : IEnumerable<long>
{
public static readonly long[] Value=A021403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021403.Bytes);
public long this[int i]=>Value[i];

public static A021403Inst Instance=new A021403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021404
{
public static readonly long[] Value={ 1L,20L,285L,3640L,44681L,540540L,6505045L,78138080L,937976961L,11257033060L,135089723405L,1621098253320L,19453266126841L,233439544261580L,2801275941271365L,33615316957309360L,403383826200494321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021404Inst : IEnumerable<long>
{
public static readonly long[] Value=A021404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021404.Bytes);
public long this[int i]=>Value[i];

public static A021404Inst Instance=new A021404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021437
{
public static readonly long[] Value={ 0L,0L,2L,3L,0L,9L,4L,6L,8L,8L,2L,2L,1L,7L,0L,9L,0L,0L,6L,9L,2L,8L,4L,0L,6L,4L,6L,6L,5L,1L,2L,7L,0L,2L,0L,7L,8L,5L,2L,1L,9L,3L,9L,9L,5L,3L,8L,1L,0L,6L,2L,3L,5L,5L,6L,5L,8L,1L,9L,8L,6L,1L,4L,3L,1L,8L,7L,0L,6L,6L,9L,7L,4L,5L,9L,5L,8L,4L,2L,9L,5L,6L,1L,2L,0L,0L,9L,2L,3L,7L,8L,7L,5L,2L,8L,8L,6L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021437Inst : IEnumerable<long>
{
public static readonly long[] Value=A021437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021437.Bytes);
public long this[int i]=>Value[i];

public static A021437Inst Instance=new A021437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021438
{
public static readonly long[] Value={ 0L,0L,2L,3L,0L,4L,1L,4L,7L,4L,6L,5L,4L,3L,7L,7L,8L,8L,0L,1L,8L,4L,3L,3L,1L,7L,9L,7L,2L,3L,5L,0L,2L,3L,0L,4L,1L,4L,7L,4L,6L,5L,4L,3L,7L,7L,8L,8L,0L,1L,8L,4L,3L,3L,1L,7L,9L,7L,2L,3L,5L,0L,2L,3L,0L,4L,1L,4L,7L,4L,6L,5L,4L,3L,7L,7L,8L,8L,0L,1L,8L,4L,3L,3L,1L,7L,9L,7L,2L,3L,5L,0L,2L,3L,0L,4L,1L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021438Inst : IEnumerable<long>
{
public static readonly long[] Value=A021438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021438.Bytes);
public long this[int i]=>Value[i];

public static A021438Inst Instance=new A021438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021439
{
public static readonly long[] Value={ 0L,0L,2L,2L,9L,8L,8L,5L,0L,5L,7L,4L,7L,1L,2L,6L,4L,3L,6L,7L,8L,1L,6L,0L,9L,1L,9L,5L,4L,0L,2L,2L,9L,8L,8L,5L,0L,5L,7L,4L,7L,1L,2L,6L,4L,3L,6L,7L,8L,1L,6L,0L,9L,1L,9L,5L,4L,0L,2L,2L,9L,8L,8L,5L,0L,5L,7L,4L,7L,1L,2L,6L,4L,3L,6L,7L,8L,1L,6L,0L,9L,1L,9L,5L,4L,0L,2L,2L,9L,8L,8L,5L,0L,5L,7L,4L,7L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021439Inst : IEnumerable<long>
{
public static readonly long[] Value=A021439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021439.Bytes);
public long this[int i]=>Value[i];

public static A021439Inst Instance=new A021439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021440
{
public static readonly long[] Value={ 0L,0L,2L,2L,9L,3L,5L,7L,7L,9L,8L,1L,6L,5L,1L,3L,7L,6L,1L,4L,6L,7L,8L,8L,9L,9L,0L,8L,2L,5L,6L,8L,8L,0L,7L,3L,3L,9L,4L,4L,9L,5L,4L,1L,2L,8L,4L,4L,0L,3L,6L,6L,9L,7L,2L,4L,7L,7L,0L,6L,4L,2L,2L,0L,1L,8L,3L,4L,8L,6L,2L,3L,8L,5L,3L,2L,1L,1L,0L,0L,9L,1L,7L,4L,3L,1L,1L,9L,2L,6L,6L,0L,5L,5L,0L,4L,5L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021440Inst : IEnumerable<long>
{
public static readonly long[] Value=A021440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021440.Bytes);
public long this[int i]=>Value[i];

public static A021440Inst Instance=new A021440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021441
{
public static readonly long[] Value={ 0L,0L,2L,2L,8L,8L,3L,2L,9L,5L,1L,9L,4L,5L,0L,8L,0L,0L,9L,1L,5L,3L,3L,1L,8L,0L,7L,7L,8L,0L,3L,2L,0L,3L,6L,6L,1L,3L,2L,7L,2L,3L,1L,1L,2L,1L,2L,8L,1L,4L,6L,4L,5L,3L,0L,8L,9L,2L,4L,4L,8L,5L,1L,2L,5L,8L,5L,8L,1L,2L,3L,5L,6L,9L,7L,9L,4L,0L,5L,0L,3L,4L,3L,2L,4L,9L,4L,2L,7L,9L,1L,7L,6L,2L,0L,1L,3L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021441Inst : IEnumerable<long>
{
public static readonly long[] Value=A021441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021441.Bytes);
public long this[int i]=>Value[i];

public static A021441Inst Instance=new A021441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021442
{
public static readonly long[] Value={ 0L,0L,2L,2L,8L,3L,1L,0L,5L,0L,2L,2L,8L,3L,1L,0L,5L,0L,2L,2L,8L,3L,1L,0L,5L,0L,2L,2L,8L,3L,1L,0L,5L,0L,2L,2L,8L,3L,1L,0L,5L,0L,2L,2L,8L,3L,1L,0L,5L,0L,2L,2L,8L,3L,1L,0L,5L,0L,2L,2L,8L,3L,1L,0L,5L,0L,2L,2L,8L,3L,1L,0L,5L,0L,2L,2L,8L,3L,1L,0L,5L,0L,2L,2L,8L,3L,1L,0L,5L,0L,2L,2L,8L,3L,1L,0L,5L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021442Inst : IEnumerable<long>
{
public static readonly long[] Value=A021442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021442.Bytes);
public long this[int i]=>Value[i];

public static A021442Inst Instance=new A021442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021443
{
public static readonly long[] Value={ 0L,0L,2L,2L,7L,7L,9L,0L,4L,3L,2L,8L,0L,1L,8L,2L,2L,3L,2L,3L,4L,6L,2L,4L,1L,4L,5L,7L,8L,5L,8L,7L,6L,9L,9L,3L,1L,6L,6L,2L,8L,7L,0L,1L,5L,9L,4L,5L,3L,3L,0L,2L,9L,6L,1L,2L,7L,5L,6L,2L,6L,4L,2L,3L,6L,9L,0L,2L,0L,5L,0L,1L,1L,3L,8L,9L,5L,2L,1L,6L,4L,0L,0L,9L,1L,1L,1L,6L,1L,7L,3L,1L,2L,0L,7L,2L,8L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021443Inst : IEnumerable<long>
{
public static readonly long[] Value=A021443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021443.Bytes);
public long this[int i]=>Value[i];

public static A021443Inst Instance=new A021443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021444
{
public static readonly long[] Value={ 0L,0L,2L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021444Inst : IEnumerable<long>
{
public static readonly long[] Value=A021444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021444.Bytes);
public long this[int i]=>Value[i];

public static A021444Inst Instance=new A021444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021445
{
public static readonly long[] Value={ 0L,0L,2L,2L,6L,7L,5L,7L,3L,6L,9L,6L,1L,4L,5L,1L,2L,4L,7L,1L,6L,5L,5L,3L,2L,8L,7L,9L,8L,1L,8L,5L,9L,4L,1L,0L,4L,3L,0L,8L,3L,9L,0L,0L,2L,2L,6L,7L,5L,7L,3L,6L,9L,6L,1L,4L,5L,1L,2L,4L,7L,1L,6L,5L,5L,3L,2L,8L,7L,9L,8L,1L,8L,5L,9L,4L,1L,0L,4L,3L,0L,8L,3L,9L,0L,0L,2L,2L,6L,7L,5L,7L,3L,6L,9L,6L,1L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021445Inst : IEnumerable<long>
{
public static readonly long[] Value=A021445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021445.Bytes);
public long this[int i]=>Value[i];

public static A021445Inst Instance=new A021445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021446
{
public static readonly long[] Value={ 0L,0L,2L,2L,6L,2L,4L,4L,3L,4L,3L,8L,9L,1L,4L,0L,2L,7L,1L,4L,9L,3L,2L,1L,2L,6L,6L,9L,6L,8L,3L,2L,5L,7L,9L,1L,8L,5L,5L,2L,0L,3L,6L,1L,9L,9L,0L,9L,5L,0L,2L,2L,6L,2L,4L,4L,3L,4L,3L,8L,9L,1L,4L,0L,2L,7L,1L,4L,9L,3L,2L,1L,2L,6L,6L,9L,6L,8L,3L,2L,5L,7L,9L,1L,8L,5L,5L,2L,0L,3L,6L,1L,9L,9L,0L,9L,5L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021446Inst : IEnumerable<long>
{
public static readonly long[] Value=A021446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021446.Bytes);
public long this[int i]=>Value[i];

public static A021446Inst Instance=new A021446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021447
{
public static readonly long[] Value={ 0L,0L,2L,2L,5L,7L,3L,3L,6L,3L,4L,3L,1L,1L,5L,1L,2L,4L,1L,5L,3L,4L,9L,8L,8L,7L,1L,3L,3L,1L,8L,2L,8L,4L,4L,2L,4L,3L,7L,9L,2L,3L,2L,5L,0L,5L,6L,4L,3L,3L,4L,0L,8L,5L,7L,7L,8L,7L,8L,1L,0L,3L,8L,3L,7L,4L,7L,1L,7L,8L,3L,2L,9L,5L,7L,1L,1L,0L,6L,0L,9L,4L,8L,0L,8L,1L,2L,6L,4L,1L,0L,8L,3L,5L,2L,1L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021447Inst : IEnumerable<long>
{
public static readonly long[] Value=A021447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021447.Bytes);
public long this[int i]=>Value[i];

public static A021447Inst Instance=new A021447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021448
{
public static readonly long[] Value={ 0L,0L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021448Inst : IEnumerable<long>
{
public static readonly long[] Value=A021448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021448.Bytes);
public long this[int i]=>Value[i];

public static A021448Inst Instance=new A021448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021449
{
public static readonly long[] Value={ 0L,0L,2L,2L,4L,7L,1L,9L,1L,0L,1L,1L,2L,3L,5L,9L,5L,5L,0L,5L,6L,1L,7L,9L,7L,7L,5L,2L,8L,0L,8L,9L,8L,8L,7L,6L,4L,0L,4L,4L,9L,4L,3L,8L,2L,0L,2L,2L,4L,7L,1L,9L,1L,0L,1L,1L,2L,3L,5L,9L,5L,5L,0L,5L,6L,1L,7L,9L,7L,7L,5L,2L,8L,0L,8L,9L,8L,8L,7L,6L,4L,0L,4L,4L,9L,4L,3L,8L,2L,0L,2L,2L,4L,7L,1L,9L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021449Inst : IEnumerable<long>
{
public static readonly long[] Value=A021449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021449.Bytes);
public long this[int i]=>Value[i];

public static A021449Inst Instance=new A021449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021450
{
public static readonly long[] Value={ 0L,0L,2L,2L,4L,2L,1L,5L,2L,4L,6L,6L,3L,6L,7L,7L,1L,3L,0L,0L,4L,4L,8L,4L,3L,0L,4L,9L,3L,2L,7L,3L,5L,4L,2L,6L,0L,0L,8L,9L,6L,8L,6L,0L,9L,8L,6L,5L,4L,7L,0L,8L,5L,2L,0L,1L,7L,9L,3L,7L,2L,1L,9L,7L,3L,0L,9L,4L,1L,7L,0L,4L,0L,3L,5L,8L,7L,4L,4L,3L,9L,4L,6L,1L,8L,8L,3L,4L,0L,8L,0L,7L,1L,7L,4L,8L,8L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021450Inst : IEnumerable<long>
{
public static readonly long[] Value=A021450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021450.Bytes);
public long this[int i]=>Value[i];

public static A021450Inst Instance=new A021450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021451
{
public static readonly long[] Value={ 0L,0L,2L,2L,3L,7L,1L,3L,6L,4L,6L,5L,3L,2L,4L,3L,8L,4L,7L,8L,7L,4L,7L,2L,0L,3L,5L,7L,9L,4L,1L,8L,3L,4L,4L,5L,1L,9L,0L,1L,5L,6L,5L,9L,9L,5L,5L,2L,5L,7L,2L,7L,0L,6L,9L,3L,5L,1L,2L,3L,0L,4L,2L,5L,0L,5L,5L,9L,2L,8L,4L,1L,1L,6L,3L,3L,1L,0L,9L,6L,1L,9L,6L,8L,6L,8L,0L,0L,8L,9L,4L,8L,5L,4L,5L,8L,6L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021451Inst : IEnumerable<long>
{
public static readonly long[] Value=A021451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021451.Bytes);
public long this[int i]=>Value[i];

public static A021451Inst Instance=new A021451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021452
{
public static readonly long[] Value={ 0L,0L,2L,2L,3L,2L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021452Inst : IEnumerable<long>
{
public static readonly long[] Value=A021452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021452.Bytes);
public long this[int i]=>Value[i];

public static A021452Inst Instance=new A021452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021453
{
public static readonly long[] Value={ 0L,0L,2L,2L,2L,7L,1L,7L,1L,4L,9L,2L,2L,0L,4L,8L,9L,9L,7L,7L,7L,2L,8L,2L,8L,5L,0L,7L,7L,9L,5L,1L,0L,0L,2L,2L,2L,7L,1L,7L,1L,4L,9L,2L,2L,0L,4L,8L,9L,9L,7L,7L,7L,2L,8L,2L,8L,5L,0L,7L,7L,9L,5L,1L,0L,0L,2L,2L,2L,7L,1L,7L,1L,4L,9L,2L,2L,0L,4L,8L,9L,9L,7L,7L,7L,2L,8L,2L,8L,5L,0L,7L,7L,9L,5L,1L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021453Inst : IEnumerable<long>
{
public static readonly long[] Value=A021453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021453.Bytes);
public long this[int i]=>Value[i];

public static A021453Inst Instance=new A021453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021454
{
public static readonly long[] Value={ 1L,18L,220L,2310L,22561L,212268L,1957600L,17857620L,161924521L,1463379918L,13200803980L,118959425130L,1071396569881L,9646380238968L,86836484875360L,781623699024840L,7035090031526641L,63318194178965418L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021454Inst : IEnumerable<long>
{
public static readonly long[] Value=A021454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021454.Bytes);
public long this[int i]=>Value[i];

public static A021454Inst Instance=new A021454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021455
{
public static readonly long[] Value={ 0L,0L,2L,2L,1L,7L,2L,9L,4L,9L,0L,0L,2L,2L,1L,7L,2L,9L,4L,9L,0L,0L,2L,2L,1L,7L,2L,9L,4L,9L,0L,0L,2L,2L,1L,7L,2L,9L,4L,9L,0L,0L,2L,2L,1L,7L,2L,9L,4L,9L,0L,0L,2L,2L,1L,7L,2L,9L,4L,9L,0L,0L,2L,2L,1L,7L,2L,9L,4L,9L,0L,0L,2L,2L,1L,7L,2L,9L,4L,9L,0L,0L,2L,2L,1L,7L,2L,9L,4L,9L,0L,0L,2L,2L,1L,7L,2L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021455Inst : IEnumerable<long>
{
public static readonly long[] Value=A021455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021455.Bytes);
public long this[int i]=>Value[i];

public static A021455Inst Instance=new A021455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021456
{
public static readonly long[] Value={ 0L,0L,2L,2L,1L,2L,3L,8L,9L,3L,8L,0L,5L,3L,0L,9L,7L,3L,4L,5L,1L,3L,2L,7L,4L,3L,3L,6L,2L,8L,3L,1L,8L,5L,8L,4L,0L,7L,0L,7L,9L,6L,4L,6L,0L,1L,7L,6L,9L,9L,1L,1L,5L,0L,4L,4L,2L,4L,7L,7L,8L,7L,6L,1L,0L,6L,1L,9L,4L,6L,9L,0L,2L,6L,5L,4L,8L,6L,7L,2L,5L,6L,6L,3L,7L,1L,6L,8L,1L,4L,1L,5L,9L,2L,9L,2L,0L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021456Inst : IEnumerable<long>
{
public static readonly long[] Value=A021456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021456.Bytes);
public long this[int i]=>Value[i];

public static A021456Inst Instance=new A021456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021457
{
public static readonly long[] Value={ 0L,0L,2L,2L,0L,7L,5L,0L,5L,5L,1L,8L,7L,6L,3L,7L,9L,6L,9L,0L,9L,4L,9L,2L,2L,7L,3L,7L,3L,0L,6L,8L,4L,3L,2L,6L,7L,1L,0L,8L,1L,6L,7L,7L,7L,0L,4L,1L,9L,4L,2L,6L,0L,4L,8L,5L,6L,5L,1L,2L,1L,4L,1L,2L,8L,0L,3L,5L,3L,2L,0L,0L,8L,8L,3L,0L,0L,2L,2L,0L,7L,5L,0L,5L,5L,1L,8L,7L,6L,3L,7L,9L,6L,9L,0L,9L,4L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021457Inst : IEnumerable<long>
{
public static readonly long[] Value=A021457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021457.Bytes);
public long this[int i]=>Value[i];

public static A021457Inst Instance=new A021457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021458
{
public static readonly long[] Value={ 0L,0L,2L,2L,0L,2L,6L,4L,3L,1L,7L,1L,8L,0L,6L,1L,6L,7L,4L,0L,0L,8L,8L,1L,0L,5L,7L,2L,6L,8L,7L,2L,2L,4L,6L,6L,9L,6L,0L,3L,5L,2L,4L,2L,2L,9L,0L,7L,4L,8L,8L,9L,8L,6L,7L,8L,4L,1L,4L,0L,9L,6L,9L,1L,6L,2L,9L,9L,5L,5L,9L,4L,7L,1L,3L,6L,5L,6L,3L,8L,7L,6L,6L,5L,1L,9L,8L,2L,3L,7L,8L,8L,5L,4L,6L,2L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021458Inst : IEnumerable<long>
{
public static readonly long[] Value=A021458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021458.Bytes);
public long this[int i]=>Value[i];

public static A021458Inst Instance=new A021458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021459
{
public static readonly long[] Value={ 0L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021459Inst : IEnumerable<long>
{
public static readonly long[] Value=A021459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021459.Bytes);
public long this[int i]=>Value[i];

public static A021459Inst Instance=new A021459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021460
{
public static readonly long[] Value={ 0L,0L,2L,1L,9L,2L,9L,8L,2L,4L,5L,6L,1L,4L,0L,3L,5L,0L,8L,7L,7L,1L,9L,2L,9L,8L,2L,4L,5L,6L,1L,4L,0L,3L,5L,0L,8L,7L,7L,1L,9L,2L,9L,8L,2L,4L,5L,6L,1L,4L,0L,3L,5L,0L,8L,7L,7L,1L,9L,2L,9L,8L,2L,4L,5L,6L,1L,4L,0L,3L,5L,0L,8L,7L,7L,1L,9L,2L,9L,8L,2L,4L,5L,6L,1L,4L,0L,3L,5L,0L,8L,7L,7L,1L,9L,2L,9L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021460Inst : IEnumerable<long>
{
public static readonly long[] Value=A021460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021460.Bytes);
public long this[int i]=>Value[i];

public static A021460Inst Instance=new A021460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021461
{
public static readonly long[] Value={ 0L,0L,2L,1L,8L,8L,1L,8L,3L,8L,0L,7L,4L,3L,9L,8L,2L,4L,9L,4L,5L,2L,9L,5L,4L,0L,4L,8L,1L,4L,0L,0L,4L,3L,7L,6L,3L,6L,7L,6L,1L,4L,8L,7L,9L,6L,4L,9L,8L,9L,0L,5L,9L,0L,8L,0L,9L,6L,2L,8L,0L,0L,8L,7L,5L,2L,7L,3L,5L,2L,2L,9L,7L,5L,9L,2L,9L,9L,7L,8L,1L,1L,8L,1L,6L,1L,9L,2L,5L,6L,0L,1L,7L,5L,0L,5L,4L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021461Inst : IEnumerable<long>
{
public static readonly long[] Value=A021461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021461.Bytes);
public long this[int i]=>Value[i];

public static A021461Inst Instance=new A021461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021462
{
public static readonly long[] Value={ 0L,0L,2L,1L,8L,3L,4L,0L,6L,1L,1L,3L,5L,3L,7L,1L,1L,7L,9L,0L,3L,9L,3L,0L,1L,3L,1L,0L,0L,4L,3L,6L,6L,8L,1L,2L,2L,2L,7L,0L,7L,4L,2L,3L,5L,8L,0L,7L,8L,6L,0L,2L,6L,2L,0L,0L,8L,7L,3L,3L,6L,2L,4L,4L,5L,4L,1L,4L,8L,4L,7L,1L,6L,1L,5L,7L,2L,0L,5L,2L,4L,0L,1L,7L,4L,6L,7L,2L,4L,8L,9L,0L,8L,2L,9L,6L,9L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021462Inst : IEnumerable<long>
{
public static readonly long[] Value=A021462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021462.Bytes);
public long this[int i]=>Value[i];

public static A021462Inst Instance=new A021462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021463
{
public static readonly long[] Value={ 0L,0L,2L,1L,7L,8L,6L,4L,9L,2L,3L,7L,4L,7L,2L,7L,6L,6L,8L,8L,4L,5L,3L,1L,5L,9L,0L,4L,1L,3L,9L,4L,3L,3L,5L,5L,1L,1L,9L,8L,2L,5L,7L,0L,8L,0L,6L,1L,0L,0L,2L,1L,7L,8L,6L,4L,9L,2L,3L,7L,4L,7L,2L,7L,6L,6L,8L,8L,4L,5L,3L,1L,5L,9L,0L,4L,1L,3L,9L,4L,3L,3L,5L,5L,1L,1L,9L,8L,2L,5L,7L,0L,8L,0L,6L,1L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021463Inst : IEnumerable<long>
{
public static readonly long[] Value=A021463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021463.Bytes);
public long this[int i]=>Value[i];

public static A021463Inst Instance=new A021463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021464
{
public static readonly long[] Value={ 1L,19L,248L,2810L,29871L,307929L,3126478L,31504000L,316245941L,3168518639L,31715571108L,317307900390L,3173840747611L,31742218586149L,317441248586138L,3174507821007980L,31745554950382881L,317457933399054459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021464Inst : IEnumerable<long>
{
public static readonly long[] Value=A021464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021464.Bytes);
public long this[int i]=>Value[i];

public static A021464Inst Instance=new A021464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021465
{
public static readonly long[] Value={ 0L,0L,2L,1L,6L,9L,1L,9L,7L,3L,9L,6L,9L,6L,3L,1L,2L,3L,6L,4L,4L,2L,5L,1L,6L,2L,6L,8L,9L,8L,0L,4L,7L,7L,2L,2L,3L,4L,2L,7L,3L,3L,1L,8L,8L,7L,2L,0L,1L,7L,3L,5L,3L,5L,7L,9L,1L,7L,5L,7L,0L,4L,9L,8L,9L,1L,5L,4L,0L,1L,3L,0L,1L,5L,1L,8L,4L,3L,8L,1L,7L,7L,8L,7L,4L,1L,8L,6L,5L,5L,0L,9L,7L,6L,1L,3L,8L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021465Inst : IEnumerable<long>
{
public static readonly long[] Value=A021465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021465.Bytes);
public long this[int i]=>Value[i];

public static A021465Inst Instance=new A021465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021466
{
public static readonly long[] Value={ 0L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021466Inst : IEnumerable<long>
{
public static readonly long[] Value=A021466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021466.Bytes);
public long this[int i]=>Value[i];

public static A021466Inst Instance=new A021466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021467
{
public static readonly long[] Value={ 0L,0L,2L,1L,5L,9L,8L,2L,7L,2L,1L,3L,8L,2L,2L,8L,9L,4L,1L,6L,8L,4L,6L,6L,5L,2L,2L,6L,7L,8L,1L,8L,5L,7L,4L,5L,1L,4L,0L,3L,8L,8L,7L,6L,8L,8L,9L,8L,4L,8L,8L,1L,2L,0L,9L,5L,0L,3L,2L,3L,9L,7L,4L,0L,8L,2L,0L,7L,3L,4L,3L,4L,1L,2L,5L,2L,6L,9L,9L,7L,8L,4L,0L,1L,7L,2L,7L,8L,6L,1L,7L,7L,1L,0L,5L,8L,3L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021467Inst : IEnumerable<long>
{
public static readonly long[] Value=A021467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021467.Bytes);
public long this[int i]=>Value[i];

public static A021467Inst Instance=new A021467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021468
{
public static readonly long[] Value={ 0L,0L,2L,1L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021468Inst : IEnumerable<long>
{
public static readonly long[] Value=A021468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021468.Bytes);
public long this[int i]=>Value[i];

public static A021468Inst Instance=new A021468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021469
{
public static readonly long[] Value={ 0L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021469Inst : IEnumerable<long>
{
public static readonly long[] Value=A021469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021469.Bytes);
public long this[int i]=>Value[i];

public static A021469Inst Instance=new A021469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021470
{
public static readonly long[] Value={ 0L,0L,2L,1L,4L,5L,9L,2L,2L,7L,4L,6L,7L,8L,1L,1L,1L,5L,8L,7L,9L,8L,2L,8L,3L,2L,6L,1L,8L,0L,2L,5L,7L,5L,1L,0L,7L,2L,9L,6L,1L,3L,7L,3L,3L,9L,0L,5L,5L,7L,9L,3L,9L,9L,1L,4L,1L,6L,3L,0L,9L,0L,1L,2L,8L,7L,5L,5L,3L,6L,4L,8L,0L,6L,8L,6L,6L,9L,5L,2L,7L,8L,9L,6L,9L,9L,5L,7L,0L,8L,1L,5L,4L,5L,0L,6L,4L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021470Inst : IEnumerable<long>
{
public static readonly long[] Value=A021470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021470.Bytes);
public long this[int i]=>Value[i];

public static A021470Inst Instance=new A021470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021471
{
public static readonly long[] Value={ 0L,0L,2L,1L,4L,1L,3L,2L,7L,6L,2L,3L,1L,2L,6L,3L,3L,8L,3L,2L,9L,7L,6L,4L,4L,5L,3L,9L,6L,1L,4L,5L,6L,1L,0L,2L,7L,8L,3L,7L,2L,5L,9L,1L,0L,0L,6L,4L,2L,3L,9L,8L,2L,8L,6L,9L,3L,7L,9L,0L,1L,4L,9L,8L,9L,2L,9L,3L,3L,6L,1L,8L,8L,4L,3L,6L,8L,3L,0L,8L,3L,5L,1L,1L,7L,7L,7L,3L,0L,1L,9L,2L,7L,1L,9L,4L,8L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021471Inst : IEnumerable<long>
{
public static readonly long[] Value=A021471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021471.Bytes);
public long this[int i]=>Value[i];

public static A021471Inst Instance=new A021471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021472
{
public static readonly long[] Value={ 0L,0L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021472Inst : IEnumerable<long>
{
public static readonly long[] Value=A021472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021472.Bytes);
public long this[int i]=>Value[i];

public static A021472Inst Instance=new A021472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021473
{
public static readonly long[] Value={ 0L,0L,2L,1L,3L,2L,1L,9L,6L,1L,6L,2L,0L,4L,6L,9L,0L,8L,3L,1L,5L,5L,6L,5L,0L,3L,1L,9L,8L,2L,9L,4L,2L,4L,3L,0L,7L,0L,3L,6L,2L,4L,7L,3L,3L,4L,7L,5L,4L,7L,9L,7L,4L,4L,1L,3L,6L,4L,6L,0L,5L,5L,4L,3L,7L,1L,0L,0L,2L,1L,3L,2L,1L,9L,6L,1L,6L,2L,0L,4L,6L,9L,0L,8L,3L,1L,5L,5L,6L,5L,0L,3L,1L,9L,8L,2L,9L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021473Inst : IEnumerable<long>
{
public static readonly long[] Value=A021473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021473.Bytes);
public long this[int i]=>Value[i];

public static A021473Inst Instance=new A021473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021474
{
public static readonly long[] Value={ 1L,20L,278L,3388L,39039L,438648L,4872316L,53834696L,593387597L,6533322796L,71896935474L,791018479524L,8701965018475L,95725426313264L,1052998752170552L,11583081609022672L,127414374439552473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021474Inst : IEnumerable<long>
{
public static readonly long[] Value=A021474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021474.Bytes);
public long this[int i]=>Value[i];

public static A021474Inst Instance=new A021474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021475
{
public static readonly long[] Value={ 0L,0L,2L,1L,2L,3L,1L,4L,2L,2L,5L,0L,5L,3L,0L,7L,8L,5L,5L,6L,2L,6L,3L,2L,6L,9L,6L,3L,9L,0L,6L,5L,8L,1L,7L,4L,0L,9L,7L,6L,6L,4L,5L,4L,3L,5L,2L,4L,4L,1L,6L,1L,3L,5L,8L,8L,1L,1L,0L,4L,0L,3L,3L,9L,7L,0L,2L,7L,6L,0L,0L,8L,4L,9L,2L,5L,6L,9L,0L,0L,2L,1L,2L,3L,1L,4L,2L,2L,5L,0L,5L,3L,0L,7L,8L,5L,5L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021475Inst : IEnumerable<long>
{
public static readonly long[] Value=A021475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021475.Bytes);
public long this[int i]=>Value[i];

public static A021475Inst Instance=new A021475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021476
{
public static readonly long[] Value={ 0L,0L,2L,1L,1L,8L,6L,4L,4L,0L,6L,7L,7L,9L,6L,6L,1L,0L,1L,6L,9L,4L,9L,1L,5L,2L,5L,4L,2L,3L,7L,2L,8L,8L,1L,3L,5L,5L,9L,3L,2L,2L,0L,3L,3L,8L,9L,8L,3L,0L,5L,0L,8L,4L,7L,4L,5L,7L,6L,2L,7L,1L,1L,8L,6L,4L,4L,0L,6L,7L,7L,9L,6L,6L,1L,0L,1L,6L,9L,4L,9L,1L,5L,2L,5L,4L,2L,3L,7L,2L,8L,8L,1L,3L,5L,5L,9L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021476Inst : IEnumerable<long>
{
public static readonly long[] Value=A021476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021476.Bytes);
public long this[int i]=>Value[i];

public static A021476Inst Instance=new A021476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021477
{
public static readonly long[] Value={ 0L,0L,2L,1L,1L,4L,1L,6L,4L,9L,0L,4L,8L,6L,2L,5L,7L,9L,2L,8L,1L,1L,8L,3L,9L,3L,2L,3L,4L,6L,7L,2L,3L,0L,4L,4L,3L,9L,7L,4L,6L,3L,0L,0L,2L,1L,1L,4L,1L,6L,4L,9L,0L,4L,8L,6L,2L,5L,7L,9L,2L,8L,1L,1L,8L,3L,9L,3L,2L,3L,4L,6L,7L,2L,3L,0L,4L,4L,3L,9L,7L,4L,6L,3L,0L,0L,2L,1L,1L,4L,1L,6L,4L,9L,0L,4L,8L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021477Inst : IEnumerable<long>
{
public static readonly long[] Value=A021477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021477.Bytes);
public long this[int i]=>Value[i];

public static A021477Inst Instance=new A021477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021478
{
public static readonly long[] Value={ 0L,0L,2L,1L,0L,9L,7L,0L,4L,6L,4L,1L,3L,5L,0L,2L,1L,0L,9L,7L,0L,4L,6L,4L,1L,3L,5L,0L,2L,1L,0L,9L,7L,0L,4L,6L,4L,1L,3L,5L,0L,2L,1L,0L,9L,7L,0L,4L,6L,4L,1L,3L,5L,0L,2L,1L,0L,9L,7L,0L,4L,6L,4L,1L,3L,5L,0L,2L,1L,0L,9L,7L,0L,4L,6L,4L,1L,3L,5L,0L,2L,1L,0L,9L,7L,0L,4L,6L,4L,1L,3L,5L,0L,2L,1L,0L,9L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021478Inst : IEnumerable<long>
{
public static readonly long[] Value=A021478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021478.Bytes);
public long this[int i]=>Value[i];

public static A021478Inst Instance=new A021478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021479
{
public static readonly long[] Value={ 0L,0L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021479Inst : IEnumerable<long>
{
public static readonly long[] Value=A021479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021479.Bytes);
public long this[int i]=>Value[i];

public static A021479Inst Instance=new A021479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021480
{
public static readonly long[] Value={ 0L,0L,2L,1L,0L,0L,8L,4L,0L,3L,3L,6L,1L,3L,4L,4L,5L,3L,7L,8L,1L,5L,1L,2L,6L,0L,5L,0L,4L,2L,0L,1L,6L,8L,0L,6L,7L,2L,2L,6L,8L,9L,0L,7L,5L,6L,3L,0L,2L,5L,2L,1L,0L,0L,8L,4L,0L,3L,3L,6L,1L,3L,4L,4L,5L,3L,7L,8L,1L,5L,1L,2L,6L,0L,5L,0L,4L,2L,0L,1L,6L,8L,0L,6L,7L,2L,2L,6L,8L,9L,0L,7L,5L,6L,3L,0L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021480Inst : IEnumerable<long>
{
public static readonly long[] Value=A021480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021480.Bytes);
public long this[int i]=>Value[i];

public static A021480Inst Instance=new A021480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021481
{
public static readonly long[] Value={ 0L,0L,2L,0L,9L,6L,4L,3L,6L,0L,5L,8L,7L,0L,0L,2L,0L,9L,6L,4L,3L,6L,0L,5L,8L,7L,0L,0L,2L,0L,9L,6L,4L,3L,6L,0L,5L,8L,7L,0L,0L,2L,0L,9L,6L,4L,3L,6L,0L,5L,8L,7L,0L,0L,2L,0L,9L,6L,4L,3L,6L,0L,5L,8L,7L,0L,0L,2L,0L,9L,6L,4L,3L,6L,0L,5L,8L,7L,0L,0L,2L,0L,9L,6L,4L,3L,6L,0L,5L,8L,7L,0L,0L,2L,0L,9L,6L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021481Inst : IEnumerable<long>
{
public static readonly long[] Value=A021481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021481.Bytes);
public long this[int i]=>Value[i];

public static A021481Inst Instance=new A021481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021482
{
public static readonly long[] Value={ 0L,0L,2L,0L,9L,2L,0L,5L,0L,2L,0L,9L,2L,0L,5L,0L,2L,0L,9L,2L,0L,5L,0L,2L,0L,9L,2L,0L,5L,0L,2L,0L,9L,2L,0L,5L,0L,2L,0L,9L,2L,0L,5L,0L,2L,0L,9L,2L,0L,5L,0L,2L,0L,9L,2L,0L,5L,0L,2L,0L,9L,2L,0L,5L,0L,2L,0L,9L,2L,0L,5L,0L,2L,0L,9L,2L,0L,5L,0L,2L,0L,9L,2L,0L,5L,0L,2L,0L,9L,2L,0L,5L,0L,2L,0L,9L,2L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021482Inst : IEnumerable<long>
{
public static readonly long[] Value=A021482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021482.Bytes);
public long this[int i]=>Value[i];

public static A021482Inst Instance=new A021482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021483
{
public static readonly long[] Value={ 0L,0L,2L,0L,8L,7L,6L,8L,2L,6L,7L,2L,2L,3L,3L,8L,2L,0L,4L,5L,9L,2L,9L,0L,1L,8L,7L,8L,9L,1L,4L,4L,0L,5L,0L,1L,0L,4L,3L,8L,4L,1L,3L,3L,6L,1L,1L,6L,9L,1L,0L,2L,2L,9L,6L,4L,5L,0L,9L,3L,9L,4L,5L,7L,2L,0L,2L,5L,0L,5L,2L,1L,9L,2L,0L,6L,6L,8L,0L,5L,8L,4L,5L,5L,1L,1L,4L,8L,2L,2L,5L,4L,6L,9L,7L,2L,8L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021483Inst : IEnumerable<long>
{
public static readonly long[] Value=A021483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021483.Bytes);
public long this[int i]=>Value[i];

public static A021483Inst Instance=new A021483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021484
{
public static readonly long[] Value={ 1L,21L,310L,4050L,50371L,613671L,7411240L,89174100L,1071295141L,12861600921L,154369595770L,1852587338550L,22231809806311L,266785528785771L,3201445408153900L,38417440232993400L,461009759536223881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021484Inst : IEnumerable<long>
{
public static readonly long[] Value=A021484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021484.Bytes);
public long this[int i]=>Value[i];

public static A021484Inst Instance=new A021484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021485
{
public static readonly long[] Value={ 0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021485Inst : IEnumerable<long>
{
public static readonly long[] Value=A021485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021485.Bytes);
public long this[int i]=>Value[i];

public static A021485Inst Instance=new A021485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021486
{
public static readonly long[] Value={ 0L,0L,2L,0L,7L,4L,6L,8L,8L,7L,9L,6L,6L,8L,0L,4L,9L,7L,9L,2L,5L,3L,1L,1L,2L,0L,3L,3L,1L,9L,5L,0L,2L,0L,7L,4L,6L,8L,8L,7L,9L,6L,6L,8L,0L,4L,9L,7L,9L,2L,5L,3L,1L,1L,2L,0L,3L,3L,1L,9L,5L,0L,2L,0L,7L,4L,6L,8L,8L,7L,9L,6L,6L,8L,0L,4L,9L,7L,9L,2L,5L,3L,1L,1L,2L,0L,3L,3L,1L,9L,5L,0L,2L,0L,7L,4L,6L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021486Inst : IEnumerable<long>
{
public static readonly long[] Value=A021486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021486.Bytes);
public long this[int i]=>Value[i];

public static A021486Inst Instance=new A021486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021487
{
public static readonly long[] Value={ 0L,0L,2L,0L,7L,0L,3L,9L,3L,3L,7L,4L,7L,4L,1L,2L,0L,0L,8L,2L,8L,1L,5L,7L,3L,4L,9L,8L,9L,6L,4L,8L,0L,3L,3L,1L,2L,6L,2L,9L,3L,9L,9L,5L,8L,5L,9L,2L,1L,3L,2L,5L,0L,5L,1L,7L,5L,9L,8L,3L,4L,3L,6L,8L,5L,3L,0L,0L,2L,0L,7L,0L,3L,9L,3L,3L,7L,4L,7L,4L,1L,2L,0L,0L,8L,2L,8L,1L,5L,7L,3L,4L,9L,8L,9L,6L,4L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021487Inst : IEnumerable<long>
{
public static readonly long[] Value=A021487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021487.Bytes);
public long this[int i]=>Value[i];

public static A021487Inst Instance=new A021487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021488
{
public static readonly long[] Value={ 0L,0L,2L,0L,6L,6L,1L,1L,5L,7L,0L,2L,4L,7L,9L,3L,3L,8L,8L,4L,2L,9L,7L,5L,2L,0L,6L,6L,1L,1L,5L,7L,0L,2L,4L,7L,9L,3L,3L,8L,8L,4L,2L,9L,7L,5L,2L,0L,6L,6L,1L,1L,5L,7L,0L,2L,4L,7L,9L,3L,3L,8L,8L,4L,2L,9L,7L,5L,2L,0L,6L,6L,1L,1L,5L,7L,0L,2L,4L,7L,9L,3L,3L,8L,8L,4L,2L,9L,7L,5L,2L,0L,6L,6L,1L,1L,5L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021488Inst : IEnumerable<long>
{
public static readonly long[] Value=A021488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021488.Bytes);
public long this[int i]=>Value[i];

public static A021488Inst Instance=new A021488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021489
{
public static readonly long[] Value={ 0L,0L,2L,0L,6L,1L,8L,5L,5L,6L,7L,0L,1L,0L,3L,0L,9L,2L,7L,8L,3L,5L,0L,5L,1L,5L,4L,6L,3L,9L,1L,7L,5L,2L,5L,7L,7L,3L,1L,9L,5L,8L,7L,6L,2L,8L,8L,6L,5L,9L,7L,9L,3L,8L,1L,4L,4L,3L,2L,9L,8L,9L,6L,9L,0L,7L,2L,1L,6L,4L,9L,4L,8L,4L,5L,3L,6L,0L,8L,2L,4L,7L,4L,2L,2L,6L,8L,0L,4L,1L,2L,3L,7L,1L,1L,3L,4L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021489Inst : IEnumerable<long>
{
public static readonly long[] Value=A021489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021489.Bytes);
public long this[int i]=>Value[i];

public static A021489Inst Instance=new A021489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021490
{
public static readonly long[] Value={ 0L,0L,2L,0L,5L,7L,6L,1L,3L,1L,6L,8L,7L,2L,4L,2L,7L,9L,8L,3L,5L,3L,9L,0L,9L,4L,6L,5L,0L,2L,0L,5L,7L,6L,1L,3L,1L,6L,8L,7L,2L,4L,2L,7L,9L,8L,3L,5L,3L,9L,0L,9L,4L,6L,5L,0L,2L,0L,5L,7L,6L,1L,3L,1L,6L,8L,7L,2L,4L,2L,7L,9L,8L,3L,5L,3L,9L,0L,9L,4L,6L,5L,0L,2L,0L,5L,7L,6L,1L,3L,1L,6L,8L,7L,2L,4L,2L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021490Inst : IEnumerable<long>
{
public static readonly long[] Value=A021490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021490.Bytes);
public long this[int i]=>Value[i];

public static A021490Inst Instance=new A021490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021491
{
public static readonly long[] Value={ 0L,0L,2L,0L,5L,3L,3L,8L,8L,0L,9L,0L,3L,4L,9L,0L,7L,5L,9L,7L,5L,3L,5L,9L,3L,4L,2L,9L,1L,5L,8L,1L,1L,0L,8L,8L,2L,9L,5L,6L,8L,7L,8L,8L,5L,0L,1L,0L,2L,6L,6L,9L,4L,0L,4L,5L,1L,7L,4L,5L,3L,7L,9L,8L,7L,6L,7L,9L,6L,7L,1L,4L,5L,7L,9L,0L,5L,5L,4L,4L,1L,4L,7L,8L,4L,3L,9L,4L,2L,5L,0L,5L,1L,3L,3L,4L,7L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021491Inst : IEnumerable<long>
{
public static readonly long[] Value=A021491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021491.Bytes);
public long this[int i]=>Value[i];

public static A021491Inst Instance=new A021491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021492
{
public static readonly long[] Value={ 0L,0L,2L,0L,4L,9L,1L,8L,0L,3L,2L,7L,8L,6L,8L,8L,5L,2L,4L,5L,9L,0L,1L,6L,3L,9L,3L,4L,4L,2L,6L,2L,2L,9L,5L,0L,8L,1L,9L,6L,7L,2L,1L,3L,1L,1L,4L,7L,5L,4L,0L,9L,8L,3L,6L,0L,6L,5L,5L,7L,3L,7L,7L,0L,4L,9L,1L,8L,0L,3L,2L,7L,8L,6L,8L,8L,5L,2L,4L,5L,9L,0L,1L,6L,3L,9L,3L,4L,4L,2L,6L,2L,2L,9L,5L,0L,8L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021492Inst : IEnumerable<long>
{
public static readonly long[] Value=A021492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021492.Bytes);
public long this[int i]=>Value[i];

public static A021492Inst Instance=new A021492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021493
{
public static readonly long[] Value={ 0L,0L,2L,0L,4L,4L,9L,8L,9L,7L,7L,5L,0L,5L,1L,1L,2L,4L,7L,4L,4L,3L,7L,6L,2L,7L,8L,1L,1L,8L,6L,0L,9L,4L,0L,6L,9L,5L,2L,9L,6L,5L,2L,3L,5L,1L,7L,3L,8L,2L,4L,1L,3L,0L,8L,7L,9L,3L,4L,5L,6L,0L,3L,2L,7L,1L,9L,8L,3L,6L,4L,0L,0L,8L,1L,7L,9L,9L,5L,9L,1L,0L,0L,2L,0L,4L,4L,9L,8L,9L,7L,7L,5L,0L,5L,1L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021493Inst : IEnumerable<long>
{
public static readonly long[] Value=A021493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021493.Bytes);
public long this[int i]=>Value[i];

public static A021493Inst Instance=new A021493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021494
{
public static readonly long[] Value={ 1L,17L,192L,1822L,15743L,128499L,1010374L,7741184L,58209525L,431623621L,3166395596L,23035216386L,166469995147L,1196633240183L,8564499500658L,61079918944228L,434330031817409L,3080934011678985L,21810281396626360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021494Inst : IEnumerable<long>
{
public static readonly long[] Value=A021494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021494.Bytes);
public long this[int i]=>Value[i];

public static A021494Inst Instance=new A021494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021495
{
public static readonly long[] Value={ 0L,0L,2L,0L,3L,6L,6L,5L,9L,8L,7L,7L,8L,0L,0L,4L,0L,7L,3L,3L,1L,9L,7L,5L,5L,6L,0L,0L,8L,1L,4L,6L,6L,3L,9L,5L,1L,1L,2L,0L,1L,6L,2L,9L,3L,2L,7L,9L,0L,2L,2L,4L,0L,3L,2L,5L,8L,6L,5L,5L,8L,0L,4L,4L,8L,0L,6L,5L,1L,7L,3L,1L,1L,6L,0L,8L,9L,6L,1L,3L,0L,3L,4L,6L,2L,3L,2L,1L,7L,9L,2L,2L,6L,0L,6L,9L,2L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021495Inst : IEnumerable<long>
{
public static readonly long[] Value=A021495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021495.Bytes);
public long this[int i]=>Value[i];

public static A021495Inst Instance=new A021495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021496
{
public static readonly long[] Value={ 0L,0L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021496Inst : IEnumerable<long>
{
public static readonly long[] Value=A021496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021496.Bytes);
public long this[int i]=>Value[i];

public static A021496Inst Instance=new A021496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021497
{
public static readonly long[] Value={ 0L,0L,2L,0L,2L,8L,3L,9L,7L,5L,6L,5L,9L,2L,2L,9L,2L,0L,8L,9L,2L,4L,9L,4L,9L,2L,9L,0L,0L,6L,0L,8L,5L,1L,9L,2L,6L,9L,7L,7L,6L,8L,7L,6L,2L,6L,7L,7L,4L,8L,4L,7L,8L,7L,0L,1L,8L,2L,5L,5L,5L,7L,8L,0L,9L,3L,3L,0L,6L,2L,8L,8L,0L,3L,2L,4L,5L,4L,3L,6L,1L,0L,5L,4L,7L,6L,6L,7L,3L,4L,2L,7L,9L,9L,1L,8L,8L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021497Inst : IEnumerable<long>
{
public static readonly long[] Value=A021497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021497.Bytes);
public long this[int i]=>Value[i];

public static A021497Inst Instance=new A021497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021498
{
public static readonly long[] Value={ 0L,0L,2L,0L,2L,4L,2L,9L,1L,4L,9L,7L,9L,7L,5L,7L,0L,8L,5L,0L,2L,0L,2L,4L,2L,9L,1L,4L,9L,7L,9L,7L,5L,7L,0L,8L,5L,0L,2L,0L,2L,4L,2L,9L,1L,4L,9L,7L,9L,7L,5L,7L,0L,8L,5L,0L,2L,0L,2L,4L,2L,9L,1L,4L,9L,7L,9L,7L,5L,7L,0L,8L,5L,0L,2L,0L,2L,4L,2L,9L,1L,4L,9L,7L,9L,7L,5L,7L,0L,8L,5L,0L,2L,0L,2L,4L,2L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021498Inst : IEnumerable<long>
{
public static readonly long[] Value=A021498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021498.Bytes);
public long this[int i]=>Value[i];

public static A021498Inst Instance=new A021498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021499
{
public static readonly long[] Value={ 0L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021499Inst : IEnumerable<long>
{
public static readonly long[] Value=A021499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021499.Bytes);
public long this[int i]=>Value[i];

public static A021499Inst Instance=new A021499Inst();

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