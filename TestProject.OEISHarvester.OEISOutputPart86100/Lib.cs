using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A105741
{
public static readonly long[] Value={ 1L,8L,9L,14L,8L,6L,2L,4L,6L,4L,2L,2L,4L,6L,4L,2L,2L,4L,6L,4L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105741Inst : IEnumerable<long>
{
public static readonly long[] Value=A105741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105741.Bytes);
public long this[int i]=>Value[i];

public static A105741Inst Instance=new A105741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105742
{
public static readonly long[] Value={ 1L,9L,10L,16L,8L,3L,5L,2L,3L,2L,1L,1L,2L,3L,2L,1L,1L,2L,3L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105742Inst : IEnumerable<long>
{
public static readonly long[] Value=A105742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105742.Bytes);
public long this[int i]=>Value[i];

public static A105742Inst Instance=new A105742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105743
{
public static readonly long[] Value={ 1L,10L,11L,6L,5L,1L,4L,5L,6L,8L,8L,6L,2L,4L,6L,4L,2L,2L,4L,6L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105743Inst : IEnumerable<long>
{
public static readonly long[] Value=A105743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105743.Bytes);
public long this[int i]=>Value[i];

public static A105743Inst Instance=new A105743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105744
{
public static readonly long[] Value={ 1L,11L,12L,20L,8L,1L,7L,8L,12L,8L,4L,4L,3L,1L,2L,3L,2L,1L,1L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105744Inst : IEnumerable<long>
{
public static readonly long[] Value=A105744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105744.Bytes);
public long this[int i]=>Value[i];

public static A105744Inst Instance=new A105744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105745
{
public static readonly long[] Value={ 1L,12L,13L,4L,9L,9L,4L,5L,6L,8L,8L,6L,2L,4L,6L,4L,2L,2L,4L,6L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105745Inst : IEnumerable<long>
{
public static readonly long[] Value=A105745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105745.Bytes);
public long this[int i]=>Value[i];

public static A105745Inst Instance=new A105745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105746
{
public static readonly long[] Value={ 3L,2L,4L,6L,8L,3L,12L,14L,16L,6L,20L,4L,24L,9L,7L,30L,32L,12L,36L,5L,8L,15L,44L,11L,48L,18L,52L,9L,56L,6L,60L,62L,15L,24L,20L,10L,72L,27L,16L,21L,80L,7L,84L,14L,11L,33L,92L,20L,96L,36L,23L,15L,104L,39L,12L,8L,24L,42L,116L,19L,120L,45L,39L,126L,35L,13L,132L,20L,31L,17L,140L,9L,144L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105746Inst : IEnumerable<long>
{
public static readonly long[] Value=A105746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105746.Bytes);
public long this[int i]=>Value[i];

public static A105746Inst Instance=new A105746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105747
{
public static readonly BigInteger[] Value={ 1L,4L,23L,216L,2937L,52108L,1136591L,29382320L,877838673L,29753600404L,1127881002535L,47278107653768L,2171286661012617L,108417864555606300L,5847857079417024031L,BigInteger.Parse("338841578119273846112") };
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
public class A105747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105747Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105747.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105747Inst Instance=new A105747Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105748
{
public static readonly BigInteger[] Value={ 1L,3L,10L,47L,313L,2744L,29751L,383273L,5713110L,96673861L,1830257967L,38326484944L,879473289521L,21944639630923L,591545277653354L,17131028946645255L,530424623323416617L,17485652721425863464UL,BigInteger.Parse("611431929749388274471"),BigInteger.Parse("22604399407882099928577") };
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
public class A105748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105748Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105748.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105748Inst Instance=new A105748Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105749
{
public static readonly BigInteger[] Value={ 1L,2L,14L,222L,6384L,291720L,19445040L,1781750880L,214899027840L,33007837322880L,6290830003852800L,1456812592995513600L,BigInteger.Parse("402910665227270323200"),BigInteger.Parse("131173228963370155161600"),BigInteger.Parse("49656810289225281849907200"),BigInteger.Parse("21628258853895305337293568000"),BigInteger.Parse("10739534026001485514941587456000") };
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
public class A105749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105749Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105749.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105749Inst Instance=new A105749Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105750
{
public static readonly BigInteger[] Value={ 1L,1L,-1L,-10L,-10L,190L,730L,-6620L,-55900L,365300L,5864300L,-28269800L,-839594600L,2691559000L,159300557000L,-238131478000L,-38894192662000L,-15194495654000L,11911522255750000L,29697351895900000L,-4477959179352100000L,BigInteger.Parse("-21683886333440500000"),BigInteger.Parse("2029107997508660900000") };
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
public class A105750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105750Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105750.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105750Inst Instance=new A105750Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105751
{
public static readonly BigInteger[] Value={ 0L,1L,3L,0L,-40L,-90L,1050L,6160L,-46800L,-549900L,3103100L,67610400L,-271627200L,-11186357000L,26495469000L,2416003824000L,-1394099824000L,-662595375078000L,-936096296850000L,225382826562400000L,819329864480400000L,BigInteger.Parse("-93217812901913700000"),BigInteger.Parse("-570263312237604700000") };
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
public class A105751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105751Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105751.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105751Inst Instance=new A105751Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105752
{
public static readonly BigInteger[] Value={ 1L,0L,1L,-3L,12L,-60L,360L,-2520L,20160L,-181440L,1814400L,-19958400L,239500800L,-3113510400L,43589145600L,-653837184000L,10461394944000L,-177843714048000L,3201186852864000L,-60822550204416000L,1216451004088320000L,BigInteger.Parse("-25545471085854720000"),BigInteger.Parse("562000363888803840000") };
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
public class A105752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105752Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105752.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105752Inst Instance=new A105752Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105753
{
public static readonly long[] Value={ 1L,3L,4L,8L,6L,22L,9L,16L,53L,11L,133L,13L,279L,15L,573L,69L,18L,1233L,20L,2486L,23L,44L,4995L,25L,10059L,27L,20145L,29L,40319L,31L,80669L,33L,161371L,35L,322777L,37L,645591L,39L,1291221L,41L,2582483L,43L,5165009L,5039L,46L,10335103L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105753Inst : IEnumerable<long>
{
public static readonly long[] Value=A105753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105753.Bytes);
public long this[int i]=>Value[i];

public static A105753Inst Instance=new A105753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105754
{
public static readonly long[] Value={ 1L,3L,7L,15L,31L,63L,127L,255L,502L,1003L,2003L,3999L,7983L,15935L,31807L,63487L,126719L,252936L,504869L,1007735L,2011471L,4014959L,8013983L,15996159L,31928831L,63730943L,127208950L,253913031L,506818327L,1011625183L,2019235407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105754Inst : IEnumerable<long>
{
public static readonly long[] Value=A105754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105754.Bytes);
public long this[int i]=>Value[i];

public static A105754Inst Instance=new A105754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105755
{
public static readonly long[] Value={ 1L,3L,7L,15L,31L,63L,127L,255L,511L,1013L,2025L,4047L,8087L,16159L,32287L,64511L,128895L,257535L,514559L,1028105L,2054185L,4104323L,8200559L,16384959L,32737631L,65410751L,130692607L,261127679L,521740799L,1042453493L,2082852801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105755Inst : IEnumerable<long>
{
public static readonly long[] Value=A105755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105755.Bytes);
public long this[int i]=>Value[i];

public static A105755Inst Instance=new A105755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105756
{
public static readonly long[] Value={ 3L,7L,8L,25L,146L,169L,182L,751L,812L,1507L,1591L,3157L,3752L,10651L,12740L,71804L,155953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105756Inst : IEnumerable<long>
{
public static readonly long[] Value=A105756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105756.Bytes);
public long this[int i]=>Value[i];

public static A105756Inst Instance=new A105756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105757
{
public static readonly BigInteger[] Value={ 2L,31L,61L,5976577L,BigInteger.Parse("1989179797398599794811479787771439644489521"),BigInteger.Parse("11241696329548911284929550459702062135838997526529"),BigInteger.Parse("73666302576706758839299120422550197113618385815703101") };
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
public class A105757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105757Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105757.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105757Inst Instance=new A105757Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105758
{
public static readonly long[] Value={ 3L,36L,37L,92L,660L,6091L,8415L,11467L,13686L,38831L,49828L,97148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105758Inst : IEnumerable<long>
{
public static readonly long[] Value=A105758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105758.Bytes);
public long this[int i]=>Value[i];

public static A105758Inst Instance=new A105758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105759
{
public static readonly BigInteger[] Value={ 2L,13435170943L,26649774581L,BigInteger.Parse("610186256014622144673892607") };
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
public class A105759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105759Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105759.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105759Inst Instance=new A105759Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105760
{
public static readonly long[] Value={ 0L,2L,3L,5L,6L,8L,11L,12L,15L,17L,18L,20L,23L,26L,27L,30L,32L,33L,36L,38L,41L,45L,47L,48L,50L,51L,53L,60L,62L,65L,66L,71L,72L,75L,78L,80L,83L,86L,87L,92L,93L,95L,96L,102L,108L,110L,111L,113L,116L,117L,122L,125L,128L,131L,132L,135L,137L,138L,143L,150L,152L,153L,155L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105760Inst : IEnumerable<long>
{
public static readonly long[] Value=A105760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105760.Bytes);
public long this[int i]=>Value[i];

public static A105760Inst Instance=new A105760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105761
{
public static readonly long[] Value={ 2L,127L,31489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105761Inst : IEnumerable<long>
{
public static readonly long[] Value=A105761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105761.Bytes);
public long this[int i]=>Value[i];

public static A105761Inst Instance=new A105761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105762
{
public static readonly BigInteger[] Value={ 3L,7L,11L,71L,131L,241L,443L,1499L,196331L,86992799L,541292033L,292997064989357251L,BigInteger.Parse("129824812729295169371"),BigInteger.Parse("238785058551151434437"),BigInteger.Parse("5026368970977284897651"),BigInteger.Parse("105803877284856287511991") };
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
public class A105762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105762Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105762.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105762Inst Instance=new A105762Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105763
{
public static readonly BigInteger[] Value={ 3L,7L,191L,367L,36319L,260111L,6921503L,49570747L,12893894812259L,BigInteger.Parse("24019714105325502367"),BigInteger.Parse("172025522413867986317"),BigInteger.Parse("17007925267174811186047"),BigInteger.Parse("3132517481738616046273627839643") };
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
public class A105763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105763Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105763.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105763Inst Instance=new A105763Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105764
{
public static readonly long[] Value={ 2L,3L,5L,7L,8L,9L,10L,13L,30L,35L,77L,98L,126L,160L,192L,810L,1086L,1999L,2021L,3157L,3426L,3471L,15066L,24115L,29782L,29941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105764Inst : IEnumerable<long>
{
public static readonly long[] Value=A105764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105764.Bytes);
public long this[int i]=>Value[i];

public static A105764Inst Instance=new A105764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105765
{
public static readonly BigInteger[] Value={ 3L,7L,31L,113L,223L,439L,863L,6553L,641449337L,18837477823L,BigInteger.Parse("40276345611255837298559"),BigInteger.Parse("58893004546665606516457357571"),BigInteger.Parse("9774215601155945008361439560567878777") };
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
public class A105765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105765Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105765.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105765Inst Instance=new A105765Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105766
{
public static readonly long[] Value={ 2L,3L,5L,8L,11L,32L,37L,46L,123L,237L,332L,408L,772L,827L,1523L,5610L,11273L,14505L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105766Inst : IEnumerable<long>
{
public static readonly long[] Value=A105766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105766.Bytes);
public long this[int i]=>Value[i];

public static A105766Inst Instance=new A105766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105767
{
public static readonly BigInteger[] Value={ 3L,7L,31L,239L,1871L,3299217791L,101312422979L,48163250752607L,BigInteger.Parse("3858266531308645633776466396252776719"),BigInteger.Parse("31313481899920920568064578921684656674109265283366018689568994494028479") };
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
public class A105767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105767Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105767.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105767Inst Instance=new A105767Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105768
{
public static readonly BigInteger[] Value={ 3L,7L,31L,127L,983L,122401L,15231991L,30341581L,60439343L,239818559L,235883775871L,935968272887L,462162688688737L,3592979567873032703L,BigInteger.Parse("439785318101603999198591"),BigInteger.Parse("432569613524779275706080077") };
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
public class A105768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105768Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105768.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105768Inst Instance=new A105768Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105769
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,11L,1L,1L,13L,55L,1L,1L,1L,1L,1L,175L,325L,13L,253L,1L,1L,1L,1L,1L,23L,1L,1L,1L,1L,5L,1L,1L,19L,11L,19L,5L,35L,1L,1L,629L,1L,253L,29L,1L,1L,29L,31L,43L,37L,5L,13L,43L,1L,1219L,1L,55L,5L,186599L,1L,72283L,1L,29L,1L,47L,1L,1L,1L,1711L,1L,25L,1L,1L,1L,67L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105769Inst : IEnumerable<long>
{
public static readonly long[] Value=A105769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105769.Bytes);
public long this[int i]=>Value[i];

public static A105769Inst Instance=new A105769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105770
{
public static readonly long[] Value={ 1L,2L,7L,10L,17L,28L,37L,50L,67L,82L,101L,124L,145L,170L,199L,226L,257L,292L,325L,362L,403L,442L,485L,532L,577L,626L,679L,730L,785L,844L,901L,962L,1027L,1090L,1157L,1228L,1297L,1370L,1447L,1522L,1601L,1684L,1765L,1850L,1939L,2026L,2117L,2212L,2305L,2402L,2503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105770Inst : IEnumerable<long>
{
public static readonly long[] Value=A105770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105770.Bytes);
public long this[int i]=>Value[i];

public static A105770Inst Instance=new A105770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105771
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,9L,12L,22L,24L,31L,33L,35L,36L,42L,44L,46L,48L,52L,61L,72L,81L,92L,222L,311L,411L,522L,611L,722L,822L,911L,2222L,2231L,3122L,3131L,4222L,5111L,6222L,6231L,7122L,8222L,8231L,9112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105771Inst : IEnumerable<long>
{
public static readonly long[] Value=A105771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105771.Bytes);
public long this[int i]=>Value[i];

public static A105771Inst Instance=new A105771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105772
{
public static readonly long[] Value={ 0L,3L,5L,11L,15L,21L,23L,27L,33L,45L,47L,51L,53L,57L,63L,65L,71L,77L,81L,93L,101L,107L,117L,123L,125L,131L,135L,147L,155L,161L,167L,173L,183L,185L,195L,197L,201L,203L,207L,213L,221L,231L,251L,255L,257L,267L,273L,285L,287L,291L,293L,297L,305L,311L,315L,317L,333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105772Inst : IEnumerable<long>
{
public static readonly long[] Value=A105772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105772.Bytes);
public long this[int i]=>Value[i];

public static A105772Inst Instance=new A105772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105773
{
public static readonly long[] Value={ 0L,6L,12L,14L,20L,26L,32L,50L,54L,60L,66L,74L,80L,84L,90L,92L,96L,110L,116L,122L,126L,132L,134L,140L,150L,162L,164L,174L,182L,186L,200L,204L,216L,222L,234L,236L,246L,260L,264L,266L,270L,272L,284L,294L,306L,312L,320L,330L,336L,344L,350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105773Inst : IEnumerable<long>
{
public static readonly long[] Value=A105773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105773.Bytes);
public long this[int i]=>Value[i];

public static A105773Inst Instance=new A105773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105774
{
public static readonly long[] Value={ 1L,1L,2L,4L,4L,7L,7L,6L,12L,12L,11L,9L,9L,20L,20L,19L,17L,17L,14L,14L,15L,33L,33L,32L,30L,30L,27L,27L,28L,22L,22L,23L,25L,25L,54L,54L,53L,51L,51L,48L,48L,49L,43L,43L,44L,46L,46L,35L,35L,36L,38L,38L,41L,41L,40L,88L,88L,87L,85L,85L,82L,82L,83L,77L,77L,78L,80L,80L,69L,69L,70L,72L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105774Inst : IEnumerable<long>
{
public static readonly long[] Value=A105774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105774.Bytes);
public long this[int i]=>Value[i];

public static A105774Inst Instance=new A105774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105775
{
public static readonly long[] Value={ 0L,6L,8L,20L,24L,38L,50L,56L,68L,78L,86L,90L,96L,104L,108L,114L,134L,138L,140L,146L,150L,164L,174L,180L,206L,216L,218L,224L,234L,240L,246L,258L,276L,288L,296L,314L,320L,336L,338L,348L,350L,356L,378L,380L,404L,414L,420L,426L,450L,474L,476L,510L,524L,530L,540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105775Inst : IEnumerable<long>
{
public static readonly long[] Value=A105775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105775.Bytes);
public long this[int i]=>Value[i];

public static A105775Inst Instance=new A105775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105776
{
public static readonly long[] Value={ 1L,22L,122L,212L,221L,333L,4444L,14444L,22333L,23233L,23323L,23332L,32233L,32323L,32332L,33223L,33232L,33322L,41444L,44144L,44414L,44441L,555555L,666666L,1666666L,2255555L,2525555L,2552555L,2555255L,2555525L,2555552L,3334444L,3343444L,3344344L,3344434L,3344443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105776Inst : IEnumerable<long>
{
public static readonly long[] Value=A105776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105776.Bytes);
public long this[int i]=>Value[i];

public static A105776Inst Instance=new A105776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105777
{
public static readonly long[] Value={ 1L,2L,2L,2L,1L,4L,3L,3L,3L,4L,4L,3L,3L,3L,4L,4L,3L,3L,3L,4L,1L,2L,2L,2L,1L,3L,4L,4L,4L,3L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,3L,4L,4L,4L,3L,3L,4L,4L,4L,3L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,3L,4L,4L,4L,3L,1L,2L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105777Inst : IEnumerable<long>
{
public static readonly long[] Value=A105777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105777.Bytes);
public long this[int i]=>Value[i];

public static A105777Inst Instance=new A105777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105778
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,4L,3L,4L,3L,4L,1L,2L,1L,2L,1L,4L,3L,4L,3L,4L,1L,2L,1L,2L,1L,3L,4L,3L,4L,3L,2L,1L,1L,1L,2L,3L,4L,3L,4L,3L,2L,1L,1L,1L,2L,3L,4L,3L,4L,3L,1L,2L,1L,2L,1L,4L,3L,4L,3L,4L,1L,2L,1L,2L,1L,4L,3L,4L,3L,4L,1L,2L,1L,2L,1L,3L,4L,3L,4L,3L,2L,1L,1L,1L,2L,3L,4L,3L,4L,3L,2L,1L,1L,1L,2L,3L,4L,3L,4L,3L,1L,2L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105778Inst : IEnumerable<long>
{
public static readonly long[] Value=A105778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105778.Bytes);
public long this[int i]=>Value[i];

public static A105778Inst Instance=new A105778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105779
{
public static readonly long[] Value={ 24L,48L,54L,144L,288L,384L,648L,972L,1260L,1728L,1792L,1936L,1944L,2304L,3584L,5184L,6250L,6912L,7168L,8748L,8788L,9216L,9604L,10000L,10125L,10816L,11760L,13122L,13824L,17640L,21632L,21952L,23328L,24255L,25088L,26244L,27648L,33264L,35937L,37752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105779Inst : IEnumerable<long>
{
public static readonly long[] Value=A105779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105779.Bytes);
public long this[int i]=>Value[i];

public static A105779Inst Instance=new A105779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105780
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,10L,14L,19L,26L,35L,46L,61L,79L,102L,131L,167L,211L,266L,333L,415L,515L,636L,782L,959L,1171L,1425L,1729L,2091L,2521L,3033L,3637L,4351L,5193L,6183L,7345L,8708L,10301L,12161L,14331L,16856L,19789L,23195L,27139L,31703L,36978L,43063L,50075L,58148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105780Inst : IEnumerable<long>
{
public static readonly long[] Value=A105780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105780.Bytes);
public long this[int i]=>Value[i];

public static A105780Inst Instance=new A105780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105781
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,6L,9L,12L,17L,23L,30L,40L,53L,68L,88L,113L,143L,181L,228L,284L,354L,439L,541L,665L,815L,993L,1208L,1465L,1769L,2132L,2563L,3070L,3671L,4379L,5209L,6185L,7329L,8663L,10223L,12041L,14153L,16609L,19459L,22755L,26571L,30979L,36059L,41915L,48654L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105781Inst : IEnumerable<long>
{
public static readonly long[] Value=A105781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105781.Bytes);
public long this[int i]=>Value[i];

public static A105781Inst Instance=new A105781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105782
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,6L,8L,11L,15L,20L,26L,34L,44L,56L,72L,91L,114L,144L,179L,222L,275L,338L,414L,507L,617L,748L,906L,1093L,1314L,1578L,1888L,2253L,2685L,3190L,3782L,4477L,5286L,6230L,7331L,8609L,10091L,11812L,13801L,16099L,18755L,21813L,25332L,29383L,34031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105782Inst : IEnumerable<long>
{
public static readonly long[] Value=A105782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105782.Bytes);
public long this[int i]=>Value[i];

public static A105782Inst Instance=new A105782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105783
{
public static readonly long[] Value={ 1L,0L,2L,0L,2L,0L,1L,2L,2L,1L,2L,0L,3L,0L,2L,1L,3L,1L,1L,2L,1L,1L,3L,1L,3L,2L,2L,1L,3L,2L,3L,1L,3L,1L,1L,1L,3L,2L,3L,2L,3L,1L,3L,1L,3L,1L,2L,2L,3L,3L,3L,2L,4L,1L,1L,3L,4L,2L,1L,0L,2L,1L,2L,0L,1L,2L,2L,3L,2L,3L,3L,1L,3L,1L,1L,2L,4L,1L,3L,3L,1L,1L,1L,4L,3L,2L,4L,3L,3L,3L,4L,1L,1L,2L,1L,0L,2L,3L,2L,0L,2L,0L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105783Inst : IEnumerable<long>
{
public static readonly long[] Value=A105783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105783.Bytes);
public long this[int i]=>Value[i];

public static A105783Inst Instance=new A105783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105784
{
public static readonly BigInteger[] Value={ 0L,1L,3L,19L,155L,1641L,21427L,334377L,6085683L,126745435L,2975448641L,77779634571L,2241339267037L,70604384569005L,2414086713172695L,89049201691604881L,3525160713653081279L,BigInteger.Parse("149075374211881719939"),BigInteger.Parse("6707440248292609651513"),BigInteger.Parse("319946143503599791200675") };
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
public class A105784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105784Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105784.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105784Inst Instance=new A105784Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105785
{
public static readonly BigInteger[] Value={ 1L,0L,2L,9L,76L,805L,10626L,167839L,3091768L,65127465L,1544951350L,40770052411L,1184951084340L,37616775522781L,1295202587597842L,48080003446006575L,1914305438178286576L,BigInteger.Parse("81379323738092982097"),BigInteger.Parse("3679128029385789284718"),BigInteger.Parse("176267238847686913800547") };
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
public class A105785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105785Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105785.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105785Inst Instance=new A105785Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105786
{
public static readonly long[] Value={ 0L,1L,0L,3L,0L,0L,16L,3L,0L,0L,125L,30L,0L,0L,0L,1296L,330L,15L,0L,0L,0L,16807L,4305L,315L,0L,0L,0L,0L,262144L,66248L,5880L,105L,0L,0L,0L,0L,4782969L,1183644L,115290L,3780L,0L,0L,0L,0L,0L,100000000L,24170310L,2467080L,107100L,945L,0L,0L,0L,0L,0L,2357947691L,556409535L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105786Inst : IEnumerable<long>
{
public static readonly long[] Value=A105786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105786.Bytes);
public long this[int i]=>Value[i];

public static A105786Inst Instance=new A105786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105787
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,28L,795L,632167L,399635138154L,BigInteger.Parse("159708243647367169100509"),BigInteger.Parse("25506723088926795724936617220833650734525459594"),BigInteger.Parse("650592922735191299575059973922272937442761432150679274453311138653498403940208837571053997389") };
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
public class A105787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105787Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105787.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105787Inst Instance=new A105787Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105788
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,16L,192L,29984L,776474136L,582837534997525192L,BigInteger.Parse("334033256143852482501323872038100184"),BigInteger.Parse("111432026121971983026248175426087984579225579894344486903683496908882296") };
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
public class A105788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105788Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105788.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105788Inst Instance=new A105788Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105789
{
public static readonly long[] Value={ 1L,2L,3L,2L,1L,4L,3L,2L,3L,4L,2L,1L,4L,1L,2L,4L,3L,2L,3L,4L,1L,2L,3L,2L,1L,3L,4L,1L,4L,3L,2L,1L,4L,1L,2L,4L,3L,2L,3L,4L,2L,1L,4L,1L,2L,3L,4L,1L,4L,3L,4L,3L,2L,3L,4L,1L,2L,3L,2L,1L,3L,4L,1L,4L,3L,1L,2L,3L,2L,1L,4L,3L,2L,3L,4L,3L,4L,1L,4L,3L,2L,1L,4L,1L,2L,4L,3L,2L,3L,4L,2L,1L,4L,1L,2L,3L,4L,1L,4L,3L,1L,2L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105789Inst : IEnumerable<long>
{
public static readonly long[] Value=A105789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105789.Bytes);
public long this[int i]=>Value[i];

public static A105789Inst Instance=new A105789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105790
{
public static readonly long[] Value={ 1L,4L,4L,6L,8L,9L,11L,13L,14L,16L,17L,19L,21L,23L,25L,26L,27L,30L,31L,33L,34L,36L,38L,40L,41L,43L,45L,46L,47L,49L,53L,53L,54L,56L,58L,60L,61L,62L,65L,66L,67L,70L,71L,72L,75L,76L,78L,80L,83L,83L,84L,87L,89L,89L,91L,93L,94L,96L,98L,99L,100L,103L,105L,107L,107L,109L,112L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105790Inst : IEnumerable<long>
{
public static readonly long[] Value=A105790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105790.Bytes);
public long this[int i]=>Value[i];

public static A105790Inst Instance=new A105790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105791
{
public static readonly long[] Value={ 1L,2L,4L,2L,1L,4L,3L,1L,3L,4L,3L,4L,2L,4L,3L,4L,3L,1L,3L,4L,1L,2L,4L,2L,1L,3L,4L,2L,4L,3L,2L,1L,3L,1L,2L,1L,2L,4L,2L,1L,2L,1L,3L,1L,2L,3L,4L,2L,4L,3L,2L,1L,3L,1L,2L,3L,4L,2L,4L,3L,4L,3L,1L,3L,4L,3L,4L,2L,4L,3L,2L,1L,3L,1L,2L,3L,4L,2L,4L,3L,2L,1L,3L,1L,2L,1L,2L,4L,2L,1L,2L,1L,3L,1L,2L,3L,4L,2L,4L,3L,1L,2L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105791Inst : IEnumerable<long>
{
public static readonly long[] Value=A105791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105791.Bytes);
public long this[int i]=>Value[i];

public static A105791Inst Instance=new A105791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105792
{
public static readonly long[] Value={ 2L,3L,7L,13L,19L,23L,31L,37L,43L,47L,53L,61L,67L,73L,79L,83L,89L,97L,103L,109L,113L,127L,131L,139L,151L,157L,163L,167L,173L,181L,193L,199L,211L,223L,229L,233L,241L,251L,257L,263L,271L,277L,283L,293L,307L,313L,317L,331L,337L,349L,353L,359L,367L,373L,379L,383L,389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105792Inst : IEnumerable<long>
{
public static readonly long[] Value=A105792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105792.Bytes);
public long this[int i]=>Value[i];

public static A105792Inst Instance=new A105792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105793
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,0L,-1L,0L,1L,0L,2L,-1L,-2L,1L,0L,-6L,5L,5L,-5L,1L,0L,24L,-26L,-15L,25L,-9L,1L,0L,-120L,154L,49L,-140L,70L,-14L,1L,0L,720L,-1044L,-140L,889L,-560L,154L,-20L,1L,0L,-5040L,8028L,-64L,-6363L,4809L,-1638L,294L,-27L,1L,0L,40320L,-69264L,8540L,50840L,-44835L,17913L,-3990L,510L,-35L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105793Inst : IEnumerable<long>
{
public static readonly long[] Value=A105793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105793.Bytes);
public long this[int i]=>Value[i];

public static A105793Inst Instance=new A105793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105794
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-1L,1L,-1L,1L,0L,1L,1L,-1L,1L,2L,1L,-1L,1L,0L,5L,5L,1L,1L,-1L,1L,10L,20L,9L,1L,-1L,1L,0L,21L,70L,56L,14L,1L,1L,-1L,1L,42L,231L,294L,126L,20L,1L,-1L,1L,0L,85L,735L,1407L,924L,246L,27L,1L,1L,-1L,1L,170L,2290L,6363L,6027L,2400L,435L,35L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105794Inst : IEnumerable<long>
{
public static readonly long[] Value=A105794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105794.Bytes);
public long this[int i]=>Value[i];

public static A105794Inst Instance=new A105794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105795
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,7L,21L,67L,237L,907L,3741L,16507L,77517L,385627L,2024301L,11174587L,64673997L,391392667L,2470864941L,16237279867L,110858862477L,784987938907L,5755734591981L,43636725010747L,341615028340557L,2758165832945947L,22940755633301421L,196354180631212027L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105795Inst : IEnumerable<long>
{
public static readonly long[] Value=A105795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105795.Bytes);
public long this[int i]=>Value[i];

public static A105795Inst Instance=new A105795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105796
{
public static readonly BigInteger[] Value={ 0L,1L,1L,13L,25L,541L,1561L,47293L,181945L,7087261L,34082521L,1622632573L,9363855865L,526858348381L,3547114323481L,230283190977853L,1771884893993785L,130370767029135901L,1128511554418948441L,BigInteger.Parse("92801587319328411133") };
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
public class A105796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105796Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105796.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105796Inst Instance=new A105796Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105797
{
public static readonly BigInteger[] Value={ 0L,1L,3L,19L,135L,1291L,14343L,188539L,2815095L,47412811L,886239783L,18231365659L,409053408855L,9943622273131L,260300948527623L,7300927107288379L,218426614502831415L,6943261704033434251L,BigInteger.Parse("233692323131307301863") };
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
public class A105797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105797Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105797.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105797Inst Instance=new A105797Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105798
{
public static readonly long[] Value={ 6L,8L,6L,1L,8L,9L,3L,2L,7L,3L,5L,5L,2L,3L,2L,9L,9L,3L,1L,3L,3L,2L,9L,1L,2L,9L,6L,9L,0L,6L,4L,8L,9L,5L,9L,1L,5L,1L,4L,7L,3L,0L,4L,2L,2L,5L,1L,2L,6L,8L,0L,7L,3L,2L,0L,0L,3L,1L,7L,1L,4L,8L,9L,8L,1L,5L,2L,5L,5L,0L,9L,1L,0L,1L,3L,3L,5L,2L,8L,7L,3L,5L,3L,7L,3L,7L,4L,8L,7L,9L,8L,7L,8L,4L,2L,5L,8L,1L,5L,6L,5L,8L,7L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105798Inst : IEnumerable<long>
{
public static readonly long[] Value=A105798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105798.Bytes);
public long this[int i]=>Value[i];

public static A105798Inst Instance=new A105798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105799
{
public static readonly long[] Value={ 2L,3L,4L,6L,8L,11L,13L,17L,19L,20L,21L,22L,24L,25L,26L,29L,31L,37L,41L,43L,47L,53L,59L,60L,62L,63L,64L,65L,66L,68L,69L,70L,72L,74L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,140L,141L,142L,143L,144L,145L,146L,147L,148L,150L,152L,153L,154L,155L,156L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105799Inst : IEnumerable<long>
{
public static readonly long[] Value=A105799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105799.Bytes);
public long this[int i]=>Value[i];

public static A105799Inst Instance=new A105799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105800
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,3L,2L,5L,1L,8L,1L,13L,5L,21L,1L,34L,1L,55L,13L,89L,1L,144L,5L,233L,34L,377L,1L,610L,1L,987L,89L,1597L,13L,2584L,1L,4181L,233L,6765L,1L,10946L,1L,17711L,610L,28657L,1L,46368L,13L,75025L,1597L,121393L,1L,196418L,89L,317811L,4181L,514229L,1L,832040L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105800Inst : IEnumerable<long>
{
public static readonly long[] Value=A105800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105800.Bytes);
public long this[int i]=>Value[i];

public static A105800Inst Instance=new A105800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105801
{
public static readonly long[] Value={ 1L,2L,10L,6L,8L,7L,46L,160L,103L,790L,2680L,1735L,13246L,44944L,29095L,222118L,753640L,487879L,3724558L,12637312L,8180935L,62454742L,211907032L,137180887L,1047263758L,3553333936L,2300298847L,17560898350L,59583591592L,38572244971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105801Inst : IEnumerable<long>
{
public static readonly long[] Value=A105801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105801.Bytes);
public long this[int i]=>Value[i];

public static A105801Inst Instance=new A105801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105802
{
public static readonly long[] Value={ 1L,3L,6L,15L,12L,45L,24L,36L,48L,405L,60L,315L,192L,144L,120L,945L,180L,1575L,240L,576L,3072L,295245L,360L,1296L,12288L,900L,960L,25515L,720L,14175L,840L,9216L,196608L,5184L,1260L,17325L,786432L,36864L,1680L,31185L,2880L,127575L,15360L,3600L,99225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105802Inst : IEnumerable<long>
{
public static readonly long[] Value=A105802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105802.Bytes);
public long this[int i]=>Value[i];

public static A105802Inst Instance=new A105802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105803
{
public static readonly long[] Value={ 4L,6L,8L,9L,11L,13L,17L,19L,23L,29L,30L,32L,33L,34L,35L,36L,38L,39L,41L,43L,47L,53L,59L,61L,67L,71L,73L,74L,75L,76L,77L,78L,80L,81L,82L,84L,85L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105803Inst : IEnumerable<long>
{
public static readonly long[] Value=A105803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105803.Bytes);
public long this[int i]=>Value[i];

public static A105803Inst Instance=new A105803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105804
{
public static readonly BigInteger[] Value={ 0L,1L,1L,3L,9L,42L,282L,2802L,42348L,984576L,35804724L,2056887084L,188218830732L,27582766315980L,6497743050809304L,2466474617607855408L,BigInteger.Parse("1510962789131940581928"),BigInteger.Parse("1495259232837545099449512"),BigInteger.Parse("2391833322688676458284572616"),BigInteger.Parse("6186748984680033744268134049416") };
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
public class A105804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105804Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105804.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105804Inst Instance=new A105804Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105805
{
public static readonly long[] Value={ 0L,1L,-1L,2L,0L,-2L,3L,1L,0L,-1L,-3L,4L,2L,1L,0L,-1L,-2L,-4L,5L,3L,2L,1L,1L,0L,-1L,-1L,-2L,-3L,-5L,6L,4L,3L,2L,2L,1L,0L,0L,0L,-1L,-2L,-2L,-3L,-4L,-6L,7L,5L,4L,3L,2L,3L,2L,1L,1L,0L,1L,0L,-1L,-1L,-2L,-1L,-2L,-3L,-3L,-4L,-5L,-7L,8L,6L,5L,4L,3L,4L,3L,2L,1L,2L,1L,0L,2L,1L,0L,0L,-1L,-1L,0L,-1L,-2L,-2L,-3L,-2L,-3L,-4L,-4L,-5L,-6L,-8L,9L,7L,6L,5L,4L,3L,5L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105805Inst : IEnumerable<long>
{
public static readonly long[] Value=A105805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105805.Bytes);
public long this[int i]=>Value[i];

public static A105805Inst Instance=new A105805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105806
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,2L,1L,1L,0L,1L,3L,1L,2L,1L,1L,0L,1L,2L,3L,2L,2L,1L,1L,0L,1L,4L,3L,3L,2L,2L,1L,1L,0L,1L,4L,5L,3L,4L,2L,2L,1L,1L,0L,1L,6L,5L,6L,3L,4L,2L,2L,1L,1L,0L,1L,7L,8L,6L,6L,4L,4L,2L,2L,1L,1L,0L,1L,11L,8L,9L,7L,6L,4L,4L,2L,2L,1L,1L,0L,1L,11L,13L,10L,10L,7L,7L,4L,4L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105806Inst : IEnumerable<long>
{
public static readonly long[] Value=A105806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105806.Bytes);
public long this[int i]=>Value[i];

public static A105806Inst Instance=new A105806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105807
{
public static readonly long[] Value={ 0L,1L,2L,4L,7L,12L,18L,29L,42L,61L,87L,125L,172L,235L,320L,437L,580L,759L,1002L,1329L,1718L,2191L,2784L,3624L,4633L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105807Inst : IEnumerable<long>
{
public static readonly long[] Value=A105807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105807.Bytes);
public long this[int i]=>Value[i];

public static A105807Inst Instance=new A105807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105808
{
public static readonly long[] Value={ 2L,3L,4L,6L,8L,22L,23L,44L,46L,48L,52L,53L,55L,57L,64L,72L,84L,222L,444L,452L,524L,644L,722L,723L,844L,852L,2222L,2244L,4442L,5444L,6422L,7444L,8422L,22444L,44222L,52224L,64444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105808Inst : IEnumerable<long>
{
public static readonly long[] Value=A105808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105808.Bytes);
public long this[int i]=>Value[i];

public static A105808Inst Instance=new A105808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105809
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,3L,4L,3L,1L,5L,7L,7L,4L,1L,8L,12L,14L,11L,5L,1L,13L,20L,26L,25L,16L,6L,1L,21L,33L,46L,51L,41L,22L,7L,1L,34L,54L,79L,97L,92L,63L,29L,8L,1L,55L,88L,133L,176L,189L,155L,92L,37L,9L,1L,89L,143L,221L,309L,365L,344L,247L,129L,46L,10L,1L,144L,232L,364L,530L,674L,709L,591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105809Inst : IEnumerable<long>
{
public static readonly long[] Value=A105809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105809.Bytes);
public long this[int i]=>Value[i];

public static A105809Inst Instance=new A105809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105810
{
public static readonly long[] Value={ 1L,-1L,1L,0L,-2L,1L,1L,2L,-3L,1L,-2L,-1L,5L,-4L,1L,3L,-1L,-6L,9L,-5L,1L,-4L,4L,5L,-15L,14L,-6L,1L,5L,-8L,-1L,20L,-29L,20L,-7L,1L,-6L,13L,-7L,-21L,49L,-49L,27L,-8L,1L,7L,-19L,20L,14L,-70L,98L,-76L,35L,-9L,1L,-8L,26L,-39L,6L,84L,-168L,174L,-111L,44L,-10L,1L,9L,-34L,65L,-45L,-78L,252L,-342L,285L,-155L,54L,-11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105810Inst : IEnumerable<long>
{
public static readonly long[] Value=A105810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105810.Bytes);
public long this[int i]=>Value[i];

public static A105810Inst Instance=new A105810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105811
{
public static readonly long[] Value={ 1L,-1L,0L,1L,-2L,3L,-4L,5L,-6L,7L,-8L,9L,-10L,11L,-12L,13L,-14L,15L,-16L,17L,-18L,19L,-20L,21L,-22L,23L,-24L,25L,-26L,27L,-28L,29L,-30L,31L,-32L,33L,-34L,35L,-36L,37L,-38L,39L,-40L,41L,-42L,43L,-44L,45L,-46L,47L,-48L,49L,-50L,51L,-52L,53L,-54L,55L,-56L,57L,-58L,59L,-60L,61L,-62L,63L,-64L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105811Inst : IEnumerable<long>
{
public static readonly long[] Value=A105811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105811.Bytes);
public long this[int i]=>Value[i];

public static A105811Inst Instance=new A105811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105812
{
public static readonly long[] Value={ 1L,0L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105812Inst : IEnumerable<long>
{
public static readonly long[] Value=A105812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105812.Bytes);
public long this[int i]=>Value[i];

public static A105812Inst Instance=new A105812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105813
{
public static readonly long[] Value={ 2L,23L,24L,44L,52L,55L,552L,563L,666L,672L,683L,772L,834L,922L,2223L,2456L,3333L,3423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105813Inst : IEnumerable<long>
{
public static readonly long[] Value=A105813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105813.Bytes);
public long this[int i]=>Value[i];

public static A105813Inst Instance=new A105813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105814
{
public static readonly long[] Value={ 12L,26L,42L,60L,80L,102L,126L,152L,180L,1110L,1232L,1356L,1482L,1610L,1740L,1872L,2006L,2142L,2280L,2420L,2562L,2706L,2852L,3000L,3150L,3302L,3456L,3612L,3770L,3930L,4092L,4256L,4422L,4590L,4760L,4932L,5106L,5282L,5460L,5640L,5822L,6006L,6192L,6380L,6570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105814Inst : IEnumerable<long>
{
public static readonly long[] Value=A105814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105814.Bytes);
public long this[int i]=>Value[i];

public static A105814Inst Instance=new A105814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105815
{
public static readonly long[] Value={ 2L,6L,6L,3L,5L,2L,5L,6L,3L,4L,8L,0L,6L,8L,5L,6L,5L,4L,4L,9L,8L,9L,4L,4L,6L,7L,3L,2L,7L,2L,1L,9L,5L,5L,1L,4L,5L,9L,9L,9L,2L,2L,9L,8L,2L,6L,8L,9L,2L,7L,2L,9L,3L,2L,9L,1L,4L,8L,3L,3L,7L,0L,5L,8L,6L,8L,0L,2L,3L,8L,8L,4L,8L,7L,9L,0L,3L,9L,3L,2L,9L,9L,3L,5L,6L,4L,3L,9L,6L,0L,5L,6L,8L,6L,4L,2L,4L,5L,5L,9L,9L,1L,4L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105815Inst : IEnumerable<long>
{
public static readonly long[] Value=A105815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105815.Bytes);
public long this[int i]=>Value[i];

public static A105815Inst Instance=new A105815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105816
{
public static readonly long[] Value={ 2L,1L,1L,1L,34L,1L,2L,2L,2L,1L,1L,5L,1L,1L,1L,1L,1L,1L,1L,9L,7L,1L,9L,1L,5L,1L,5L,1L,2L,7L,2L,2L,3L,5L,2L,1L,10L,8L,2L,3L,1L,1L,1L,12L,1L,1L,5L,4L,4L,2L,1L,1L,2L,2L,4L,13L,2L,2L,12L,3L,11L,15L,2L,2L,2L,23L,8L,1L,1L,3L,1L,2L,8L,19L,1L,5L,2L,7L,4L,1L,82L,22L,1L,1L,1L,2L,1L,1L,9L,1L,1L,1L,15L,8L,12L,2L,11L,1L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105816Inst : IEnumerable<long>
{
public static readonly long[] Value=A105816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105816.Bytes);
public long this[int i]=>Value[i];

public static A105816Inst Instance=new A105816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105817
{
public static readonly long[] Value={ 1L,6L,6L,1L,9L,8L,2L,4L,6L,2L,3L,2L,7L,8L,1L,1L,5L,5L,7L,9L,6L,7L,6L,0L,6L,0L,8L,1L,8L,1L,5L,1L,3L,1L,2L,9L,5L,0L,5L,6L,1L,6L,7L,5L,6L,2L,4L,6L,5L,0L,3L,5L,0L,0L,8L,2L,9L,9L,0L,6L,8L,0L,6L,7L,4L,3L,0L,6L,2L,9L,7L,2L,3L,5L,9L,8L,9L,5L,7L,3L,8L,1L,0L,8L,1L,7L,1L,6L,7L,0L,4L,1L,1L,0L,8L,4L,9L,2L,6L,6L,6L,9L,2L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105817Inst : IEnumerable<long>
{
public static readonly long[] Value=A105817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105817.Bytes);
public long this[int i]=>Value[i];

public static A105817Inst Instance=new A105817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105818
{
public static readonly long[] Value={ 1L,1L,1L,1L,23L,18L,1L,1L,1L,1L,1L,1L,2L,1L,22L,2L,1L,53L,1L,1L,10L,1L,1L,17L,2L,4L,1L,27L,1L,2L,422L,3L,3L,13L,12L,5L,28L,1L,3L,1L,2L,1L,3L,2L,4L,6L,6L,3L,5L,50L,1L,1L,6L,3L,2L,1L,118L,2L,1L,1L,2L,6L,1L,4L,1L,1L,5L,2L,3L,3L,16L,1L,4L,6L,2L,2L,22L,4L,3L,10L,1L,1L,49L,5L,1L,1L,12L,1L,1L,3L,13L,3L,10L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105818Inst : IEnumerable<long>
{
public static readonly long[] Value=A105818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105818.Bytes);
public long this[int i]=>Value[i];

public static A105818Inst Instance=new A105818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105819
{
public static readonly long[] Value={ 0L,2L,0L,9L,0L,0L,64L,12L,0L,0L,625L,180L,0L,0L,0L,7776L,2730L,120L,0L,0L,0L,117649L,46410L,3780L,0L,0L,0L,0L,2097152L,893816L,99120L,1680L,0L,0L,0L,0L,43046721L,19389384L,2600640L,90720L,0L,0L,0L,0L,0L,1000000000L,469532790L,71734320L,3654000L,30240L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105819Inst : IEnumerable<long>
{
public static readonly long[] Value=A105819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105819.Bytes);
public long this[int i]=>Value[i];

public static A105819Inst Instance=new A105819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105820
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,0L,2L,1L,0L,0L,3L,1L,0L,0L,0L,6L,3L,1L,0L,0L,0L,11L,5L,1L,0L,0L,0L,0L,23L,12L,3L,1L,0L,0L,0L,0L,47L,23L,6L,1L,0L,0L,0L,0L,0L,106L,52L,14L,3L,1L,0L,0L,0L,0L,0L,235L,110L,29L,6L,1L,0L,0L,0L,0L,0L,0L,551L,253L,68L,15L,3L,1L,0L,0L,0L,0L,0L,0L,1301L,570L,148L,31L,6L,1L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105820Inst : IEnumerable<long>
{
public static readonly long[] Value=A105820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105820.Bytes);
public long this[int i]=>Value[i];

public static A105820Inst Instance=new A105820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105821
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,2L,2L,1L,1L,0L,3L,3L,2L,1L,1L,0L,6L,6L,4L,2L,1L,1L,0L,11L,11L,7L,4L,2L,1L,1L,0L,23L,23L,14L,8L,4L,2L,1L,1L,0L,47L,46L,29L,15L,8L,4L,2L,1L,1L,0L,106L,99L,60L,32L,16L,8L,4L,2L,1L,1L,0L,235L,216L,128L,66L,33L,16L,8L,4L,2L,1L,1L,0L,551L,488L,284L,143L,69L,34L,16L,8L,4L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105821Inst : IEnumerable<long>
{
public static readonly long[] Value=A105821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105821.Bytes);
public long this[int i]=>Value[i];

public static A105821Inst Instance=new A105821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105822
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,4L,12L,7L,10L,17L,6L,11L,21L,32L,13L,19L,14L,33L,20L,28L,24L,27L,42L,40L,18L,9L,35L,44L,39L,54L,48L,22L,15L,37L,52L,89L,30L,59L,23L,36L,99L,70L,16L,86L,47L,45L,92L,65L,157L,34L,123L,135L,222L,56L,136L,82L,29L,53L,102L,155L,25L,130L,87L,43L,170L,213L,63L,150L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105822Inst : IEnumerable<long>
{
public static readonly long[] Value=A105822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105822.Bytes);
public long this[int i]=>Value[i];

public static A105822Inst Instance=new A105822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105823
{
public static readonly long[] Value={ 16L,49L,121L,144L,400L,256L,529L,576L,529L,784L,625L,1849L,2116L,2601L,1089L,2704L,2209L,4096L,2704L,3600L,4761L,6084L,4624L,1764L,2601L,2809L,7396L,11025L,10404L,7056L,3364L,3481L,4489L,15876L,14161L,21904L,6241L,9025L,10404L,19881L,11236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105823Inst : IEnumerable<long>
{
public static readonly long[] Value=A105823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105823.Bytes);
public long this[int i]=>Value[i];

public static A105823Inst Instance=new A105823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105824
{
public static readonly long[] Value={ 1L,3L,0L,3L,2L,0L,0L,3L,1L,2L,0L,0L,2L,0L,0L,3L,2L,3L,0L,2L,0L,0L,0L,0L,3L,2L,0L,0L,2L,0L,0L,3L,0L,2L,0L,3L,2L,0L,0L,2L,2L,0L,0L,0L,2L,0L,0L,0L,1L,1L,0L,2L,2L,0L,0L,0L,0L,2L,0L,0L,2L,0L,0L,3L,0L,0L,0L,2L,0L,0L,0L,3L,2L,2L,0L,0L,0L,0L,0L,2L,1L,2L,0L,0L,0L,0L,0L,0L,2L,2L,0L,0L,0L,0L,0L,0L,2L,3L,0L,1L,2L,0L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105824Inst : IEnumerable<long>
{
public static readonly long[] Value=A105824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105824.Bytes);
public long this[int i]=>Value[i];

public static A105824Inst Instance=new A105824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105825
{
public static readonly long[] Value={ 1L,3L,4L,2L,1L,2L,3L,0L,3L,3L,2L,3L,4L,4L,4L,1L,3L,4L,0L,2L,2L,1L,4L,0L,1L,2L,0L,1L,0L,2L,2L,3L,3L,4L,3L,1L,3L,0L,1L,0L,2L,1L,4L,4L,3L,2L,3L,4L,2L,3L,2L,3L,4L,0L,2L,0L,0L,0L,0L,3L,2L,1L,4L,2L,4L,4L,3L,1L,1L,4L,2L,0L,4L,4L,4L,0L,1L,3L,0L,1L,1L,1L,4L,4L,3L,2L,0L,0L,0L,4L,2L,3L,3L,4L,0L,2L,3L,1L,1L,2L,2L,1L,4L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105825Inst : IEnumerable<long>
{
public static readonly long[] Value=A105825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105825.Bytes);
public long this[int i]=>Value[i];

public static A105825Inst Instance=new A105825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105826
{
public static readonly long[] Value={ 1L,3L,4L,0L,6L,5L,1L,1L,6L,4L,5L,0L,0L,3L,3L,3L,4L,4L,6L,0L,4L,1L,3L,4L,3L,0L,5L,0L,2L,2L,4L,0L,6L,5L,6L,0L,3L,4L,0L,6L,0L,5L,2L,0L,1L,2L,6L,5L,1L,2L,2L,0L,5L,1L,2L,1L,3L,6L,4L,0L,6L,5L,6L,1L,0L,4L,5L,0L,5L,4L,2L,6L,4L,2L,5L,0L,5L,0L,3L,4L,2L,0L,0L,0L,3L,6L,1L,5L,6L,3L,0L,0L,2L,4L,1L,0L,0L,3L,2L,0L,4L,6L,6L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105826Inst : IEnumerable<long>
{
public static readonly long[] Value=A105826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105826.Bytes);
public long this[int i]=>Value[i];

public static A105826Inst Instance=new A105826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105827
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,4L,0L,7L,5L,2L,4L,4L,6L,0L,0L,7L,2L,7L,4L,2L,0L,4L,0L,4L,7L,2L,0L,0L,6L,0L,0L,7L,0L,6L,0L,3L,6L,4L,0L,2L,2L,0L,4L,4L,6L,0L,0L,4L,1L,5L,0L,2L,6L,0L,0L,0L,0L,2L,4L,0L,6L,0L,0L,7L,4L,0L,4L,6L,0L,0L,0L,3L,2L,2L,4L,4L,0L,0L,0L,2L,1L,6L,4L,0L,4L,4L,0L,4L,2L,2L,0L,0L,0L,0L,0L,4L,2L,3L,4L,1L,6L,0L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105827Inst : IEnumerable<long>
{
public static readonly long[] Value=A105827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105827.Bytes);
public long this[int i]=>Value[i];

public static A105827Inst Instance=new A105827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105828
{
public static readonly long[] Value={ 1L,3L,4L,7L,2L,5L,12L,9L,21L,8L,13L,6L,19L,11L,30L,41L,15L,26L,24L,50L,14L,36L,18L,10L,28L,38L,66L,20L,16L,48L,45L,93L,72L,165L,63L,102L,96L,198L,105L,23L,62L,85L,58L,27L,31L,46L,32L,78L,47L,43L,90L,117L,22L,95L,53L,42L,128L,40L,25L,65L,68L,124L,79L,129L,208L,100L,108L,184L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105828Inst : IEnumerable<long>
{
public static readonly long[] Value=A105828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105828.Bytes);
public long this[int i]=>Value[i];

public static A105828Inst Instance=new A105828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105829
{
public static readonly long[] Value={ 1L,4L,5L,6L,8L,14L,9L,18L,7L,11L,30L,41L,15L,26L,21L,17L,38L,39L,27L,12L,20L,13L,33L,46L,19L,2L,72L,74L,23L,51L,54L,96L,24L,36L,60L,56L,32L,78L,47L,10L,37L,65L,102L,167L,67L,100L,68L,59L,105L,164L,45L,119L,48L,71L,29L,42L,135L,132L,3L,129L,270L,351L,66L,40L,64L,90L,61L,53L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105829Inst : IEnumerable<long>
{
public static readonly long[] Value=A105829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105829.Bytes);
public long this[int i]=>Value[i];

public static A105829Inst Instance=new A105829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105830
{
public static readonly long[] Value={ 1L,5L,6L,8L,14L,4L,10L,24L,18L,15L,3L,12L,36L,21L,2L,19L,33L,52L,28L,27L,55L,78L,16L,62L,35L,87L,54L,141L,25L,46L,71L,42L,29L,13L,90L,7L,26L,45L,50L,80L,40L,75L,115L,58L,57L,43L,44L,84L,53L,22L,31L,60L,91L,37L,20L,17L,63L,110L,32L,96L,56L,132L,108L,135L,138L,61L,65L,114L,143L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105830Inst : IEnumerable<long>
{
public static readonly long[] Value=A105830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105830.Bytes);
public long this[int i]=>Value[i];

public static A105830Inst Instance=new A105830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105831
{
public static readonly long[] Value={ 1L,6L,7L,3L,4L,15L,19L,8L,11L,10L,21L,13L,18L,16L,2L,5L,12L,9L,30L,24L,54L,33L,17L,26L,43L,28L,71L,39L,32L,55L,87L,46L,25L,66L,27L,93L,22L,56L,78L,23L,31L,114L,40L,74L,36L,38L,68L,106L,60L,166L,42L,124L,110L,14L,48L,62L,85L,58L,143L,86L,57L,29L,140L,169L,51L,118L,45L,52L,76L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105831Inst : IEnumerable<long>
{
public static readonly long[] Value=A105831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105831.Bytes);
public long this[int i]=>Value[i];

public static A105831Inst Instance=new A105831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105832
{
public static readonly long[] Value={ 1L,7L,8L,12L,20L,13L,15L,22L,5L,3L,2L,16L,18L,9L,14L,23L,10L,33L,19L,52L,71L,21L,50L,39L,11L,28L,64L,60L,4L,17L,42L,27L,24L,35L,26L,48L,74L,30L,44L,32L,51L,83L,38L,45L,62L,56L,6L,36L,96L,57L,153L,54L,99L,63L,86L,80L,166L,85L,81L,46L,127L,75L,202L,69L,133L,136L,165L,91L,114L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105832Inst : IEnumerable<long>
{
public static readonly long[] Value=A105832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105832.Bytes);
public long this[int i]=>Value[i];

public static A105832Inst Instance=new A105832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105833
{
public static readonly long[] Value={ 1L,8L,9L,14L,23L,10L,13L,3L,16L,12L,4L,5L,6L,11L,2L,40L,42L,27L,15L,22L,37L,24L,61L,33L,28L,45L,7L,38L,77L,48L,20L,50L,30L,36L,66L,26L,92L,118L,82L,200L,138L,47L,31L,78L,109L,35L,74L,57L,17L,124L,96L,79L,135L,46L,21L,25L,34L,32L,72L,44L,116L,69L,95L,86L,153L,98L,55L,43L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105833Inst : IEnumerable<long>
{
public static readonly long[] Value=A105833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105833.Bytes);
public long this[int i]=>Value[i];

public static A105833Inst Instance=new A105833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105834
{
public static readonly long[] Value={ 1L,9L,10L,16L,8L,3L,5L,2L,7L,4L,11L,15L,14L,29L,18L,47L,21L,26L,32L,40L,12L,28L,17L,6L,23L,13L,36L,49L,46L,95L,50L,45L,35L,80L,75L,155L,22L,69L,76L,33L,43L,20L,63L,68L,91L,27L,64L,51L,115L,44L,71L,34L,37L,62L,24L,38L,25L,48L,73L,70L,143L,60L,83L,19L,102L,72L,30L,42L,144L,96L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105834Inst : IEnumerable<long>
{
public static readonly long[] Value=A105834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105834.Bytes);
public long this[int i]=>Value[i];

public static A105834Inst Instance=new A105834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105835
{
public static readonly long[] Value={ 1L,10L,11L,6L,5L,4L,9L,13L,22L,8L,14L,15L,26L,21L,17L,30L,47L,19L,28L,20L,33L,27L,60L,7L,2L,24L,56L,34L,12L,46L,36L,82L,50L,32L,18L,45L,38L,35L,3L,54L,57L,25L,42L,16L,58L,63L,106L,40L,66L,43L,23L,126L,72L,104L,70L,61L,39L,100L,51L,49L,156L,160L,31L,129L,130L,144L,162L,81L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105835Inst : IEnumerable<long>
{
public static readonly long[] Value=A105835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105835.Bytes);
public long this[int i]=>Value[i];

public static A105835Inst Instance=new A105835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105836
{
public static readonly long[] Value={ 2L,3L,5L,8L,4L,12L,7L,10L,17L,6L,11L,21L,32L,13L,19L,14L,33L,20L,28L,24L,27L,42L,40L,18L,1L,39L,82L,72L,154L,43L,35L,78L,56L,22L,9L,31L,70L,69L,52L,25L,48L,73L,46L,119L,57L,26L,15L,36L,51L,50L,101L,60L,41L,54L,95L,61L,16L,45L,76L,121L,62L,59L,130L,141L,81L,222L,63L,87L,30L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105836Inst : IEnumerable<long>
{
public static readonly long[] Value=A105836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105836.Bytes);
public long this[int i]=>Value[i];

public static A105836Inst Instance=new A105836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105837
{
public static readonly BigInteger[] Value={ 1L,131L,529L,52139L,210541L,20751191L,83794789L,8258921879L,33350115481L,3287030156651L,13273262166649L,1308229743425219L,5282724992210821L,520672150853080511L,2102511273637740109L,BigInteger.Parse("207226207809782618159"),BigInteger.Parse("836794204182828352561") };
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
public class A105837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105837Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105837.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105837Inst Instance=new A105837Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105838
{
public static readonly BigInteger[] Value={ 0L,39L,159L,15720L,63480L,6256719L,25265079L,2490158640L,10055438160L,991076882199L,4002039122799L,394446108956760L,1592801515436040L,156988560287908479L,633931001104421319L,BigInteger.Parse("62481052548478618080"),BigInteger.Parse("252302945638044249120"),BigInteger.Parse("24867301925734202087559") };
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
public class A105838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105838Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105838.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105838Inst Instance=new A105838Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105839
{
public static readonly BigInteger[] Value={ 1L,37L,2927L,68171L,183769L,4280053L,338355383L,7880431259L,21243328861L,494765566657L,39113205561107L,910962092609711L,2455686329490109L,57193909970135833L,4521408336114491603L,BigInteger.Parse("105305395973616940919"),BigInteger.Parse("283872428295154291321"),BigInteger.Parse("6611501604232996456477") };
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
public class A105839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105839Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A105839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105839.Bytes);
public BigInteger this[int i]=>Value[i];

public static A105839Inst Instance=new A105839Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A105840
{
public static readonly long[] Value={ 2L,11L,17L,23L,31L,37L,41L,47L,59L,67L,71L,73L,79L,83L,89L,97L,101L,103L,109L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,191L,197L,199L,211L,223L,227L,233L,239L,241L,257L,263L,269L,271L,277L,281L,283L,293L,307L,311L,313L,331L,347L,349L,353L,359L,367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A105840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A105840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A105840Inst : IEnumerable<long>
{
public static readonly long[] Value=A105840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A105840.Bytes);
public long this[int i]=>Value[i];

public static A105840Inst Instance=new A105840Inst();

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