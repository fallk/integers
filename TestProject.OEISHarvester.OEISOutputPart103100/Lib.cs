using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A122741
{
public static readonly long[] Value={ 0L,0L,0L,0L,3L,24L,189L,1252L,7736L,45079L,252804L,1375917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122741Inst : IEnumerable<long>
{
public static readonly long[] Value=A122741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122741.Bytes);
public long this[int i]=>Value[i];

public static A122741Inst Instance=new A122741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122742
{
public static readonly long[] Value={ 0L,0L,1L,3L,6L,16L,34L,80L,172L,384L,824L,1792L,3824L,8192L,17376L,36864L,77760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122742Inst : IEnumerable<long>
{
public static readonly long[] Value=A122742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122742.Bytes);
public long this[int i]=>Value[i];

public static A122742Inst Instance=new A122742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122743
{
public static readonly BigInteger[] Value={ 1L,6L,56L,960L,31744L,2064384L,266338304L,68451041280L,35115652612096L,35993612646875136L,BigInteger.Parse("73750947497819242496"),BigInteger.Parse("302157667927362455470080"),BigInteger.Parse("2475577847115856892504571904"),BigInteger.Parse("40562343327224770087344704323584"),BigInteger.Parse("1329187430965708569562959165777772544") };
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
public class A122743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122743Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122743.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A122743.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122743Inst Instance=new A122743Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122744
{
public static readonly long[] Value={ 0L,0L,1L,4L,10L,27L,67L,166L,396L,934L,2168L,4984L,11332L,25584L,57312L,127624L,282560L,622528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122744Inst : IEnumerable<long>
{
public static readonly long[] Value=A122744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122744.Bytes);
public long this[int i]=>Value[i];

public static A122744Inst Instance=new A122744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122745
{
public static readonly long[] Value={ 1L,1L,2L,5L,12L,29L,72L,170L,404L,944L,2184L,5000L,11368L,25616L,57376L,127696L,282688L,622656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122745Inst : IEnumerable<long>
{
public static readonly long[] Value=A122745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122745.Bytes);
public long this[int i]=>Value[i];

public static A122745Inst Instance=new A122745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122746
{
public static readonly long[] Value={ 1L,2L,6L,12L,28L,56L,120L,240L,496L,992L,2016L,4032L,8128L,16256L,32640L,65280L,130816L,261632L,523776L,1047552L,2096128L,4192256L,8386560L,16773120L,33550336L,67100672L,134209536L,268419072L,536854528L,1073709056L,2147450880L,4294901760L,8589869056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122746Inst : IEnumerable<long>
{
public static readonly long[] Value=A122746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122746.Bytes);
public long this[int i]=>Value[i];

public static A122746Inst Instance=new A122746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122747
{
public static readonly BigInteger[] Value={ 1L,4L,144L,14400L,2822400L,914457600L,442597478400L,299195895398400L,269276305858560000L,BigInteger.Parse("311283409572495360000"),BigInteger.Parse("449493243422683299840000"),BigInteger.Parse("792906081397613340917760000"),BigInteger.Parse("1677789268237349829381980160000"),BigInteger.Parse("4194473170593374573454950400000000"),BigInteger.Parse("12231083765450280256194635366400000000") };
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
public class A122747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122747Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122747.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A122747.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122747Inst Instance=new A122747Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122748
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,8L,16L,40L,72L,260L,432L,1976L,2880L,17632L,23040L,177248L,201600L,2001680L,2016000L,24879520L,21772800L,338969216L,261273600L,5002865792L,3353011200L,79676972608L,46942156800L,1358997441920L,697426329600L,24740358817280L,11158821273600L,478218277674496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122748Inst : IEnumerable<long>
{
public static readonly long[] Value=A122748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122748.Bytes);
public long this[int i]=>Value[i];

public static A122748Inst Instance=new A122748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122749
{
public static readonly ulong[] Value={ 4L,2L,16L,44L,256L,768L,5184L,25344L,186624L,996480L,8294400L,57888000L,530841600L,4006195200L,40642560000L,367408742400L,4064256000000L,39358255104000L,474054819840000L,5254107586560000L,68263894056960000L,804207665479680000L,11242684107325440000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122749Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A122749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122749.Bytes);
public ulong this[int i]=>Value[i];

public static A122749Inst Instance=new A122749Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122750
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-2L,1L,-1L,1L,-1L,1L,1L,-2L,1L,-2L,1L,-1L,1L,-1L,1L,-1L,1L,1L,-2L,1L,-2L,1L,-2L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,-2L,1L,-2L,1L,-2L,1L,-2L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,-2L,1L,-2L,1L,-2L,1L,-2L,1L,-2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122750Inst : IEnumerable<long>
{
public static readonly long[] Value=A122750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122750.Bytes);
public long this[int i]=>Value[i];

public static A122750Inst Instance=new A122750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122751
{
public static readonly long[] Value={ 1L,2L,7L,14L,29L,49L,83L,127L,192L,273L,384L,519L,694L,902L,1162L,1466L,1835L,2260L,2765L,3340L,4011L,4767L,5637L,6609L,7714L,8939L,10318L,11837L,13532L,15388L,17444L,19684L,22149L,24822L,27747L,30906L,34345L,38045L,42055L,46355L,50996L,55957L,61292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122751Inst : IEnumerable<long>
{
public static readonly long[] Value=A122751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122751.Bytes);
public long this[int i]=>Value[i];

public static A122751Inst Instance=new A122751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122752
{
public static readonly long[] Value={ 1L,1L,1L,3L,12L,59L,352L,2455L,19592L,176033L,1758218L,19323213L,231721820L,3010799363L,42133608902L,631791578187L,10105884589152L,171760897623865L,3091106286704942L,58721542573721093L,1174269157320995428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122752Inst : IEnumerable<long>
{
public static readonly long[] Value=A122752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122752.Bytes);
public long this[int i]=>Value[i];

public static A122752Inst Instance=new A122752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122753
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,1L,-1L,0L,1L,4L,-5L,1L,0L,1L,11L,-14L,1L,2L,0L,1L,26L,-24L,-29L,36L,-9L,0L,1L,57L,1L,-244L,281L,-104L,9L,0L,1L,120L,225L,-1259L,1401L,-454L,-83L,50L,0L,1L,247L,1268L,-5081L,4621L,911L,-3422L,1723L,-267L,0L,1L,502L,5278L,-16981L,5335L,30871L,-44260L,24739L,-5897L,413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122753Inst : IEnumerable<long>
{
public static readonly long[] Value=A122753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122753.Bytes);
public long this[int i]=>Value[i];

public static A122753Inst Instance=new A122753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122754
{
public static readonly long[] Value={ 8L,15L,20L,23L,32L,39L,42L,43L,50L,51L,60L,63L,72L,79L,82L,89L,90L,99L,102L,111L,118L,119L,126L,127L,130L,139L,146L,149L,150L,157L,160L,169L,172L,173L,174L,183L,186L,193L,196L,203L,204L,213L,222L,229L,232L,233L,242L,249L,252L,253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122754Inst : IEnumerable<long>
{
public static readonly long[] Value=A122754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122754.Bytes);
public long this[int i]=>Value[i];

public static A122754Inst Instance=new A122754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122755
{
public static readonly long[] Value={ 35L,41L,81L,93L,95L,97L,109L,114L,149L,151L,158L,159L,160L,161L,162L,163L,165L,169L,171L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122755Inst : IEnumerable<long>
{
public static readonly long[] Value=A122755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122755.Bytes);
public long this[int i]=>Value[i];

public static A122755Inst Instance=new A122755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122756
{
public static readonly long[] Value={ 1L,2L,6L,8L,24L,32L,96L,128L,384L,512L,1536L,2048L,6144L,8192L,24576L,32768L,98304L,131072L,393216L,524288L,1572864L,2097152L,6291456L,8388608L,25165824L,33554432L,100663296L,134217728L,402653184L,536870912L,1610612736L,2147483648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122756Inst : IEnumerable<long>
{
public static readonly long[] Value=A122756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122756.Bytes);
public long this[int i]=>Value[i];

public static A122756Inst Instance=new A122756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122757
{
public static readonly long[] Value={ 0L,1L,3L,4L,12L,16L,9L,27L,36L,108L,16L,48L,64L,192L,256L,25L,75L,100L,300L,400L,1200L,36L,108L,144L,432L,576L,1728L,2304L,49L,147L,196L,588L,784L,2352L,3136L,9408L,64L,192L,256L,768L,1024L,3072L,4096L,12288L,16384L,81L,243L,324L,972L,1296L,3888L,5184L,15552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122757Inst : IEnumerable<long>
{
public static readonly long[] Value=A122757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122757.Bytes);
public long this[int i]=>Value[i];

public static A122757Inst Instance=new A122757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122758
{
public static readonly long[] Value={ 0L,2L,6L,8L,24L,32L,18L,54L,72L,216L,32L,96L,128L,384L,512L,50L,150L,200L,600L,800L,2400L,72L,216L,288L,864L,1152L,3456L,4608L,98L,294L,392L,1176L,1568L,4704L,6272L,18816L,128L,384L,512L,1536L,2048L,6144L,8192L,24576L,32768L,162L,486L,648L,1944L,2592L,7776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122758Inst : IEnumerable<long>
{
public static readonly long[] Value=A122758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122758.Bytes);
public long this[int i]=>Value[i];

public static A122758Inst Instance=new A122758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122759
{
public static readonly long[] Value={ 1L,0L,0L,1L,3L,9L,0L,0L,0L,0L,1L,3L,9L,27L,81L,0L,0L,0L,0L,0L,0L,1L,3L,9L,27L,81L,243L,729L,0L,0L,0L,0L,0L,0L,0L,0L,1L,3L,9L,27L,81L,243L,729L,2187L,6561L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,3L,9L,27L,81L,243L,729L,2187L,6561L,19683L,59049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122759Inst : IEnumerable<long>
{
public static readonly long[] Value=A122759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122759.Bytes);
public long this[int i]=>Value[i];

public static A122759Inst Instance=new A122759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122760
{
public static readonly long[] Value={ 0L,2L,6L,0L,0L,0L,2L,6L,18L,54L,0L,0L,0L,0L,0L,2L,6L,18L,54L,162L,486L,0L,0L,0L,0L,0L,0L,0L,2L,6L,18L,54L,162L,486L,1458L,4374L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,6L,18L,54L,162L,486L,1458L,4374L,13122L,39366L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122760Inst : IEnumerable<long>
{
public static readonly long[] Value=A122760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122760.Bytes);
public long this[int i]=>Value[i];

public static A122760Inst Instance=new A122760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122761
{
public static readonly long[] Value={ 1L,2L,6L,1L,3L,9L,2L,6L,18L,54L,1L,3L,9L,27L,81L,2L,6L,18L,54L,162L,486L,1L,3L,9L,27L,81L,243L,729L,2L,6L,18L,54L,162L,486L,1458L,4374L,1L,3L,9L,27L,81L,243L,729L,2187L,6561L,2L,6L,18L,54L,162L,486L,1458L,4374L,13122L,39366L,1L,3L,9L,27L,81L,243L,729L,2187L,6561L,19683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122761Inst : IEnumerable<long>
{
public static readonly long[] Value=A122761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122761.Bytes);
public long this[int i]=>Value[i];

public static A122761Inst Instance=new A122761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122762
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,6L,6L,11L,11L,21L,26L,41L,56L,86L,121L,181L,256L,381L,541L,801L,1146L,1686L,2426L,3551L,5131L,7486L,10841L,15791L,22896L,33321L,48346L,70321L,102076L,148416L,215506L,313256L,454961L,661206L,960446L,1395686L,2027501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122762Inst : IEnumerable<long>
{
public static readonly long[] Value=A122762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122762.Bytes);
public long this[int i]=>Value[i];

public static A122762Inst Instance=new A122762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122763
{
public static readonly long[] Value={ 0L,1L,2L,6L,30L,150L,210L,13860L,60060L,420420L,4144140L,9699690L,87297210L,717777060L,4180566390L,18846497670L,26004868890L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122763Inst : IEnumerable<long>
{
public static readonly long[] Value=A122763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122763.Bytes);
public long this[int i]=>Value[i];

public static A122763Inst Instance=new A122763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122764
{
public static readonly long[] Value={ 2L,3L,5L,7L,199L,110437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122764Inst : IEnumerable<long>
{
public static readonly long[] Value=A122764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122764.Bytes);
public long this[int i]=>Value[i];

public static A122764Inst Instance=new A122764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122765
{
public static readonly long[] Value={ 1L,-1L,2L,-2L,-2L,3L,2L,-6L,-3L,4L,3L,6L,-12L,-4L,5L,-3L,12L,12L,-20L,-5L,6L,-4L,-12L,30L,20L,-30L,-6L,7L,4L,-20L,-30L,60L,30L,-42L,-7L,8L,5L,20L,-60L,-60L,105L,42L,-56L,-8L,9L,-5L,30L,60L,-140L,-105L,168L,56L,-72L,-9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122765Inst : IEnumerable<long>
{
public static readonly long[] Value=A122765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122765.Bytes);
public long this[int i]=>Value[i];

public static A122765Inst Instance=new A122765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122766
{
public static readonly long[] Value={ 2L,-2L,6L,-6L,-6L,12L,6L,-24L,-12L,20L,12L,24L,-60L,-20L,30L,-12L,60L,60L,-120L,-30L,42L,-20L,-60L,180L,120L,-210L,-42L,56L,20L,-120L,-180L,420L,210L,-336L,-56L,72L,30L,120L,-420L,-420L,840L,336L,-504L,-72L,90L,-30L,210L,420L,-1120L,-840L,1512L,504L,-720L,-90L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122766Inst : IEnumerable<long>
{
public static readonly long[] Value=A122766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122766.Bytes);
public long this[int i]=>Value[i];

public static A122766Inst Instance=new A122766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122767
{
public static readonly long[] Value={ 0L,2L,12L,312L,2712L,50112L,532512L,8394912L,99237312L,1443059712L,18048362112L,251686144512L,3243002406912L,44245843149312L,579129504371712L,7811377482074112L,103090052472256512L,1382166761370918912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122767Inst : IEnumerable<long>
{
public static readonly long[] Value=A122767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122767.Bytes);
public long this[int i]=>Value[i];

public static A122767Inst Instance=new A122767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122768
{
public static readonly long[] Value={ 0L,1L,3L,7L,15L,29L,54L,95L,163L,270L,439L,696L,1088L,1669L,2530L,3780L,5591L,8173L,11845L,17000L,24215L,34210L,48008L,66895L,92660L,127554L,174651L,237830L,322297L,434625L,583524L,779972L,1038356L,1376787L,1818755L,2393775L,3139812L,4104433L,5348375L,6947545L,8998201L,11620313L,14965126L,19220569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122768Inst : IEnumerable<long>
{
public static readonly long[] Value=A122768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122768.Bytes);
public long this[int i]=>Value[i];

public static A122768Inst Instance=new A122768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122769
{
public static readonly long[] Value={ 1L,11L,153L,2131L,29681L,413403L,5757961L,80198051L,1117014753L,15558008491L,216695104121L,3018173449203L,42037733184721L,585510091136891L,8155103542731753L,113585939507107651L,1582048049556775361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122769Inst : IEnumerable<long>
{
public static readonly long[] Value=A122769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122769.Bytes);
public long this[int i]=>Value[i];

public static A122769Inst Instance=new A122769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122770
{
public static readonly BigInteger[] Value={ 0L,6L,88L,1230L,17136L,238678L,3324360L,46302366L,644908768L,8982420390L,125108976696L,1742543253358L,24270496570320L,338044408731126L,4708351225665448L,65578872750585150L,913395867282526656L,12721963269204788038UL,BigInteger.Parse("177194089901584505880") };
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
public class A122770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122770Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122770.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A122770.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122770Inst Instance=new A122770Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122771
{
public static readonly long[] Value={ 1L,2L,-1L,-1L,-1L,1L,2L,-2L,2L,-1L,-1L,-2L,4L,-3L,1L,2L,-3L,6L,-7L,4L,-1L,-1L,-3L,9L,-13L,11L,-5L,1L,2L,-4L,12L,-22L,24L,-16L,6L,-1L,-1L,-4L,16L,-34L,46L,-40L,22L,-7L,1L,2L,-5L,20L,-50L,80L,-86L,62L,-29L,8L,-1L,-1L,-5L,25L,-70L,130L,-166L,148L,-91L,37L,-9L,1L,2L,-6L,30L,-95L,200L,-296L,314L,-239L,128L,-46L,10L,-1L,-1L,-6L,36L,-125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122771Inst : IEnumerable<long>
{
public static readonly long[] Value=A122771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122771.Bytes);
public long this[int i]=>Value[i];

public static A122771Inst Instance=new A122771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122772
{
public static readonly long[] Value={ 3L,5L,6L,10L,12L,15L,17L,20L,24L,30L,34L,40L,48L,51L,60L,68L,80L,85L,96L,102L,120L,136L,160L,170L,192L,204L,240L,255L,257L,272L,320L,340L,384L,408L,480L,510L,514L,544L,640L,680L,768L,771L,816L,960L,1020L,1028L,1088L,1280L,1285L,1360L,1536L,1542L,1632L,1920L,2040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122772Inst : IEnumerable<long>
{
public static readonly long[] Value=A122772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122772.Bytes);
public long this[int i]=>Value[i];

public static A122772Inst Instance=new A122772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122773
{
public static readonly long[] Value={ 2L,1L,-1L,-4L,2L,1L,4L,-4L,2L,-1L,-16L,24L,-16L,4L,1L,16L,-32L,28L,-12L,3L,-1L,-64L,160L,-176L,104L,-36L,6L,1L,64L,-192L,256L,-192L,88L,-24L,4L,-1L,-256L,896L,-1408L,1280L,-736L,272L,-64L,8L,1L,256L,-1024L,1856L,-1984L,1376L,-640L,200L,-40L,5L,-1L,-1024L,4608L,-9472L,11648L,-9472L,5312L,-2080L,560L,-100L,10L,1L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122773Inst : IEnumerable<long>
{
public static readonly long[] Value=A122773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122773.Bytes);
public long this[int i]=>Value[i];

public static A122773Inst Instance=new A122773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122774
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,8L,15L,18L,24L,48L,105L,120L,144L,192L,384L,945L,1050L,1200L,1440L,1920L,3840L,10395L,11340L,12600L,14400L,17280L,23040L,46080L,135135L,145530L,158760L,176400L,201600L,241920L,322560L,645120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122774Inst : IEnumerable<long>
{
public static readonly long[] Value=A122774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122774.Bytes);
public long this[int i]=>Value[i];

public static A122774Inst Instance=new A122774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122775
{
public static readonly long[] Value={ 3L,3L,2L,3L,9L,5L,6L,5L,7L,8L,6L,0L,5L,6L,6L,1L,5L,6L,0L,0L,6L,4L,2L,1L,0L,0L,1L,8L,8L,3L,2L,4L,7L,2L,2L,7L,4L,2L,2L,7L,5L,8L,3L,1L,6L,6L,7L,5L,7L,7L,3L,4L,3L,6L,8L,0L,6L,2L,1L,7L,6L,5L,3L,7L,8L,8L,7L,3L,6L,6L,6L,7L,2L,1L,3L,0L,7L,3L,0L,1L,7L,8L,6L,3L,5L,3L,9L,5L,7L,2L,5L,5L,7L,2L,3L,3L,8L,2L,3L,7L,3L,6L,5L,3L,6L,1L,9L,3L,8L,8L,8L,2L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122775Inst : IEnumerable<long>
{
public static readonly long[] Value=A122775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122775.Bytes);
public long this[int i]=>Value[i];

public static A122775Inst Instance=new A122775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122776
{
public static readonly long[] Value={ 1L,1L,-1L,-3L,1L,-1L,0L,1L,1L,1L,-4L,3L,-2L,0L,-1L,5L,2L,1L,4L,-3L,0L,-4L,0L,-1L,1L,-2L,-1L,0L,-2L,-1L,0L,-7L,4L,2L,0L,-3L,-10L,4L,2L,1L,10L,0L,4L,12L,1L,0L,8L,-5L,-7L,1L,-2L,6L,-10L,-1L,-4L,0L,-4L,-2L,-4L,3L,-2L,0L,0L,-3L,-2L,4L,12L,-6L,0L,0L,-8L,1L,10L,-10L,-1L,-12L,0L,2L,0L,5L,1L,10L,12L,0L,2L,4L,2L,-4L,-6L,1L,0L,0L,0L,8L,4L,7L,2L,-7L,-4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122776Inst : IEnumerable<long>
{
public static readonly long[] Value=A122776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122776.Bytes);
public long this[int i]=>Value[i];

public static A122776Inst Instance=new A122776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122777
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-1L,-1L,-4L,-1L,1L,1L,0L,1L,2L,4L,-1L,1L,6L,-1L,-4L,-1L,-4L,0L,0L,-1L,1L,-2L,1L,-4L,-6L,1L,8L,-1L,0L,-6L,4L,1L,2L,4L,2L,1L,-6L,4L,-4L,0L,-1L,0L,0L,1L,9L,-1L,6L,2L,-6L,-1L,0L,4L,-4L,6L,0L,-1L,-10L,-8L,-4L,1L,-2L,0L,-4L,6L,0L,-4L,0L,-1L,2L,-2L,1L,-4L,0L,-2L,8L,-1L,1L,6L,12L,-4L,-6L,4L,-6L,0L,18L,1L,-8L,0L,8L,0L,4L,-1L,2L,-9L,0L,1L,18L,-6L,-4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122777Inst : IEnumerable<long>
{
public static readonly long[] Value=A122777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122777.Bytes);
public long this[int i]=>Value[i];

public static A122777Inst Instance=new A122777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122778
{
public static readonly BigInteger[] Value={ 1L,1L,3L,22L,285L,5656L,158095L,5881968L,279768825L,16507789696L,1180490926131L,100415158796800L,10005244013129365L,1152844128057793536L,BigInteger.Parse("151949197139815794615"),BigInteger.Parse("22696027820066041133056"),BigInteger.Parse("3810644613584486281328625") };
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
public class A122778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122778Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122778.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A122778.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122778Inst Instance=new A122778Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122779
{
public static readonly long[] Value={ 1L,1L,1L,-1L,-1L,1L,0L,1L,-3L,-1L,0L,-1L,2L,-4L,-1L,-1L,-2L,1L,-4L,1L,0L,0L,4L,1L,1L,2L,5L,4L,2L,-1L,0L,1L,0L,6L,0L,-1L,2L,-4L,2L,-1L,2L,-4L,-8L,0L,3L,0L,-4L,-1L,1L,1L,-2L,-2L,-6L,1L,0L,-4L,-4L,-6L,8L,1L,-2L,8L,-8L,-1L,-2L,0L,0L,-6L,4L,4L,-8L,1L,2L,2L,1L,4L,0L,2L,8L,1L,1L,-6L,8L,4L,2L,-4L,2L,0L,2L,-1L,0L,0L,0L,0L,4L,1L,2L,9L,0L,-1L,10L,6L,8L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122779Inst : IEnumerable<long>
{
public static readonly long[] Value=A122779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122779.Bytes);
public long this[int i]=>Value[i];

public static A122779Inst Instance=new A122779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122780
{
public static readonly long[] Value={ 1L,6L,66L,91L,121L,286L,561L,671L,703L,726L,949L,1105L,1541L,1729L,1891L,2465L,2665L,2701L,2821L,3281L,3367L,3751L,4961L,5551L,6601L,7107L,7381L,8205L,8401L,8646L,8911L,10585L,11011L,12403L,14383L,15203L,15457L,15841L,16471L,16531L,18721L,19345L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122780Inst : IEnumerable<long>
{
public static readonly long[] Value=A122780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122780.Bytes);
public long this[int i]=>Value[i];

public static A122780Inst Instance=new A122780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122781
{
public static readonly long[] Value={ 1L,4L,6L,12L,15L,28L,66L,85L,91L,186L,276L,341L,435L,451L,532L,561L,645L,703L,946L,1068L,1105L,1247L,1271L,1387L,1581L,1695L,1729L,1891L,1905L,2044L,2046L,2047L,2071L,2465L,2701L,2821L,2926L,3133L,3277L,3367L,3683L,4033L,4369L,4371L,4681L,4795L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122781Inst : IEnumerable<long>
{
public static readonly long[] Value=A122781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122781.Bytes);
public long this[int i]=>Value[i];

public static A122781Inst Instance=new A122781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122782
{
public static readonly long[] Value={ 1L,4L,10L,15L,20L,65L,124L,190L,217L,310L,435L,561L,781L,1105L,1541L,1729L,1891L,2465L,2821L,3565L,3820L,4123L,4495L,5461L,5611L,5662L,5731L,6601L,6735L,7449L,7813L,8029L,8290L,8911L,9881L,10585L,11041L,11476L,12801L,13021L,13333L,13981L,14981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122782Inst : IEnumerable<long>
{
public static readonly long[] Value=A122782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122782.Bytes);
public long this[int i]=>Value[i];

public static A122782Inst Instance=new A122782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122783
{
public static readonly long[] Value={ 1L,6L,10L,15L,21L,30L,35L,105L,185L,190L,217L,231L,301L,430L,435L,481L,561L,777L,1105L,1111L,1221L,1261L,1333L,1729L,1866L,2121L,2465L,2553L,2701L,2821L,2955L,3421L,3565L,3589L,3885L,3913L,4123L,4495L,5061L,5565L,5662L,5713L,6531L,6533L,6601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122783Inst : IEnumerable<long>
{
public static readonly long[] Value=A122783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122783.Bytes);
public long this[int i]=>Value[i];

public static A122783Inst Instance=new A122783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122784
{
public static readonly long[] Value={ 1L,6L,14L,21L,25L,42L,105L,133L,231L,301L,325L,525L,561L,703L,817L,1105L,1729L,1825L,2101L,2353L,2465L,2821L,3277L,3325L,3486L,3913L,4011L,4525L,4825L,5565L,5719L,5901L,6601L,6697L,7525L,8321L,8911L,9331L,10225L,10325L,10585L,10621L,11041L,11521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122784Inst : IEnumerable<long>
{
public static readonly long[] Value=A122784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122784.Bytes);
public long this[int i]=>Value[i];

public static A122784Inst Instance=new A122784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122785
{
public static readonly long[] Value={ 1L,4L,8L,9L,14L,21L,28L,341L,481L,511L,561L,585L,645L,651L,861L,949L,1001L,1016L,1105L,1106L,1281L,1288L,1365L,1387L,1417L,1541L,1649L,1661L,1729L,1736L,1785L,1905L,2044L,2047L,2169L,2465L,2501L,2696L,2701L,2821L,3145L,3171L,3201L,3277L,3605L,3641L,4005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122785Inst : IEnumerable<long>
{
public static readonly long[] Value=A122785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122785.Bytes);
public long this[int i]=>Value[i];

public static A122785Inst Instance=new A122785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122786
{
public static readonly long[] Value={ 1L,4L,6L,8L,9L,12L,15L,18L,24L,28L,36L,45L,52L,66L,72L,91L,121L,153L,205L,276L,286L,364L,366L,369L,396L,435L,511L,532L,561L,616L,671L,697L,703L,726L,804L,946L,949L,1035L,1036L,1105L,1128L,1288L,1387L,1541L,1729L,1737L,1845L,1854L,1891L,2196L,2465L,2501L,2556L,2665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122786Inst : IEnumerable<long>
{
public static readonly long[] Value=A122786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122786.Bytes);
public long this[int i]=>Value[i];

public static A122786Inst Instance=new A122786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122787
{
public static readonly BigInteger[] Value={ 3L,37L,333667L,757L,163L,BigInteger.Parse("411361786890737698932559"),313471L,2558791L,618846643L,2238862519L,396319276163359L,34720813L };
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
public class A122787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122787Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122787.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A122787.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122787Inst Instance=new A122787Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122788
{
public static readonly long[] Value={ 0L,1L,1L,0L,0L,2L,4L,4L,4L,8L,16L,24L,32L,48L,80L,128L,192L,288L,448L,704L,1088L,1664L,2560L,3968L,6144L,9472L,14592L,22528L,34816L,53760L,82944L,128000L,197632L,305152L,471040L,727040L,1122304L,1732608L,2674688L,4128768L,6373376L,9838592L,15187968L,23445504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122788Inst : IEnumerable<long>
{
public static readonly long[] Value=A122788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122788.Bytes);
public long this[int i]=>Value[i];

public static A122788Inst Instance=new A122788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122789
{
public static readonly long[] Value={ 0L,1L,1L,0L,0L,1L,2L,2L,2L,3L,5L,7L,9L,12L,17L,24L,33L,45L,62L,86L,119L,164L,226L,312L,431L,595L,821L,1133L,1564L,2159L,2980L,4113L,5677L,7836L,10816L,14929L,20606L,28442L,39258L,54187L,74793L,103235L,142493L,196680L,271473L,374708L,517201L,713881L,985354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122789Inst : IEnumerable<long>
{
public static readonly long[] Value=A122789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122789.Bytes);
public long this[int i]=>Value[i];

public static A122789Inst Instance=new A122789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122790
{
public static readonly long[] Value={ 9L,4L,7L,7L,9L,5L,5L,5L,5L,6L,5L,5L,9L,2L,7L,4L,7L,3L,6L,9L,1L,6L,6L,8L,1L,0L,1L,2L,5L,8L,9L,0L,4L,1L,9L,4L,2L,2L,8L,1L,8L,7L,1L,6L,0L,4L,4L,2L,7L,2L,9L,9L,7L,1L,5L,9L,2L,7L,4L,4L,2L,3L,5L,6L,6L,6L,7L,0L,1L,5L,3L,2L,2L,1L,6L,2L,4L,8L,2L,8L,1L,7L,7L,5L,6L,1L,0L,6L,8L,5L,6L,5L,5L,7L,3L,1L,0L,4L,0L,2L,6L,4L,4L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122790Inst : IEnumerable<long>
{
public static readonly long[] Value=A122790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122790.Bytes);
public long this[int i]=>Value[i];

public static A122790Inst Instance=new A122790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122791
{
public static readonly long[] Value={ 3L,4L,9L,2L,6L,5L,1L,8L,5L,2L,1L,8L,6L,4L,2L,4L,9L,1L,2L,3L,0L,5L,5L,6L,0L,3L,3L,7L,5L,2L,9L,6L,8L,0L,6L,4L,7L,4L,2L,7L,2L,9L,0L,5L,3L,4L,8L,0L,9L,0L,9L,9L,9L,0L,5L,3L,0L,9L,1L,4L,7L,4L,5L,2L,2L,2L,2L,3L,3L,8L,4L,4L,0L,7L,2L,0L,8L,2L,7L,6L,0L,5L,9L,1L,8L,7L,0L,2L,2L,8L,5L,5L,1L,9L,1L,0L,3L,4L,6L,7L,5L,4L,8L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122791Inst : IEnumerable<long>
{
public static readonly long[] Value=A122791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122791.Bytes);
public long this[int i]=>Value[i];

public static A122791Inst Instance=new A122791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122792
{
public static readonly long[] Value={ 1L,1L,0L,2L,1L,0L,4L,2L,0L,6L,4L,0L,10L,6L,0L,16L,9L,0L,24L,14L,0L,36L,20L,0L,52L,29L,0L,74L,42L,0L,104L,58L,0L,144L,80L,0L,198L,110L,0L,268L,148L,0L,360L,198L,0L,480L,264L,0L,634L,347L,0L,832L,454L,0L,1084L,592L,0L,1404L,764L,0L,1808L,982L,0L,2316L,1257L,0L,2952L,1598L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122792Inst : IEnumerable<long>
{
public static readonly long[] Value=A122792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122792.Bytes);
public long this[int i]=>Value[i];

public static A122792Inst Instance=new A122792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122793
{
public static readonly long[] Value={ 1L,3L,7L,12L,19L,28L,38L,50L,64L,80L,97L,116L,137L,160L,185L,211L,239L,269L,301L,335L,371L,408L,447L,488L,531L,576L,623L,672L,722L,774L,828L,884L,942L,1002L,1064L,1128L,1193L,1260L,1329L,1400L,1473L,1548L,1625L,1704L,1785L,1867L,1951L,2037L,2125L,2215L,2307L,2401L,2497L,2595L,2695L,2796L,2899L,3004L,3111L,3220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122793Inst : IEnumerable<long>
{
public static readonly long[] Value=A122793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122793.Bytes);
public long this[int i]=>Value[i];

public static A122793Inst Instance=new A122793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122794
{
public static readonly long[] Value={ 1L,3L,8L,16L,25L,37L,52L,70L,91L,113L,138L,166L,197L,231L,268L,308L,349L,393L,440L,490L,543L,599L,658L,720L,785L,851L,920L,992L,1067L,1145L,1226L,1310L,1397L,1487L,1580L,1676L,1773L,1873L,1976L,2082L,2191L,2303L,2418L,2536L,2657L,2781L,2908L,3038L,3171L,3305L,3442L,3582L,3725L,3871L,4020L,4172L,4327L,4485L,4646L,4810L,4977L,5147L,5320L,5496L,5673L,5853L,6036L,6222L,6411L,6603L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122794Inst : IEnumerable<long>
{
public static readonly long[] Value=A122794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122794.Bytes);
public long this[int i]=>Value[i];

public static A122794Inst Instance=new A122794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122795
{
public static readonly long[] Value={ 1L,3L,10L,22L,39L,57L,80L,108L,141L,179L,222L,270L,319L,373L,432L,496L,565L,639L,718L,802L,891L,985L,1080L,1180L,1285L,1395L,1510L,1630L,1755L,1885L,2020L,2160L,2305L,2455L,2610L,2766L,2927L,3093L,3264L,3440L,3621L,3807L,3998L,4194L,4395L,4601L,4812L,5028L,5249L,5475L,5706L,5938L,6175L,6417L,6664L,6916L,7173L,7435L,7702L,7974L,8251L,8533L,8820L,9112L,9409L,9711L,10018L,10330L,10647L,10969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122795Inst : IEnumerable<long>
{
public static readonly long[] Value=A122795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122795.Bytes);
public long this[int i]=>Value[i];

public static A122795Inst Instance=new A122795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122796
{
public static readonly long[] Value={ 1L,3L,8L,16L,27L,41L,58L,76L,97L,121L,148L,178L,211L,247L,286L,328L,373L,421L,470L,522L,577L,635L,696L,760L,827L,897L,970L,1046L,1125L,1207L,1292L,1380L,1471L,1565L,1660L,1758L,1859L,1963L,2070L,2180L,2293L,2409L,2528L,2650L,2775L,2903L,3034L,3168L,3305L,3445L,3588L,3734L,3883L,4035L,4190L,4346L,4505L,4667L,4832L,5000L,5171L,5345L,5522L,5702L,5885L,6071L,6260L,6452L,6647L,6845L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122796Inst : IEnumerable<long>
{
public static readonly long[] Value=A122796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122796.Bytes);
public long this[int i]=>Value[i];

public static A122796Inst Instance=new A122796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122797
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,4L,5L,6L,7L,7L,8L,9L,10L,11L,11L,12L,13L,14L,15L,16L,16L,17L,18L,19L,20L,21L,22L,22L,23L,24L,25L,26L,27L,28L,29L,29L,30L,31L,32L,33L,34L,35L,36L,37L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,79L,80L,81L,82L,83L,84L,85L,86L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122797Inst : IEnumerable<long>
{
public static readonly long[] Value=A122797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122797.Bytes);
public long this[int i]=>Value[i];

public static A122797Inst Instance=new A122797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122798
{
public static readonly long[] Value={ 1L,1L,5L,9L,13L,13L,17L,21L,25L,29L,33L,37L,37L,41L,45L,49L,53L,57L,61L,65L,69L,73L,73L,77L,81L,85L,89L,93L,97L,101L,105L,109L,113L,117L,121L,121L,125L,129L,133L,137L,141L,145L,149L,153L,157L,161L,165L,169L,173L,177L,181L,181L,185L,189L,193L,197L,201L,205L,209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122798Inst : IEnumerable<long>
{
public static readonly long[] Value=A122798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122798.Bytes);
public long this[int i]=>Value[i];

public static A122798Inst Instance=new A122798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122799
{
public static readonly long[] Value={ 1L,1L,3L,5L,7L,9L,11L,11L,13L,15L,17L,19L,21L,23L,25L,27L,29L,31L,31L,33L,35L,37L,39L,41L,43L,45L,47L,49L,51L,53L,55L,57L,59L,61L,61L,63L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,97L,99L,101L,101L,103L,105L,107L,109L,111L,113L,115L,117L,119L,121L,123L,125L,127L,129L,131L,133L,135L,137L,139L,141L,143L,145L,147L,149L,151L,151L,153L,155L,157L,159L,161L,163L,165L,167L,169L,171L,173L,175L,177L,179L,181L,183L,185L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122799Inst : IEnumerable<long>
{
public static readonly long[] Value=A122799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122799.Bytes);
public long this[int i]=>Value[i];

public static A122799Inst Instance=new A122799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122800
{
public static readonly long[] Value={ 1L,1L,3L,5L,5L,7L,9L,11L,13L,13L,15L,17L,19L,21L,23L,25L,25L,27L,29L,31L,33L,35L,37L,39L,41L,41L,43L,45L,47L,49L,51L,53L,55L,57L,59L,61L,61L,63L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,85L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,105L,107L,109L,111L,113L,113L,115L,117L,119L,121L,123L,125L,127L,129L,131L,133L,135L,137L,139L,141L,143L,145L,145L,147L,149L,151L,153L,155L,157L,159L,161L,163L,165L,167L,169L,171L,173L,175L,177L,179L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122800Inst : IEnumerable<long>
{
public static readonly long[] Value=A122800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122800.Bytes);
public long this[int i]=>Value[i];

public static A122800Inst Instance=new A122800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122801
{
public static readonly BigInteger[] Value={ 1L,1L,21L,2650L,1452605L,3149738046L,26503552820514L,868081172737564500L,BigInteger.Parse("111606080497500509325405"),BigInteger.Parse("56762846667123360827351083510"),BigInteger.Parse("114847831981827229530824587617895286") };
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
public class A122801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122801Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122801.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A122801.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122801Inst Instance=new A122801Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122802
{
public static readonly BigInteger[] Value={ 1L,0L,1L,6L,29L,510L,5032L,161406L,3294405L,194342910L,7934652356L,881008805886L,71275547085536L,15178191426486270L,2434250064518832302L,BigInteger.Parse("1008694542117649154046"),BigInteger.Parse("321680912414994434144165") };
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
public class A122802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122802Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122802.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A122802.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122802Inst Instance=new A122802Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122803
{
public static readonly long[] Value={ 1L,-2L,4L,-8L,16L,-32L,64L,-128L,256L,-512L,1024L,-2048L,4096L,-8192L,16384L,-32768L,65536L,-131072L,262144L,-524288L,1048576L,-2097152L,4194304L,-8388608L,16777216L,-33554432L,67108864L,-134217728L,268435456L,-536870912L,1073741824L,-2147483648L,4294967296L,-8589934592L,17179869184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122803Inst : IEnumerable<long>
{
public static readonly long[] Value=A122803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122803.Bytes);
public long this[int i]=>Value[i];

public static A122803Inst Instance=new A122803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122804
{
public static readonly long[] Value={ 1L,4L,3L,12L,10L,12L,21L,32L,9L,40L,55L,48L,26L,28L,45L,112L,17L,108L,114L,180L,63L,132L,23L,168L,150L,104L,270L,28L,145L,150L,186L,128L,99L,170L,70L,252L,370L,266L,39L,400L,328L,252L,301L,352L,495L,92L,188L,576L,245L,150L,408L,468L,106L,486L,165L,784L,342L,406L,649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122804Inst : IEnumerable<long>
{
public static readonly long[] Value=A122804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122804.Bytes);
public long this[int i]=>Value[i];

public static A122804Inst Instance=new A122804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122805
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,2L,3L,4L,1L,4L,5L,4L,2L,2L,3L,7L,1L,6L,6L,9L,3L,6L,1L,7L,6L,4L,10L,1L,5L,5L,6L,4L,3L,5L,2L,7L,10L,7L,1L,10L,8L,6L,7L,8L,11L,2L,4L,12L,5L,3L,8L,9L,2L,9L,3L,14L,6L,7L,11L,13L,8L,16L,4L,2L,11L,14L,11L,6L,6L,1L,10L,12L,9L,21L,2L,13L,5L,6L,8L,15L,6L,4L,7L,3L,2L,9L,10L,16L,12L,13L,17L,1L,5L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122805Inst : IEnumerable<long>
{
public static readonly long[] Value=A122805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122805.Bytes);
public long this[int i]=>Value[i];

public static A122805Inst Instance=new A122805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122806
{
public static readonly long[] Value={ 2L,5L,6L,7L,8L,11L,13L,14L,15L,16L,18L,19L,20L,22L,24L,25L,27L,29L,30L,31L,33L,34L,35L,36L,37L,38L,41L,42L,43L,44L,46L,47L,49L,50L,51L,52L,53L,54L,56L,57L,58L,59L,60L,61L,62L,64L,65L,66L,67L,68L,69L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122806Inst : IEnumerable<long>
{
public static readonly long[] Value=A122806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122806.Bytes);
public long this[int i]=>Value[i];

public static A122806Inst Instance=new A122806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122807
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,1L,0L,2L,0L,1L,2L,1L,0L,2L,0L,1L,2L,1L,0L,2L,4L,1L,0L,0L,2L,0L,0L,1L,2L,1L,0L,0L,2L,0L,0L,1L,4L,2L,0L,1L,2L,1L,0L,2L,4L,1L,0L,11L,2L,8L,22L,1L,0L,4L,2L,0L,0L,1L,2L,1L,0L,0L,2L,0L,0L,1L,4L,2L,28L,1L,2L,1L,0L,0L,2L,6L,10L,1L,0L,2L,6L,1L,0L,0L,2L,4L,0L,1L,0L,12L,6L,2L,0L,21L,8L,1L,0L,2L,40L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122807Inst : IEnumerable<long>
{
public static readonly long[] Value=A122807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122807.Bytes);
public long this[int i]=>Value[i];

public static A122807Inst Instance=new A122807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122808
{
public static readonly long[] Value={ 1L,2L,4L,511L,22L,295L,77L,183L,51L,261L,78L,49L,91L,815L,400L,715L,117L,729L,112L,125L,319L,95L,52L,669L,187L,2223L,123L,477L,70L,1287L,344L,471L,455L,371L,243L,365L,124L,335L,209L,1765L,100L,153L,130L,1071L,273L,1593L,177L,377L,297L,2289L,1396L,2091L,1018L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122808Inst : IEnumerable<long>
{
public static readonly long[] Value=A122808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122808.Bytes);
public long this[int i]=>Value[i];

public static A122808Inst Instance=new A122808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122809
{
public static readonly long[] Value={ 1L,3L,6L,9L,12L,6L,3L,9L,6L,27L,9L,3L,15L,12L,30L,3L,6L,24L,36L,27L,15L,9L,21L,15L,24L,36L,39L,18L,12L,3L,57L,3L,45L,51L,42L,33L,12L,9L,75L,48L,21L,57L,18L,24L,27L,15L,6L,18L,12L,138L,9L,6L,30L,60L,39L,117L,3L,21L,24L,21L,42L,15L,24L,45L,63L,6L,15L,15L,42L,153L,9L,15L,45L,141L,39L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122809Inst : IEnumerable<long>
{
public static readonly long[] Value=A122809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122809.Bytes);
public long this[int i]=>Value[i];

public static A122809Inst Instance=new A122809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122810
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,1L,3L,2L,2L,1L,3L,1L,2L,2L,3L,1L,3L,1L,3L,2L,2L,1L,4L,2L,2L,3L,3L,1L,3L,1L,4L,2L,2L,2L,4L,1L,2L,2L,4L,1L,3L,1L,3L,3L,2L,1L,5L,2L,3L,2L,3L,1L,4L,2L,4L,2L,2L,1L,4L,1L,2L,3L,5L,2L,3L,1L,3L,2L,3L,1L,5L,1L,2L,3L,3L,2L,3L,1L,5L,4L,2L,1L,4L,2L,2L,2L,4L,1L,4L,2L,3L,2L,2L,2L,5L,1L,3L,3L,4L,1L,3L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122810Inst : IEnumerable<long>
{
public static readonly long[] Value=A122810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122810.Bytes);
public long this[int i]=>Value[i];

public static A122810Inst Instance=new A122810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122811
{
public static readonly long[] Value={ 0L,1L,2L,2L,4L,3L,6L,3L,4L,5L,10L,4L,12L,7L,6L,5L,16L,5L,18L,6L,8L,11L,22L,5L,8L,13L,6L,8L,28L,7L,30L,6L,12L,17L,10L,6L,36L,19L,14L,7L,40L,9L,42L,12L,8L,23L,46L,6L,12L,9L,18L,14L,52L,7L,14L,9L,20L,29L,58L,8L,60L,31L,10L,7L,16L,13L,66L,18L,24L,11L,70L,7L,72L,37L,10L,20L,16L,15L,78L,8L,8L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122811Inst : IEnumerable<long>
{
public static readonly long[] Value=A122811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122811.Bytes);
public long this[int i]=>Value[i];

public static A122811Inst Instance=new A122811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122812
{
public static readonly long[] Value={ 8L,24L,48L,64L,72L,80L,108L,112L,128L,144L,160L,162L,176L,192L,208L,216L,224L,243L,256L,272L,288L,304L,320L,324L,352L,368L,384L,416L,432L,448L,464L,480L,486L,496L,512L,544L,576L,592L,608L,640L,648L,656L,672L,688L,704L,729L,736L,752L,768L,832L,848L,864L,896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122812Inst : IEnumerable<long>
{
public static readonly long[] Value=A122812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122812.Bytes);
public long this[int i]=>Value[i];

public static A122812Inst Instance=new A122812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122813
{
public static readonly long[] Value={ 24L,360L,2520L,7560L,10080L,15120L,50400L,60480L,83160L,110880L,166320L,352800L,967680L,332640L,3870720L,554400L,665280L,2822400L,1081080L,61931520L,1441440L,247726080L,2162160L,3880800L,10644480L,3963617280L,4324320L,42577920L,7207200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122813Inst : IEnumerable<long>
{
public static readonly long[] Value=A122813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122813.Bytes);
public long this[int i]=>Value[i];

public static A122813Inst Instance=new A122813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122814
{
public static readonly long[] Value={ 105L,3465L,45045L,135135L,225225L,405405L,1576575L,3648645L,2297295L,3828825L,6891885L,17342325L,295540245L,11486475L,2659862205L,26801775L,62026965L,225450225L,43648605L,215448838605L,72747675L,1939039547445L,130945815L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122814Inst : IEnumerable<long>
{
public static readonly long[] Value=A122814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122814.Bytes);
public long this[int i]=>Value[i];

public static A122814Inst Instance=new A122814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122815
{
public static readonly long[] Value={ 2L,3L,4L,4L,4L,4L,4L,4L,5L,5L,5L,4L,4L,5L,4L,5L,5L,4L,6L,4L,6L,4L,6L,5L,5L,4L,6L,5L,6L,6L,4L,6L,5L,4L,6L,5L,6L,4L,5L,7L,6L,4L,6L,4L,6L,5L,5L,4L,7L,6L,4L,7L,7L,5L,4L,7L,6L,4L,5L,7L,6L,4L,6L,4L,7L,4L,5L,5L,6L,6L,4L,7L,5L,4L,7L,5L,7L,4L,7L,6L,6L,5L,8L,4L,4L,6L,6L,4L,7L,5L,4L,4L,4L,6L,6L,5L,8L,7L,5L,6L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122815Inst : IEnumerable<long>
{
public static readonly long[] Value=A122815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122815.Bytes);
public long this[int i]=>Value[i];

public static A122815Inst Instance=new A122815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122816
{
public static readonly long[] Value={ 3L,4L,5L,5L,5L,5L,5L,5L,6L,6L,6L,5L,5L,6L,5L,6L,6L,5L,7L,5L,7L,5L,7L,6L,6L,5L,7L,6L,7L,7L,5L,7L,6L,5L,8L,6L,7L,5L,6L,8L,7L,5L,7L,5L,7L,6L,6L,5L,8L,7L,5L,8L,8L,6L,5L,8L,7L,5L,6L,8L,7L,5L,7L,5L,8L,5L,6L,6L,7L,7L,5L,8L,6L,5L,8L,6L,8L,5L,8L,7L,7L,6L,9L,5L,5L,7L,7L,5L,8L,6L,5L,5L,5L,7L,7L,6L,9L,8L,6L,7L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122816Inst : IEnumerable<long>
{
public static readonly long[] Value=A122816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122816.Bytes);
public long this[int i]=>Value[i];

public static A122816Inst Instance=new A122816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122817
{
public static readonly long[] Value={ 4L,6L,7L,8L,9L,9L,10L,11L,9L,10L,10L,11L,15L,11L,17L,11L,12L,14L,10L,21L,11L,23L,11L,12L,16L,27L,12L,18L,12L,13L,33L,12L,15L,35L,14L,22L,13L,41L,24L,12L,13L,45L,14L,47L,17L,16L,28L,51L,13L,19L,57L,13L,14L,34L,63L,13L,16L,65L,36L,15L,18L,71L,23L,75L,14L,77L,42L,18L,25L,20L,83L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122817Inst : IEnumerable<long>
{
public static readonly long[] Value=A122817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122817.Bytes);
public long this[int i]=>Value[i];

public static A122817Inst Instance=new A122817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122818
{
public static readonly long[] Value={ 3L,5L,6L,7L,7L,8L,8L,10L,8L,8L,9L,9L,14L,9L,16L,9L,11L,10L,9L,20L,9L,22L,10L,10L,15L,26L,10L,17L,10L,12L,32L,11L,11L,34L,10L,21L,11L,40L,23L,11L,11L,44L,13L,46L,16L,12L,27L,50L,11L,18L,56L,11L,13L,33L,62L,12L,12L,64L,35L,12L,17L,70L,22L,74L,12L,76L,41L,14L,24L,19L,82L,12L,45L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122818Inst : IEnumerable<long>
{
public static readonly long[] Value=A122818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122818.Bytes);
public long this[int i]=>Value[i];

public static A122818Inst Instance=new A122818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122819
{
public static readonly long[] Value={ 1L,3L,9L,15L,27L,81L,45L,243L,729L,105L,135L,2187L,225L,6561L,405L,19683L,59049L,315L,675L,1215L,177147L,531441L,3645L,1594323L,2025L,4782969L,945L,1155L,3375L,10935L,14348907L,43046721L,1575L,6075L,32805L,129140163L,387420489L,2835L,10125L,98415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122819Inst : IEnumerable<long>
{
public static readonly long[] Value=A122819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122819.Bytes);
public long this[int i]=>Value[i];

public static A122819Inst Instance=new A122819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122820
{
public static readonly long[] Value={ 2L,3L,5L,3L,5L,7L,5L,7L,11L,13L,71L,73L,79L,83L,89L,5L,7L,11L,13L,17L,19L,7L,11L,13L,17L,19L,23L,29L,17L,19L,23L,29L,31L,37L,41L,43L,239L,241L,251L,257L,263L,269L,271L,277L,281L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,5L,7L,11L,13L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122820Inst : IEnumerable<long>
{
public static readonly long[] Value=A122820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122820.Bytes);
public long this[int i]=>Value[i];

public static A122820Inst Instance=new A122820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122821
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,1L,0L,2L,0L,1L,3L,1L,0L,3L,0L,2L,2L,1L,0L,1L,2L,2L,0L,0L,2L,0L,0L,2L,5L,2L,0L,0L,3L,0L,0L,2L,4L,2L,0L,1L,3L,2L,0L,1L,1L,2L,0L,2L,1L,5L,1L,4L,0L,2L,2L,0L,0L,1L,3L,1L,0L,0L,2L,0L,0L,1L,1L,4L,1L,2L,1L,1L,0L,0L,1L,1L,3L,2L,0L,2L,2L,1L,0L,0L,1L,5L,0L,3L,0L,1L,1L,1L,0L,2L,2L,2L,0L,1L,1L,3L,3L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122821Inst : IEnumerable<long>
{
public static readonly long[] Value=A122821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122821.Bytes);
public long this[int i]=>Value[i];

public static A122821Inst Instance=new A122821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122822
{
public static readonly long[] Value={ 0L,0L,-1L,0L,0L,-1L,1L,2L,3L,10L,19L,35L,71L,131L,240L,446L,810L,1467L,2660L,4792L,8621L,15501L,27814L,49873L,89384L,160079L,286589L,512943L,917813L,1641978L,2937132L,5253248L,9395035L,16801268L,30044388L,53724067L,96064297L,171769178L,307129259L,549150614L,981877515L,1755576755L,3138916347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122822Inst : IEnumerable<long>
{
public static readonly long[] Value=A122822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122822.Bytes);
public long this[int i]=>Value[i];

public static A122822Inst Instance=new A122822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122823
{
public static readonly long[] Value={ 2L,7L,11L,15L,96L,132L,26L,378L,2088L,2664L,40L,1040L,12960L,66240L,80640L,57L,2325L,51600L,594000L,2894400L,3412800L,77L,4536L,157500L,3225600L,35380800L,166924800L,192326400L,100L,8036L,402192L,12877200L,251193600L,2667168000L,12294374400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122823Inst : IEnumerable<long>
{
public static readonly long[] Value=A122823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122823.Bytes);
public long this[int i]=>Value[i];

public static A122823Inst Instance=new A122823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122824
{
public static readonly long[] Value={ 1L,4L,9L,8L,10L,12L,24L,24L,32L,15L,46L,24L,27L,34L,25L,40L,44L,46L,51L,54L,53L,46L,54L,60L,70L,70L,98L,105L,104L,91L,64L,72L,45L,48L,95L,118L,120L,120L,116L,108L,100L,96L,101L,118L,102L,144L,123L,86L,76L,81L,136L,138L,143L,112L,132L,131L,153L,160L,171L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122824Inst : IEnumerable<long>
{
public static readonly long[] Value=A122824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122824.Bytes);
public long this[int i]=>Value[i];

public static A122824Inst Instance=new A122824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122825
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,9L,10L,11L,13L,15L,16L,17L,19L,21L,22L,23L,25L,26L,27L,28L,29L,31L,33L,34L,35L,36L,37L,39L,40L,41L,43L,45L,46L,47L,49L,50L,51L,52L,53L,55L,56L,57L,58L,59L,61L,63L,64L,65L,66L,67L,69L,70L,71L,73L,75L,76L,77L,78L,79L,81L,82L,83L,85L,86L,87L,88L,89L,91L,92L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122825Inst : IEnumerable<long>
{
public static readonly long[] Value=A122825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122825.Bytes);
public long this[int i]=>Value[i];

public static A122825Inst Instance=new A122825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122826
{
public static readonly BigInteger[] Value={ 1L,1L,2L,10L,55L,377L,2892L,25007L,239286L,2514113L,28781748L,356825354L,4765183277L,68227504423L,1043012154681L,16960950354371L,292402844221089L,5327959744239694L,102326036191376400L,2066148465783001383L,BigInteger.Parse("43760821265601562218"),BigInteger.Parse("970152278606623445790") };
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
public class A122826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122826Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122826.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A122826.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122826Inst Instance=new A122826Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122827
{
public static readonly BigInteger[] Value={ 1L,0L,1L,6L,39L,284L,2305L,20682L,203651L,2186744L,25463925L,319989030L,4320183527L,62412737460L,961264517369L,15730347890082L,272650924761195L,4991218317261808L,96248879172426557L,1950405560049871134L,BigInteger.Parse("41440841509597888495"),BigInteger.Parse("921333064567137032620"),BigInteger.Parse("21392807067461981820417") };
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
public class A122827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122827Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122827.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A122827.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122827Inst Instance=new A122827Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122828
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,2L,3L,7L,5L,2L,5L,13L,14L,7L,2L,8L,25L,32L,23L,9L,2L,13L,46L,71L,62L,34L,11L,2L,34L,151L,304L,367L,295L,163L,62L,15L,2L,55L,269L,604L,827L,767L,505L,238L,79L,17L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122828Inst : IEnumerable<long>
{
public static readonly long[] Value=A122828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122828.Bytes);
public long this[int i]=>Value[i];

public static A122828Inst Instance=new A122828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122829
{
public static readonly long[] Value={ 1L,6L,24L,160L,30L,84L,60L,120L,180L,960L,360L,504L,1008L,210L,1470L,2550L,1050L,420L,630L,924L,840L,1260L,1320L,2184L,2520L,2640L,3120L,5712L,6120L,5040L,8400L,9360L,10080L,13440L,13200L,18900L,15120L,23760L,25200L,26400L,2310L,30240L,40320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122829Inst : IEnumerable<long>
{
public static readonly long[] Value=A122829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122829.Bytes);
public long this[int i]=>Value[i];

public static A122829Inst Instance=new A122829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122830
{
public static readonly long[] Value={ 1L,1L,0L,-2L,-3L,0L,5L,7L,0L,-12L,-15L,0L,26L,32L,0L,-50L,-63L,0L,92L,114L,0L,-168L,-201L,0L,295L,350L,0L,-496L,-591L,0L,818L,967L,0L,-1332L,-1554L,0L,2126L,2468L,0L,-3324L,-3855L,0L,5126L,5916L,0L,-7824L,-8970L,0L,11793L,13471L,0L,-17548L,-20007L,0L,25857L,29384L,0L,-37788L,-42771L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122830Inst : IEnumerable<long>
{
public static readonly long[] Value=A122830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122830.Bytes);
public long this[int i]=>Value[i];

public static A122830Inst Instance=new A122830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122831
{
public static readonly long[] Value={ 1L,3L,3L,0L,-6L,-9L,0L,15L,21L,0L,-36L,-45L,0L,78L,96L,0L,-150L,-189L,0L,276L,342L,0L,-504L,-603L,0L,885L,1050L,0L,-1488L,-1773L,0L,2454L,2901L,0L,-3996L,-4662L,0L,6378L,7404L,0L,-9972L,-11565L,0L,15378L,17748L,0L,-23472L,-26910L,0L,35379L,40413L,0L,-52644L,-60021L,0L,77571L,88152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122831Inst : IEnumerable<long>
{
public static readonly long[] Value=A122831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122831.Bytes);
public long this[int i]=>Value[i];

public static A122831Inst Instance=new A122831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122832
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,1L,7L,9L,3L,1L,25L,28L,18L,4L,1L,81L,125L,70L,30L,5L,1L,331L,486L,375L,140L,45L,6L,1L,1303L,2317L,1701L,875L,245L,63L,7L,1L,5937L,10424L,9268L,4536L,1750L,392L,84L,8L,1L,26785L,53433L,46908L,27804L,10206L,3150L,588L,108L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122832Inst : IEnumerable<long>
{
public static readonly long[] Value=A122832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122832.Bytes);
public long this[int i]=>Value[i];

public static A122832Inst Instance=new A122832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122833
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,-2L,1L,5L,-3L,-3L,1L,1L,20L,-6L,-4L,1L,-41L,5L,50L,-10L,-5L,1L,31L,-246L,15L,100L,-15L,-6L,1L,461L,217L,-861L,35L,175L,-21L,-7L,1L,-895L,3688L,868L,-2296L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122833Inst : IEnumerable<long>
{
public static readonly long[] Value=A122833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122833.Bytes);
public long this[int i]=>Value[i];

public static A122833Inst Instance=new A122833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122834
{
public static readonly BigInteger[] Value={ 3L,5L,7L,13L,17L,19L,31L,61L,67L,127L,257L,1021L,4093L,4099L,8191L,16381L,65537L,65539L,131071L,262147L,524287L,1048573L,4194301L,16777213L,268435459L,1073741827L,2147483647L,2305843009213693951L,BigInteger.Parse("19342813113834066795298819") };
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
public class A122834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122834Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122834.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A122834.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122834Inst Instance=new A122834Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122835
{
public static readonly long[] Value={ 1L,1L,4L,19L,112L,811L,7024L,70939L,818752L,10630891L,153371344L,2433948859L,42137351392L,790287522571L,15962014455664L,345424786466779L,7973482022972032L,195556150543703851L,5078301994885267984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122835Inst : IEnumerable<long>
{
public static readonly long[] Value=A122835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122835.Bytes);
public long this[int i]=>Value[i];

public static A122835Inst Instance=new A122835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122836
{
public static readonly BigInteger[] Value={ 0L,0L,0L,10L,243L,6131L,202503L,9464302L,641960602L,63249658532L,8976900501699L,1816843604787333L,519355528928422629L,BigInteger.Parse("20788139292866381430470"),BigInteger.Parse("115617051961092253351796"),BigInteger.Parse("88736269118240819706018342") };
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
public class A122836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122836Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A122836.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A122836.Bytes);
public BigInteger this[int i]=>Value[i];

public static A122836Inst Instance=new A122836Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122837
{
public static readonly long[] Value={ 1L,1L,-1L,2L,0L,-1L,3L,1L,-1L,-1L,5L,4L,-1L,-2L,-1L,8L,10L,2L,-4L,-3L,-1L,13L,22L,11L,-4L,-8L,-4L,-1L,21L,45L,35L,3L,-15L,-13L,-5L,-1L,34L,88L,91L,34L,-20L,-32L,-19L,-6L,-1L,55L,167L,214L,128L,-1L,-65L,-56L,-26L,-7L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122837Inst : IEnumerable<long>
{
public static readonly long[] Value=A122837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122837.Bytes);
public long this[int i]=>Value[i];

public static A122837Inst Instance=new A122837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122838
{
public static readonly long[] Value={ 1L,-1L,1L,0L,-2L,1L,2L,2L,-4L,1L,-6L,2L,11L,-7L,1L,22L,-24L,-37L,42L,-12L,1L,-146L,204L,217L,-338L,133L,-20L,1L,1766L,-2654L,-2395L,4359L,-1995L,387L,-33L,1L,-36064L,56072L,46122L,-91568L,45323L,-9982L,1073L,-54L,1L,1212048L,-1921280L,-1492916L,3124562L,-1616590L,381615L,-46200L,2901L,-88L,1L,-66338064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122838Inst : IEnumerable<long>
{
public static readonly long[] Value=A122838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122838.Bytes);
public long this[int i]=>Value[i];

public static A122838Inst Instance=new A122838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122839
{
public static readonly long[] Value={ 1L,2L,3L,6L,14L,15L,30L,35L,42L,60L,70L,78L,105L,190L,210L,312L,357L,418L,570L,714L,910L,1045L,1254L,1428L,2090L,2730L,3135L,3640L,4522L,4674L,5278L,6270L,10659L,10920L,12441L,13566L,14630L,15834L,16770L,18696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122839Inst : IEnumerable<long>
{
public static readonly long[] Value=A122839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122839.Bytes);
public long this[int i]=>Value[i];

public static A122839Inst Instance=new A122839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A122840
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A122840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A122840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A122840Inst : IEnumerable<long>
{
public static readonly long[] Value=A122840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A122840.Bytes);
public long this[int i]=>Value[i];

public static A122840Inst Instance=new A122840Inst();

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