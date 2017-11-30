using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A159805
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,2L,2L,4L,3L,3L,4L,4L,4L,4L,5L,4L,5L,6L,5L,6L,5L,7L,7L,4L,10L,5L,5L,10L,8L,6L,7L,5L,7L,5L,7L,10L,7L,10L,12L,11L,10L,7L,11L,10L,10L,10L,12L,8L,9L,11L,9L,9L,8L,9L,15L,15L,9L,14L,11L,14L,17L,11L,11L,10L,17L,14L,15L,13L,17L,17L,13L,12L,16L,13L,20L,17L,11L,14L,14L,17L,16L,17L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159805Inst : IEnumerable<long>
{
public static readonly long[] Value=A159805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159805.Bytes);
public long this[int i]=>Value[i];

public static A159805Inst Instance=new A159805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159806
{
public static readonly BigInteger[] Value={ 1L,1L,-241L,-725L,174241L,876041L,-209955569L,-1481967101L,354182766785L,3223271074321L,-768186794983409L,-8568502794840229L,2036344745450994529L,BigInteger.Parse("26919276861667019545"),BigInteger.Parse("-6379421292327161768689"),BigInteger.Parse("-97581931299655023987149"),BigInteger.Parse("23059717359847942196353921") };
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
public class A159806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159806Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159806.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159806.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159806Inst Instance=new A159806Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159807
{
public static readonly BigInteger[] Value={ 1L,3L,-233L,-2151L,162705L,2570283L,-189162201L,-4299537519L,307542155937L,9246531104595L,-642087222317001L,-24302866940070903L,1636327584987643953L,BigInteger.Parse("75484508348928834171"),BigInteger.Parse("-4921433057324341373625"),BigInteger.Parse("-270505813458143914292223"),BigInteger.Parse("17053284557712927443382081") };
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
public class A159807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159807Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159807.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159807.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159807Inst Instance=new A159807Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159808
{
public static readonly BigInteger[] Value={ 1L,5L,-217L,-3505L,140017L,4092925L,-148955945L,-6687706825L,218892836705L,14041864596725L,-406539275359865L,-36014008700873825L,902137507503591505L,BigInteger.Parse("109095368804855545325"),BigInteger.Parse("-2292647754582021148105"),BigInteger.Parse("-381078348283760693301625"),BigInteger.Parse("6416919607713933301113025") };
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
public class A159808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159808Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159808.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159808.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159808Inst Instance=new A159808Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159809
{
public static readonly long[] Value={ 197L,223L,257L,925L,1115L,1345L,5353L,6467L,7813L,31193L,37687L,45533L,181805L,219655L,265385L,1059637L,1280243L,1546777L,6176017L,7461803L,9015277L,35996465L,43490575L,52544885L,209802773L,253481647L,306254033L,1222820173L,1477399307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159809Inst : IEnumerable<long>
{
public static readonly long[] Value=A159809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159809.Bytes);
public long this[int i]=>Value[i];

public static A159809Inst Instance=new A159809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159810
{
public static readonly long[] Value={ 1L,2L,0L,8L,1L,9L,0L,1L,6L,5L,3L,4L,1L,6L,7L,1L,9L,7L,9L,6L,5L,9L,4L,2L,0L,0L,0L,7L,7L,4L,1L,2L,1L,4L,9L,8L,8L,1L,4L,8L,3L,8L,6L,3L,5L,0L,9L,4L,7L,5L,7L,1L,4L,8L,9L,6L,6L,5L,0L,2L,4L,1L,7L,9L,9L,9L,8L,7L,5L,3L,2L,4L,8L,2L,2L,3L,6L,0L,1L,8L,4L,3L,7L,9L,1L,5L,3L,1L,9L,5L,5L,2L,9L,0L,7L,1L,4L,1L,1L,2L,9L,2L,3L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159810Inst : IEnumerable<long>
{
public static readonly long[] Value=A159810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159810.Bytes);
public long this[int i]=>Value[i];

public static A159810Inst Instance=new A159810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159811
{
public static readonly long[] Value={ 3L,9L,9L,2L,8L,2L,9L,6L,1L,6L,0L,5L,9L,5L,4L,0L,8L,7L,1L,9L,4L,7L,0L,2L,3L,1L,5L,9L,0L,3L,2L,9L,5L,2L,8L,8L,8L,1L,2L,8L,2L,0L,0L,2L,4L,6L,4L,5L,6L,8L,4L,4L,6L,8L,4L,5L,6L,7L,9L,4L,1L,7L,1L,2L,0L,8L,5L,7L,8L,9L,2L,9L,0L,3L,1L,0L,4L,7L,7L,1L,6L,5L,0L,8L,0L,2L,9L,1L,1L,5L,7L,7L,4L,8L,8L,0L,1L,7L,0L,9L,3L,2L,0L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159811Inst : IEnumerable<long>
{
public static readonly long[] Value=A159811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159811.Bytes);
public long this[int i]=>Value[i];

public static A159811Inst Instance=new A159811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159812
{
public static readonly long[] Value={ 2104L,5573L,4093L,20131L,19637L,22523L,177913L,334634L,167084L,441730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159812Inst : IEnumerable<long>
{
public static readonly long[] Value=A159812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159812.Bytes);
public long this[int i]=>Value[i];

public static A159812Inst Instance=new A159812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159813
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,0L,0L,1L,1L,-1L,0L,0L,0L,0L,1L,-2L,1L,0L,3L,0L,0L,-2L,-2L,0L,0L,-1L,0L,0L,-1L,0L,2L,0L,-1L,0L,0L,0L,1L,4L,0L,2L,0L,0L,-2L,0L,0L,0L,-4L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,-1L,2L,-2L,0L,2L,0L,0L,-1L,-1L,-2L,0L,0L,0L,0L,4L,2L,-3L,0L,2L,0L,0L,2L,2L,-2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159813Inst : IEnumerable<long>
{
public static readonly long[] Value=A159813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159813.Bytes);
public long this[int i]=>Value[i];

public static A159813Inst Instance=new A159813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159814
{
public static readonly long[] Value={ 1L,-2L,0L,0L,-4L,12L,0L,0L,-3L,-20L,0L,0L,28L,-8L,0L,0L,-8L,42L,0L,0L,-72L,-20L,0L,0L,29L,36L,0L,0L,84L,-72L,0L,0L,24L,-40L,0L,0L,-68L,36L,0L,0L,-112L,24L,0L,0L,84L,248L,0L,0L,-39L,-158L,0L,0L,-12L,-144L,0L,0L,216L,-116L,0L,0L,-108L,-16L,0L,0L,80L,144L,0L,0L,48L,152L,0L,0L,-232L,220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159814Inst : IEnumerable<long>
{
public static readonly long[] Value=A159814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159814.Bytes);
public long this[int i]=>Value[i];

public static A159814Inst Instance=new A159814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159815
{
public static readonly long[] Value={ 7L,707L,7007L,7043L,7057L,22143L,22157L,22193L,22207L,22243L,22257L,22293L,22307L,22343L,22357L,70007L,70043L,70057L,70093L,70107L,70143L,70157L,70193L,70207L,70243L,70257L,70293L,70307L,70343L,70357L,70393L,70407L,70443L,70457L,70493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159815Inst : IEnumerable<long>
{
public static readonly long[] Value=A159815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159815.Bytes);
public long this[int i]=>Value[i];

public static A159815Inst Instance=new A159815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159816
{
public static readonly long[] Value={ 1025874L,1028574L,1042587L,1042857L,1052874L,1054287L,1072854L,1074285L,1078524L,1078542L,1085274L,1085427L,1087254L,1087425L,1087524L,1087542L,1207854L,1208754L,1240785L,1240875L,1245789L,1245879L,1247589L,1247859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159816Inst : IEnumerable<long>
{
public static readonly long[] Value=A159816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159816.Bytes);
public long this[int i]=>Value[i];

public static A159816Inst Instance=new A159816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159817
{
public static readonly long[] Value={ 1L,2L,-1L,-2L,1L,0L,2L,-2L,-6L,4L,-4L,-6L,1L,-4L,6L,4L,0L,2L,2L,4L,6L,10L,-1L,6L,-3L,-12L,-6L,0L,8L,-12L,2L,-2L,-2L,-2L,-12L,12L,2L,2L,0L,-8L,-11L,-6L,6L,12L,-6L,-4L,8L,-4L,2L,0L,6L,-14L,4L,6L,2L,4L,-6L,6L,2L,12L,-11L,12L,-1L,-2L,20L,0L,-8L,4L,18L,4L,12L,0L,-6L,-6L,-6L,-20L,-6L,-4L,-22L,-12L,12L,10L,0L,-18L,-9L,4L,-6L,-2L,-24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159817Inst : IEnumerable<long>
{
public static readonly long[] Value=A159817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159817.Bytes);
public long this[int i]=>Value[i];

public static A159817Inst Instance=new A159817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159818
{
public static readonly long[] Value={ 1L,1L,-1L,0L,0L,0L,1L,-2L,0L,0L,-2L,-1L,-1L,0L,0L,2L,0L,0L,0L,0L,1L,0L,2L,0L,0L,-2L,0L,2L,0L,0L,1L,1L,0L,0L,0L,0L,-2L,2L,0L,0L,0L,0L,1L,0L,0L,-2L,0L,0L,0L,0L,0L,-2L,0L,0L,0L,0L,-1L,-2L,0L,0L,-2L,-1L,0L,0L,0L,2L,0L,2L,0L,0L,-2L,0L,1L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-2L,0L,0L,1L,0L,2L,0L,0L,0L,0L,2L,0L,0L,2L,1L,-2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159818Inst : IEnumerable<long>
{
public static readonly long[] Value=A159818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159818.Bytes);
public long this[int i]=>Value[i];

public static A159818Inst Instance=new A159818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159819
{
public static readonly long[] Value={ 1L,1L,-2L,0L,1L,-4L,-2L,-2L,2L,4L,0L,8L,-1L,1L,6L,-8L,-4L,0L,6L,-2L,-6L,-4L,-2L,0L,-7L,2L,-2L,8L,4L,-4L,-2L,0L,4L,4L,8L,-8L,10L,-1L,0L,8L,1L,4L,-4L,6L,-6L,0L,-8L,-8L,2L,-4L,-18L,-16L,0L,12L,-2L,6L,18L,-16L,-2L,0L,5L,-6L,12L,8L,-4L,4L,0L,-2L,-6L,12L,0L,8L,-12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159819Inst : IEnumerable<long>
{
public static readonly long[] Value=A159819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159819.Bytes);
public long this[int i]=>Value[i];

public static A159819Inst Instance=new A159819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159820
{
public static readonly long[] Value={ 13L,1L,4L,2L,13L,3L,1L,1L,7L,3L,30L,1L,7L,1L,1L,40L,2L,6L,2L,1L,35L,4L,1L,3L,3L,1L,3L,3L,8L,1L,1L,4L,3L,5L,7L,1L,1L,1L,1L,2L,1L,2L,2L,1L,188L,3L,2L,1L,7L,1L,1L,13L,1L,7L,28L,2L,2L,47L,31L,1L,1L,1L,5L,3L,1L,7L,2L,3L,1L,3L,2L,1L,3L,4L,4L,2L,1L,1L,3L,1L,1L,1L,3L,4L,1L,19L,225L,1L,1L,16L,1L,1L,1L,1L,11L,4L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159820Inst : IEnumerable<long>
{
public static readonly long[] Value=A159820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159820.Bytes);
public long this[int i]=>Value[i];

public static A159820Inst Instance=new A159820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159821
{
public static readonly long[] Value={ 190L,1L,12L,2L,2L,1L,12L,2L,10L,2L,1L,16L,1L,226L,2L,1L,2L,1L,2L,2L,1L,1L,9L,3L,7L,1L,1L,1L,2L,1L,1L,1L,6L,2L,2L,494L,1L,1L,60L,194L,2L,1L,2L,1L,4L,1L,1L,7L,1L,4L,7L,1L,1L,1L,5L,4L,2L,5L,2L,1L,4L,4L,1L,7L,1L,16L,4L,1L,1L,4L,2L,1L,5283L,4L,11L,1L,2L,1L,3L,1L,1L,1L,5L,1L,1L,2L,3L,3L,1L,3L,5L,3L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159821Inst : IEnumerable<long>
{
public static readonly long[] Value=A159821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159821.Bytes);
public long this[int i]=>Value[i];

public static A159821Inst Instance=new A159821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159822
{
public static readonly long[] Value={ 8L,1L,1L,5L,1L,3L,1L,4L,12L,3L,2L,1L,5L,2L,12L,1L,1L,1L,10L,2L,2L,2L,3L,8L,3L,2L,2L,2L,29L,1L,1L,13L,1L,1L,8L,11L,16L,3L,1L,4L,163L,2L,1L,1L,1L,5L,1L,6L,1L,17L,5L,1L,3L,6L,3L,1L,4L,1L,1L,1L,5L,1L,7L,15L,4L,1L,1L,1L,9L,1L,1L,4L,1L,1L,9L,1L,55L,14L,14L,1L,3L,2L,3L,7L,1L,118L,1L,2L,29L,1L,2L,2L,1L,4L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159822Inst : IEnumerable<long>
{
public static readonly long[] Value=A159822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159822.Bytes);
public long this[int i]=>Value[i];

public static A159822Inst Instance=new A159822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159823
{
public static readonly long[] Value={ 4L,2L,1L,1L,22L,1L,1L,4L,5L,2L,2L,1L,1L,15L,1L,12L,2L,2L,6L,10L,6L,1L,11L,3L,1L,3L,33L,1L,1L,1L,2L,2L,1L,4L,1L,2L,3L,3L,8L,1L,1L,1L,1L,2L,1L,3L,32L,3L,1L,1L,2L,2L,1L,5L,10L,1L,1L,1L,2L,2L,1L,1L,1L,4L,2L,2L,20L,2L,1L,2L,1L,1L,3L,1L,1L,2L,5L,1L,9L,1L,23L,1L,291L,1L,3L,2L,9L,7L,1L,1L,3L,10L,5L,2L,1L,13L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159823Inst : IEnumerable<long>
{
public static readonly long[] Value=A159823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159823.Bytes);
public long this[int i]=>Value[i];

public static A159823Inst Instance=new A159823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159824
{
public static readonly long[] Value={ 36L,2L,6L,9L,2L,1L,2L,5L,1L,1L,6L,2L,1L,291L,1L,38L,50L,1L,2L,5L,4L,1L,2L,2L,1L,5L,1L,4L,13L,2L,1L,4L,3L,3L,1L,2L,25L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,3L,1L,43L,1L,2L,7L,3L,1L,1L,1L,2L,4L,2L,1L,1L,3L,1L,3L,3L,2L,2L,16L,3L,5L,2L,1L,5L,2L,1L,10L,1L,1L,3L,1L,13L,1L,1L,3L,1L,10L,4L,1L,1L,1L,38L,1L,2L,2L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159824Inst : IEnumerable<long>
{
public static readonly long[] Value=A159824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159824.Bytes);
public long this[int i]=>Value[i];

public static A159824Inst Instance=new A159824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159825
{
public static readonly long[] Value={ 3814279L,9L,1L,1L,4L,1L,53L,26L,1L,13L,3L,1L,1L,22L,1L,226L,1L,5L,2L,1L,6L,2L,3L,1L,4L,1L,6L,39L,2L,1L,3L,1L,5L,1L,4L,1L,3L,1L,4L,1L,1L,19L,1L,2L,8899L,5L,2L,2L,1L,3L,3L,2L,2L,2L,1L,1L,3L,5L,1L,6L,10L,2L,1L,2L,1L,1L,1L,2L,2L,4L,1L,10L,2L,6L,1L,5L,6L,2L,4L,2L,1L,2L,1L,1L,1L,3L,2L,2L,1L,1L,11L,7L,3L,1L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159825Inst : IEnumerable<long>
{
public static readonly long[] Value=A159825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159825.Bytes);
public long this[int i]=>Value[i];

public static A159825Inst Instance=new A159825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159826
{
public static readonly BigInteger[] Value={ 1L,7L,-193L,-4739L,106945L,5335967L,-92051681L,-8392185851L,97190246657L,16927603534135L,-93187132480001L,-41617110479966707L,-43255626698004287L,BigInteger.Parse("120553299446937287119"),BigInteger.Parse("979955297720482496735"),BigInteger.Parse("-401574891442180151282027"),BigInteger.Parse("-6368261970820612522122239") };
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
public class A159826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159826Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159826.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159826.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159826Inst Instance=new A159826Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159827
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,12L,288L,4032L,47904L,398736L,2668464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159827Inst : IEnumerable<long>
{
public static readonly long[] Value=A159827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159827.Bytes);
public long this[int i]=>Value[i];

public static A159827Inst Instance=new A159827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159828
{
public static readonly long[] Value={ 1L,6L,1L,6L,9L,2L,3L,6L,1L,6L,3L,2L,3L,6L,1L,6L,27L,8L,9L,24L,1L,6L,21L,4L,69L,12L,3L,6L,21L,6L,3L,6L,1L,6L,9L,2L,9L,6L,1L,6L,15L,6L,9L,6L,1L,6L,27L,2L,3L,36L,9L,6L,3L,6L,15L,18L,1L,48L,3L,4L,9L,6L,7L,6L,15L,4L,21L,42L,5L,6L,3L,2L,69L,18L,5L,6L,3L,2L,9L,24L,1L,6L,3L,8L,9L,6L,11L,18L,15L,4L,3L,6L,7L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159828Inst : IEnumerable<long>
{
public static readonly long[] Value=A159828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159828.Bytes);
public long this[int i]=>Value[i];

public static A159828Inst Instance=new A159828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159829
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,4L,15L,2L,3L,2L,11L,10L,9L,2L,7L,14L,5L,4L,9L,2L,15L,2L,7L,16L,15L,8L,13L,2L,1L,10L,3L,4L,15L,2L,11L,10L,9L,2L,7L,6L,13L,22L,5L,2L,1L,6L,29L,10L,29L,10L,3L,2L,11L,12L,3L,8L,3L,2L,19L,6L,15L,8L,1L,2L,1L,18L,5L,2L,1L,18L,1L,12L,17L,14L,15L,26L,7L,6L,3L,2L,19L,12L,1L,18L,3L,8L,15L,2L,11L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159829Inst : IEnumerable<long>
{
public static readonly long[] Value=A159829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159829.Bytes);
public long this[int i]=>Value[i];

public static A159829Inst Instance=new A159829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159830
{
public static readonly long[] Value={ 1L,-1L,1L,2L,-2L,1L,-3L,6L,-3L,1L,7L,-12L,12L,-4L,1L,-10L,35L,-30L,20L,-5L,1L,31L,-60L,105L,-60L,30L,-6L,1L,-21L,217L,-210L,245L,-105L,42L,-7L,1L,204L,-168L,868L,-560L,490L,-168L,56L,-8L,1L,307L,1836L,-756L,2604L,-1260L,882L,-252L,72L,-9L,1L,2811L,3070L,9180L,-2520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159830Inst : IEnumerable<long>
{
public static readonly long[] Value=A159830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159830.Bytes);
public long this[int i]=>Value[i];

public static A159830Inst Instance=new A159830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159831
{
public static readonly BigInteger[] Value={ 1L,9L,-161L,-5805L,64641L,6201009L,-22406529L,-9205523829L,-44893054335L,17417856643929L,254537782136991L,-39860373039075261L,-1036322933400347391L,BigInteger.Parse("106427616904871431425"),BigInteger.Parse("4218120500621335774911"),BigInteger.Parse("-322613681568112387693701"),BigInteger.Parse("-18215300551368460352170239") };
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
public class A159831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159831Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159831.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159831.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159831Inst Instance=new A159831Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159832
{
public static readonly BigInteger[] Value={ 1L,13L,-73L,-7241L,-41135L,6474533L,133942279L,-7659772289L,-326475260383L,10585140766525L,848669947078999L,-14583331342963513L,-2448742706582821007L,10516339034389368661UL,BigInteger.Parse("7840456962356616680615"),BigInteger.Parse("66296583862124835824527"),BigInteger.Parse("-27599003183146895684913599") };
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
public class A159832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159832Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159832.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159832.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159832Inst Instance=new A159832Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159833
{
public static readonly long[] Value={ 0L,4L,19L,54L,124L,250L,459L,784L,1264L,1944L,2875L,4114L,5724L,7774L,10339L,13500L,17344L,21964L,27459L,33934L,41500L,50274L,60379L,71944L,85104L,100000L,116779L,135594L,156604L,179974L,205875L,234484L,265984L,300564L,338419L,379750L,424764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159833Inst : IEnumerable<long>
{
public static readonly long[] Value=A159833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159833.Bytes);
public long this[int i]=>Value[i];

public static A159833Inst Instance=new A159833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159834
{
public static readonly long[] Value={ 1L,-1L,1L,0L,-2L,1L,2L,0L,-3L,1L,-2L,8L,0L,-4L,1L,-6L,-10L,20L,0L,-5L,1L,16L,-36L,-30L,40L,0L,-6L,1L,20L,112L,-126L,-70L,70L,0L,-7L,1L,-132L,160L,448L,-336L,-140L,112L,0L,-8L,1L,-28L,-1188L,720L,1344L,-756L,-252L,168L,0L,-9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159834Inst : IEnumerable<long>
{
public static readonly long[] Value=A159834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159834.Bytes);
public long this[int i]=>Value[i];

public static A159834Inst Instance=new A159834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159835
{
public static readonly long[] Value={ 1L,4L,4L,4L,4L,6L,11L,11L,11L,14L,61L,266L,1006L,1030L,1261L,6264L,7583L,7979L,7986L,12386L,80041L,87434L,130927L,270073L,1653819L,1715177L,1973657L,3483485L,12346987L,17531499L,21237674L,84101406L,95403456L,664784809L,14591838849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159835Inst : IEnumerable<long>
{
public static readonly long[] Value=A159835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159835.Bytes);
public long this[int i]=>Value[i];

public static A159835Inst Instance=new A159835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159836
{
public static readonly long[] Value={ 8L,9L,18L,24L,25L,32L,36L,40L,45L,49L,50L,56L,63L,64L,75L,81L,88L,90L,96L,98L,99L,100L,104L,117L,120L,121L,125L,126L,128L,136L,144L,147L,150L,152L,153L,160L,162L,168L,169L,171L,175L,180L,184L,192L,196L,198L,200L,207L,216L,224L,225L,232L,234L,242L,243L,245L,248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159836Inst : IEnumerable<long>
{
public static readonly long[] Value=A159836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159836.Bytes);
public long this[int i]=>Value[i];

public static A159836Inst Instance=new A159836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159837
{
public static readonly long[] Value={ 10348965L,100348965L,103489650L,103489965L,103498965L,1000348965L,1003489650L,1003489965L,1003498965L,1023748965L,1032890967L,1032896709L,1032908967L,1032967089L,1034896500L,1034897625L,1034899650L,1034899965L,1034989650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159837Inst : IEnumerable<long>
{
public static readonly long[] Value=A159837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159837.Bytes);
public long this[int i]=>Value[i];

public static A159837Inst Instance=new A159837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159838
{
public static readonly long[] Value={ 10L,66L,70L,78L,114L,130L,154L,174L,222L,238L,282L,310L,318L,370L,390L,418L,474L,510L,574L,618L,642L,670L,678L,690L,742L,754L,790L,798L,814L,822L,870L,874L,930L,978L,1090L,1122L,1162L,1182L,1218L,1230L,1374L,1378L,1398L,1434L,1498L,1542L,1554L,1570L,1578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159838Inst : IEnumerable<long>
{
public static readonly long[] Value=A159838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159838.Bytes);
public long this[int i]=>Value[i];

public static A159838Inst Instance=new A159838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159839
{
public static readonly long[] Value={ 1L,10L,13L,19L,23L,28L,31L,32L,44L,49L,68L,79L,82L,86L,91L,94L,97L,100L,103L,109L,129L,130L,133L,139L,167L,176L,188L,190L,192L,193L,203L,208L,219L,226L,230L,239L,236L,262L,263L,277L,280L,291L,293L,301L,302L,310L,313L,319L,320L,326L,329L,331L,338L,362L,367L,368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159839Inst : IEnumerable<long>
{
public static readonly long[] Value=A159839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159839.Bytes);
public long this[int i]=>Value[i];

public static A159839Inst Instance=new A159839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159840
{
public static readonly BigInteger[] Value={ 1L,15L,-17L,-7515L,-100383L,5768775L,207995055L,-5256335475L,-431188655295L,3708435650175L,994755425985135L,5946917116353525L,-2558835187227126495L,BigInteger.Parse("-55652375114297534025"),BigInteger.Parse("7215309872302076942895"),BigInteger.Parse("296779894971771199420125"),BigInteger.Parse("-21739876411879971311406975") };
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
public class A159840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159840Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159840.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159840.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159840Inst Instance=new A159840Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159841
{
public static readonly long[] Value={ 1L,4L,1L,21L,7L,1L,120L,45L,10L,1L,715L,286L,78L,13L,1L,4368L,1820L,560L,120L,16L,1L,27132L,11628L,3876L,969L,171L,19L,1L,170544L,74613L,26334L,7315L,1540L,231L,22L,1L,1081575L,480700L,177100L,53130L,12650L,2300L,300L,25L,1L,6906900L,3108105L,1184040L,376740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159841Inst : IEnumerable<long>
{
public static readonly long[] Value=A159841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159841.Bytes);
public long this[int i]=>Value[i];

public static A159841Inst Instance=new A159841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159842
{
public static readonly long[] Value={ 1L,2L,3L,7L,5L,10L,7L,20L,14L,18L,11L,41L,15L,28L,31L,58L,21L,60L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159842Inst : IEnumerable<long>
{
public static readonly long[] Value=A159842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159842.Bytes);
public long this[int i]=>Value[i];

public static A159842Inst Instance=new A159842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159843
{
public static readonly long[] Value={ 1L,2L,6L,7L,8L,9L,12L,13L,15L,16L,17L,19L,20L,22L,26L,27L,28L,30L,31L,33L,34L,35L,37L,42L,43L,48L,49L,50L,51L,53L,54L,56L,58L,61L,62L,63L,64L,65L,67L,68L,69L,70L,71L,72L,75L,78L,79L,84L,85L,86L,87L,89L,90L,91L,92L,94L,96L,97L,98L,103L,104L,105L,106L,107L,110L,114L,115L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159843Inst : IEnumerable<long>
{
public static readonly long[] Value=A159843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159843.Bytes);
public long this[int i]=>Value[i];

public static A159843Inst Instance=new A159843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159844
{
public static readonly long[] Value={ 325L,359L,401L,1549L,1795L,2081L,8969L,10411L,12085L,52265L,60671L,70429L,304621L,353615L,410489L,1775461L,2061019L,2392505L,10348145L,12012499L,13944541L,60313409L,70013975L,81274741L,351532309L,408071351L,473703905L,2048880445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159844Inst : IEnumerable<long>
{
public static readonly long[] Value=A159844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159844.Bytes);
public long this[int i]=>Value[i];

public static A159844Inst Instance=new A159844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159845
{
public static readonly long[] Value={ 1L,1L,6L,0L,8L,3L,5L,9L,7L,5L,9L,6L,1L,4L,9L,7L,5L,2L,6L,0L,5L,7L,0L,0L,3L,2L,6L,3L,2L,8L,6L,8L,2L,0L,4L,0L,9L,4L,3L,0L,7L,7L,3L,0L,6L,7L,5L,8L,8L,6L,4L,6L,3L,1L,4L,1L,5L,2L,4L,0L,6L,2L,1L,1L,8L,2L,0L,7L,4L,6L,0L,5L,6L,2L,1L,6L,0L,4L,4L,7L,5L,6L,2L,0L,1L,4L,3L,3L,7L,7L,8L,0L,0L,6L,8L,2L,5L,5L,7L,0L,3L,7L,3L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159845Inst : IEnumerable<long>
{
public static readonly long[] Value=A159845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159845.Bytes);
public long this[int i]=>Value[i];

public static A159845Inst Instance=new A159845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159846
{
public static readonly long[] Value={ 4L,3L,2L,5L,2L,3L,4L,4L,4L,1L,5L,4L,4L,5L,3L,2L,4L,0L,8L,6L,0L,9L,1L,4L,3L,5L,6L,2L,6L,7L,6L,5L,7L,1L,2L,2L,8L,9L,4L,1L,2L,1L,1L,5L,6L,9L,9L,8L,7L,5L,8L,2L,8L,3L,2L,6L,2L,1L,6L,4L,0L,1L,5L,7L,3L,7L,1L,3L,0L,4L,8L,7L,7L,0L,3L,4L,6L,7L,5L,9L,2L,6L,6L,1L,0L,9L,0L,3L,0L,3L,8L,6L,8L,5L,4L,6L,5L,9L,3L,6L,7L,4L,5L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159846Inst : IEnumerable<long>
{
public static readonly long[] Value=A159846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159846.Bytes);
public long this[int i]=>Value[i];

public static A159846Inst Instance=new A159846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159847
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,3L,7L,1L,4L,1L,22L,14L,15L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159847Inst : IEnumerable<long>
{
public static readonly long[] Value=A159847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159847.Bytes);
public long this[int i]=>Value[i];

public static A159847Inst Instance=new A159847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159848
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,9L,13L,19L,28L,34L,38L,57L,85L,87L,90L,103L,122L,135L,139L,173L,186L,199L,205L,243L,300L,309L,347L,520L,524L,530L,539L,552L,586L,595L,614L,652L,658L,667L,705L,711L,910L,1109L,1194L,1279L,1298L,1332L,1370L,1543L,1549L,1562L,1575L,1609L,1618L,1627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159848Inst : IEnumerable<long>
{
public static readonly long[] Value=A159848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159848.Bytes);
public long this[int i]=>Value[i];

public static A159848Inst Instance=new A159848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159849
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,6L,9L,6L,4L,19L,28L,2L,3L,13L,19L,13L,4L,34L,13L,13L,6L,38L,57L,9L,38L,173L,4L,6L,9L,13L,34L,9L,19L,38L,6L,9L,38L,6L,199L,199L,85L,85L,19L,34L,38L,173L,6L,13L,13L,34L,9L,9L,13L,205L,309L,13L,135L,6L,9L,13L,13L,19L,19L,595L,186L,139L,103L,38L,87L,57L,28L,135L,13L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159849Inst : IEnumerable<long>
{
public static readonly long[] Value=A159849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159849.Bytes);
public long this[int i]=>Value[i];

public static A159849Inst Instance=new A159849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159850
{
public static readonly BigInteger[] Value={ 1L,17L,47L,-7429L,-160415L,4464217L,269993839L,-1892147821L,-489536076223L,-4658915114335L,987008017069999L,28053710866880683L,-2150502256703365727L,BigInteger.Parse("-118026514721378720791"),BigInteger.Parse("4759029349325350323695"),BigInteger.Parse("480777330814562061542723"),BigInteger.Parse("-9102061914203466628786559") };
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
public class A159850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159850Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159850.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159850.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159850Inst Instance=new A159850Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159851
{
public static readonly BigInteger[] Value={ 1L,19L,119L,-6935L,-218159L,2568059L,312765511L,2213723041L,-487764037855L,-13553284526621L,804837668442391L,48090864254828249L,-1228751452551908111L,BigInteger.Parse("-163002147394507489205"),BigInteger.Parse("768611269232660622311"),BigInteger.Parse("566854889488011925250449"),BigInteger.Parse("7980183992957668520769601") };
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
public class A159851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159851Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159851.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159851.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159851Inst Instance=new A159851Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159852
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,49L,4L,21L,40L,1L,24L,49L,16L,45L,16L,49L,24L,1L,40L,21L,4L,49L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,49L,4L,21L,40L,1L,24L,49L,16L,45L,16L,49L,24L,1L,40L,21L,4L,49L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,49L,4L,21L,40L,1L,24L,49L,16L,45L,16L,49L,24L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159852Inst : IEnumerable<long>
{
public static readonly long[] Value=A159852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159852.Bytes);
public long this[int i]=>Value[i];

public static A159852Inst Instance=new A159852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159853
{
public static readonly long[] Value={ 1L,-1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,3L,4L,4L,3L,1L,1L,4L,7L,8L,7L,4L,1L,1L,5L,11L,15L,15L,11L,5L,1L,1L,6L,16L,26L,30L,26L,16L,6L,1L,1L,7L,22L,42L,56L,56L,42L,22L,7L,1L,1L,8L,29L,64L,98L,112L,98L,64L,29L,8L,1L,1L,9L,37L,93L,162L,210L,210L,162L,93L,37L,9L,1L,1L,10L,46L,130L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159853Inst : IEnumerable<long>
{
public static readonly long[] Value=A159853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159853.Bytes);
public long this[int i]=>Value[i];

public static A159853Inst Instance=new A159853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159854
{
public static readonly long[] Value={ 1L,-1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,2L,1L,0L,0L,1L,3L,3L,1L,0L,0L,1L,4L,6L,4L,1L,0L,0L,1L,5L,10L,10L,5L,1L,0L,0L,1L,6L,15L,20L,15L,6L,1L,0L,0L,1L,7L,21L,35L,35L,21L,7L,1L,0L,0L,1L,8L,28L,56L,70L,56L,28L,8L,1L,0L,0L,1L,9L,36L,84L,126L,126L,84L,36L,9L,1L,0L,0L,1L,10L,45L,120L,210L,252L,210L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159854Inst : IEnumerable<long>
{
public static readonly long[] Value=A159854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159854.Bytes);
public long this[int i]=>Value[i];

public static A159854Inst Instance=new A159854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159855
{
public static readonly long[] Value={ 1L,-1L,1L,-2L,0L,1L,-2L,-2L,1L,1L,-2L,-4L,-1L,2L,1L,-2L,-6L,-5L,1L,3L,1L,-2L,-8L,-11L,-4L,4L,4L,1L,-2L,-10L,-19L,-15L,0L,8L,5L,1L,-2L,-12L,-29L,-34L,-15L,8L,13L,6L,1L,-2L,-14L,-41L,-63L,-49L,-7L,21L,19L,7L,1L,-2L,-16L,-55L,-104L,-112L,-56L,14L,34L,20L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159855Inst : IEnumerable<long>
{
public static readonly long[] Value=A159855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159855.Bytes);
public long this[int i]=>Value[i];

public static A159855Inst Instance=new A159855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159856
{
public static readonly long[] Value={ 1L,2L,-1L,3L,-4L,1L,4L,-11L,6L,-1L,5L,-26L,23L,-8L,1L,6L,-57L,72L,-39L,10L,-1L,7L,-120L,201L,-150L,59L,-12L,1L,8L,-247L,522L,-501L,268L,-83L,14L,-1L,9L,-502L,1291L,-1524L,1037L,434L,111L,-16L,1L,10L,-1013L,3084L,-4339L,3598L,-1905L,656L,-143L,18L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159856Inst : IEnumerable<long>
{
public static readonly long[] Value=A159856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159856.Bytes);
public long this[int i]=>Value[i];

public static A159856Inst Instance=new A159856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159857
{
public static readonly BigInteger[] Value={ 1L,21L,199L,-5985L,-270159L,120141L,329415351L,6743277639L,-416420774175L,-21799821766779L,449168189050791L,62188100645671791L,110264394305901969L,BigInteger.Parse("-178278691994606939715"),BigInteger.Parse("-4090744316373113328489"),BigInteger.Parse("518102577833892931856151"),BigInteger.Parse("25729556002946152951394241") };
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
public class A159857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159857Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159857.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159857.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159857Inst Instance=new A159857Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159858
{
public static readonly BigInteger[] Value={ 1L,2L,-1054L,-6340L,3332716L,33496312L,-17563075016L,-247760738608L,129576612091280L,2356200115760672L,-1229116100101646816L,BigInteger.Parse("-27386829424951203392"),BigInteger.Parse("14249679514133063237824"),BigInteger.Parse("376202545407446604740480"),BigInteger.Parse("-195237686946571258563550336"),BigInteger.Parse("-5962787476468241626543090432") };
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
public class A159858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159858Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159858.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159858.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159858Inst Instance=new A159858Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159859
{
public static readonly BigInteger[] Value={ 1L,4L,-1042L,-12632L,3256780L,66485744L,-16962423224L,-489901195808L,123664101613712L,4641180127773760L,-1158964855054670624L,BigInteger.Parse("-53739545172065063296"),BigInteger.Parse("13273074802437996468928"),BigInteger.Parse("735369564714290029481728"),BigInteger.Parse("-179616392573875043315708800"),BigInteger.Parse("-11610759562843564089946190336") };
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
public class A159859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159859Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159859.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159859.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159859Inst Instance=new A159859Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159860
{
public static readonly BigInteger[] Value={ 2L,4L,10L,40L,460L,53590L,718052410L,128899816953780640L,BigInteger.Parse("4313494300416744426870901874924164733839903365825579313972159982440"),BigInteger.Parse("4651558269931934854975620016004337876013135072223108603058097397593938231557041644242694327255059535060293888049465758695393517062060") };
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
public class A159860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159860Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159860.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159860.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159860Inst Instance=new A159860Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159861
{
public static readonly BigInteger[] Value={ 1L,1L,1L,11L,1L,1L,1111L,6L,1L,1L,11111111L,58L,4L,1L,1L,1111111111111111L,5829L,38L,3L,1L,1L,BigInteger.Parse("11111111111111111111111111111111"),58292915L,3813L,29L,3L,1L,1L,BigInteger.Parse("1111111111111111111111111111111111111111111111111111111111111111") };
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
public class A159861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159861Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159861.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159861.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159861Inst Instance=new A159861Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159862
{
public static readonly BigInteger[] Value={ 1L,1L,4L,29L,2265L,18698645L,1602308616574727L,BigInteger.Parse("14017675267522095175220940844027"),BigInteger.Parse("1245902734717669791621141496863001384336371908521990690157218737") };
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
public class A159862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159862Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159862.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159862.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159862Inst Instance=new A159862Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159863
{
public static readonly BigInteger[] Value={ 10113L,101343L,1020412245351433L,1023L,10262054413L,103L,BigInteger.Parse("1034482758620689655172413793"),2076L };
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
public class A159863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159863Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159863.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159863.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159863Inst Instance=new A159863Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159864
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,-1L,2L,1L,1L,2L,3L,1L,0L,-1L,-3L,5L,2L,1L,1L,2L,5L,8L,3L,1L,0L,-1L,-3L,-8L,13L,5L,2L,1L,1L,2L,5L,13L,21L,8L,3L,1L,0L,-1L,-3L,-8L,-21L,34L,13L,5L,2L,1L,1L,2L,5L,13L,34L,55L,21L,8L,3L,1L,0L,-1L,-3L,-8L,-21L,-55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159864Inst : IEnumerable<long>
{
public static readonly long[] Value=A159864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159864.Bytes);
public long this[int i]=>Value[i];

public static A159864Inst Instance=new A159864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159865
{
public static readonly BigInteger[] Value={ 1L,6L,-1022L,-18828L,3130860L,98465256L,-15971457864L,-720886192272L,113959299787152L,6785336530113120L,-1044408433392582624L,BigInteger.Parse("-78055311088952305344"),BigInteger.Parse("11686493481289162746048"),BigInteger.Parse("1061109190473073445123712"),BigInteger.Parse("-154369376198812703738401920"),BigInteger.Parse("-16643365586480040091602833664") };
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
public class A159865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159865Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159865.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159865.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159865Inst Instance=new A159865Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159866
{
public static readonly long[] Value={ 1L,2L,5L,17L,55L,206L,781L,3099L,12421L,50725L,208870L,868238L,3631673L,15281827L,64610493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159866Inst : IEnumerable<long>
{
public static readonly long[] Value=A159866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159866.Bytes);
public long this[int i]=>Value[i];

public static A159866Inst Instance=new A159866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159867
{
public static readonly long[] Value={ 1L,3L,12L,60L,375L,2613L,19074L,143660L,1101860L,8562292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159867Inst : IEnumerable<long>
{
public static readonly long[] Value=A159867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159867.Bytes);
public long this[int i]=>Value[i];

public static A159867Inst Instance=new A159867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159868
{
public static readonly BigInteger[] Value={ 1L,8L,-994L,-24880L,2955916L,128939488L,-14605279736L,-935350107712L,100683900863120L,8722274518579328L,-888933907869994016L,BigInteger.Parse("-99393135669529242368"),BigInteger.Parse("9550267734434756419264"),BigInteger.Parse("1338297392335821312458240"),BigInteger.Parse("-120648003280729069290891136"),BigInteger.Parse("-20788045001524017834458579968") };
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
public class A159868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159868Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159868.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159868.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159868Inst Instance=new A159868Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159869
{
public static readonly BigInteger[] Value={ 1L,10L,-958L,-30740L,2733292L,157424600L,-12884868680L,-1128180047600L,84143536968080L,10390351292567200L,-697311246084385760L,BigInteger.Parse("-116903029136204833600"),BigInteger.Parse("6946277990568033138880"),BigInteger.Parse("1553663637818936898774400"),BigInteger.Parse("-80002471104083358804411520"),BigInteger.Parse("-23812890514414926932690528000") };
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
public class A159869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159869Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159869.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159869.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159869Inst Instance=new A159869Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159870
{
public static readonly BigInteger[] Value={ 1L,12L,-914L,-36360L,2464716L,183452112L,-10836922296L,-1294597074528L,64723081629840L,11734146618363072L,-475483423858979616L,BigInteger.Parse("-129853072308589057152"),BigInteger.Parse("3975439219167736085184"),BigInteger.Parse("1696319876659859502624000"),BigInteger.Parse("-34322352500514728084132736"),BigInteger.Parse("-25537758243092015689876280832") };
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
public class A159870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159870Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159870.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159870.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159870Inst Instance=new A159870Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159871
{
public static readonly BigInteger[] Value={ 1L,14L,-862L,-41692L,2152300L,206572744L,-8493648584L,-1430234859088L,42880673385872L,12705837274723040L,-230428050134150624L,BigInteger.Parse("-137653751068447871936"),BigInteger.Parse("754569132502974755008"),BigInteger.Parse("1758215991420055828669568"),BigInteger.Parse("14236680031434866820993920"),BigInteger.Parse("-25843381744473778798759726336") };
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
public class A159871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159871Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159871.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159871.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159871Inst Instance=new A159871Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159872
{
public static readonly BigInteger[] Value={ 1L,16L,-802L,-46688L,1798540L,226360256L,-5892512504L,-1531215105152L,19140505922192L,13266452744761600L,30007346525073376L,BigInteger.Parse("-139878952495176553984"),BigInteger.Parse("-2587288738781628813632"),BigInteger.Parse("1734506561058255468362752"),BigInteger.Parse("63337674290134610196498560"),BigInteger.Parse("-24678108393752726234245105664") };
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
public class A159872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159872Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159872.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159872.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159872Inst Instance=new A159872Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159873
{
public static readonly BigInteger[] Value={ 1L,18L,-734L,-51300L,1406316L,242415288L,-3075936456L,-1594219104432L,-5915558486640L,13386990447152928L,297293775958538784L,BigInteger.Parse("-136283070963624280128"),BigInteger.Parse("-5913000241950711410496"),BigInteger.Parse("1623815864599061055116160"),BigInteger.Parse("110556090890573183732052864"),BigInteger.Parse("-22061950950410975041203610368") };
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
public class A159873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159873Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159873.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159873.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159873Inst Instance=new A159873Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159874
{
public static readonly BigInteger[] Value={ 1L,20L,-658L,-55480L,978892L,254369200L,-90954680L,-1616554775200L,-31657485143920L,13049369914414400L,562429971828694240L,BigInteger.Parse("-126813734257930467200"),BigInteger.Parse("-9081834697300952909120"),BigInteger.Parse("1428390476192666153388800"),BigInteger.Parse("153479363950530629379812480"),BigInteger.Parse("-18087732454355158476398656000") };
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
public class A159874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159874Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159874.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159874.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159874Inst Instance=new A159874Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159875
{
public static readonly BigInteger[] Value={ 1L,22L,-574L,-59180L,519916L,261887912L,3011178424L,-1596218540048L,-57417595289200L,12247206626603872L,816168888129047584L,BigInteger.Parse("-111619730570629918912"),BigInteger.Parse("-11954207592599713998656"),BigInteger.Parse("1154131532287523742536320"),BigInteger.Parse("189809064938941988673313664"),BigInteger.Parse("-12919196827586077923635071232") };
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
public class A159875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159875Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159875.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159875.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159875Inst Instance=new A159875Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159876
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,3L,1L,3L,3L,1L,2L,5L,1L,2L,2L,4L,2L,4L,2L,2L,3L,3L,1L,7L,2L,1L,4L,3L,2L,4L,1L,5L,4L,2L,2L,6L,2L,3L,2L,4L,1L,6L,2L,4L,4L,2L,1L,9L,1L,3L,4L,2L,2L,5L,3L,5L,3L,3L,2L,6L,2L,1L,5L,6L,1L,7L,2L,3L,3L,3L,2L,9L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159876Inst : IEnumerable<long>
{
public static readonly long[] Value=A159876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159876.Bytes);
public long this[int i]=>Value[i];

public static A159876Inst Instance=new A159876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159877
{
public static readonly BigInteger[] Value={ 1L,24L,-482L,-62352L,33420L,264675744L,6175426056L,-1531951397568L,-82502038912368L,10986387695118720L,1049257719206417376L,BigInteger.Parse("-91053796553402040576"),BigInteger.Parse("-14396552453405934395712"),BigInteger.Parse("810501742160249881655808"),BigInteger.Parse("217462224255991218838362240"),BigInteger.Parse("-6786058422733831994965134336") };
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
public class A159877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159877Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159877.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159877.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159877Inst Instance=new A159877Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159878
{
public static readonly long[] Value={ 3L,1L,4L,1L,2L,3L,7L,3L,2L,3L,4L,2L,4L,3L,3L,3L,2L,7L,0L,2L,4L,1L,7L,1L,3L,3L,7L,1L,0L,2L,0L,7L,4L,4L,4L,2L,3L,0L,7L,1L,4L,0L,2L,2L,0L,2L,0L,3L,4L,2L,3L,4L,2L,1L,1L,7L,0L,7L,2L,1L,4L,0L,1L,3L,2L,2L,3L,0L,4L,7L,0L,3L,4L,4L,0L,0L,2L,2L,3L,1L,7L,2L,3L,4L,0L,1L,2L,4L,1L,1L,1L,7L,4L,0L,2L,4L,1L,0L,2L,7L,0L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159878Inst : IEnumerable<long>
{
public static readonly long[] Value=A159878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159878.Bytes);
public long this[int i]=>Value[i];

public static A159878Inst Instance=new A159878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159879
{
public static readonly long[] Value={ 0L,2L,11L,20L,27L,36L,54L,72L,74L,81L,92L,101L,108L,110L,128L,135L,144L,153L,162L,171L,191L,200L,209L,218L,225L,227L,252L,254L,261L,270L,317L,326L,344L,353L,360L,371L,387L,405L,416L,425L,504L,506L,515L,540L,605L,641L,684L,711L,720L,722L,731L,740L,767L,774L,801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159879Inst : IEnumerable<long>
{
public static readonly long[] Value=A159879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159879.Bytes);
public long this[int i]=>Value[i];

public static A159879Inst Instance=new A159879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159880
{
public static readonly long[] Value={ 0L,1L,2L,0L,1L,2L,3L,0L,1L,3L,0L,1L,2L,3L,0L,2L,3L,0L,1L,2L,3L,1L,2L,3L,4L,0L,1L,4L,0L,1L,2L,4L,0L,2L,4L,0L,1L,2L,4L,1L,2L,4L,0L,1L,2L,0L,1L,2L,3L,4L,0L,3L,4L,0L,1L,3L,4L,1L,3L,4L,0L,1L,3L,0L,1L,3L,4L,0L,1L,4L,0L,1L,2L,3L,4L,2L,3L,4L,0L,2L,3L,0L,2L,3L,4L,0L,2L,4L,0L,2L,3L,4L,0L,3L,4L,0L,1L,2L,3L,1L,2L,3L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159880Inst : IEnumerable<long>
{
public static readonly long[] Value=A159880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159880.Bytes);
public long this[int i]=>Value[i];

public static A159880Inst Instance=new A159880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159881
{
public static readonly long[] Value={ 1L,2L,-1L,3L,-3L,1L,4L,-6L,5L,-1L,5L,-10L,16L,-8L,1L,6L,-15L,42L,-40L,12L,-1L,7L,-21L,99L,-162L,88L,-17L,1L,8L,-28L,219L,-585L,514L,-173L,23L,-1L,9L,-36L,466L,-1974L,2641L,-1379L,311L,-31L,1L,10L,-45L,968L,-6388L,12538L,-9536L,3245L,-521L,38L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159881Inst : IEnumerable<long>
{
public static readonly long[] Value=A159881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159881.Bytes);
public long this[int i]=>Value[i];

public static A159881Inst Instance=new A159881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159882
{
public static readonly BigInteger[] Value={ 1L,26L,-382L,-64948L,-476180L,262479256L,9343452856L,-1423288542832L,-106203113965168L,9285433263435680L,1252687316025657376L,BigInteger.Parse("-65670013710482402624"),BigInteger.Parse("-16286195340379143010112"),BigInteger.Parse("410305415218426865451392"),BigInteger.Parse("234668271507253831462816640"),BigInteger.Parse("23931248973260886967214336") };
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
public class A159882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159882Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159882.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159882.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159882Inst Instance=new A159882Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159883
{
public static readonly BigInteger[] Value={ 1L,28L,-274L,-66920L,-1004084L,255091088L,12454154824L,-1270601891552L,-127812323590000L,7175629349576128L,1417946567012111584L,BigInteger.Parse("-36215654642176309888"),BigInteger.Parse("-17516100476867891291456"),BigInteger.Parse("-30656862015230525822720"),BigInteger.Parse("240058053822414522099649664"),BigInteger.Parse("7175714947197201167276319232") };
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
public class A159883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159883Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159883.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159883.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159883Inst Instance=new A159883Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159884
{
public static readonly BigInteger[] Value={ 1L,30L,-158L,-68220L,-1545108L,242353800L,15444235320L,-1075134862800L,-146634052663920L,4700919898821600L,1537277046430494240L,-3617421136617700800L,BigInteger.Parse("-17999352900456622989120"),BigInteger.Parse("-494053808263200360316800"),BigInteger.Parse("232741485544984381782852480"),BigInteger.Parse("14300169574344055190498016000") };
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
public class A159884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159884Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159884.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159884.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159884Inst Instance=new A159884Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159885
{
public static readonly long[] Value={ 2L,1L,2L,6L,1L,1L,2L,3L,3L,1L,1L,4L,1L,1L,2L,8L,2L,3L,3L,39L,1L,1L,1L,4L,3L,1L,1L,2L,1L,1L,2L,8L,5L,2L,2L,41L,3L,2L,3L,5L,5L,1L,1L,1L,1L,1L,1L,42L,2L,1L,4L,6L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,2L,44L,5L,5L,5L,31L,5L,2L,2L,41L,7L,1L,3L,3L,3L,2L,3L,34L,3L,5L,13L,12L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,42L,8L,1L,2L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159885Inst : IEnumerable<long>
{
public static readonly long[] Value=A159885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159885.Bytes);
public long this[int i]=>Value[i];

public static A159885Inst Instance=new A159885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159886
{
public static readonly long[] Value={ 12L,18L,24L,31L,32L,42L,48L,54L,56L,60L,72L,80L,84L,90L,96L,98L,104L,108L,114L,120L,124L,126L,128L,132L,140L,144L,152L,156L,168L,180L,182L,186L,192L,210L,216L,224L,228L,234L,240L,248L,252L,264L,270L,272L,280L,288L,294L,308L,312L,320L,324L,336L,342L,360L,372L,378L,384L,390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159886Inst : IEnumerable<long>
{
public static readonly long[] Value=A159886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159886.Bytes);
public long this[int i]=>Value[i];

public static A159886Inst Instance=new A159886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159887
{
public static readonly long[] Value={ 29L,39L,41L,43L,45L,55L,57L,59L,93L,103L,105L,107L,109L,119L,121L,251L,285L,295L,297L,299L,301L,311L,313L,315L,349L,359L,361L,363L,365L,375L,377L,507L,541L,551L,553L,555L,557L,567L,569L,571L,605L,615L,619L,621L,631L,633L,763L,797L,807L,809L,811L,813L,823L,825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159887Inst : IEnumerable<long>
{
public static readonly long[] Value=A159887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159887.Bytes);
public long this[int i]=>Value[i];

public static A159887Inst Instance=new A159887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159888
{
public static readonly long[] Value={ 29L,39L,41L,43L,45L,55L,57L,59L,93L,103L,105L,107L,109L,119L,121L,251L,285L,295L,297L,299L,301L,311L,313L,315L,349L,359L,361L,363L,365L,375L,377L,507L,541L,551L,553L,555L,557L,567L,569L,571L,605L,615L,617L,619L,621L,631L,633L,763L,797L,807L,809L,811L,813L,823L,825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159888Inst : IEnumerable<long>
{
public static readonly long[] Value=A159888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159888.Bytes);
public long this[int i]=>Value[i];

public static A159888Inst Instance=new A159888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159889
{
public static readonly BigInteger[] Value={ 1L,32L,-34L,-68800L,-2093684L,224163712L,18248827144L,-839028775168L,-161999734633840L,1917548044739072L,1603923010615074784L,BigInteger.Parse("31037878026343011328"),BigInteger.Parse("-17673243900695263973696"),BigInteger.Parse("-959600704244699318978560"),BigInteger.Parse("212370574074332282486900864"),BigInteger.Parse("21009464001651119352291258368") };
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
public class A159889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159889Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159889.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159889.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159889Inst Instance=new A159889Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159890
{
public static readonly long[] Value={ 401L,439L,485L,1921L,2195L,2509L,11125L,12731L,14569L,64829L,74191L,84905L,377849L,432415L,494861L,2202265L,2520299L,2884261L,12835741L,14689379L,16810705L,74812181L,85615975L,97979969L,436037345L,499006471L,571069109L,2541411889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159890Inst : IEnumerable<long>
{
public static readonly long[] Value=A159890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159890.Bytes);
public long this[int i]=>Value[i];

public static A159890Inst Instance=new A159890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159891
{
public static readonly long[] Value={ 1L,1L,4L,4L,4L,1L,2L,2L,3L,1L,4L,7L,9L,8L,8L,6L,0L,8L,6L,6L,7L,3L,5L,1L,0L,0L,8L,2L,9L,5L,4L,0L,0L,3L,0L,0L,5L,2L,3L,9L,0L,1L,1L,8L,8L,7L,8L,4L,9L,2L,7L,5L,2L,1L,4L,2L,9L,0L,2L,5L,1L,8L,2L,0L,0L,3L,5L,5L,5L,9L,8L,2L,7L,0L,9L,6L,6L,0L,2L,4L,9L,5L,7L,4L,4L,2L,2L,8L,4L,2L,0L,1L,4L,0L,6L,8L,5L,5L,2L,6L,3L,2L,0L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159891Inst : IEnumerable<long>
{
public static readonly long[] Value=A159891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159891.Bytes);
public long this[int i]=>Value[i];

public static A159891Inst Instance=new A159891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159892
{
public static readonly long[] Value={ 4L,4L,5L,0L,2L,7L,0L,2L,8L,9L,4L,4L,0L,8L,8L,4L,9L,0L,7L,5L,1L,3L,3L,7L,2L,2L,5L,3L,6L,5L,6L,8L,8L,1L,4L,5L,7L,5L,7L,6L,6L,1L,4L,8L,3L,1L,8L,8L,0L,1L,7L,9L,8L,2L,1L,2L,5L,9L,1L,4L,2L,8L,8L,9L,4L,7L,6L,5L,7L,8L,6L,4L,8L,5L,8L,4L,4L,9L,7L,4L,5L,7L,0L,0L,6L,3L,7L,6L,4L,6L,1L,8L,7L,2L,5L,8L,2L,1L,5L,9L,3L,8L,4L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159892Inst : IEnumerable<long>
{
public static readonly long[] Value=A159892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159892.Bytes);
public long this[int i]=>Value[i];

public static A159892Inst Instance=new A159892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159893
{
public static readonly long[] Value={ 677L,727L,785L,3277L,3635L,4033L,18985L,21083L,23413L,110633L,122863L,136445L,644813L,716095L,795257L,3758245L,4173707L,4635097L,21904657L,24326147L,27015325L,127669697L,141783175L,157456853L,744113525L,826372903L,917725793L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159893Inst : IEnumerable<long>
{
public static readonly long[] Value=A159893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159893.Bytes);
public long this[int i]=>Value[i];

public static A159893Inst Instance=new A159893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159894
{
public static readonly long[] Value={ 1L,1L,1L,0L,5L,4L,6L,8L,1L,2L,0L,6L,0L,7L,2L,5L,0L,7L,9L,2L,7L,8L,2L,5L,4L,7L,3L,3L,2L,9L,7L,5L,5L,6L,6L,6L,6L,0L,8L,3L,5L,7L,9L,4L,7L,9L,0L,5L,1L,3L,8L,2L,6L,6L,2L,9L,3L,1L,9L,6L,7L,9L,5L,8L,5L,3L,0L,2L,6L,0L,7L,3L,4L,3L,0L,1L,1L,7L,4L,3L,8L,8L,0L,3L,0L,1L,5L,2L,5L,8L,1L,6L,4L,1L,9L,4L,3L,1L,1L,5L,4L,4L,3L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159894Inst : IEnumerable<long>
{
public static readonly long[] Value=A159894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159894.Bytes);
public long this[int i]=>Value[i];

public static A159894Inst Instance=new A159894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159895
{
public static readonly long[] Value={ 4L,7L,2L,5L,8L,2L,4L,9L,5L,3L,4L,6L,7L,6L,9L,1L,1L,6L,4L,8L,2L,9L,6L,9L,5L,4L,5L,6L,2L,5L,1L,7L,8L,0L,1L,9L,8L,6L,1L,3L,1L,6L,6L,2L,6L,5L,4L,2L,5L,7L,7L,8L,9L,6L,6L,7L,9L,9L,5L,5L,6L,4L,6L,6L,2L,3L,7L,7L,6L,2L,6L,5L,1L,3L,3L,3L,9L,5L,2L,7L,1L,7L,3L,8L,3L,4L,0L,4L,8L,8L,6L,9L,2L,5L,4L,2L,4L,0L,1L,1L,8L,2L,9L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159895Inst : IEnumerable<long>
{
public static readonly long[] Value=A159895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159895.Bytes);
public long this[int i]=>Value[i];

public static A159895Inst Instance=new A159895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159896
{
public static readonly long[] Value={ 785L,839L,901L,3809L,4195L,4621L,22069L,24331L,26825L,128605L,141791L,156329L,749561L,826415L,911149L,4368761L,4816699L,5310565L,25463005L,28073779L,30952241L,148409269L,163625975L,180402881L,864992609L,953682071L,1051465045L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159896Inst : IEnumerable<long>
{
public static readonly long[] Value=A159896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159896.Bytes);
public long this[int i]=>Value[i];

public static A159896Inst Instance=new A159896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159897
{
public static readonly long[] Value={ 1L,1L,0L,2L,5L,3L,2L,0L,4L,6L,0L,2L,8L,1L,7L,5L,8L,1L,9L,8L,2L,1L,8L,0L,9L,2L,3L,2L,4L,2L,4L,5L,0L,8L,3L,2L,9L,6L,2L,6L,9L,8L,5L,6L,6L,0L,0L,3L,7L,9L,7L,7L,3L,3L,9L,9L,8L,1L,2L,2L,4L,5L,8L,2L,6L,0L,2L,4L,5L,8L,2L,6L,4L,3L,0L,3L,6L,9L,7L,5L,0L,6L,8L,5L,7L,3L,5L,6L,9L,4L,5L,1L,6L,2L,1L,0L,1L,5L,6L,2L,8L,3L,5L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159897Inst : IEnumerable<long>
{
public static readonly long[] Value=A159897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159897.Bytes);
public long this[int i]=>Value[i];

public static A159897Inst Instance=new A159897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159898
{
public static readonly long[] Value={ 4L,7L,9L,4L,7L,8L,2L,6L,7L,8L,6L,7L,7L,0L,4L,8L,9L,2L,7L,0L,1L,2L,7L,7L,4L,8L,6L,0L,9L,9L,3L,9L,2L,8L,7L,0L,7L,7L,6L,4L,9L,8L,7L,5L,2L,2L,5L,1L,5L,3L,0L,3L,2L,2L,4L,7L,1L,2L,9L,0L,1L,7L,1L,2L,1L,8L,8L,2L,1L,7L,3L,4L,7L,6L,7L,3L,7L,6L,5L,0L,2L,9L,1L,3L,4L,5L,8L,1L,6L,1L,8L,9L,6L,8L,9L,2L,8L,0L,6L,8L,2L,1L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159898Inst : IEnumerable<long>
{
public static readonly long[] Value=A159898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159898.Bytes);
public long this[int i]=>Value[i];

public static A159898Inst Instance=new A159898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159899
{
public static readonly long[] Value={ 1L,4L,2L,9L,1L,3L,8L,25L,4L,36L,18L,1L,2L,64L,6L,81L,16L,4L,50L,121L,1L,20L,72L,9L,36L,196L,2L,225L,4L,11L,128L,1L,12L,324L,162L,13L,5L,400L,8L,441L,100L,3L,242L,529L,1L,63L,40L,17L,144L,676L,18L,9L,7L,19L,392L,841L,4L,900L,450L,12L,8L,16L,22L,1089L,256L,23L,2L,1225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159899Inst : IEnumerable<long>
{
public static readonly long[] Value=A159899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159899.Bytes);
public long this[int i]=>Value[i];

public static A159899Inst Instance=new A159899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159900
{
public static readonly BigInteger[] Value={ 1L,12L,123L,1235L,12357L,1235711L,123571113L,12357111317L,1235711131719L,123571113171923L,12357111317192329L,1235711131719232931L,BigInteger.Parse("123571113171923293137"),BigInteger.Parse("12357111317192329313741") };
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
public class A159900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159900Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159900.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159900.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159900Inst Instance=new A159900Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159901
{
public static readonly BigInteger[] Value={ 1L,12L,123L,1235L,12356L,123567L,12356710L,1235671011L,123567101113L,12356710111314L,1235671011131415L,123567101113141517L,12356710111314151719UL,BigInteger.Parse("1235671011131415171921"),BigInteger.Parse("123567101113141517192122") };
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
public class A159901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159901Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159901.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159901.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159901Inst Instance=new A159901Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159902
{
public static readonly BigInteger[] Value={ 2L,23L,235L,2356L,23567L,2356710L,235671011L,23567101113L,2356710111314L,235671011131415L,23567101113141517L,2356710111314151719L,BigInteger.Parse("235671011131415171921"),BigInteger.Parse("23567101113141517192122") };
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
public class A159902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159902Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159902.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159902.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159902Inst Instance=new A159902Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159903
{
public static readonly BigInteger[] Value={ 4L,48L,489L,48912L,4891216L,489121618L,48912161820L,4891216182024L,489121618202425L,48912161820242527L,4891216182024252728L,BigInteger.Parse("489121618202425272832"),BigInteger.Parse("48912161820242527283236") };
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
public class A159903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159903Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159903.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159903.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159903Inst Instance=new A159903Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159904
{
public static readonly BigInteger[] Value={ 1L,34L,98L,-68612L,-2643860L,200474744L,20802160696L,-565340211248L,-173282369297008L,-1106561008095200L,1612371646170873376L,BigInteger.Parse("66528051435456910784"),BigInteger.Parse("-16502827469331089383232"),BigInteger.Parse("-1405736274981817978343552"),BigInteger.Parse("179184855663797992113292160"),BigInteger.Parse("26914050797599819627076625664") };
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
public class A159904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159904Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159904.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A159904.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159904Inst Instance=new A159904Inst();

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