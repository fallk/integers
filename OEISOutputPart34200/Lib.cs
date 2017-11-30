using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A010309
{
public static readonly long[] Value={ 4L,3L,16L,1L,1L,5L,1L,1L,2L,16L,2L,1L,3L,3L,2L,1L,6L,2L,12L,1L,1L,1L,2L,4L,3L,2L,14L,3L,3L,2L,1L,2L,1L,11L,3L,21L,1L,1L,1L,1L,2L,6L,1L,1L,3L,1L,3L,12L,1L,1L,1L,3L,2L,3L,1L,1L,10L,3L,3L,1L,3L,26L,1L,45L,1L,2L,2L,2L,25L,1L,1L,9L,4L,11L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010309Inst : IEnumerable<long>
{
public static readonly long[] Value=A010309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010309.Bytes);
public long this[int i]=>Value[i];

public static A010309Inst Instance=new A010309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010308
{
public static readonly long[] Value={ 4L,3L,4L,4L,1L,3L,1L,9L,1L,5L,1L,4L,115L,2L,4L,8L,3L,3L,4L,1L,1L,2L,1L,2L,1L,1L,3L,1L,5L,1L,9L,3L,4L,1L,2002L,1L,1L,2L,1L,2L,1L,1L,4L,2L,7L,1L,6L,55L,1L,3L,1L,10L,2L,5L,1L,1L,4L,4L,9L,30L,1L,51L,4L,1L,17L,60L,1L,8L,1L,1L,1L,4L,1L,7L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010308Inst : IEnumerable<long>
{
public static readonly long[] Value=A010308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010308.Bytes);
public long this[int i]=>Value[i];

public static A010308Inst Instance=new A010308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010307
{
public static readonly long[] Value={ 4L,3L,2L,3L,1L,1L,4L,3L,1L,76L,1L,1L,40L,7L,1L,2L,14L,3L,1L,5L,1L,1L,21L,7L,1L,2L,1L,5L,1L,11L,1L,3L,1L,1L,1L,7L,5L,1L,10L,9L,1L,2L,1L,3L,1L,3L,1L,145L,1L,3L,38L,2L,2L,4L,1L,1L,1L,1L,2L,40L,1L,1L,1L,6L,2L,2L,2L,5L,2L,1L,1L,5L,1L,24L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010307Inst : IEnumerable<long>
{
public static readonly long[] Value=A010307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010307.Bytes);
public long this[int i]=>Value[i];

public static A010307Inst Instance=new A010307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010306
{
public static readonly long[] Value={ 4L,3L,1L,2L,120L,7L,1L,45L,3L,2L,6L,1L,4L,149L,1L,1L,1L,9L,2L,4L,2L,2L,23L,2L,1L,1L,1L,5L,49L,4L,1L,3L,1L,2L,1L,3L,1L,1L,1L,5L,1L,1L,9L,1L,4L,2L,3L,2L,2L,1L,2L,1L,12L,1L,2L,79L,5L,22L,3L,1L,12L,2L,14L,1L,6L,8L,1L,2L,1L,1L,2L,1L,1L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010306Inst : IEnumerable<long>
{
public static readonly long[] Value=A010306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010306.Bytes);
public long this[int i]=>Value[i];

public static A010306Inst Instance=new A010306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010305
{
public static readonly long[] Value={ 4L,3L,1L,13L,1L,2L,1L,1L,49L,5L,1L,1L,3L,4L,1L,8L,3L,9L,7L,1L,7L,1L,6L,2L,1L,1L,7L,131L,1L,3L,5L,5L,11L,1L,1L,12L,4L,9L,1L,37L,7L,1L,1L,3L,1L,2L,2L,1L,7L,2L,4L,2L,1L,10L,12L,1L,1L,1L,8L,424L,7L,2L,1L,1L,1L,3L,1L,1L,1L,4L,2L,2L,1L,2L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010305Inst : IEnumerable<long>
{
public static readonly long[] Value=A010305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010305.Bytes);
public long this[int i]=>Value[i];

public static A010305Inst Instance=new A010305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010304
{
public static readonly long[] Value={ 4L,4L,4L,6L,3L,2L,1L,426L,2L,4L,1L,17L,23L,2L,2L,43L,1L,1L,2L,1L,1L,1L,1L,1L,7L,19L,3L,2L,3L,1L,2L,4L,15L,1L,1L,4L,1L,1L,4L,1L,12L,3L,1L,1L,4L,8L,1L,385L,2L,3L,3L,1L,1L,1L,2L,2L,2L,4L,2L,1L,3L,8L,1L,7L,1L,11L,1L,5L,11L,5L,1L,66L,6L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010304Inst : IEnumerable<long>
{
public static readonly long[] Value=A010304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010304.Bytes);
public long this[int i]=>Value[i];

public static A010304Inst Instance=new A010304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010303
{
public static readonly long[] Value={ 4L,4L,1L,1L,1L,1L,7L,1L,2L,6L,2L,2L,10L,2L,3L,2L,1L,1L,3L,1L,2L,1L,41L,1L,2L,3L,1L,1L,4L,1L,2L,1L,2L,5L,1L,17L,3L,1L,1L,112L,6L,3L,1L,3L,11L,7L,1L,4L,9L,1L,1L,1L,2L,8L,2L,1L,1L,3L,1L,1L,2L,2L,1L,24L,1L,2L,71L,2L,3L,1L,1L,2L,2L,3L,9L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010303Inst : IEnumerable<long>
{
public static readonly long[] Value=A010303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010303.Bytes);
public long this[int i]=>Value[i];

public static A010303Inst Instance=new A010303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010302
{
public static readonly long[] Value={ 4L,5L,23L,1L,5L,2L,4L,1L,3L,19L,1L,3L,2L,6L,3L,1L,17L,1L,1L,1L,4L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,3L,7L,1L,6L,4L,9L,2L,2L,3L,1L,2L,1L,1L,1L,1L,1L,1L,1L,13L,1L,5L,47L,1L,1L,1L,1L,1L,1L,1L,12L,2L,4L,2L,22L,2L,62L,7L,1L,1L,1L,1L,2L,4L,10L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010302Inst : IEnumerable<long>
{
public static readonly long[] Value=A010302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010302.Bytes);
public long this[int i]=>Value[i];

public static A010302Inst Instance=new A010302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010301
{
public static readonly long[] Value={ 4L,5L,1L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,4L,9L,1L,1L,1L,25L,4L,1L,2L,3L,1L,3L,2L,16L,5L,3L,3L,1L,2L,1L,9L,73L,4L,1L,2L,13L,9L,72L,3L,50L,1L,4L,8L,1L,1L,1L,3L,2L,8L,2L,4L,1L,1L,14L,1L,2L,1L,1L,1L,19L,12L,3L,2L,1L,2L,1L,1L,1L,3L,1L,3L,16L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010301Inst : IEnumerable<long>
{
public static readonly long[] Value=A010301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010301.Bytes);
public long this[int i]=>Value[i];

public static A010301Inst Instance=new A010301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010300
{
public static readonly long[] Value={ 4L,6L,4L,9L,3L,3L,2L,3L,1L,11L,1L,20L,2L,1L,9L,2L,1L,4L,6L,6L,1L,2L,1L,1L,6L,2L,4L,2L,2L,2L,1L,1L,24L,1L,3L,1L,10L,1L,2L,14L,1L,1L,4L,1L,2L,1L,11L,4L,3L,9L,1L,1L,1L,1L,19L,1L,1L,5L,1L,3L,93L,12L,1L,2L,2L,2L,3L,2L,8L,3L,1L,11L,2L,1L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010300Inst : IEnumerable<long>
{
public static readonly long[] Value=A010300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010300.Bytes);
public long this[int i]=>Value[i];

public static A010300Inst Instance=new A010300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010299
{
public static readonly long[] Value={ 4L,7L,9L,1L,6L,2L,1L,3L,1L,1L,2L,4L,7L,1L,5L,9L,1L,1L,1L,1L,1L,1L,2L,21L,1L,18L,1L,2L,4L,8L,7L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,24L,1L,21L,1L,9L,7L,1L,8L,104L,1L,1L,14L,6L,2L,2L,13L,1L,11L,2L,2L,29L,1L,1L,3L,4L,1L,1L,23L,112L,9L,1L,8L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010299Inst : IEnumerable<long>
{
public static readonly long[] Value=A010299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010299.Bytes);
public long this[int i]=>Value[i];

public static A010299Inst Instance=new A010299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010298
{
public static readonly long[] Value={ 4L,8L,4L,12L,3L,3L,1L,2L,1L,1L,1L,16L,10L,7L,2L,2L,2L,1L,1L,1L,1L,4L,1L,2L,7L,7L,1L,1L,9L,1L,10L,2L,1L,1L,59L,6L,9L,2L,2L,5L,1L,1L,2L,3L,1L,2L,1L,2L,1L,1L,1L,3L,2L,2L,12L,9L,1L,1L,2L,1L,1L,5L,2L,11L,7L,2L,1L,1L,2L,1L,3L,5L,2L,2L,2L,2L,14L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010298Inst : IEnumerable<long>
{
public static readonly long[] Value=A010298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010298.Bytes);
public long this[int i]=>Value[i];

public static A010298Inst Instance=new A010298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010297
{
public static readonly long[] Value={ 4L,9L,1L,5L,2L,17L,2L,1L,61L,1L,3L,3L,1L,1L,2L,14L,12L,1L,60L,14L,3L,82L,2L,12L,1L,2L,1L,8L,1L,11L,1L,2L,10L,1L,1L,1L,1L,2L,1L,2L,2L,8L,2L,1L,13L,3L,3L,2L,7L,1L,14L,2L,2L,1L,6L,6L,1L,9L,5L,4L,1L,2L,2L,1L,1L,2L,2L,1L,25L,1L,2L,1L,8L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010297Inst : IEnumerable<long>
{
public static readonly long[] Value=A010297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010297.Bytes);
public long this[int i]=>Value[i];

public static A010297Inst Instance=new A010297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010296
{
public static readonly long[] Value={ 4L,12L,4L,18L,3L,4L,15L,24L,1L,2L,17L,1L,2L,28L,2L,3L,1L,7L,8L,3L,1L,2L,2L,2L,1L,1L,4L,4L,1L,1L,32L,1L,2L,121L,1L,1L,4L,3L,5L,7L,4L,2L,1L,1L,1L,11L,1L,1L,1L,2L,5L,1L,1L,1L,4L,1L,2L,1L,1L,20L,1L,5L,3L,3L,1L,1L,1L,1L,2L,22L,1L,2L,11L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010296Inst : IEnumerable<long>
{
public static readonly long[] Value=A010296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010296.Bytes);
public long this[int i]=>Value[i];

public static A010296Inst Instance=new A010296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010295
{
public static readonly long[] Value={ 4L,16L,4L,24L,3L,4L,3L,1L,4L,32L,1L,1L,7L,2L,6L,1L,13L,1L,2L,5L,1L,5L,1L,2L,7L,1L,11L,2L,7L,1L,10L,4L,1L,2L,4L,1L,4L,1L,1L,4L,4L,1L,3L,1L,5L,1L,8L,16L,4L,35L,1L,1L,1L,1L,1L,1L,1L,11L,1L,3L,1L,1L,2L,1L,2L,1L,3L,9L,8L,1L,1L,1L,4L,9L,1L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010295Inst : IEnumerable<long>
{
public static readonly long[] Value=A010295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010295.Bytes);
public long this[int i]=>Value[i];

public static A010295Inst Instance=new A010295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010294
{
public static readonly long[] Value={ 4L,24L,4L,36L,3L,4L,2L,12L,1L,47L,1L,4L,1L,1L,24L,79L,5L,1L,13L,1L,1L,1L,1L,2L,2L,2L,1L,58L,1L,1L,48L,2L,8L,9L,2L,1L,1L,6L,10L,1L,2L,2L,2L,1L,4L,2L,1L,5L,1L,6L,2L,1L,15L,2L,2L,61L,1L,1L,2L,1L,8L,3L,1L,2L,10L,6L,1L,10L,1L,1L,3L,26L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010294Inst : IEnumerable<long>
{
public static readonly long[] Value=A010294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010294.Bytes);
public long this[int i]=>Value[i];

public static A010294Inst Instance=new A010294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010293
{
public static readonly long[] Value={ 4L,48L,4L,72L,3L,4L,1L,2L,1L,1L,1L,3L,1L,95L,1L,25L,1L,8L,1L,1L,2L,4L,9L,1L,1L,1L,6L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,6L,6L,1L,1L,1L,3L,1L,2L,1L,1L,2L,4L,5L,1L,1L,4L,5L,1L,2L,8L,2L,1L,1L,1L,1L,1L,3L,1L,13L,1L,1L,1L,12L,1L,7L,2L,1L,1L,19L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010293Inst : IEnumerable<long>
{
public static readonly long[] Value=A010293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010293.Bytes);
public long this[int i]=>Value[i];

public static A010293Inst Instance=new A010293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010292
{
public static readonly long[] Value={ 3L,1L,46L,1L,2L,1L,70L,1L,2L,5L,3L,4L,1L,2L,94L,1L,8L,4L,1L,6L,1L,1L,1L,7L,3L,3L,1L,3L,1L,1L,2L,2L,5L,1L,2L,4L,1L,4L,1L,1L,6L,1L,77L,1L,1L,2L,1L,4L,1L,2L,2L,1L,4L,1L,2L,64L,1L,1L,9L,6L,10L,1L,6L,1L,1L,2L,1L,1L,3L,1L,1L,2L,53L,1L,2L,24L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010292Inst : IEnumerable<long>
{
public static readonly long[] Value=A010292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010292.Bytes);
public long this[int i]=>Value[i];

public static A010292Inst Instance=new A010292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010291
{
public static readonly long[] Value={ 3L,1L,22L,1L,2L,1L,34L,1L,2L,5L,1L,2L,2314L,1L,1L,1L,1L,13L,3L,43L,3L,1L,1L,1L,5L,2L,1L,24L,1L,7L,1L,1L,4L,1L,4L,2L,5L,1L,2L,1L,4L,8L,1L,1L,1L,1L,3L,1L,3L,2L,1L,9L,1L,24163L,1L,1L,3L,16L,4L,8L,1L,1L,7L,1L,3L,2L,23L,3L,1L,1L,1L,6L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010291Inst : IEnumerable<long>
{
public static readonly long[] Value=A010291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010291.Bytes);
public long this[int i]=>Value[i];

public static A010291Inst Instance=new A010291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010290
{
public static readonly long[] Value={ 3L,1L,14L,1L,2L,1L,22L,1L,2L,6L,12L,1L,30L,3L,6L,2L,2L,1L,3L,19L,8L,1L,10L,5L,4L,3L,2L,6L,30L,2L,17L,9L,1L,5L,1L,1L,9L,4L,3L,6L,4L,1L,6L,3L,18L,1L,1L,3L,2L,1L,1L,1L,8L,19L,2L,1L,1L,2L,1L,18L,1L,5L,1L,1L,2L,1L,2L,1L,7L,1L,1L,6L,1L,5L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010290Inst : IEnumerable<long>
{
public static readonly long[] Value=A010290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010290.Bytes);
public long this[int i]=>Value[i];

public static A010290Inst Instance=new A010290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010289
{
public static readonly long[] Value={ 3L,1L,10L,1L,2L,1L,16L,1L,2L,6L,1L,1L,3L,1L,22L,2L,5L,2L,11L,22L,1L,9L,4L,3L,2L,2L,4L,7L,1L,2L,1L,1L,2L,1L,1L,2L,1L,12L,2L,3L,1L,5L,2L,1L,1L,4L,2L,214L,1L,3L,24L,1L,1L,1L,7L,1L,13L,6L,1L,9L,2L,2L,8L,1L,4L,1L,4L,2L,1L,50L,9L,1L,2L,1L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010289Inst : IEnumerable<long>
{
public static readonly long[] Value=A010289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010289.Bytes);
public long this[int i]=>Value[i];

public static A010289Inst Instance=new A010289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010288
{
public static readonly long[] Value={ 3L,1L,8L,2L,1L,8L,2L,11L,1L,6L,8L,2L,10L,2L,1L,2L,2L,3L,2L,4L,3L,10L,3L,13L,1L,2L,1L,1L,3L,1L,1L,7L,1L,2L,1L,12L,1L,1L,1L,1L,2L,1L,4L,3L,4L,1L,1L,1L,10L,1L,13L,3L,5L,1L,5L,1L,1L,1L,1L,5L,4L,4L,1L,1L,4L,2L,3L,6L,1L,3L,30L,1L,11L,3L,1L,10L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010288Inst : IEnumerable<long>
{
public static readonly long[] Value=A010288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010288.Bytes);
public long this[int i]=>Value[i];

public static A010288Inst Instance=new A010288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010287
{
public static readonly long[] Value={ 3L,1L,6L,1L,2L,1L,10L,1L,2L,7L,1L,4L,15L,37L,1L,6L,1L,2L,2L,1L,2L,8L,10L,39L,75L,1L,2L,2L,1L,1L,2L,1L,10L,18L,1L,4L,3L,2L,1L,2L,1L,2L,1L,5L,1L,4L,1L,1L,3L,181L,1L,2L,1L,5L,11L,2L,16L,1L,2L,1L,2L,3L,1L,1L,1L,3L,3L,1L,1L,15L,3L,8L,3L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010287Inst : IEnumerable<long>
{
public static readonly long[] Value=A010287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010287.Bytes);
public long this[int i]=>Value[i];

public static A010287Inst Instance=new A010287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010286
{
public static readonly long[] Value={ 3L,1L,5L,1L,1L,1L,1L,55L,1L,3L,1L,2L,1L,13L,1L,3L,1L,1L,2L,4L,1L,1L,3L,2L,1L,2L,1L,1L,1L,4L,2L,1L,6L,1L,1L,6L,1L,5L,1L,1L,1L,2L,4L,27L,7L,1L,9L,1L,1L,2L,2L,2L,2L,1L,2L,4L,10L,1L,1L,9L,9L,1L,2L,3L,1L,1L,23L,6L,8L,18L,1L,2L,1L,1L,1L,1L,24L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010286Inst : IEnumerable<long>
{
public static readonly long[] Value=A010286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010286.Bytes);
public long this[int i]=>Value[i];

public static A010286Inst Instance=new A010286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010269
{
public static readonly long[] Value={ 3L,2L,2L,1L,1L,1L,1L,1L,7L,1L,2L,3L,1L,1L,1L,1L,4L,1L,1L,8L,2L,7L,3L,1L,1525L,1L,4L,4L,2L,2L,7L,1L,2L,6L,1L,1L,2L,3L,27L,1L,83L,1L,1L,1L,1L,5L,1L,11L,1L,15L,7L,16L,1L,2L,4L,4L,1L,1L,4L,1L,2L,7L,1L,1L,5L,1L,1L,3L,1L,1L,4L,1L,1L,23L,1L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010269Inst : IEnumerable<long>
{
public static readonly long[] Value=A010269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010269.Bytes);
public long this[int i]=>Value[i];

public static A010269Inst Instance=new A010269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010268
{
public static readonly long[] Value={ 3L,2L,1L,1L,3L,1L,19L,1L,1L,3L,2L,1L,2L,1L,2L,3L,1L,1L,29L,1L,21L,1L,1L,1L,3L,9L,2L,2L,3L,2L,4L,4L,1L,5L,4L,1L,39L,1L,7L,1L,6L,1L,173L,3L,4L,7L,1L,1L,6L,2L,3L,1L,1L,2L,9L,1L,6L,1L,1L,79L,1L,7L,1L,24L,2L,1L,2L,1L,1L,1L,7L,5L,1L,2L,4L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010268Inst : IEnumerable<long>
{
public static readonly long[] Value=A010268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010268.Bytes);
public long this[int i]=>Value[i];

public static A010268Inst Instance=new A010268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010267
{
public static readonly long[] Value={ 3L,2L,1L,3L,4L,1L,2L,2L,1L,2L,1L,1L,1L,3L,13L,2L,3L,1L,4L,1L,1L,1L,572L,1L,1L,1L,1L,10L,1L,1L,2L,1L,9L,1L,1L,1L,1L,1L,1L,2L,1L,1L,74L,4L,2L,1L,11L,2L,1L,2L,1L,2L,1L,6L,2L,1L,1L,1L,1L,1L,1L,3L,9L,1L,1L,8L,1L,1L,6L,6L,1L,1L,161L,1L,2L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010267Inst : IEnumerable<long>
{
public static readonly long[] Value=A010267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010267.Bytes);
public long this[int i]=>Value[i];

public static A010267Inst Instance=new A010267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010266
{
public static readonly long[] Value={ 3L,3L,99L,1L,1L,1L,2L,1L,1L,1L,149L,3L,2L,3L,178L,5L,3L,1L,199L,7L,4L,7L,1L,1L,1L,1L,14L,4L,2L,1L,2L,1L,1L,5L,5L,2L,64L,1L,2L,1L,3L,7L,1L,4L,2L,4L,16L,4L,1L,1L,2L,3L,5L,2L,6L,1L,1L,6L,1L,5L,5L,2L,6L,4L,1L,25L,9L,4L,1L,2L,19L,1L,1L,32L,1L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010266Inst : IEnumerable<long>
{
public static readonly long[] Value=A010266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010266.Bytes);
public long this[int i]=>Value[i];

public static A010266Inst Instance=new A010266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010265
{
public static readonly long[] Value={ 3L,3L,3L,4L,1L,7L,1L,83L,1L,36L,15L,3L,2L,3L,1L,3L,2L,2L,4L,1L,1L,4L,1L,1L,5L,1L,1L,1L,5L,1L,25L,1L,1L,9L,2L,1L,1L,8L,3L,1L,1L,1L,2L,6L,3L,2L,14L,1L,1L,2L,11L,2L,1L,4L,1L,4L,1L,3L,1L,1L,2L,1L,1L,1L,11L,1L,1L,1L,1L,15L,9L,1L,1L,20L,2L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010265Inst : IEnumerable<long>
{
public static readonly long[] Value=A010265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010265.Bytes);
public long this[int i]=>Value[i];

public static A010265Inst Instance=new A010265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010264
{
public static readonly long[] Value={ 3L,3L,1L,2L,4L,1L,1L,1L,1L,2L,1L,2L,2L,46L,13L,4L,6L,1L,11L,4L,2L,1L,1L,2L,4L,1L,1L,11L,46L,1L,9L,8L,4L,1L,3L,52L,1L,13L,5L,1L,1L,1L,2L,3L,1L,1L,14L,1L,11L,11L,7L,3L,3L,13L,1L,16L,1L,7L,1L,3L,3L,1L,1L,1L,23L,4L,1L,1L,7L,1L,1L,12L,184L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010264Inst : IEnumerable<long>
{
public static readonly long[] Value=A010264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010264.Bytes);
public long this[int i]=>Value[i];

public static A010264Inst Instance=new A010264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010263
{
public static readonly long[] Value={ 3L,4L,5L,1L,3L,3L,1L,1L,4L,2L,1L,1L,3L,6L,1L,1L,3L,1L,1L,20L,1L,4L,2L,1L,1L,4L,1L,160L,1L,1L,1L,1L,1L,2L,8L,1L,1L,1L,2L,1L,1L,2L,14L,4L,4L,2L,5L,2L,1L,2L,1L,1L,2L,1L,2L,26L,2L,42L,6L,2L,3L,5L,1L,2L,2L,158L,1L,2L,109L,4L,2L,2L,1L,41L,1L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010263Inst : IEnumerable<long>
{
public static readonly long[] Value=A010263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010263.Bytes);
public long this[int i]=>Value[i];

public static A010263Inst Instance=new A010263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010262
{
public static readonly long[] Value={ 3L,4L,1L,4L,1L,1L,27L,5L,1L,1L,2L,2L,1L,3L,2L,1L,1L,6L,3L,1L,1L,1L,1L,50L,6L,3L,1L,5L,1L,3L,3L,1L,4L,1L,19L,1L,5L,1L,4L,17L,1L,4L,1L,3L,2L,1L,4L,5L,1L,8L,1L,1L,1L,1L,3L,1L,2L,1L,10L,6L,1L,2L,1L,6L,5L,1L,1L,13L,7L,2L,2L,9L,1L,1L,30L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010262Inst : IEnumerable<long>
{
public static readonly long[] Value=A010262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010262.Bytes);
public long this[int i]=>Value[i];

public static A010262Inst Instance=new A010262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010261
{
public static readonly long[] Value={ 3L,5L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,62L,1L,1L,1L,5L,4L,1L,1L,2L,1L,1L,1L,1L,3L,1L,14L,1L,6L,1L,2L,3L,3L,52L,1L,3L,15L,4L,1L,132L,1L,7L,1L,2L,1L,1L,1L,29L,1L,12L,1L,3L,1L,1L,2L,13L,1L,1L,1L,1L,9L,1L,10L,30L,1L,1L,1L,1L,1L,1L,4L,15L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010261Inst : IEnumerable<long>
{
public static readonly long[] Value=A010261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010261.Bytes);
public long this[int i]=>Value[i];

public static A010261Inst Instance=new A010261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010260
{
public static readonly long[] Value={ 3L,7L,13L,1L,2L,8L,1L,1L,12L,1L,7L,1L,4L,237L,1L,372L,1L,1L,1L,3L,2L,1L,3L,4L,3L,4L,4L,1L,1L,2L,1L,1L,279L,3L,6L,2L,15L,9L,1L,2L,2L,9L,17L,2L,2L,3L,5L,1L,1L,1L,9L,2L,2L,2L,1L,4L,3L,1L,4L,5L,2L,18L,1L,1L,2L,7L,1L,2L,2L,2L,2L,1L,3L,1L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010260Inst : IEnumerable<long>
{
public static readonly long[] Value=A010260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010260.Bytes);
public long this[int i]=>Value[i];

public static A010260Inst Instance=new A010260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010259
{
public static readonly long[] Value={ 3L,9L,3L,13L,1L,9L,1L,2L,5L,4L,1L,1L,3L,1L,18L,3L,2L,4L,5L,3L,4L,1L,2L,2L,22L,1L,3L,1L,3L,79L,6L,5L,1L,1L,10L,1L,1L,1L,26L,1L,4L,2L,2L,19L,26L,1L,3L,12L,27L,1L,1L,1L,19L,1L,1L,1L,7L,1L,4L,3L,1L,2L,5L,1L,1L,26L,1L,1L,1L,2L,10L,1L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010259Inst : IEnumerable<long>
{
public static readonly long[] Value=A010259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010259.Bytes);
public long this[int i]=>Value[i];

public static A010259Inst Instance=new A010259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010258
{
public static readonly long[] Value={ 3L,13L,1L,4L,1L,4L,2L,2L,2L,3L,1L,1L,2L,1L,1L,4L,1L,3L,2L,3L,8L,7L,2L,2L,1L,2L,8L,1L,3L,12L,1L,2L,3L,1L,11L,1L,2L,1L,1L,170L,2L,1L,4L,1L,3L,2L,11L,1L,2L,1L,2L,2L,3L,5L,3L,53L,2L,10L,6L,1L,2L,5L,3L,2L,3L,2L,1L,3L,2L,12L,13L,5L,6L,4L,2L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010258Inst : IEnumerable<long>
{
public static readonly long[] Value=A010258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010258.Bytes);
public long this[int i]=>Value[i];

public static A010258Inst Instance=new A010258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010257
{
public static readonly long[] Value={ 3L,27L,3L,40L,1L,10L,1L,1L,21L,13L,1L,2L,2L,1L,7L,2L,2L,63L,1L,1L,2L,1L,5L,3L,3L,1L,1L,1L,11L,4L,1L,1L,1L,1L,4L,1L,1L,1L,3L,1L,1L,1L,3L,2L,1L,1L,2L,3L,5L,124L,17L,2L,1L,41L,4L,47L,1L,2L,1L,5L,1L,8L,1L,1L,32L,1L,4L,1L,6L,4L,2L,4L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010257Inst : IEnumerable<long>
{
public static readonly long[] Value=A010257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010257.Bytes);
public long this[int i]=>Value[i];

public static A010257Inst Instance=new A010257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010256
{
public static readonly long[] Value={ 2L,1L,25L,1L,1L,1L,39L,12L,1L,1L,4L,4L,13L,93L,3L,17L,3L,1L,85L,1L,3L,5L,1L,1L,8L,1L,6L,1L,2L,1L,1L,3L,67L,20L,52L,1L,1L,1L,3L,1L,3L,5L,3L,18L,13L,1L,2L,1L,2L,8L,5L,23L,3L,4L,2L,1L,22L,2L,13L,3L,1L,1L,1L,10L,4L,1L,3L,6L,1L,1L,2L,95L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010256Inst : IEnumerable<long>
{
public static readonly long[] Value=A010256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010256.Bytes);
public long this[int i]=>Value[i];

public static A010256Inst Instance=new A010256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010255
{
public static readonly long[] Value={ 2L,1L,12L,6L,4L,1L,2L,2L,2L,5L,1L,1L,4L,1L,2L,1L,3L,1L,2L,3L,3L,610L,3L,10L,1L,14L,1L,5L,1L,1L,2L,4L,4L,70L,2L,7L,1L,24L,2L,1L,1L,3L,8L,2L,2L,2L,167L,1L,10L,5L,16L,1L,2L,4L,1L,1L,1L,1L,1L,1L,1L,50L,9L,1L,2L,1L,9L,1L,1L,3L,1L,1L,94L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010255Inst : IEnumerable<long>
{
public static readonly long[] Value=A010255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010255.Bytes);
public long this[int i]=>Value[i];

public static A010255Inst Instance=new A010255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010254
{
public static readonly long[] Value={ 2L,1L,7L,1L,1L,1L,12L,13L,1L,10L,4L,6L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,7L,1L,6L,2L,2L,2L,19L,1L,3L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,2L,1L,14L,1L,1L,3L,3L,6L,7L,1L,1L,3L,1L,1L,1L,14L,1L,2L,2L,1L,2L,1L,1L,1L,1L,22L,4L,2L,69L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010254Inst : IEnumerable<long>
{
public static readonly long[] Value=A010254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010254.Bytes);
public long this[int i]=>Value[i];

public static A010254Inst Instance=new A010254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010253
{
public static readonly long[] Value={ 2L,1L,5L,2L,2L,7L,1L,16L,4L,1L,8L,10L,7L,1L,4L,5L,1L,2L,2L,3L,1L,1L,1L,1L,3L,7L,1L,12L,1L,1L,1L,4L,19L,18L,3L,1L,4L,3L,6L,1L,3L,17L,1L,2L,1L,1L,1L,1L,1L,8L,81L,5L,13L,1L,2L,2L,8L,1L,3L,6L,6L,2L,2L,5L,1L,1L,3L,1L,1L,1L,43L,91L,3L,4L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010253Inst : IEnumerable<long>
{
public static readonly long[] Value=A010253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010253.Bytes);
public long this[int i]=>Value[i];

public static A010253Inst Instance=new A010253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010252
{
public static readonly long[] Value={ 2L,1L,4L,19L,2L,2L,2L,2L,2L,29L,56L,35L,49L,39L,4L,2L,56L,1L,97L,2L,11L,1L,5L,1L,2L,1L,1L,1L,2L,1L,3L,2L,2L,1L,4L,29L,1L,2L,2L,9L,7L,2L,63L,1L,1L,3L,28L,1L,1L,3L,1L,44L,1L,2L,1L,6L,1L,1L,1L,3L,2L,1L,1L,1L,7L,3L,1L,2L,1L,2L,5L,1L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010252Inst : IEnumerable<long>
{
public static readonly long[] Value=A010252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010252.Bytes);
public long this[int i]=>Value[i];

public static A010252Inst Instance=new A010252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010251
{
public static readonly long[] Value={ 2L,1L,3L,6L,1L,3L,17L,1L,7L,3L,3L,11L,2L,92L,1L,3L,1L,3L,1L,2L,2L,26L,2L,1L,20L,1L,4L,2L,10L,43L,2L,1L,4L,2L,3L,1L,11L,2L,1L,1L,4L,1L,1L,1L,10L,1L,1L,1L,2L,1L,12L,35L,1L,1L,2L,1L,1L,5L,1L,3L,204L,4L,1L,1L,5L,2L,13L,3L,2L,5L,1L,6L,253L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010251Inst : IEnumerable<long>
{
public static readonly long[] Value=A010251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010251.Bytes);
public long this[int i]=>Value[i];

public static A010251Inst Instance=new A010251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010250
{
public static readonly long[] Value={ 2L,1L,2L,1L,1L,154L,6L,1L,1L,1L,6L,231L,1L,15L,8L,3L,1L,10L,3L,2L,1L,1L,17L,1L,2L,77L,42L,1L,4L,8L,6L,2L,5L,2L,29L,5L,1L,2L,7L,12L,3L,18L,1L,13L,1L,1L,1L,60L,1L,1L,1L,1L,1L,15L,2L,1L,6L,2L,4L,2L,8L,1L,1L,1L,7L,1L,1L,3L,1L,1L,2L,1L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010250Inst : IEnumerable<long>
{
public static readonly long[] Value=A010250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010250.Bytes);
public long this[int i]=>Value[i];

public static A010250Inst Instance=new A010250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010249
{
public static readonly long[] Value={ 2L,1L,2L,63L,1L,2L,2L,2L,1L,95L,2L,1L,1L,2L,7L,4L,2L,3L,1L,2L,3L,127L,1L,4L,1L,3L,1L,4L,4L,12L,2L,1L,1L,1L,5L,1L,18L,2L,3L,1L,1L,1L,1L,1L,2L,1L,1L,8L,1L,4L,1L,4L,8L,1L,1L,2L,1L,1L,11L,1L,12L,6L,1L,1L,3L,2L,3L,3L,1L,2L,8L,1L,3L,2L,1L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010249Inst : IEnumerable<long>
{
public static readonly long[] Value=A010249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010249.Bytes);
public long this[int i]=>Value[i];

public static A010249Inst Instance=new A010249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010248
{
public static readonly long[] Value={ 2L,1L,1L,1L,1L,1L,3L,22L,1L,2L,2L,2L,24L,64L,2L,2L,1L,2L,1L,2L,1L,4L,24L,1L,1L,1L,2L,2L,1L,16L,3L,2L,1L,2L,1L,5L,1L,3L,5L,2L,3L,1L,9L,1L,4L,1L,448L,2L,3L,26L,4L,3L,108L,1L,11L,1L,1L,2L,13L,4L,1L,2L,51L,1L,72L,1L,11L,1L,2L,7L,1L,16L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010248Inst : IEnumerable<long>
{
public static readonly long[] Value=A010248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010248.Bytes);
public long this[int i]=>Value[i];

public static A010248Inst Instance=new A010248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010247
{
public static readonly long[] Value={ 2L,1L,1L,3L,138L,1L,1L,3L,2L,3L,1L,1L,207L,1L,2L,2L,1L,1L,1L,1L,2L,4L,9L,1L,2L,4L,1L,1L,3L,4L,277L,2L,5L,3L,3L,3L,1L,1L,1L,1L,13L,2L,15L,20L,2L,1L,1L,1L,1L,1L,2L,1L,2L,18L,2L,4L,1L,22L,20L,51L,23L,2L,1L,3L,2L,204L,1L,2L,3L,1L,4L,1L,3L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010247Inst : IEnumerable<long>
{
public static readonly long[] Value=A010247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010247.Bytes);
public long this[int i]=>Value[i];

public static A010247Inst Instance=new A010247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010246
{
public static readonly long[] Value={ 2L,1L,1L,12L,10L,18L,1L,6L,1L,21L,1L,2L,2L,24L,1L,6L,1L,2L,1L,1L,1L,1L,1L,3L,1L,28L,1L,1L,1L,5L,1L,31L,1L,1L,9L,267L,3L,1L,2L,3L,1L,60L,2L,1L,4L,2L,20L,1L,1L,2L,2L,1L,20L,3L,7L,3L,1L,2L,2L,1L,4L,9L,1L,1L,14L,3L,3L,2L,2L,1L,4L,7L,139L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010246Inst : IEnumerable<long>
{
public static readonly long[] Value=A010246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010246.Bytes);
public long this[int i]=>Value[i];

public static A010246Inst Instance=new A010246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010245
{
public static readonly long[] Value={ 2L,2L,6L,1L,8L,1L,10L,8L,12L,1L,719L,4L,2L,5L,2L,2L,3L,3L,2L,1L,46L,4L,2L,11L,2L,1L,3L,11L,2L,1L,7L,1L,1L,3L,5L,1L,1L,2L,16L,1L,2L,2L,1L,3L,2L,1L,3L,1L,1L,1L,19L,10L,13L,1L,1L,1L,4L,1522L,2L,2L,11L,1L,2L,1L,9L,54L,3L,1L,8L,3L,1230L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010245Inst : IEnumerable<long>
{
public static readonly long[] Value=A010245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010245.Bytes);
public long this[int i]=>Value[i];

public static A010245Inst Instance=new A010245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010244
{
public static readonly long[] Value={ 2L,2L,2L,3L,1L,1L,5L,5L,9L,6L,21L,1L,1L,54L,1L,22L,1L,1L,3L,2L,1L,5L,3L,237L,2L,20L,1L,1L,3L,3L,9L,1L,16L,1L,1L,47L,2L,1L,7L,1L,5L,2L,2L,15L,1L,11L,1L,1L,1L,1L,1L,2L,2L,1L,4L,1L,3L,3L,2L,2L,2L,1L,9L,1L,4L,1L,7L,1L,1L,1L,13L,2L,2L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010244Inst : IEnumerable<long>
{
public static readonly long[] Value=A010244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010244.Bytes);
public long this[int i]=>Value[i];

public static A010244Inst Instance=new A010244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010243
{
public static readonly long[] Value={ 2L,2L,1L,5L,1L,1L,43L,3L,2L,1L,1L,3L,10L,7L,1L,12L,2L,20L,3L,1L,3L,9L,1L,6L,1L,1L,22L,1L,2L,2L,1L,3L,4L,2L,2L,43L,1L,1L,3L,4L,1L,22L,1L,6L,4L,1L,1L,2L,4L,11L,1L,1L,1L,42L,1L,1L,9L,1L,2L,2L,1L,1L,14L,3L,1L,195L,3L,1L,9L,2L,3L,2L,1L,55L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010243Inst : IEnumerable<long>
{
public static readonly long[] Value=A010243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010243.Bytes);
public long this[int i]=>Value[i];

public static A010243Inst Instance=new A010243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010242
{
public static readonly long[] Value={ 2L,3L,2L,5L,15L,7L,3L,1L,1L,3L,1L,1L,96L,7L,2L,6L,3L,36L,1L,17L,25L,2L,4L,9L,24L,9L,1L,3L,2L,34L,1L,73L,1L,9L,1L,1L,17L,6L,2L,163L,2L,1L,1L,1L,2L,81L,3L,1L,1L,34L,3L,11L,1L,75L,12L,2L,2L,2L,1L,1L,3L,1L,19L,4L,1L,1L,2L,3L,6L,1L,234L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010242Inst : IEnumerable<long>
{
public static readonly long[] Value=A010242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010242.Bytes);
public long this[int i]=>Value[i];

public static A010242Inst Instance=new A010242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010241
{
public static readonly long[] Value={ 2L,4L,2L,6L,1L,1L,2L,1L,2L,9L,88L,2L,1L,2L,1L,8L,1L,1L,3L,4L,1L,7L,1L,40L,1L,1L,36L,2L,3L,1L,29L,6L,3L,1L,2L,2L,5L,1L,4L,1L,10L,5L,1L,2L,1L,1L,1L,88L,4L,4L,3L,5L,3L,7L,1L,1L,17L,5L,4L,3L,4L,3L,5L,1L,5L,103L,1L,1L,1L,12L,4L,1L,1L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010241Inst : IEnumerable<long>
{
public static readonly long[] Value=A010241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010241.Bytes);
public long this[int i]=>Value[i];

public static A010241Inst Instance=new A010241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010240
{
public static readonly long[] Value={ 2L,6L,2L,9L,1L,1L,2L,4L,1L,12L,1L,1L,1L,1L,57L,4L,2L,16L,1L,1L,1L,1L,9L,6L,2L,3L,1L,1L,12L,1L,4L,6L,2L,2L,1001L,3L,2L,6L,9L,1L,15L,1L,2L,1L,1L,27L,2L,1L,1L,21L,1L,11L,9L,2L,18L,15L,2L,25L,1L,1L,1L,1L,35L,30L,2L,4L,3L,10L,1L,3L,3L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010240Inst : IEnumerable<long>
{
public static readonly long[] Value=A010240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010240.Bytes);
public long this[int i]=>Value[i];

public static A010240Inst Instance=new A010240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010239
{
public static readonly long[] Value={ 2L,12L,2L,18L,1L,1L,1L,1L,4L,1L,1L,24L,1L,9L,1L,2L,19L,1L,2L,2L,12L,3L,2L,1L,3L,1L,2L,1L,2L,1L,1L,1L,2L,2L,2L,3L,12L,2L,1L,1L,22L,2L,1L,6L,1L,3L,2L,2L,1L,2L,5L,1L,1L,1L,1L,1L,1L,19L,4L,1L,9L,3L,1L,2L,2L,1L,1L,1L,46L,25L,2L,2L,2L,1L,1L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010239Inst : IEnumerable<long>
{
public static readonly long[] Value=A010239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010239.Bytes);
public long this[int i]=>Value[i];

public static A010239Inst Instance=new A010239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010238
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,4L,4L,7L,12L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010238Inst : IEnumerable<long>
{
public static readonly long[] Value=A010238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010238.Bytes);
public long this[int i]=>Value[i];

public static A010238Inst Instance=new A010238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010205
{
public static readonly long[] Value={ 12L,2L,2L,3L,1L,2L,1L,3L,2L,2L,24L,2L,2L,3L,1L,2L,1L,3L,2L,2L,24L,2L,2L,3L,1L,2L,1L,3L,2L,2L,24L,2L,2L,3L,1L,2L,1L,3L,2L,2L,24L,2L,2L,3L,1L,2L,1L,3L,2L,2L,24L,2L,2L,3L,1L,2L,1L,3L,2L,2L,24L,2L,2L,3L,1L,2L,1L,3L,2L,2L,24L,2L,2L,3L,1L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010205Inst : IEnumerable<long>
{
public static readonly long[] Value=A010205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010205.Bytes);
public long this[int i]=>Value[i];

public static A010205Inst Instance=new A010205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010204
{
public static readonly long[] Value={ 12L,2L,1L,2L,2L,2L,1L,2L,24L,2L,1L,2L,2L,2L,1L,2L,24L,2L,1L,2L,2L,2L,1L,2L,24L,2L,1L,2L,2L,2L,1L,2L,24L,2L,1L,2L,2L,2L,1L,2L,24L,2L,1L,2L,2L,2L,1L,2L,24L,2L,1L,2L,2L,2L,1L,2L,24L,2L,1L,2L,2L,2L,1L,2L,24L,2L,1L,2L,2L,2L,1L,2L,24L,2L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010204Inst : IEnumerable<long>
{
public static readonly long[] Value=A010204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010204.Bytes);
public long this[int i]=>Value[i];

public static A010204Inst Instance=new A010204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010203
{
public static readonly long[] Value={ 12L,3L,2L,7L,1L,3L,4L,1L,1L,1L,11L,1L,1L,1L,4L,3L,1L,7L,2L,3L,24L,3L,2L,7L,1L,3L,4L,1L,1L,1L,11L,1L,1L,1L,4L,3L,1L,7L,2L,3L,24L,3L,2L,7L,1L,3L,4L,1L,1L,1L,11L,1L,1L,1L,4L,3L,1L,7L,2L,3L,24L,3L,2L,7L,1L,3L,4L,1L,1L,1L,11L,1L,1L,1L,4L,3L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010203Inst : IEnumerable<long>
{
public static readonly long[] Value=A010203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010203.Bytes);
public long this[int i]=>Value[i];

public static A010203Inst Instance=new A010203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010202
{
public static readonly long[] Value={ 12L,4L,1L,5L,3L,3L,5L,1L,4L,24L,4L,1L,5L,3L,3L,5L,1L,4L,24L,4L,1L,5L,3L,3L,5L,1L,4L,24L,4L,1L,5L,3L,3L,5L,1L,4L,24L,4L,1L,5L,3L,3L,5L,1L,4L,24L,4L,1L,5L,3L,3L,5L,1L,4L,24L,4L,1L,5L,3L,3L,5L,1L,4L,24L,4L,1L,5L,3L,3L,5L,1L,4L,24L,4L,1L,5L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010202Inst : IEnumerable<long>
{
public static readonly long[] Value=A010202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010202.Bytes);
public long this[int i]=>Value[i];

public static A010202Inst Instance=new A010202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010201
{
public static readonly long[] Value={ 11L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L,10L,1L,22L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010201Inst : IEnumerable<long>
{
public static readonly long[] Value=A010201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010201.Bytes);
public long this[int i]=>Value[i];

public static A010201Inst Instance=new A010201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010200
{
public static readonly long[] Value={ 11L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L,22L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010200Inst : IEnumerable<long>
{
public static readonly long[] Value=A010200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010200.Bytes);
public long this[int i]=>Value[i];

public static A010200Inst Instance=new A010200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010199
{
public static readonly long[] Value={ 11L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L,22L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010199Inst : IEnumerable<long>
{
public static readonly long[] Value=A010199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010199.Bytes);
public long this[int i]=>Value[i];

public static A010199Inst Instance=new A010199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010198
{
public static readonly long[] Value={ 11L,1L,3L,1L,3L,7L,1L,1L,2L,11L,2L,1L,1L,7L,3L,1L,3L,1L,22L,1L,3L,1L,3L,7L,1L,1L,2L,11L,2L,1L,1L,7L,3L,1L,3L,1L,22L,1L,3L,1L,3L,7L,1L,1L,2L,11L,2L,1L,1L,7L,3L,1L,3L,1L,22L,1L,3L,1L,3L,7L,1L,1L,2L,11L,2L,1L,1L,7L,3L,1L,3L,1L,22L,1L,3L,1L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010198Inst : IEnumerable<long>
{
public static readonly long[] Value=A010198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010198.Bytes);
public long this[int i]=>Value[i];

public static A010198Inst Instance=new A010198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010197
{
public static readonly long[] Value={ 11L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L,22L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010197Inst : IEnumerable<long>
{
public static readonly long[] Value=A010197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010197.Bytes);
public long this[int i]=>Value[i];

public static A010197Inst Instance=new A010197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010196
{
public static readonly long[] Value={ 11L,1L,2L,2L,1L,1L,2L,2L,1L,22L,1L,2L,2L,1L,1L,2L,2L,1L,22L,1L,2L,2L,1L,1L,2L,2L,1L,22L,1L,2L,2L,1L,1L,2L,2L,1L,22L,1L,2L,2L,1L,1L,2L,2L,1L,22L,1L,2L,2L,1L,1L,2L,2L,1L,22L,1L,2L,2L,1L,1L,2L,2L,1L,22L,1L,2L,2L,1L,1L,2L,2L,1L,22L,1L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010196Inst : IEnumerable<long>
{
public static readonly long[] Value=A010196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010196.Bytes);
public long this[int i]=>Value[i];

public static A010196Inst Instance=new A010196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010195
{
public static readonly long[] Value={ 11L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L,22L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010195Inst : IEnumerable<long>
{
public static readonly long[] Value=A010195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010195.Bytes);
public long this[int i]=>Value[i];

public static A010195Inst Instance=new A010195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010194
{
public static readonly long[] Value={ 11L,1L,1L,1L,1L,1L,1L,1L,22L,1L,1L,1L,1L,1L,1L,1L,22L,1L,1L,1L,1L,1L,1L,1L,22L,1L,1L,1L,1L,1L,1L,1L,22L,1L,1L,1L,1L,1L,1L,1L,22L,1L,1L,1L,1L,1L,1L,1L,22L,1L,1L,1L,1L,1L,1L,1L,22L,1L,1L,1L,1L,1L,1L,1L,22L,1L,1L,1L,1L,1L,1L,1L,22L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010194Inst : IEnumerable<long>
{
public static readonly long[] Value=A010194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010194.Bytes);
public long this[int i]=>Value[i];

public static A010194Inst Instance=new A010194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010193
{
public static readonly long[] Value={ 11L,1L,1L,2L,1L,3L,1L,10L,1L,3L,1L,2L,1L,1L,22L,1L,1L,2L,1L,3L,1L,10L,1L,3L,1L,2L,1L,1L,22L,1L,1L,2L,1L,3L,1L,10L,1L,3L,1L,2L,1L,1L,22L,1L,1L,2L,1L,3L,1L,10L,1L,3L,1L,2L,1L,1L,22L,1L,1L,2L,1L,3L,1L,10L,1L,3L,1L,2L,1L,1L,22L,1L,1L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010193Inst : IEnumerable<long>
{
public static readonly long[] Value=A010193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010193.Bytes);
public long this[int i]=>Value[i];

public static A010193Inst Instance=new A010193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010192
{
public static readonly long[] Value={ 11L,1L,1L,7L,5L,1L,1L,1L,2L,1L,1L,1L,5L,7L,1L,1L,22L,1L,1L,7L,5L,1L,1L,1L,2L,1L,1L,1L,5L,7L,1L,1L,22L,1L,1L,7L,5L,1L,1L,1L,2L,1L,1L,1L,5L,7L,1L,1L,22L,1L,1L,7L,5L,1L,1L,1L,2L,1L,1L,1L,5L,7L,1L,1L,22L,1L,1L,7L,5L,1L,1L,1L,2L,1L,1L,1L,5L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010192Inst : IEnumerable<long>
{
public static readonly long[] Value=A010192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010192.Bytes);
public long this[int i]=>Value[i];

public static A010192Inst Instance=new A010192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010191
{
public static readonly long[] Value={ 11L,2L,4L,11L,4L,2L,22L,2L,4L,11L,4L,2L,22L,2L,4L,11L,4L,2L,22L,2L,4L,11L,4L,2L,22L,2L,4L,11L,4L,2L,22L,2L,4L,11L,4L,2L,22L,2L,4L,11L,4L,2L,22L,2L,4L,11L,4L,2L,22L,2L,4L,11L,4L,2L,22L,2L,4L,11L,4L,2L,22L,2L,4L,11L,4L,2L,22L,2L,4L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010191Inst : IEnumerable<long>
{
public static readonly long[] Value=A010191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010191.Bytes);
public long this[int i]=>Value[i];

public static A010191Inst Instance=new A010191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010190
{
public static readonly long[] Value={ 11L,2L,1L,3L,1L,6L,1L,3L,1L,2L,22L,2L,1L,3L,1L,6L,1L,3L,1L,2L,22L,2L,1L,3L,1L,6L,1L,3L,1L,2L,22L,2L,1L,3L,1L,6L,1L,3L,1L,2L,22L,2L,1L,3L,1L,6L,1L,3L,1L,2L,22L,2L,1L,3L,1L,6L,1L,3L,1L,2L,22L,2L,1L,3L,1L,6L,1L,3L,1L,2L,22L,2L,1L,3L,1L,6L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010190Inst : IEnumerable<long>
{
public static readonly long[] Value=A010190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010190.Bytes);
public long this[int i]=>Value[i];

public static A010190Inst Instance=new A010190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010189
{
public static readonly long[] Value={ 11L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L,22L,3L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010189Inst : IEnumerable<long>
{
public static readonly long[] Value=A010189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010189.Bytes);
public long this[int i]=>Value[i];

public static A010189Inst Instance=new A010189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010188
{
public static readonly long[] Value={ 11L,3L,1L,2L,2L,7L,11L,7L,2L,2L,1L,3L,22L,3L,1L,2L,2L,7L,11L,7L,2L,2L,1L,3L,22L,3L,1L,2L,2L,7L,11L,7L,2L,2L,1L,3L,22L,3L,1L,2L,2L,7L,11L,7L,2L,2L,1L,3L,22L,3L,1L,2L,2L,7L,11L,7L,2L,2L,1L,3L,22L,3L,1L,2L,2L,7L,11L,7L,2L,2L,1L,3L,22L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010188Inst : IEnumerable<long>
{
public static readonly long[] Value=A010188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010188.Bytes);
public long this[int i]=>Value[i];

public static A010188Inst Instance=new A010188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010187
{
public static readonly long[] Value={ 11L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L,22L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010187Inst : IEnumerable<long>
{
public static readonly long[] Value=A010187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010187.Bytes);
public long this[int i]=>Value[i];

public static A010187Inst Instance=new A010187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010186
{
public static readonly long[] Value={ 11L,5L,1L,1L,5L,22L,5L,1L,1L,5L,22L,5L,1L,1L,5L,22L,5L,1L,1L,5L,22L,5L,1L,1L,5L,22L,5L,1L,1L,5L,22L,5L,1L,1L,5L,22L,5L,1L,1L,5L,22L,5L,1L,1L,5L,22L,5L,1L,1L,5L,22L,5L,1L,1L,5L,22L,5L,1L,1L,5L,22L,5L,1L,1L,5L,22L,5L,1L,1L,5L,22L,5L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010186Inst : IEnumerable<long>
{
public static readonly long[] Value=A010186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010186.Bytes);
public long this[int i]=>Value[i];

public static A010186Inst Instance=new A010186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010185
{
public static readonly long[] Value={ 11L,7L,2L,1L,1L,1L,3L,1L,4L,1L,3L,1L,1L,1L,2L,7L,22L,7L,2L,1L,1L,1L,3L,1L,4L,1L,3L,1L,1L,1L,2L,7L,22L,7L,2L,1L,1L,1L,3L,1L,4L,1L,3L,1L,1L,1L,2L,7L,22L,7L,2L,1L,1L,1L,3L,1L,4L,1L,3L,1L,1L,1L,2L,7L,22L,7L,2L,1L,1L,1L,3L,1L,4L,1L,3L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010185Inst : IEnumerable<long>
{
public static readonly long[] Value=A010185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010185.Bytes);
public long this[int i]=>Value[i];

public static A010185Inst Instance=new A010185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010184
{
public static readonly long[] Value={ 10L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L,20L,1L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010184Inst : IEnumerable<long>
{
public static readonly long[] Value=A010184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010184.Bytes);
public long this[int i]=>Value[i];

public static A010184Inst Instance=new A010184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010183
{
public static readonly long[] Value={ 10L,1L,6L,3L,2L,10L,2L,3L,6L,1L,20L,1L,6L,3L,2L,10L,2L,3L,6L,1L,20L,1L,6L,3L,2L,10L,2L,3L,6L,1L,20L,1L,6L,3L,2L,10L,2L,3L,6L,1L,20L,1L,6L,3L,2L,10L,2L,3L,6L,1L,20L,1L,6L,3L,2L,10L,2L,3L,6L,1L,20L,1L,6L,3L,2L,10L,2L,3L,6L,1L,20L,1L,6L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010183Inst : IEnumerable<long>
{
public static readonly long[] Value=A010183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010183.Bytes);
public long this[int i]=>Value[i];

public static A010183Inst Instance=new A010183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010182
{
public static readonly long[] Value={ 10L,1L,4L,2L,4L,1L,20L,1L,4L,2L,4L,1L,20L,1L,4L,2L,4L,1L,20L,1L,4L,2L,4L,1L,20L,1L,4L,2L,4L,1L,20L,1L,4L,2L,4L,1L,20L,1L,4L,2L,4L,1L,20L,1L,4L,2L,4L,1L,20L,1L,4L,2L,4L,1L,20L,1L,4L,2L,4L,1L,20L,1L,4L,2L,4L,1L,20L,1L,4L,2L,4L,1L,20L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010182Inst : IEnumerable<long>
{
public static readonly long[] Value=A010182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010182.Bytes);
public long this[int i]=>Value[i];

public static A010182Inst Instance=new A010182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010181
{
public static readonly long[] Value={ 10L,1L,3L,2L,1L,4L,1L,2L,3L,1L,20L,1L,3L,2L,1L,4L,1L,2L,3L,1L,20L,1L,3L,2L,1L,4L,1L,2L,3L,1L,20L,1L,3L,2L,1L,4L,1L,2L,3L,1L,20L,1L,3L,2L,1L,4L,1L,2L,3L,1L,20L,1L,3L,2L,1L,4L,1L,2L,3L,1L,20L,1L,3L,2L,1L,4L,1L,2L,3L,1L,20L,1L,3L,2L,1L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010181Inst : IEnumerable<long>
{
public static readonly long[] Value=A010181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010181.Bytes);
public long this[int i]=>Value[i];

public static A010181Inst Instance=new A010181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010180
{
public static readonly long[] Value={ 10L,1L,2L,1L,1L,1L,1L,1L,2L,1L,20L,1L,2L,1L,1L,1L,1L,1L,2L,1L,20L,1L,2L,1L,1L,1L,1L,1L,2L,1L,20L,1L,2L,1L,1L,1L,1L,1L,2L,1L,20L,1L,2L,1L,1L,1L,1L,1L,2L,1L,20L,1L,2L,1L,1L,1L,1L,1L,2L,1L,20L,1L,2L,1L,1L,1L,1L,1L,2L,1L,20L,1L,2L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010180Inst : IEnumerable<long>
{
public static readonly long[] Value=A010180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010180.Bytes);
public long this[int i]=>Value[i];

public static A010180Inst Instance=new A010180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010179
{
public static readonly long[] Value={ 10L,1L,2L,10L,2L,1L,20L,1L,2L,10L,2L,1L,20L,1L,2L,10L,2L,1L,20L,1L,2L,10L,2L,1L,20L,1L,2L,10L,2L,1L,20L,1L,2L,10L,2L,1L,20L,1L,2L,10L,2L,1L,20L,1L,2L,10L,2L,1L,20L,1L,2L,10L,2L,1L,20L,1L,2L,10L,2L,1L,20L,1L,2L,10L,2L,1L,20L,1L,2L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010179Inst : IEnumerable<long>
{
public static readonly long[] Value=A010179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010179.Bytes);
public long this[int i]=>Value[i];

public static A010179Inst Instance=new A010179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010178
{
public static readonly long[] Value={ 10L,1L,1L,1L,2L,2L,1L,1L,1L,20L,1L,1L,1L,2L,2L,1L,1L,1L,20L,1L,1L,1L,2L,2L,1L,1L,1L,20L,1L,1L,1L,2L,2L,1L,1L,1L,20L,1L,1L,1L,2L,2L,1L,1L,1L,20L,1L,1L,1L,2L,2L,1L,1L,1L,20L,1L,1L,1L,2L,2L,1L,1L,1L,20L,1L,1L,1L,2L,2L,1L,1L,1L,20L,1L,1L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010178Inst : IEnumerable<long>
{
public static readonly long[] Value=A010178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010178.Bytes);
public long this[int i]=>Value[i];

public static A010178Inst Instance=new A010178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010177
{
public static readonly long[] Value={ 10L,1L,1L,2L,1L,1L,20L,1L,1L,2L,1L,1L,20L,1L,1L,2L,1L,1L,20L,1L,1L,2L,1L,1L,20L,1L,1L,2L,1L,1L,20L,1L,1L,2L,1L,1L,20L,1L,1L,2L,1L,1L,20L,1L,1L,2L,1L,1L,20L,1L,1L,2L,1L,1L,20L,1L,1L,2L,1L,1L,20L,1L,1L,2L,1L,1L,20L,1L,1L,2L,1L,1L,20L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010177Inst : IEnumerable<long>
{
public static readonly long[] Value=A010177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010177.Bytes);
public long this[int i]=>Value[i];

public static A010177Inst Instance=new A010177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010176
{
public static readonly long[] Value={ 10L,1L,1L,6L,1L,1L,20L,1L,1L,6L,1L,1L,20L,1L,1L,6L,1L,1L,20L,1L,1L,6L,1L,1L,20L,1L,1L,6L,1L,1L,20L,1L,1L,6L,1L,1L,20L,1L,1L,6L,1L,1L,20L,1L,1L,6L,1L,1L,20L,1L,1L,6L,1L,1L,20L,1L,1L,6L,1L,1L,20L,1L,1L,6L,1L,1L,20L,1L,1L,6L,1L,1L,20L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010176Inst : IEnumerable<long>
{
public static readonly long[] Value=A010176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010176.Bytes);
public long this[int i]=>Value[i];

public static A010176Inst Instance=new A010176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010175
{
public static readonly long[] Value={ 10L,2L,3L,1L,2L,4L,1L,6L,6L,1L,4L,2L,1L,3L,2L,20L,2L,3L,1L,2L,4L,1L,6L,6L,1L,4L,2L,1L,3L,2L,20L,2L,3L,1L,2L,4L,1L,6L,6L,1L,4L,2L,1L,3L,2L,20L,2L,3L,1L,2L,4L,1L,6L,6L,1L,4L,2L,1L,3L,2L,20L,2L,3L,1L,2L,4L,1L,6L,6L,1L,4L,2L,1L,3L,2L,20L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010175Inst : IEnumerable<long>
{
public static readonly long[] Value=A010175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010175.Bytes);
public long this[int i]=>Value[i];

public static A010175Inst Instance=new A010175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010174
{
public static readonly long[] Value={ 10L,2L,1L,1L,4L,1L,1L,2L,20L,2L,1L,1L,4L,1L,1L,2L,20L,2L,1L,1L,4L,1L,1L,2L,20L,2L,1L,1L,4L,1L,1L,2L,20L,2L,1L,1L,4L,1L,1L,2L,20L,2L,1L,1L,4L,1L,1L,2L,20L,2L,1L,1L,4L,1L,1L,2L,20L,2L,1L,1L,4L,1L,1L,2L,20L,2L,1L,1L,4L,1L,1L,2L,20L,2L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010174Inst : IEnumerable<long>
{
public static readonly long[] Value=A010174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010174.Bytes);
public long this[int i]=>Value[i];

public static A010174Inst Instance=new A010174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010141
{
public static readonly long[] Value={ 7L,2L,2L,2L,14L,2L,2L,2L,14L,2L,2L,2L,14L,2L,2L,2L,14L,2L,2L,2L,14L,2L,2L,2L,14L,2L,2L,2L,14L,2L,2L,2L,14L,2L,2L,2L,14L,2L,2L,2L,14L,2L,2L,2L,14L,2L,2L,2L,14L,2L,2L,2L,14L,2L,2L,2L,14L,2L,2L,2L,14L,2L,2L,2L,14L,2L,2L,2L,14L,2L,2L,2L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010141Inst : IEnumerable<long>
{
public static readonly long[] Value=A010141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010141.Bytes);
public long this[int i]=>Value[i];

public static A010141Inst Instance=new A010141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010140
{
public static readonly long[] Value={ 7L,2L,1L,6L,1L,2L,14L,2L,1L,6L,1L,2L,14L,2L,1L,6L,1L,2L,14L,2L,1L,6L,1L,2L,14L,2L,1L,6L,1L,2L,14L,2L,1L,6L,1L,2L,14L,2L,1L,6L,1L,2L,14L,2L,1L,6L,1L,2L,14L,2L,1L,6L,1L,2L,14L,2L,1L,6L,1L,2L,14L,2L,1L,6L,1L,2L,14L,2L,1L,6L,1L,2L,14L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010140Inst : IEnumerable<long>
{
public static readonly long[] Value=A010140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010140.Bytes);
public long this[int i]=>Value[i];

public static A010140Inst Instance=new A010140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010139
{
public static readonly long[] Value={ 7L,3L,1L,1L,3L,14L,3L,1L,1L,3L,14L,3L,1L,1L,3L,14L,3L,1L,1L,3L,14L,3L,1L,1L,3L,14L,3L,1L,1L,3L,14L,3L,1L,1L,3L,14L,3L,1L,1L,3L,14L,3L,1L,1L,3L,14L,3L,1L,1L,3L,14L,3L,1L,1L,3L,14L,3L,1L,1L,3L,14L,3L,1L,1L,3L,14L,3L,1L,1L,3L,14L,3L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010139Inst : IEnumerable<long>
{
public static readonly long[] Value=A010139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010139.Bytes);
public long this[int i]=>Value[i];

public static A010139Inst Instance=new A010139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010138
{
public static readonly long[] Value={ 7L,4L,1L,2L,1L,4L,14L,4L,1L,2L,1L,4L,14L,4L,1L,2L,1L,4L,14L,4L,1L,2L,1L,4L,14L,4L,1L,2L,1L,4L,14L,4L,1L,2L,1L,4L,14L,4L,1L,2L,1L,4L,14L,4L,1L,2L,1L,4L,14L,4L,1L,2L,1L,4L,14L,4L,1L,2L,1L,4L,14L,4L,1L,2L,1L,4L,14L,4L,1L,2L,1L,4L,14L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010138Inst : IEnumerable<long>
{
public static readonly long[] Value=A010138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010138.Bytes);
public long this[int i]=>Value[i];

public static A010138Inst Instance=new A010138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010137
{
public static readonly long[] Value={ 6L,1L,5L,1L,12L,1L,5L,1L,12L,1L,5L,1L,12L,1L,5L,1L,12L,1L,5L,1L,12L,1L,5L,1L,12L,1L,5L,1L,12L,1L,5L,1L,12L,1L,5L,1L,12L,1L,5L,1L,12L,1L,5L,1L,12L,1L,5L,1L,12L,1L,5L,1L,12L,1L,5L,1L,12L,1L,5L,1L,12L,1L,5L,1L,12L,1L,5L,1L,12L,1L,5L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010137Inst : IEnumerable<long>
{
public static readonly long[] Value=A010137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010137.Bytes);
public long this[int i]=>Value[i];

public static A010137Inst Instance=new A010137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010136
{
public static readonly long[] Value={ 6L,1L,3L,1L,1L,2L,6L,2L,1L,1L,3L,1L,12L,1L,3L,1L,1L,2L,6L,2L,1L,1L,3L,1L,12L,1L,3L,1L,1L,2L,6L,2L,1L,1L,3L,1L,12L,1L,3L,1L,1L,2L,6L,2L,1L,1L,3L,1L,12L,1L,3L,1L,1L,2L,6L,2L,1L,1L,3L,1L,12L,1L,3L,1L,1L,2L,6L,2L,1L,1L,3L,1L,12L,1L,3L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010136Inst : IEnumerable<long>
{
public static readonly long[] Value=A010136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010136.Bytes);
public long this[int i]=>Value[i];

public static A010136Inst Instance=new A010136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010135
{
public static readonly long[] Value={ 6L,1L,2L,2L,2L,1L,12L,1L,2L,2L,2L,1L,12L,1L,2L,2L,2L,1L,12L,1L,2L,2L,2L,1L,12L,1L,2L,2L,2L,1L,12L,1L,2L,2L,2L,1L,12L,1L,2L,2L,2L,1L,12L,1L,2L,2L,2L,1L,12L,1L,2L,2L,2L,1L,12L,1L,2L,2L,2L,1L,12L,1L,2L,2L,2L,1L,12L,1L,2L,2L,2L,1L,12L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010135Inst : IEnumerable<long>
{
public static readonly long[] Value=A010135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010135.Bytes);
public long this[int i]=>Value[i];

public static A010135Inst Instance=new A010135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010134
{
public static readonly long[] Value={ 6L,1L,1L,3L,1L,5L,1L,3L,1L,1L,12L,1L,1L,3L,1L,5L,1L,3L,1L,1L,12L,1L,1L,3L,1L,5L,1L,3L,1L,1L,12L,1L,1L,3L,1L,5L,1L,3L,1L,1L,12L,1L,1L,3L,1L,5L,1L,3L,1L,1L,12L,1L,1L,3L,1L,5L,1L,3L,1L,1L,12L,1L,1L,3L,1L,5L,1L,3L,1L,1L,12L,1L,1L,3L,1L,5L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010134Inst : IEnumerable<long>
{
public static readonly long[] Value=A010134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010134.Bytes);
public long this[int i]=>Value[i];

public static A010134Inst Instance=new A010134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010133
{
public static readonly long[] Value={ 6L,2L,2L,12L,2L,2L,12L,2L,2L,12L,2L,2L,12L,2L,2L,12L,2L,2L,12L,2L,2L,12L,2L,2L,12L,2L,2L,12L,2L,2L,12L,2L,2L,12L,2L,2L,12L,2L,2L,12L,2L,2L,12L,2L,2L,12L,2L,2L,12L,2L,2L,12L,2L,2L,12L,2L,2L,12L,2L,2L,12L,2L,2L,12L,2L,2L,12L,2L,2L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010133Inst : IEnumerable<long>
{
public static readonly long[] Value=A010133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010133.Bytes);
public long this[int i]=>Value[i];

public static A010133Inst Instance=new A010133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010132
{
public static readonly long[] Value={ 5L,1L,4L,1L,10L,1L,4L,1L,10L,1L,4L,1L,10L,1L,4L,1L,10L,1L,4L,1L,10L,1L,4L,1L,10L,1L,4L,1L,10L,1L,4L,1L,10L,1L,4L,1L,10L,1L,4L,1L,10L,1L,4L,1L,10L,1L,4L,1L,10L,1L,4L,1L,10L,1L,4L,1L,10L,1L,4L,1L,10L,1L,4L,1L,10L,1L,4L,1L,10L,1L,4L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010132Inst : IEnumerable<long>
{
public static readonly long[] Value=A010132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010132.Bytes);
public long this[int i]=>Value[i];

public static A010132Inst Instance=new A010132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010131
{
public static readonly long[] Value={ 5L,1L,2L,1L,10L,1L,2L,1L,10L,1L,2L,1L,10L,1L,2L,1L,10L,1L,2L,1L,10L,1L,2L,1L,10L,1L,2L,1L,10L,1L,2L,1L,10L,1L,2L,1L,10L,1L,2L,1L,10L,1L,2L,1L,10L,1L,2L,1L,10L,1L,2L,1L,10L,1L,2L,1L,10L,1L,2L,1L,10L,1L,2L,1L,10L,1L,2L,1L,10L,1L,2L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010131Inst : IEnumerable<long>
{
public static readonly long[] Value=A010131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010131.Bytes);
public long this[int i]=>Value[i];

public static A010131Inst Instance=new A010131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010130
{
public static readonly long[] Value={ 5L,1L,1L,1L,10L,1L,1L,1L,10L,1L,1L,1L,10L,1L,1L,1L,10L,1L,1L,1L,10L,1L,1L,1L,10L,1L,1L,1L,10L,1L,1L,1L,10L,1L,1L,1L,10L,1L,1L,1L,10L,1L,1L,1L,10L,1L,1L,1L,10L,1L,1L,1L,10L,1L,1L,1L,10L,1L,1L,1L,10L,1L,1L,1L,10L,1L,1L,1L,10L,1L,1L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010130Inst : IEnumerable<long>
{
public static readonly long[] Value=A010130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010130.Bytes);
public long this[int i]=>Value[i];

public static A010130Inst Instance=new A010130Inst();

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