using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A280674
{
public static readonly long[] Value={ 2L,11L,59L,338L,1917L,10893L,61880L,351541L,1997095L,11345458L,64453321L,366158041L,2080136592L,11817214849L,67133363931L,381383313234L,2166631062437L,12308588230773L,69924846394792L,397241669934877L,2256722073320511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280674Inst : IEnumerable<long>
{
public static readonly long[] Value=A280674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280674.Bytes);
public long this[int i]=>Value[i];

public static A280674Inst Instance=new A280674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280675
{
public static readonly long[] Value={ 5L,82L,858L,10205L,119440L,1401470L,16438612L,192831783L,2261964301L,26533504354L,311245493388L,3650998431229L,42827250423319L,502375841919309L,5893011645334528L,69126704336253119L,810875921978239834L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280675Inst : IEnumerable<long>
{
public static readonly long[] Value=A280675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280675.Bytes);
public long this[int i]=>Value[i];

public static A280675Inst Instance=new A280675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280676
{
public static readonly BigInteger[] Value={ 14L,612L,12484L,310365L,7533245L,183331502L,4460317695L,108520231044L,2640298250694L,64238619127022L,1562929767205929L,38026186043293995L,925179685380850290L,BigInteger.Parse("22509684536321285656"),BigInteger.Parse("547662154172647585113") };
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
public class A280676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280676Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280676.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280676.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280676Inst Instance=new A280676Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280725
{
public static readonly long[] Value={ 3L,1L,3L,0L,9L,2L,6L,4L,4L,2L,0L,1L,2L,2L,7L,3L,0L,8L,9L,7L,6L,3L,4L,3L,8L,7L,0L,9L,5L,6L,0L,1L,3L,2L,7L,1L,3L,4L,0L,3L,1L,2L,9L,9L,4L,4L,7L,7L,1L,6L,5L,5L,2L,2L,5L,1L,9L,7L,8L,2L,1L,3L,0L,4L,2L,9L,8L,1L,2L,0L,7L,7L,1L,2L,1L,9L,2L,2L,1L,4L,8L,5L,8L,3L,9L,2L,1L,4L,7L,1L,6L,7L,2L,0L,7L,9L,7L,6L,1L,7L,0L,3L,6L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280725Inst : IEnumerable<long>
{
public static readonly long[] Value=A280725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280725.Bytes);
public long this[int i]=>Value[i];

public static A280725Inst Instance=new A280725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280726
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,2L,1L,2L,1L,4L,1L,2L,2L,1L,1L,1L,2L,5L,1L,2L,4L,5L,1L,4L,2L,5L,2L,3L,1L,4L,1L,4L,1L,2L,2L,5L,5L,2L,1L,4L,2L,9L,4L,2L,5L,6L,1L,9L,4L,1L,2L,6L,5L,4L,2L,5L,3L,8L,1L,4L,4L,5L,1L,2L,4L,7L,1L,5L,2L,7L,2L,5L,5L,4L,5L,4L,2L,7L,1L,7L,4L,10L,2L,1L,9L,3L,4L,5L,2L,5L,5L,4L,6L,5L,1L,2L,9L,4L,4L,7L,1L,8L,2L,2L,6L,12L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280726Inst : IEnumerable<long>
{
public static readonly long[] Value=A280726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280726.Bytes);
public long this[int i]=>Value[i];

public static A280726Inst Instance=new A280726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280727
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,4L,0L,0L,24L,0L,0L,8L,0L,0L,4L,0L,0L,20L,0L,0L,24L,0L,0L,8L,0L,0L,16L,0L,0L,32L,0L,0L,16L,0L,0L,48L,0L,0L,8L,0L,0L,32L,0L,0L,32L,0L,0L,64L,0L,0L,16L,0L,0L,32L,0L,0L,1152L,0L,0L,16L,0L,0L,4L,0L,0L,16L,0L,0L,16L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280727Inst : IEnumerable<long>
{
public static readonly long[] Value=A280727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280727.Bytes);
public long this[int i]=>Value[i];

public static A280727Inst Instance=new A280727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280728
{
public static readonly long[] Value={ 1L,0L,0L,2L,0L,0L,3L,0L,0L,4L,0L,0L,4L,0L,0L,8L,0L,0L,8L,0L,0L,8L,0L,0L,4L,0L,0L,8L,0L,0L,12L,0L,0L,8L,0L,0L,8L,0L,0L,16L,0L,0L,24L,0L,0L,64L,0L,0L,8L,0L,0L,16L,0L,0L,20L,0L,0L,16L,0L,0L,32L,0L,0L,64L,0L,0L,24L,0L,0L,32L,0L,0L,8L,0L,0L,128L,0L,0L,12L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280728Inst : IEnumerable<long>
{
public static readonly long[] Value=A280728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280728.Bytes);
public long this[int i]=>Value[i];

public static A280728Inst Instance=new A280728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280729
{
public static readonly long[] Value={ 2L,4L,5L,9L,10L,16L,15L,21L,26L,23L,30L,36L,33L,45L,50L,57L,46L,53L,59L,60L,63L,81L,84L,80L,90L,83L,105L,90L,104L,99L,113L,132L,113L,146L,115L,126L,135L,165L,170L,177L,138L,167L,160L,182L,159L,153L,183L,225L,186L,228L,215L,184L,225L,256L,261L,266L,207L,226L,236L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280729Inst : IEnumerable<long>
{
public static readonly long[] Value=A280729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280729.Bytes);
public long this[int i]=>Value[i];

public static A280729Inst Instance=new A280729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280730
{
public static readonly long[] Value={ 1L,3L,6L,16L,27L,39L,59L,89L,189L,299L,499L,799L,1799L,2899L,4899L,6999L,9999L,19999L,39999L,69999L,169999L,279999L,399999L,599999L,899999L,1899999L,2999999L,4999999L,7999999L,17999999L,28999999L,48999999L,69999999L,99999999L,199999999L,399999999L,699999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280730Inst : IEnumerable<long>
{
public static readonly long[] Value=A280730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280730.Bytes);
public long this[int i]=>Value[i];

public static A280730Inst Instance=new A280730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280731
{
public static readonly long[] Value={ 1L,2L,3L,9L,10L,18L,19L,81L,90L,162L,171L,729L,810L,1458L,1539L,6561L,7290L,13122L,13851L,59049L,65610L,118098L,124659L,531441L,590490L,1062882L,1121931L,4782969L,5314410L,9565938L,10097379L,43046721L,47829690L,86093442L,90876411L,387420489L,430467210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280731Inst : IEnumerable<long>
{
public static readonly long[] Value=A280731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280731.Bytes);
public long this[int i]=>Value[i];

public static A280731Inst Instance=new A280731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280732
{
public static readonly long[] Value={ 111L,122L,133L,144L,155L,166L,177L,188L,199L,224L,236L,248L,339L,2510L,2612L,2714L,2816L,2918L,3412L,3515L,3618L,3721L,3824L,3927L,4416L,4520L,4624L,4728L,4832L,4936L,5525L,5630L,5735L,5840L,5945L,6636L,6742L,6848L,6954L,7749L,7856L,7963L,8864L,8972L,9981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280732Inst : IEnumerable<long>
{
public static readonly long[] Value=A280732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280732.Bytes);
public long this[int i]=>Value[i];

public static A280732Inst Instance=new A280732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280733
{
public static readonly long[] Value={ 122L,133L,144L,155L,166L,177L,188L,199L,236L,248L,2510L,2612L,2714L,2816L,2918L,3412L,3515L,3618L,3721L,3824L,3927L,4520L,4624L,4728L,4832L,4936L,5630L,5735L,5840L,5945L,6742L,6848L,6954L,7856L,7963L,8972L,11010L,11111L,11212L,11313L,11414L,11515L,11616L,11717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280733Inst : IEnumerable<long>
{
public static readonly long[] Value=A280733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280733.Bytes);
public long this[int i]=>Value[i];

public static A280733Inst Instance=new A280733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280734
{
public static readonly BigInteger[] Value={ 2L,12L,34560L,125411328000L,BigInteger.Parse("265790267296391946810949632000000000"),BigInteger.Parse("792786697595796795607377086400871488552960000000000000") };
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
public class A280734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280734Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280734.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280734.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280734Inst Instance=new A280734Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280735
{
public static readonly BigInteger[] Value={ 1L,3L,4L,125L,225L,84035L,2458624L,162030456L,8930250000L,92844190333125L,9001015156742400L,BigInteger.Parse("942951673566712781829"),BigInteger.Parse("68987440762943255933340961"),BigInteger.Parse("14018304328535759323100326171875"),BigInteger.Parse("377177413291384771899817984000000") };
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
public class A280735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280735Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280735.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280735.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280735Inst Instance=new A280735Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280736
{
public static readonly long[] Value={ 1L,2L,1L,6L,1L,16L,9L,5L,1L,16L,1L,28L,225L,2048L,1L,729L,1L,125L,49L,11L,1L,55296L,625L,13L,59049L,43904L,1L,8L,1L,67108864L,121L,17L,2401L,1L,1L,19L,169L,1L,1L,16807L,1L,1331L,36905625L,23L,1L,67108864L,117649L,9765625L,23409L,2197L,1L,94143178827L,14641L,262144L,361L,29L,1L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280736Inst : IEnumerable<long>
{
public static readonly long[] Value=A280736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280736.Bytes);
public long this[int i]=>Value[i];

public static A280736Inst Instance=new A280736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280737
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,2L,1L,2L,1L,1L,0L,1L,1L,2L,1L,2L,2L,2L,1L,2L,2L,2L,1L,2L,1L,1L,0L,1L,1L,2L,1L,2L,2L,2L,1L,2L,2L,3L,2L,3L,2L,2L,1L,2L,2L,3L,2L,3L,2L,2L,1L,2L,2L,2L,1L,2L,1L,1L,0L,1L,1L,2L,1L,2L,2L,2L,1L,2L,2L,3L,2L,3L,2L,2L,1L,2L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280737Inst : IEnumerable<long>
{
public static readonly long[] Value=A280737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280737.Bytes);
public long this[int i]=>Value[i];

public static A280737Inst Instance=new A280737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280738
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,1L,5L,2L,3L,1L,7L,2L,1L,11L,2L,3L,5L,2L,3L,7L,2L,13L,1L,17L,2L,15L,1L,19L,2L,1L,23L,2L,3L,1L,5L,7L,6L,1L,29L,2L,5L,11L,3L,13L,2L,11L,7L,1L,31L,2L,5L,13L,6L,1L,37L,2L,7L,3L,17L,2L,15L,1L,41L,2L,1L,43L,2L,33L,1L,47L,2L,35L,3L,19L,2L,3L,23L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280738Inst : IEnumerable<long>
{
public static readonly long[] Value=A280738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280738.Bytes);
public long this[int i]=>Value[i];

public static A280738Inst Instance=new A280738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280739
{
public static readonly long[] Value={ 4L,6L,8L,10L,15L,20L,21L,28L,35L,56L,70L,105L,140L,147L,196L,198L,220L,231L,260L,273L,364L,455L,459L,510L,513L,570L,676L,798L,1064L,1122L,1242L,1254L,1288L,1463L,1976L,2057L,2277L,2299L,2320L,2436L,2480L,2527L,2552L,2622L,2728L,2997L,3224L,3509L,3885L,4147L,4216L,4433L,4592L,4810L,4816L,5412L,5661L,5676L,5875L,6253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280739Inst : IEnumerable<long>
{
public static readonly long[] Value=A280739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280739.Bytes);
public long this[int i]=>Value[i];

public static A280739Inst Instance=new A280739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280740
{
public static readonly long[] Value={ 2L,3L,3L,5L,5L,5L,7L,7L,7L,7L,11L,11L,11L,13L,13L,13L,13L,13L,13L,13L,13L,13L,17L,19L,19L,19L,19L,23L,23L,23L,25L,25L,25L,25L,29L,29L,29L,29L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,37L,37L,37L,37L,37L,37L,41L,41L,41L,41L,41L,41L,41L,41L,43L,43L,43L,47L,47L,47L,47L,53L,53L,53L,53L,53L,53L,53L,53L,53L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280740Inst : IEnumerable<long>
{
public static readonly long[] Value=A280740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280740.Bytes);
public long this[int i]=>Value[i];

public static A280740Inst Instance=new A280740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280789
{
public static readonly long[] Value={ 1L,2L,1L,6L,3L,1L,16L,10L,3L,1L,46L,30L,11L,3L,1L,128L,91L,34L,11L,3L,1L,364L,268L,108L,35L,11L,3L,1L,1029L,790L,327L,112L,35L,11L,3L,1L,2930L,2308L,992L,344L,113L,35L,11L,3L,1L,8344L,6737L,2962L,1055L,348L,113L,35L,11L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280789Inst : IEnumerable<long>
{
public static readonly long[] Value=A280789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280789.Bytes);
public long this[int i]=>Value[i];

public static A280789Inst Instance=new A280789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280790
{
public static readonly BigInteger[] Value={ 1L,4L,2320L,9857600L,159122080000L,7098806416000000L,BigInteger.Parse("686863244097538560000"),BigInteger.Parse("143579312211740504320000000"),BigInteger.Parse("27634174819420517051458560000000"),BigInteger.Parse("103635121107833144489335056076800000000"),BigInteger.Parse("-624322694794393812097710416148436992000000000"),BigInteger.Parse("9870191061692402402605200350045038131191808000000000"),BigInteger.Parse("-258786046753018245774392957793266127246933652766720000000000"),BigInteger.Parse("11248188901093330352571154620038385487188031846809616384000000000000") };
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
public class A280790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280790Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280790.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280790.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280790Inst Instance=new A280790Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280791
{
public static readonly BigInteger[] Value={ 1L,4L,400L,5364800L,-367374176000L,143449000888960000L,BigInteger.Parse("-181899009894595069440000"),BigInteger.Parse("627436681283593072503040000000"),BigInteger.Parse("-5107564746905573153364013194240000000"),BigInteger.Parse("88171417366157389105207649269976371200000000"),BigInteger.Parse("-2969272543655823399308577388625291953035264000000000"),BigInteger.Parse("182441297602875422577046590572630481727347923066880000000000") };
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
public class A280791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280791Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280791.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280791.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280791Inst Instance=new A280791Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280792
{
public static readonly BigInteger[] Value={ 1L,-4L,-304L,648896L,2650020096L,-142483330376704L,BigInteger.Parse("24311838501965418496"),BigInteger.Parse("-17572131142184492046434304"),BigInteger.Parse("31550058162566932127305417424896"),BigInteger.Parse("-123841868587916789535717370523560443904"),BigInteger.Parse("969729634851676570691527174556498457233719296"),BigInteger.Parse("-14068736567241332813708145418894026558391075423125504"),BigInteger.Parse("356436464229966658550949874743523835716465340767523041181696"),BigInteger.Parse("-15023108679681039882374036580197265042861509571919315150655773999104") };
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
public class A280792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280792Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280792.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280792.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280792Inst Instance=new A280792Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280793
{
public static readonly BigInteger[] Value={ 1L,-4L,1616L,-10233664L,605781862656L,-195074044306023424L,BigInteger.Parse("226963189334487889924096"),BigInteger.Parse("-745095268828143694162593398784"),BigInteger.Parse("5876637899238904537105181354518183936"),BigInteger.Parse("-99252790021186158091252679600581668608671744"),BigInteger.Parse("3289325814605557759161838756845047127645003816370176"),BigInteger.Parse("-199648823584758446510667095055905800597628128606583525474304") };
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
public class A280793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280793Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280793.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280793.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280793Inst Instance=new A280793Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280794
{
public static readonly BigInteger[] Value={ 1L,2L,24L,576L,22656L,1302528L,101763072L,10295230464L,1303603347456L,201345802960896L,37165722291929088L,8062848653812826112L,BigInteger.Parse("2027520921133859733504"),BigInteger.Parse("584153907885564625944576"),BigInteger.Parse("190935313631330908457926656"),BigInteger.Parse("70201900206284691681897873408"),BigInteger.Parse("28820073606162151615036529836032") };
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
public class A280794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280794Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280794.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280794.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280794Inst Instance=new A280794Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280795
{
public static readonly BigInteger[] Value={ 2L,-4L,-4L,-64L,-1392L,-36048L,-68288L,217764736L,45152039424L,6761531610496L,479656304761728L,-181164506307765760L,BigInteger.Parse("-94510602811595547648"),BigInteger.Parse("-9099359091145965684736"),BigInteger.Parse("15760449987522859047213056"),BigInteger.Parse("8420566548360384773538111488"),BigInteger.Parse("-5361092182457081839427169370112"),BigInteger.Parse("-9833526816807364784720991628738560"),BigInteger.Parse("595009928118250648162581567581609984") };
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
public class A280795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280795Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280795.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280795.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280795Inst Instance=new A280795Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280796
{
public static readonly BigInteger[] Value={ 1L,-1L,-1L,-13L,-367L,-18549L,-1465953L,-166262441L,-25526158559L,-5088504559209L,-1277203721141441L,-394351281523218693L,BigInteger.Parse("-147069662568684159055"),BigInteger.Parse("-65255038602423680990301"),BigInteger.Parse("-33992871584988519888865825"),BigInteger.Parse("-20539580068386370855911967393"),BigInteger.Parse("-14240009948449682448965044873663"),BigInteger.Parse("-11224227759618581623496389602591953"),BigInteger.Parse("-9984932631658989030110444663072663937"),BigInteger.Parse("-9963529315662216629464111409263738683133") };
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
public class A280796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280796Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280796.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280796.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280796Inst Instance=new A280796Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280797
{
public static readonly BigInteger[] Value={ 0L,0L,5L,182L,13107L,1627604L,310968905L,84777884106L,31274997412295L,15009463529699912L,9090909090909090909L,BigInteger.Parse("6783562448903313426110"),BigInteger.Parse("6115142092568526471803195"),BigInteger.Parse("6552380728090615475599972572"),BigInteger.Parse("8231779712749862388415318790417"),BigInteger.Parse("11984441202055255416780710220336914") };
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
public class A280797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280797Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280797.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280797.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280797Inst Instance=new A280797Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280798
{
public static readonly long[] Value={ 1L,2L,13L,16667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280798Inst : IEnumerable<long>
{
public static readonly long[] Value=A280798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280798.Bytes);
public long this[int i]=>Value[i];

public static A280798Inst Instance=new A280798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280799
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,2L,3L,0L,3L,0L,2L,0L,0L,0L,0L,0L,3L,0L,0L,0L,3L,2L,0L,0L,4L,0L,6L,3L,0L,3L,4L,0L,6L,3L,0L,0L,3L,2L,4L,0L,3L,0L,2L,0L,0L,0L,3L,0L,0L,3L,2L,0L,4L,0L,3L,0L,4L,3L,4L,3L,0L,0L,4L,0L,3L,4L,7L,0L,0L,6L,0L,4L,5L,0L,4L,4L,0L,4L,4L,0L,0L,6L,0L,4L,3L,0L,3L,0L,0L,3L,6L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280799Inst : IEnumerable<long>
{
public static readonly long[] Value=A280799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280799.Bytes);
public long this[int i]=>Value[i];

public static A280799Inst Instance=new A280799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280800
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,2L,0L,2L,1L,2L,0L,1L,1L,3L,1L,1L,0L,5L,0L,1L,2L,5L,1L,2L,0L,4L,0L,2L,0L,4L,0L,2L,4L,2L,0L,1L,0L,4L,1L,3L,0L,5L,0L,1L,4L,4L,0L,5L,0L,1L,2L,1L,1L,6L,0L,5L,2L,6L,0L,2L,0L,6L,1L,4L,1L,7L,0L,2L,2L,9L,0L,4L,4L,5L,0L,2L,0L,7L,1L,2L,1L,2L,1L,1L,0L,3L,1L,4L,0L,7L,0L,3L,3L,7L,0L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280800Inst : IEnumerable<long>
{
public static readonly long[] Value=A280800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280800.Bytes);
public long this[int i]=>Value[i];

public static A280800Inst Instance=new A280800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280801
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,4L,1L,3L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,5L,1L,1L,2L,1L,1L,2L,3L,1L,1L,1L,1L,15L,1L,2L,1L,2L,1L,3L,1L,1L,1L,1L,1L,1L,1L,2L,1L,3L,1L,7L,2L,1L,1L,1L,1L,2L,1L,1L,1L,3L,1L,2L,1L,1L,3L,3L,1L,8L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,4L,1L,2L,2L,1L,1L,4L,1L,1L,1L,17L,1L,2L,1L,1L,1L,3L,1L,3L,1L,1L,1L,1L,1L,2L,1L,2L,2L,1L,1L,2L,5L,2L,2L,1L,1L,4L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280801Inst : IEnumerable<long>
{
public static readonly long[] Value=A280801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280801.Bytes);
public long this[int i]=>Value[i];

public static A280801Inst Instance=new A280801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280802
{
public static readonly long[] Value={ 1L,6L,18L,32L,42L,48L,80L,96L,90L,54L,144L,96L,176L,144L,192L,192L,186L,192L,162L,288L,336L,192L,240L,288L,368L,150L,432L,320L,384L,144L,384L,576L,378L,384L,576L,384L,378L,240L,720L,384L,720L,384L,576L,480L,528L,432L,576L,960L,752L,486L,450L,384L,1008L,432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280802Inst : IEnumerable<long>
{
public static readonly long[] Value=A280802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280802.Bytes);
public long this[int i]=>Value[i];

public static A280802Inst Instance=new A280802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280803
{
public static readonly long[] Value={ 0L,1L,56L,2146L,41931L,547197L,5219491L,39260363L,247768745L,1379016025L,7040775017L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280803Inst : IEnumerable<long>
{
public static readonly long[] Value=A280803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280803.Bytes);
public long this[int i]=>Value[i];

public static A280803Inst Instance=new A280803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280804
{
public static readonly long[] Value={ 0L,1L,3L,18L,72L,284L,1047L,3722L,12816L,43077L,142046L,461225L,1478635L,4689871L,14740063L,45963889L,142346346L,438168498L,1341507977L,4087399361L,12399650175L,37467705018L,112808649521L,338530408321L,1012834966758L,3021810804515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280804Inst : IEnumerable<long>
{
public static readonly long[] Value=A280804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280804.Bytes);
public long this[int i]=>Value[i];

public static A280804Inst Instance=new A280804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280853
{
public static readonly long[] Value={ 2L,9L,29L,110L,442L,1708L,6596L,25624L,99432L,385584L,1495696L,5802080L,22506144L,87301312L,338644032L,1313606016L,5095497344L,19765519104L,76670777600L,297407202816L,1153647430144L,4475017382912L,17358666073088L,67334551345152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280853Inst : IEnumerable<long>
{
public static readonly long[] Value=A280853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280853.Bytes);
public long this[int i]=>Value[i];

public static A280853Inst Instance=new A280853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280854
{
public static readonly long[] Value={ 4L,29L,46L,96L,256L,678L,1698L,4358L,11218L,28650L,73354L,188066L,481554L,1233194L,3159018L,8091050L,20722730L,53077762L,135947682L,348198514L,891836994L,2284251018L,5850611770L,14985083066L,38381073050L,98304843826L,251786685106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280854Inst : IEnumerable<long>
{
public static readonly long[] Value=A280854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280854.Bytes);
public long this[int i]=>Value[i];

public static A280854Inst Instance=new A280854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280855
{
public static readonly long[] Value={ 11L,110L,96L,124L,216L,462L,1005L,2010L,3907L,7756L,15749L,31804L,63463L,126758L,254453L,511180L,1024877L,2052836L,4115191L,8254198L,16552251L,33182160L,66522097L,133381078L,267442273L,536212952L,1075064777L,2155474072L,4321733703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280855Inst : IEnumerable<long>
{
public static readonly long[] Value=A280855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280855.Bytes);
public long this[int i]=>Value[i];

public static A280855Inst Instance=new A280855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280856
{
public static readonly long[] Value={ 30L,442L,256L,216L,282L,491L,968L,1857L,3220L,5281L,8574L,14339L,24694L,42833L,73650L,125361L,212438L,360727L,614668L,1049609L,1791800L,3055487L,5205640L,8868669L,15113516L,25765385L,43926544L,74885231L,127643494L,217567203L,370837946L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280856Inst : IEnumerable<long>
{
public static readonly long[] Value=A280856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280856.Bytes);
public long this[int i]=>Value[i];

public static A280856Inst Instance=new A280856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280857
{
public static readonly long[] Value={ 82L,1708L,678L,462L,491L,712L,1202L,2268L,4220L,7108L,11240L,17330L,26934L,43062L,70776L,117452L,193842L,316394L,511776L,825074L,1333130L,2163076L,3521462L,5738446L,9343090L,15187700L,24659768L,40027188L,64994524L,105599072L,171639520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280857Inst : IEnumerable<long>
{
public static readonly long[] Value=A280857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280857.Bytes);
public long this[int i]=>Value[i];

public static A280857Inst Instance=new A280857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280858
{
public static readonly long[] Value={ 224L,6596L,1698L,1005L,968L,1202L,1738L,2877L,5244L,9569L,15872L,24653L,36954L,55077L,83190L,128817L,204084L,326793L,522262L,828099L,1300592L,2029441L,3159306L,4927841L,7712840L,12114811L,19061740L,29999825L,47157384L,74031085L,116080358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280858Inst : IEnumerable<long>
{
public static readonly long[] Value=A280858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280858.Bytes);
public long this[int i]=>Value[i];

public static A280858Inst Instance=new A280858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280859
{
public static readonly long[] Value={ 1L,2L,2L,4L,9L,4L,11L,29L,29L,11L,30L,110L,46L,110L,30L,82L,442L,96L,96L,442L,82L,224L,1708L,256L,124L,256L,1708L,224L,612L,6596L,678L,216L,216L,678L,6596L,612L,1672L,25624L,1698L,462L,282L,462L,1698L,25624L,1672L,4568L,99432L,4358L,1005L,491L,491L,1005L,4358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280859Inst : IEnumerable<long>
{
public static readonly long[] Value=A280859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280859.Bytes);
public long this[int i]=>Value[i];

public static A280859Inst Instance=new A280859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280860
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,2L,1L,1L,2L,3L,2L,1L,3L,4L,2L,3L,5L,6L,4L,3L,7L,9L,6L,6L,9L,12L,9L,7L,13L,16L,12L,11L,18L,22L,17L,15L,23L,29L,22L,21L,32L,38L,31L,27L,41L,49L,39L,37L,54L,63L,52L,48L,68L,80L,66L,64L,88L,102L,86L,80L,111L,128L,108L,104L,140L,161L,138L,131L,174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280860Inst : IEnumerable<long>
{
public static readonly long[] Value=A280860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280860.Bytes);
public long this[int i]=>Value[i];

public static A280860Inst Instance=new A280860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280861
{
public static readonly long[] Value={ 0L,1L,3L,7L,9L,15L,17L,27L,37L,55L,58L,155L,228L,480L,720L,1305L,1573L,2173L,2547L,2767L,5448L,5500L,9468L,14268L,35207L,58155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280861Inst : IEnumerable<long>
{
public static readonly long[] Value=A280861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280861.Bytes);
public long this[int i]=>Value[i];

public static A280861Inst Instance=new A280861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280862
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,14L,15L,18L,21L,22L,26L,33L,34L,35L,38L,39L,45L,46L,50L,51L,54L,55L,57L,58L,62L,65L,69L,74L,75L,77L,82L,85L,86L,87L,91L,93L,94L,95L,98L,99L,106L,111L,115L,118L,119L,122L,123L,129L,133L,134L,135L,141L,142L,143L,145L,146L,147L,153L,155L,158L,159L,161L,162L,166L,175L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280862Inst : IEnumerable<long>
{
public static readonly long[] Value=A280862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280862.Bytes);
public long this[int i]=>Value[i];

public static A280862Inst Instance=new A280862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280863
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,15L,19L,24L,30L,37L,45L,55L,66L,79L,95L,115L,140L,171L,209L,255L,312L,381L,464L,564L,685L,832L,1011L,1229L,1494L,1818L,2214L,2697L,3285L,4000L,4869L,5926L,7211L,8772L,10670L,12980L,15793L,19219L,23391L,28470L,34653L,42179L,51336L,62475L,76025L,92510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280863Inst : IEnumerable<long>
{
public static readonly long[] Value=A280863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280863.Bytes);
public long this[int i]=>Value[i];

public static A280863Inst Instance=new A280863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280864
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,8L,5L,10L,12L,9L,7L,14L,16L,11L,22L,18L,15L,20L,24L,21L,28L,26L,13L,17L,34L,30L,45L,19L,38L,32L,23L,46L,36L,27L,25L,35L,42L,48L,29L,58L,40L,55L,33L,39L,52L,44L,77L,49L,31L,62L,50L,65L,78L,54L,37L,74L,56L,63L,51L,68L,60L,75L,41L,82L,64L,43L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280864Inst : IEnumerable<long>
{
public static readonly long[] Value=A280864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280864.Bytes);
public long this[int i]=>Value[i];

public static A280864Inst Instance=new A280864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280865
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,30L,33L,37L,42L,48L,55L,63L,72L,82L,93L,105L,118L,132L,147L,163L,180L,198L,217L,237L,258L,280L,303L,327L,352L,378L,405L,433L,463L,496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280865Inst : IEnumerable<long>
{
public static readonly long[] Value=A280865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280865.Bytes);
public long this[int i]=>Value[i];

public static A280865Inst Instance=new A280865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280866
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,8L,5L,10L,12L,9L,7L,14L,16L,11L,22L,18L,15L,20L,24L,21L,28L,26L,13L,17L,34L,30L,45L,19L,38L,32L,23L,46L,36L,27L,25L,35L,42L,48L,29L,58L,40L,50L,31L,62L,44L,33L,39L,52L,54L,51L,68L,56L,49L,37L,74L,60L,75L,41L,82L,64L,43L,86L,66L,99L,47L,94L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280866Inst : IEnumerable<long>
{
public static readonly long[] Value=A280866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280866.Bytes);
public long this[int i]=>Value[i];

public static A280866Inst Instance=new A280866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280867
{
public static readonly long[] Value={ 2L,8L,12L,20L,24L,32L,40L,50L,48L,62L,60L,64L,76L,102L,88L,108L,120L,128L,112L,136L,152L,148L,186L,168L,180L,192L,184L,216L,252L,236L,208L,220L,244L,232L,308L,268L,280L,292L,336L,304L,368L,328L,384L,364L,352L,408L,440L,376L,432L,400L,436L,388L,448L,492L,460L,484L,472L,548L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280867Inst : IEnumerable<long>
{
public static readonly long[] Value=A280867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280867.Bytes);
public long this[int i]=>Value[i];

public static A280867Inst Instance=new A280867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280868
{
public static readonly long[] Value={ 5L,5L,2L,0L,0L,7L,8L,1L,1L,0L,2L,8L,6L,3L,1L,0L,6L,4L,9L,5L,9L,6L,6L,0L,4L,1L,1L,2L,8L,1L,3L,0L,2L,7L,4L,2L,5L,2L,2L,1L,8L,6L,5L,4L,7L,8L,7L,8L,2L,9L,0L,9L,8L,5L,3L,7L,5L,7L,5L,5L,2L,0L,3L,8L,1L,4L,4L,2L,9L,0L,8L,2L,9L,1L,9L,3L,7L,2L,5L,4L,4L,3L,0L,9L,3L,6L,1L,0L,4L,9L,1L,3L,9L,9L,5L,4L,3L,4L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280868Inst : IEnumerable<long>
{
public static readonly long[] Value=A280868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280868.Bytes);
public long this[int i]=>Value[i];

public static A280868Inst Instance=new A280868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280885
{
public static readonly long[] Value={ 1L,28L,84L,2730L,462L,45276L,73788L,2849847L,365365L,69293224L,4913272L,623100660L,1424294340L,67844069880L,333126696L,2369968906305L,38838853515L,4030108023172L,3637504185700L,767066790520030L,21258921662550L,13536000500234940L,10485013256679780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280885Inst : IEnumerable<long>
{
public static readonly long[] Value=A280885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280885.Bytes);
public long this[int i]=>Value[i];

public static A280885Inst Instance=new A280885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280886
{
public static readonly long[] Value={ 1L,36L,120L,4950L,792L,97812L,171600L,8384805L,972400L,233084280L,14734512L,2345611788L,5678805120L,343522980720L,1221436128L,13374187844391L,185339038104L,22390031621100L,18903665638000L,5148292859617050L,118997530835040L,97446697480400580L,78169931776006200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280886Inst : IEnumerable<long>
{
public static readonly long[] Value=A280886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280886.Bytes);
public long this[int i]=>Value[i];

public static A280886Inst Instance=new A280886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280887
{
public static readonly long[] Value={ 1L,45L,165L,8415L,1287L,195195L,366795L,22046310L,2358070L,693870606L,39982878L,7765924530L,19829897010L,1474459789770L,4013220090L,63387586762335L,769009559175L,106739428871075L,85029993637875L,28720696235896665L,574973722599705L,581923529546044725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280887Inst : IEnumerable<long>
{
public static readonly long[] Value=A280887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280887.Bytes);
public long this[int i]=>Value[i];

public static A280887Inst Instance=new A280887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280888
{
public static readonly long[] Value={ 1L,55L,220L,13585L,2002L,365365L,732160L,52971490L,5299580L,1872409682L,99936200L,23179025870L,62214309080L,5550857869040L,12039496832L,261712025228225L,2847305553950L,449212777481325L,340010469598800L,138437940253287675L,2463591280250100L,2996433107369524875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280888Inst : IEnumerable<long>
{
public static readonly long[] Value=A280888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280888.Bytes);
public long this[int i]=>Value[i];

public static A280888Inst Instance=new A280888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280889
{
public static readonly BigInteger[] Value={ 1L,1L,4L,75L,56L,6930L,28512L,2849847L,972400L,693870606L,99936200L,63488350926L,475814969280L,166184959669300L,497980728000L,78877488833249175L,1489333512849120L,1116126129558913110L,1597083864660900000L,BigInteger.Parse("4467282986266589095530"),BigInteger.Parse("107279471180408841600") };
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
public class A280889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280889Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280889.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280889.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280889Inst Instance=new A280889Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280890
{
public static readonly long[] Value={ 2L,4L,16L,1296L,9681819840000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280890Inst : IEnumerable<long>
{
public static readonly long[] Value=A280890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280890.Bytes);
public long this[int i]=>Value[i];

public static A280890Inst Instance=new A280890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280891
{
public static readonly long[] Value={ 1L,4L,12L,37L,118L,387L,1298L,4433L,15366L,53924L,191216L,684114L,2466428L,8951945L,32683230L,119949945L,442281030L,1637618400L,6086481720L,22699003830L,84918443220L,318593346630L,1198421583684L,4518886787802L,17077448924828L,64671604514552L,245380598678208L,932708665735364L,3551238550341944L,13542393822575541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280891Inst : IEnumerable<long>
{
public static readonly long[] Value=A280891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280891.Bytes);
public long this[int i]=>Value[i];

public static A280891Inst Instance=new A280891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280892
{
public static readonly long[] Value={ 4L,12L,16L,18L,20L,32L,36L,40L,52L,54L,56L,60L,68L,72L,84L,88L,90L,92L,96L,104L,108L,112L,128L,132L,140L,144L,150L,156L,160L,162L,164L,180L,184L,192L,196L,198L,200L,204L,212L,216L,220L,228L,232L,234L,236L,240L,248L,250L,252L,256L,264L,268L,270L,272L,284L,292L,294L,300L,304L,306L,308L,312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280892Inst : IEnumerable<long>
{
public static readonly long[] Value=A280892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280892.Bytes);
public long this[int i]=>Value[i];

public static A280892Inst Instance=new A280892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280893
{
public static readonly BigInteger[] Value={ 1L,2L,3L,41L,43L,1063L,5479L,111031L,790000148543L,790000148543L,BigInteger.Parse("326139075156576200419624217119"),BigInteger.Parse("326139075156576200419624217119"),BigInteger.Parse("326139075156576200419624217119"),BigInteger.Parse("246787955464079218902570922322710067417716295997334514692275780099917") };
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
public class A280893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280893Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280893.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280893.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280893Inst Instance=new A280893Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280894
{
public static readonly BigInteger[] Value={ 1L,2L,3L,23L,19L,773L,13L,25771L,1325771L,85903775257L,2599552664779907L,BigInteger.Parse("4078014120856770452857"),BigInteger.Parse("770310365288124131869"),BigInteger.Parse("47072294862890243358278834974724275093"),BigInteger.Parse("8735279620054327668810964663269852011597"),BigInteger.Parse("1500540910023123440069025527770773118908806062201") };
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
public class A280894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280894Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280894.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280894.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280894Inst Instance=new A280894Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280895
{
public static readonly BigInteger[] Value={ 2L,3L,3L,163L,113L,1030291L,109L,107L,2571337L,103L,101L,2248069L,97L,263L,1442869L,139L,89L,1225009L,2685583L,83L,2571313L,79L,317L,2571307L,73L,71L,1224991L,67L,113L,3307891L,61L,59L,BigInteger.Parse("104633567005988371387"),103L,53L,1224973L,97L,47L,1224967L,43L,41L,1030219L,37L };
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
public class A280895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280895Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280895.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280895.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280895Inst Instance=new A280895Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280896
{
public static readonly long[] Value={ 0L,1L,9L,124L,1464L,15768L,159920L,1554304L,14632704L,134378112L,1209699584L,10713166848L,93585811456L,808068888576L,6907767091200L,58538748477440L,492296387559424L,4112143740076032L,34141836642680832L,281936660687224832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280896Inst : IEnumerable<long>
{
public static readonly long[] Value=A280896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280896.Bytes);
public long this[int i]=>Value[i];

public static A280896Inst Instance=new A280896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280897
{
public static readonly BigInteger[] Value={ 0L,10L,646L,22632L,610448L,14262832L,304584096L,6117000704L,117496694272L,2181977379072L,39462274293248L,698659360847872L,12154771113160704L,208386384523096064L,3528538532937736192L,BigInteger.Parse("59112926060691652608") };
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
public class A280897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280897Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280897.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280897.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280897Inst Instance=new A280897Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280898
{
public static readonly BigInteger[] Value={ 1L,213L,22568L,1451655L,75809243L,3521886844L,151803173493L,6210239609889L,244458357395448L,9341978860523675L,348715442831794031L,12770615176465927916UL,BigInteger.Parse("460340220926625794761"),BigInteger.Parse("16373994793450266278677") };
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
public class A280898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280898Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280898.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280898.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280898Inst Instance=new A280898Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280899
{
public static readonly BigInteger[] Value={ 2L,2292L,492490L,65348136L,7083739466L,684011230518L,61277484218852L,5208435552362140L,425813044528570428L,BigInteger.Parse("33785008405748220928"),BigInteger.Parse("2617623231970413715570"),BigInteger.Parse("198929682493832699515942") };
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
public class A280899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280899Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280899.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280899.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280899Inst Instance=new A280899Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280900
{
public static readonly BigInteger[] Value={ 9L,21762L,9426050L,2571528867L,574982226478L,114677717497532L,21239418911643829L,3734730743379447607L,BigInteger.Parse("631954681035516327314"),BigInteger.Parse("103814102347627733308778"),BigInteger.Parse("16657805707161598572521126") };
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
public class A280900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280900Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280900.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280900.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280900Inst Instance=new A280900Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280933
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280933Inst : IEnumerable<long>
{
public static readonly long[] Value=A280933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280933.Bytes);
public long this[int i]=>Value[i];

public static A280933Inst Instance=new A280933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280934
{
public static readonly long[] Value={ 1L,1L,4L,36L,52L,76L,92L,116L,136L,160L,176L,208L,224L,248L,272L,300L,316L,348L,364L,396L,420L,444L,460L,500L,520L,544L,568L,600L,616L,656L,672L,704L,728L,752L,776L,820L,836L,860L,884L,924L,940L,980L,996L,1028L,1060L,1084L,1100L,1148L,1168L,1200L,1224L,1256L,1272L,1312L,1336L,1376L,1400L,1424L,1440L,1496L,1512L,1536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280934Inst : IEnumerable<long>
{
public static readonly long[] Value=A280934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280934.Bytes);
public long this[int i]=>Value[i];

public static A280934Inst Instance=new A280934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280935
{
public static readonly long[] Value={ 16L,27L,72L,540L,2106L,2625L,3264L,5445L,5824L,5880L,10647L,13475L,15210L,15500L,18048L,22800L,28611L,37752L,38528L,39445L,42237L,47334L,61568L,64141L,68952L,69575L,70308L,71136L,71478L,72912L,74115L,75392L,79000L,80937L,83712L,89775L,100156L,100359L,113680L,114660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280935Inst : IEnumerable<long>
{
public static readonly long[] Value=A280935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280935.Bytes);
public long this[int i]=>Value[i];

public static A280935Inst Instance=new A280935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280936
{
public static readonly long[] Value={ 288L,1225L,4116L,35378L,54450L,1693776L,5969418L,9396618L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280936Inst : IEnumerable<long>
{
public static readonly long[] Value=A280936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280936.Bytes);
public long this[int i]=>Value[i];

public static A280936Inst Instance=new A280936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280937
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,11L,13L,20L,26L,36L,46L,63L,79L,105L,132L,171L,213L,273L,336L,425L,522L,650L,793L,981L,1188L,1456L,1756L,2136L,2563L,3098L,3698L,4443L,5285L,6312L,7477L,8891L,10489L,12415L,14599L,17206L,20165L,23678L,27659L,32363L,37698L,43958L,51058L,59361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280937Inst : IEnumerable<long>
{
public static readonly long[] Value=A280937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280937.Bytes);
public long this[int i]=>Value[i];

public static A280937Inst Instance=new A280937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280938
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,11L,15L,20L,28L,38L,50L,67L,87L,113L,146L,187L,237L,301L,378L,473L,590L,732L,903L,1113L,1364L,1666L,2030L,2464L,2981L,3600L,4332L,5201L,6229L,7442L,8869L,10551L,12521L,14829L,17531L,20684L,24357L,28638L,33607L,39375L,46062L,53798L,62736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280938Inst : IEnumerable<long>
{
public static readonly long[] Value=A280938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280938.Bytes);
public long this[int i]=>Value[i];

public static A280938Inst Instance=new A280938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280939
{
public static readonly BigInteger[] Value={ 1L,1L,4L,19L,121L,946L,8779L,94249L,1148746L,15667741L,236396029L,3909054304L,70297156021L,1365847397461L,28512838809004L,636437585232559L,15125744356058821L,381337518656892106L,10164860714961807079UL,BigInteger.Parse("285635253778131491389"),BigInteger.Parse("8438962752941736017146"),BigInteger.Parse("261512261403795336646801"),BigInteger.Parse("8481542634943973943517129"),BigInteger.Parse("287325556922319462615912544"),BigInteger.Parse("10148442521179099638781764121") };
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
public class A280939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280939Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280939.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280939.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280939Inst Instance=new A280939Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280940
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,4L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280940Inst : IEnumerable<long>
{
public static readonly long[] Value=A280940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280940.Bytes);
public long this[int i]=>Value[i];

public static A280940Inst Instance=new A280940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280941
{
public static readonly long[] Value={ 2L,3L,10L,0L,33L,45L,0L,294L,98L,0L,296L,262L,0L,428L,984L,0L,1456L,3086L,0L,2343L,1878L,0L,14938L,8422L,0L,2809L,4259L,0L,7809L,13819L,0L,51036L,45506L,0L,15782L,30764L,0L,57764L,24553L,0L,23282L,51942L,0L,44902L,34214L,0L,1242641L,95929L,0L,66761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280941Inst : IEnumerable<long>
{
public static readonly long[] Value=A280941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280941.Bytes);
public long this[int i]=>Value[i];

public static A280941Inst Instance=new A280941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280942
{
public static readonly long[] Value={ 1L,2L,12L,14L,31L,32L,42L,44L,69L,134L,146L,164L,560L,846L,1410L,1416L,1962L,1995L,2546L,3506L,4334L,7035L,12901L,20137L,42206L,45890L,58417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280942Inst : IEnumerable<long>
{
public static readonly long[] Value=A280942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280942.Bytes);
public long this[int i]=>Value[i];

public static A280942Inst Instance=new A280942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280943
{
public static readonly long[] Value={ 5L,10L,7L,20L,7L,14L,20L,40L,13L,14L,21L,28L,14L,40L,19L,33L,11L,26L,56L,28L,49L,42L,115L,56L,35L,28L,31L,57L,11L,38L,50L,66L,63L,11L,17L,52L,11L,112L,42L,51L,22L,98L,11L,84L,57L,35L,52L,95L,138L,13L,33L,56L,22L,62L,77L,114L,61L,22L,39L,76L,44L,13L,91L,57L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280943Inst : IEnumerable<long>
{
public static readonly long[] Value=A280943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280943.Bytes);
public long this[int i]=>Value[i];

public static A280943Inst Instance=new A280943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280944
{
public static readonly long[] Value={ 3L,6L,9L,13L,17L,21L,26L,31L,36L,41L,46L,52L,58L,64L,70L,76L,82L,88L,94L,101L,108L,115L,122L,129L,136L,144L,152L,160L,168L,176L,184L,192L,200L,208L,216L,224L,232L,240L,248L,257L,266L,275L,284L,293L,302L,311L,320L,329L,339L,349L,359L,369L,379L,389L,399L,409L,419L,429L,439L,449L,459L,469L,479L,489L,499L,510L,521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280944Inst : IEnumerable<long>
{
public static readonly long[] Value=A280944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280944.Bytes);
public long this[int i]=>Value[i];

public static A280944Inst Instance=new A280944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280945
{
public static readonly long[] Value={ 2L,2L,2L,2L,2L,3L,2L,6L,11L,3L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280945Inst : IEnumerable<long>
{
public static readonly long[] Value=A280945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280945.Bytes);
public long this[int i]=>Value[i];

public static A280945Inst Instance=new A280945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280946
{
public static readonly long[] Value={ 1L,8L,9L,10L,12L,14L,18L,22L,24L,25L,26L,28L,30L,32L,34L,35L,38L,40L,44L,46L,49L,52L,54L,55L,58L,60L,62L,63L,65L,66L,68L,72L,74L,76L,77L,78L,80L,81L,82L,84L,85L,86L,88L,90L,91L,92L,94L,95L,96L,98L,99L,102L,104L,106L,108L,110L,112L,114L,115L,116L,117L,118L,119L,121L,122L,124L,125L,126L,128L,130L,133L,134L,135L,136L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280946Inst : IEnumerable<long>
{
public static readonly long[] Value=A280946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280946.Bytes);
public long this[int i]=>Value[i];

public static A280946Inst Instance=new A280946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280947
{
public static readonly long[] Value={ 1L,2L,4L,8L,14L,24L,40L,64L,100L,153L,230L,340L,496L,714L,1016L,1432L,1998L,2764L,3793L,5166L,6988L,9392L,12546L,16664L,22016L,28940L,37860L,49306L,63936L,82568L,106216L,136128L,173844L,221256L,280680L,354952L,447530L,562624L,705352L,881920L,1099840L,1368188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280947Inst : IEnumerable<long>
{
public static readonly long[] Value=A280947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280947.Bytes);
public long this[int i]=>Value[i];

public static A280947Inst Instance=new A280947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280948
{
public static readonly long[] Value={ 1L,0L,2L,1L,4L,2L,7L,4L,12L,8L,20L,14L,32L,24L,50L,39L,76L,62L,114L,96L,168L,145L,244L,216L,350L,316L,496L,456L,696L,650L,968L,916L,1334L,1278L,1824L,1766L,2475L,2420L,3336L,3290L,4468L,4440L,5948L,5952L,7874L,7929L,10368L,10500L,13584L,13828L,17714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280948Inst : IEnumerable<long>
{
public static readonly long[] Value=A280948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280948.Bytes);
public long this[int i]=>Value[i];

public static A280948Inst Instance=new A280948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280998
{
public static readonly long[] Value={ 2L,4L,5L,6L,8L,9L,11L,12L,13L,14L,16L,17L,19L,21L,23L,24L,25L,27L,28L,29L,30L,32L,33L,35L,37L,39L,41L,43L,45L,47L,48L,49L,51L,53L,55L,56L,57L,59L,60L,61L,62L,64L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,96L,97L,99L,101L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280998Inst : IEnumerable<long>
{
public static readonly long[] Value=A280998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280998.Bytes);
public long this[int i]=>Value[i];

public static A280998Inst Instance=new A280998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280999
{
public static readonly long[] Value={ 7L,8L,12L,14L,15L,16L,17L,19L,23L,24L,25L,27L,28L,29L,30L,33L,34L,35L,36L,38L,39L,40L,44L,46L,47L,49L,50L,51L,52L,54L,55L,57L,58L,59L,61L,63L,64L,66L,68L,69L,70L,72L,73L,75L,76L,77L,78L,80L,81L,83L,87L,88L,89L,91L,92L,93L,94L,96L,98L,100L,101L,102L,104L,105L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280999Inst : IEnumerable<long>
{
public static readonly long[] Value=A280999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280999.Bytes);
public long this[int i]=>Value[i];

public static A280999Inst Instance=new A280999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281000
{
public static readonly long[] Value={ 1L,3L,1L,10L,10L,1L,35L,70L,21L,1L,126L,420L,252L,36L,1L,462L,2310L,2310L,660L,55L,1L,1716L,12012L,18018L,8580L,1430L,78L,1L,6435L,60060L,126126L,90090L,25025L,2730L,105L,1L,24310L,291720L,816816L,816816L,340340L,61880L,4760L,136L,1L,92378L,1385670L,4988412L,6651216L,3879876L,1058148L,135660L,7752L,171L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281000Inst : IEnumerable<long>
{
public static readonly long[] Value=A281000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281000.Bytes);
public long this[int i]=>Value[i];

public static A281000Inst Instance=new A281000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281001
{
public static readonly long[] Value={ 1093L,2L,11L,1093L,71L,1093L,2L,3L,2L,2L,1093L,11L,1093L,1093L,66161L,2L,71L,2L,2L,2L,5L,1093L,3L,1093L,1093L,1093L,2L,3L,2L,11L,2L,2L,2L,1093L,11L,2L,1093L,71L,1093L,1093L,1093L,2L,71L,1093L,3L,2L,3L,2L,2L,2L,1093L,3L,2L,11L,71L,1093L,11L,1093L,1093L,1093L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281001Inst : IEnumerable<long>
{
public static readonly long[] Value=A281001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281001.Bytes);
public long this[int i]=>Value[i];

public static A281001Inst Instance=new A281001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281002
{
public static readonly long[] Value={ 3511L,19L,1006003L,7L,11L,3511L,491531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281002Inst : IEnumerable<long>
{
public static readonly long[] Value=A281002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281002.Bytes);
public long this[int i]=>Value[i];

public static A281002Inst Instance=new A281002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281003
{
public static readonly long[] Value={ 1L,0L,0L,1L,6L,28L,252L,4726L,150324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281003Inst : IEnumerable<long>
{
public static readonly long[] Value=A281003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281003.Bytes);
public long this[int i]=>Value[i];

public static A281003Inst Instance=new A281003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281004
{
public static readonly long[] Value={ 13L,37L,41L,49L,67L,97L,131L,133L,145L,193L,259L,265L,273L,289L,385L,517L,529L,577L,1027L,1029L,1033L,1041L,1153L,1281L,2053L,2057L,4101L,4105L,4113L,4129L,4161L,6145L,8195L,8197L,8209L,8225L,8257L,8321L,8449L,8705L,10241L,16449L,17409L,18433L,20481L,24577L,32771L,32777L,32785L,32801L,32833L,32897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281004Inst : IEnumerable<long>
{
public static readonly long[] Value=A281004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281004.Bytes);
public long this[int i]=>Value[i];

public static A281004Inst Instance=new A281004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281005
{
public static readonly long[] Value={ 3L,5L,7L,9L,10L,11L,13L,14L,15L,17L,18L,19L,21L,22L,23L,25L,26L,27L,29L,30L,31L,33L,34L,35L,36L,37L,38L,39L,41L,42L,43L,44L,45L,46L,47L,49L,50L,51L,52L,53L,54L,55L,57L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L,78L,79L,81L,82L,83L,84L,85L,86L,87L,89L,90L,91L,92L,93L,94L,95L,97L,98L,99L,100L,101L,102L,103L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281005Inst : IEnumerable<long>
{
public static readonly long[] Value=A281005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281005.Bytes);
public long this[int i]=>Value[i];

public static A281005Inst Instance=new A281005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281006
{
public static readonly long[] Value={ 1L,3L,2L,5L,2L,8L,2L,9L,5L,10L,2L,18L,2L,12L,10L,17L,2L,23L,2L,24L,12L,16L,2L,38L,7L,18L,14L,30L,2L,44L,2L,33L,16L,22L,14L,57L,2L,24L,18L,52L,2L,56L,2L,42L,34L,28L,2L,78L,9L,45L,22L,48L,2L,68L,18L,66L,24L,34L,2L,110L,2L,36L,42L,65L,20L,80L,2L,60L,28L,76L,2L,125L,2L,42L,50L,66L,20L,92L,2L,108L,41L,46L,2L,142L,24L,48L,34L,94L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281006Inst : IEnumerable<long>
{
public static readonly long[] Value=A281006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281006.Bytes);
public long this[int i]=>Value[i];

public static A281006Inst Instance=new A281006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281007
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,2L,2L,1L,2L,1L,2L,2L,2L,2L,1L,1L,2L,2L,2L,2L,1L,2L,2L,3L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L,1L,2L,2L,2L,2L,2L,4L,1L,2L,1L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,1L,2L,2L,1L,2L,2L,4L,2L,2L,2L,2L,2L,1L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,4L,1L,2L,4L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281007Inst : IEnumerable<long>
{
public static readonly long[] Value=A281007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281007.Bytes);
public long this[int i]=>Value[i];

public static A281007Inst Instance=new A281007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281008
{
public static readonly long[] Value={ 1L,3L,21L,75L,105L,315L,495L,945L,1575L,2835L,3465L,4095L,11025L,17955L,10395L,23205L,17325L,24255L,31185L,36855L,51975L,61425L,45045L,108675L,143325L,121275L,184275L,155925L,135135L,176715L,239085L,315315L,294525L,225225L,606375L,626535L,405405L,700245L,1531530L,1351350L,2072070L,1289925L,855855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281008Inst : IEnumerable<long>
{
public static readonly long[] Value=A281008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281008.Bytes);
public long this[int i]=>Value[i];

public static A281008Inst Instance=new A281008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281009
{
public static readonly long[] Value={ 0L,0L,2L,0L,2L,0L,2L,0L,2L,2L,2L,0L,2L,2L,2L,0L,2L,2L,2L,0L,4L,2L,2L,0L,2L,2L,4L,0L,2L,2L,2L,0L,4L,2L,2L,2L,2L,2L,4L,0L,2L,2L,2L,2L,4L,2L,2L,0L,2L,2L,4L,2L,2L,2L,4L,0L,4L,2L,2L,2L,2L,2L,4L,0L,4L,2L,2L,2L,4L,2L,2L,0L,2L,2L,6L,2L,2L,4L,2L,0L,4L,2L,2L,2L,4L,2L,4L,0L,2L,4L,2L,2L,4L,2L,4L,0L,2L,2L,4L,2L,2L,4L,2L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281009Inst : IEnumerable<long>
{
public static readonly long[] Value=A281009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281009.Bytes);
public long this[int i]=>Value[i];

public static A281009Inst Instance=new A281009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281010
{
public static readonly long[] Value={ 1L,1L,-1L,1L,1L,1L,1L,0L,0L,-1L,1L,1L,0L,1L,1L,1L,0L,-1L,1L,0L,-1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,-1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,-1L,0L,0L,1L,0L,0L,-1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,-1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,-1L,0L,0L,0L,0L,1L,0L,0L,0L,-1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281010Inst : IEnumerable<long>
{
public static readonly long[] Value=A281010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281010.Bytes);
public long this[int i]=>Value[i];

public static A281010Inst Instance=new A281010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281011
{
public static readonly long[] Value={ 1L,-1L,1L,0L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,0L,0L,0L,0L,0L,-1L,1L,0L,0L,-1L,0L,0L,1L,0L,0L,-1L,1L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,-1L,1L,0L,0L,0L,-1L,0L,0L,0L,0L,1L,0L,0L,0L,-1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,1L,0L,0L,0L,0L,-1L,0L,1L,0L,0L,-1L,0L,1L,0L,0L,0L,0L,-1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281011Inst : IEnumerable<long>
{
public static readonly long[] Value=A281011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281011.Bytes);
public long this[int i]=>Value[i];

public static A281011Inst Instance=new A281011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281012
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,2L,2L,1L,1L,1L,3L,2L,3L,2L,1L,1L,2L,1L,2L,2L,4L,2L,1L,1L,3L,2L,2L,2L,2L,1L,3L,2L,1L,1L,4L,2L,2L,2L,3L,2L,3L,2L,1L,1L,1L,1L,4L,2L,2L,2L,4L,2L,3L,2L,1L,1L,2L,2L,4L,2L,2L,3L,5L,2L,3L,2L,1L,1L,3L,2L,4L,2L,2L,2L,1L,2L,5L,2L,2L,1L,1L,2L,1L,1L,4L,2L,4L,2L,2L,2L,2L,2L,5L,2L,3L,4L,1L,1L,5L,2L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281012Inst : IEnumerable<long>
{
public static readonly long[] Value=A281012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281012.Bytes);
public long this[int i]=>Value[i];

public static A281012Inst Instance=new A281012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281013
{
public static readonly long[] Value={ 1L,2L,2L,1L,3L,2L,1L,1L,3L,1L,4L,2L,1L,1L,1L,2L,2L,1L,3L,1L,1L,3L,2L,4L,1L,5L,2L,1L,1L,1L,1L,2L,2L,1L,1L,3L,1L,1L,1L,3L,1L,2L,3L,2L,1L,4L,1L,1L,4L,2L,5L,1L,6L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,2L,2L,1L,1L,1L,2L,2L,2L,1L,3L,1L,1L,1L,1L,3L,1L,1L,2L,3L,1L,2L,1L,3L,2L,1L,1L,3L,2L,2L,3L,3L,1L,4L,1L,1L,1L,4L,1L,2L,4L,2L,1L,4L,3L,5L,1L,1L,5L,2L,6L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281013Inst : IEnumerable<long>
{
public static readonly long[] Value=A281013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281013.Bytes);
public long this[int i]=>Value[i];

public static A281013Inst Instance=new A281013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281352
{
public static readonly long[] Value={ 1L,6L,12L,14L,30L,48L,36L,48L,84L,86L,48L,96L,86L,96L,96L,144L,126L,192L,108L,96L,192L,240L,96L,288L,252L,150L,144L,158L,192L,432L,240L,144L,372L,288L,96L,384L,446L,192L,288L,480L,336L,384L,288L,288L,528L,432L,192L,480L,374L,294L,300L,576L,384L,720L,324L,384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281352Inst : IEnumerable<long>
{
public static readonly long[] Value=A281352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281352.Bytes);
public long this[int i]=>Value[i];

public static A281352Inst Instance=new A281352Inst();

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