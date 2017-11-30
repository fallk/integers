using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A275976
{
public static readonly long[] Value={ 5L,1L,5L,5L,1L,2L,4L,3L,4L,0L,0L,7L,4L,6L,4L,4L,0L,5L,5L,1L,4L,1L,6L,1L,9L,3L,3L,7L,5L,6L,5L,2L,2L,8L,2L,8L,7L,4L,8L,5L,7L,6L,0L,4L,5L,1L,8L,8L,1L,1L,0L,0L,2L,4L,8L,3L,1L,4L,3L,1L,1L,0L,7L,7L,6L,9L,7L,3L,5L,0L,2L,9L,8L,8L,6L,6L,9L,4L,6L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275976Inst : IEnumerable<long>
{
public static readonly long[] Value=A275976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275976.Bytes);
public long this[int i]=>Value[i];

public static A275976Inst Instance=new A275976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275977
{
public static readonly long[] Value={ 4L,7L,8L,2L,2L,0L,2L,7L,8L,8L,0L,5L,4L,6L,1L,2L,0L,2L,9L,5L,2L,8L,3L,9L,2L,9L,8L,6L,6L,0L,0L,0L,5L,9L,0L,9L,7L,4L,1L,4L,9L,7L,1L,7L,2L,4L,0L,2L,2L,3L,6L,5L,0L,0L,8L,5L,1L,3L,3L,4L,5L,1L,0L,9L,9L,1L,8L,3L,7L,8L,9L,5L,0L,9L,4L,2L,6L,6L,2L,9L,7L,0L,2L,7L,8L,9L,2L,7L,6L,8L,6L,1L,1L,2L,7L,0L,7L,8L,9L,4L,5L,8L,6L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275977Inst : IEnumerable<long>
{
public static readonly long[] Value=A275977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275977.Bytes);
public long this[int i]=>Value[i];

public static A275977Inst Instance=new A275977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275978
{
public static readonly long[] Value={ 1L,4L,6L,12L,34L,54L,60L,61L,73L,148L,349L,552L,649L,967L,1044L,2521L,4501L,5721L,6133L,9052L,9880L,16126L,16215L,19146L,61770L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275978Inst : IEnumerable<long>
{
public static readonly long[] Value=A275978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275978.Bytes);
public long this[int i]=>Value[i];

public static A275978Inst Instance=new A275978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275979
{
public static readonly long[] Value={ 3L,4L,6L,0L,8L,8L,2L,8L,2L,4L,9L,0L,8L,5L,1L,2L,1L,5L,2L,4L,2L,9L,6L,0L,3L,9L,5L,7L,6L,7L,4L,1L,3L,3L,1L,6L,7L,2L,2L,6L,2L,8L,6L,6L,8L,9L,0L,0L,2L,3L,8L,5L,4L,7L,7L,9L,0L,4L,8L,9L,2L,8L,3L,4L,4L,5L,0L,0L,6L,2L,2L,0L,8L,0L,9L,8L,3L,4L,1L,1L,4L,4L,6L,4L,3L,6L,4L,3L,7L,5L,5L,4L,4L,1L,5L,3L,7L,0L,7L,5L,3L,3L,6L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275979Inst : IEnumerable<long>
{
public static readonly long[] Value=A275979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275979.Bytes);
public long this[int i]=>Value[i];

public static A275979Inst Instance=new A275979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275980
{
public static readonly long[] Value={ 2L,8L,1L,4L,1L,1L,2L,0L,1L,3L,6L,9L,7L,3L,7L,3L,1L,3L,3L,3L,9L,3L,1L,5L,2L,9L,7L,5L,8L,4L,2L,5L,8L,4L,1L,9L,1L,8L,1L,8L,6L,6L,2L,3L,8L,2L,0L,1L,3L,6L,0L,0L,7L,8L,7L,8L,9L,2L,4L,1L,9L,3L,4L,9L,3L,4L,5L,5L,1L,5L,1L,7L,6L,6L,8L,2L,2L,7L,6L,3L,1L,3L,8L,1L,0L,7L,1L,5L,0L,9L,4L,7L,4L,5L,6L,3L,3L,2L,5L,7L,0L,7L,4L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275980Inst : IEnumerable<long>
{
public static readonly long[] Value=A275980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275980.Bytes);
public long this[int i]=>Value[i];

public static A275980Inst Instance=new A275980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275981
{
public static readonly long[] Value={ 4L,3L,1L,5L,4L,2L,4L,7L,9L,7L,3L,8L,8L,1L,6L,2L,6L,4L,8L,0L,5L,5L,2L,3L,5L,5L,1L,6L,3L,3L,7L,9L,1L,9L,8L,3L,9L,0L,5L,3L,9L,3L,5L,0L,4L,3L,2L,2L,6L,7L,1L,1L,5L,0L,5L,1L,6L,5L,2L,5L,0L,5L,4L,1L,4L,0L,3L,3L,3L,0L,6L,8L,0L,1L,3L,7L,6L,5L,8L,0L,9L,1L,1L,3L,0L,4L,5L,1L,3L,6L,2L,9L,3L,1L,8L,5L,8L,4L,6L,6L,5L,5L,4L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275981Inst : IEnumerable<long>
{
public static readonly long[] Value=A275981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275981.Bytes);
public long this[int i]=>Value[i];

public static A275981Inst Instance=new A275981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275982
{
public static readonly long[] Value={ 4L,4L,8L,6L,7L,9L,1L,6L,6L,1L,1L,9L,0L,4L,3L,3L,3L,4L,7L,9L,4L,9L,5L,1L,4L,1L,0L,3L,6L,1L,5L,9L,1L,7L,7L,8L,7L,2L,7L,2L,0L,9L,0L,2L,3L,7L,2L,9L,3L,8L,8L,6L,1L,3L,0L,1L,0L,3L,6L,4L,8L,0L,4L,4L,7L,5L,1L,2L,7L,8L,5L,6L,0L,9L,1L,5L,8L,0L,5L,3L,6L,3L,7L,1L,6L,2L,0L,1L,8L,3L,9L,5L,9L,2L,0L,1L,8L,3L,1L,0L,8L,6L,8L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275982Inst : IEnumerable<long>
{
public static readonly long[] Value=A275982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275982.Bytes);
public long this[int i]=>Value[i];

public static A275982Inst Instance=new A275982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275983
{
public static readonly long[] Value={ 4L,0L,2L,8L,7L,4L,1L,1L,5L,7L,7L,8L,9L,8L,8L,7L,7L,8L,1L,8L,1L,8L,7L,3L,3L,2L,9L,0L,7L,1L,5L,9L,1L,7L,6L,7L,7L,2L,2L,4L,3L,8L,5L,0L,6L,8L,9L,1L,6L,2L,2L,4L,2L,0L,0L,4L,1L,0L,2L,9L,9L,6L,3L,5L,7L,8L,6L,9L,4L,5L,9L,5L,2L,4L,0L,8L,8L,7L,4L,0L,0L,8L,6L,7L,6L,3L,9L,8L,6L,1L,4L,6L,1L,4L,6L,6L,5L,3L,7L,1L,0L,3L,8L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275983Inst : IEnumerable<long>
{
public static readonly long[] Value=A275983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275983.Bytes);
public long this[int i]=>Value[i];

public static A275983Inst Instance=new A275983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275984
{
public static readonly long[] Value={ 8L,5L,4L,5L,0L,9L,8L,2L,4L,3L,0L,3L,6L,3L,3L,8L,0L,3L,1L,9L,3L,3L,0L,0L,7L,0L,5L,3L,1L,8L,4L,0L,3L,0L,3L,6L,5L,0L,9L,9L,0L,1L,5L,9L,1L,3L,0L,4L,0L,2L,1L,0L,5L,8L,3L,4L,3L,2L,6L,9L,2L,5L,8L,2L,8L,2L,2L,9L,0L,0L,6L,4L,7L,8L,2L,1L,6L,7L,6L,3L,5L,8L,5L,6L,2L,0L,0L,5L,0L,0L,0L,1L,4L,4L,5L,7L,6L,4L,5L,8L,6L,1L,4L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275984Inst : IEnumerable<long>
{
public static readonly long[] Value=A275984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275984.Bytes);
public long this[int i]=>Value[i];

public static A275984Inst Instance=new A275984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275985
{
public static readonly long[] Value={ 1L,3L,6L,4L,10L,6L,14L,4L,7L,10L,22L,6L,26L,14L,10L,5L,34L,7L,38L,10L,14L,22L,46L,6L,11L,26L,9L,14L,58L,10L,62L,5L,22L,34L,14L,7L,74L,38L,26L,10L,82L,14L,86L,22L,10L,46L,94L,6L,21L,11L,34L,26L,106L,9L,22L,14L,38L,58L,118L,10L,122L,62L,14L,6L,26L,22L,134L,34L,46L,14L,142L,7L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275985Inst : IEnumerable<long>
{
public static readonly long[] Value=A275985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275985.Bytes);
public long this[int i]=>Value[i];

public static A275985Inst Instance=new A275985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275986
{
public static readonly long[] Value={ 101L,1233L,8833L,10001L,10100L,990100L,1000001L,5882353L,94122353L,99009901L,100000001L,100010000L,1765038125L,2584043776L,7416043776L,8235038125L,9901009901L,10000000001L,48600220401L,116788321168L,123288328768L,601300773101L,876712328768L,883212321168L,990100990100L,999900010000L,1000000000001L,1000001000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275986Inst : IEnumerable<long>
{
public static readonly long[] Value=A275986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275986.Bytes);
public long this[int i]=>Value[i];

public static A275986Inst Instance=new A275986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275987
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,6L,12L,13L,14L,14L,16L,10L,18L,19L,20L,21L,22L,14L,24L,16L,20L,27L,28L,29L,30L,21L,32L,33L,34L,33L,36L,37L,24L,28L,40L,20L,42L,43L,44L,45L,30L,33L,48L,49L,50L,30L,52L,34L,54L,30L,54L,57L,40L,24L,60L,61L,42L,63L,64L,44L,66L,67L,68L,42L,66L,30L,72L,73L,74L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275987Inst : IEnumerable<long>
{
public static readonly long[] Value=A275987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275987.Bytes);
public long this[int i]=>Value[i];

public static A275987Inst Instance=new A275987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276116
{
public static readonly long[] Value={ 2L,1L,3L,11L,5L,29L,2L,37L,1L,17L,3L,277L,33L,1L,5L,59L,2L,313L,2L,31L,1L,2L,10L,401L,1L,37L,1L,71L,4L,367L,3L,367L,1L,1L,7L,1259L,8L,1L,11L,83L,4L,347L,2L,1L,3L,5L,2L,6263L,2L,7L,3L,23L,10L,331L,11L,94L,1L,2L,2L,1069L,2L,2L,13L,467L,11L,89L,3L,67L,15L,5L,2L,2467L,8L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276116Inst : IEnumerable<long>
{
public static readonly long[] Value=A276116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276116.Bytes);
public long this[int i]=>Value[i];

public static A276116Inst Instance=new A276116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276117
{
public static readonly long[] Value={ 1L,3L,7L,10L,11L,21L,16L,25L,24L,31L,38L,37L,34L,46L,47L,53L,51L,63L,69L,79L,75L,81L,87L,88L,91L,103L,102L,104L,109L,112L,119L,140L,127L,133L,134L,146L,150L,156L,155L,164L,170L,175L,189L,193L,197L,197L,209L,215L,215L,224L,221L,237L,237L,246L,247L,249L,254L,266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276117Inst : IEnumerable<long>
{
public static readonly long[] Value=A276117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276117.Bytes);
public long this[int i]=>Value[i];

public static A276117Inst Instance=new A276117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276118
{
public static readonly long[] Value={ 0L,1L,2L,4L,13L,19L,39L,62L,76L,79L,109L,184L,222L,265L,370L,626L,670L,679L,763L,1950L,2174L,3379L,7369L,9087L,34990L,47535L,97970L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276118Inst : IEnumerable<long>
{
public static readonly long[] Value=A276118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276118.Bytes);
public long this[int i]=>Value[i];

public static A276118Inst Instance=new A276118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276119
{
public static readonly long[] Value={ 2L,2L,3L,3L,5L,5L,4L,6L,5L,11L,9L,12L,11L,12L,17L,17L,16L,19L,16L,18L,24L,22L,17L,22L,26L,32L,36L,33L,26L,35L,39L,45L,36L,36L,38L,52L,42L,51L,40L,48L,55L,51L,67L,62L,64L,66L,66L,72L,77L,67L,71L,73L,96L,75L,69L,109L,83L,90L,86L,100L,101L,95L,91L,112L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276119Inst : IEnumerable<long>
{
public static readonly long[] Value=A276119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276119.Bytes);
public long this[int i]=>Value[i];

public static A276119Inst Instance=new A276119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276120
{
public static readonly long[] Value={ 0L,3L,8L,7L,6L,8L,1L,7L,9L,6L,0L,2L,9L,1L,6L,7L,9L,8L,9L,4L,1L,1L,1L,9L,8L,9L,0L,3L,1L,8L,7L,2L,1L,1L,4L,9L,8L,0L,6L,2L,3L,4L,5L,6L,8L,0L,3L,9L,5L,5L,2L,5L,7L,9L,2L,2L,3L,1L,2L,6L,7L,6L,2L,1L,2L,3L,7L,7L,7L,1L,3L,7L,0L,1L,2L,2L,8L,6L,8L,5L,5L,2L,7L,1L,8L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276120Inst : IEnumerable<long>
{
public static readonly long[] Value=A276120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276120.Bytes);
public long this[int i]=>Value[i];

public static A276120Inst Instance=new A276120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276121
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,1L,13L,7L,1L,21L,15L,3L,31L,147L,45L,1L,43L,73L,15L,69L,91L,1L,51L,81L,3L,1L,9L,85L,1L,55L,169L,225L,109L,145L,15L,103L,615L,69L,259L,69L,63L,45L,285L,471L,9L,255L,169L,489L,69L,273L,427L,43L,391L,169L,201L,21L,159L,181L,103L,15L,339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276121Inst : IEnumerable<long>
{
public static readonly long[] Value=A276121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276121.Bytes);
public long this[int i]=>Value[i];

public static A276121Inst Instance=new A276121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276122
{
public static readonly BigInteger[] Value={ 1L,1L,1L,4L,22L,526L,69427L,219111589L,91273561736491L,BigInteger.Parse("119994570874632853695766"),BigInteger.Parse("65713991236617279734602790963627271046"),BigInteger.Parse("47311933073383646516067037755547920981262829886906923065810924") };
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
public class A276122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276122Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276122.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276122.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276122Inst Instance=new A276122Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276123
{
public static readonly long[] Value={ 1L,1L,1L,4L,10L,55L,154L,868L,2449L,13825L,39025L,220324L,621946L,3511351L,9912106L,55961284L,157971745L,891869185L,2517635809L,14213945668L,40124201194L,226531261495L,639469583290L,3610286238244L,10191389131441L,57538048550401L,162422756519761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276123Inst : IEnumerable<long>
{
public static readonly long[] Value=A276123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276123.Bytes);
public long this[int i]=>Value[i];

public static A276123Inst Instance=new A276123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276124
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,4L,22L,589L,399253L,41144206447L,BigInteger.Parse("77387327118194895379"),BigInteger.Parse("10169897514576967837097322386922878932"),BigInteger.Parse("259050897146323086186965020577200627526185475088368701480903471601830") };
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
public class A276124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276124Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276124.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276124.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276124Inst Instance=new A276124Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276125
{
public static readonly long[] Value={ 1L,2L,3L,2L,6L,6L,12L,2L,24L,6L,30L,6L,30L,22L,6L,2L,30L,24L,90L,6L,33L,42L,59L,6L,40L,30L,72L,22L,77L,6L,73L,2L,66L,30L,66L,24L,72L,90L,60L,6L,99L,66L,122L,42L,48L,118L,144L,6L,432L,40L,60L,30L,132L,72L,66L,22L,129L,154L,870L,6L,210L,146L,264L,2L,60L,66L,224L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276125Inst : IEnumerable<long>
{
public static readonly long[] Value=A276125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276125.Bytes);
public long this[int i]=>Value[i];

public static A276125Inst Instance=new A276125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276126
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,5L,33L,1281L,1853441L,3826997739521L,BigInteger.Parse("2989151785658720873470945"),BigInteger.Parse("271581474754155314350055167823358355425497243141"),BigInteger.Parse("57581776430597685625970981157448022010386123824977761496513036956000541901241585948341716033") };
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
public class A276126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276126Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276126.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276126.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276126Inst Instance=new A276126Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276127
{
public static readonly long[] Value={ 1L,2L,4L,5L,3L,6L,7L,6L,7L,5L,8L,8L,9L,7L,10L,9L,8L,9L,13L,11L,14L,9L,10L,10L,12L,11L,15L,13L,16L,10L,10L,19L,17L,20L,12L,21L,19L,22L,11L,11L,15L,25L,23L,26L,11L,12L,17L,11L,13L,14L,13L,12L,16L,18L,14L,31L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276127Inst : IEnumerable<long>
{
public static readonly long[] Value=A276127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276127.Bytes);
public long this[int i]=>Value[i];

public static A276127Inst Instance=new A276127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276128
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,8L,10L,12L,14L,16L,18L,21L,24L,27L,30L,34L,38L,42L,46L,49L,52L,55L,58L,61L,64L,67L,70L,73L,76L,79L,82L,86L,90L,94L,98L,102L,106L,110L,114L,119L,124L,129L,134L,139L,144L,149L,154L,160L,166L,172L,178L,182L,186L,190L,194L,198L,202L,206L,210L,214L,218L,222L,226L,230L,234L,238L,242L,246L,250L,254L,258L,262L,266L,270L,274L,278L,282L,286L,290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276128Inst : IEnumerable<long>
{
public static readonly long[] Value=A276128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276128.Bytes);
public long this[int i]=>Value[i];

public static A276128Inst Instance=new A276128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276129
{
public static readonly long[] Value={ 1L,3L,6L,13L,27L,54L,106L,204L,387L,725L,1344L,2469L,4500L,8145L,14652L,26213L,46665L,82704L,145982L,256722L,449937L,786109L,1369494L,2379447L,4123944L,7130895L,12303714L,21186013L,36411399L,62466906L,106987282L,182946888L,312367887L,532587461L,906840060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276129Inst : IEnumerable<long>
{
public static readonly long[] Value=A276129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276129.Bytes);
public long this[int i]=>Value[i];

public static A276129Inst Instance=new A276129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276130
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,4L,10L,55L,649L,38881L,6414706L,24978826228L,2913605221297249L,BigInteger.Parse("112139525368095766797655"),BigInteger.Parse("8403341152380185679389503620974065"),BigInteger.Parse("146904111947501701959735285821948223340424963459227") };
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
public class A276130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276130Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276130.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276130.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276130Inst Instance=new A276130Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276131
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,10L,136L,20251L,413100001L,170660037240000001L,BigInteger.Parse("2912484838126132813026335712191641"),BigInteger.Parse("62371823031725048177115183368983888882661870237372850050710016335") };
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
public class A276131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276131Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276131.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276131.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276131Inst Instance=new A276131Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276212
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,8L,9L,11L,12L,13L,14L,16L,17L,18L,19L,21L,22L,23L,24L,25L,27L,28L,29L,30L,31L,33L,34L,35L,36L,37L,38L,40L,41L,42L,43L,44L,45L,47L,48L,49L,50L,51L,52L,54L,55L,56L,57L,58L,59L,61L,62L,63L,64L,65L,66L,67L,69L,70L,71L,72L,73L,74L,75L,77L,78L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276212Inst : IEnumerable<long>
{
public static readonly long[] Value=A276212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276212.Bytes);
public long this[int i]=>Value[i];

public static A276212Inst Instance=new A276212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276213
{
public static readonly long[] Value={ 2L,5L,7L,10L,14L,17L,20L,24L,27L,31L,34L,38L,42L,45L,49L,53L,57L,61L,65L,69L,74L,78L,82L,86L,91L,95L,99L,104L,108L,113L,117L,122L,126L,131L,136L,140L,145L,150L,155L,159L,164L,169L,174L,179L,184L,189L,194L,199L,204L,209L,214L,219L,224L,229L,234L,239L,245L,250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276213Inst : IEnumerable<long>
{
public static readonly long[] Value=A276213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276213.Bytes);
public long this[int i]=>Value[i];

public static A276213Inst Instance=new A276213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276214
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,9L,11L,12L,13L,15L,16L,18L,19L,21L,22L,23L,25L,26L,28L,29L,30L,32L,33L,35L,36L,37L,39L,40L,41L,43L,44L,46L,47L,48L,50L,51L,52L,54L,55L,56L,58L,59L,60L,62L,63L,64L,66L,67L,68L,70L,71L,72L,73L,75L,76L,77L,79L,80L,81L,83L,84L,85L,87L,88L,89L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276214Inst : IEnumerable<long>
{
public static readonly long[] Value=A276214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276214.Bytes);
public long this[int i]=>Value[i];

public static A276214Inst Instance=new A276214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276215
{
public static readonly long[] Value={ 3L,7L,13L,19L,26L,34L,42L,51L,61L,72L,83L,95L,108L,121L,135L,150L,165L,181L,197L,214L,231L,249L,267L,286L,306L,326L,347L,368L,389L,411L,434L,457L,481L,505L,530L,555L,580L,606L,633L,660L,687L,715L,744L,773L,802L,832L,862L,893L,924L,955L,988L,1020L,1053L,1086L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276215Inst : IEnumerable<long>
{
public static readonly long[] Value=A276215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276215.Bytes);
public long this[int i]=>Value[i];

public static A276215Inst Instance=new A276215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276216
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,8L,9L,10L,11L,12L,14L,15L,16L,17L,18L,20L,21L,22L,23L,24L,25L,27L,28L,29L,30L,31L,32L,33L,35L,36L,37L,38L,39L,40L,41L,43L,44L,45L,46L,47L,48L,49L,50L,52L,53L,54L,55L,56L,57L,58L,59L,60L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,73L,74L,75L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276216Inst : IEnumerable<long>
{
public static readonly long[] Value=A276216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276216.Bytes);
public long this[int i]=>Value[i];

public static A276216Inst Instance=new A276216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276217
{
public static readonly long[] Value={ 2L,5L,9L,12L,16L,20L,24L,29L,33L,38L,43L,48L,53L,59L,64L,69L,75L,81L,87L,93L,99L,105L,111L,117L,124L,130L,137L,143L,150L,157L,164L,171L,178L,185L,192L,200L,207L,214L,222L,229L,237L,245L,252L,260L,268L,276L,284L,292L,300L,308L,317L,325L,333L,342L,350L,359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276217Inst : IEnumerable<long>
{
public static readonly long[] Value=A276217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276217.Bytes);
public long this[int i]=>Value[i];

public static A276217Inst Instance=new A276217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276218
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,8L,10L,11L,13L,14L,15L,17L,18L,19L,21L,22L,23L,25L,26L,27L,28L,30L,31L,32L,34L,35L,36L,37L,39L,40L,41L,42L,44L,45L,46L,47L,49L,50L,51L,52L,54L,55L,56L,57L,58L,60L,61L,62L,63L,65L,66L,67L,68L,70L,71L,72L,73L,74L,76L,77L,78L,79L,80L,82L,83L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276218Inst : IEnumerable<long>
{
public static readonly long[] Value=A276218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276218.Bytes);
public long this[int i]=>Value[i];

public static A276218Inst Instance=new A276218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276219
{
public static readonly long[] Value={ 3L,6L,10L,13L,17L,21L,25L,30L,34L,39L,44L,49L,54L,60L,65L,70L,76L,82L,88L,94L,100L,106L,112L,118L,125L,131L,138L,144L,151L,158L,165L,172L,179L,186L,193L,201L,208L,215L,223L,230L,238L,246L,253L,261L,269L,277L,285L,293L,301L,309L,318L,326L,334L,343L,351L,360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276219Inst : IEnumerable<long>
{
public static readonly long[] Value=A276219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276219.Bytes);
public long this[int i]=>Value[i];

public static A276219Inst Instance=new A276219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276220
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,9L,11L,12L,14L,15L,16L,18L,19L,20L,22L,23L,24L,26L,27L,28L,29L,31L,32L,33L,35L,36L,37L,38L,40L,41L,42L,43L,45L,46L,47L,48L,50L,51L,52L,53L,55L,56L,57L,58L,59L,61L,62L,63L,64L,66L,67L,68L,69L,71L,72L,73L,74L,75L,77L,78L,79L,80L,81L,83L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276220Inst : IEnumerable<long>
{
public static readonly long[] Value=A276220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276220.Bytes);
public long this[int i]=>Value[i];

public static A276220Inst Instance=new A276220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276221
{
public static readonly long[] Value={ 4L,8L,14L,20L,27L,35L,43L,52L,62L,73L,84L,96L,109L,122L,136L,151L,166L,182L,198L,215L,232L,250L,268L,287L,307L,327L,348L,369L,390L,412L,435L,458L,482L,506L,531L,556L,581L,607L,634L,661L,688L,716L,745L,774L,803L,833L,863L,894L,925L,956L,989L,1021L,1054L,1087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276221Inst : IEnumerable<long>
{
public static readonly long[] Value=A276221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276221.Bytes);
public long this[int i]=>Value[i];

public static A276221Inst Instance=new A276221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276222
{
public static readonly long[] Value={ 4L,7L,12L,17L,23L,29L,35L,42L,50L,58L,66L,75L,84L,93L,103L,113L,124L,135L,146L,157L,169L,181L,194L,206L,219L,233L,246L,260L,274L,288L,303L,318L,333L,349L,364L,380L,396L,413L,430L,446L,464L,481L,499L,517L,535L,553L,572L,590L,610L,629L,648L,668L,688L,708L,728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276222Inst : IEnumerable<long>
{
public static readonly long[] Value=A276222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276222.Bytes);
public long this[int i]=>Value[i];

public static A276222Inst Instance=new A276222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276223
{
public static readonly long[] Value={ 2L,4L,6L,9L,11L,14L,17L,19L,22L,24L,27L,30L,33L,35L,38L,41L,44L,47L,49L,52L,55L,58L,61L,64L,67L,70L,73L,75L,78L,81L,84L,87L,90L,93L,96L,99L,102L,105L,109L,112L,115L,118L,121L,124L,127L,130L,133L,136L,139L,143L,146L,149L,152L,155L,158L,161L,165L,168L,171L,174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276223Inst : IEnumerable<long>
{
public static readonly long[] Value=A276223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276223.Bytes);
public long this[int i]=>Value[i];

public static A276223Inst Instance=new A276223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276224
{
public static readonly long[] Value={ 1L,3L,5L,7L,8L,10L,12L,13L,15L,16L,18L,20L,21L,23L,25L,26L,28L,29L,31L,32L,34L,36L,37L,39L,40L,42L,43L,45L,46L,48L,50L,51L,53L,54L,56L,57L,59L,60L,62L,63L,65L,66L,68L,69L,71L,72L,74L,76L,77L,79L,80L,82L,83L,85L,86L,88L,89L,91L,92L,94L,95L,97L,98L,100L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276224Inst : IEnumerable<long>
{
public static readonly long[] Value=A276224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276224.Bytes);
public long this[int i]=>Value[i];

public static A276224Inst Instance=new A276224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276225
{
public static readonly long[] Value={ 3L,2L,6L,17L,42L,107L,273L,695L,1770L,4508L,11481L,29240L,74469L,189659L,483027L,1230182L,3133050L,7979309L,20321850L,51756059L,131813277L,335704463L,854978262L,2177474264L,5545631253L,14123715032L,35970535581L,91610417447L,233315085507L,594211124042L,1513347751038L,3854221711625L,9816002298330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276225Inst : IEnumerable<long>
{
public static readonly long[] Value=A276225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276225.Bytes);
public long this[int i]=>Value[i];

public static A276225Inst Instance=new A276225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276226
{
public static readonly long[] Value={ 0L,6L,8L,22L,58L,146L,372L,948L,2414L,6148L,15658L,39878L,101562L,258660L,658760L,1677742L,4272904L,10882310L,27715266L,70585746L,179769068L,457839148L,1166033110L,2969674436L,7563221130L,19262149806L,49057195178L,124939761292L,318198867568L,810394691606L,2063928012072L,5256449583318L,13387221870314L,34094821336018L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276226Inst : IEnumerable<long>
{
public static readonly long[] Value=A276226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276226.Bytes);
public long this[int i]=>Value[i];

public static A276226Inst Instance=new A276226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276227
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,9L,4L,6L,8L,10L,12L,14L,11L,13L,17L,19L,23L,18L,15L,16L,20L,21L,22L,24L,25L,26L,27L,28L,30L,32L,33L,34L,35L,36L,29L,31L,37L,41L,43L,47L,38L,39L,40L,42L,44L,45L,46L,48L,49L,50L,51L,52L,54L,55L,56L,57L,53L,59L,61L,67L,71L,65L,58L,60L,62L,63L,64L,66L,68L,69L,70L,72L,74L,75L,76L,77L,78L,80L,81L,73L,79L,83L,89L,97L,87L,82L,84L,85L,86L,88L,90L,91L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276227Inst : IEnumerable<long>
{
public static readonly long[] Value=A276227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276227.Bytes);
public long this[int i]=>Value[i];

public static A276227Inst Instance=new A276227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276276
{
public static readonly long[] Value={ 2L,1L,0L,3L,1L,3L,4L,4L,7L,8L,11L,15L,19L,26L,34L,45L,60L,79L,105L,139L,184L,244L,323L,428L,567L,751L,995L,1318L,1746L,2313L,3064L,4059L,5377L,7123L,9436L,12500L,16559L,21936L,29059L,38495L,50995L,67554L,89490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276276Inst : IEnumerable<long>
{
public static readonly long[] Value=A276276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276276.Bytes);
public long this[int i]=>Value[i];

public static A276276Inst Instance=new A276276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276277
{
public static readonly long[] Value={ 1L,2L,6L,25L,111L,540L,2736L,14396L,77649L,427608L,2392866L,13570386L,77815161L,450418536L,2628225684L,15443406868L,91301938365L,542704450806L,3241411991712L,19443499011192L,117084197728737L,707532791560272L,4289252607915012L,26078561954153631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276277Inst : IEnumerable<long>
{
public static readonly long[] Value=A276277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276277.Bytes);
public long this[int i]=>Value[i];

public static A276277Inst Instance=new A276277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276278
{
public static readonly long[] Value={ 3L,5L,6L,7L,9L,10L,11L,12L,13L,14L,16L,17L,18L,19L,20L,21L,23L,24L,25L,26L,27L,28L,30L,31L,32L,33L,34L,35L,37L,38L,39L,40L,41L,42L,44L,45L,46L,47L,48L,49L,51L,52L,53L,54L,55L,56L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,72L,73L,74L,75L,76L,77L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276278Inst : IEnumerable<long>
{
public static readonly long[] Value=A276278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276278.Bytes);
public long this[int i]=>Value[i];

public static A276278Inst Instance=new A276278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276279
{
public static readonly long[] Value={ 1L,8L,36L,127L,386L,1050L,2632L,6187L,13789L,29397L,60344L,119854L,231267L,434941L,799370L,1438926L,2541698L,4412665L,7540065L,12696188L,21088997L,34588405L,56060794L,89859652L,142540123L,223891729L,348420859L,537465685L,822193976L,1247827454L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276279Inst : IEnumerable<long>
{
public static readonly long[] Value=A276279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276279.Bytes);
public long this[int i]=>Value[i];

public static A276279Inst Instance=new A276279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276280
{
public static readonly long[] Value={ 1L,9L,45L,173L,567L,1654L,4422L,11040L,26051L,58638L,126778L,264670L,535806L,1055480L,2028884L,3814688L,7029559L,12717703L,22622719L,39618458L,68384638L,116456100L,195837008L,325462408L,534921468L,870044724L,1401226327L,2235733481L,3535790660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276280Inst : IEnumerable<long>
{
public static readonly long[] Value=A276280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276280.Bytes);
public long this[int i]=>Value[i];

public static A276280Inst Instance=new A276280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276281
{
public static readonly long[] Value={ 1L,2L,4L,5L,10L,15L,25L,30L,52L,75L,104L,203L,225L,260L,406L,780L,877L,1015L,1754L,2704L,3045L,4140L,4385L,8280L,10556L,13155L,20700L,21147L,41209L,42294L,45604L,62100L,105735L,115975L,178031L,215280L,231950L,317205L,579875L,678570L,769129L,840420L,1099644L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276281Inst : IEnumerable<long>
{
public static readonly long[] Value=A276281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276281.Bytes);
public long this[int i]=>Value[i];

public static A276281Inst Instance=new A276281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276282
{
public static readonly long[] Value={ 1L,1296L,10000L,20736L,38416L,46656L,50625L,104976L,160000L,194481L,234256L,331776L,456976L,614656L,810000L,1000000L,1185921L,1336336L,1500625L,1679616L,2085136L,2313441L,2560000L,2985984L,3111696L,3748096L,4100625L,4477456L,5308416L,6250000L,6765201L,7311616L,7529536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276282Inst : IEnumerable<long>
{
public static readonly long[] Value=A276282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276282.Bytes);
public long this[int i]=>Value[i];

public static A276282Inst Instance=new A276282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276283
{
public static readonly long[] Value={ 1L,3L,7L,11L,13L,15L,19L,23L,25L,27L,31L,35L,37L,39L,43L,47L,49L,51L,55L,59L,61L,63L,67L,71L,73L,75L,79L,83L,85L,87L,91L,95L,97L,99L,103L,107L,109L,111L,115L,119L,121L,123L,127L,131L,133L,135L,139L,143L,145L,147L,151L,155L,157L,159L,163L,167L,169L,171L,175L,179L,181L,183L,187L,191L,193L,195L,199L,203L,205L,207L,211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276283Inst : IEnumerable<long>
{
public static readonly long[] Value=A276283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276283.Bytes);
public long this[int i]=>Value[i];

public static A276283Inst Instance=new A276283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276284
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,9L,33L,385L,13825L,5474305L,8430415841L,1398605982547209L,BigInteger.Parse("30625582893143965429313"),BigInteger.Parse("3098236789946633955987434183345281"),BigInteger.Parse("17332850039068891068793031113694107707268123637761") };
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
public class A276284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276284Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276284.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276284.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276284Inst Instance=new A276284Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276285
{
public static readonly long[] Value={ 1L,26L,312L,2288L,11466L,41808L,116688L,265408L,535704L,1031914L,1899664L,3214224L,5043376L,7801744L,12066912L,17689152L,24443978L,34039200L,48210760L,64966096L,83323344L,109157152L,145532816L,185245632L,227110416L,284788010L,363737712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276285Inst : IEnumerable<long>
{
public static readonly long[] Value=A276285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276285.Bytes);
public long this[int i]=>Value[i];

public static A276285Inst Instance=new A276285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276286
{
public static readonly long[] Value={ 1L,28L,364L,2912L,16044L,64792L,200928L,503360L,1089452L,2186940L,4196920L,7544992L,12547808L,19975256L,31553344L,48484800L,70439852L,99602104L,142487436L,200569824L,268594872L,354052608L,476105504L,630908096L,800698080L,1008274932L,1296257144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276286Inst : IEnumerable<long>
{
public static readonly long[] Value=A276286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276286.Bytes);
public long this[int i]=>Value[i];

public static A276286Inst Instance=new A276286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276287
{
public static readonly long[] Value={ 1L,30L,420L,3640L,21870L,96936L,331240L,911040L,2128260L,4495430L,8972712L,16946280L,29822520L,49476840L,80027280L,127083328L,193511790L,282611280L,409172940L,590913960L,825736296L,1115671760L,1509537960L,2048372160L,2698852520L,3463029894L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276287Inst : IEnumerable<long>
{
public static readonly long[] Value=A276287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276287.Bytes);
public long this[int i]=>Value[i];

public static A276287Inst Instance=new A276287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276288
{
public static readonly long[] Value={ 0L,1L,1L,4L,7L,25L,46L,163L,301L,1066L,1969L,6973L,12880L,45613L,84253L,298372L,551131L,1951765L,3605158L,12767239L,23582713L,83515378L,154263517L,546305929L,1009096480L,3573595369L,6600884809L,23376249796L,43178904223L,152912962465L,282449675134L,1000261987867L,1847611013269L,6543095027674L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276288Inst : IEnumerable<long>
{
public static readonly long[] Value=A276288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276288.Bytes);
public long this[int i]=>Value[i];

public static A276288Inst Instance=new A276288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276289
{
public static readonly long[] Value={ 0L,1L,7L,30L,104L,320L,912L,2464L,6400L,16128L,39680L,95744L,227328L,532480L,1232896L,2826240L,6422528L,14483456L,32440320L,72220672L,159907840L,352321536L,772800512L,1688207360L,3674210304L,7969177600L,17230200832L,37144756224L,79859548160L,171261820928L,366414397440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276289Inst : IEnumerable<long>
{
public static readonly long[] Value=A276289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276289.Bytes);
public long this[int i]=>Value[i];

public static A276289Inst Instance=new A276289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276290
{
public static readonly long[] Value={ 25L,35L,55L,65L,77L,85L,95L,115L,133L,143L,145L,155L,161L,185L,203L,205L,209L,215L,217L,235L,253L,259L,265L,287L,295L,305L,329L,341L,355L,365L,371L,391L,395L,403L,407L,415L,427L,437L,445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276290Inst : IEnumerable<long>
{
public static readonly long[] Value=A276290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276290.Bytes);
public long this[int i]=>Value[i];

public static A276290Inst Instance=new A276290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276291
{
public static readonly long[] Value={ 1512L,91392L,5911400L,1120056192L,252824095384L,187568248374272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276291Inst : IEnumerable<long>
{
public static readonly long[] Value=A276291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276291.Bytes);
public long this[int i]=>Value[i];

public static A276291Inst Instance=new A276291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276820
{
public static readonly long[] Value={ 1546275796L,879788114L,1745191708L,771966234L,1247963869L,1611845387L,1529973242L,2093650929L,1860635684L,1497261229L,1145234796L,1165293667L,1233809453L,785019983L,252606271L,111721893L,473031201L,1002808953L,614474799L,471414712L,65507668L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276820Inst : IEnumerable<long>
{
public static readonly long[] Value=A276820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276820.Bytes);
public long this[int i]=>Value[i];

public static A276820Inst Instance=new A276820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276821
{
public static readonly long[] Value={ 2L,2L,29L,3299L,4866623L,22081407211439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276821Inst : IEnumerable<long>
{
public static readonly long[] Value=A276821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276821.Bytes);
public long this[int i]=>Value[i];

public static A276821Inst Instance=new A276821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276822
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,20L,30L,31L,40L,41L,42L,50L,51L,52L,53L,60L,61L,62L,63L,64L,70L,71L,72L,73L,74L,75L,80L,81L,82L,83L,84L,85L,86L,100L,101L,102L,103L,104L,105L,106L,107L,108L,200L,300L,301L,400L,401L,402L,500L,501L,502L,503L,600L,601L,602L,603L,604L,700L,701L,702L,703L,704L,705L,800L,801L,802L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276822Inst : IEnumerable<long>
{
public static readonly long[] Value=A276822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276822.Bytes);
public long this[int i]=>Value[i];

public static A276822Inst Instance=new A276822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276823
{
public static readonly BigInteger[] Value={ 1L,9L,1241L,2634489L,87807053113L,46414431022602681L,BigInteger.Parse("390913823614809035461305"),BigInteger.Parse("52571422826552549403006580802745"),BigInteger.Parse("113007269646365312407427675894837602068665"),BigInteger.Parse("3884802624238339577626451297006421856376970743148729") };
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
public class A276823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276823Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276823.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276823.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276823Inst Instance=new A276823Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276824
{
public static readonly long[] Value={ 0L,-1L,-1L,-2L,2L,-2L,3L,-5L,-1L,17L,2L,22L,25L,2L,1L,28L,47L,18L,41L,36L,-7L,20L,12L,37L,103L,91L,30L,10L,-57L,-70L,157L,125L,153L,63L,213L,120L,145L,168L,129L,154L,170L,65L,230L,114L,61L,-63L,189L,445L,386L,239L,172L,203L,52L,239L,257L,268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276824Inst : IEnumerable<long>
{
public static readonly long[] Value=A276824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276824.Bytes);
public long this[int i]=>Value[i];

public static A276824Inst Instance=new A276824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276825
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,2L,2L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,1L,2L,3L,2L,2L,2L,3L,1L,2L,2L,2L,2L,2L,2L,3L,1L,2L,1L,2L,2L,2L,2L,2L,1L,2L,1L,2L,1L,2L,1L,2L,2L,2L,2L,2L,2L,1L,3L,4L,2L,3L,2L,4L,1L,1L,3L,3L,3L,1L,2L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276825Inst : IEnumerable<long>
{
public static readonly long[] Value=A276825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276825.Bytes);
public long this[int i]=>Value[i];

public static A276825Inst Instance=new A276825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276826
{
public static readonly long[] Value={ 4L,14L,6L,6L,6L,12L,6L,8L,14L,14L,18L,36L,24L,65L,18L,6L,10L,6L,84L,14L,162L,10L,54L,84L,179L,10L,23L,12L,18L,18L,24L,128L,18L,24L,28L,10L,10L,72L,34L,23L,12L,18L,6L,6L,12L,34L,8L,644L,12L,12L,6L,29L,24L,12L,18L,28L,28L,24L,22L,22L,10L,14L,12L,12L,16L,6L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276826Inst : IEnumerable<long>
{
public static readonly long[] Value=A276826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276826.Bytes);
public long this[int i]=>Value[i];

public static A276826Inst Instance=new A276826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276827
{
public static readonly long[] Value={ 3L,5L,13L,53L,83L,853L,2083L,3413L,5333L,85333L,208333L,218453L,341333L,3495253L,5461333L,8533333L,13981013L,83333333L,853333333L,22369621333L,218453333333L,341333333333L,2236962133333L,3665038759253L,53333333333333L,91625968981333L,203450520833333L,1333333333333333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276827Inst : IEnumerable<long>
{
public static readonly long[] Value=A276827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276827.Bytes);
public long this[int i]=>Value[i];

public static A276827Inst Instance=new A276827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276828
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,10L,13L,15L,16L,21L,25L,26L,30L,34L,40L,42L,45L,52L,55L,65L,68L,75L,89L,104L,105L,110L,120L,144L,156L,170L,178L,195L,203L,233L,260L,275L,288L,315L,377L,406L,416L,445L,466L,510L,609L,610L,676L,720L,754L,825L,877L,987L,1015L,1092L,1165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276828Inst : IEnumerable<long>
{
public static readonly long[] Value=A276828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276828.Bytes);
public long this[int i]=>Value[i];

public static A276828Inst Instance=new A276828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276829
{
public static readonly long[] Value={ 2L,6L,12L,18L,24L,42L,48L,8L,30L,10L,60L,66L,36L,14L,20L,78L,22L,96L,108L,28L,84L,68L,102L,126L,90L,120L,72L,54L,114L,150L,26L,132L,144L,162L,16L,34L,186L,56L,50L,168L,156L,228L,204L,222L,40L,46L,174L,192L,210L,38L,180L,138L,80L,74L,44L,252L,76L,336L,240L,216L,264L,306L,258L,300L,246L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276829Inst : IEnumerable<long>
{
public static readonly long[] Value=A276829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276829.Bytes);
public long this[int i]=>Value[i];

public static A276829Inst Instance=new A276829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276830
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,2L,2L,1L,3L,3L,2L,2L,3L,3L,2L,1L,3L,2L,2L,1L,2L,3L,2L,1L,4L,3L,2L,2L,4L,2L,3L,1L,3L,4L,2L,2L,5L,4L,4L,2L,5L,3L,3L,2L,3L,5L,3L,1L,5L,3L,2L,2L,2L,3L,3L,2L,4L,4L,3L,2L,5L,3L,2L,3L,5L,3L,4L,3L,4L,5L,2L,3L,5L,4L,2L,3L,5L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276830Inst : IEnumerable<long>
{
public static readonly long[] Value=A276830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276830.Bytes);
public long this[int i]=>Value[i];

public static A276830Inst Instance=new A276830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276831
{
public static readonly long[] Value={ 5L,17L,11L,5L,3L,17L,3L,11L,11L,5L,31L,107L,13L,333L,17L,5L,3L,3L,281L,5L,997L,3L,487L,659L,5178L,5L,15L,3L,23L,53L,13L,1567L,13L,13L,181L,3L,5L,443L,37L,21L,19L,11L,5L,3L,5L,5L,7L,20786L,13L,7L,5L,21L,3L,5L,17L,61L,31L,23L,7L,3L,11L,5L,11L,5L,3L,3L,157L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276831Inst : IEnumerable<long>
{
public static readonly long[] Value=A276831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276831.Bytes);
public long this[int i]=>Value[i];

public static A276831Inst Instance=new A276831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276832
{
public static readonly long[] Value={ 231L,561L,1045L,1105L,1653L,1729L,2465L,2821L,3059L,3655L,4371L,4641L,5005L,5083L,5365L,5565L,6545L,6601L,7337L,8029L,8695L,8911L,9361L,10011L,10585L,10857L,10879L,11077L,11305L,12121L,13685L,13695L,15181L,15753L,15841L,16269L,17755L,18361L,18565L,19721L,20301L,20501L,21115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276832Inst : IEnumerable<long>
{
public static readonly long[] Value=A276832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276832.Bytes);
public long this[int i]=>Value[i];

public static A276832Inst Instance=new A276832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276833
{
public static readonly long[] Value={ 1L,0L,-1L,0L,-3L,0L,-5L,0L,-1L,0L,-9L,0L,-11L,0L,3L,0L,-15L,0L,-17L,0L,5L,0L,-21L,0L,-3L,0L,-1L,0L,-27L,0L,-29L,0L,9L,0L,15L,0L,-35L,0L,11L,0L,-39L,0L,-41L,0L,3L,0L,-45L,0L,-5L,0L,15L,0L,-51L,0L,27L,0L,17L,0L,-57L,0L,-59L,0L,5L,0L,33L,0L,-65L,0L,21L,0L,-69L,0L,-71L,0L,3L,0L,45L,0L,-77L,0L,-1L,0L,-81L,0L,45L,0L,27L,0L,-87L,0L,55L,0L,29L,0L,51L,0L,-95L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276833Inst : IEnumerable<long>
{
public static readonly long[] Value=A276833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276833.Bytes);
public long this[int i]=>Value[i];

public static A276833Inst Instance=new A276833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276834
{
public static readonly long[] Value={ 4L,1L,1L,0L,8L,2L,8L,8L,6L,3L,8L,2L,1L,6L,3L,3L,0L,2L,3L,8L,0L,8L,4L,8L,9L,7L,1L,6L,1L,5L,8L,5L,9L,2L,1L,2L,9L,2L,3L,9L,4L,1L,6L,5L,0L,2L,2L,0L,6L,1L,5L,7L,4L,4L,2L,5L,1L,9L,0L,3L,9L,5L,9L,6L,9L,3L,2L,1L,9L,6L,5L,4L,0L,3L,1L,8L,2L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276834Inst : IEnumerable<long>
{
public static readonly long[] Value=A276834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276834.Bytes);
public long this[int i]=>Value[i];

public static A276834Inst Instance=new A276834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276835
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,1L,7L,1L,3L,1L,11L,1L,13L,1L,1L,6L,17L,3L,19L,4L,1L,3L,23L,90L,5L,5L,3L,3L,29L,12L,31L,112L,3L,105L,1L,50L,37L,5L,1L,27L,41L,81L,43L,10L,1L,105L,47L,539L,7L,77L,15L,4L,265L,2L,3L,520L,3L,351L,59L,945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276835Inst : IEnumerable<long>
{
public static readonly long[] Value=A276835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276835.Bytes);
public long this[int i]=>Value[i];

public static A276835Inst Instance=new A276835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276948
{
public static readonly long[] Value={ 2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276948Inst : IEnumerable<long>
{
public static readonly long[] Value=A276948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276948.Bytes);
public long this[int i]=>Value[i];

public static A276948Inst Instance=new A276948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276949
{
public static readonly long[] Value={ 0L,1L,2L,1L,1L,1L,3L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L,1L,2L,1L,1L,1L,3L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,2L,1L,1L,1L,3L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276949Inst : IEnumerable<long>
{
public static readonly long[] Value=A276949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276949.Bytes);
public long this[int i]=>Value[i];

public static A276949Inst Instance=new A276949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276950
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276950Inst : IEnumerable<long>
{
public static readonly long[] Value=A276950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276950.Bytes);
public long this[int i]=>Value[i];

public static A276950Inst Instance=new A276950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276951
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,4L,1L,5L,2L,6L,7L,8L,3L,9L,4L,10L,11L,12L,13L,14L,15L,16L,17L,18L,1L,19L,5L,20L,21L,22L,2L,23L,6L,24L,25L,26L,7L,27L,8L,28L,29L,30L,31L,32L,33L,34L,35L,36L,3L,37L,9L,38L,39L,40L,4L,41L,10L,42L,43L,44L,11L,45L,12L,46L,47L,48L,49L,50L,51L,52L,53L,54L,13L,55L,14L,56L,57L,58L,15L,59L,16L,60L,61L,62L,17L,63L,18L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276951Inst : IEnumerable<long>
{
public static readonly long[] Value=A276951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276951.Bytes);
public long this[int i]=>Value[i];

public static A276951Inst Instance=new A276951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276952
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,4L,4L,5L,5L,6L,7L,8L,8L,9L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,18L,19L,19L,20L,21L,22L,22L,23L,23L,24L,25L,26L,26L,27L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,36L,37L,37L,38L,39L,40L,40L,41L,41L,42L,43L,44L,44L,45L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,54L,55L,55L,56L,57L,58L,58L,59L,59L,60L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276952Inst : IEnumerable<long>
{
public static readonly long[] Value=A276952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276952.Bytes);
public long this[int i]=>Value[i];

public static A276952Inst Instance=new A276952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276953
{
public static readonly long[] Value={ 1L,3L,2L,4L,8L,6L,5L,12L,30L,24L,7L,14L,48L,144L,120L,9L,26L,54L,240L,840L,720L,10L,32L,126L,264L,1440L,5760L,5040L,11L,36L,150L,744L,1560L,10080L,45360L,40320L,13L,38L,168L,864L,5160L,10800L,80640L,403200L,362880L,15L,50L,174L,960L,5880L,41040L,85680L,725760L,3991680L,3628800L,16L,56L,246L,984L,6480L,46080L,367920L,766080L,7257600L,43545600L,39916800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276953Inst : IEnumerable<long>
{
public static readonly long[] Value=A276953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276953.Bytes);
public long this[int i]=>Value[i];

public static A276953Inst Instance=new A276953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276954
{
public static readonly long[] Value={ 1L,3L,2L,4L,7L,6L,11L,5L,16L,22L,29L,8L,37L,12L,46L,56L,67L,79L,92L,106L,121L,137L,154L,10L,172L,17L,191L,211L,232L,9L,254L,23L,277L,301L,326L,30L,352L,38L,379L,407L,436L,466L,497L,529L,562L,596L,631L,13L,667L,47L,704L,742L,781L,18L,821L,57L,862L,904L,947L,68L,991L,80L,1036L,1082L,1129L,1177L,1226L,1276L,1327L,1379L,1432L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276954Inst : IEnumerable<long>
{
public static readonly long[] Value=A276954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276954.Bytes);
public long this[int i]=>Value[i];

public static A276954Inst Instance=new A276954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276955
{
public static readonly long[] Value={ 1L,2L,3L,6L,8L,4L,24L,30L,12L,5L,120L,144L,48L,14L,7L,720L,840L,240L,54L,26L,9L,5040L,5760L,1440L,264L,126L,32L,10L,40320L,45360L,10080L,1560L,744L,150L,36L,11L,362880L,403200L,80640L,10800L,5160L,864L,168L,38L,13L,3628800L,3991680L,725760L,85680L,41040L,5880L,960L,174L,50L,15L,39916800L,43545600L,7257600L,766080L,367920L,46080L,6480L,984L,246L,56L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276955Inst : IEnumerable<long>
{
public static readonly long[] Value=A276955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276955.Bytes);
public long this[int i]=>Value[i];

public static A276955Inst Instance=new A276955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276956
{
public static readonly long[] Value={ 1L,2L,3L,6L,10L,4L,15L,5L,21L,28L,36L,9L,45L,14L,55L,66L,78L,91L,105L,120L,136L,153L,171L,7L,190L,20L,210L,231L,253L,8L,276L,27L,300L,325L,351L,35L,378L,44L,406L,435L,465L,496L,528L,561L,595L,630L,666L,13L,703L,54L,741L,780L,820L,19L,861L,65L,903L,946L,990L,77L,1035L,90L,1081L,1128L,1176L,1225L,1275L,1326L,1378L,1431L,1485L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276956Inst : IEnumerable<long>
{
public static readonly long[] Value=A276956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276956.Bytes);
public long this[int i]=>Value[i];

public static A276956Inst Instance=new A276956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276957
{
public static readonly long[] Value={ 1L,4L,2L,3L,5L,12L,6L,16L,7L,8L,9L,18L,10L,22L,11L,13L,14L,15L,17L,19L,20L,21L,23L,48L,24L,52L,25L,26L,27L,60L,28L,64L,29L,30L,31L,66L,32L,70L,33L,34L,35L,36L,37L,38L,39L,40L,41L,72L,42L,76L,43L,44L,45L,84L,46L,88L,47L,49L,50L,90L,51L,94L,53L,54L,55L,56L,57L,58L,59L,61L,62L,96L,63L,100L,65L,67L,68L,108L,69L,112L,71L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276957Inst : IEnumerable<long>
{
public static readonly long[] Value=A276957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276957.Bytes);
public long this[int i]=>Value[i];

public static A276957Inst Instance=new A276957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276958
{
public static readonly long[] Value={ 1L,3L,4L,2L,5L,7L,9L,10L,11L,13L,15L,6L,16L,17L,18L,8L,19L,12L,20L,21L,22L,14L,23L,25L,27L,28L,29L,31L,33L,34L,35L,37L,39L,40L,41L,42L,43L,44L,45L,46L,47L,49L,51L,52L,53L,55L,57L,24L,58L,59L,61L,26L,63L,64L,65L,66L,67L,68L,69L,30L,70L,71L,73L,32L,75L,36L,76L,77L,79L,38L,81L,48L,82L,83L,85L,50L,87L,88L,89L,90L,91L,92L,93L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276958Inst : IEnumerable<long>
{
public static readonly long[] Value=A276958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276958.Bytes);
public long this[int i]=>Value[i];

public static A276958Inst Instance=new A276958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276959
{
public static readonly long[] Value={ 1L,5L,10L,21L,26L,50L,50L,85L,91L,31L,3L,71L,11L,71L,61L,122L,51L,196L,83L,51L,64L,15L,14L,155L,55L,55L,144L,155L,86L,111L,11L,135L,30L,80L,109L,262L,59L,160L,110L,131L,18L,141L,26L,63L,183L,70L,66L,272L,147L,85L,86L,100L,35L,290L,78L,280L,166L,179L,107L,172L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276959Inst : IEnumerable<long>
{
public static readonly long[] Value=A276959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276959.Bytes);
public long this[int i]=>Value[i];

public static A276959Inst Instance=new A276959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276960
{
public static readonly BigInteger[] Value={ 1L,1L,9L,169L,5329L,251001L,16410601L,1416242689L,155514288609L,21128299481809L,3474052208270281L,679096541717605881L,BigInteger.Parse("155504946117339546289"),BigInteger.Parse("41199419449380747871369"),BigInteger.Parse("12496348897836314700506409") };
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
public class A276960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276960Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276960.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276960.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276960Inst Instance=new A276960Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276961
{
public static readonly BigInteger[] Value={ 1L,1L,9L,90L,1015L,12978L,187110L,3008148L,53275365L,1028142830L,21426984722L,478684639524L,11394222257054L,287518726261900L,7658231720886900L,214521099685649640L,6299407928673657135L,BigInteger.Parse("193373975592937777770"),BigInteger.Parse("6189939300880260745050"),BigInteger.Parse("206159811915115686404700") };
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
public class A276961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276961Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276961.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276961.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276961Inst Instance=new A276961Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276962
{
public static readonly long[] Value={ 20L,62L,84L,368L,410L,614L,720L,740L,762L,1230L,1280L,1988L,1998L,2064L,2100L,2268L,2312L,2468L,2678L,2940L,3002L,3324L,3392L,3462L,3768L,3848L,3968L,4178L,4244L,4680L,4968L,5022L,5024L,5198L,5304L,5382L,5624L,5822L,5850L,6048L,6248L,6338L,6354L,6398L,6428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276962Inst : IEnumerable<long>
{
public static readonly long[] Value=A276962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276962.Bytes);
public long this[int i]=>Value[i];

public static A276962Inst Instance=new A276962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276963
{
public static readonly long[] Value={ 65L,544L,1776L,12240L,13920L,54960L,46800L,149520L,427440L,216240L,950640L,951600L,593040L,1460880L,3010800L,4226880L,1728480L,6305280L,5260560L,2986560L,10551840L,8508240L,15283920L,25787040L,15531120L,8490480L,18528720L,10078560L,21889200L,97097280L,34355280L,57775440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276963Inst : IEnumerable<long>
{
public static readonly long[] Value=A276963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276963.Bytes);
public long this[int i]=>Value[i];

public static A276963Inst Instance=new A276963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276980
{
public static readonly long[] Value={ 273L,1729L,2109L,2255L,4433L,4641L,4697L,5673L,6643L,6935L,7667L,8103L,8729L,10235L,11543L,14497L,16385L,16523L,17507L,18915L,20033L,22649L,23579L,26691L,29309L,29393L,34799L,35853L,35929L,37209L,37829L,39277L,42653L,45551L,55699L,56163L,68735L,68901L,69167L,69977L,70993L,73505L,75361L,76373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276980Inst : IEnumerable<long>
{
public static readonly long[] Value=A276980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276980.Bytes);
public long this[int i]=>Value[i];

public static A276980Inst Instance=new A276980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276981
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,2L,0L,1L,0L,1L,4L,1L,3L,2L,6L,4L,5L,1L,2L,4L,0L,1L,1L,0L,1L,10L,1L,10L,4L,1L,10L,9L,12L,3L,4L,1L,10L,2L,6L,4L,12L,8L,1L,10L,1L,10L,4L,8L,0L,1L,10L,15L,14L,4L,6L,9L,5L,16L,7L,2L,3L,13L,11L,8L,12L,1L,10L,1L,10L,5L,12L,6L,3L,11L,15L,17L,18L,9L,14L,7L,13L,16L,8L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276981Inst : IEnumerable<long>
{
public static readonly long[] Value=A276981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276981.Bytes);
public long this[int i]=>Value[i];

public static A276981Inst Instance=new A276981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276982
{
public static readonly long[] Value={ 4L,6L,8L,10L,10L,10L,7L,19L,18L,16L,19L,17L,16L,11L,20L,19L,21L,22L,21L,19L,30L,21L,22L,23L,30L,22L,30L,30L,30L,7L,24L,27L,23L,28L,24L,29L,45L,25L,29L,20L,53L,28L,50L,45L,50L,30L,24L,25L,48L,25L,45L,40L,45L,26L,53L,48L,53L,45L,50L,45L,10L,27L,26L,32L,24L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276982Inst : IEnumerable<long>
{
public static readonly long[] Value=A276982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276982.Bytes);
public long this[int i]=>Value[i];

public static A276982Inst Instance=new A276982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276983
{
public static readonly long[] Value={ 4L,6L,10L,14L,22L,38L,46L,58L,62L,74L,82L,106L,158L,166L,178L,194L,226L,262L,278L,314L,346L,358L,382L,398L,422L,458L,466L,478L,502L,542L,562L,586L,614L,662L,674L,718L,734L,758L,838L,862L,878L,886L,982L,998L,1018L,1094L,1154L,1186L,1202L,1214L,1238L,1282L,1306L,1318L,1322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276983Inst : IEnumerable<long>
{
public static readonly long[] Value=A276983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276983.Bytes);
public long this[int i]=>Value[i];

public static A276983Inst Instance=new A276983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276984
{
public static readonly long[] Value={ 0L,0L,4L,9L,29L,41L,90L,119L,194L,255L,384L,440L,649L,765L,980L,1155L,1495L,1654L,2108L,2324L,2811L,3185L,3794L,4050L,4874L,5351L,6110L,6664L,7713L,8155L,9454L,10075L,11309L,12235L,13610L,14295L,16205L,17209L,18840L,19930L,22139L,23085L,25584L,26808L,29029L,30861L,33510L,34614L,37974L,39670L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276984Inst : IEnumerable<long>
{
public static readonly long[] Value=A276984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276984.Bytes);
public long this[int i]=>Value[i];

public static A276984Inst Instance=new A276984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276985
{
public static readonly long[] Value={ 2L,4L,4L,6L,12L,8L,8L,24L,32L,16L,10L,40L,80L,80L,32L,12L,60L,160L,240L,192L,64L,14L,84L,280L,560L,672L,448L,128L,16L,112L,448L,1120L,1792L,1792L,1024L,256L,18L,144L,672L,2016L,4032L,5376L,4608L,2304L,512L,20L,180L,960L,3360L,8064L,13440L,15360L,11520L,5120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276985Inst : IEnumerable<long>
{
public static readonly long[] Value=A276985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276985.Bytes);
public long this[int i]=>Value[i];

public static A276985Inst Instance=new A276985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276986
{
public static readonly long[] Value={ 0L,1L,3L,4L,9L,10L,12L,13L,28L,29L,31L,32L,37L,38L,40L,41L,90L,91L,93L,94L,99L,100L,102L,103L,118L,119L,121L,122L,127L,128L,130L,131L,297L,298L,300L,301L,306L,307L,309L,310L,325L,326L,328L,329L,334L,335L,337L,338L,387L,388L,390L,391L,396L,397L,399L,400L,415L,416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276986Inst : IEnumerable<long>
{
public static readonly long[] Value=A276986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276986.Bytes);
public long this[int i]=>Value[i];

public static A276986Inst Instance=new A276986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276987
{
public static readonly long[] Value={ 1L,2L,0L,8L,0L,1L,9L,2L,1L,8L,6L,1L,7L,0L,6L,1L,2L,9L,4L,2L,3L,7L,2L,3L,1L,5L,6L,9L,8L,8L,7L,9L,2L,0L,5L,6L,3L,0L,4L,3L,9L,9L,2L,5L,1L,6L,7L,9L,4L,0L,6L,9L,1L,3L,6L,6L,9L,7L,9L,2L,1L,5L,6L,9L,6L,2L,0L,8L,1L,0L,2L,1L,2L,3L,5L,7L,9L,0L,2L,4L,8L,8L,8L,7L,3L,9L,5L,1L,8L,4L,5L,5L,1L,1L,7L,8L,9L,7L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276987Inst : IEnumerable<long>
{
public static readonly long[] Value=A276987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276987.Bytes);
public long this[int i]=>Value[i];

public static A276987Inst Instance=new A276987Inst();

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