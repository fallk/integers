using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A156705
{
public static readonly BigInteger[] Value={ 1L,-9L,-70L,4509L,30170L,-1671849L,-33017110L,10288405413L,67607285690L,-6774813697599L,-222549868079350L,54517401073397079L,1074501236150606810L,BigInteger.Parse("-155538551845927881549"),BigInteger.Parse("-7152956142185399429590"),BigInteger.Parse("9557732764973420897505381"),BigInteger.Parse("62791988710527474778497530") };
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
public class A156705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156705Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156705.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156705.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156705Inst Instance=new A156705Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156706
{
public static readonly long[] Value={ -1L,1L,-1L,1L,-1L,1L,-1L,0L,-1L,1L,0L,1L,-1L,1L,-1L,0L,-1L,0L,-1L,1L,0L,1L,-1L,1L,0L,1L,-1L,0L,-1L,0L,0L,1L,-1L,1L,-1L,1L,-1L,0L,0L,0L,0L,1L,-1L,0L,-1L,1L,0L,0L,-1L,1L,0L,1L,0L,1L,-1L,0L,-1L,0L,-1L,1L,0L,0L,-1L,1L,-1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,-1L,1L,-1L,0L,-1L,1L,0L,0L,-1L,0L,-1L,0L,-1L,0L,-1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156706Inst : IEnumerable<long>
{
public static readonly long[] Value=A156706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156706.Bytes);
public long this[int i]=>Value[i];

public static A156706Inst Instance=new A156706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156707
{
public static readonly long[] Value={ -1L,1L,-1L,0L,-1L,1L,0L,1L,-1L,0L,-1L,0L,0L,1L,-1L,0L,0L,1L,0L,1L,-1L,0L,-1L,0L,0L,1L,0L,0L,-1L,1L,0L,0L,-1L,0L,-1L,1L,0L,0L,-1L,0L,-1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,-1L,0L,-1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,-1L,0L,-1L,0L,0L,1L,-1L,0L,0L,0L,0L,1L,-1L,0L,0L,1L,0L,0L,-1L,0L,-1L,0L,0L,1L,0L,0L,-1L,1L,0L,0L,0L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156707Inst : IEnumerable<long>
{
public static readonly long[] Value=A156707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156707.Bytes);
public long this[int i]=>Value[i];

public static A156707Inst Instance=new A156707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156708
{
public static readonly long[] Value={ 1L,2L,1L,4L,4L,1L,8L,11L,5L,1L,16L,26L,16L,6L,1L,32L,57L,42L,22L,7L,1L,64L,120L,99L,64L,29L,8L,1L,128L,247L,219L,163L,93L,37L,9L,1L,256L,502L,466L,382L,256L,130L,46L,10L,1L,512L,1013L,968L,848L,638L,386L,176L,56L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156708Inst : IEnumerable<long>
{
public static readonly long[] Value=A156708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156708.Bytes);
public long this[int i]=>Value[i];

public static A156708Inst Instance=new A156708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156709
{
public static readonly long[] Value={ -1L,0L,-1L,0L,-1L,0L,-1L,-1L,-2L,-1L,-1L,0L,-1L,0L,-1L,-1L,-2L,-2L,-3L,-2L,-2L,-1L,-2L,-1L,-1L,0L,-1L,-1L,-2L,-2L,-2L,-1L,-2L,-1L,-2L,-1L,-2L,-2L,-2L,-2L,-2L,-1L,-2L,-2L,-3L,-2L,-2L,-2L,-3L,-2L,-2L,-1L,-1L,0L,-1L,-1L,-2L,-2L,-3L,-2L,-2L,-2L,-3L,-2L,-3L,-2L,-2L,-2L,-2L,-1L,-1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156709Inst : IEnumerable<long>
{
public static readonly long[] Value=A156709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156709.Bytes);
public long this[int i]=>Value[i];

public static A156709Inst Instance=new A156709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156710
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,3L,6L,6L,1L,3L,6L,18L,16L,1L,3L,6L,18L,48L,44L,1L,3L,6L,18L,48L,132L,120L,136L,18L,48L,132L,360L,328L,1L,3L,6L,18L,48L,132L,360L,984L,896L,1L,3L,6L,18L,48L,132L,360L,984L,2688L,2448L,1L,3L,6L,18L,48L,132L,360L,984L,2688L,7344L,6688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156710Inst : IEnumerable<long>
{
public static readonly long[] Value=A156710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156710.Bytes);
public long this[int i]=>Value[i];

public static A156710Inst Instance=new A156710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156711
{
public static readonly long[] Value={ 28L,299L,858L,1705L,2840L,4263L,5974L,7973L,10260L,12835L,15698L,18849L,22288L,26015L,30030L,34333L,38924L,43803L,48970L,54425L,60168L,66199L,72518L,79125L,86020L,93203L,100674L,108433L,116480L,124815L,133438L,142349L,151548L,161035L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156711Inst : IEnumerable<long>
{
public static readonly long[] Value=A156711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156711.Bytes);
public long this[int i]=>Value[i];

public static A156711Inst Instance=new A156711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156712
{
public static readonly BigInteger[] Value={ 1L,7L,91L,1261L,17557L,244531L,3405871L,47437657L,660721321L,9202660831L,128176530307L,1785268763461L,24865586158141L,346332937450507L,4823795538148951L,67186804596634801L,935791468814738257L,13033893758809700791UL,BigInteger.Parse("181538721154521072811") };
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
public class A156712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156712Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156712.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156712.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156712Inst Instance=new A156712Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156713
{
public static readonly long[] Value={ 12005L,12467L,12985L,14063L,15025L,16807L,19073L,20923L,24157L,26747L,31213L,40817L,48055L,53753L,63455L,71077L,84035L,99413L,111475L,131957L,148015L,175273L,232897L,275863L,309533L,366667L,411437L,487403L,577405L,647927L,767585L,861343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156713Inst : IEnumerable<long>
{
public static readonly long[] Value=A156713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156713.Bytes);
public long this[int i]=>Value[i];

public static A156713Inst Instance=new A156713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156714
{
public static readonly BigInteger[] Value={ 1L,-7L,-78L,3619L,34242L,-1349047L,-37558638L,8307763163L,76926573282L,-5471036646817L,-253234420408398L,44026233246763369L,1222654371574693122L,BigInteger.Parse("-125607305261028115987"),BigInteger.Parse("-8139214655788357421358"),BigInteger.Parse("7718479984058355255697051"),BigInteger.Parse("71449829249126826451689762") };
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
public class A156714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156714Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156714.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156714.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156714Inst Instance=new A156714Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156715
{
public static readonly long[] Value={ 3L,3L,3L,12L,3L,3L,25L,25L,3L,3L,42L,90L,42L,3L,3L,63L,231L,231L,63L,3L,3L,88L,490L,840L,490L,88L,3L,3L,117L,918L,2394L,2394L,918L,117L,3L,3L,150L,1575L,5796L,8820L,5796L,1575L,150L,3L,3L,187L,2530L,12474L,26796L,26796L,12474L,2530L,187L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156715Inst : IEnumerable<long>
{
public static readonly long[] Value=A156715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156715.Bytes);
public long this[int i]=>Value[i];

public static A156715Inst Instance=new A156715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156716
{
public static readonly long[] Value={ 5L,0L,5L,5L,15L,15L,5L,5L,35L,70L,35L,5L,5L,60L,210L,210L,60L,5L,5L,90L,486L,840L,486L,90L,5L,5L,125L,960L,2550L,2550L,960L,125L,5L,5L,165L,1705L,6435L,9900L,6435L,1705L,165L,5L,5L,210L,2805L,14245L,31185L,31185L,14245L,2805L,210L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156716Inst : IEnumerable<long>
{
public static readonly long[] Value=A156716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156716.Bytes);
public long this[int i]=>Value[i];

public static A156716Inst Instance=new A156716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156717
{
public static readonly long[] Value={ 2L,2L,2L,2L,6L,2L,2L,11L,11L,2L,2L,17L,30L,17L,2L,2L,24L,63L,63L,24L,2L,2L,32L,115L,168L,115L,32L,2L,2L,41L,192L,375L,375L,192L,41L,2L,2L,51L,301L,748L,990L,748L,301L,51L,2L,2L,62L,450L,1379L,2288L,2288L,1379L,450L,62L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156717Inst : IEnumerable<long>
{
public static readonly long[] Value=A156717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156717.Bytes);
public long this[int i]=>Value[i];

public static A156717Inst Instance=new A156717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156718
{
public static readonly long[] Value={ 70L,99L,239L,268L,408L,437L,577L,606L,746L,775L,915L,944L,1084L,1113L,1253L,1282L,1422L,1451L,1591L,1620L,1760L,1789L,1929L,1958L,2098L,2127L,2267L,2296L,2436L,2465L,2605L,2634L,2774L,2803L,2943L,2972L,3112L,3141L,3281L,3310L,3450L,3479L,3619L,3648L,3788L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156718Inst : IEnumerable<long>
{
public static readonly long[] Value=A156718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156718.Bytes);
public long this[int i]=>Value[i];

public static A156718Inst Instance=new A156718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156719
{
public static readonly long[] Value={ 45L,350L,943L,1824L,2993L,4450L,6195L,8228L,10549L,13158L,16055L,19240L,22713L,26474L,30523L,34860L,39485L,44398L,49599L,55088L,60865L,66930L,73283L,79924L,86853L,94070L,101575L,109368L,117449L,125818L,134475L,143420L,152653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156719Inst : IEnumerable<long>
{
public static readonly long[] Value=A156719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156719.Bytes);
public long this[int i]=>Value[i];

public static A156719Inst Instance=new A156719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156720
{
public static readonly BigInteger[] Value={ 1L,-5L,-84L,2645L,37380L,-990125L,-41075244L,6100987285L,84147366660L,-4018059515075L,-277011341395404L,32334176427828815L,1337456651437946340L,BigInteger.Parse("-92249828940696374225"),BigInteger.Parse("-8903456587278888387564"),BigInteger.Parse("5668687258864979375891525"),BigInteger.Parse("78158704678426515547572420") };
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
public class A156720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156720Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156720.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156720.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156720Inst Instance=new A156720Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156721
{
public static readonly long[] Value={ 19603L,143649L,381939L,734473L,1201251L,1782273L,2477539L,3287049L,4210803L,5248801L,6401043L,7667529L,9048259L,10543233L,12152451L,13875913L,15713619L,17665569L,19731763L,21912201L,24206883L,26615809L,29138979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156721Inst : IEnumerable<long>
{
public static readonly long[] Value=A156721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156721.Bytes);
public long this[int i]=>Value[i];

public static A156721Inst Instance=new A156721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156722
{
public static readonly long[] Value={ 1L,1L,1L,1L,-1L,1L,1L,7L,7L,1L,1L,-91L,637L,-91L,1L,1L,1729L,157339L,157339L,1729L,1L,1L,-43225L,74736025L,-971568325L,74736025L,-43225L,1L,1L,1339975L,57920419375L,14306343585625L,14306343585625L,57920419375L,1339975L,1L,1L,-49579075L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156722Inst : IEnumerable<long>
{
public static readonly long[] Value=A156722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156722.Bytes);
public long this[int i]=>Value[i];

public static A156722Inst Instance=new A156722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156723
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,1L,2L,3L,2L,3L,4L,3L,4L,3L,4L,5L,4L,5L,4L,5L,6L,7L,6L,7L,8L,9L,8L,9L,8L,9L,10L,9L,10L,11L,12L,11L,12L,13L,12L,13L,12L,13L,14L,15L,14L,15L,16L,17L,16L,17L,18L,17L,18L,17L,18L,19L,18L,19L,18L,19L,20L,21L,20L,21L,22L,21L,22L,21L,22L,23L,22L,23L,24L,25L,24L,25L,26L,27L,26L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156723Inst : IEnumerable<long>
{
public static readonly long[] Value=A156723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156723.Bytes);
public long this[int i]=>Value[i];

public static A156723Inst Instance=new A156723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156724
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,3L,3L,5L,5L,5L,7L,7L,9L,9L,9L,9L,11L,11L,13L,13L,13L,15L,15L,17L,17L,17L,17L,19L,19L,19L,21L,21L,21L,21L,23L,23L,25L,25L,27L,27L,27L,27L,27L,29L,29L,31L,31L,31L,31L,31L,33L,33L,35L,35L,37L,37L,37L,37L,39L,39L,39L,41L,41L,41L,43L,43L,43L,43L,45L,45L,45L,47L,47L,49L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156724Inst : IEnumerable<long>
{
public static readonly long[] Value=A156724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156724.Bytes);
public long this[int i]=>Value[i];

public static A156724Inst Instance=new A156724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156725
{
public static readonly long[] Value={ 1L,1L,1L,1L,-2L,1L,1L,22L,22L,1L,1L,-440L,4840L,-440L,1L,1L,12760L,2807200L,2807200L,12760L,1L,1L,-484880L,3093534400L,-61870688000L,3093534400L,-484880L,1L,1L,22789360L,5525052438400L,3204530414272000L,3204530414272000L,5525052438400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156725Inst : IEnumerable<long>
{
public static readonly long[] Value=A156725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156725.Bytes);
public long this[int i]=>Value[i];

public static A156725Inst Instance=new A156725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156726
{
public static readonly long[] Value={ 0L,0L,0L,2L,2L,4L,4L,4L,4L,4L,6L,6L,8L,8L,8L,10L,10L,12L,12L,12L,12L,14L,14L,16L,16L,18L,18L,18L,18L,18L,20L,20L,22L,22L,22L,22L,24L,24L,26L,26L,26L,28L,28L,28L,30L,30L,30L,30L,32L,32L,32L,34L,34L,36L,36L,36L,36L,38L,38L,40L,40L,40L,40L,40L,42L,42L,44L,44L,44L,44L,44L,46L,46L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156726Inst : IEnumerable<long>
{
public static readonly long[] Value=A156726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156726.Bytes);
public long this[int i]=>Value[i];

public static A156726Inst Instance=new A156726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156727
{
public static readonly long[] Value={ 1L,1L,1L,1L,-3L,1L,1L,45L,45L,1L,1L,-1215L,18225L,-1215L,1L,1L,47385L,19190925L,19190925L,47385L,1L,1L,-2416635L,38170749825L,-1030610245275L,38170749825L,-2416635L,1L,1L,152248005L,122642619187725L,129142678004674425L,129142678004674425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156727Inst : IEnumerable<long>
{
public static readonly long[] Value=A156727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156727.Bytes);
public long this[int i]=>Value[i];

public static A156727Inst Instance=new A156727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156728
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156728Inst : IEnumerable<long>
{
public static readonly long[] Value=A156728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156728.Bytes);
public long this[int i]=>Value[i];

public static A156728Inst Instance=new A156728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156729
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156729Inst : IEnumerable<long>
{
public static readonly long[] Value=A156729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156729.Bytes);
public long this[int i]=>Value[i];

public static A156729Inst Instance=new A156729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156730
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,2L,1L,7L,-25L,6L,1L,9L,-98L,-875L,24L,1L,11L,-243L,-15092L,398125L,120L,1L,13L,-484L,-98415L,46483360L,3441790625L,720L,1L,15L,-845L,-404624L,1076168025L,4151893715200L,-743856998828125L,5040L,1L,17L,-1350L,-1263275L,11501032576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156730Inst : IEnumerable<long>
{
public static readonly long[] Value=A156730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156730.Bytes);
public long this[int i]=>Value[i];

public static A156730Inst Instance=new A156730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156731
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156731Inst : IEnumerable<long>
{
public static readonly long[] Value=A156731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156731.Bytes);
public long this[int i]=>Value[i];

public static A156731Inst Instance=new A156731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156732
{
public static readonly long[] Value={ 0L,1L,1L,4L,0L,4L,9L,2L,2L,9L,16L,10L,0L,10L,16L,25L,27L,5L,5L,27L,25L,36L,56L,28L,0L,28L,56L,36L,49L,100L,84L,14L,14L,84L,100L,49L,64L,162L,192L,84L,0L,84L,192L,162L,64L,81L,245L,375L,270L,42L,42L,270L,375L,245L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156732Inst : IEnumerable<long>
{
public static readonly long[] Value=A156732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156732.Bytes);
public long this[int i]=>Value[i];

public static A156732Inst Instance=new A156732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156733
{
public static readonly long[] Value={ 1L,1L,11L,41L,176L,606L,2391L,8091L,28636L,95056L,316048L,1014240L,3237325L,10082015L,31109500L,94352346L,283209381L,838650191L,2458835711L,7127912979L,20471486368L,58224189612L,164181018330L,458982667630L,1273039111210L,3503609456548L,9572771822745L,25971150308985L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156733Inst : IEnumerable<long>
{
public static readonly long[] Value=A156733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156733.Bytes);
public long this[int i]=>Value[i];

public static A156733Inst Instance=new A156733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156734
{
public static readonly long[] Value={ 1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156734Inst : IEnumerable<long>
{
public static readonly long[] Value=A156734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156734.Bytes);
public long this[int i]=>Value[i];

public static A156734Inst Instance=new A156734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156735
{
public static readonly long[] Value={ 9801L,114243L,332929L,665859L,1113033L,1674451L,2350113L,3140019L,4044169L,5062563L,6195201L,7442083L,8803209L,10278579L,11868193L,13572051L,15390153L,17322499L,19369089L,21529923L,23805001L,26194323L,28697889L,31315699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156735Inst : IEnumerable<long>
{
public static readonly long[] Value=A156735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156735.Bytes);
public long this[int i]=>Value[i];

public static A156735Inst Instance=new A156735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156736
{
public static readonly BigInteger[] Value={ 1L,2L,14L,-1582L,-7497258L,303297921775458L,BigInteger.Parse("-2646995089135122277190614296178"),BigInteger.Parse("82888930564911423983289917045230098319343306166666586941750246") };
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
public class A156736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156736Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156736.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156736.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156736Inst Instance=new A156736Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156737
{
public static readonly BigInteger[] Value={ 1L,-3L,-88L,1611L,39512L,-604803L,-43472968L,3728240427L,89073174872L,-2455513901613L,-293232235293448L,19760158012503441L,1415776664259943832L,BigInteger.Parse("-56376027452001277023"),BigInteger.Parse("-9424835479770725654728"),BigInteger.Parse("3464267588648611359658299"),BigInteger.Parse("82735614434542157259090392") };
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
public class A156737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156737Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156737.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156737.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156737Inst Instance=new A156737Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156738
{
public static readonly BigInteger[] Value={ 1L,-1L,-90L,541L,40590L,-203401L,-44687970L,1254112037L,91570023630L,-826012235551L,-301454785512450L,6647155741019671L,1455478124167389870L,BigInteger.Parse("-18964441825936233901"),BigInteger.Parse("-9689129535589841904930"),BigInteger.Parse("1165351776696760349312869"),BigInteger.Parse("85055712408455297951111310") };
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
public class A156738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156738Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156738.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156738.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156738Inst Instance=new A156738Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156739
{
public static readonly long[] Value={ 1L,1L,1L,1L,120L,1L,1L,3060L,3060L,1L,1L,38760L,988380L,38760L,1L,1L,319770L,103285710L,103285710L,319770L,1L,1L,1961256L,5226256926L,66199254396L,5226256926L,1961256L,1L,1L,9657700L,157843517260L,16494647553670L,16494647553670L,157843517260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156739Inst : IEnumerable<long>
{
public static readonly long[] Value=A156739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156739.Bytes);
public long this[int i]=>Value[i];

public static A156739Inst Instance=new A156739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156740
{
public static readonly long[] Value={ 1L,1L,1L,1L,153L,1L,1L,4845L,4845L,1L,1L,74613L,2362745L,74613L,1L,1L,735471L,358664691L,358664691L,735471L,1L,1L,5311735L,25533510145L,393216056233L,25533510145L,5311735L,1L,1L,30421755L,1056158828725L,160324910200455L,160324910200455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156740Inst : IEnumerable<long>
{
public static readonly long[] Value=A156740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156740.Bytes);
public long this[int i]=>Value[i];

public static A156740Inst Instance=new A156740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156741
{
public static readonly long[] Value={ 1L,1L,1L,1L,190L,1L,1L,7315L,7315L,1L,1L,134596L,5181946L,134596L,1L,1L,1562275L,1106715610L,1106715610L,1562275L,1L,1L,13123110L,107904771975L,1985447804340L,107904771975L,13123110L,1L,1L,86493225L,5974000557525L,1275875833357125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156741Inst : IEnumerable<long>
{
public static readonly long[] Value=A156741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156741.Bytes);
public long this[int i]=>Value[i];

public static A156741Inst Instance=new A156741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156742
{
public static readonly long[] Value={ 1L,1L,1L,1L,231L,1L,1L,10626L,10626L,1L,1L,230230L,10590580L,230230L,1L,1L,3108105L,3097744650L,3097744650L,3108105L,1L,1L,30045015L,404255676825L,8758872997875L,404255676825L,30045015L,1L,1L,225792840L,29367745734600L,8590065627370500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156742Inst : IEnumerable<long>
{
public static readonly long[] Value=A156742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156742.Bytes);
public long this[int i]=>Value[i];

public static A156742Inst Instance=new A156742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156743
{
public static readonly long[] Value={ 4L,3L,4L,4L,4L,4L,3L,4L,4L,3L,4L,4L,3L,4L,4L,4L,4L,3L,4L,4L,3L,4L,4L,4L,4L,4L,4L,4L,3L,4L,4L,3L,4L,4L,4L,4L,3L,4L,4L,3L,4L,4L,4L,4L,4L,4L,4L,3L,4L,4L,3L,4L,4L,4L,4L,4L,4L,4L,3L,4L,4L,4L,4L,3L,4L,4L,3L,4L,4L,3L,4L,4L,4L,4L,3L,4L,4L,3L,4L,4L,4L,4L,4L,4L,4L,3L,4L,4L,3L,4L,3L,4L,4L,4L,4L,4L,3L,4L,4L,4L,4L,3L,4L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156743Inst : IEnumerable<long>
{
public static readonly long[] Value=A156743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156743.Bytes);
public long this[int i]=>Value[i];

public static A156743Inst Instance=new A156743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156744
{
public static readonly long[] Value={ -1L,0L,1L,1L,-8L,0L,8L,-1L,-1L,9L,-45L,0L,45L,-9L,1L,3L,-32L,168L,-672L,0L,672L,-168L,32L,-3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156744Inst : IEnumerable<long>
{
public static readonly long[] Value=A156744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156744.Bytes);
public long this[int i]=>Value[i];

public static A156744Inst Instance=new A156744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156745
{
public static readonly long[] Value={ 2L,5L,8L,12L,15L,20L,23L,28L,32L,37L,40L,47L,50L,55L,60L,66L,69L,76L,79L,86L,91L,96L,99L,108L,112L,117L,122L,129L,132L,141L,144L,151L,156L,161L,166L,176L,179L,184L,189L,198L,201L,210L,213L,220L,227L,232L,235L,246L,250L,257L,262L,269L,272L,281L,286L,295L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156745Inst : IEnumerable<long>
{
public static readonly long[] Value=A156745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156745.Bytes);
public long this[int i]=>Value[i];

public static A156745Inst Instance=new A156745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156746
{
public static readonly BigInteger[] Value={ 1L,-9L,-19L,1971L,7961L,-1580049L,-9560059L,2686469931L,21670511921L,-7838281432089L,-79034002960099L,34943616861129891L,422806632973239881L,BigInteger.Parse("-220928651974538628129"),BigInteger.Parse("-3118693689740162472139"),BigInteger.Parse("1880318896105818396109851"),BigInteger.Parse("30335009203988869812319841") };
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
public class A156746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156746Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156746.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156746.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156746Inst Instance=new A156746Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156747
{
public static readonly long[] Value={ 0L,0L,0L,-1L,0L,2L,2L,3L,2L,2L,0L,-1L,2L,0L,2L,-1L,0L,4L,4L,7L,6L,8L,6L,7L,4L,4L,0L,-1L,4L,2L,6L,3L,6L,2L,4L,-1L,0L,6L,6L,11L,10L,14L,12L,15L,12L,14L,10L,11L,6L,6L,0L,-1L,6L,4L,10L,7L,12L,8L,12L,7L,10L,4L,6L,-1L,0L,8L,8L,15L,14L,20L,18L,23L,20L,24L,20L,23L,18L,20L,14L,15L,8L,8L,0L,-1L,8L,6L,14L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156747Inst : IEnumerable<long>
{
public static readonly long[] Value=A156747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156747.Bytes);
public long this[int i]=>Value[i];

public static A156747Inst Instance=new A156747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156748
{
public static readonly long[] Value={ -1L,0L,0L,2L,2L,-1L,-2L,-2L,4L,4L,3L,4L,0L,-2L,-2L,3L,2L,4L,6L,0L,-5L,-4L,4L,6L,4L,5L,2L,-4L,-6L,0L,7L,6L,4L,4L,-2L,-1L,0L,8L,8L,0L,-1L,-2L,8L,8L,4L,5L,0L,0L,0L,4L,3L,0L,0L,-2L,4L,5L,4L,4L,0L,-4L,-5L,4L,4L,10L,14L,3L,-6L,-6L,4L,10L,5L,4L,4L,-6L,2L,7L,16L,16L,4L,-4L,-9L,8L,8L,22L,30L,7L,-10L,-10L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156748Inst : IEnumerable<long>
{
public static readonly long[] Value=A156748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156748.Bytes);
public long this[int i]=>Value[i];

public static A156748Inst Instance=new A156748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156749
{
public static readonly long[] Value={ -1L,0L,-1L,-1L,-2L,-1L,-1L,0L,-1L,-1L,-2L,-2L,-2L,-1L,-2L,-2L,-2L,-1L,-1L,0L,-1L,-1L,-2L,-2L,-2L,-1L,-1L,-1L,-2L,-1L,-1L,-1L,-2L,-2L,-3L,-2L,-2L,-2L,-3L,-3L,-4L,-4L,-4L,-3L,-3L,-3L,-3L,-2L,-2L,-1L,-2L,-2L,-3L,-2L,-2L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-2L,-2L,-3L,-3L,-3L,-2L,-3L,-3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156749Inst : IEnumerable<long>
{
public static readonly long[] Value=A156749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156749.Bytes);
public long this[int i]=>Value[i];

public static A156749Inst Instance=new A156749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156750
{
public static readonly BigInteger[] Value={ 1L,2L,15L,243L,69282L,36600664305L,BigInteger.Parse("6435072487994269232829"),BigInteger.Parse("364103502021384610224777078613738432189483892") };
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
public class A156750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156750Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156750.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156750.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156750Inst Instance=new A156750Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156751
{
public static readonly BigInteger[] Value={ 1L,-7L,-51L,1757L,23001L,-1423807L,-27733851L,2423221157L,62887847601L,-7070927698807L,-229364654629251L,31523048882011757L,1227032077593393801L,BigInteger.Parse("-199302585894622665007"),BigInteger.Parse("-9050801142483361006251"),BigInteger.Parse("1696260152956539473013557"),BigInteger.Parse("88035625059010432835381601") };
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
public class A156751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156751Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156751.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156751.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156751Inst Instance=new A156751Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156752
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156752Inst : IEnumerable<long>
{
public static readonly long[] Value=A156752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156752.Bytes);
public long this[int i]=>Value[i];

public static A156752Inst Instance=new A156752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156753
{
public static readonly long[] Value={ 11L,101L,167L,211L,257L,347L,431L,523L,541L,617L,743L,761L,853L,1021L,1087L,1153L,1201L,1373L,1427L,1483L,1531L,1571L,1607L,1733L,1861L,2011L,2053L,2141L,2237L,2251L,2273L,2383L,2411L,2417L,2503L,2521L,2741L,2833L,2851L,3041L,3137L,3371L,3407L,3511L,3823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156753Inst : IEnumerable<long>
{
public static readonly long[] Value=A156753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156753.Bytes);
public long this[int i]=>Value[i];

public static A156753Inst Instance=new A156753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156754
{
public static readonly BigInteger[] Value={ 1L,-3L,-91L,873L,44681L,-723243L,-54370771L,1234258113L,123409465361L,-3602675046483L,-450147484965451L,16061724748579353L,2408182490139558041L,BigInteger.Parse("-101549689784375097723"),BigInteger.Parse("-17763194493523591880131"),BigInteger.Parse("864287669702052258292593"),BigInteger.Parse("172779639453348550866418721") };
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
public class A156754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156754Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156754.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156754.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156754Inst Instance=new A156754Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156755
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,2L,2L,3L,1L,1L,2L,1L,1L,2L,2L,2L,3L,1L,1L,2L,1L,1L,2L,2L,2L,3L,1L,1L,2L,1L,1L,2L,2L,2L,3L,1L,1L,2L,1L,1L,2L,2L,2L,3L,1L,1L,2L,1L,1L,2L,2L,2L,3L,1L,1L,2L,1L,1L,2L,2L,2L,3L,1L,1L,2L,1L,1L,2L,2L,2L,3L,1L,1L,2L,1L,1L,2L,2L,2L,3L,1L,1L,2L,1L,1L,2L,2L,2L,3L,1L,1L,2L,1L,1L,2L,2L,2L,3L,1L,1L,2L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156755Inst : IEnumerable<long>
{
public static readonly long[] Value=A156755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156755.Bytes);
public long this[int i]=>Value[i];

public static A156755Inst Instance=new A156755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156756
{
public static readonly long[] Value={ 2L,3L,5L,7L,23L,29L,41L,43L,47L,61L,67L,83L,89L,113L,131L,137L,139L,151L,157L,173L,179L,191L,193L,197L,199L,223L,227L,229L,241L,263L,269L,281L,283L,311L,313L,317L,331L,337L,353L,359L,373L,379L,397L,401L,409L,421L,443L,449L,461L,463L,467L,487L,557L,571L,577L,593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156756Inst : IEnumerable<long>
{
public static readonly long[] Value=A156756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156756.Bytes);
public long this[int i]=>Value[i];

public static A156756Inst Instance=new A156756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156757
{
public static readonly BigInteger[] Value={ 1L,-1L,-99L,299L,49401L,-249001L,-60251499L,425252099L,136795497201L,-1241382296401L,-498990299504499L,5534485665505499L,2669489641160743401L,BigInteger.Parse("-34991633084859742201"),BigInteger.Parse("-19690651784477632959099"),BigInteger.Parse("297813229679687736760499"),BigInteger.Parse("191527704666360326602988001") };
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
public class A156757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156757Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156757.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156757.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156757Inst Instance=new A156757Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156758
{
public static readonly BigInteger[] Value={ 1L,-19L,-20L,9139L,9220L,-4037899L,-12206060L,30276088403L,30504279940L,-24347629105189L,-122654643961100L,239338306197009289L,723419793280402660L,BigInteger.Parse("-834151618558367715079"),BigInteger.Parse("-5883014418494598304940"),BigInteger.Parse("62617114255248306776597731"),BigInteger.Parse("63088459108278656408525380") };
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
public class A156758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156758Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156758.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156758.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156758Inst Instance=new A156758Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156759
{
public static readonly long[] Value={ 2L,4L,6L,8L,9L,15L,21L,25L,35L,49L,77L,91L,119L,121L,143L,169L,221L,247L,289L,323L,361L,437L,529L,667L,713L,841L,899L,961L,1147L,1271L,1333L,1369L,1517L,1591L,1681L,1763L,1849L,2021L,2209L,2491L,2773L,2809L,3127L,3233L,3481L,3599L,3721L,4087L,4331L,4453L,4489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156759Inst : IEnumerable<long>
{
public static readonly long[] Value=A156759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156759.Bytes);
public long this[int i]=>Value[i];

public static A156759Inst Instance=new A156759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156760
{
public static readonly long[] Value={ 4L,19L,79L,319L,1279L,5119L,20479L,81919L,327679L,1310719L,5242879L,20971519L,83886079L,335544319L,1342177279L,5368709119L,21474836479L,85899345919L,343597383679L,1374389534719L,5497558138879L,21990232555519L,87960930222079L,351843720888319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156760Inst : IEnumerable<long>
{
public static readonly long[] Value=A156760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156760.Bytes);
public long this[int i]=>Value[i];

public static A156760Inst Instance=new A156760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156761
{
public static readonly long[] Value={ 3L,5L,17L,31L,1201L,128199521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156761Inst : IEnumerable<long>
{
public static readonly long[] Value=A156761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156761.Bytes);
public long this[int i]=>Value[i];

public static A156761Inst Instance=new A156761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156762
{
public static readonly BigInteger[] Value={ 1L,42L,441L,37044L,194481L,8168202L,85766121L,14408708328L,37822859361L,1588560093162L,16679880978201L,1401110002168884L,7355827511386641L,308944755478238922L,3243919932521508681L,BigInteger.Parse("1089957097327226916816") };
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
public class A156762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156762Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156762.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156762.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156762Inst Instance=new A156762Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156763
{
public static readonly long[] Value={ 2L,3L,3L,7L,12L,7L,21L,42L,42L,21L,71L,160L,180L,160L,71L,253L,660L,770L,770L,660L,253L,925L,2814L,3570L,3360L,3570L,2814L,925L,3433L,12068L,17388L,15750L,15750L,17388L,12068L,3433L,12871L,51552L,85344L,81312L,69300L,81312L,85344L,51552L,12871L,48621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156763Inst : IEnumerable<long>
{
public static readonly long[] Value=A156763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156763.Bytes);
public long this[int i]=>Value[i];

public static A156763Inst Instance=new A156763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156764
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,40L,40L,1L,1L,300L,2000L,300L,1L,1L,2520L,126000L,126000L,2520L,1L,1L,23520L,9878400L,74088000L,9878400L,23520L,1L,1L,241920L,948326400L,59744563200L,59744563200L,948326400L,241920L,1L,1L,2721600L,109734912000L,64524128256000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156764Inst : IEnumerable<long>
{
public static readonly long[] Value=A156764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156764.Bytes);
public long this[int i]=>Value[i];

public static A156764Inst Instance=new A156764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156765
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,42L,42L,1L,1L,360L,2520L,360L,1L,1L,3720L,223200L,223200L,3720L,1L,1L,45360L,28123200L,241056000L,28123200L,45360L,1L,1L,640080L,4839004800L,428597568000L,428597568000L,4839004800L,640080L,1L,1L,10281600L,1096841088000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156765Inst : IEnumerable<long>
{
public static readonly long[] Value=A156765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156765.Bytes);
public long this[int i]=>Value[i];

public static A156765Inst Instance=new A156765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156766
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,78L,78L,1L,1L,960L,9360L,960L,1L,1L,14520L,1742400L,1742400L,14520L,1L,1L,262080L,475675200L,5854464000L,475675200L,262080L,1L,1L,5508720L,180465667200L,33594378048000L,33594378048000L,180465667200L,5508720L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156766Inst : IEnumerable<long>
{
public static readonly long[] Value=A156766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156766.Bytes);
public long this[int i]=>Value[i];

public static A156766Inst Instance=new A156766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156767
{
public static readonly long[] Value={ 1L,1L,1L,1L,10L,1L,1L,126L,126L,1L,1L,2040L,25704L,2040L,1L,1L,40920L,8347680L,8347680L,40920L,1L,1L,982800L,4021617600L,65111904000L,4021617600L,982800L,1L,1L,27523440L,2705003683200L,878482148544000L,878482148544000L,2705003683200L,27523440L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156767Inst : IEnumerable<long>
{
public static readonly long[] Value=A156767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156767.Bytes);
public long this[int i]=>Value[i];

public static A156767Inst Instance=new A156767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156768
{
public static readonly long[] Value={ 2L,5L,11L,19L,37L,11L,13L,17L,17L,29L,11L,13L,17L,17L,19L,23L,23L,23L,23L,29L,23L,29L,37L,31L,41L,41L,29L,29L,29L,31L,31L,37L,37L,37L,41L,41L,41L,41L,43L,43L,41L,43L,47L,47L,53L,53L,53L,53L,59L,59L,53L,59L,59L,59L,59L,67L,67L,71L,67L,71L,61L,67L,67L,67L,71L,71L,73L,79L,89L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156768Inst : IEnumerable<long>
{
public static readonly long[] Value=A156768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156768.Bytes);
public long this[int i]=>Value[i];

public static A156768Inst Instance=new A156768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156769
{
public static readonly BigInteger[] Value={ 1L,3L,15L,315L,2835L,155925L,6081075L,638512875L,10854718875L,1856156927625L,194896477400625L,49308808782358125L,3698160658676859375L,BigInteger.Parse("1298054391195577640625"),BigInteger.Parse("263505041412702261046875") };
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
public class A156769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156769Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156769.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156769.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156769Inst Instance=new A156769Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156770
{
public static readonly long[] Value={ 1L,3L,7L,9L,11L,17L,21L,29L,39L,43L,49L,51L,53L,81L,91L,99L,103L,123L,127L,133L,153L,191L,227L,231L,241L,249L,253L,273L,281L,291L,293L,311L,323L,333L,337L,339L,341L,347L,359L,377L,387L,397L,427L,429L,431L,441L,443L,453L,461L,467L,471L,481L,489L,493L,523L,541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156770Inst : IEnumerable<long>
{
public static readonly long[] Value=A156770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156770.Bytes);
public long this[int i]=>Value[i];

public static A156770Inst Instance=new A156770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156771
{
public static readonly long[] Value={ 198L,927L,1656L,2385L,3114L,3843L,4572L,5301L,6030L,6759L,7488L,8217L,8946L,9675L,10404L,11133L,11862L,12591L,13320L,14049L,14778L,15507L,16236L,16965L,17694L,18423L,19152L,19881L,20610L,21339L,22068L,22797L,23526L,24255L,24984L,25713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156771Inst : IEnumerable<long>
{
public static readonly long[] Value=A156771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156771.Bytes);
public long this[int i]=>Value[i];

public static A156771Inst Instance=new A156771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156772
{
public static readonly long[] Value={ 531L,1260L,1989L,2718L,3447L,4176L,4905L,5634L,6363L,7092L,7821L,8550L,9279L,10008L,10737L,11466L,12195L,12924L,13653L,14382L,15111L,15840L,16569L,17298L,18027L,18756L,19485L,20214L,20943L,21672L,22401L,23130L,23859L,24588L,25317L,26046L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156772Inst : IEnumerable<long>
{
public static readonly long[] Value=A156772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156772.Bytes);
public long this[int i]=>Value[i];

public static A156772Inst Instance=new A156772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156773
{
public static readonly long[] Value={ 3482L,485L,10610L,33857L,70226L,119717L,182330L,258065L,346922L,448901L,564002L,692225L,833570L,988037L,1155626L,1336337L,1530170L,1737125L,1957202L,2190401L,2436722L,2696165L,2968730L,3254417L,3553226L,3865157L,4190210L,4528385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156773Inst : IEnumerable<long>
{
public static readonly long[] Value=A156773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156773.Bytes);
public long this[int i]=>Value[i];

public static A156773Inst Instance=new A156773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156774
{
public static readonly long[] Value={ 485L,3482L,19601L,48842L,91205L,146690L,215297L,297026L,391877L,499850L,620945L,755162L,902501L,1062962L,1236545L,1423250L,1623077L,1836026L,2062097L,2301290L,2553605L,2819042L,3097601L,3389282L,3694085L,4012010L,4343057L,4687226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156774Inst : IEnumerable<long>
{
public static readonly long[] Value=A156774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156774.Bytes);
public long this[int i]=>Value[i];

public static A156774Inst Instance=new A156774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156775
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,3L,2L,1L,1L,1L,1L,2L,3L,2L,1L,4L,1L,3L,2L,4L,1L,3L,1L,1L,4L,3L,2L,1L,1L,4L,3L,2L,1L,9L,1L,3L,4L,2L,1L,7L,1L,1L,3L,2L,1L,8L,3L,2L,3L,2L,1L,4L,1L,8L,7L,1L,4L,3L,1L,2L,7L,6L,1L,1L,1L,4L,3L,4L,6L,5L,1L,2L,1L,2L,1L,5L,6L,5L,4L,3L,1L,9L,4L,3L,7L,6L,5L,4L,1L,1L,9L,1L,1L,5L,1L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156775Inst : IEnumerable<long>
{
public static readonly long[] Value=A156775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156775.Bytes);
public long this[int i]=>Value[i];

public static A156775Inst Instance=new A156775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156776
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,2L,0L,3L,2L,1L,0L,1L,0L,2L,0L,0L,0L,4L,1L,0L,0L,4L,0L,0L,0L,1L,4L,3L,2L,1L,0L,0L,0L,0L,0L,9L,0L,0L,0L,0L,0L,7L,1L,1L,0L,0L,0L,8L,3L,2L,0L,0L,0L,0L,0L,8L,7L,1L,0L,0L,0L,0L,7L,6L,0L,1L,0L,0L,0L,4L,6L,5L,0L,0L,1L,0L,0L,5L,6L,5L,4L,3L,0L,9L,0L,0L,7L,6L,5L,4L,0L,1L,9L,1L,0L,5L,0L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156776Inst : IEnumerable<long>
{
public static readonly long[] Value=A156776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156776.Bytes);
public long this[int i]=>Value[i];

public static A156776Inst Instance=new A156776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156777
{
public static readonly BigInteger[] Value={ 1L,-17L,-38L,8789L,18202L,-3900497L,-24136118L,29256582973L,60326310202L,-23528623958327L,-242569025402198L,231288364766352959L,1430679350247407002L,BigInteger.Parse("-806095985543164838357"),BigInteger.Parse("-11634611806073959269878"),BigInteger.Parse("60511069853807388560688701"),BigInteger.Parse("124767626040514356915524602") };
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
public class A156777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156777Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156777.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156777.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156777Inst Instance=new A156777Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156778
{
public static readonly long[] Value={ 0L,1L,5L,15L,34L,70L,123L,203L,308L,450L,645L,880L,1182L,1547L,1967L,2460L,3048L,3740L,4509L,5396L,6390L,7476L,8701L,10051L,11556L,13250L,15093L,17064L,19194L,21460L,23895L,26660L,29616L,32802L,36159L,39830L,43686L,47804L,52193L,56823L,61740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156778Inst : IEnumerable<long>
{
public static readonly long[] Value=A156778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156778.Bytes);
public long this[int i]=>Value[i];

public static A156778Inst Instance=new A156778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156779
{
public static readonly long[] Value={ 0L,2L,5L,7L,10L,17L,17L,24L,22L,29L,28L,50L,41L,60L,56L,65L,58L,92L,77L,111L,99L,107L,100L,167L,110L,143L,122L,165L,129L,214L,160L,225L,193L,220L,187L,285L,197L,276L,243L,325L,238L,390L,281L,393L,354L,383L,328L,536L,345L,457L,391L,476L,381L,573L,419L,563L,463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156779Inst : IEnumerable<long>
{
public static readonly long[] Value=A156779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156779.Bytes);
public long this[int i]=>Value[i];

public static A156779Inst Instance=new A156779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156780
{
public static readonly long[] Value={ 0L,0L,2L,10L,10L,30L,30L,68L,68L,68L,68L,140L,140L,246L,246L,246L,246L,406L,406L,616L,616L,616L,616L,900L,900L,900L,900L,900L,900L,1290L,1290L,1760L,1760L,1760L,1760L,1760L,1760L,2364L,2364L,2364L,2364L,3094L,3094L,3934L,3934L,3934L,3934L,4920L,4920L,4920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156780Inst : IEnumerable<long>
{
public static readonly long[] Value=A156780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156780.Bytes);
public long this[int i]=>Value[i];

public static A156780Inst Instance=new A156780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156781
{
public static readonly long[] Value={ 11L,17L,23L,29L,31L,41L,61L,71L,79L,157L,211L,281L,293L,311L,349L,389L,401L,463L,509L,661L,719L,757L,797L,809L,857L,863L,997L,1187L,1201L,1289L,1291L,1301L,1307L,1319L,1399L,1427L,1451L,1663L,1669L,1723L,2029L,2111L,2113L,2129L,2137L,2243L,2311L,2339L,2341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156781Inst : IEnumerable<long>
{
public static readonly long[] Value=A156781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156781.Bytes);
public long this[int i]=>Value[i];

public static A156781Inst Instance=new A156781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156782
{
public static readonly long[] Value={ 19L,29L,43L,73L,137L,149L,157L,179L,211L,379L,383L,401L,409L,433L,467L,557L,569L,577L,599L,677L,839L,863L,883L,919L,997L,1103L,1303L,1499L,1553L,1637L,1669L,1709L,1783L,1811L,1861L,1873L,1951L,2113L,2207L,2309L,2393L,2503L,2647L,2663L,2713L,2791L,3011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156782Inst : IEnumerable<long>
{
public static readonly long[] Value=A156782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156782.Bytes);
public long this[int i]=>Value[i];

public static A156782Inst Instance=new A156782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156783
{
public static readonly long[] Value={ 43L,47L,53L,71L,79L,89L,107L,113L,127L,137L,151L,359L,401L,499L,503L,617L,881L,883L,1097L,1279L,1787L,1997L,2213L,2281L,2393L,2551L,2591L,3209L,3221L,3673L,3847L,4111L,4513L,4519L,4603L,4651L,4703L,4877L,4987L,5237L,5431L,5501L,5741L,5801L,6073L,6367L,6833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156783Inst : IEnumerable<long>
{
public static readonly long[] Value=A156783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156783.Bytes);
public long this[int i]=>Value[i];

public static A156783Inst Instance=new A156783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156784
{
public static readonly long[] Value={ 29L,83L,127L,131L,157L,173L,197L,241L,389L,577L,619L,1129L,1201L,1259L,1361L,1367L,1429L,1439L,1601L,1663L,1723L,1783L,1787L,1811L,2017L,2083L,2153L,2237L,2287L,2351L,2371L,2591L,2659L,2699L,2819L,3163L,3209L,3373L,3407L,3433L,3467L,4013L,4051L,4217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156784Inst : IEnumerable<long>
{
public static readonly long[] Value=A156784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156784.Bytes);
public long this[int i]=>Value[i];

public static A156784Inst Instance=new A156784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156785
{
public static readonly long[] Value={ 401L,7187L,39229L,128257L,149099L,216179L,347041L,585889L,767831L,3574721L,5171951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156785Inst : IEnumerable<long>
{
public static readonly long[] Value=A156785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156785.Bytes);
public long this[int i]=>Value[i];

public static A156785Inst Instance=new A156785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156786
{
public static readonly long[] Value={ 2L,-1L,-1L,1L,4L,1L,-1L,-12L,-12L,-1L,1L,36L,72L,36L,1L,-1L,-140L,-360L,-360L,-140L,-1L,1L,750L,2100L,2400L,2100L,750L,1L,-1L,-5082L,-15750L,-16800L,-16800L,-15750L,-5082L,-1L,1L,40376L,142296L,152880L,117600L,152880L,142296L,40376L,1L,-1L,-362952L,-1453536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156786Inst : IEnumerable<long>
{
public static readonly long[] Value=A156786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156786.Bytes);
public long this[int i]=>Value[i];

public static A156786Inst Instance=new A156786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156787
{
public static readonly long[] Value={ 9L,10L,25L,27L,40L,49L,81L,100L,105L,116L,121L,125L,160L,169L,243L,250L,289L,343L,361L,400L,525L,529L,561L,568L,625L,640L,729L,805L,841L,945L,961L,1000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156787Inst : IEnumerable<long>
{
public static readonly long[] Value=A156787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156787.Bytes);
public long this[int i]=>Value[i];

public static A156787Inst Instance=new A156787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156788
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,4L,0L,3L,0L,27L,0L,8L,96L,0L,256L,0L,45L,640L,2430L,0L,3125L,0L,264L,8640L,29160L,61440L,0L,46656L,0L,1855L,118272L,688905L,1146880L,1640625L,0L,823543L,0L,14832L,1899520L,16166304L,41287680L,43750000L,47029248L,0L,16777216L,0L,133497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156788Inst : IEnumerable<long>
{
public static readonly long[] Value=A156788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156788.Bytes);
public long this[int i]=>Value[i];

public static A156788Inst Instance=new A156788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156789
{
public static readonly long[] Value={ 1L,1L,4L,6L,1L,8L,36L,80L,70L,1L,12L,90L,400L,1050L,1512L,924L,1L,16L,168L,1120L,4900L,14112L,25872L,27456L,12870L,1L,20L,270L,2400L,14700L,63504L,194040L,411840L,579150L,486200L,184756L,1L,24L,396L,4400L,34650L,199584L,853776L,2718144L,6370650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156789Inst : IEnumerable<long>
{
public static readonly long[] Value=A156789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156789.Bytes);
public long this[int i]=>Value[i];

public static A156789Inst Instance=new A156789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156790
{
public static readonly long[] Value={ 0L,1L,8L,41L,183L,770L,3149L,12730L,51209L,205356L,822500L,3292134L,13172634L,52698912L,210812207L,843281848L,3373193506L,13492906143L,53971888157L,15888078393L,863553363881L,3454215553470L,13816866413106L,55267474046659L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156790Inst : IEnumerable<long>
{
public static readonly long[] Value=A156790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156790.Bytes);
public long this[int i]=>Value[i];

public static A156790Inst Instance=new A156790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156791
{
public static readonly long[] Value={ 1L,1L,6L,7L,78L,420L,6872L,17253L,326552L,2680988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156791Inst : IEnumerable<long>
{
public static readonly long[] Value=A156791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156791.Bytes);
public long this[int i]=>Value[i];

public static A156791Inst Instance=new A156791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156792
{
public static readonly long[] Value={ 1L,1L,1L,6L,1L,2L,7L,6L,2L,9L,78L,7L,12L,9L,24L,420L,78L,14L,54L,24L,130L,6872L,420L,156L,63L,144L,130L,720L,17253L,6872L,840L,702L,168L,780L,720L,8505L,326552L,17253L,13744L,3780L,1872L,910L,4320L,8505L,35840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156792Inst : IEnumerable<long>
{
public static readonly long[] Value=A156792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156792.Bytes);
public long this[int i]=>Value[i];

public static A156792Inst Instance=new A156792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156793
{
public static readonly long[] Value={ 6L,7L,11L,12L,20L,21L,22L,25L,28L,30L,35L,37L,39L,41L,46L,64L,68L,69L,72L,77L,126L,127L,130L,131L,132L,133L,135L,136L,155L,159L,160L,162L,163L,164L,166L,167L,169L,172L,173L,174L,178L,180L,182L,184L,185L,186L,190L,191L,194L,196L,197L,198L,199L,200L,201L,202L,203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156793Inst : IEnumerable<long>
{
public static readonly long[] Value=A156793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156793.Bytes);
public long this[int i]=>Value[i];

public static A156793Inst Instance=new A156793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156794
{
public static readonly BigInteger[] Value={ 1L,-13L,-68L,7501L,34612L,-3368053L,-46106108L,25293153197L,115286766772L,-20343772131163L,-463582285448348L,199983801754948471L,2734234973817091732L,BigInteger.Parse("-696993077392215409273"),BigInteger.Parse("-22235435864793932409788"),BigInteger.Parse("52321069430592373062936349"),BigInteger.Parse("238449099270604459179493492") };
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
public class A156794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156794Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A156794.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A156794.Bytes);
public BigInteger this[int i]=>Value[i];

public static A156794Inst Instance=new A156794Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156795
{
public static readonly long[] Value={ 22L,103L,184L,265L,346L,427L,508L,589L,670L,751L,832L,913L,994L,1075L,1156L,1237L,1318L,1399L,1480L,1561L,1642L,1723L,1804L,1885L,1966L,2047L,2128L,2209L,2290L,2371L,2452L,2533L,2614L,2695L,2776L,2857L,2938L,3019L,3100L,3181L,3262L,3343L,3424L,3505L,3586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156795Inst : IEnumerable<long>
{
public static readonly long[] Value=A156795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156795.Bytes);
public long this[int i]=>Value[i];

public static A156795Inst Instance=new A156795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156796
{
public static readonly long[] Value={ 59L,140L,221L,302L,383L,464L,545L,626L,707L,788L,869L,950L,1031L,1112L,1193L,1274L,1355L,1436L,1517L,1598L,1679L,1760L,1841L,1922L,2003L,2084L,2165L,2246L,2327L,2408L,2489L,2570L,2651L,2732L,2813L,2894L,2975L,3056L,3137L,3218L,3299L,3380L,3461L,3542L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156796Inst : IEnumerable<long>
{
public static readonly long[] Value=A156796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156796.Bytes);
public long this[int i]=>Value[i];

public static A156796Inst Instance=new A156796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156797
{
public static readonly long[] Value={ 22L,59L,103L,140L,184L,221L,265L,302L,346L,383L,427L,464L,508L,545L,589L,626L,670L,707L,751L,788L,832L,869L,913L,950L,994L,1031L,1075L,1112L,1156L,1193L,1237L,1274L,1318L,1355L,1399L,1436L,1480L,1517L,1561L,1598L,1642L,1679L,1723L,1760L,1804L,1841L,1885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156797Inst : IEnumerable<long>
{
public static readonly long[] Value=A156797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156797.Bytes);
public long this[int i]=>Value[i];

public static A156797Inst Instance=new A156797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156798
{
public static readonly long[] Value={ 4L,10L,40L,130L,340L,754L,1480L,2650L,4420L,6970L,10504L,15250L,21460L,29410L,39400L,51754L,66820L,84970L,106600L,132130L,162004L,196690L,236680L,282490L,334660L,393754L,460360L,535090L,618580L,711490L,814504L,928330L,1053700L,1191370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156798Inst : IEnumerable<long>
{
public static readonly long[] Value=A156798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156798.Bytes);
public long this[int i]=>Value[i];

public static A156798Inst Instance=new A156798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156799
{
public static readonly long[] Value={ 1L,2L,4L,5L,10L,11L,13L,14L,20L,21L,23L,24L,29L,30L,32L,33L,48L,49L,51L,52L,57L,58L,60L,61L,67L,68L,70L,71L,76L,77L,79L,80L,99L,100L,102L,103L,108L,109L,111L,112L,118L,119L,121L,122L,127L,128L,130L,131L,146L,147L,149L,150L,155L,156L,158L,159L,165L,166L,168L,169L,174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156799Inst : IEnumerable<long>
{
public static readonly long[] Value=A156799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156799.Bytes);
public long this[int i]=>Value[i];

public static A156799Inst Instance=new A156799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156800
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,35L,134L,777L,6702L,104825L,3370317L,231557290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156800Inst : IEnumerable<long>
{
public static readonly long[] Value=A156800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156800.Bytes);
public long this[int i]=>Value[i];

public static A156800Inst Instance=new A156800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156801
{
public static readonly long[] Value={ 1L,2L,4L,9L,21L,64L,218L,1068L,8038L,114188L,3493965L,235176097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156801Inst : IEnumerable<long>
{
public static readonly long[] Value=A156801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156801.Bytes);
public long this[int i]=>Value[i];

public static A156801Inst Instance=new A156801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156802
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,8L,15L,43L,110L,370L,1260L,5366L,25684L,154104L,1156716L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156802Inst : IEnumerable<long>
{
public static readonly long[] Value=A156802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156802.Bytes);
public long this[int i]=>Value[i];

public static A156802Inst Instance=new A156802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156803
{
public static readonly long[] Value={ 1L,2L,3L,6L,10L,22L,43L,104L,250L,720L,2229L,8361L,36441L,199610L,1395326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156803Inst : IEnumerable<long>
{
public static readonly long[] Value=A156803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156803.Bytes);
public long this[int i]=>Value[i];

public static A156803Inst Instance=new A156803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A156804
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,24L,71L,257L,1186L,7070L,56698L,614952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A156804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A156804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A156804Inst : IEnumerable<long>
{
public static readonly long[] Value=A156804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A156804.Bytes);
public long this[int i]=>Value[i];

public static A156804Inst Instance=new A156804Inst();

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