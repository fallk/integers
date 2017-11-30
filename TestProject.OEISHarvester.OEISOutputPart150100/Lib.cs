using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A179405
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,56L,360L,2934L,26054L,269128L,3010680L,37616880L,504880992L,7387701672L,115228447152L,1929016301016L,34194883090440L,643667407174464L,12757366498618176L,266426229010029696L,5830527979298793024L,BigInteger.Parse("133665090871032478080"),BigInteger.Parse("3197905600674249843840") };
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
public class A179405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179405Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179405.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179405.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179405Inst Instance=new A179405Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179406
{
public static readonly long[] Value={ 7L,19L,60L,341L,47776L,70378L,78846L,115775L,220898L,780231L,2242100L,11889984L,26914479L,50406928L,77146256L,80117392L,284679759L,595974650L,2071791247L,7825152599L,67944824923L,742629277177L,1709838230002L,2676465117663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179406Inst : IEnumerable<long>
{
public static readonly long[] Value=A179406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179406.Bytes);
public long this[int i]=>Value[i];

public static A179406Inst Instance=new A179406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179407
{
public static readonly long[] Value={ 8L,55L,76L,377L,430L,499L,655L,804L,1827L,5350L,10805L,15433L,22108L,44729L,44817L,96001L,747343L,748635L,952463L,7626590L,10741787L,12798893L,14957531L,15873532L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179407Inst : IEnumerable<long>
{
public static readonly long[] Value=A179407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179407.Bytes);
public long this[int i]=>Value[i];

public static A179407Inst Instance=new A179407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179408
{
public static readonly long[] Value={ 181L,22434L,50354L,2759646L,3834168L,5562261L,10980023L,18329057L,142674503L,2093555387L,12135618855L,29588700403L,72673092233L,423129175811L,425213412449L,2855547523353L,482836315990072L,484925830443335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179408Inst : IEnumerable<long>
{
public static readonly long[] Value=A179408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179408.Bytes);
public long this[int i]=>Value[i];

public static A179408Inst Instance=new A179408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179409
{
public static readonly long[] Value={ 6L,6L,6L,8L,10L,12L,16L,18L,20L,26L,26L,28L,30L,22L,26L,16L,20L,18L,18L,20L,16L,20L,10L,8L,6L,6L,6L,8L,10L,12L,16L,18L,20L,26L,26L,28L,30L,22L,26L,16L,20L,18L,18L,20L,16L,20L,10L,8L,6L,6L,6L,8L,10L,12L,16L,18L,20L,26L,26L,28L,30L,22L,26L,16L,20L,18L,18L,20L,16L,20L,10L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179409Inst : IEnumerable<long>
{
public static readonly long[] Value=A179409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179409.Bytes);
public long this[int i]=>Value[i];

public static A179409Inst Instance=new A179409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179410
{
public static readonly long[] Value={ 4L,5L,3L,3L,5L,5L,7L,6L,7L,8L,7L,7L,7L,4L,7L,5L,6L,6L,5L,5L,5L,5L,7L,3L,4L,5L,3L,3L,5L,5L,7L,6L,7L,8L,7L,7L,7L,4L,7L,5L,6L,6L,5L,5L,5L,5L,7L,3L,4L,5L,3L,3L,5L,5L,7L,6L,7L,8L,7L,7L,7L,4L,7L,5L,6L,6L,5L,5L,5L,5L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179410Inst : IEnumerable<long>
{
public static readonly long[] Value=A179410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179410.Bytes);
public long this[int i]=>Value[i];

public static A179410Inst Instance=new A179410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179411
{
public static readonly long[] Value={ 4L,2L,4L,4L,4L,4L,6L,6L,6L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,6L,4L,4L,2L,4L,4L,4L,4L,6L,6L,6L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,6L,4L,4L,2L,4L,4L,4L,4L,6L,6L,6L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179411Inst : IEnumerable<long>
{
public static readonly long[] Value=A179411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179411.Bytes);
public long this[int i]=>Value[i];

public static A179411Inst Instance=new A179411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179412
{
public static readonly long[] Value={ 8L,8L,9L,10L,12L,16L,13L,23L,16L,22L,18L,24L,16L,20L,21L,23L,28L,19L,18L,18L,23L,22L,18L,27L,16L,20L,10L,10L,10L,13L,15L,19L,22L,18L,25L,18L,19L,23L,23L,20L,21L,22L,30L,19L,22L,21L,20L,28L,19L,16L,14L,9L,13L,12L,13L,14L,16L,23L,15L,19L,16L,26L,16L,12L,12L,9L,8L,8L,9L,10L,12L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179412Inst : IEnumerable<long>
{
public static readonly long[] Value=A179412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179412.Bytes);
public long this[int i]=>Value[i];

public static A179412Inst Instance=new A179412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179413
{
public static readonly long[] Value={ 3L,4L,5L,5L,6L,6L,6L,7L,8L,8L,8L,8L,7L,8L,8L,8L,8L,8L,7L,7L,8L,8L,8L,7L,7L,6L,3L,5L,5L,5L,6L,8L,7L,8L,8L,7L,7L,7L,8L,7L,8L,8L,8L,7L,7L,8L,8L,8L,6L,6L,7L,5L,6L,8L,7L,7L,8L,8L,8L,6L,7L,7L,8L,6L,6L,4L,3L,4L,5L,5L,6L,6L,6L,7L,8L,8L,8L,8L,7L,8L,8L,8L,8L,8L,7L,7L,8L,8L,8L,7L,7L,6L,3L,5L,5L,5L,6L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179413Inst : IEnumerable<long>
{
public static readonly long[] Value=A179413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179413.Bytes);
public long this[int i]=>Value[i];

public static A179413Inst Instance=new A179413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179414
{
public static readonly long[] Value={ 4L,4L,4L,4L,5L,6L,7L,8L,8L,8L,7L,8L,7L,7L,7L,8L,8L,8L,7L,7L,7L,7L,6L,8L,8L,8L,7L,4L,6L,6L,6L,7L,7L,8L,8L,7L,8L,7L,8L,8L,8L,8L,8L,8L,8L,7L,8L,8L,6L,7L,7L,5L,4L,5L,5L,5L,6L,6L,7L,7L,8L,8L,7L,5L,5L,5L,4L,4L,4L,4L,5L,6L,7L,8L,8L,8L,7L,8L,7L,7L,7L,8L,8L,8L,7L,7L,7L,7L,6L,8L,8L,8L,7L,4L,6L,6L,6L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179414Inst : IEnumerable<long>
{
public static readonly long[] Value=A179414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179414.Bytes);
public long this[int i]=>Value[i];

public static A179414Inst Instance=new A179414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179415
{
public static readonly long[] Value={ 6L,6L,6L,8L,10L,12L,16L,18L,20L,26L,24L,28L,30L,22L,32L,28L,32L,36L,48L,42L,56L,34L,26L,28L,40L,38L,50L,48L,46L,64L,48L,46L,48L,46L,48L,56L,52L,66L,62L,66L,68L,86L,60L,70L,64L,72L,50L,50L,50L,40L,42L,46L,48L,36L,38L,36L,42L,48L,46L,44L,34L,30L,26L,22L,20L,16L,16L,16L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179415Inst : IEnumerable<long>
{
public static readonly long[] Value=A179415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179415.Bytes);
public long this[int i]=>Value[i];

public static A179415Inst Instance=new A179415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179416
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179416Inst : IEnumerable<long>
{
public static readonly long[] Value=A179416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179416.Bytes);
public long this[int i]=>Value[i];

public static A179416Inst Instance=new A179416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179417
{
public static readonly long[] Value={ 1L,5L,24L,104L,279L,2001L,4131L,17453L,88826L,362532L,1655660L,6120642L,25376649L,128526482L,301370205L,1756488602L,8046359747L,30854867177L,73845140753L,488906501177L,2106640948770L,6573967883049L,29711211505300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179417Inst : IEnumerable<long>
{
public static readonly long[] Value=A179417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179417.Bytes);
public long this[int i]=>Value[i];

public static A179417Inst Instance=new A179417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179418
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,7L,4L,6L,11L,6L,10L,11L,12L,12L,17L,16L,20L,21L,15L,19L,24L,24L,21L,22L,24L,29L,25L,25L,30L,29L,37L,29L,34L,30L,31L,36L,37L,34L,32L,36L,46L,43L,46L,50L,46L,48L,39L,40L,52L,49L,55L,51L,54L,47L,55L,50L,53L,65L,57L,59L,74L,73L,78L,65L,66L,70L,58L,64L,69L,69L,69L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179418Inst : IEnumerable<long>
{
public static readonly long[] Value=A179418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179418.Bytes);
public long this[int i]=>Value[i];

public static A179418Inst Instance=new A179418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179419
{
public static readonly long[] Value={ 216L,343L,1331L,12167L,13824L,17576L,21952L,29791L,54872L,74088L,85184L,103823L,157464L,166375L,226981L,250047L,592704L,753571L,778688L,857375L,884736L,970299L,1124864L,1331000L,1367631L,1404928L,1643032L,1685159L,1906624L,2628072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179419Inst : IEnumerable<long>
{
public static readonly long[] Value=A179419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179419.Bytes);
public long this[int i]=>Value[i];

public static A179419Inst Instance=new A179419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179420
{
public static readonly BigInteger[] Value={ 0L,1L,2L,12L,132L,2200L,50280L,1482768L,54171376L,2381590944L,123292821600L,7390709937600L,506182300962624L,39180896544097152L,3396777800819754624L,BigInteger.Parse("327323946734658720000"),BigInteger.Parse("34831825328790915321600") };
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
public class A179420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179420Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179420.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179420.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179420Inst Instance=new A179420Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179421
{
public static readonly BigInteger[] Value={ 1L,1L,4L,33L,440L,8380L,211824L,6771422L,264621216L,12329282160L,671882721600L,42181858413552L,3013915118776704L,242626985772839616L,BigInteger.Parse("21821596448977248000"),BigInteger.Parse("2176989083049432207600"),BigInteger.Parse("239420370429753669425664") };
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
public class A179421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179421Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179421.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179421.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179421Inst Instance=new A179421Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179422
{
public static readonly BigInteger[] Value={ 1L,4L,36L,528L,11000L,301680L,10379376L,433371008L,21434318496L,1232928216000L,81297809313600L,6074187611551488L,509351655073262976L,BigInteger.Parse("47554889211476564736"),BigInteger.Parse("4909859201019880800000"),BigInteger.Parse("557309205260654645145600") };
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
public class A179422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179422Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179422.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179422.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179422Inst Instance=new A179422Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179423
{
public static readonly BigInteger[] Value={ 1L,2L,10L,90L,1240L,23800L,598788L,18932620L,729558240L,33475442400L,1796086010400L,111058345494624L,7820581741096320L,621007886404464000L,BigInteger.Parse("55143814204485434400"),BigInteger.Parse("5436629250445000648800"),BigInteger.Parse("591426542480093093242368") };
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
public class A179423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179423Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179423.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179423.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179423Inst Instance=new A179423Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179424
{
public static readonly long[] Value={ 0L,0L,0L,12L,575L,9837L,63553L,265008L,853497L,2312925L,5532967L,12037068L,24293243L,46125317L,83243925L,143918272L,239811333L,387002853L,607226187L,929346700L,1391111127L,2041198973L,2941608713L,4170413232L,5824920625L,8025278157L,10918558863L,14683371948L,19535039827L,25731386325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179424Inst : IEnumerable<long>
{
public static readonly long[] Value=A179424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179424.Bytes);
public long this[int i]=>Value[i];

public static A179424Inst Instance=new A179424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179425
{
public static readonly long[] Value={ 0L,0L,0L,0L,10L,14940L,229908L,1678336L,8155404L,30614620L,96011322L,263506752L,652150382L,1485650012L,3161648520L,6355083264L,12167739256L,22339050588L,39536586430L,67748508480L,112804636266L,183057635420L,290261282204L,450688785408L,686540794500L,1027700020828L,1513897376994L,2197363228480L,3146046781446L,4447496831580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179425Inst : IEnumerable<long>
{
public static readonly long[] Value=A179425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179425.Bytes);
public long this[int i]=>Value[i];

public static A179425Inst Instance=new A179425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179426
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,10596L,486668L,7063520L,55345356L,299491100L,1263811604L,4455716184L,13701863604L,37823872044L,95648273100L,224887404416L,497181121100L,1042609380588L,2088337713332L,4017815773400L,7459198321428L,13414493857116L,23444476061772L,39928736913120L,66425550447500L,108162598959740L,172697249542932L,270794133842456L,417578468928308L,634036069773900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179426Inst : IEnumerable<long>
{
public static readonly long[] Value=A179426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179426.Bytes);
public long this[int i]=>Value[i];

public static A179426Inst Instance=new A179426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179427
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,3420L,576856L,19760512L,270487188L,2209065700L,12914201256L,59659859232L,231216019632L,781647658596L,2367858314700L,6553746728448L,16815788711212L,40446802230372L,92003239814224L,199311860224800L,413589922308360L,825997764087012L,1594007700404532L,2982430581363072L,5425904270482500L,9622254525739492L,16669554533555832L,28264133502586912L,46982453295836640L,76676963241363300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179427Inst : IEnumerable<long>
{
public static readonly long[] Value=A179427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179427.Bytes);
public long this[int i]=>Value[i];

public static A179427Inst Instance=new A179427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179428
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,486L,346381L,36285336L,956078397L,12428297150L,104000525596L,643409498286L,3191250652226L,13361641961066L,48905750870775L,160414160371552L,480243686391743L,1330654487994234L,3449609146025210L,8439769551278350L,19624142987739108L,43616849672119790L,93112709811981557L,191696927842663704L,381920049400830625L,738532765420347014L,1389708580432837752L,2550402748009811870L,4573836436177381798L,8029626473495462850L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179428Inst : IEnumerable<long>
{
public static readonly long[] Value=A179428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179428.Bytes);
public long this[int i]=>Value[i];

public static A179428Inst Instance=new A179428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179429
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,59L,61L,71L,73L,79L,89L,97L,103L,107L,113L,131L,149L,151L,157L,167L,173L,179L,181L,191L,199L,233L,239L,241L,251L,257L,269L,293L,379L,383L,401L,419L,433L,467L,479L,487L,521L,523L,613L,617L,619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179429Inst : IEnumerable<long>
{
public static readonly long[] Value=A179429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179429.Bytes);
public long this[int i]=>Value[i];

public static A179429Inst Instance=new A179429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179430
{
public static readonly long[] Value={ 1L,1L,1L,3L,9L,1L,84L,405L,81L,1L,17550L,121500L,32805L,729L,1L,25621596L,247203171L,82255257L,2539107L,6561L,1L,268715232324L,3543210805275L,1382411964132L,53628242751L,199290375L,59049L,1L,21091830512086620L,373203783345533355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179430Inst : IEnumerable<long>
{
public static readonly long[] Value=A179430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179430.Bytes);
public long this[int i]=>Value[i];

public static A179430Inst Instance=new A179430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179431
{
public static readonly BigInteger[] Value={ 1L,1L,3L,84L,17550L,25621596L,268715232324L,21091830512086620L,BigInteger.Parse("12814543323816738705045"),BigInteger.Parse("61742372998425082372103866380"),BigInteger.Parse("2399699340005498870742886195375900380") };
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
public class A179431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179431Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179431.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179431.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179431Inst Instance=new A179431Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179432
{
public static readonly BigInteger[] Value={ 1L,2L,15L,816L,316251L,873642672L,17743125256857L,2739097835911193328L,BigInteger.Parse("3301626910467952067341626"),BigInteger.Parse("31698997711344336177849363574320"),BigInteger.Parse("2460103385023594223069956382123378560008") };
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
public class A179432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179432Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179432.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179432.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179432Inst Instance=new A179432Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179433
{
public static readonly BigInteger[] Value={ 1L,9L,405L,121500L,247203171L,3543210805275L,373203783345533355L,BigInteger.Parse("299059356226224581923626"),BigInteger.Parse("1870707073035678423776605220985"),BigInteger.Parse("93075349691648156957700437094276630105") };
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
public class A179433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179433Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179433.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179433.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179433Inst Instance=new A179433Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179434
{
public static readonly BigInteger[] Value={ 1L,2L,13L,571L,172585L,357625693L,5248165593907L,566958191345077996L,BigInteger.Parse("465798195439736703244606"),BigInteger.Parse("2982999334066325867630228374270"),BigInteger.Parse("151658307264909973462110073089257457502") };
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
public class A179434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179434Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179434.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179434.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179434Inst Instance=new A179434Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179435
{
public static readonly long[] Value={ 40L,48L,54L,88L,108L,184L,250L,384L,424L,432L,448L,808L,864L,1048L,1216L,1384L,1528L,1575L,1680L,1792L,1864L,1890L,2104L,2184L,2457L,2925L,2944L,3080L,3120L,3328L,3510L,3696L,3712L,3915L,4125L,4158L,4288L,4504L,4744L,4950L,5224L,5488L,5632L,5928L,5940L,6240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179435Inst : IEnumerable<long>
{
public static readonly long[] Value=A179435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179435.Bytes);
public long this[int i]=>Value[i];

public static A179435Inst Instance=new A179435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179436
{
public static readonly long[] Value={ 7L,25L,52L,88L,133L,187L,250L,322L,403L,493L,592L,700L,817L,943L,1078L,1222L,1375L,1537L,1708L,1888L,2077L,2275L,2482L,2698L,2923L,3157L,3400L,3652L,3913L,4183L,4462L,4750L,5047L,5353L,5668L,5992L,6325L,6667L,7018L,7378L,7747L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179436Inst : IEnumerable<long>
{
public static readonly long[] Value=A179436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179436.Bytes);
public long this[int i]=>Value[i];

public static A179436Inst Instance=new A179436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179437
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,3L,3L,5L,9L,9L,13L,15L,15L,17L,21L,25L,25L,29L,31L,31L,35L,37L,41L,47L,49L,49L,51L,51L,53L,65L,67L,71L,71L,79L,79L,83L,87L,89L,93L,97L,97L,105L,105L,107L,107L,117L,127L,129L,129L,131L,135L,135L,143L,147L,151L,155L,155L,159L,161L,161L,169L,181L,183L,183L,185L,197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179437Inst : IEnumerable<long>
{
public static readonly long[] Value=A179437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179437.Bytes);
public long this[int i]=>Value[i];

public static A179437Inst Instance=new A179437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179438
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,4L,2L,1L,1L,1L,9L,4L,2L,2L,1L,1L,1L,20L,9L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179438Inst : IEnumerable<long>
{
public static readonly long[] Value=A179438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179438.Bytes);
public long this[int i]=>Value[i];

public static A179438Inst Instance=new A179438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179439
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,8L,9L,10L,11L,12L,13L,14L,15L,17L,20L,21L,22L,24L,25L,26L,27L,29L,30L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,61L,62L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179439Inst : IEnumerable<long>
{
public static readonly long[] Value=A179439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179439.Bytes);
public long this[int i]=>Value[i];

public static A179439Inst Instance=new A179439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179440
{
public static readonly long[] Value={ 240L,395L,450L,733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179440Inst : IEnumerable<long>
{
public static readonly long[] Value=A179440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179440.Bytes);
public long this[int i]=>Value[i];

public static A179440Inst Instance=new A179440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179441
{
public static readonly long[] Value={ 1L,21L,121L,432L,1182L,2723L,5558L,10368L,18039L,29689L,46695L,70720L,103740L,148071L,206396L,281792L,377757L,498237L,647653L,830928L,1053514L,1321419L,1641234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179441Inst : IEnumerable<long>
{
public static readonly long[] Value=A179441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179441.Bytes);
public long this[int i]=>Value[i];

public static A179441Inst Instance=new A179441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179442
{
public static readonly BigInteger[] Value={ 2L,3L,16L,180L,3456L,100800L,4147200L,228614400L,16257024000L,1448500838400L,158018273280000L,20713561989120000L,3212195459235840000L,BigInteger.Parse("581636820654489600000"),BigInteger.Parse("121600871304831959040000") };
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
public class A179442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179442Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179442.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179442.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179442Inst Instance=new A179442Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179443
{
public static readonly long[] Value={ 8L,9L,12L,14L,16L,20L,22L,26L,30L,32L,34L,35L,36L,38L,39L,44L,45L,48L,50L,51L,55L,56L,58L,62L,65L,68L,72L,74L,77L,78L,80L,84L,85L,86L,87L,90L,92L,93L,95L,96L,98L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179443Inst : IEnumerable<long>
{
public static readonly long[] Value=A179443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179443.Bytes);
public long this[int i]=>Value[i];

public static A179443Inst Instance=new A179443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179444
{
public static readonly long[] Value={ 81L,91L,121L,141L,161L,201L,221L,261L,301L,321L,341L,351L,361L,381L,391L,441L,451L,481L,501L,511L,551L,561L,581L,621L,651L,681L,721L,741L,771L,781L,801L,841L,851L,861L,871L,901L,921L,931L,951L,961L,981L,1001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179444Inst : IEnumerable<long>
{
public static readonly long[] Value=A179444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179444.Bytes);
public long this[int i]=>Value[i];

public static A179444Inst Instance=new A179444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179445
{
public static readonly long[] Value={ 1L,4L,6L,10L,15L,18L,21L,24L,25L,27L,28L,33L,40L,42L,46L,49L,52L,54L,57L,60L,63L,64L,66L,69L,70L,75L,76L,81L,82L,88L,91L,94L,99L,102L,105L,106L,115L,117L,118L,120L,123L,129L,130L,132L,136L,138L,145L,147L,148L,153L,160L,162L,172L,174L,180L,183L,186L,187L,190L,195L,201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179445Inst : IEnumerable<long>
{
public static readonly long[] Value=A179445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179445.Bytes);
public long this[int i]=>Value[i];

public static A179445Inst Instance=new A179445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179446
{
public static readonly long[] Value={ 11L,41L,61L,101L,151L,181L,211L,241L,251L,271L,281L,331L,401L,421L,461L,491L,521L,541L,571L,601L,631L,641L,661L,691L,701L,751L,761L,811L,821L,881L,911L,941L,991L,1021L,1051L,1061L,1151L,1171L,1181L,1201L,1231L,1291L,1301L,1321L,1361L,1381L,1451L,1471L,1481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179446Inst : IEnumerable<long>
{
public static readonly long[] Value=A179446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179446.Bytes);
public long this[int i]=>Value[i];

public static A179446Inst Instance=new A179446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179447
{
public static readonly long[] Value={ 2L,1L,7L,1044976L,11331151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179447Inst : IEnumerable<long>
{
public static readonly long[] Value=A179447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179447.Bytes);
public long this[int i]=>Value[i];

public static A179447Inst Instance=new A179447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179448
{
public static readonly long[] Value={ 1044976L,1541468L,11331151L,15579791L,16410368L,33543196L,46539324L,72697500L,302272796L,528292607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179448Inst : IEnumerable<long>
{
public static readonly long[] Value=A179448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179448.Bytes);
public long this[int i]=>Value[i];

public static A179448Inst Instance=new A179448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179449
{
public static readonly long[] Value={ 3L,1L,8L,3L,0L,5L,0L,0L,9L,3L,7L,5L,0L,8L,7L,6L,2L,6L,4L,9L,6L,1L,7L,7L,6L,3L,8L,0L,2L,8L,6L,3L,4L,9L,0L,1L,8L,9L,9L,7L,4L,2L,3L,5L,0L,1L,6L,1L,8L,6L,4L,2L,8L,1L,5L,5L,3L,7L,9L,2L,8L,1L,4L,4L,1L,2L,2L,8L,2L,9L,4L,7L,6L,5L,0L,9L,1L,4L,6L,2L,5L,2L,4L,3L,9L,9L,3L,9L,9L,6L,5L,0L,8L,8L,4L,0L,7L,1L,8L,7L,6L,2L,7L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179449Inst : IEnumerable<long>
{
public static readonly long[] Value=A179449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179449.Bytes);
public long this[int i]=>Value[i];

public static A179449Inst Instance=new A179449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179450
{
public static readonly long[] Value={ 1L,3L,8L,3L,5L,5L,2L,5L,9L,3L,6L,2L,4L,9L,4L,0L,4L,1L,3L,9L,8L,2L,5L,9L,9L,2L,0L,6L,1L,4L,0L,5L,2L,8L,2L,6L,6L,7L,0L,8L,1L,7L,5L,2L,0L,1L,8L,8L,9L,9L,3L,2L,2L,8L,8L,5L,4L,3L,4L,2L,0L,8L,8L,6L,1L,9L,9L,6L,4L,7L,5L,9L,5L,5L,9L,7L,3L,7L,8L,0L,5L,4L,8L,3L,4L,0L,8L,4L,0L,8L,2L,3L,7L,3L,9L,8L,8L,3L,1L,1L,2L,4L,1L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179450Inst : IEnumerable<long>
{
public static readonly long[] Value=A179450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179450.Bytes);
public long this[int i]=>Value[i];

public static A179450Inst Instance=new A179450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179451
{
public static readonly long[] Value={ 2L,9L,3L,0L,5L,9L,8L,2L,8L,4L,4L,9L,1L,1L,9L,8L,9L,5L,4L,0L,7L,4L,5L,3L,7L,5L,4L,3L,6L,1L,9L,2L,6L,7L,7L,0L,2L,7L,6L,0L,2L,5L,1L,6L,3L,0L,9L,1L,7L,4L,2L,8L,3L,0L,9L,0L,7L,6L,4L,1L,7L,1L,3L,8L,1L,5L,4L,6L,0L,9L,2L,9L,9L,1L,0L,5L,1L,5L,9L,4L,9L,6L,1L,3L,9L,5L,0L,2L,5L,8L,3L,0L,4L,3L,7L,2L,9L,5L,7L,6L,4L,3L,0L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179451Inst : IEnumerable<long>
{
public static readonly long[] Value=A179451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179451.Bytes);
public long this[int i]=>Value[i];

public static A179451Inst Instance=new A179451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179452
{
public static readonly long[] Value={ 1L,5L,3L,8L,8L,4L,1L,7L,6L,8L,5L,8L,7L,6L,2L,6L,7L,0L,1L,2L,8L,5L,1L,4L,5L,2L,8L,8L,0L,1L,8L,4L,5L,4L,9L,1L,2L,0L,0L,3L,3L,5L,1L,0L,7L,1L,7L,6L,8L,8L,9L,6L,2L,1L,3L,5L,1L,9L,5L,7L,8L,1L,2L,5L,1L,8L,7L,4L,3L,1L,6L,4L,4L,2L,4L,7L,5L,4L,5L,4L,5L,9L,2L,2L,7L,2L,9L,6L,8L,6L,0L,8L,3L,3L,5L,5L,2L,7L,1L,7L,6L,3L,5L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179452Inst : IEnumerable<long>
{
public static readonly long[] Value=A179452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179452.Bytes);
public long this[int i]=>Value[i];

public static A179452Inst Instance=new A179452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179453
{
public static readonly long[] Value={ 1L,4L,6L,3L,5L,2L,5L,4L,9L,1L,5L,6L,2L,4L,2L,1L,1L,3L,6L,1L,5L,3L,4L,4L,0L,1L,2L,5L,7L,7L,4L,2L,2L,8L,5L,8L,8L,2L,9L,0L,2L,3L,1L,8L,8L,4L,8L,5L,4L,3L,2L,2L,1L,4L,6L,6L,0L,1L,5L,8L,6L,4L,6L,7L,0L,2L,8L,9L,4L,5L,3L,4L,7L,1L,1L,4L,1L,7L,6L,8L,3L,7L,2L,8L,0L,4L,0L,5L,4L,0L,3L,1L,4L,2L,0L,4L,3L,3L,5L,3L,1L,1L,3L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179453Inst : IEnumerable<long>
{
public static readonly long[] Value=A179453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179453.Bytes);
public long this[int i]=>Value[i];

public static A179453Inst Instance=new A179453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179454
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,4L,1L,1L,14L,8L,1L,1L,51L,54L,13L,1L,1L,202L,365L,132L,19L,1L,1L,876L,2582L,1289L,265L,26L,1L,1L,4139L,19404L,12859L,3409L,473L,34L,1L,1L,21146L,155703L,134001L,43540L,7666L,779L,43L,1L,1L,115974L,1335278L,1471353L,569275L,120200L,15456L,1209L,53L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179454Inst : IEnumerable<long>
{
public static readonly long[] Value=A179454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179454.Bytes);
public long this[int i]=>Value[i];

public static A179454Inst Instance=new A179454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179455
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,5L,6L,1L,15L,23L,24L,1L,52L,106L,119L,120L,1L,203L,568L,700L,719L,720L,1L,877L,3459L,4748L,5013L,5039L,5040L,1L,4140L,23544L,36403L,39812L,40285L,40319L,40320L,1L,21147L,176850L,310851L,354391L,362057L,362836L,362879L,362880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179455Inst : IEnumerable<long>
{
public static readonly long[] Value=A179455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179455.Bytes);
public long this[int i]=>Value[i];

public static A179455Inst Instance=new A179455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179456
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,5L,1L,24L,23L,9L,1L,120L,119L,68L,14L,1L,720L,719L,517L,152L,20L,1L,5040L,5039L,4163L,1581L,292L,27L,1L,40320L,40319L,36180L,16776L,3917L,508L,35L,1L,362880L,362879L,341733L,186030L,52029L,8489L,823L,44L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179456Inst : IEnumerable<long>
{
public static readonly long[] Value=A179456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179456.Bytes);
public long this[int i]=>Value[i];

public static A179456Inst Instance=new A179456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179457
{
public static readonly long[] Value={ 1L,1L,2L,1L,5L,6L,1L,12L,23L,24L,1L,27L,93L,119L,120L,1L,58L,360L,662L,719L,720L,1L,121L,1312L,3728L,4919L,5039L,5040L,1L,248L,4541L,20160L,35779L,40072L,40319L,40320L,1L,503L,15111L,103345L,259535L,347769L,362377L,362879L,362880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179457Inst : IEnumerable<long>
{
public static readonly long[] Value=A179457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179457.Bytes);
public long this[int i]=>Value[i];

public static A179457Inst Instance=new A179457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179458
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,13L,15L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,85L,89L,91L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,271L,277L,281L,283L,293L,307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179458Inst : IEnumerable<long>
{
public static readonly long[] Value=A179458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179458.Bytes);
public long this[int i]=>Value[i];

public static A179458Inst Instance=new A179458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179459
{
public static readonly long[] Value={ 4L,9L,16L,25L,36L,49L,64L,81L,100L,121L,169L,225L,289L,441L,676L,729L,784L,1156L,1444L,1600L,2601L,3025L,4624L,7921L,12544L,20736L,23409L,27556L,31684L,47524L,54289L,139129L,142129L,171396L,217156L,372100L,974169L,1488400L,2550409L,6677056L,10201636L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179459Inst : IEnumerable<long>
{
public static readonly long[] Value=A179459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179459.Bytes);
public long this[int i]=>Value[i];

public static A179459Inst Instance=new A179459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179460
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,9L,10L,13L,14L,15L,17L,19L,21L,22L,27L,29L,30L,31L,33L,34L,35L,39L,41L,42L,49L,50L,51L,54L,55L,57L,61L,63L,65L,66L,69L,70L,71L,73L,75L,79L,82L,85L,86L,87L,89L,90L,91L,93L,97L,99L,101L,102L,103L,104L,105L,106L,107L,114L,115L,121L,122L,125L,126L,129L,133L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179460Inst : IEnumerable<long>
{
public static readonly long[] Value=A179460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179460.Bytes);
public long this[int i]=>Value[i];

public static A179460Inst Instance=new A179460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179461
{
public static readonly long[] Value={ 1L,0L,2L,0L,2L,0L,4L,0L,6L,1L,2L,2L,0L,4L,0L,7L,1L,4L,2L,5L,7L,1L,3L,4L,2L,8L,3L,0L,1L,9L,5L,3L,2L,3L,6L,1L,1L,2L,5L,2L,3L,1L,0L,1L,6L,5L,7L,0L,0L,3L,9L,0L,5L,4L,7L,6L,0L,1L,2L,0L,4L,4L,1L,1L,8L,2L,3L,6L,8L,8L,6L,2L,9L,4L,9L,1L,4L,3L,1L,6L,9L,8L,0L,3L,6L,9L,9L,8L,3L,1L,6L,2L,1L,8L,9L,7L,4L,3L,4L,5L,4L,6L,2L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179461Inst : IEnumerable<long>
{
public static readonly long[] Value=A179461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179461.Bytes);
public long this[int i]=>Value[i];

public static A179461Inst Instance=new A179461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179462
{
public static readonly long[] Value={ 1L,2L,11L,13L,20L,22L,101L,103L,105L,110L,114L,121L,200L,202L,204L,213L,1001L,1005L,1012L,1100L,1104L,1111L,1113L,1115L,1120L,2000L,2002L,10001L,10003L,10049L,10102L,10104L,11000L,11008L,20000L,20004L,20013L,20020L,20022L,20031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179462Inst : IEnumerable<long>
{
public static readonly long[] Value=A179462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179462.Bytes);
public long this[int i]=>Value[i];

public static A179462Inst Instance=new A179462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179463
{
public static readonly long[] Value={ 4L,6L,9L,14L,26L,34L,39L,46L,49L,62L,65L,69L,74L,86L,91L,93L,94L,95L,106L,119L,129L,134L,141L,142L,143L,145L,146L,159L,161L,166L,169L,194L,206L,209L,214L,219L,226L,247L,249L,254L,259L,262L,265L,267L,274L,289L,291L,295L,298L,299L,309L,314L,319L,326L,329L,334L,339L,341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179463Inst : IEnumerable<long>
{
public static readonly long[] Value=A179463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179463.Bytes);
public long this[int i]=>Value[i];

public static A179463Inst Instance=new A179463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179464
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,9L,9L,10L,11L,13L,13L,14L,15L,17L,17L,19L,19L,21L,21L,22L,23L,25L,25L,26L,29L,29L,29L,31L,31L,33L,33L,34L,35L,37L,37L,38L,39L,41L,41L,43L,43L,46L,46L,46L,47L,49L,49L,51L,51L,53L,53L,55L,55L,57L,57L,58L,59L,61L,61L,62L,65L,65L,65L,67L,67L,69L,69L,71L,71L,73L,73L,74L,77L,77L,77L,79L,79L,82L,82L,82L,83L,85L,85L,86L,87L,89L,89L,91L,91L,93L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179464Inst : IEnumerable<long>
{
public static readonly long[] Value=A179464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179464.Bytes);
public long this[int i]=>Value[i];

public static A179464Inst Instance=new A179464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179465
{
public static readonly long[] Value={ 1L,31L,396L,2673L,10076L,20153L,16739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179465Inst : IEnumerable<long>
{
public static readonly long[] Value=A179465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179465.Bytes);
public long this[int i]=>Value[i];

public static A179465Inst Instance=new A179465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179466
{
public static readonly long[] Value={ 1L,57L,1415L,19995L,176026L,989225L,3467544L,6935089L,6061476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179466Inst : IEnumerable<long>
{
public static readonly long[] Value=A179466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179466.Bytes);
public long this[int i]=>Value[i];

public static A179466Inst Instance=new A179466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179467
{
public static readonly long[] Value={ 1L,1L,3L,7L,19L,47L,131L,351L,992L,2808L,8131L,23723L,70192L,209209L,629165L,1904391L,5801109L,17764063L,54663309L,168925259L,524064687L,1631511342L,5095440198L,15960070908L,50124189982L,157806721089L,497953049736L,1574573746276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179467Inst : IEnumerable<long>
{
public static readonly long[] Value=A179467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179467.Bytes);
public long this[int i]=>Value[i];

public static A179467Inst Instance=new A179467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179468
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,22L,62L,146L,420L,1050L,3124L,7956L,23957L,62486L,192129L,509457L,1560782L,4196095L,13066095L,35437076L,109838408L,301261013L,944939968L,2605796828L,8124857765L,22597326279L,71095025143L,198583977503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179468Inst : IEnumerable<long>
{
public static readonly long[] Value=A179468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179468.Bytes);
public long this[int i]=>Value[i];

public static A179468Inst Instance=new A179468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179469
{
public static readonly long[] Value={ 1L,2L,8L,32L,140L,624L,2928L,14048L,69200L,347040L,1768120L,9122144L,47572128L,250341312L,1327718272L,7089595552L,38082093120L,205638343552L,1115635692576L,6078058719232L,33239328613648L,182402290944576L,1004073853702320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179469Inst : IEnumerable<long>
{
public static readonly long[] Value=A179469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179469.Bytes);
public long this[int i]=>Value[i];

public static A179469Inst Instance=new A179469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179470
{
public static readonly BigInteger[] Value={ 1L,1L,3L,15L,138L,2370L,78532L,5110472L,659436845L,169486506217L,86947958127377L,89122003350193045L,BigInteger.Parse("182611160539104099261"),BigInteger.Parse("748158103862060509908713"),BigInteger.Parse("6129659711065116858192667033"),BigInteger.Parse("100434475863953990317790200253757") };
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
public class A179470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179470Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179470.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179470.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179470Inst Instance=new A179470Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179471
{
public static readonly BigInteger[] Value={ 1L,1L,3L,15L,139L,2387L,79115L,5148411L,664332843L,170744863371L,87593505706987L,89783692196468907L,BigInteger.Parse("183966962290186844267"),BigInteger.Parse("753712824966410639243755"),BigInteger.Parse("6175169543791440589003293035"),BigInteger.Parse("101180154484297968338398947674219") };
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
public class A179471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179471Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179471.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179471.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179471Inst Instance=new A179471Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179472
{
public static readonly BigInteger[] Value={ 1L,1L,2L,16L,352L,19456L,2580480L,797442048L,562315657216L,890678506684416L,3130276584569700352L,BigInteger.Parse("24169368847503392243712"),BigInteger.Parse("406655844230538529416937472"),BigInteger.Parse("14808051220103187059129440010240") };
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
public class A179472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179472Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179472.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179472.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179472Inst Instance=new A179472Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179473
{
public static readonly BigInteger[] Value={ 1L,1L,3L,25L,553L,30593L,4058273L,1254164865L,884379898753L,1400813695453185L,4923141150511206913L,BigInteger.Parse("38012367976534051399681"),BigInteger.Parse("639567877826710211455375361"),BigInteger.Parse("23289359003850096570580313620481") };
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
public class A179473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179473Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179473.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179473.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179473Inst Instance=new A179473Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179474
{
public static readonly long[] Value={ 1L,8L,10L,18L,24L,29L,32L,37L,43L,56L,57L,61L,63L,67L,73L,74L,79L,84L,87L,100L,105L,110L,118L,125L,126L,130L,134L,143L,150L,157L,160L,165L,175L,177L,184L,185L,187L,188L,193L,200L,205L,215L,230L,233L,235L,242L,248L,256L,258L,261L,262L,265L,272L,276L,278L,279L,290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179474Inst : IEnumerable<long>
{
public static readonly long[] Value=A179474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179474.Bytes);
public long this[int i]=>Value[i];

public static A179474Inst Instance=new A179474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179475
{
public static readonly long[] Value={ 2L,3L,5L,4L,6L,3L,5L,2L,3L,2L,6L,5L,4L,3L,5L,4L,3L,2L,6L,5L,6L,3L,5L,2L,4L,5L,4L,6L,2L,4L,3L,2L,6L,5L,4L,6L,2L,4L,3L,6L,3L,5L,2L,3L,6L,5L,4L,3L,5L,4L,3L,6L,6L,3L,5L,2L,2L,4L,6L,3L,2L,3L,2L,5L,4L,5L,2L,3L,6L,4L,6L,5L,2L,2L,6L,5L,3L,4L,2L,6L,5L,3L,5L,2L,4L,3L,2L,4L,3L,6L,5L,4L,6L,5L,4L,3L,4L,6L,3L,2L,3L,5L,4L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179475Inst : IEnumerable<long>
{
public static readonly long[] Value=A179475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179475.Bytes);
public long this[int i]=>Value[i];

public static A179475Inst Instance=new A179475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179476
{
public static readonly long[] Value={ 1L,2L,4L,8L,17L,37L,85L,197L,465L,1106L,2656L,6414L,15582L,38011L,93124L,228927L,564674L,1396860L,3464995L,8616281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179476Inst : IEnumerable<long>
{
public static readonly long[] Value=A179476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179476.Bytes);
public long this[int i]=>Value[i];

public static A179476Inst Instance=new A179476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179477
{
public static readonly BigInteger[] Value={ 10L,99L,988L,9877L,98766L,987655L,9876544L,98765433L,987654322L,9876543211L,98765432100L,987654320989L,9876543209878L,98765432098767L,987654320987656L,9876543209876545L,98765432098765434L,987654320987654323L,9876543209876543212UL,BigInteger.Parse("98765432098765432101") };
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
public class A179477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179477Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179477.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179477.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179477Inst Instance=new A179477Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179478
{
public static readonly long[] Value={ 1L,2L,2L,6L,6L,12L,6L,18L,18L,6L,6L,6L,12L,12L,12L,6L,6L,6L,30L,30L,30L,18L,30L,6L,18L,6L,18L,24L,18L,12L,6L,18L,6L,24L,12L,48L,24L,6L,12L,30L,18L,12L,24L,18L,30L,6L,12L,30L,54L,12L,54L,6L,24L,30L,42L,18L,12L,36L,6L,6L,12L,24L,18L,12L,6L,6L,12L,12L,18L,24L,6L,12L,6L,12L,30L,48L,24L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179478Inst : IEnumerable<long>
{
public static readonly long[] Value=A179478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179478.Bytes);
public long this[int i]=>Value[i];

public static A179478Inst Instance=new A179478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179479
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,19L,29L,43L,53L,67L,71L,79L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179479Inst : IEnumerable<long>
{
public static readonly long[] Value=A179479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179479.Bytes);
public long this[int i]=>Value[i];

public static A179479Inst Instance=new A179479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179480
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,3L,2L,1L,5L,2L,6L,5L,5L,7L,2L,1L,6L,9L,6L,3L,3L,6L,12L,10L,4L,13L,10L,3L,15L,15L,2L,1L,17L,10L,18L,2L,10L,14L,20L,13L,21L,2L,14L,4L,6L,4L,18L,11L,9L,25L,26L,4L,27L,9L,18L,5L,22L,4L,12L,27L,10L,25L,2L,1L,33L,6L,18L,15L,35L,22L,30L,3L,22L,37L,6L,12L,10L,13L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179480Inst : IEnumerable<long>
{
public static readonly long[] Value=A179480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179480.Bytes);
public long this[int i]=>Value[i];

public static A179480Inst Instance=new A179480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179481
{
public static readonly long[] Value={ 3L,7L,11L,19L,23L,29L,37L,47L,53L,59L,67L,71L,79L,83L,101L,103L,107L,131L,139L,149L,163L,167L,173L,179L,191L,197L,199L,211L,227L,239L,263L,269L,271L,293L,311L,317L,347L,359L,367L,373L,379L,383L,389L,419L,443L,461L,463L,467L,479L,487L,491L,503L,509L,523L,541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179481Inst : IEnumerable<long>
{
public static readonly long[] Value=A179481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179481.Bytes);
public long this[int i]=>Value[i];

public static A179481Inst Instance=new A179481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179482
{
public static readonly long[] Value={ 126L,153L,688L,1395L,33579L,37668L,187029L,223524L,267034L,1008126L,1480368L,1514955L,1574253L,1766196L,1791495L,1831086L,1945944L,2784384L,10013323L,10353244L,18937617L,19437888L,23486976L,36528975L,38477586L,45334998L,48471696L,109019911L,116257833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179482Inst : IEnumerable<long>
{
public static readonly long[] Value=A179482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179482.Bytes);
public long this[int i]=>Value[i];

public static A179482Inst Instance=new A179482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179483
{
public static readonly long[] Value={ 3L,-9L,6L,36L,150L,540L,1806L,5796L,18150L,55980L,171006L,519156L,1569750L,4733820L,14250606L,42850116L,128746950L,386634060L,1160688606L,3483638676L,10454061750L,31368476700L,94118013006L,282379204836L,847187946150L,2541664501740L,7625194831806L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179483Inst : IEnumerable<long>
{
public static readonly long[] Value=A179483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179483.Bytes);
public long this[int i]=>Value[i];

public static A179483Inst Instance=new A179483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179484
{
public static readonly long[] Value={ 181L,349L,2029L,8101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179484Inst : IEnumerable<long>
{
public static readonly long[] Value=A179484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179484.Bytes);
public long this[int i]=>Value[i];

public static A179484Inst Instance=new A179484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179485
{
public static readonly long[] Value={ 8L,100L,1120L,1220L,1300L,2240L,2380L,2414L,3536L,3634L,4906L,4940L,5566L,5740L,6706L,7240L,8864L,9224L,9394L,10136L,10850L,12040L,12476L,12586L,12920L,13180L,13334L,13754L,14630L,14720L,15134L,16270L,17710L,18430L,18800L,19916L,21014L,21320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179485Inst : IEnumerable<long>
{
public static readonly long[] Value=A179485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179485.Bytes);
public long this[int i]=>Value[i];

public static A179485Inst Instance=new A179485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179486
{
public static readonly long[] Value={ 1L,1L,3L,12L,56L,285L,1533L,8571L,49311L,290019L,1735845L,10538550L,64741482L,401708636L,2513837931L,15847467276L,100547976684L,641571037002L,4114313992851L,26503239829953L,171416342026944L,1112726829455289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179486Inst : IEnumerable<long>
{
public static readonly long[] Value=A179486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179486.Bytes);
public long this[int i]=>Value[i];

public static A179486Inst Instance=new A179486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179487
{
public static readonly long[] Value={ 1L,3L,12L,55L,276L,1470L,8160L,46692L,273450L,1631091L,9874836L,60522111L,374783066L,2341345848L,14738239920L,93389126442L,595210710006L,3813127548837L,24540706889124L,158592962937843L,1028721051285840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179487Inst : IEnumerable<long>
{
public static readonly long[] Value=A179487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179487.Bytes);
public long this[int i]=>Value[i];

public static A179487Inst Instance=new A179487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179488
{
public static readonly long[] Value={ 1L,1L,2L,7L,32L,172L,1052L,7177L,53792L,437992L,3841772L,36060262L,360234512L,3812425912L,42576007352L,500022862357L,6157034292032L,79278216024592L,1064888929532492L,14890014669234922L,216315676347260912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179488Inst : IEnumerable<long>
{
public static readonly long[] Value=A179488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179488.Bytes);
public long this[int i]=>Value[i];

public static A179488Inst Instance=new A179488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179489
{
public static readonly long[] Value={ 1L,1L,2L,8L,44L,288L,2172L,18516L,175352L,1819868L,20491844L,248417128L,3221797252L,44464876996L,650076797232L,10028658649668L,162695157490644L,2767333692834768L,49221196196394252L,913310582666986596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179489Inst : IEnumerable<long>
{
public static readonly long[] Value=A179489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179489.Bytes);
public long this[int i]=>Value[i];

public static A179489Inst Instance=new A179489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179490
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,22L,63L,148L,429L,1093L,3233L,8235L,25361L,65890L,201793L,544175L,1667061L,4481965L,14036608L,38084873L,118657467L,328157619L,1023953705L,2831122937L,8891271200L,24765261847L,77805405420L,218807381684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179490Inst : IEnumerable<long>
{
public static readonly long[] Value=A179490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179490.Bytes);
public long this[int i]=>Value[i];

public static A179490Inst Instance=new A179490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179491
{
public static readonly long[] Value={ 1L,3L,7L,23L,51L,201L,442L,1663L,4156L,15083L,35564L,139961L,329694L,1244834L,3162552L,11494207L,28340038L,108476634L,266695553L,992977283L,2544862201L,9319498334L,23550935216L,87424092169L,222620040051L,819109845024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179491Inst : IEnumerable<long>
{
public static readonly long[] Value=A179491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179491.Bytes);
public long this[int i]=>Value[i];

public static A179491Inst Instance=new A179491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179492
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,5L,6L,9L,12L,15L,20L,27L,36L,47L,63L,83L,109L,144L,190L,251L,331L,436L,575L,759L,1001L,1319L,1739L,2293L,3023L,3985L,5254L,6927L,9132L,12039L,15871L,20923L,27583L,36363L,47938L,63197L,83313L,109833L,144794L,190884L,251644L,331745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179492Inst : IEnumerable<long>
{
public static readonly long[] Value=A179492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179492.Bytes);
public long this[int i]=>Value[i];

public static A179492Inst Instance=new A179492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179493
{
public static readonly BigInteger[] Value={ 0L,1L,2L,12L,108L,1420L,24660L,541968L,14547792L,465228720L,17385553440L,747776581200L,36566808933600L,2012537262763872L,123612631608883872L,8412289268206662720L,BigInteger.Parse("630378349868153698560"),BigInteger.Parse("51733701375836221013760") };
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
public class A179493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179493Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179493.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179493.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179493Inst Instance=new A179493Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179494
{
public static readonly BigInteger[] Value={ 1L,1L,4L,27L,284L,4110L,77424L,1818474L,51692080L,1738555344L,67979689200L,3047234077800L,154810558674144L,8829473686348848L,560819284547110848L,BigInteger.Parse("39398646866759606160"),BigInteger.Parse("3043158904460954177280"),BigInteger.Parse("257091879144869492997120") };
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
public class A179494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179494Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179494.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179494.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179494Inst Instance=new A179494Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179495
{
public static readonly BigInteger[] Value={ 0L,1L,2L,12L,84L,820L,9540L,132888L,2129232L,38760048L,788500800L,17740459440L,437238410400L,11716457100192L,339129808346784L,10544636706428160L,350515939418507520L,12404398847785793280UL,BigInteger.Parse("465618362609300313600") };
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
public class A179495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179495Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179495.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179495.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179495Inst Instance=new A179495Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179496
{
public static readonly BigInteger[] Value={ 1L,1L,4L,21L,164L,1590L,18984L,266154L,4306672L,78850080L,1612769040L,36436534200L,901265930784L,24223557739056L,702975780428544L,21907246213656720L,729670520457987840L,BigInteger.Parse("25867686811627795200"),BigInteger.Parse("972505009580975483904") };
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
public class A179496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179496Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179496.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179496.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179496Inst Instance=new A179496Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179497
{
public static readonly BigInteger[] Value={ 1L,2L,18L,312L,8240L,297000L,13705776L,776778688L,52511234688L,4143702216960L,375403993060800L,38537107042934016L,4435139176244554752L,BigInteger.Parse("567238312617468850176"),BigInteger.Parse("80029364113424328422400") };
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
public class A179497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179497Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179497.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179497.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179497Inst Instance=new A179497Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179498
{
public static readonly BigInteger[] Value={ 1L,1L,6L,78L,1648L,49500L,1957968L,97097336L,5834581632L,414370221696L,34127635732800L,3211425586911168L,341164552018811904L,BigInteger.Parse("40517022329819203584"),BigInteger.Parse("5335290940894955228160"),BigInteger.Parse("773591071307555130451200") };
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
public class A179498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179498Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179498.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179498.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179498Inst Instance=new A179498Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179499
{
public static readonly BigInteger[] Value={ 1L,4L,42L,768L,20680L,749040L,34497792L,1944626432L,130528288512L,10219233265920L,918320724657600L,93509880099305472L,10677268138244018688UL,BigInteger.Parse("1355273477576934150144"),BigInteger.Parse("189834913883100796531200") };
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
public class A179499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179499Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179499.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179499.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179499Inst Instance=new A179499Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179500
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,16L,74L,612L,12271L,893422L,414194958L,2790004382642L,907459561737399050L,BigInteger.Parse("79479770316224310083608800"),BigInteger.Parse("22570656733849188237806831031463922346") };
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
public class A179500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179500Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179500.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179500.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179500Inst Instance=new A179500Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179501
{
public static readonly BigInteger[] Value={ 1L,3L,10L,43L,276L,3138L,80998L,7043187L,3719589796L,27895892650378L,9982024484486217164UL,BigInteger.Parse("953757232905143490078932902"),BigInteger.Parse("293418537539006210065580840496997061594") };
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
public class A179501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179501Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179501.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179501.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179501Inst Instance=new A179501Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179502
{
public static readonly long[] Value={ 11L,29L,79L,271L,379L,461L,521L,631L,739L,881L,929L,1459L,1531L,1709L,2161L,2239L,2341L,2729L,3049L,3491L,3709L,4021L,4349L,4561L,4691L,5021L,5281L,5851L,5879L,6301L,6329L,6829L,7559L,8009L,9151L,10069L,10099L,10151L,10529L,10891L,11719L,11959L,11969L,13799L,14051L,14159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179502Inst : IEnumerable<long>
{
public static readonly long[] Value=A179502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179502.Bytes);
public long this[int i]=>Value[i];

public static A179502Inst Instance=new A179502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179503
{
public static readonly BigInteger[] Value={ 1L,2L,38L,352L,8372L,115584L,4900168L,109607936L,5462020742L,210689453568L,11579697409448L,585804318154752L,39828186864515408L,2482740302750253056L,BigInteger.Parse("188760627291893696552"),BigInteger.Parse("14430243196023615258624") };
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
public class A179503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179503Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179503.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179503.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179503Inst Instance=new A179503Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179504
{
public static readonly BigInteger[] Value={ 1L,3L,21L,252L,4369L,103158L,3037530L,106237176L,4311810305L,198756808749L,10250010815226L,584603613083988L,36529334450076658L,2481455748310337022L,BigInteger.Parse("182070232515259616850"),BigInteger.Parse("14349345894391097803752") };
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
public class A179504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179504Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A179504.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A179504.Bytes);
public BigInteger this[int i]=>Value[i];

public static A179504Inst Instance=new A179504Inst();

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